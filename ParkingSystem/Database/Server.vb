Imports System.Data.SQLite
Imports Bunifu.Framework.UI

Public Class Server

    Dim location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim fileName As String = "Parking_Database.db"

    Dim fullPath As String = System.IO.Path.Combine(location, fileName)

    Public connectionString As String = String.Format("Data Source = {0}", fullPath)
    Private table As BunifuCustomDataGrid = New Bunifu.Framework.UI.BunifuCustomDataGrid

    Public Property Table1 As BunifuCustomDataGrid
        Get
            Return table
        End Get
        Set(value As BunifuCustomDataGrid)
            table = value
        End Set
    End Property

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

        End If
    End Sub

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

    'Start of Parking Query'
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


    'End of Promo Query'
    '------------------------------------------------------------------------------------------------------------'



End Class
