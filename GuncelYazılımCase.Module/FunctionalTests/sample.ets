;#DropDB GuncelYazılımCaseEasyTest

#Application GuncelYazılımCaseWin
#Application GuncelYazılımCaseWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef GuncelYazılımCaseWin

*Action About...
 
*Action OK

#EndIf

#IfDef GuncelYazılımCaseWeb
*Action Navigation(My Details)
#EndIf
