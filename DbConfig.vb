Imports MySql.Data.MySqlClient

Module DbConfig

    Public Function GetLocalConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;database=" & CurrentLocalDatabase & ";")
    End Function

    Public Function GetCentralConnection() As MySqlConnection
        Return New MySqlConnection("server=192.168.1.100;userid=branchuser;password=;database=attendance_central;")
    End Function

    Public Function GetMainLocalConnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;userid=root;password=;database=attendance_central;")
    End Function

End Module