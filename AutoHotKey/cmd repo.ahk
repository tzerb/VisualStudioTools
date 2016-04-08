#IfWinActive ahk_class ConsoleWindowClass
 ^R::
 SendInput c:{enter}
 SendInput cd c:\repos{enter}
 return
 #IfWinActive
