Imports System.Xml
Public Class Form1

    'FILES ARE LOCATED IN ----> write_file\write_file\bin\Debug

    Private Sub ageField_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ageField.KeyPress
        'Numerical field
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtBtn_Click(sender As Object, e As EventArgs) Handles txtBtn.Click
        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("text-file.txt", False)
        file.WriteLine("name: " + nameField.Text)
        file.WriteLine("age: " + ageField.Text)
        file.WriteLine("address: " + addressField.Text)

        file.Close()
    End Sub
    Private Sub xmlBtn_Click(sender As Object, e As EventArgs) Handles xmlBtn.Click
        Dim writer As New XmlTextWriter("xml-file.xml", System.Text.Encoding.UTF8)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartDocument(True)
        writer.WriteStartElement("form")
        writer.WriteStartElement("name")
        writer.WriteString(nameField.Text)
        writer.WriteEndElement()
        writer.WriteStartElement("age")
        writer.WriteString(ageField.Text)
        writer.WriteEndElement()
        writer.WriteStartElement("address")
        writer.WriteString(addressField.Text)
        writer.WriteEndElement()
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
    End Sub
    Private Sub jsonBtn_Click(sender As Object, e As EventArgs) Handles jsonBtn.Click
        Dim file As System.IO.StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter("json-file.txt", False)
        file.WriteLine("{")
        file.WriteLine("""name"": """ + nameField.Text + """")
        file.WriteLine("""age"": """ + ageField.Text + """")
        file.WriteLine("""address"": """ + addressField.Text + """")
        file.WriteLine("}")

        file.Close()
    End Sub
End Class
