Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Runtime.CompilerServices

Public Module ListViewExtension

    ''' <summary>
    ''' Update list view
    ''' </summary>
    ''' <paramname="list">ListView to update</param>
    ''' <paramname="values">Items to add to the list</param>
    ''' <paramname="decoders">Lambda that transforms item to column string value</param>
    <Extension()>
    Public Sub UpdateList(Of T)(list As ListView, values As IEnumerable(Of T), ParamArray decoders As Func(Of T, Object)())
        Try
            list.BeginUpdate()

            If values Is Nothing OrElse values.Count() = 0 Then
                list.Items.Clear()
            Else

                For i = 0 To values.Count() - 1
                    Dim variable = values.ElementAt(i)

                    If i < list.Items.Count Then
                        ' Replace item
                        For c = 0 To decoders.Length - 1
                            list.Items(i).SubItems(c).Text = decoders(c)(variable)?.ToString()
                        Next
                    Else
                        ' add new items
                        list.Items.Add(New ListViewItem(decoders.[Select](Function(decoder) decoder(variable)?.ToString()).ToArray()))
                    End If
                Next

                Dim itemCount = list.Items.Count
                For i = values.Count() To itemCount - 1
                    ' remove last items
                    list.Items.RemoveAt(list.Items.Count - 1)
                Next
            End If

        Finally
            list.EndUpdate()
        End Try
    End Sub


    <DllImport("user32.dll")>
    Private Function SendMessage(window As IntPtr, message As Integer, wParam As Integer, lParam As IntPtr) As Integer
    End Function

    <Extension()>
    Public Sub SetGroupCollapse(group As ListViewGroup, state As GroupState)
        Dim i = group.ListView.Groups.IndexOf(group)

        Dim lvgroup As LVGROUP = New LVGROUP()
        lvgroup.cbSize = Marshal.SizeOf(lvgroup)
        lvgroup.state = state ' LVGS_COLLAPSIBLE 
        lvgroup.mask = 4 ' LVGF_STATE 
        lvgroup.iGroupId = i
        Dim ip = IntPtr.Zero
        Try
            ip = Marshal.AllocHGlobal(lvgroup.cbSize)
            Marshal.StructureToPtr(lvgroup, ip, True)
            SendMessage(group.ListView.Handle, &H1000 + 147, i, ip) ' #define  LVM_SETGROUPINFO(LVM_FIRST + 147)
        Catch ex As Exception
        Finally
            If ip <> IntPtr.Zero Then Marshal.FreeHGlobal(ip)
        End Try
    End Sub
End Module

<StructLayout(LayoutKind.Sequential)>
Public Structure LVGROUP
    Public cbSize As Integer
    Public mask As Integer
    Public pszHeader As IntPtr
    Public cchHeader As Integer
    Public pszFooter As IntPtr
    Public cchFooter As Integer
    Public iGroupId As Integer
    Public stateMask As Integer
    Public state As Integer
    Public uAlign As Integer
End Structure

Public Enum GroupState
    COLLAPSIBLE = 8
    COLLAPSED = 1
    EXPANDED = 0
End Enum
