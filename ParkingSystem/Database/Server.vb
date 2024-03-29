﻿Imports System.Data.SQLite
Imports Bunifu.Framework.UI
Imports ParkingSystem

Public Class Server

#Region "Object and Variable"
    ReadOnly location As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    ReadOnly fileName As String = "Parking_Database.db"

    Private ReadOnly encrypt As Encrypt = New Encrypt
    ReadOnly fullPath As String = System.IO.Path.Combine(location, fileName)

    Public connectionString As String = String.Format("Data Source = {0}", fullPath)
    Private _member As Membership
    Private date_today = Date.Today.ToString("dd'/'MM'/'yyyy")



#End Region

#Region "Getter and Setter"
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
    ReadOnly Create_User_Table_Statement As String = "CREATE TABLE 'USER'(
	                                          'USER_ID'	TEXT Not NULL,
	                                          'FIRST_NAME'   TEXT ,
	                                          'LAST_NAME'	 TEXT ,
	                                          'USER_NAME'	 TEXT ,
	                                          'EMAIL' 	     TEXT ,
	                                          'PASSWORD'	 TEXT ,
	                                          'DATE_CREATED' TEXT ,
	                                          'STATUS'	TEXT,
	                                          PRIMARY KEY('USER_ID')
                                              );"

    ReadOnly Create_Area_Table_Statement As String = "CREATE TABLE 'PARKING_AREA'(
	                                             'AREA_ID'	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                             'PARKING_NAME'	TEXT,
	                                             'PARKING_LEVEL' TEXT,
	                                             'PARKING_RATE'	TEXT,
                                                 'PARKING_STATUS' TEXT);"

    ReadOnly Create_User_History_Table_Statment As String = "CREATE TABLE 'USER_HISTORY' (
                                                  'USER_ID'	 TEXT,
	                                              'TIME_IN'	 TEXT,
	                                              'TIME_OUT' TEXT,
	                                              'SESSION'	 TEXT,
	                                              'Date' TEXT);"

    ReadOnly Create_Promo_Table_Statemet As String = "CREATE TABLE 'PROMO' (
                                            	'ID'	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                            'NAME'	TEXT,
	                                            'DURATION'	TEXT,
	                                            'DESCRIPTION'	TEXT,
	                                            'PROMOEND'	TEXT,
	                                            'PRICE'	TEXT,
	                                            'STATUS' TEXT);"

    ReadOnly Create_Membership_Table_Statement As String = "CREATE TABLE 'MEMBERSHIP' (
                                                      'MEMBER_ID' TEXT,
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
	                                                  'PHOTO'	TEXT,
                                                      'ACTIVE'	TEXT,
                                                      PRIMARY KEY('MEMBER_ID')
                                                      );"

    ReadOnly Create_parking_history_table_query As String = "CREATE TABLE 'PARKING_HISTORY' (
	                                               'PARKING_ID'	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                               'MEMBER_ID'	TEXT,
	                                               'PROMO_NAME'	TEXT,
	                                               'LOCATION'	TEXT,
	                                               'TIME_IN' TEXT,
	                                               'TIME_OUT'	TEXT,
                                                    'USER_ASSIGN'	TEXT,
                                                   'PROMO_ACTIVE'	TEXT,
                                                   'DATE' TEXT);"

    ReadOnly Create_Profit_table_query As String = "CREATE TABLE 'PROFIT' (
	                                               'ACTION_ID'	INTEGER PRIMARY KEY AUTOINCREMENT,
	                                               'ASSIGN_USER'	TEXT,
	                                               'PROFIT_DATE'	TEXT,
                                                   'MEMBER_NAME'	TEXT,
	                                               'PROFIT_AMOUNT'	TEXT);"
#End Region

#Region "Connection To the database"
    Private Function DuplicateDataBase(fullPath As String) As Boolean
        Return System.IO.File.Exists(fullPath)
    End Function

    Public Sub Connection_Query(ByVal Statement As String)

        Using Sqlconn As New SQLiteConnection(connectionString)

            Using cmd As New SQLiteCommand(Statement, Sqlconn)

                Sqlconn.Open()
                cmd.ExecuteNonQuery()
            End Using
            Sqlconn.Close()


        End Using

    End Sub

    Public Sub CreateDatabase()

        If Not DuplicateDataBase(fullPath) Then

            Connection_Query(Create_User_Table_Statement)
            Connection_Query(Create_User_History_Table_Statment)
            Connection_Query(Create_Area_Table_Statement)
            Connection_Query(Create_Promo_Table_Statemet)
            Connection_Query(Create_Membership_Table_Statement)
            Connection_Query(Create_parking_history_table_query)
            Connection_Query(Create_Profit_table_query)
            Dim add_query As String = "INSERT INTO PROMO (NAME,DURATION,DESCRIPTION,PROMOEND,PRICE,STATUS) VALUES('Enter Promo' , '" + "" + "' , '" +
            "" + "' , '" + "" + "', '" + "" + "', 'ACTIVE')"

            Connection_Query(add_query)

            Dim register_statement As String = "INSERT INTO USER VALUES('1234567891', 'John' , 'Doe' , 'username' , 'johndoe@gmail.com' , 'cGFzc3dvcmQ=' , 'beginning of the system', 'Admin')"

            Connection_Query(register_statement)
        End If
    End Sub

#End Region

#Region "For users Query"

    Public Function Delete_user(ByVal id As String) As Boolean

        Dim delete_query As String = "DELETE FROM USER WHERE USER_ID = '" + id + "' "
        Try
            Connection_Query(delete_query)
            MessageBox.Show("Delete Succesful")
            Return True
        Catch ex As Exception
            MessageBox.Show("No user found")
            Return False
        End Try

        Return False
    End Function

    Public Function Upate_user(ByVal userid As String, ByVal user As User) As Boolean

        Dim update_query As String = "UPDATE USER SET USER_ID = '" + user.Id1 + "', FIRST_NAME = '" + user.First_name1 + "', LAST_NAME = '" + user.Last_name1 + "'" +
                                     ", USER_NAME = '" + user.Username1 + "', EMAIL = '" + user.Email1 + "', PASSWORD = '" + user.Password1 + "' WHERE '" + userid + "' "
        Try
            Connection_Query(update_query)
            Return True
        Catch ex As Exception
            MessageBox.Show("Update not Successful")
        End Try

        Return False
    End Function
    Public Sub User_Query_Name(ByVal User_name As String, ByVal user As User)
        Dim select_userstatement As String = "SELECT * FROM USER WHERE USER_NAME = '" + User_name + "' LIMIT 1"

        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Using cmd As New SQLiteCommand(select_userstatement, con)
                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr

                    While (rdr.Read())
                        user.Id1 = rdr.GetString(0)
                        user.First_name1 = rdr.GetString(1)
                        user.Last_name1 = rdr.GetString(2)
                        user.Username1 = rdr.GetString(3)
                        user.Email1 = rdr.GetString(4)
                        user.Password1 = rdr.GetString(5)

                    End While
                End Using
            End Using
            con.Close()
        End Using
    End Sub


    Public Sub User_Query(ByVal user_id As String, ByVal user As User)
        Dim select_userstatement As String = "SELECT * FROM USER WHERE USER_ID = '" + user_id + "' LIMIT 1"

        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Using cmd As New SQLiteCommand(select_userstatement, con)
                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr

                    While (rdr.Read())
                        user.Id1 = rdr.GetString(0)
                        user.First_name1 = rdr.GetString(1)
                        user.Last_name1 = rdr.GetString(2)
                        user.Username1 = rdr.GetString(3)
                        user.Email1 = rdr.GetString(4)
                        user.Password1 = rdr.GetString(5)

                    End While
                End Using
            End Using
            con.Close()
        End Using
    End Sub


    Public Function Check_userid(ByVal value As String) As Boolean

        Dim result As Boolean = False
        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT USER.USER_ID FROM USER WHERE USER.USER_ID = '" + value + "';"

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr

                    While (rdr.Read())
                        result = True
                    End While
                End Using
            End Using
            con.Close()
        End Using
        Return result

    End Function
    Public Function Check_email(ByVal value As String) As Boolean
        Dim result As Boolean = False
        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT USER.EMAIL FROM USER WHERE USER.EMAIL = '" + value + "';"

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr

                    While (rdr.Read())
                        result = True
                    End While
                End Using
            End Using
            con.Close()
        End Using
        Return result
    End Function

    Public Function Check_username(ByVal value As String) As Boolean

        Dim result As Boolean = False

        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT USER.USER_NAME FROM USER WHERE USER.USER_NAME = '" + value + "';"

                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr

                    While (rdr.Read())
                        result = True
                    End While
                End Using
            End Using
            con.Close()
        End Using
        Return result
    End Function

    Public Function Register_User(ByVal user As User) As Boolean

        Try

            Dim register_statement As String = "INSERT INTO USER VALUES('" + user.Id1 + "' , '" + user.First_name1 + "' , '" + user.Last_name1 + "' , '" +
                user.Username1 + "' , '" + user.Email1 + "' , '" + user.Password1 + "' , '" + date_today + "', '" + user.Status1 + "')"

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
        Dim exist As Boolean = False
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(con)

                cmd.CommandText = "SELECT * FROM USER WHERE USER_NAME = '" + username + "' AND PASSWORD = '" + password + "' AND STATUS = 'User' LIMIT 1"
                Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                Using rdr

                    While (rdr.Read())
                        exist = True

                        Dim id As String = rdr.GetString(0)
                        Dim firstname As String = rdr.GetString(1)
                        Dim lastname As String = rdr.GetString(2)
                        Dim user_name As String = rdr.GetString(3)

                        Dim time_start As DateTime = New DateTime
                        time_start = Convert.ToDateTime(DateTime.Now)

                        login.User1 = New User_History(id, firstname, lastname, user_name, time_start.ToString, "", "", Date.Now.ToString("MM/dd/yyyy"))
                        login.Admin1 = False
                        con.Close()

                        Return True
                    End While

                End Using


            End Using

            '**************************************
            con.Close()

            If (exist = False) Then
                con.Open()

                Using cmd As New SQLiteCommand(con)

                    cmd.CommandText = "SELECT * FROM USER WHERE USER_NAME = '" + username + "' AND PASSWORD = '" + password + "' AND STATUS = 'Admin' LIMIT 1"
                    Dim rdr As SQLiteDataReader = cmd.ExecuteReader()

                    Using rdr

                        While (rdr.Read())
                            exist = True
                            Dim id As String = rdr.GetString(0)
                            Dim firstname As String = rdr.GetString(1)
                            Dim lastname As String = rdr.GetString(2)
                            Dim user_name As String = rdr.GetString(3)

                            Dim time_start As DateTime = New DateTime
                            time_start = Convert.ToDateTime(DateTime.Now)

                            login.User1 = New User_History(id, firstname, lastname, user_name, time_start.ToString, "", "", Date.Now.ToString("MM/dd/yyyy"))
                            login.Admin1 = True
                            con.Close()

                            Return True
                        End While

                    End Using


                End Using


                con.Close()

            End If
        End Using
        Return False

    End Function

    '------------------------------------------------------------------------------------------------------------'

    Public Sub User_Table(ByVal table As BunifuCustomDataGrid, ByVal text As String)
        table.Rows.Clear()

        Dim query As String

        If (text.Equals("")) Then
            query = "SELECT * FROM USER"
        Else
            query = "SELECT * FROM USER WHERE USER_ID like '%" + text + "%' Or FIRST_NAME like '%" + text +
                     "%' Or LAST_NAME like '" + text + "%' Or USER_NAME like '%" + text + "%' Or EMAIL like '%" +
                     text + "%' Or PASSWORD like '%" + text + "%' Or DATE_CREATED like '%" + text + "%' Or STATUS like '%" + text + "%';"
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
                    Dim email As String = reader.GetString(4)
                    Dim password As String = reader.GetString(5)
                    Dim date_Created As String = reader.GetString(6)
                    Dim status As String = reader.GetString(7)

                    table.Rows.Add(id, first_name, last_name, user_name, email, encrypt.Base64Decode(password), date_Created, status)

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
    Public Function User_History_Table(ByVal table1 As BunifuCustomDataGrid, ByVal text As String, ByVal condition As String) As Boolean
        table1.Rows.Clear()
        Dim query As String
        If (text = "") Then
            If (condition.Equals(" USER_HISTORY.DATE = ")) Then

                query = "SELECT USER.USER_ID, USER.FIRST_NAME, USER.LAST_NAME, USER.USER_NAME, USER_HISTORY.TIME_IN, USER_HISTORY.TIME_OUT, USER_HISTORY.SESSION, USER_HISTORY.DATE
                     FROM [USER] INNER JOIN USER_HISTORY ON USER.[USER_ID] = USER_HISTORY.[USER_ID];"
                'MessageBox.Show("asdfadsf " + query)

            Else

                query = "SELECT USER.USER_ID, USER.FIRST_NAME, USER.LAST_NAME, USER.USER_NAME, USER_HISTORY.TIME_IN, USER_HISTORY.TIME_OUT, USER_HISTORY.SESSION, USER_HISTORY.DATE
                     FROM [USER] INNER JOIN USER_HISTORY ON USER.[USER_ID] = USER_HISTORY.[USER_ID] WHERE " + condition + ";"
                'MessageBox.Show(query)

            End If

        Else

            If (condition.Equals(" USER_HISTORY.DATE = ")) Then

                query = "SELECT USER.USER_ID, USER.FIRST_NAME, USER.LAST_NAME, USER.USER_NAME, USER_HISTORY.TIME_IN, USER_HISTORY.TIME_OUT, USER_HISTORY.SESSION, USER_HISTORY.DATE 
                               FROM [USER] INNER JOIN USER_HISTORY ON USER.[USER_ID] = USER_HISTORY.[USER_ID] WHERE USER.USER_ID like '%" + text + "%' Or USER.FIRST_NAME like '%" + text + "%'
                               Or USER.LAST_NAME like '%" + text + "%' Or USER.USER_NAME like '%" + text + "%' Or USER_HISTORY.TIME_IN like '%" + text + "%'Or USER_HISTORY.TIME_OUT like '%" + text + "%' Or USER_HISTORY.SESSION like '%" + text + "%'
                               Or USER_HISTORY.DATE like '%" + text + "%';"
                'MessageBox.Show(query)
            Else

                query = "SELECT USER.USER_ID, USER.FIRST_NAME, USER.LAST_NAME, USER.USER_NAME, USER_HISTORY.TIME_IN, USER_HISTORY.TIME_OUT, USER_HISTORY.SESSION, USER_HISTORY.DATE 
                               FROM [USER] INNER JOIN USER_HISTORY ON USER.[USER_ID] = USER_HISTORY.[USER_ID] WHERE (USER.USER_ID like '%" + text + "%' Or USER.FIRST_NAME like '%" + text + "%'
                               Or USER.LAST_NAME like '%" + text + "%' Or USER.USER_NAME like '%" + text + "%' Or USER_HISTORY.TIME_IN like '%" + text + "%'Or USER_HISTORY.TIME_OUT like '%" + text + "%' Or USER_HISTORY.SESSION like '%" + text + "%'
                               Or USER_HISTORY.DATE like '%" + text + "%') AND ( " + condition + " ) ;"
                ' MessageBox.Show(query)
            End If

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
    Public Sub Parking_Query_Name(ByVal name As String, ByVal parking_area As Parking_Area)
        Dim query As String = "SELECT * FROM PARKING_AREA WHERE PARKING_NAME= '" + name + "' LIMIT 1"
        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader
                While (reader.Read())
                    parking_area.Id1 = reader.GetInt64(0)
                    parking_area.Parking_name1 = reader.GetString(1)
                    parking_area.Parking_level1 = reader.GetString(2)
                    parking_area.Parking_Rate1 = reader.GetString(3)
                    parking_area.Parking_Status1 = reader.GetString(4)
                End While
            End Using
            con.Close()
        End Using
    End Sub
    Public Sub Parking_Query(ByVal id As String, ByVal parking_area As Parking_Area)
        Dim query As String = "SELECT * FROM PARKING_AREA WHERE AREA_ID = '" + id + "' LIMIT 1"
        Using con As New SQLiteConnection(connectionString)
            con.Open()
            Using cmd As New SQLiteCommand(query, con)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader
                While (reader.Read())
                    parking_area.Id1 = reader.GetInt64(0)
                    parking_area.Parking_name1 = reader.GetString(1)
                    parking_area.Parking_level1 = reader.GetString(2)
                    parking_area.Parking_Rate1 = reader.GetString(3)
                    parking_area.Parking_Status1 = reader.GetString(4)
                End While
            End Using
            con.Close()
        End Using
    End Sub

    ' Param 1 - The name of the parking
    'Param 2 - value for status your want
    Public Sub Update_location(name As String, value As String)
        Dim Update_Location_Status As String = "UPDATE PARKING_AREA SET PARKING_STATUS =  '" + value + "'WHERE PARKING_NAME ='" + name + "'"

        Connection_Query(Update_Location_Status)

    End Sub

    Public Function Location_price(name As String) As Integer
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
        Return price
    End Function
    Public Function Generate_Location() As String
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

    Public Function Generate_Occupide_Area(id As String) As String

        Dim query As String = "SELECT PARKING_AREA.PARKING_NAME FROM PARKING_AREA WHERE PARKING_STATUS = '" + id + "' LIMIT 1"

        Dim location As String = ""
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
        Dim query As String = "SELECT PARKING_AREA.PARKING_NAME FROM PARKING_AREA WHERE PARKING_AREA.PARKING_STATUS = 'Available'  ORDER By PARKING_AREA.PARKING_NAME LIMIT 1"

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

    Public Function Update_Parkingarea(ByVal parkig_update As Parking_Area)

        Try
            Dim add_query As String = "UPDATE PARKING_AREA SET PARKING_NAME =  '" + parkig_update.Parking_name1 + "', PARKING_LEVEL = '" + parkig_update.Parking_level1 + "', PARKING_RATE = '" + parkig_update.Parking_Rate1 + "' WHERE AREA_ID = '" + parkig_update.Id1 + "'"

            Connection_Query(add_query)
            MessageBox.Show("Update Successful")
            Return True
        Catch ex As Exception
            MessageBox.Show("Can't Update")
        End Try

        Return False
    End Function
    '------------------------------------------------------------------------------------------------------------'
    Public Function Add_ParkingArea(ByVal parking As Parking_Area) As Boolean

        Try
            Dim add_query As String = "INSERT INTO PARKING_AREA (PARKING_NAME, PARKING_LEVEL, PARKING_RATE, PARKING_STATUS) VALUES('" + parking.Parking_name1 + "' , '" + parking.Parking_level1 + "' , '" +
                parking.Parking_Rate1 + "' , '" + parking.Parking_Status1 + "')"

            Connection_Query(add_query)
            Return True
        Catch ex As Exception
            MessageBox.Show("Add not Successful")
        End Try
        Return False
    End Function
    Public Sub Add_Parking_Price_Combobox(ByVal drop_down As BunifuDropdown)
        drop_down.Clear()
        drop_down.AddItem("Parking Fee")
        Dim query As String = "select DISTINCT PARKING_RATE FROM PARKING_AREA order by PARKING_RATE"
        Using Conn As New SQLiteConnection(connectionString)

            Conn.Open()

            Using commands As New SQLiteCommand(query, Conn)

                Dim reader As SQLiteDataReader = commands.ExecuteReader

                While (reader.Read())


                    Dim parking_level As String = reader.GetString(0)

                    drop_down.AddItem(parking_level)

                End While

            End Using
            drop_down.AddItem("Add New Item")
            Conn.Close()
            drop_down.selectedIndex = 0
            drop_down.Select()
        End Using

    End Sub

    Public Sub Add_Parking_Level_Combobox(ByVal drop_down As BunifuDropdown)
        drop_down.Clear()
        drop_down.AddItem("Parking Level")
        Dim query As String = "select DISTINCT PARKING_LEVEL FROM PARKING_AREA order by PARKING_LEVEL;"

        Using Conn As New SQLiteConnection(connectionString)

            Conn.Open()

            Using commands As New SQLiteCommand(query, Conn)

                Dim reader As SQLiteDataReader = commands.ExecuteReader

                While (reader.Read())

                    Dim parking_level As String = reader.GetString(0)

                    drop_down.AddItem(parking_level)


                End While

            End Using
            drop_down.AddItem("Add New Item")
            drop_down.selectedIndex = 0
            drop_down.Select()
            Conn.Close()
        End Using

    End Sub

    Public Sub Parking_Table(ByVal text As String, ByVal table As BunifuCustomDataGrid)
        CreateDatabase()
        table.Rows.Clear()
        Dim query As String
        If Not (text.Equals("")) Then
            query = "SELECT * FROM PARKING_AREA WHERE PARKING_NAME LIKE '%" + text + "%' OR PARKING_LEVEL LIKE '%" + text + "%' OR PARKING_RATE LIKE '%" + text + "%' OR PARKING_STATUS LIKE'%" + text + "%' AND  NOT PARKING_STATUS = 'DISABLED' ORDER BY PARKING_NAME ASC"
        Else
            query = "SELECT * FROM PARKING_AREA WHERE NOT PARKING_STATUS = 'DISABLED' ORDER BY PARKING_NAME ASC"
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
                    If Not (status.Equals("DISABLED")) Then
                        table.Rows.Add(id, parking_name, parking_level, parking_rate, status)
                    End If
                    'MessageBox.Show(id)
                End While
            End Using
            con.Close()
        End Using
    End Sub

    Public Function Get_Floor(ByVal parking_name As String) As String
        Dim query As String = "SELECT PARKING_AREA.PARKING_LEVEL FROM PARKING_AREA WHERE PARKING_NAME = '" + parking_name + "'; "
        Dim floor As String = ""
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)
                Dim reader As SQLiteDataReader = cmd.ExecuteReader
                While (reader.Read())
                    floor = reader.GetString(0)
                End While
            End Using
            con.Close()
        End Using
        Return floor
    End Function

    'End of Parking Query '
    '------------------------------------------------------------------------------------------------------------'

#End Region

#Region "Promo Query"
    'Start of Promo Query'
    '------------------------------------------------------------------------------------------------------------'

    Public Function Promo_Update(ByVal promo As Promo) As Boolean
        Try
            Dim update_promo As String = "UPDATE PROMO SET NAME = '" + promo.Name1 + "' , DURATION = '" + promo.Duration1 + "' , DESCRIPTION '" + promo.Description1 +
                                     "' , PROMOEND = '" + promo.Ends1 + "' , PRICE = '" + promo.Price1 + "' WHERE ID = '" + promo.Id1 + "'"
            Connection_Query(update_promo)

        Catch ex As Exception
            Return False
        End Try
        Return False
    End Function

    Public Sub Promo_Query_Name(ByVal Name As String, ByVal promo As Promo)
        Dim query As String = "SELECT * FROM PROMO WHERE NAME = '" + Name + "'"
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While (reader.Read())
                    promo.Id1 = reader.GetInt64(0).ToString
                    promo.Name1 = reader.GetString(1)
                    promo.Duration1 = reader.GetString(2)
                    promo.Description1 = reader.GetString(3)
                    promo.Ends1 = reader.GetString(4)
                    promo.Price1 = reader.GetString(5)
                    promo.Status1 = reader.GetString(6)
                End While
            End Using
        End Using
    End Sub

    Public Sub Promo_Query(ByVal id As String, ByVal promo As Promo)
        Dim query As String = "SELECT * FROM PROMO WHERE ID = '" + id + "'"
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While (reader.Read())
                    promo.Id1 = reader.GetInt64(0).ToString
                    promo.Name1 = reader.GetString(1)
                    promo.Duration1 = reader.GetString(2)
                    promo.Description1 = reader.GetString(3)
                    promo.Ends1 = reader.GetString(4)
                    promo.Price1 = reader.GetString(5)
                    promo.Status1 = reader.GetString(6)
                End While
            End Using
        End Using
    End Sub

    Public Function Delete_Promo(ByVal id As String) As Boolean

        Try
            Dim delete_Query As String = "DELETE FROM PROMO WHERE ID = '" + id + "' "
            Connection_Query(delete_Query)
            Return False
        Catch ex As Exception
            Return False
        End Try
        Return False

    End Function

    Public Function Promo_Enable(ByVal id As String) As Boolean
        Dim query_duration As String = "SELECT PROMO.STATUS FROM PROMO WHERE ID = '" + id + "' "
        Dim result As String = ""
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query_duration, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While (reader.Read())
                    result = reader.GetString(0)
                End While
            End Using
            con.Close()
            If (result.Equals("INACTIVE")) Then
                Dim set_enable_query = "UPDATE PROMO SET STATUS = 'ACTIVE' WHERE ID = '" + id + "' "
                Connection_Query(set_enable_query)
                Return True
            Else
                MessageBox.Show("Promo is Already Enable")
            End If
        End Using
        Return False
    End Function

    Public Function Promo_Disable(ByVal id As String) As Boolean
        Dim query_duration As String = "SELECT PROMO.STATUS FROM PROMO WHERE ID = '" + id + "' "
        Dim result As String = ""
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query_duration, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While (reader.Read())
                    result = reader.GetString(0)
                End While
            End Using
            con.Close()
            If (result.Equals("ACTIVE")) Then
                Dim set_enable_query = "UPDATE PROMO SET STATUS = 'INACTIVE' WHERE ID = '" + id + "' "
                Connection_Query(set_enable_query)
                Return True
            Else
                MessageBox.Show("Promo is Already Enable")
            End If
        End Using
        Return False
    End Function

    Public Function Promo_ends(ByVal name As String) As Integer
        Dim value As Integer = 0
        If Not (name.Equals("Enter Promo")) Then
            Dim query_duration As String = "SELECT PROMO.DURATION FROM PROMO WHERE NAME = '" + name + "'"

            Using con As New SQLiteConnection(connectionString)

                con.Open()

                Using cmd As New SQLiteCommand(query_duration, con)

                    Dim reader As SQLiteDataReader = cmd.ExecuteReader

                    While (reader.Read())

                        value = CInt(reader.GetString(0))

                    End While
                End Using
                con.Close()
            End Using
            Return value
        End If
        Return value
    End Function

    Public Sub InsertPromo(ByVal promo As Promo)
        Dim add_query As String = "INSERT INTO PROMO (NAME,DURATION,DESCRIPTION,PROMOEND,PRICE,STATUS) VALUES('" + promo.Name1 + "' , '" + promo.Duration1 + "' , '" +
             promo.Description1 + "' , '" + promo.Ends1 + "', '" + promo.Price1 + "', 'ACTIVE')"

        Connection_Query(add_query)

        MessageBox.Show("Succesful Added")
    End Sub

    Public Sub Promo_Table(ByVal text As String, ByVal table As BunifuCustomDataGrid)
        table.Rows.Clear()
        Dim query As String

        If Not (text.Equals("")) Then
            query = "SELECT * FROM PROMO WHERE NAME LIKE '%" + text + "%' OR DURATION LIKE '%" + text + "%' OR DESCRIPTION LIKE '" + text + "%' OR PROMOEND LIKE'" + text + "%' OR PRICE LIKE '%" + text + "%' OR STATUS LIKE '%" + text + "%' ORDER BY NAME ASC"
        Else
            query = "SELECT * FROM PROMO ORDER BY NAME ASC"
        End If
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                Dim count As Integer = 0
                While (reader.Read())
                    Dim name As String = reader.GetString(1)


                    If (name.Equals("Enter Promo")) Then

                    Else
                        Dim id As String = reader.GetInt64(0).ToString
                        Dim duration As String = reader.GetString(2)
                        Dim description As String = reader.GetString(3)
                        Dim promoend As String = reader.GetString(4)
                        Dim price As String = reader.GetString(5)
                        Dim status As String = reader.GetString(6)
                        table.Rows.Add(id, name, duration, description, promoend, price, status)
                    End If

                    'MessageBox.Show(id)
                End While
            End Using
            con.Close()
        End Using
    End Sub

    Public Sub Promo_Combobox(ByVal combobox As Bunifu.Framework.UI.BunifuDropdown)
        combobox.Clear()
        Dim query As String = "SELECT * FROM PROMO WHERE STATUS = 'ACTIVE'"

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
    Public Function Update_Member(ByVal id As String, ByVal member As Membership) As Boolean

        Dim query As String = "UPDATE MEMBERSHIP SET MEMBER_ID = '" + member.Member_id1 + "', FIRST_NAME = '" + member.First_name1 + "', PHOTO = '" + member.Photo1 +
        "', LAST_NAME = '" + member.Last_name1 + "', EMAIL_ADDRESS = '" + member.Email_address1 +
        "', CELLPHONENUMBER = '" + member.Cellphone_number1 + "', TELEPHONENUMBER = '" + member.Phone_number1 +
        "', DATE_OF_BIRTH = '" + member.Date_of_birth1 + "', INITIAL_AMOUNT = '" + member.Initital_amount1 +
        "', TOTAL_SPEND = '" + member.Total_spend1 + "', PLACE_OF_BIRTH = '" + member.Place_of_birth1 +
        "', PERSON_TO_CONTACT = '" + member.Person_to_contact1 + "', PERSON_TO_CONTACT_NUMBER = '" +
        member.Person_to_contact_number1 + "' WHERE  MEMBER_ID = '" + id + "' ;"

        Try
            Connection_Query(query)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        Return False

    End Function

    Public Sub Update_Member_Status(member_id As String, value As String)
        Dim Update_Member_Status_Query As String = "UPDATE MEMBERSHIP SET ACTIVE = '" + value + "' WHERE MEMBER_ID = '" + member_id + "'"
        Connection_Query(Update_Member_Status_Query)
    End Sub

    Public Sub Update_Promo(member As String, value As String)

        Dim Update_Promo_StatusQuery As String = "UPDATE MEMBERSHIP SET PROMO_ACTIVATE = '" + value + "' WHERE MEMBER_ID = '" + member + "'"
        Connection_Query(Update_Promo_StatusQuery)

    End Sub

    '@ param 1 - the value will be the condition for search
    '@ param 2 -  the table will update after the search
    Public Sub MembershipTable(ByVal search As String, ByVal table As BunifuCustomDataGrid)

        table.Rows.Clear()

        Dim query As String

        If (search.Equals("")) Then
            query = "SELECT * FROM MEMBERSHIP WHERE NOT ACTIVE = 'DISABLED' ORDER BY LAST_NAME ASC "
        Else
            query = "Select * FROM MEMBERSHIP WHERE FIRST_NAME Like '%" + search + "%' OR LAST_NAME LIKE '%" + search + "%' Or " +
                  "EMAIL_ADDRESS LIKE '%" + search + "%' OR CELLPHONENUMBER LIKE '%" + search + "%' OR " +
            "LAST_PARKING LIKE '%" + search + "%' OR PROMO_ACTIVATE LIKE '%" + search + "%' OR " +
              "ACTIVE LIKE '%" + search + "%' AND NOT ACTIVE = 'DISABLED' ORDER BY LAST_NAME ASC"
        End If

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    Dim member_id As String = reader.GetString(0)
                    Dim first_name As String = reader.GetString(1)
                    Dim last_name As String = reader.GetString(2)
                    Dim email_address As String = reader.GetString(3)
                    Dim cellphone_number As String = reader.GetString(4)
                    Dim last_parking As String = reader.GetString(10)
                    Dim promo As String = reader.GetString(15)
                    Dim status As String = reader.GetString(20)
                    'MessageBox.Show(id)
                    If Not (status.Equals("DISABLED")) Then
                        table.Rows.Add(member_id, last_name, first_name, email_address, cellphone_number,
                                   last_parking, promo, status)
                    End If
                End While
            End Using
            con.Close()
        End Using

    End Sub

    Public Function Membership_Register(ByVal member As Membership) As Boolean
        Dim register_statement As String = "INSERT INTO MEMBERSHIP VALUES('" + member.Member_id1 + "' , '" +
        member.First_name1 + "' , '" + member.Last_name1 +
       "' , '" + member.Email_address1 + "' , '" + member.Cellphone_number1 +
       "' , '" + member.Phone_number1 + "' , '" + member.Date_of_birth1 +
       "' , '" + member.Initital_amount1 + "' , '" + member.Login_times1 +
       "' , '" + member.Points1 + "' , '" + member.Last_parking1 +
       "' , '" + member.Membership_level1 + "' , '" + member.Cashier_registered1 +
       "' , '" + member.Date_registered1 + "' , '" + member.Total_spend1 +
       "' , '" + member.Promo_activate1 + "' , '" + member.Place_of_birth1 +
       "' , '" + member.Person_to_contact1 + "' , '" + member.Person_to_contact_number1 +
       "' , '" + member.Photo1 + "' , '" + member.Active1 + "')"

        Try
            Connection_Query(register_statement)
        Catch ex As Exception
            MessageBox.Show("Id has a duplicate")
        End Try

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
                    members.Member_id1 = reader.GetString(0)
                    members.First_name1 = reader.GetString(1)
                    members.Last_name1 = reader.GetString(2)
                    members.Email_address1 = reader.GetString(3)
                    members.Cellphone_number1 = reader.GetString(4)
                    members.Person_to_contact1 = reader.GetString(16)
                    members.Place_of_birth1 = reader.GetString(17)
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
                    members.Active1 = reader.GetString(20)
                    members.Photo1 = reader.GetString(19)
                End While

                con.Close()
                Return True
            End Using

        End Using
        Return False
    End Function

    Public Sub Update_Login(ByVal members As Membership)
        Try
            Dim login_total As Integer = CInt(members.Login_times1) + 1

            ' MessageBox.Show(login_total.ToString)
            Dim my_query As String = "UPDATE MEMBERSHIP set LOGIN_TIMES = '" + login_total.ToString +
                  "' , LAST_PARKING = '" + date_today +
                    "' WHERE  MEMBER_ID = '" + members.Member_id1 + "'"
            Connection_Query(my_query)
        Catch ex As Exception
            MessageBox.Show("No Members")
        End Try

    End Sub

    Public Sub Update_Initital_Amount(ByVal amount As String, ByVal id As String)

        Dim query As String = "UPDATE MEMBERSHIP set INITIAL_AMOUNT = '" + amount +
                "' WHERE  MEMBER_ID = '" + id + "'"

        Connection_Query(query)

    End Sub

    Public Function Update_Amount(ByVal initial_value As Bunifu.Framework.UI.BunifuMaterialTextbox, ByVal membership As Membership, ByVal textBox As TextBox,
                                  ByVal points As Label, ByVal Total_amount As Label) As Boolean

        Dim total As Integer = CInt(textBox.Text) + CInt(initial_value.Text)
        Dim total_pay = CInt(Total_amount.Text) + CInt(initial_value.Text)

        Dim initial_points As Double = Decimal.Round((CDbl(initial_value.Text / 50) + CDbl(points.Text)), 2, MidpointRounding.AwayFromZero)

        Try

            Dim query As String = "UPDATE MEMBERSHIP set INITIAL_AMOUNT = '" + total.ToString +
                "' , TOTAL_SPEND = '" + total_pay.ToString +
                "', POINTS = '" + initial_points.ToString +
                "' WHERE  MEMBER_ID = '" + membership.Member_id1 + "'"

            MessageBox.Show("Add value Succesful")
            Connection_Query(query)
            initial_value.Text = "0"
            textBox.Text = total.ToString
            points.Text = initial_points.ToString
            Total_amount.Text = total_pay.ToString
        Catch ex As Exception
            MessageBox.Show("Can't Add the amount")
        End Try
        Return False
    End Function

    Public Sub Update_InitialAmount(member_id As String, amount As String)
        Dim Update_Query_InititalAmount As String = "UPDATE MEMBERSHIP SET INITIAL_AMOUNT = '" + amount + "' WHERE MEMBER_ID = '" + member_id + "'"
        Connection_Query(Update_Query_InititalAmount)

    End Sub


    'End Membership Query'
    '------------------------------------------------------------------------------------------------------------'

#End Region

#Region "PARKING_HISTORY Query"
    'textBox.Text = total.ToString

    Public Sub Insert_Parkinghistory(ByVal promo As Promo_History)

        Dim add_query As String = "INSERT INTO PARKING_HISTORY (MEMBER_ID,PROMO_NAME,LOCATION,TIME_IN,TIME_OUT,USER_ASSIGN,PROMO_ACTIVE,DATE) VALUES('" + promo.Member_id1 + "' , '" + promo.Promo_name1 + "' , '" +
        promo.Location1 + "' , '" + promo.Promo_registered_date1 + "', '" + promo.Promo_ends1 + "' , '" + promo.User_assign1 + "', 'ACTIVE', '" + Date.Now.ToString("dd'/'MM'/'yyyy") + "')"

        Connection_Query(add_query)

        'MessageBox.Show("Succesful Added")
    End Sub


    Public Function Get_Promo_ends(id As String) As String

        Dim promo_ends_result As String = ""

        Dim query As String = "Select PARKING_HISTORY.TIME_OUT FROM PARKING_HISTORY WHERE PROMO_ACTIVE = 'ACTIVE' AND MEMBER_ID = '" + id + "' LIMIT 1 "

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While (reader.Read())

                    promo_ends_result = (reader.GetString(0))

                End While
            End Using
            con.Close()
        End Using
        Return promo_ends_result
    End Function

    Public Sub Set_Promo_Inactive(id As String)

        Dim update_promo_inactive As String = "UPDATE PARKING_HISTORY SET PROMO_ACTIVE = 'INACTIVE' WHERE MEMBER_ID = '" + id + "' AND PROMO_ACTIVE = 'ACTIVE'"
        Connection_Query(update_promo_inactive)

    End Sub

    Public Function Location_history(ByVal id As String) As String

        Dim location As String = ""

        Dim query As String = "Select PARKING_HISTORY.LOCATION FROM PARKING_HISTORY WHERE PROMO_ACTIVE = 'Active' AND PARKING_HISTORY.MEMBER_ID = '" + id + "' LIMIT 1 "

        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While (reader.Read())

                    location = (reader.GetString(0))

                End While
            End Using
            con.Close()
        End Using
        Return location
    End Function


    'First parameter for searching
    'Second param The table that will add the query
    'Third param the table that will define if the tables is for history or not
    'Fourth param The date
    Public Sub Load_Historyparking(ByVal search As String, ByVal tables As BunifuCustomDataGrid, ByVal history As Boolean, ByVal condition As String)
        tables.Rows.Clear()
        date_today = Date.Today.ToString("dd'/'MM'/'yyyy")
        Dim query As String


        If (history = True) Then

            If (search.Equals("")) Then
                If (condition.Equals(" PARKING_HISTORY.DATE = ")) Then
                    query = "SELECT PARKING_HISTORY.PARKING_ID,
                               MEMBERSHIP.MEMBER_ID , MEMBERSHIP.FIRST_NAME, 
                               MEMBERSHIP.LAST_NAME, PARKING_HISTORY.PROMO_NAME, 
                               PARKING_HISTORY.LOCATION, PARKING_HISTORY.TIME_IN, 
                               PARKING_HISTORY.TIME_OUT, PARKING_HISTORY.USER_ASSIGN,
                               PARKING_HISTORY.PROMO_ACTIVE, PARKING_HISTORY.DATE
                               FROM MEMBERSHIP INNER JOIN PARKING_HISTORY 
                               ON MEMBERSHIP.[MEMBER_ID] = PARKING_HISTORY.[MEMBER_ID];"

                    '  MessageBox.Show(query)
                Else

                    query = "SELECT PARKING_HISTORY.PARKING_ID,
                               MEMBERSHIP.MEMBER_ID , MEMBERSHIP.FIRST_NAME, 
                               MEMBERSHIP.LAST_NAME, PARKING_HISTORY.PROMO_NAME, 
                               PARKING_HISTORY.LOCATION, PARKING_HISTORY.TIME_IN, 
                               PARKING_HISTORY.TIME_OUT, PARKING_HISTORY.USER_ASSIGN,
                               PARKING_HISTORY.PROMO_ACTIVE, PARKING_HISTORY.DATE
                               FROM MEMBERSHIP INNER JOIN PARKING_HISTORY 
                               ON MEMBERSHIP.[MEMBER_ID] = PARKING_HISTORY.[MEMBER_ID] WHERE " + condition + ";"
                    '  MessageBox.Show(query)

                End If

            Else

                If (condition.Equals(" PARKING_HISTORY.DATE = ")) Then

                    query = "SELECT PARKING_HISTORY.PARKING_ID,
                               MEMBERSHIP.MEMBER_ID , MEMBERSHIP.FIRST_NAME, 
                               MEMBERSHIP.LAST_NAME, PARKING_HISTORY.PROMO_NAME, 
                               PARKING_HISTORY.LOCATION, PARKING_HISTORY.TIME_IN, 
                               PARKING_HISTORY.TIME_OUT, PARKING_HISTORY.USER_ASSIGN,
                               PARKING_HISTORY.PROMO_ACTIVE, PARKING_HISTORY.DATE
                               FROM MEMBERSHIP INNER JOIN PARKING_HISTORY 
                               ON MEMBERSHIP.[MEMBER_ID] = PARKING_HISTORY.[MEMBER_ID]
							   WHERE PARKING_HISTORY.PARKING_ID LIKE '%" + search + "%' " +
                               "OR MEMBERSHIP.MEMBER_ID LIKE '%" + search + "%'  OR MEMBERSHIP.FIRST_NAME LIKE '%" + search + "%' " +
                               "OR Membership.last_name Like '%" + search + "%'  OR PARKING_HISTORY.PROMO_NAME LIKE '%" + search + "%' " +
                               "OR PARKING_HISTORY.LOCATION Like '%" + search + "%' OR PARKING_HISTORY.TIME_IN LIKE '%" + search + "%'" +
                               "OR PARKING_HISTORY.TIME_OUT Like '%" + search + "%'  OR PARKING_HISTORY.USER_ASSIGN Like '%" + search + "%' " +
                               "OR PARKING_HISTORY.PROMO_ACTIVE Like '%" + search + "%' OR PARKING_HISTORY.DATE LIKE '%" + search + "%'; "
                    '  MessageBox.Show(query)

                Else

                    query = "SELECT PARKING_HISTORY.PARKING_ID,
                               MEMBERSHIP.MEMBER_ID , MEMBERSHIP.FIRST_NAME, 
                               MEMBERSHIP.LAST_NAME, PARKING_HISTORY.PROMO_NAME, 
                               PARKING_HISTORY.LOCATION, PARKING_HISTORY.TIME_IN, 
                               PARKING_HISTORY.TIME_OUT, PARKING_HISTORY.USER_ASSIGN,
                               PARKING_HISTORY.PROMO_ACTIVE, PARKING_HISTORY.DATE
                               FROM MEMBERSHIP INNER JOIN PARKING_HISTORY 
                               ON MEMBERSHIP.[MEMBER_ID] = PARKING_HISTORY.[MEMBER_ID]
							   WHERE (" + condition + ") AND (PARKING_HISTORY.PARKING_ID LIKE '%" + search + "%' " +
                               "OR MEMBERSHIP.MEMBER_ID LIKE '%" + search + "%'  OR MEMBERSHIP.FIRST_NAME LIKE '%" + search + "%' " +
                               "OR Membership.last_name Like '%" + search + "%'  OR PARKING_HISTORY.PROMO_NAME LIKE '%" + search + "%' " +
                               "OR PARKING_HISTORY.LOCATION Like '%" + search + "%' OR PARKING_HISTORY.TIME_IN LIKE '%" + search + "%'" +
                               "OR PARKING_HISTORY.TIME_OUT Like '%" + search + "%'  OR PARKING_HISTORY.USER_ASSIGN Like '%" + search + "%' " +
                               "OR PARKING_HISTORY.PROMO_ACTIVE Like '%" + search + "%' OR PARKING_HISTORY.DATE LIKE '%" + search + "%');"
                    ' MessageBox.Show(query)
                End If

            End If

        Else
            If (search.Equals("")) Then

                query = "SELECT PARKING_HISTORY.PARKING_ID,
                               MEMBERSHIP.MEMBER_ID , MEMBERSHIP.FIRST_NAME, 
                               MEMBERSHIP.LAST_NAME, PARKING_HISTORY.PROMO_NAME, 
                               PARKING_HISTORY.LOCATION, PARKING_HISTORY.TIME_IN, 
                               PARKING_HISTORY.TIME_OUT, PARKING_HISTORY.USER_ASSIGN,
                               PARKING_HISTORY.PROMO_ACTIVE, PARKING_HISTORY.DATE
                               FROM MEMBERSHIP INNER JOIN PARKING_HISTORY 
                               ON MEMBERSHIP.[MEMBER_ID] = PARKING_HISTORY.[MEMBER_ID] WHERE PARKING_HISTORY.DATE = '" + date_today + "' OR PARKING_HISTORY.PROMO_ACTIVE = 'ACTIVE';"
            Else
                query = "SELECT PARKING_HISTORY.PARKING_ID,
                               MEMBERSHIP.MEMBER_ID , MEMBERSHIP.FIRST_NAME, 
                               MEMBERSHIP.LAST_NAME, PARKING_HISTORY.PROMO_NAME, 
                               PARKING_HISTORY.LOCATION, PARKING_HISTORY.TIME_IN, 
                               PARKING_HISTORY.TIME_OUT, PARKING_HISTORY.USER_ASSIGN,
                               PARKING_HISTORY.PROMO_ACTIVE, PARKING_HISTORY.DATE
                               FROM MEMBERSHIP INNER JOIN PARKING_HISTORY 
                               ON MEMBERSHIP.[MEMBER_ID] = PARKING_HISTORY.[MEMBER_ID]
							   WHERE ( PARKING_HISTORY.PARKING_ID LIKE '%" + search + "%' " +
                               "OR MEMBERSHIP.MEMBER_ID LIKE '%" + search + "%'  OR MEMBERSHIP.FIRST_NAME LIKE '%" + search + "%'" +
                               "OR Membership.last_name Like '%" + search + "%'  OR PARKING_HISTORY.PROMO_NAME LIKE '%" + search + "%'" +
                               "OR PARKING_HISTORY.LOCATION Like '%" + search + "%' OR PARKING_HISTORY.TIME_IN LIKE '%" + search + "%'" +
                               "OR PARKING_HISTORY.TIME_OUT Like '%" + search + "%'  OR PARKING_HISTORY.USER_ASSIGN Like '%" + search + "%' ) " +
                               "AND (PARKING_HISTORY.PROMO_ACTIVE = 'ACTIVE' OR PARKING_HISTORY.DATE = '" + date_today + "');"
                '  MessageBox.Show(query)

            End If

        End If
        MessageBox.Show(query)
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader


                While (reader.Read())

                    Dim parking_id As Integer = reader.GetInt64(0)
                    Dim member_id As String = reader.GetString(1)
                    Dim firstname As String = reader.GetString(2)
                    Dim lastname As String = reader.GetString(3)
                    Dim promoname As String = reader.GetString(4)
                    Dim location As String = reader.GetString(5)
                    Dim timein As String = reader.GetString(6)
                    Dim timeout As String = reader.GetString(7)
                    Dim user_assign As String = reader.GetString(8)
                    Dim promo_active As String = reader.GetString(9)
                    Dim date_ As String = reader.GetString(10)
                    tables.Rows.Add(parking_id.ToString, member_id.ToString, firstname, lastname,
                                    promoname, location, timein, timeout, user_assign, promo_active, date_)
                End While

            End Using
            con.Close()
        End Using


    End Sub
#End Region

#Region "Profit Table Query"

    Public Function Insert_Profit(ByVal profit As Profit_Entities) As Boolean
        Dim profit_insert As String = "INSERT INTO  PROFIT(ASSIGN_USER, PROFIT_DATE, PROFIT_AMOUNT, MEMBER_NAME) VALUES ('" + profit.Asign_User1 + "', '" + profit.Profit_date1 + "', '" + profit.Profit_amount1 + "', '" + profit.Member_name1 + "')"
        Connection_Query(profit_insert)
        Try

            Return True
        Catch ex As Exception

        End Try
        Return False
    End Function

    Public Sub Profit_Table(ByVal text As String, ByVal tables As BunifuCustomDataGrid, ByVal label As Label, ByVal condition As String)
        tables.Rows.Clear()
        Dim query As String
        Dim total As Integer
        If (text.Equals("")) Then

            If (condition.Equals(" PROFIT_DATE = ")) Then
                query = "SELECT * FROM PROFIT"
                'MessageBox.Show(query)
            Else
                query = "SELECT * FROM PROFIT WHERE " + condition + "; "
                '  MessageBox.Show(query)
            End If

        Else

            If (condition.Equals(" PROFIT_DATE = ")) Then

                query = "SELECT * FROM PROFIT WHERE ASSIGN_USER LIKE '%" + text + "%' OR PROFIT_DATE LIKE '%" + text + "%' OR PROFIT_AMOUNT LIKE '%" + text + "%' OR MEMBER_NAME LIKE '%" + text + "%'"
                'MessageBox.Show(query)
            Else

                query = "SELECT * FROM PROFIT WHERE (" + condition + ") AND (ASSIGN_USER LIKE '%" + text + "%' OR PROFIT_DATE LIKE '%" + text + "%' OR PROFIT_AMOUNT LIKE '%" + text + "%' OR MEMBER_NAME LIKE '%" + text + "%')"
                ' MessageBox.Show(query)
            End If

        End If

        ' Try
        Using con As New SQLiteConnection(connectionString)

            con.Open()

            Using cmd As New SQLiteCommand(query, con)

                Dim reader As SQLiteDataReader = cmd.ExecuteReader

                While (reader.Read())

                    Dim id As String = reader.GetInt64(0).ToString
                    Dim assign_user As String = reader.GetString(1)
                    Dim profit_date As String = reader.GetString(2)
                    Dim member_name As String = reader.GetString(3)
                    Dim amount As String = reader.GetString(4)

                    Try
                        total += CInt(amount)
                    Catch ex As Exception

                    End Try

                    tables.Rows.Add(id, assign_user, profit_date, member_name, amount)
                End While

            End Using
            label.Text = total.ToString
            con.Close()
        End Using
        'Catch ex As Exception

        'MessageBox.Show("Invalid Query")
        'End Try
    End Sub
#End Region
End Class