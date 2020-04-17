; User defines
!define PRODUCT_EXE "SupervisorioAutoclave"   ;${PRODUCT_EXE}
!define UNINSTALL_NAME "Desinstalar"          ;${UNINSTALL_NAME}

; HM NIS Edit Wizard helper defines
!define PRODUCT_NAME "Supervisorio Autoclave"     ;${PRODUCT_NAME} 
!define PRODUCT_VERSION "1.2.1"
!define PRODUCT_PUBLISHER "FRASEL"
!define PRODUCT_WEB_SITE "https://github.com/GLuisF/Supervisorio-Autoclave/"
!define PRODUCT_DIR_REGKEY "Software\Microsoft\Windows\CurrentVersion\App Paths\${PRODUCT_EXE}.exe"
!define PRODUCT_UNINST_KEY "Software\Microsoft\Windows\CurrentVersion\Uninstall\${PRODUCT_NAME}"
!define PRODUCT_ROOT_KEY "HKLM"
!define PRODUCT_STARTMENU_REGVAL "NSIS:StartMenuDir"

; MUI 2 compatible
!include "MUI2.nsh"
; For the GetSize function
!include "FileFunc.nsh"
Unicode true

; MUI Settings
!define MUI_ABORTWARNING
!define MUI_ICON "Icon.ico" ;"${NSISDIR}\Contrib\Graphics\Icons\modern-install.ico"
!define MUI_UNICON "Icon.ico" ;"${NSISDIR}\Contrib\Graphics\Icons\modern-uninstall.ico"
!define MUI_HEADERIMAGE
!define MUI_HEADERIMAGE_BITMAP "HEADER.bmp"
!define MUI_HEADERIMAGE_RIGHT

; Language Selection Dialog Settings
!define MUI_LANGDLL_REGISTRY_ROOT "${PRODUCT_ROOT_KEY}"
!define MUI_LANGDLL_REGISTRY_KEY "${PRODUCT_UNINST_KEY}"
!define MUI_LANGDLL_REGISTRY_VALUENAME "NSIS:Language"

; Welcome page
!insertmacro MUI_PAGE_WELCOME
; License page
!insertmacro MUI_PAGE_LICENSE "License.txt"
; Components page
!insertmacro MUI_PAGE_COMPONENTS
; Directory page
!insertmacro MUI_PAGE_DIRECTORY
; Start menu page
var ICONS_GROUP
!define MUI_STARTMENUPAGE_NODISABLE
!define MUI_STARTMENUPAGE_DEFAULTFOLDER "${PRODUCT_PUBLISHER}"
!define MUI_STARTMENUPAGE_REGISTRY_ROOT "${PRODUCT_ROOT_KEY}"
!define MUI_STARTMENUPAGE_REGISTRY_KEY "${PRODUCT_UNINST_KEY}"
!define MUI_STARTMENUPAGE_REGISTRY_VALUENAME "${PRODUCT_STARTMENU_REGVAL}"
!insertmacro MUI_PAGE_STARTMENU Application $ICONS_GROUP
; Instfiles page
!insertmacro MUI_PAGE_INSTFILES
; Finish page
;!define MUI_FINISHPAGE_RUN_NOTCHECKED
!define MUI_FINISHPAGE_RUN "$INSTDIR\${PRODUCT_EXE}.exe"
!define MUI_FINISHPAGE_SHOWREADME_NOTCHECKED
!define MUI_FINISHPAGE_SHOWREADME "$INSTDIR\LEIA-ME.txt"
!insertmacro MUI_PAGE_FINISH

; Uninstaller pages
!insertmacro MUI_UNPAGE_INSTFILES

; Language files
!insertmacro MUI_LANGUAGE "English"
!insertmacro MUI_LANGUAGE "PortugueseBR"
!insertmacro MUI_LANGUAGE "Spanish"

; Reserve files
;!insertmacro MUI_RESERVEFILE_INSTALLOPTIONS

; MUI end ------

Name "${PRODUCT_NAME} v${PRODUCT_VERSION}"
OutFile "${PRODUCT_EXE}-v${PRODUCT_VERSION}-Setup.exe"
InstallDir "$PROGRAMFILES\${PRODUCT_PUBLISHER}"
InstallDirRegKey ${PRODUCT_ROOT_KEY} "${PRODUCT_DIR_REGKEY}" ""
ShowInstDetails show
ShowUnInstDetails show

Function .onInit
  !insertmacro MUI_LANGDLL_DISPLAY
FunctionEnd

Section "${PRODUCT_NAME}" SEC01
  SetOutPath "$INSTDIR"
  SetOverwrite on                 ;ifnewer
  File "${PRODUCT_EXE}.exe"
  File "LEIA-ME.txt"

; Get size of installation
  ${GetSize} "$INSTDIR" "/S=0K" $0 $1 $2
  IntFmt $0 "0x%08X" $0

; Shortcuts
  !insertmacro MUI_STARTMENU_WRITE_BEGIN Application
  CreateDirectory "$SMPROGRAMS\$ICONS_GROUP"
  CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\${PRODUCT_NAME}.lnk" "$INSTDIR\${PRODUCT_EXE}.exe"
  CreateShortCut "$DESKTOP\${PRODUCT_NAME}.lnk" "$INSTDIR\${PRODUCT_EXE}.exe"
  !insertmacro MUI_STARTMENU_WRITE_END
SectionEnd

Section -AdditionalIcons
  !insertmacro MUI_STARTMENU_WRITE_BEGIN Application
  WriteIniStr "$INSTDIR\${PRODUCT_NAME} Website.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  WriteIniStr "$SMPROGRAMS\$ICONS_GROUP\${PRODUCT_NAME} Website.url" "InternetShortcut" "URL" "${PRODUCT_WEB_SITE}"
  ;CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\Website.lnk" "$INSTDIR\${PRODUCT_NAME}.url"
  CreateShortCut "$SMPROGRAMS\$ICONS_GROUP\${UNINSTALL_NAME}.lnk" "$INSTDIR\${UNINSTALL_NAME}.exe"
  !insertmacro MUI_STARTMENU_WRITE_END
SectionEnd

Section -Post
  WriteUninstaller "$INSTDIR\${UNINSTALL_NAME}.exe"
  WriteRegStr ${PRODUCT_ROOT_KEY} "${PRODUCT_DIR_REGKEY}" "" "$INSTDIR\${PRODUCT_EXE}.exe"
  WriteRegStr ${PRODUCT_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayName" "$(^Name)"
  WriteRegStr ${PRODUCT_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "UninstallString" "$INSTDIR\${UNINSTALL_NAME}.exe"
  WriteRegStr ${PRODUCT_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayIcon" "$INSTDIR\${PRODUCT_EXE}.exe"
  WriteRegDWORD ${PRODUCT_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "EstimatedSize" "$0"
  WriteRegStr ${PRODUCT_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "DisplayVersion" "${PRODUCT_VERSION}"
  WriteRegStr ${PRODUCT_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "URLInfoAbout" "${PRODUCT_WEB_SITE}"
  WriteRegStr ${PRODUCT_ROOT_KEY} "${PRODUCT_UNINST_KEY}" "Publisher" "${PRODUCT_PUBLISHER}"
SectionEnd

; Section descriptions
!insertmacro MUI_FUNCTION_DESCRIPTION_BEGIN
  !insertmacro MUI_DESCRIPTION_TEXT ${SEC01} ""
!insertmacro MUI_FUNCTION_DESCRIPTION_END


Function un.onUninstSuccess
  HideWindow
  MessageBox MB_ICONINFORMATION|MB_OK "$(^Name) foi removido com sucesso do seu computador."
FunctionEnd

Function un.onInit
!insertmacro MUI_UNGETLANGUAGE
  MessageBox MB_ICONQUESTION|MB_YESNO|MB_DEFBUTTON2 "Tem certeza que quer remover completamente $(^Name) e todos os seus componentes?" IDYES +2
  Abort
FunctionEnd

Section Uninstall
  !insertmacro MUI_STARTMENU_GETFOLDER "Application" $ICONS_GROUP
  Delete "$INSTDIR\${PRODUCT_NAME} Website.url"
  Delete "$INSTDIR\${UNINSTALL_NAME}.exe"
  Delete "$INSTDIR\LEIA-ME.txt"
  Delete "$INSTDIR\${PRODUCT_EXE}.exe"

  Delete "$SMPROGRAMS\$ICONS_GROUP\${UNINSTALL_NAME}.lnk"
  Delete "$SMPROGRAMS\$ICONS_GROUP\${PRODUCT_NAME} Website.url"
  Delete "$DESKTOP\${PRODUCT_NAME}.lnk"
  Delete "$SMPROGRAMS\$ICONS_GROUP\${PRODUCT_NAME}.lnk"

  RMDir "$SMPROGRAMS\$ICONS_GROUP"
  RMDir "$INSTDIR"

  DeleteRegKey ${PRODUCT_ROOT_KEY} "${PRODUCT_UNINST_KEY}"
  DeleteRegKey ${PRODUCT_ROOT_KEY} "${PRODUCT_DIR_REGKEY}"
  SetAutoClose true
SectionEnd