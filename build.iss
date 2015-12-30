; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "VAF FTC Match Timer"
#define MyAppVersion "15.1512.29"
#define MyAppPublisher "VirginiaFIRST"
#define MyAppURL "http://www.virginiafirst.org"
#define MyAppExeName "FTC-Timer-Display.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{CC95291B-6081-4A84-947A-C77E0AF1A869}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
OutputBaseFilename=VAF-FTC-Timer
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Components]
Name: app; Description: "Application Files"; Types: full compact custom; Flags: fixed
Name: deb; Description: "Debugging Assistance Files"; Types: full custom;
Name: dep; Description: "Dependencies"; Types: full compact custom; Flags: fixed
Name: gs; Description: "Game Sounds"; Types: full compact custom; Flags: fixed
Name: ns; Description: "Numbers"; Types: full compact custom; Flags: fixed

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\Users\mglennon\Documents\Visual Studio 2013\Projects\FTC-Timer-App\FTC-Timer-Display\bin\Debug\FTC-Timer-Display.exe"; DestDir: "{app}"; Flags: ignoreversion; Components: app
Source: "C:\Users\mglennon\Documents\Visual Studio 2013\Projects\FTC-Timer-App\FTC-Timer-Display\bin\Debug\FTC-Timer-Display.pdb"; DestDir: "{app}"; Flags: ignoreversion; Components: deb
Source: "C:\Users\mglennon\Documents\Visual Studio 2013\Projects\FTC-Timer-App\FTC-Timer-Display\bin\Debug\DevComponents.DotNetBar2.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: dep
Source: "C:\Users\mglennon\Documents\Visual Studio 2013\Projects\FTC-Timer-App\FTC-Timer-Display\bin\Debug\DevComponents.Instrumentation.dll"; DestDir: "{app}"; Flags: ignoreversion; Components: dep

; Sounds
Source: "C:\Users\mglennon\Documents\Visual Studio 2013\Projects\FTC-Timer-App\FTC-Timer-Display\bin\Debug\Sounds\*"; DestDir: "{app}\Sounds"; Flags: ignoreversion; Components: gs
Source: "C:\Users\mglennon\Documents\Visual Studio 2013\Projects\FTC-Timer-App\FTC-Timer-Display\bin\Debug\Numbers\*"; DestDir: "{app}\Sounds"; Flags: ignoreversion; Components: ns



; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
