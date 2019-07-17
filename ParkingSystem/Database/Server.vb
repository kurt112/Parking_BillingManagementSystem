Imports System.Data.SQLite
Imports Bunifu.Framework.UI
Imports ParkingSystem

Public Class Server

#Region "Object and Variable"
    Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim fileName As String = "Parking_Database.db"

    Dim fullPath As String = System.IO.Path.Combine(location, fileName)

    Public connectionString As String = String.Format("Data Source = {0}", fullPath)
    Private table As BunifuCustomDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid
    Private _member As Membership



#End Region

#Region "Getter and Setter"
    Public Property Table1 As BunifuCustomDataGrid
        Get
            Return table
        End Get
        Set(value As BunifuCustomDataGrid)
            table = value
        End Set
    End Property

    Public Property Member1 As Membership
        Get
            Return _member
        End Get
        Set(value As Membership)
            _member = value
        End Set
    End Property

#End Region

#Region "For Table Query String"
    Dim Create_User_Table_Statement As String = "CREATE TABLE 'USER'(
	                                          'USER_ID'	TEXT Not NULL UNIQUE,
	                                          'FIRST_NAME'   TEXT,
	                                          'LAST_NAME'	 TEXT,
	                                          'USER_NAME'	 TEXT,
	                                          'EMAIL' 	     TEXT,
	                                          'PASSWORD'	 TEXT,
	                                          'DATE_CREATED' TEXT,
	                                          'STATUS'	TEXT,
	                                          PRIMARY KEY('USER_ID')
                                              );"

    Dim Create_Area_Table_Statement As String = "CREATE TABLE 'PARKING_AREA'(
	                                             'AREA_ID'	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                             'PARKING_NAME'	TEXT,
	                                             'PARKING_LEVEL'	TEXT,
	                                             'PARKING_RATE'	TEXT);"

    Dim Create_User_History_Table_Statment As String = "CREATE TABLE 'USER_HISTORY' (
                                                  'USER_ID'	 TEXT,
	                                              'TIME_IN'	 TEXT,
	                                              'TIME_OUT' TEXT,
	                                              'SESSION'	 TEXT,
	                                              'Date'	 TEXT);"

    Dim Create_Promo_Table_Statemet As String = "CREATE TABLE 'PROMO' (
                                            	'ID'	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                            'NAME'	TEXT,
	                                            'DURATION'	TEXT,
	                                            'DESCRIPTION'	TEXT,
	                                            'PROMOEND'	TEXT,
	                                            'PRICE'	TEXT,
	                                            'STATUS'	TEXT
                                                );"
    Dim Create_Membership_Table_Statement As String = "CREATE TABLE 'MEMBERSHIP' (
                                                      'MEMBER_ID' Integer UNIQUE,
	                                                  'FIRST_NAME'	TEXT,
	                                                  'LAST_NAME'	TEXT,
	                                                  'EMAIL_ADDRESS'	TEXT,
	                                                  'CELLPHONENUMBER'	TEXT,
                                                      'TELEPHONENUMBER'	TEXT,
	                                                  'DATE_OF_BIRTH'	TEXT,
	                                                  'INITIAL_AMOUNT'	TEXT,
                                                      'LOGIN_TIMES'	TEXT,
	                                                  'POINTS'	TEXT,
	                                                  'LAST_PARKING'	TEXT,
	                                                  'MEMBERSHIP_LEVEL'	TEXT,
	                                                  'CASHIER_REGISTERED'	TEXT,
	                                                  'DATE_REGISTERED'	TEXT,
	                                                  'TOTAL_SPEND'	TEXT,
                                                      'PROMO_ACTIVATE'	TEXT,                                                     
                                                      'PLACE_OF_BIRTH'	TEXT,
                                                      'PERSON_TO_CONTACT'	TEXT,
	                                                  'PERSON_TO_CONTACT_NUMBER'	TEXT,
	                                                  'PHOTO'	TEXT
                                                      PRIMARY KEY('MEMBER_ID')
                                                      );"

    Private Create_promo_history_table_query As String = "CREATE TABLE 'PROMO_HISOTRY' (
	                                               'PROMO_ID'	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                               'MEMBER_ID'	TEXT,
	                                               'PROMO_NAME'	TEXT,
	                                               'LOCATION'	TEXT,
	                                               'PROMO_REGISTERED' TEXT,
	                                               'PROMO_ENDS'	TEXT,
                                                   'PROMO_ACTIVE'	TEXT);"
#End Region

#Region "Connection To the database"
    Private Function duplicateDataBase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Public Sub Connection_Query(ByVal Statement As String)

        Using Sqlconn As New SQLiteConnection(connectionString)

            Dim cmd As New SQLiteCommand(Statement, Sqlconn)

            Sqlconn.Open()
            cmd.ExecuteNonQuery()
            Sqlconn.Close()


        End Using

    End Sub

    Public Sub createDatabase()

        If Not duplicateDataBase(fullPath) Then

            Connection_Query(Create_User_Table_Statement)
            Connection_Query(Create_User_History_Table_Statment)
            Connection_Query(Create_Area_Table_Statement)
            Connection_Query(Create_Promo_Table_Statemet)
            Connection_Query(Create_Membership_Table_Statement)
            Connection_Query(Create_promo_history_table_query)
        End If
    End Sub

#End Region
#Region "For users Query"
    Public Function Register_User(ByVal Id As String, ByVal first_name As String,
                              ByVal LastName As String, ByVal UserName As String,
                             ByVal Email As String, ByVal Password As String,
                             ByVal Date_Created As String, ByVal Status As String) As Boolean

        Try

            Dim register_statement As String = "INSERT INTO USER VALUES('" + Id + "' , '" + first_name + "' , '" + LastName + "' , '" +
                UserName + "' , '" + Email + "' , '" + Password + "' , '" + Date_Created + "', '" + Status + "')"

            Connection_Query(register_statement)

            MessageBox.Show("User Register Succesful")

            Return True

        Catch ex As Exception
            MessageBox.Show("The Id has a duplicate")
        End Try


        Return False
    End Function


    'Start of user Query'
    '------------------------------------------------------------------------------------------------------------'

    Public Function User_Login(ByVal username As String, ByVal password As String, ByVal login As Login) As Boolean

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT * FROM USER WHERE USER_NAME = '" + username + "' AND PASSWORD = '" + password + "' LIMIT 1"

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr

                    While (rdr.Read())

                        Dim id As String = rdr.GetString(0)
                        Dim firstname As String = rdr.GetString(1)
                        Dim lastname As String = rdr.GetString(2)
                        Dim user_name As String = rdr.GetString(3)

                        Dim time_start As DateTime = New DateTime
                        time_start = Convert.ToDateTime(DateTime.Now)

                        login.User1 = New User_History(id, firstname, lastname, user_name, time_start.ToString, "", "", Date.Now.ToString("MM/dd/yyyy"))

                        con.Close()

                        Return True
                    End While

                End Using


            End Using


            con.Close()

        End Using


        Return False

    End Function

    '------------------------------------------------------------------------------------------------------------'

    Public Sub User_Table(ByVal table As Bunifu.Framework.UI.BunifuCustomDataGrid)

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand("SELECT * FROM USER WHERE STATUS = 'Active' ", con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    Dim id As String = reader.GetString(0)
                    Dim first_name As String = reader.GetString(1)
                    Dim last_name As String = reader.GetString(2)
                    Dim user_name As String = reader.GetString(3)
                    Dim email As String = reader.GetString(4)
                    Dim password As String = reader.GetString(5)
                    Dim date_Created As String = reader.GetString(6)
                    Dim status As String = reader.GetString(7)

                    table.Rows.Add(id, first_name, last_name, user_name, email, password, date_Created, status)

                End While

            End Using
            con.Close()
        End Using
    End Sub

    '------------------------------------------------------------------------------------------------------------'
    Public Function Add_User_History(ByVal user_history As User_History) As Boolean

        Try

            Dim register_statement As String = "INSERT INTO USER_HISTORY VALUES('" + user_history.Id1 + "' , '" + user_history.Time_in1 + "' , '" + user_history.Time_out1 + "' , '" +
                user_history.Session1 + "' , '" + user_history.Date_1 + "')"

            Connection_Query(register_statement)

            Return True

        Catch ex As Exception

            MessageBox.Show("Can't add to history")

        End Try


        Return False
    End Function

    '------------------------------------------------------------------------------------------------------------'
    Public Function User_History_Table(ByVal table1 As Bunifu.Framework.UI.BunifuCustomDataGrid, ByVal text As String) As Boolean
        table1.Rows.Clear()

        Dim query As String
        If (text = "") Then
            query = "SELECT USER.USER_ID, USER.FIRST_NAME, USER.LAST_NAME, USER.USER_NAME, USER_HISTORY.TIME_IN, USER_HISTORY.TIME_OUT, USER_HISTORY.SESSION, USER_HISTORY.DATE
                     FROM [USER] INNER JOIN USER_HISTORY ON USER.[USER_ID] = USER_HISTORY.[USER_ID];"

        Else
            query = "SELECT USER.USER_ID, USER.FIRST_NAME, USER.LAST_NAME, USER.USER_NAME, USER_HISTORY.TIME_IN, USER_HISTORY.TIME_OUT, USER_HISTORY.SESSION, USER_HISTORY.DATE 
                               FROM [USER] INNER JOIN USER_HISTORY ON USER.[USER_ID] = USER_HISTORY.[USER_ID] WHERE USER.USER_ID like '" + text + "%' Or USER.FIRST_NAME like '" + text + "%'
                               Or USER.LAST_NAME like '" + text + "%' Or USER.USER_NAME like '" + text + "%' Or USER_HISTORY.TIME_IN like '" + text + "%'Or USER_HISTORY.TIME_OUT like '" + text + "%' Or USER_HISTORY.SESSION like '" + text + "%'
                               Or USER_HISTORY.DATE like '" + text + "%';"

        End If



        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    Dim id As String = reader.GetString(0)
                    Dim first_name As String = reader.GetString(1)
                    Dim last_name As String = reader.GetString(2)
                    Dim user_name As String = reader.GetString(3)
                    Dim time_in As String = reader.GetString(4)
                    Dim time_out As String = reader.GetString(5)
                    Dim session As String = reader.GetString(6)
                    Dim date_ As String = reader.GetString(7)

                    table1.Rows.Add(id, first_name, last_name, user_name, time_in, time_out, session, date_)

                End While

            End Using
            con.Close()
        End Using


        Return False
    End Function

    'End of user Query'
    '------------------------------------------------------------------------------------------------------------'

#End Region
#Region "For Parking Query"

    'Start of Parking Query'


    Public Sub Update_location_Available(name As String)
        Dim Update_Location_Status As String = "UPDATE PARKING_AREA SET PARKING_STATUS = 'Available' WHERE PARKING_NAME ='" + name + "'"
        Connection_Query(Update_Location_Status)

    End Sub

    Public Function location_price(name As String) As Integer

        Dim price As Integer = 0

        Dim query As String = "SELECT PARKING_AREA.PARKING_RATE FROM PARKING_AREA where PARKING_NAME = '" + name + "' LIMIT 1"

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    price = CInt(reader.GetString(0))

                End While
            End Using
            con.Close()
        End Using
        Dim Update_Location_Status As String = "UPDATE PARKING_AREA SET PARKING_STATUS = 'Not Available' WHERE PARKING_NAME ='" + name + "'"
        Connection_Query(Update_Location_Status)
        Return price


    End Function

    Public Function generate_Location() As String
        Dim location As String = ""

        Dim query As String = "SELECT PARKING_AREA.PARKING_NAME FROM PARKING_AREA WHERE PARKING_AREA.PARKING_STATUS = 'Available' ORDER BY PARKING_AREA.PARKING_NAME ASC LIMIT 1"

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    location = reader.GetString(0)

                End While
            End Using
            con.Close()
        End Using

        Return location
    End Function

    Public Function Parking_Location() As String
        Dim location As String = ""
        Dim query As String = "SELECT PARKING_AREA.PARKING_NAME FROM PARKING_AREA  WHERE PARKING_AREA.PARKING_STATUS = 'Available'  ORDER By PARKING_AREA.PARKING_NAME LIMIT 1"

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    location = reader.GetString(1)

                End While
            End Using
            con.Close()
        End Using


        Return location
    End Function
    '------------------------------------------------------------------------------------------------------------'
    Public Function Add_ParkingArea(ByVal parking As Parking_Area) As Boolean

        Dim add_query As String = "INSERT INTO PARKING_AREA (PARKING_NAME, PARKING_LEVEL, PARKING_RATE, PARKING_STATUS) VALUES('" + parking.Parking_name1 + "' , '" + parking.Parking_level1 + "' , '" +
                parking.Parking_Rate1 + "' , '" + parking.Parking_Status1 + "')"

        Connection_Query(add_query)

        MessageBox.Show("Succesful Added")
        Return False
    End Function
    Public Sub Add_Parking_Price_Combobox(ByVal items_price As List(Of String))
        items_price.Clear()
        Dim query As String = "SELECT PARKING_AREA.PARKING_RATE FROM PARKING_AREA;"
        Using Conn As New SQLiteConnection(connectionString)

            Conn.Open()

            Using commands As New SQLiteCommand(query, Conn)

                Dim reader As SQLiteDataReader = commands.ExecuteReader

                While (reader.Read())

                    Dim parking_rate As String = reader.GetString(0)

                    items_price.Add(parking_rate)

                End While

            End Using

            Conn.Close()
        End Using

    End Sub

    Public Sub Add_Parking_Level_Combobox(ByVal items_level As List(Of String))
        items_level.Clear()
        Dim query As String = "SELECT PARKING_AREA.PARKING_LEVEL FROM PARKING_AREA;"

        Using Conn As New SQLiteConnection(connectionString)

            Conn.Open()

            Using commands As New SQLiteCommand(query, Conn)

                Dim reader As SQLiteDataReader = commands.ExecuteReader

                While (reader.Read())

                    Dim parking_level As String = reader.GetString(0)
                    items_level.Add(parking_level)


                End While

            End Using

            Conn.Close()
        End Using

    End Sub

    Public Sub Parking_Table(ByVal text As String)
        Table1.Rows.Clear()
        Dim query As String
        If Not (text.Equals("")) Then
            query = "SELECT * FROM PARKING_AREA WHERE PARKING_NAME LIKE '%" + text + "%' OR PARKING_LEVEL LIKE '%" + text + "%' OR PARKING_RATE LIKE '%" + text + "%' OR PARKING_STATUS LIKE'%" + text + "%' ORDER BY PARKING_NAME ASC"
        Else
            query = "SELECT * FROM PARKING_AREA  ORDER BY PARKING_NAME ASC"
        End If
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    Dim id As String = reader.GetInt64(0).ToString
                    Dim parking_name As String = reader.GetString(1)
                    Dim parking_level As String = reader.GetString(2)
                    Dim parking_rate As String = reader.GetString(3)
                    Dim status As String = reader.GetString(4)
                    'MessageBox.Show(id)
                    table.Rows.Add(id, parking_name, parking_level, parking_rate, status)
                End While
            End Using
            con.Close()
        End Using
    End Sub
    'End of Parking Query '
    '------------------------------------------------------------------------------------------------------------'

#End Region
     
#Region "Promo Query"
    'Start of Promo Query'
    '------------------------------------------------------------------------------------------------------------'
    Public Sub InsertPromo(ByVal promo As Promo)
        Dim add_query As String = "INSERT INTO PROMO (NAME,DURATION,DESCRIPTION,PROMOEND,PRICE,STATUS) VALUES('" + promo.Name1 + "' , '" + promo.Duration1 + "' , '" +
             promo.Description1 + "' , '" + promo.Ends1 + "', '" + promo.Price1 + "', 'ACTIVE')"

        Connection_Query(add_query)

        MessageBox.Show("Succesful Added")
    End Sub

    Public Sub Promo_Table(ByVal text As String)

        Table1.Rows.Clear()
        Dim query As String

        If Not (text.Equals("")) Then
            query = "SELECT * FROM PROMO WHERE NAME LIKE '%" + text + "%' OR DURATION LIKE '%" + text + "%' OR DESCRIPTION LIKE '" + text + "%' OR PROMOEND LIKE'" + text + "%' OR PRICE LIKE '%" + text + "%' OR STATUS LIKE '%" + text + "%' ORDER BY NAME ASC"
        Else
            query = "SELECT * FROM PROMO  ORDER BY NAME ASC"
        End If
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    Dim id As String = reader.GetInt64(0).ToString
                    Dim name As String = reader.GetString(1)
                    Dim duration As String = reader.GetString(2)
                    Dim description As String = reader.GetString(3)
                    Dim promoend As String = reader.GetString(4)
                    Dim price As String = reader.GetString(5)
                    Dim status As String = reader.GetString(6)

                    'MessageBox.Show(id)
                    table.Rows.Add(id, name, duration, description, promoend, price, status)
                End While
            End Using
            con.Close()
        End Using
    End Sub

    Public Sub Promo_Combobox(ByVal combobox As Bunifu.Framework.UI.BunifuDropdown)
        combobox.Clear()
        Dim query As String = "SELECT * FROM PROMO  ORDER BY NAME ASC"

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    Dim name As String = reader.GetString(1)

                    combobox.AddItem(name)

                End While
            End Using
            con.Close()
        End Using
    End Sub

    Public Function Promo_Price(ByVal value As String) As Integer
        Dim price As Integer = 0
        If (value = "Promo") Then
            Return 0
        Else
            Dim query As String = "SELECT PROMO.PRICE FROM PROMO WHERE NAME = '" + value + "'LIMIT 1"

            Using con As New SQLiteConnection(connectionString)

                con.Open()

                Using cmd As New SQLiteCommand(query, con)

                    Dim reader As SQLiteDataReader = cmd.ExecuteReader


                    While (reader.Read())

                        price = CInt(reader.GetString(0))

                    End While
                End Using
                con.Close()
                Return CInt(price)

            End Using
        End If
        Return 0
    End Function

    'End of Promo Query'
    '------------------------------------------------------------------------------------------------------------'

#End Region

#Region "Membership Query"
    'Start Membership Query '
    '------------------------------------------------------------------------------------------------------------'
    Public Sub Update_Promo(member As String, value As String)

        Dim Update_Promo_StatusQuery As String = "UPDATE MEMBERSHIP SET PROMO_ACTIVATE = '" + value + "' WHERE MEMBER_ID = '" + member + "'"
        Connection_Query(Update_Promo_StatusQuery)

    End Sub

    Public Sub MembershipTable(ByVal table As Bunifu.Framework.UI.BunifuCustomDataGrid)
        table.Rows.Clear()

        Dim query As String = "SELECT * FROM MEMBERSHIP ORDER BY LAST_NAME ASC"

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    Dim member_id As String = reader.GetInt64(0).ToString
                    Dim first_name As String = reader.GetString(1)
                    Dim last_name As String = reader.GetString(2)
                    Dim email_address As String = reader.GetString(3)
                    Dim cellphone_number As String = reader.GetString(4)
                    Dim phone_number As String = reader.GetString(5)
                    Dim date_of_birth As String = reader.GetString(6)
                    Dim place_of_birth As String = reader.GetString(7)
                    Dim person_to_contact As String = reader.GetString(8)
                    Dim person_to_contact_number As String = reader.GetString(9)
                    Dim photo As String = reader.GetString(10)
                    Dim initital_amount As String = reader.GetString(11)
                    Dim login_times As String = reader.GetString(12)
                    Dim points As String = reader.GetString(13)
                    Dim last_parking As String = reader.GetString(14)
                    Dim membership_level As String = reader.GetString(15)
                    Dim cashier_registered As String = reader.GetString(16)
                    Dim date_registered As String = reader.GetString(17)
                    Dim total_spend As String = reader.GetString(18)

                    'MessageBox.Show(id)
                    table.Rows.Add(member_id, last_name, first_name, email_address, cellphone_number,
                                   phone_number, date_of_birth, place_of_birth, person_to_contact, person_to_contact_number,
                                   photo, initital_amount, login_times, points, last_parking, membership_level, cashier_registered,
                                   date_registered, total_spend)
                End While
            End Using
            con.Close()
        End Using



    End Sub

    Public Function Membership_Register(ByVal member As Membership) As Boolean
        'Dim query As String = "INSERT INTO MEMBERSHIP VALUES(55, 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt', 'kurt')"

        Dim register_statement As String = "INSERT INTO MEMBERSHIP VALUES('" +
                        member.Member_id1 + "' , '" + member.First_name1 +
                     "' , '" + member.Last_name1 + "' , '" + member.Email_address1 +
                       "' , '" + member.Cellphone_number1 + "' , '" + member.Phone_number1 +
                      "' , '" + member.Date_of_birth1 + "' , '" + member.Initital_amount1 +
                  "' , '" + member.Login_times1 + "' , '" + member.Points1 +
                 "' , '" + member.Last_parking1 + "' , '" + member.Membership_level1 +
                "' , '" + member.Cashier_registered1 + "' , '" + member.Date_registered1 +
               "' , '" + member.Total_spend1 + "')"

        Connection_Query(register_statement)

        MessageBox.Show("Succesful")

        Return True


        Return False
    End Function

    Public Function Member_query(ByVal text As String, ByVal members As Membership) As Boolean
        Dim query As String = "SELECT * FROM MEMBERSHIP WHERE MEMBER_ID = '" + text + "' LIMIT 1"

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())
                    members.Member_id1 = reader.GetInt64(0).ToString
                    members.First_name1 = reader.GetString(1)
                    members.Last_name1 = reader.GetString(2)
                    members.Email_address1 = reader.GetString(3)
                    members.Cellphone_number1 = reader.GetString(4)
                    members.Phone_number1 = reader.GetString(5)
                    members.Date_of_birth1 = reader.GetString(6)
                    members.Initital_amount1 = reader.GetString(7)
                    members.Login_times1 = reader.GetString(8)
                    members.Points1 = reader.GetString(9)
                    members.Last_parking1 = reader.GetString(10)
                    members.Membership_level1 = reader.GetString(11)
                    members.Cashier_registered1 = reader.GetString(12)
                    members.Date_registered1 = reader.GetString(13)
                    members.Total_spend1 = reader.GetString(14)
                    members.Promo_activate1 = reader.GetString(15)

                End While

                con.Close()
                '  MessageBox.Show(members.Login_times1)
                Try
                    Dim login_total As Integer = CInt(members.Login_times1) + 1
                    MessageBox.Show(login_total.ToString)

                    Dim my_query As String = "UPDATE MEMBERSHIP set LOGIN_TIMES = '" + login_total.ToString +
                          "' , LAST_PARKING = '" + Date.Today.ToString("dd'/'MM'/'yyyy") +
                            "' WHERE  MEMBER_ID = '" + members.Member_id1.ToString + "'"
                    Connection_Query(my_query)
                Catch ex As Exception
                    MessageBox.Show("No Members")
                End Try
                Return True
            End Using

        End Using
        Return False
    End Function

    Public Sub Update_Initital_Amount(ByVal amount As String, ByVal id As String)

        Dim query As String = "UPDATE MEMBERSHIP set INITIAL_AMOUNT = '" + amount +
                "' WHERE  MEMBER_ID = '" + id + "'"

        Connection_Query(query)

    End Sub

    Public Function Update_Amount(ByVal initial_value As Bunifu.Framework.UI.BunifuMaterialTextbox, ByVal membership As Membership, ByVal textBox As TextBox,
                                  ByVal points As Label, ByVal Total_amount As Label) As Boolean

        Dim total = CInt(membership.Initital_amount1) + CInt(initial_value.Text)
        Dim total_pay = CInt(Total_amount.Text) + CInt(initial_value.Text)

        Dim initial_points As Double = Decimal.Round((CDbl(initial_value.Text / 50) + CDbl(points.Text)), 2, MidpointRounding.AwayFromZero)

        Try
            Dim query As String = "UPDATE MEMBERSHIP set INITIAL_AMOUNT = '" + total.ToString +
                "' , TOTAL_SPEND = '" + total_pay.ToString +
                "', POINTS = '" + initial_points.ToString +
                "' WHERE  MEMBER_ID = '" + membership.Member_id1.ToString + "'"

            MessageBox.Show("Add value Succesful")
            Connection_Query(query)
            initial_value.Text = "0"
            textBox.Text = total.ToString
            points.Text = initial_points.ToString
            Total_amount.Text = total_pay.ToString
        Catch ex As Exception
            MessageBox.Show("Error amount")
        End Try

        'textBox.Text = total.ToString

        ' Dim add_query As String = "INSERT INTO PROMO (NAME,DURATION,DESCRIPTION,PROMOEND,PRICE,STATUS) VALUES('" + Promo.Name1 + "' , '" + Promo.Duration1 + "' , '" +
        'Promo.Description1 +"' , '" + Promo.Ends1 + "', '" + Promo.Price1 + "', 'ACTIVE')"

        '        Connection_Query(add_query)

        'MessageBox.Show("Succesful Added")



        Return False
    End Function

    Public Sub Update_InitialAmount(member_id As String, amount As String)

        Dim Update_Query_InititalAmount As String = "UPDATE MEMBERSHIP SET INITIAL_AMOUNT = '" + amount + "' WHERE MEMBER_ID = '" + member_id + "'"


    End Sub


    'End Membership Query'
    '------------------------------------------------------------------------------------------------------------'

#End Region

#Region "Promo History Query"

    Public Sub Promo_history()

    End Sub


    Public Function location_history(ByVal id As String) As String

        Dim location As String = ""

        Dim query As String = "Select PROMO_HISTORY.LOCATION FROM PROMO_HISTORY WHERE PROMO_ACTIVE = 'ACTIVE' AND PROMO_HISTORY.MEMBER_ID = '" + id + "' LIMIT 1 "

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While (reader.Read())

                    location = CInt(reader.GetString(0))

                End While
            End Using
            con.Close()
        End Using
        Return location
    End Function


#End Region

End Class