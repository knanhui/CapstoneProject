S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 9875
Date: 2017-06-01 21:07:27+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb38088ac, esi = 0x00000000
ebp = 0xbfc5da08, esp = 0xbfc5d890
eax = 0x00000001, ebx = 0xb380b000
ecx = 0xb380b000, edx = 0x00000000
eip = 0xb3807a36

Memory Information
MemTotal:      123 KB
MemFree:        22 KB
Buffers:         7 KB
Cached:     191516 KB
VmPeak:     100472 KB
VmSize:     100472 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22404 KB
VmRSS:       22404 KB
VmData:      32916 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34464 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 9875 TID = 9875
9875 9881 10079 10081 

Maps Information
b2bc7000 b2bd1000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bd7000 b2be3000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2be4000 b2c05000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c0a000 b2c0b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c0c000 b2c11000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c12000 b2c14000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c15000 b2c17000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c18000 b2c24000 r-xp /usr/lib/libdrm.so.2.4.0
b2c25000 b2c28000 r-xp /usr/lib/libdri2.so.0.0.0
b2c29000 b2c33000 r-xp /usr/lib/libtbm.so.1.0.0
b2c34000 b2c49000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c4a000 b2c5c000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b345e000 b348f000 r-xp /usr/lib/libidn.so.11.5.44
b3490000 b34b2000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34b3000 b34c3000 r-xp /usr/lib/libcares.so.2.1.0
b34c4000 b34cd000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34ce000 b34d7000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34d8000 b354f000 r-xp /usr/lib/libcurl.so.4.3.0
b3551000 b3563000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3564000 b3585000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b358c000 b358d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b358e000 b358f000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3590000 b3593000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3594000 b3597000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b369f000 b36a5000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36a6000 b37ea000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37fa000 b37fb000 r-xp /usr/lib/libxshmfence.so.1.0.0
b37fc000 b37fd000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37fe000 b380a000 r-xp /opt/usr/apps/org.example.example/bin/example
b380c000 b3845000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4248000 b4253000 r-xp /lib/libnss_files-2.20-2014.11.so
b4255000 b4260000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4262000 b4279000 r-xp /lib/libnsl-2.20-2014.11.so
b427d000 b4285000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4287000 b42ab000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42ac000 b42ad000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42ae000 b42b1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42b2000 b42b9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ba000 b42c4000 r-xp /usr/lib/libsensord-share.so
b42c5000 b42e1000 r-xp /usr/lib/libsensor.so.1.2.0
b42e3000 b42ec000 r-xp /usr/lib/libappcore-common.so.1.1
b42ef000 b42f1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4306000 b4308000 r-xp /usr/lib/libXau.so.6.0.0
b4309000 b432b000 r-xp /usr/lib/libxcb.so.1.1.0
b432d000 b4336000 r-xp /lib/libcrypt-2.20-2014.11.so
b435f000 b4361000 r-xp /usr/lib/libiri.so
b4362000 b4388000 r-xp /lib/libexpat.so.1.5.2
b438a000 b43f5000 r-xp /usr/lib/libssl.so.1.0.0
b43fb000 b4407000 r-xp /usr/lib/libethumb.so.1.13.0
b4408000 b440c000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b440d000 b465e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bd9000 b5be9000 r-xp /usr/lib/libXi.so.6.1.0
b5bea000 b5bec000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bed000 b5bf3000 r-xp /usr/lib/libXtst.so.6.1.0
b5bf4000 b5bfe000 r-xp /usr/lib/libXrender.so.1.3.0
b5bff000 b5c08000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c0a000 b5c0c000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c0d000 b5c12000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c13000 b5c25000 r-xp /usr/lib/libXext.so.6.4.0
b5c26000 b5c28000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c29000 b5c2b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c2d000 b5d6f000 r-xp /usr/lib/libX11.so.6.3.0
b5d73000 b5d7d000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d7e000 b5d94000 r-xp /usr/lib/libudev.so.1.6.0
b5d97000 b5d9b000 r-xp /lib/libattr.so.1.1.0
b5d9c000 b5dcb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dcd000 b5dd3000 r-xp /usr/lib/libffi.so.6.0.2
b5dd4000 b5df7000 r-xp /lib/libz.so.1.2.8
b5df8000 b5dfb000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dfc000 b5f58000 r-xp /usr/lib/libxml2.so.2.9.2
b5f5e000 b6045000 r-xp /usr/lib/libstdc++.so.6.0.20
b6052000 b6055000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6056000 b6078000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6079000 b608d000 r-xp /lib/libresolv-2.20-2014.11.so
b6091000 b60b5000 r-xp /usr/lib/liblzma.so.5.0.3
b60b6000 b60b8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60ba000 b60c4000 r-xp /usr/lib/libembryo.so.1.13.0
b60c5000 b60ee000 r-xp /usr/lib/libpng12.so.0.50.0
b60ef000 b6138000 r-xp /usr/lib/libjpeg.so.8.0.2
b6149000 b6150000 r-xp /lib/librt-2.20-2014.11.so
b6152000 b6171000 r-xp /usr/lib/libector.so.1.13.0
b6174000 b61a1000 r-xp /usr/lib/liblua-5.1.so
b61a2000 b6232000 r-xp /usr/lib/libfreetype.so.6.11.3
b6236000 b6274000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6275000 b628b000 r-xp /usr/lib/libfribidi.so.0.3.1
b628c000 b62e5000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62e8000 b6333000 r-xp /lib/libm-2.20-2014.11.so
b6335000 b6347000 r-xp /usr/lib/libeio.so.1.13.0
b6348000 b634b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b634c000 b6352000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6353000 b6376000 r-xp /usr/lib/libefreet.so.1.13.0
b6379000 b63a4000 r-xp /usr/lib/libeldbus.so.1.13.0
b63a5000 b63d9000 r-xp /usr/lib/libecore_con.so.1.13.0
b63db000 b63e4000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63e5000 b63ee000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63ef000 b6402000 r-xp /usr/lib/libeo.so.1.13.0
b6404000 b6417000 r-xp /usr/lib/libecore_input.so.1.13.0
b6418000 b641f000 r-xp /usr/lib/libecore_file.so.1.13.0
b6420000 b6443000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6444000 b6470000 r-xp /usr/lib/libeet.so.1.13.0
b6479000 b64e4000 r-xp /usr/lib/libeina.so.1.13.0
b64e7000 b64fe000 r-xp /usr/lib/libefl.so.1.13.0
b6500000 b6667000 r-xp /usr/lib/libicuuc.so.51.1
b6675000 b6881000 r-xp /usr/lib/libicui18n.so.51.1
b6889000 b68d8000 r-xp /usr/lib/libecore_x.so.1.13.0
b68da000 b68f4000 r-xp /lib/libgcc_s-4.9.so.1
b68f6000 b68fa000 r-xp /lib/libcap.so.2.21
b68fb000 b6941000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6942000 b6949000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b694b000 b699d000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b699f000 b6b2a000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b2f000 b6bfd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c00000 b6c04000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c05000 b6c14000 r-xp /usr/lib/libvconf.so.0.2.45
b6c15000 b6c18000 r-xp /usr/lib/libvasum.so.0.3.1
b6c19000 b6c1c000 r-xp /usr/lib/libttrace.so.1.1
b6c1e000 b6c22000 r-xp /usr/lib/libiniparser.so.0
b6c23000 b6c53000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c54000 b6c5d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c5e000 b6c83000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c84000 b6c94000 r-xp /usr/lib/libunwind.so.8.0.1
b6c9e000 b6e4c000 r-xp /lib/libc-2.20-2014.11.so
b6e54000 b6f97000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f99000 b6ff1000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6ff2000 b7026000 r-xp /usr/lib/libsystemd.so.0.4.0
b7029000 b70fd000 r-xp /usr/lib/libedje.so.1.13.0
b7100000 b712c000 r-xp /usr/lib/libecore.so.1.13.0
b713d000 b7363000 r-xp /usr/lib/libevas.so.1.13.0
b738b000 b73a3000 r-xp /lib/libpthread-2.20-2014.11.so
b73a7000 b7721000 r-xp /usr/lib/libelementary.so.1.13.0
b7741000 b7745000 r-xp /usr/lib/libsmack.so.1.0.0
b7746000 b774f000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7750000 b7753000 r-xp /usr/lib/libdlog.so.0.0.0
b7754000 b7759000 r-xp /usr/lib/libbundle.so.0.1.22
b775a000 b775d000 r-xp /lib/libdl-2.20-2014.11.so
b775f000 b7784000 r-xp /usr/lib/libaul.so.0.1.0
b7787000 b7789000 r-xp /usr/lib/libappsvc.so.0.1.0
b778a000 b778f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7790000 b7797000 r-xp /usr/lib/libappcore-efl.so.1.1
b7799000 b779e000 r-xp /usr/lib/libsys-assert.so
b77a1000 b77a2000 r-xp [vdso]
b77a2000 b77c4000 r-xp /lib/ld-2.20-2014.11.so
b77c6000 b77ce000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:9875)
Call Stack Count: 23
 0: db_read_cb + 0x1b6 (0xb3807a36) [/opt/usr/apps/org.example.example/bin/example] + 0x9a36
 1: sqlite3_exec + 0x27b (0xb6bae04b) [/usr/lib/libsqlite3.so.0] + 0x7f04b
 2: read_db + 0xa9 (0xb3807869) [/opt/usr/apps/org.example.example/bin/example] + 0x9869
 3: init_db + 0x1c9 (0xb3807469) [/opt/usr/apps/org.example.example/bin/example] + 0x9469
 4: create_button_view + 0x539 (0xb3806eb9) [/opt/usr/apps/org.example.example/bin/example] + 0x8eb9
 5: setting_view_cb + 0x5d (0xb38068bd) [/opt/usr/apps/org.example.example/bin/example] + 0x88bd
 6: (0xb7171449) [/usr/lib/libevas.so.1] + 0x34449
 7: (0xb63fd319) [/usr/lib/libeo.so.1] + 0xe319
 8: eo_event_callback_call + 0xb3 (0xb63fad63) [/usr/lib/libeo.so.1] + 0xbd63
 9: (0xb7171a62) [/usr/lib/libevas.so.1] + 0x34a62
10: (0xb7180441) [/usr/lib/libevas.so.1] + 0x43441
11: evas_canvas_event_feed_mouse_down + 0xcf (0xb718a20f) [/usr/lib/libevas.so.1] + 0x4d20f
12: evas_event_feed_mouse_down + 0x6a (0xb7190c2a) [/usr/lib/libevas.so.1] + 0x53c2a
13: (0xb440a49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
14: (0xb710d055) [/usr/lib/libecore.so.1] + 0xd055
15: (0xb71161b9) [/usr/lib/libecore.so.1] + 0x161b9
16: ecore_main_loop_begin + 0x57 (0xb7116587) [/usr/lib/libecore.so.1] + 0x16587
17: elm_run + 0x2d (0xb756f22d) [/usr/lib/libelementary.so.1] + 0x1c822d
18: appcore_efl_main + 0x4de (0xb7793dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
19: ui_app_main + 0x140 (0xb778cc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
20: main + 0x2e1 (0xb3805991) [/opt/usr/apps/org.example.example/bin/example] + 0x7991
21: (0xb77c8148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77c8148
22: __libc_start_main + 0xde (0xb6cb5e4e) [/lib/libc.so.6] + 0x17e4e
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
cpp: MoveMenuBox(768) >  MoveBox Name[clockui2] pos[4, 1] pageId[100001]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[16]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[4], [4, 1]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[4], [4, 1]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.972+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.contacts] Name[Contacts] Icon[/usr/share/icons/default/small/org.tizen.contacts.png] enable[1] system[1]
06-01 21:07:23.972+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.contacts'], count[0]
06-01 21:07:23.972+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.contacts][-17956860][0]
06-01 21:07:23.972+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.contacts]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Contacts] pos[1, 2] pageId[100001]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[4]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[5], [1, 2]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[5], [1, 2]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.972+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.email] Name[Email] Icon[/usr/apps/org.tizen.email/shared/res/org.tizen.email.png] enable[1] system[1]
06-01 21:07:23.972+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.email'], count[1]
06-01 21:07:23.972+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.email]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Email] pos[2, 2] pageId[100001]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[5]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[6], [2, 2]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[6], [2, 2]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.972+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.emailui] Name[emailui] Icon[/opt/usr/apps/org.example.emailui/shared/res/emailui.png] enable[1] system[0]
06-01 21:07:23.972+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.emailui'], count[0]
06-01 21:07:23.972+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.emailui][-17956860][0]
06-01 21:07:23.972+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.emailui]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[emailui] pos[3, 2] pageId[100001]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[7], [3, 2]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.972+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.example] Name[forpet] Icon[/opt/usr/apps/org.example.example/shared/res/1.jpg] enable[1] system[0]
06-01 21:07:23.972+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.example'], count[0]
06-01 21:07:23.972+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 21:07:23.972+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 21:07:23.972+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 21:07:23.972+0900 D/test-log( 2894): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-01 21:07:23.972+0900 D/test-log( 2894): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 21:07:23.992+0900 D/test-log( 2894): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 21:07:23.992+0900 D/test-log( 2894): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 21:07:23.992+0900 D/BADGE   ( 2894): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 21:07:23.992+0900 E/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 21:07:23.992+0900 D/cluster-home( 2894): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 21:07:23.992+0900 D/cluster-view( 2894): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 21:07:24.182+0900 D/rpm-installer(10019): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 21:07:24.182+0900 D/rpm-installer(10019): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 21:07:24.182+0900 D/rpm-installer(10019): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 21:07:24.182+0900 D/rpm-installer(10019): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 21:07:24.192+0900 D/PKGMGR_SERVER(10005): pkgmgr-server.c: sighandler(387) > child exit [10019]
06-01 21:07:24.192+0900 E/PKGMGR_SERVER(10005): pkgmgr-server.c: sighandler(402) > child NORMAL exit [10019]
06-01 21:07:24.942+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 21:07:24.942+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 21:07:24.942+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 21:07:24.942+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 21:07:24.942+0900 I/AUL     ( 2787): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 21:07:24.942+0900 D/AUL     ( 2787): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 10072, pid = 10074
06-01 21:07:24.942+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 21:07:24.942+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 21:07:24.952+0900 I/AUL     ( 2787): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 21:07:24.952+0900 E/AUL_AMD ( 2787): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 21:07:24.952+0900 W/AUL_AMD ( 2787): amd_launch.c: _start_app(2233) > caller pid : 10074
06-01 21:07:24.952+0900 E/AUL_AMD ( 2787): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 21:07:24.952+0900 W/AUL_AMD ( 2787): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 21:07:24.952+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2648) > process_pool: false
06-01 21:07:24.952+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 21:07:24.952+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 21:07:24.952+0900 W/AUL_AMD ( 2787): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 21:07:24.952+0900 D/AUL_AMD ( 2787): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 21:07:24.952+0900 D/AUL_AMD ( 2787): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 21:07:24.952+0900 D/AUL     ( 2787): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 21:07:24.952+0900 W/AUL_PAD ( 2943): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 21:07:24.952+0900 D/AUL     ( 2943): process_pool.c: __send_pkt_raw_data(219) > send(12) : 624 / 624
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 9875, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 21:07:24.952+0900 W/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 21:07:24.952+0900 D/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 21:07:24.952+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 21:07:24.952+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-01 21:07:24.952+0900 D/RESOURCED( 2881): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 21:07:24.952+0900 D/RESOURCED( 2881): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 21:07:24.952+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 21:07:24.952+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 21:07:24.952+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 21:07:24.952+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 21:07:24.952+0900 E/RESOURCED( 2881): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 21:07:24.952+0900 D/AUL     ( 9875): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (9881) is sent.
06-01 21:07:24.952+0900 D/AUL     ( 9875): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 9881, signo: 10
06-01 21:07:24.962+0900 D/AUL     ( 9875): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYzMTg4NDQvOTQ5OTA3AA==##
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMDA3NAA=##
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 21:07:24.962+0900 D/AUL_PAD ( 9875): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 21:07:24.972+0900 I/CAPI_APPFW_APPLICATION( 9875): app_main.c: ui_app_main(788) > app_efl_main
06-01 21:07:24.972+0900 D/LAUNCH  ( 9875): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 21:07:24.972+0900 D/APP_CORE( 9875): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 21:07:24.972+0900 D/APP_CORE( 9875): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 21:07:24.972+0900 D/APP_CORE( 9875): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 21:07:24.992+0900 E/PKGMGR_SERVER(10005): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 21:07:24.992+0900 E/PKGMGR_SERVER(10005): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 21:07:25.002+0900 D/APP_CORE( 9875): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 21:07:25.002+0900 D/AUL     ( 9875): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 21:07:25.002+0900 D/APP_CORE( 9875): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42ec520
06-01 21:07:25.002+0900 D/LAUNCH  ( 9875): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 21:07:25.002+0900 I/CAPI_APPFW_APPLICATION( 9875): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 21:07:25.062+0900 D/AUL_PAD ( 2943): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 21:07:25.062+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 9875, appid: org.example.example
06-01 21:07:25.062+0900 D/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 21:07:25.062+0900 E/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 21:07:25.062+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2700) > add app group info
06-01 21:07:25.062+0900 E/AUL     ( 2787): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 21:07:25.062+0900 D/AUL_AMD ( 2787): amd_status.c: _status_add_app_info_list(427) > pid(9875) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 21:07:25.072+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 9875
06-01 21:07:25.072+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 21:07:25.072+0900 E/RESOURCED( 2881): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 21:07:25.072+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(888) > available memory = 316
06-01 21:07:25.132+0900 D/LAUNCH  ( 9875): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 21:07:25.142+0900 D/APP_CORE( 9875): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 21:07:25.142+0900 E/E17     ( 2736): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-01 21:07:25.192+0900 D/APP_CORE( 9875): appcore.c: __aul_handler(587) > [APP 9875]     AUL event: AUL_START
06-01 21:07:25.192+0900 I/APP_CORE( 9875): appcore-efl.c: __do_app(496) > [APP 9875] Event: RESET State: CREATED
06-01 21:07:25.192+0900 D/APP_CORE( 9875): appcore-efl.c: __do_app(527) > [APP 9875] RESET
06-01 21:07:25.192+0900 D/LAUNCH  ( 9875): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 21:07:25.192+0900 D/APP_CORE( 9875): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 21:07:25.192+0900 D/APP_CORE( 9875): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 21:07:25.192+0900 I/CAPI_APPFW_APPLICATION( 9875): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 21:07:25.192+0900 D/AUL     ( 9875): service.c: __set_bundle(186) > __set_bundle
06-01 21:07:25.192+0900 D/LAUNCH  ( 9875): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 21:07:25.192+0900 D/APP_CORE( 9875): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 21:07:25.192+0900 E/EFL     ( 9875): edje<9875> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:07:25.192+0900 E/EFL     ( 9875): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:07:25.192+0900 E/EFL     ( 9875): edje<9875> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:07:25.192+0900 E/EFL     ( 9875): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:07:25.192+0900 E/EFL     ( 9875): edje<9875> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:07:25.192+0900 E/EFL     ( 9875): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:07:25.192+0900 E/EFL     ( 9875): edje<9875> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:07:25.192+0900 E/EFL     ( 9875): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:07:25.192+0900 E/EFL     ( 9875): edje<9875> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 21:07:25.192+0900 E/EFL     ( 9875): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 21:07:25.212+0900 E/E17     ( 2736): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-01 21:07:25.232+0900 W/PROCESSMGR( 2736): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9875
06-01 21:07:25.242+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:07:25.242+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:07:25.282+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 21:07:25.282+0900 D/INDICATOR( 2886): main.c: _property_changed_cb(432) > UNSNIFF API 1800002
06-01 21:07:25.282+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 21:07:25.282+0900 D/INDICATOR( 2886): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 21:07:25.282+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 21:07:25.282+0900 D/INDICATOR( 2886): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 21:07:25.282+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 21:07:25.282+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 21:07:25.282+0900 D/INDICATOR( 2886): main.c: _rotate_window(252) > port :: hide more icon
06-01 21:07:25.282+0900 D/AUL_AMD ( 2787): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 9875 is org.example.example
06-01 21:07:25.282+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 9875 : 0
06-01 21:07:25.282+0900 D/AUL     ( 2961): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 21:07:25.342+0900 D/APP_CORE( 9875): appcore.c: __prt_ltime(236) > [APP 9875] first idle after reset: 405 msec
06-01 21:07:25.362+0900 W/APP_CORE( 9875): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-01 21:07:25.362+0900 D/APP_CORE( 9875): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-01 21:07:25.362+0900 D/APP_CORE( 9875): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 21:07:25.362+0900 D/AUL     ( 9875): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 21:07:25.362+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 21:07:25.662+0900 E/E17     ( 2736): e_border.c: e_border_hide(2248) > BD_HIDE(0x01800002), visible:1
06-01 21:07:25.662+0900 D/APP_CORE( 9875): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-01 21:07:25.662+0900 D/APP_CORE( 9875): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 21:07:25.662+0900 D/APP_CORE( 9875): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 21:07:25.662+0900 I/APP_CORE( 9875): appcore-efl.c: __do_app(496) > [APP 9875] Event: RESUME State: CREATED
06-01 21:07:25.662+0900 D/LAUNCH  ( 9875): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 21:07:25.662+0900 D/APP_CORE( 9875): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 21:07:25.662+0900 D/APP_CORE( 9875): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 21:07:25.662+0900 D/APP_CORE( 9875): appcore-efl.c: __do_app(607) > [APP 9875] RESUME
06-01 21:07:25.662+0900 D/APP_CORE( 2894): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1800002 fully_obscured 1
06-01 21:07:25.662+0900 D/APP_CORE( 2894): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 21:07:25.662+0900 D/APP_CORE( 2894): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 21:07:25.662+0900 I/APP_CORE( 2894): appcore-efl.c: __do_app(496) > [APP 2894] Event: PAUSE State: RUNNING
06-01 21:07:25.662+0900 D/APP_CORE( 2894): appcore-efl.c: __do_app(565) > [APP 2894] PAUSE
06-01 21:07:25.662+0900 I/CAPI_APPFW_APPLICATION( 2894): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 21:07:25.662+0900 E/cluster-home( 2894): homescreen.cpp: OnPause(84) >  app pause
06-01 21:07:25.662+0900 D/cluster-view( 2894): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 21:07:25.662+0900 D/cluster-view( 2894): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 21:07:25.662+0900 D/APP_CORE( 2894): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 21:07:25.662+0900 E/APP_CORE( 2894): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 21:07:25.672+0900 I/APP_CORE( 9875): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 21:07:25.672+0900 I/APP_CORE( 9875): appcore-efl.c: __do_app(614) > [APP 9875] Initial Launching, call the resume_cb
06-01 21:07:25.672+0900 I/CAPI_APPFW_APPLICATION( 9875): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 21:07:25.672+0900 D/LAUNCH  ( 9875): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 21:07:25.672+0900 D/LAUNCH  ( 9875): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 21:07:25.672+0900 D/APP_CORE( 9875): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 21:07:25.672+0900 E/APP_CORE( 9875): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 21:07:25.672+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(2894) status(4)
06-01 21:07:25.672+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(2894) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 21:07:25.672+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 21:07:25.672+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2894, appid: org.tizen.homescreen, status: bg
06-01 21:07:25.682+0900 D/DATA_PROVIDER_MASTER( 2950): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2894 is paused
06-01 21:07:25.682+0900 D/DATA_PROVIDER_MASTER( 2950): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 21:07:25.682+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2891) > pid(9875) status(3)
06-01 21:07:25.682+0900 D/AUL_AMD ( 2787): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 21:07:25.692+0900 I/CAPI_WIDGET_APPLICATION( 3024): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 21:07:25.692+0900 W/AUL_AMD ( 2787): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 21:07:25.692+0900 W/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 21:07:25.692+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(9875) status(3)
06-01 21:07:25.692+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(9875) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 21:07:25.692+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 21:07:25.692+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 9875, appid: org.example.example, status: fg
06-01 21:07:25.692+0900 I/CAPI_WIDGET_APPLICATION( 3024): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 21:07:25.692+0900 W/AUL     ( 3024): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3024, appid: org.tizen.calendar.widget, status: bg
06-01 21:07:25.692+0900 D/RESOURCED( 2881): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 9875
06-01 21:07:25.692+0900 D/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 9875, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 21:07:25.692+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 9875
06-01 21:07:25.772+0900 D/RESOURCED( 2881): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 9875, appname = org.example.example, pkgname = org.example.example
06-01 21:07:25.772+0900 D/RESOURCED( 2881): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 9875, appname = org.example.example
06-01 21:07:25.772+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 9875
06-01 21:07:25.772+0900 D/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3024, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 21:07:25.772+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3024
06-01 21:07:25.772+0900 D/RESOURCED( 2881): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3024, appname = org.tizen.calendar.widget
06-01 21:07:25.772+0900 D/RESOURCED( 2881): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3024
06-01 21:07:25.772+0900 I/RESOURCED( 2881): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 21:07:25.772+0900 I/RESOURCED( 2881): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 21:07:25.852+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2910) > pid(9875) status(0)
06-01 21:07:26.062+0900 D/AUL_PAD ( 2943): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 21:07:26.062+0900 D/AUL_PAD (10083): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 21:07:26.072+0900 D/AUL_PAD ( 2943): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 21:07:26.082+0900 E/RESOURCED( 2881): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.819
06-01 21:07:26.571+0900 D/AUL_AMD ( 2787): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 21:07:26.571+0900 D/RUA     ( 2787): rua.c: rua_add_history(179) > rua_add_history start
06-01 21:07:26.571+0900 D/RUA     ( 2787): rua.c: rua_add_history(247) > rua_add_history ok
06-01 21:07:26.951+0900 I/user    ( 9875): on
06-01 21:07:26.961+0900 I/user2   ( 9875): on
06-01 21:07:26.961+0900 I/user_tag0( 9875): /opt/usr/apps/org.example.example/data/test.db
06-01 21:07:26.981+0900 I/tag     ( 9875): insert~~~
06-01 21:07:26.991+0900 I/tag     ( 9875): insert~~~
06-01 21:07:27.001+0900 I/tag     ( 9875): eonji~
06-01 21:07:27.001+0900 I/tag     ( 9875): 들어와!
06-01 21:07:27.001+0900 I/tag     ( 9875): 언지
06-01 21:07:27.041+0900 D/PROCESSMGR( 2736): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40164e 
06-01 21:07:27.051+0900 D/AUL_PAD ( 2943): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 21:07:27.051+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 21:07:27.051+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 21:07:27.051+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 21:07:27.051+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 21:07:27.051+0900 D/AUL_PAD ( 2943): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 21:07:27.051+0900 D/AUL_PAD ( 2943): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 21:07:27.051+0900 I/AUL_PAD ( 2943): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 9875 pgid = 9875
06-01 21:07:27.051+0900 I/AUL_PAD ( 2943): sigchild.h: __sigchild_action(142) > dead_pid(9875)
06-01 21:07:27.071+0900 E/EFL     ( 2736): eo<2736> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 21:07:27.081+0900 W/CRASH_MANAGER(10084): worker.c: worker_job(1204) > 1109875657861149631884
