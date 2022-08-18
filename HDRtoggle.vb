Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Module SendWinKey

    Const KEYEVENTF_KEYDOWN As Integer = &H0
    Const KEYEVENTF_KEYUP As Integer = &H2

    Declare Sub keybd_event Lib "User32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As UInteger, ByVal dwExtraInfo As UInteger)

       Public Sub Main()    
           keybd_event(CByte(Keys.LWin), 0, KEYEVENTF_KEYDOWN, 0) 'press the left Win key down
           keybd_event(CByte(Keys.Alt), 0, KEYEVENTF_KEYDOWN, 0) 'press the R key down
           keybd_event(CByte(Keys.B), 0, KEYEVENTF_KEYDOWN, 0) 'press the R key down
           keybd_event(CByte(Keys.B), 0, KEYEVENTF_KEYUP, 0) 'release the R key
           keybd_event(CByte(Keys.Alt), 0, KEYEVENTF_KEYUP, 0) 'release the R key
           keybd_event(CByte(Keys.LWin), 0, KEYEVENTF_KEYUP, 0) 'release the left Win key
       End Sub
End Module