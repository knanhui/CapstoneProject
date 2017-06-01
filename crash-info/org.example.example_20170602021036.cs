S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 12999
Date: 2017-06-02 02:10:36+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xc

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xbfb64690
ebp = 0xbfb647a8, esp = 0xbfb64650
eax = 0x00000023, ebx = 0xb381a000
ecx = 0x00000000, edx = 0xbfb6468c
eip = 0xb3815aad

Memory Information
MemTotal:      123 KB
MemFree:        21 KB
Buffers:        10 KB
Cached:     181992 KB
VmPeak:     100460 KB
VmSize:     100460 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22004 KB
VmRSS:       22004 KB
VmData:      32904 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34464 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 12999 TID = 12999
12999 13000 13161 13162 

Maps Information
b2bd6000 b2be0000 r-xp /usr/lib/libfeedback.so.0.1.4
b2be6000 b2bf2000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bf3000 b2c14000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c19000 b2c1a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c1b000 b2c20000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c21000 b2c23000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c24000 b2c26000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c27000 b2c33000 r-xp /usr/lib/libdrm.so.2.4.0
b2c34000 b2c37000 r-xp /usr/lib/libdri2.so.0.0.0
b2c38000 b2c42000 r-xp /usr/lib/libtbm.so.1.0.0
b2c43000 b2c58000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c59000 b2c6b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b346d000 b349e000 r-xp /usr/lib/libidn.so.11.5.44
b349f000 b34c1000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34c2000 b34d2000 r-xp /usr/lib/libcares.so.2.1.0
b34d3000 b34dc000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34dd000 b34e6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34e7000 b355e000 r-xp /usr/lib/libcurl.so.4.3.0
b3560000 b3572000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3573000 b3594000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b359b000 b359c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b359d000 b359e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b359f000 b35a2000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35a3000 b35a6000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36ae000 b36b4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36b5000 b37f9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3809000 b380a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b380b000 b380c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b380d000 b3819000 r-xp /opt/usr/apps/org.example.example/bin/example
b381b000 b3854000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4257000 b4262000 r-xp /lib/libnss_files-2.20-2014.11.so
b4264000 b426f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4271000 b4288000 r-xp /lib/libnsl-2.20-2014.11.so
b428c000 b4294000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4296000 b42ba000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42bb000 b42bc000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42bd000 b42c0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42c1000 b42c8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42c9000 b42d3000 r-xp /usr/lib/libsensord-share.so
b42d4000 b42f0000 r-xp /usr/lib/libsensor.so.1.2.0
b42f2000 b42fb000 r-xp /usr/lib/libappcore-common.so.1.1
b42fe000 b4300000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4315000 b4317000 r-xp /usr/lib/libXau.so.6.0.0
b4318000 b433a000 r-xp /usr/lib/libxcb.so.1.1.0
b433c000 b4345000 r-xp /lib/libcrypt-2.20-2014.11.so
b436e000 b4370000 r-xp /usr/lib/libiri.so
b4371000 b4397000 r-xp /lib/libexpat.so.1.5.2
b4399000 b4404000 r-xp /usr/lib/libssl.so.1.0.0
b440a000 b4416000 r-xp /usr/lib/libethumb.so.1.13.0
b4417000 b441b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b441c000 b466d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5be8000 b5bf8000 r-xp /usr/lib/libXi.so.6.1.0
b5bf9000 b5bfb000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bfc000 b5c02000 r-xp /usr/lib/libXtst.so.6.1.0
b5c03000 b5c0d000 r-xp /usr/lib/libXrender.so.1.3.0
b5c0e000 b5c17000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c19000 b5c1b000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c1c000 b5c21000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c22000 b5c34000 r-xp /usr/lib/libXext.so.6.4.0
b5c35000 b5c37000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c38000 b5c3a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c3c000 b5d7e000 r-xp /usr/lib/libX11.so.6.3.0
b5d82000 b5d8c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d8d000 b5da3000 r-xp /usr/lib/libudev.so.1.6.0
b5da6000 b5daa000 r-xp /lib/libattr.so.1.1.0
b5dab000 b5dda000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5ddc000 b5de2000 r-xp /usr/lib/libffi.so.6.0.2
b5de3000 b5e06000 r-xp /lib/libz.so.1.2.8
b5e07000 b5e0a000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e0b000 b5f67000 r-xp /usr/lib/libxml2.so.2.9.2
b5f6d000 b6054000 r-xp /usr/lib/libstdc++.so.6.0.20
b6061000 b6064000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6065000 b6087000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6088000 b609c000 r-xp /lib/libresolv-2.20-2014.11.so
b60a0000 b60c4000 r-xp /usr/lib/liblzma.so.5.0.3
b60c5000 b60c7000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60c9000 b60d3000 r-xp /usr/lib/libembryo.so.1.13.0
b60d4000 b60fd000 r-xp /usr/lib/libpng12.so.0.50.0
b60fe000 b6147000 r-xp /usr/lib/libjpeg.so.8.0.2
b6158000 b615f000 r-xp /lib/librt-2.20-2014.11.so
b6161000 b6180000 r-xp /usr/lib/libector.so.1.13.0
b6183000 b61b0000 r-xp /usr/lib/liblua-5.1.so
b61b1000 b6241000 r-xp /usr/lib/libfreetype.so.6.11.3
b6245000 b6283000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6284000 b629a000 r-xp /usr/lib/libfribidi.so.0.3.1
b629b000 b62f4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62f7000 b6342000 r-xp /lib/libm-2.20-2014.11.so
b6344000 b6356000 r-xp /usr/lib/libeio.so.1.13.0
b6357000 b635a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b635b000 b6361000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6362000 b6385000 r-xp /usr/lib/libefreet.so.1.13.0
b6388000 b63b3000 r-xp /usr/lib/libeldbus.so.1.13.0
b63b4000 b63e8000 r-xp /usr/lib/libecore_con.so.1.13.0
b63ea000 b63f3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63f4000 b63fd000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63fe000 b6411000 r-xp /usr/lib/libeo.so.1.13.0
b6413000 b6426000 r-xp /usr/lib/libecore_input.so.1.13.0
b6427000 b642e000 r-xp /usr/lib/libecore_file.so.1.13.0
b642f000 b6452000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6453000 b647f000 r-xp /usr/lib/libeet.so.1.13.0
b6488000 b64f3000 r-xp /usr/lib/libeina.so.1.13.0
b64f6000 b650d000 r-xp /usr/lib/libefl.so.1.13.0
b650f000 b6676000 r-xp /usr/lib/libicuuc.so.51.1
b6684000 b6890000 r-xp /usr/lib/libicui18n.so.51.1
b6898000 b68e7000 r-xp /usr/lib/libecore_x.so.1.13.0
b68e9000 b6903000 r-xp /lib/libgcc_s-4.9.so.1
b6905000 b6909000 r-xp /lib/libcap.so.2.21
b690a000 b6950000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6951000 b6958000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b695a000 b69ac000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69ae000 b6b39000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b3e000 b6c0c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c0f000 b6c13000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c14000 b6c23000 r-xp /usr/lib/libvconf.so.0.2.45
b6c24000 b6c27000 r-xp /usr/lib/libvasum.so.0.3.1
b6c28000 b6c2b000 r-xp /usr/lib/libttrace.so.1.1
b6c2d000 b6c31000 r-xp /usr/lib/libiniparser.so.0
b6c32000 b6c62000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c63000 b6c6c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c6d000 b6c92000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c93000 b6ca3000 r-xp /usr/lib/libunwind.so.8.0.1
b6cad000 b6e5b000 r-xp /lib/libc-2.20-2014.11.so
b6e63000 b6fa6000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fa8000 b7000000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7001000 b7035000 r-xp /usr/lib/libsystemd.so.0.4.0
b7038000 b710c000 r-xp /usr/lib/libedje.so.1.13.0
b710f000 b713b000 r-xp /usr/lib/libecore.so.1.13.0
b714c000 b7372000 r-xp /usr/lib/libevas.so.1.13.0
b739a000 b73b2000 r-xp /lib/libpthread-2.20-2014.11.so
b73b6000 b7730000 r-xp /usr/lib/libelementary.so.1.13.0
b7750000 b7754000 r-xp /usr/lib/libsmack.so.1.0.0
b7755000 b775e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b775f000 b7762000 r-xp /usr/lib/libdlog.so.0.0.0
b7763000 b7768000 r-xp /usr/lib/libbundle.so.0.1.22
b7769000 b776c000 r-xp /lib/libdl-2.20-2014.11.so
b776e000 b7793000 r-xp /usr/lib/libaul.so.0.1.0
b7796000 b7798000 r-xp /usr/lib/libappsvc.so.0.1.0
b7799000 b779e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b779f000 b77a6000 r-xp /usr/lib/libappcore-efl.so.1.1
b77a8000 b77ad000 r-xp /usr/lib/libsys-assert.so
b77b0000 b77b1000 r-xp [vdso]
b77b1000 b77d3000 r-xp /lib/ld-2.20-2014.11.so
b77d5000 b77dd000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12999)
Call Stack Count: 19
 0: InsertRecord + 0xbd (0xb3815aad) [/opt/usr/apps/org.example.example/bin/example] + 0x8aad
 1: setting_view_cb + 0x54 (0xb38158c4) [/opt/usr/apps/org.example.example/bin/example] + 0x88c4
 2: (0xb7180449) [/usr/lib/libevas.so.1] + 0x34449
 3: (0xb640c319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb6409d63) [/usr/lib/libeo.so.1] + 0xbd63
 5: (0xb7180a62) [/usr/lib/libevas.so.1] + 0x34a62
 6: (0xb718f441) [/usr/lib/libevas.so.1] + 0x43441
 7: evas_canvas_event_feed_mouse_down + 0xcf (0xb719920f) [/usr/lib/libevas.so.1] + 0x4d20f
 8: evas_event_feed_mouse_down + 0x6a (0xb719fc2a) [/usr/lib/libevas.so.1] + 0x53c2a
 9: (0xb441949c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
10: (0xb711c055) [/usr/lib/libecore.so.1] + 0xd055
11: (0xb71251b9) [/usr/lib/libecore.so.1] + 0x161b9
12: ecore_main_loop_begin + 0x57 (0xb7125587) [/usr/lib/libecore.so.1] + 0x16587
13: elm_run + 0x2d (0xb757e22d) [/usr/lib/libelementary.so.1] + 0x1c822d
14: appcore_efl_main + 0x4de (0xb77a2dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
15: ui_app_main + 0x140 (0xb779bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
16: main + 0x2e1 (0xb38149a1) [/opt/usr/apps/org.example.example/bin/example] + 0x79a1
17: (0xb77d7148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77d7148
18: __libc_start_main + 0xde (0xb6cc4e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.example
Package ID : org.example.example
Version: 1.0.0
Package Type: tpk
App Name: forpet
App ID: org.example.example
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 pageId[100001]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[4]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[5], [1, 2]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[5], [1, 2]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.477+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.email] Name[Email] Icon[/usr/apps/org.tizen.email/shared/res/org.tizen.email.png] enable[1] system[1]
06-02 02:10:33.477+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.email'], count[1]
06-02 02:10:33.477+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.email]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.477+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.emailui] Name[emailui] Icon[/opt/usr/apps/org.example.emailui/shared/res/emailui.png] enable[1] system[0]
06-02 02:10:33.477+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.emailui'], count[0]
06-02 02:10:33.477+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.emailui][-17956860][0]
06-02 02:10:33.477+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.emailui]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[emailui] pos[3, 2] pageId[100001]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[7], [3, 2]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.477+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-02 02:10:33.477+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-02 02:10:33.477+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-02 02:10:33.477+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-02 02:10:33.477+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-02 02:10:33.477+0900 D/test-log( 2878): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-02 02:10:33.477+0900 D/test-log( 2878): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-02 02:10:33.537+0900 D/test-log( 2878): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-02 02:10:33.537+0900 D/test-log( 2878): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-02 02:10:33.537+0900 D/BADGE   ( 2878): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-02 02:10:33.537+0900 E/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-02 02:10:33.537+0900 D/cluster-home( 2878): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-02 02:10:33.537+0900 D/cluster-view( 2878): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-02 02:10:33.647+0900 D/rpm-installer(13101): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-02 02:10:33.647+0900 D/rpm-installer(13101): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-02 02:10:33.647+0900 D/rpm-installer(13101): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-02 02:10:33.647+0900 D/rpm-installer(13101): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-02 02:10:33.647+0900 D/PKGMGR_SERVER(13087): pkgmgr-server.c: sighandler(387) > child exit [13101]
06-02 02:10:33.667+0900 E/PKGMGR_SERVER(13087): pkgmgr-server.c: sighandler(402) > child NORMAL exit [13101]
06-02 02:10:33.997+0900 E/PKGMGR_SERVER(13087): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-02 02:10:33.997+0900 E/PKGMGR_SERVER(13087): pkgmgr-server.c: main(2265) > package manager server terminated.
06-02 02:10:34.497+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 0
06-02 02:10:34.497+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-02 02:10:34.497+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-02 02:10:34.497+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-02 02:10:34.497+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-02 02:10:34.497+0900 D/AUL     ( 2767): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 13155, pid = 13157
06-02 02:10:34.497+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-02 02:10:34.497+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-02 02:10:34.497+0900 I/AUL     ( 2767): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-02 02:10:34.497+0900 E/AUL_AMD ( 2767): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-02 02:10:34.497+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2233) > caller pid : 13157
06-02 02:10:34.497+0900 E/AUL_AMD ( 2767): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-02 02:10:34.497+0900 W/AUL_AMD ( 2767): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-02 02:10:34.497+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2648) > process_pool: false
06-02 02:10:34.497+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-02 02:10:34.497+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-02 02:10:34.497+0900 W/AUL_AMD ( 2767): amd_launch.c: _start_app(2665) > pad pid(-5)
06-02 02:10:34.497+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-02 02:10:34.497+0900 D/AUL_AMD ( 2767): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-02 02:10:34.497+0900 D/AUL     ( 2767): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-02 02:10:34.497+0900 W/AUL_PAD ( 2927): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-02 02:10:34.497+0900 D/AUL     ( 2927): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 12999, bin path: /opt/usr/apps/org.example.example/bin/example
06-02 02:10:34.497+0900 W/AUL_PAD ( 2927): launchpad.c: __send_result_to_caller(265) > Check app launching
06-02 02:10:34.497+0900 D/AUL_PAD ( 2927): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-02 02:10:34.497+0900 D/RESOURCED( 2860): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-02 02:10:34.497+0900 D/RESOURCED( 2860): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-02 02:10:34.497+0900 E/RESOURCED( 2860): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-02 02:10:34.497+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-02 02:10:34.497+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-02 02:10:34.497+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-02 02:10:34.497+0900 D/AUL_PAD (12999): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-02 02:10:34.497+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-02 02:10:34.497+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-02 02:10:34.497+0900 D/AUL     (12999): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (13000) is sent.
06-02 02:10:34.497+0900 D/AUL     (12999): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 13000, signo: 10
06-02 02:10:34.507+0900 D/AUL     (12999): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYzMzcwMzQvNDk4OTIyAA==##
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMzE1NwA=##
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-02 02:10:34.507+0900 D/AUL_PAD (12999): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-02 02:10:34.507+0900 I/CAPI_APPFW_APPLICATION(12999): app_main.c: ui_app_main(788) > app_efl_main
06-02 02:10:34.507+0900 D/LAUNCH  (12999): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-02 02:10:34.507+0900 D/APP_CORE(12999): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-02 02:10:34.507+0900 D/APP_CORE(12999): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-02 02:10:34.507+0900 D/APP_CORE(12999): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-02 02:10:34.537+0900 D/APP_CORE(12999): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-02 02:10:34.537+0900 D/AUL     (12999): app_sock.c: __create_server_sock(156) > pg path - already exists
06-02 02:10:34.537+0900 D/APP_CORE(12999): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42fb520
06-02 02:10:34.537+0900 D/LAUNCH  (12999): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-02 02:10:34.537+0900 I/CAPI_APPFW_APPLICATION(12999): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-02 02:10:34.607+0900 D/AUL_PAD ( 2927): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-02 02:10:34.607+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 12999, appid: org.example.example
06-02 02:10:34.607+0900 D/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-02 02:10:34.607+0900 E/AUL     ( 2767): simple_util.c: __trm_app_info_send_socket(330) > access
06-02 02:10:34.607+0900 D/AUL_AMD ( 2767): amd_launch.c: _start_app(2700) > add app group info
06-02 02:10:34.607+0900 E/AUL     ( 2767): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-02 02:10:34.607+0900 D/AUL_AMD ( 2767): amd_status.c: _status_add_app_info_list(427) > pid(12999) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-02 02:10:34.607+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 12999
06-02 02:10:34.607+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-02 02:10:34.607+0900 E/RESOURCED( 2860): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-02 02:10:34.607+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(888) > available memory = 315
06-02 02:10:34.647+0900 D/LAUNCH  (12999): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-02 02:10:34.647+0900 D/APP_CORE(12999): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-02 02:10:34.657+0900 E/E17     ( 2740): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-02 02:10:34.697+0900 E/E17     ( 2740): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-02 02:10:34.717+0900 D/APP_CORE(12999): appcore.c: __aul_handler(587) > [APP 12999]     AUL event: AUL_START
06-02 02:10:34.717+0900 I/APP_CORE(12999): appcore-efl.c: __do_app(496) > [APP 12999] Event: RESET State: CREATED
06-02 02:10:34.717+0900 D/APP_CORE(12999): appcore-efl.c: __do_app(527) > [APP 12999] RESET
06-02 02:10:34.717+0900 D/LAUNCH  (12999): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-02 02:10:34.727+0900 D/APP_CORE(12999): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-02 02:10:34.727+0900 D/APP_CORE(12999): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-02 02:10:34.727+0900 I/CAPI_APPFW_APPLICATION(12999): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-02 02:10:34.727+0900 D/AUL     (12999): service.c: __set_bundle(186) > __set_bundle
06-02 02:10:34.727+0900 D/LAUNCH  (12999): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-02 02:10:34.727+0900 D/APP_CORE(12999): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-02 02:10:34.727+0900 E/EFL     (12999): edje<12999> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-02 02:10:34.727+0900 E/EFL     (12999): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 02:10:34.727+0900 E/EFL     (12999): edje<12999> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-02 02:10:34.727+0900 E/EFL     (12999): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 02:10:34.727+0900 E/EFL     (12999): edje<12999> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-02 02:10:34.727+0900 E/EFL     (12999): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 02:10:34.727+0900 E/EFL     (12999): edje<12999> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-02 02:10:34.727+0900 E/EFL     (12999): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 02:10:34.727+0900 E/EFL     (12999): edje<12999> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-02 02:10:34.727+0900 E/EFL     (12999): By the power of Grayskull, your previous Embryo stack is now broken!
06-02 02:10:34.727+0900 W/PROCESSMGR( 2740): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12999
06-02 02:10:34.747+0900 E/EFL     ( 2740): eo<2740> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-02 02:10:34.747+0900 E/EFL     ( 2740): eo<2740> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-02 02:10:34.767+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 15
06-02 02:10:34.767+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-02 02:10:34.767+0900 D/PKGMGR_INFO( 2767): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-02 02:10:34.767+0900 D/AUL_AMD ( 2767): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12999 is org.example.example
06-02 02:10:34.767+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12999 : 0
06-02 02:10:34.777+0900 D/AUL     ( 2944): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-02 02:10:34.777+0900 D/INDICATOR( 2863): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-02 02:10:34.797+0900 W/APP_CORE(12999): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-02 02:10:34.797+0900 D/APP_CORE(12999): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-02 02:10:34.797+0900 D/APP_CORE(12999): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-02 02:10:34.797+0900 D/AUL     (12999): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-02 02:10:34.797+0900 D/AUL_AMD ( 2767): amd_request.c: __request_handler(838) > __request_handler: 34
06-02 02:10:34.807+0900 D/INDICATOR( 2863): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-02 02:10:34.807+0900 D/INDICATOR( 2863): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-02 02:10:34.807+0900 D/INDICATOR( 2863): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-02 02:10:34.807+0900 D/INDICATOR( 2863): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-02 02:10:34.807+0900 D/INDICATOR( 2863): main.c: _rotate_window(252) > port :: hide more icon
06-02 02:10:35.047+0900 D/APP_CORE(12999): appcore.c: __prt_ltime(236) > [APP 12999] first idle after reset: 560 msec
06-02 02:10:35.147+0900 E/E17     ( 2740): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-02 02:10:35.157+0900 D/APP_CORE( 2878): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-02 02:10:35.157+0900 D/APP_CORE( 2878): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-02 02:10:35.157+0900 D/APP_CORE( 2878): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-02 02:10:35.157+0900 I/APP_CORE( 2878): appcore-efl.c: __do_app(496) > [APP 2878] Event: PAUSE State: RUNNING
06-02 02:10:35.157+0900 D/APP_CORE( 2878): appcore-efl.c: __do_app(565) > [APP 2878] PAUSE
06-02 02:10:35.157+0900 I/CAPI_APPFW_APPLICATION( 2878): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-02 02:10:35.157+0900 E/cluster-home( 2878): homescreen.cpp: OnPause(84) >  app pause
06-02 02:10:35.157+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-02 02:10:35.157+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppPause(923) >  END
06-02 02:10:35.157+0900 D/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-02 02:10:35.157+0900 E/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-02 02:10:35.167+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(2878) status(4)
06-02 02:10:35.167+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(2878) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-02 02:10:35.167+0900 D/AUL     ( 2767): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-02 02:10:35.167+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2878, appid: org.tizen.homescreen, status: bg
06-02 02:10:35.167+0900 D/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2891) > pid(12999) status(3)
06-02 02:10:35.167+0900 D/AUL_AMD ( 2767): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-02 02:10:35.167+0900 D/DATA_PROVIDER_MASTER( 2930): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2878 is paused
06-02 02:10:35.167+0900 D/DATA_PROVIDER_MASTER( 2930): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-02 02:10:35.177+0900 I/CAPI_WIDGET_APPLICATION( 3020): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-02 02:10:35.177+0900 I/CAPI_WIDGET_APPLICATION( 3020): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-02 02:10:35.177+0900 W/AUL     ( 3020): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3020, appid: org.tizen.calendar.widget, status: bg
06-02 02:10:35.177+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3020, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-02 02:10:35.177+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3020
06-02 02:10:35.177+0900 D/RESOURCED( 2860): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3020, appname = org.tizen.calendar.widget
06-02 02:10:35.177+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3020
06-02 02:10:35.197+0900 D/APP_CORE(12999): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-02 02:10:35.197+0900 D/APP_CORE(12999): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-02 02:10:35.197+0900 D/APP_CORE(12999): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-02 02:10:35.197+0900 I/APP_CORE(12999): appcore-efl.c: __do_app(496) > [APP 12999] Event: RESUME State: CREATED
06-02 02:10:35.197+0900 D/LAUNCH  (12999): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-02 02:10:35.197+0900 D/APP_CORE(12999): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-02 02:10:35.197+0900 D/APP_CORE(12999): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-02 02:10:35.197+0900 D/APP_CORE(12999): appcore-efl.c: __do_app(607) > [APP 12999] RESUME
06-02 02:10:35.197+0900 W/AUL_AMD ( 2767): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 02:10:35.197+0900 W/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-02 02:10:35.197+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(12999) status(3)
06-02 02:10:35.197+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(12999) appid(org.example.example) pkgid(org.example.example) status(3)
06-02 02:10:35.197+0900 D/AUL     ( 2767): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-02 02:10:35.197+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12999, appid: org.example.example, status: fg
06-02 02:10:35.207+0900 I/APP_CORE(12999): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-02 02:10:35.207+0900 I/APP_CORE(12999): appcore-efl.c: __do_app(614) > [APP 12999] Initial Launching, call the resume_cb
06-02 02:10:35.207+0900 I/CAPI_APPFW_APPLICATION(12999): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-02 02:10:35.207+0900 D/LAUNCH  (12999): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-02 02:10:35.207+0900 D/LAUNCH  (12999): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-02 02:10:35.207+0900 D/APP_CORE(12999): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-02 02:10:35.207+0900 E/APP_CORE(12999): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-02 02:10:35.207+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12999
06-02 02:10:35.207+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12999, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-02 02:10:35.207+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12999
06-02 02:10:35.257+0900 D/RESOURCED( 2860): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12999, appname = org.example.example, pkgname = org.example.example
06-02 02:10:35.257+0900 D/RESOURCED( 2860): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12999, appname = org.example.example
06-02 02:10:35.257+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12999
06-02 02:10:35.257+0900 I/RESOURCED( 2860): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-02 02:10:35.257+0900 I/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-02 02:10:35.337+0900 D/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2910) > pid(12999) status(0)
06-02 02:10:35.607+0900 D/AUL_PAD ( 2927): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-02 02:10:35.607+0900 D/AUL_PAD (13164): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-02 02:10:35.617+0900 D/AUL_PAD ( 2927): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-02 02:10:35.627+0900 E/RESOURCED( 2860): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1167
06-02 02:10:36.117+0900 D/AUL_AMD ( 2767): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-02 02:10:36.117+0900 D/RUA     ( 2767): rua.c: rua_add_history(179) > rua_add_history start
06-02 02:10:36.217+0900 D/RUA     ( 2767): rua.c: rua_add_history(247) > rua_add_history ok
06-02 02:10:36.447+0900 I/tag     (12999): insert~~~
06-02 02:10:36.537+0900 D/PROCESSMGR( 2740): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x602384 
06-02 02:10:36.547+0900 D/AUL_PAD ( 2927): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-02 02:10:36.547+0900 D/AUL_PAD ( 2927): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-02 02:10:36.547+0900 D/AUL_PAD ( 2927): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-02 02:10:36.547+0900 D/AUL_PAD ( 2927): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-02 02:10:36.547+0900 D/AUL_PAD ( 2927): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-02 02:10:36.547+0900 D/AUL_PAD ( 2927): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-02 02:10:36.547+0900 D/AUL_PAD ( 2927): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-02 02:10:36.547+0900 I/AUL_PAD ( 2927): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 12999 pgid = 12999
06-02 02:10:36.547+0900 I/AUL_PAD ( 2927): sigchild.h: __sigchild_action(142) > dead_pid(12999)
06-02 02:10:36.547+0900 E/EFL     ( 2740): eo<2740> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-02 02:10:36.567+0900 D/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2891) > pid(2878) status(3)
06-02 02:10:36.567+0900 D/AUL_AMD ( 2767): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-02 02:10:36.567+0900 D/AUL_PAD ( 2927): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-02 02:10:36.567+0900 I/AUL_PAD ( 2927): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-02 02:10:36.567+0900 I/AUL_PAD ( 2927): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-02 02:10:36.567+0900 E/AUL_PAD ( 2927): launchpad.c: main(688) > error reading sigchld info
06-02 02:10:36.577+0900 I/ESD     ( 2942): esd_main.c: __esd_app_dead_handler(1771) > pid: 12999
06-02 02:10:36.577+0900 D/STARTER ( 2857): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 12999 is termianted
06-02 02:10:36.577+0900 D/STARTER ( 2857): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-02 02:10:36.577+0900 W/AUL_AMD ( 2767): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-02 02:10:36.577+0900 W/AUL_AMD ( 2767): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-02 02:10:36.577+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(456) > pid(2878) status(3)
06-02 02:10:36.577+0900 D/AUL_AMD ( 2767): amd_status.c: _status_update_app_info_list(468) > pid(2878) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-02 02:10:36.577+0900 D/AUL     ( 2767): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-02 02:10:36.577+0900 W/AUL     ( 2767): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2878, appid: org.tizen.homescreen, status: fg
06-02 02:10:36.577+0900 W/CRASH_MANAGER(13165): worker.c: worker_job(1204) > 1112999657861149633703
