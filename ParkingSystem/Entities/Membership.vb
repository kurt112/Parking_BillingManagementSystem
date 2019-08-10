Public Class Membership

#Region "Object of Class"
    Dim member_id As String
    Dim first_name As String
    Dim last_name As String
    Dim email_address As String
    Dim cellphone_number As String
    Dim phone_number As String
    Dim date_of_birth As String
    Dim initital_amount As String
    Dim login_times As String
    Dim points As String
    Dim last_parking As String
    Dim membership_level As String
    Dim cashier_registered As String
    Dim date_registered As String
    Dim total_spend As String
    Dim promo_activate As String
    Dim place_of_birth As String
    Dim person_to_contact As String
    Dim person_to_contact_number As String
    Dim photo As String
    Dim active As String
#End Region
    Public Sub New(member_id As String, first_name As String, last_name As String,
                   email_address As String, cellphone_number As String,
                   phone_number As String, date_of_birth As String, initital_amount As String,
                   login_times As String, points As String, last_parking As String, membership_level As String,
                   cashier_registered As String, date_registered As String, total_spend As String,
                   promo_activate As String, place_of_birth As String, person_to_contact As String,
                   person_to_contact_number As String, photo As String, active As String)
        Me.member_id = member_id
        Me.first_name = first_name
        Me.last_name = last_name
        Me.email_address = email_address
        Me.cellphone_number = cellphone_number
        Me.phone_number = phone_number
        Me.date_of_birth = date_of_birth
        Me.initital_amount = initital_amount
        Me.login_times = login_times
        Me.points = points
        Me.last_parking = last_parking
        Me.membership_level = membership_level
        Me.cashier_registered = cashier_registered
        Me.date_registered = date_registered
        Me.total_spend = total_spend
        Me.promo_activate = promo_activate
        Me.place_of_birth = place_of_birth
        Me.person_to_contact = person_to_contact
        Me.person_to_contact_number = person_to_contact_number
        Me.photo = photo
        Me.active = active
    End Sub
#Region "Constructor"

#End Region
#Region "Getter and Setter"
    Public Property First_name1 As String
        Get
            Return First_name2
        End Get
        Set(value As String)
            First_name2 = value
        End Set
    End Property

    Public Property Last_name1 As String
        Get
            Return last_name
        End Get
        Set(value As String)
            last_name = value
        End Set
    End Property

    Public Property Email_address1 As String
        Get
            Return email_address
        End Get
        Set(value As String)
            email_address = value
        End Set
    End Property

    Public Property Cellphone_number1 As String
        Get
            Return cellphone_number
        End Get
        Set(value As String)
            cellphone_number = value
        End Set
    End Property

    Public Property Phone_number1 As String
        Get
            Return phone_number
        End Get
        Set(value As String)
            phone_number = value
        End Set
    End Property

    Public Property Date_of_birth1 As String
        Get
            Return date_of_birth
        End Get
        Set(value As String)
            date_of_birth = value
        End Set
    End Property

    Public Property Initital_amount1 As String
        Get
            Return initital_amount
        End Get
        Set(value As String)
            initital_amount = value
        End Set
    End Property

    Public Property Login_times1 As String
        Get
            Return login_times
        End Get
        Set(value As String)
            login_times = value
        End Set
    End Property

    Public Property Points1 As String
        Get
            Return points
        End Get
        Set(value As String)
            points = value
        End Set
    End Property

    Public Property Last_parking1 As String
        Get
            Return last_parking
        End Get
        Set(value As String)
            last_parking = value
        End Set
    End Property

    Public Property Membership_level1 As String
        Get
            Return membership_level
        End Get
        Set(value As String)
            membership_level = value
        End Set
    End Property

    Public Property Cashier_registered1 As String
        Get
            Return cashier_registered
        End Get
        Set(value As String)
            cashier_registered = value
        End Set
    End Property

    Public Property Date_registered1 As String
        Get
            Return date_registered
        End Get
        Set(value As String)
            date_registered = value
        End Set
    End Property

    Public Property Total_spend1 As String
        Get
            Return total_spend
        End Get
        Set(value As String)
            total_spend = value
        End Set
    End Property

    Public Property First_name2 As String
        Get
            Return first_name
        End Get
        Set(value As String)
            first_name = value
        End Set
    End Property

    Public Property Member_id1 As String
        Get
            Return member_id
        End Get
        Set(value As String)
            member_id = value
        End Set
    End Property

    Public Property Promo_activate1 As String
        Get
            Return promo_activate
        End Get
        Set(value As String)
            promo_activate = value
        End Set
    End Property

    Public Property Active1 As String
        Get
            Return active
        End Get
        Set(value As String)
            active = value
        End Set
    End Property

    Public Property Person_to_contact1 As String
        Get
            Return person_to_contact
        End Get
        Set(value As String)
            person_to_contact = value
        End Set
    End Property

    Public Property Person_to_contact_number1 As String
        Get
            Return person_to_contact_number
        End Get
        Set(value As String)
            person_to_contact_number = value
        End Set
    End Property

    Public Property Place_of_birth1 As String
        Get
            Return place_of_birth
        End Get
        Set(value As String)
            place_of_birth = value
        End Set
    End Property

    Public Property Photo1 As String
        Get
            Return photo
        End Get
        Set(value As String)
            photo = value
        End Set
    End Property


#End Region
End Class
