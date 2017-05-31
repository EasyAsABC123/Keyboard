ipmo C:\Githubdata\Jimmy
ipmo C:\Githubdata\RaxIntensiveCreds
Add-Type -Path C:\dev\Keyboard\Keyboard\bin\x64\Debug\Keyboard.dll
Add-Type -TypeDefinition @'
using System;  
using System.Runtime.InteropServices;
namespace Test2
{
    public class Test
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetActiveWindow();
    }
}
'@

if ($null -eq $P -or $P.HasExited) {
    $P = Get-Process RTS3App
    #$P.StartInfo.FileName = 'MSTSC.exe'
    #$P.StartInfo.Arguments = "C:\Users\Freddie\Desktop\DellDesktop.rdp"
    #$P.StartInfo.Arguments = "C:\Users\Freddie\Desktop\FS-70-533-DC.rdp"
    #$null = $P.Start()
}

$Id = 'Farmtest'
Open-RoyalTSConnection -ComputerName 'bts.lon5.farm.rackspace.com' -Username (Get-IntUsername -Cust) -Password (Get-IntPassword -Cust) -DisplayName $Id -NoRdGateway -NoNla


$P.MainWindowTitle
$H = $P.MainWindowHandle
$H
return
#$P.WaitForInputIdle()
#[TestTest.Test]::SetForegroundWindow($H)

function Send-Key {
    param(
        [string]$Key
        #[int]$Handle
    )

    $EnumVal = "KEY_{0}" -f $Key.ToUpper()
    $KeyObj = New-Object Keyboard.Key ([Keyboard.Messaging+VKeys]::($EnumVal))
    $KeyObj.PressForeground($H)

}

#$Win = New-Object Keyboard.Key ([Keyboard.Messaging+VKeys]::KEY_LMENU)
#$Enter = New-Object Keyboard.Key ([Keyboard.Messaging+VKeys]::KEY_RETURN)

#$Enter.PressForeground($H)
#$Enter.PressBackground($H)
#$Enter.Press($H, $true)
#[System.Windows.Forms.SendKeys]::SendWait("^{c}")

$LCtrl = New-Object Keyboard.Key ([Keyboard.Messaging+VKeys]::KEY_LCONTROL)
$Esc = New-Object Keyboard.Key ([Keyboard.Messaging+VKeys]::KEY_ESCAPE)

$S = New-Object Keyboard.Key ([Keyboard.Messaging+VKeys]::KEY_S)


Start-Sleep 3
[TestTest.Test]::SetForegroundWindow($H)

Send-Key 'S'

$LCtrl.Down($H)
Start-Sleep -Milliseconds 20
$Esc.Down($H)
Start-Sleep -Milliseconds 20
$Esc.Up($H)
Start-Sleep -Milliseconds 20
$LCtrl.Up($H)


<#
$wsh = New-Object -Com WScript.Shell
$wsh.AppActivate($P.MainWindowTitle)
start-sleep -m 250
$wsh.SendKeys('{TAB}')
start-sleep -m 250
$wsh.SendKeys('{ENTER}')

#http://www.codeguru.com/vb/gen/vb_system/keyboard/article.php/c14629/SendKeys.htm
$SK = New-Object System.Windows.Forms.SendKeys
#>
