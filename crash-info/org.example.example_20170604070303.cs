S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 4659
Date: 2017-06-04 07:03:03+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb37998b1, esi = 0xb3799605
ebp = 0xbfa07b58, esp = 0xbfa07990
eax = 0x0000000c, ebx = 0xb379c000
ecx = 0x00000002, edx = 0x00000000
eip = 0xb3793ac2

Memory Information
MemTotal:      123 KB
MemFree:        26 KB
Buffers:         5 KB
Cached:     183824 KB
VmPeak:     121292 KB
VmSize:     118176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34088 KB
VmRSS:       31016 KB
VmData:      48264 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4659 TID = 4659
4659 4662 4865 4866 4873 

Maps Information
b0e9c000 b0ea3000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b0ea6000 b0ebe000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0ebf000 b0ec6000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b187d000 b1881000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b56000 b2b60000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b66000 b2b72000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b73000 b2b94000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b99000 b2b9a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b9b000 b2ba0000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2ba1000 b2ba2000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2ba3000 b2ba5000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2ba6000 b2ba8000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2ba9000 b2bb5000 r-xp /usr/lib/libdrm.so.2.4.0
b2bb6000 b2bb9000 r-xp /usr/lib/libdri2.so.0.0.0
b2bba000 b2bc4000 r-xp /usr/lib/libtbm.so.1.0.0
b2bc5000 b2bda000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bdb000 b2bed000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33ef000 b3420000 r-xp /usr/lib/libidn.so.11.5.44
b3421000 b3443000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3444000 b3454000 r-xp /usr/lib/libcares.so.2.1.0
b3455000 b345e000 r-xp /usr/lib/libeventsystem.so.0.0.1
b345f000 b3468000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3469000 b34e0000 r-xp /usr/lib/libcurl.so.4.3.0
b34e2000 b34f4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34f5000 b3516000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b351d000 b351e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b351f000 b3520000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3521000 b3524000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3525000 b3528000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3630000 b3636000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3637000 b377b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b378c000 b378d000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b378e000 b379b000 r-xp /opt/usr/apps/org.example.example/bin/example
b379d000 b37d6000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41d9000 b41e4000 r-xp /lib/libnss_files-2.20-2014.11.so
b41e6000 b41f1000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41f3000 b420a000 r-xp /lib/libnsl-2.20-2014.11.so
b420e000 b4216000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4218000 b423c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b423d000 b423e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b423f000 b4242000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4243000 b424a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b424b000 b4255000 r-xp /usr/lib/libsensord-share.so
b4256000 b4272000 r-xp /usr/lib/libsensor.so.1.2.0
b4274000 b427d000 r-xp /usr/lib/libappcore-common.so.1.1
b4280000 b4282000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4297000 b4299000 r-xp /usr/lib/libXau.so.6.0.0
b429a000 b42bc000 r-xp /usr/lib/libxcb.so.1.1.0
b42be000 b42c7000 r-xp /lib/libcrypt-2.20-2014.11.so
b42f0000 b42f2000 r-xp /usr/lib/libiri.so
b42f3000 b4319000 r-xp /lib/libexpat.so.1.5.2
b431b000 b4386000 r-xp /usr/lib/libssl.so.1.0.0
b438c000 b4398000 r-xp /usr/lib/libethumb.so.1.13.0
b4399000 b439d000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b439e000 b45ef000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b6a000 b5b7a000 r-xp /usr/lib/libXi.so.6.1.0
b5b7b000 b5b7d000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b7e000 b5b84000 r-xp /usr/lib/libXtst.so.6.1.0
b5b85000 b5b8f000 r-xp /usr/lib/libXrender.so.1.3.0
b5b90000 b5b99000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b9b000 b5b9d000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b9e000 b5ba3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5ba4000 b5bb6000 r-xp /usr/lib/libXext.so.6.4.0
b5bb7000 b5bb9000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bba000 b5bbc000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bbe000 b5d00000 r-xp /usr/lib/libX11.so.6.3.0
b5d04000 b5d0e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d0f000 b5d25000 r-xp /usr/lib/libudev.so.1.6.0
b5d28000 b5d2c000 r-xp /lib/libattr.so.1.1.0
b5d2d000 b5d5c000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d5e000 b5d64000 r-xp /usr/lib/libffi.so.6.0.2
b5d65000 b5d88000 r-xp /lib/libz.so.1.2.8
b5d89000 b5d8c000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d8d000 b5ee9000 r-xp /usr/lib/libxml2.so.2.9.2
b5eef000 b5fd6000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fe3000 b5fe6000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fe7000 b6009000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b600a000 b601e000 r-xp /lib/libresolv-2.20-2014.11.so
b6022000 b6046000 r-xp /usr/lib/liblzma.so.5.0.3
b6047000 b6049000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b604b000 b6055000 r-xp /usr/lib/libembryo.so.1.13.0
b6056000 b607f000 r-xp /usr/lib/libpng12.so.0.50.0
b6080000 b60c9000 r-xp /usr/lib/libjpeg.so.8.0.2
b60da000 b60e1000 r-xp /lib/librt-2.20-2014.11.so
b60e3000 b6102000 r-xp /usr/lib/libector.so.1.13.0
b6105000 b6132000 r-xp /usr/lib/liblua-5.1.so
b6133000 b61c3000 r-xp /usr/lib/libfreetype.so.6.11.3
b61c7000 b6205000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6206000 b621c000 r-xp /usr/lib/libfribidi.so.0.3.1
b621d000 b6276000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6279000 b62c4000 r-xp /lib/libm-2.20-2014.11.so
b62c6000 b62d8000 r-xp /usr/lib/libeio.so.1.13.0
b62d9000 b62dc000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62dd000 b62e3000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62e4000 b6307000 r-xp /usr/lib/libefreet.so.1.13.0
b630a000 b6335000 r-xp /usr/lib/libeldbus.so.1.13.0
b6336000 b636a000 r-xp /usr/lib/libecore_con.so.1.13.0
b636c000 b6375000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6376000 b637f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6380000 b6393000 r-xp /usr/lib/libeo.so.1.13.0
b6395000 b63a8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63a9000 b63b0000 r-xp /usr/lib/libecore_file.so.1.13.0
b63b1000 b63d4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63d5000 b6401000 r-xp /usr/lib/libeet.so.1.13.0
b640a000 b6475000 r-xp /usr/lib/libeina.so.1.13.0
b6478000 b648f000 r-xp /usr/lib/libefl.so.1.13.0
b6491000 b65f8000 r-xp /usr/lib/libicuuc.so.51.1
b6606000 b6812000 r-xp /usr/lib/libicui18n.so.51.1
b681a000 b6869000 r-xp /usr/lib/libecore_x.so.1.13.0
b686b000 b6885000 r-xp /lib/libgcc_s-4.9.so.1
b6887000 b688b000 r-xp /lib/libcap.so.2.21
b688c000 b68d2000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68d3000 b68da000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68dc000 b692e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6930000 b6abb000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ac0000 b6b8e000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b91000 b6b95000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b96000 b6ba5000 r-xp /usr/lib/libvconf.so.0.2.45
b6ba6000 b6ba9000 r-xp /usr/lib/libvasum.so.0.3.1
b6baa000 b6bad000 r-xp /usr/lib/libttrace.so.1.1
b6baf000 b6bb3000 r-xp /usr/lib/libiniparser.so.0
b6bb4000 b6be4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6be5000 b6bee000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bef000 b6c14000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c15000 b6c25000 r-xp /usr/lib/libunwind.so.8.0.1
b6c2f000 b6ddd000 r-xp /lib/libc-2.20-2014.11.so
b6de5000 b6f28000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f2a000 b6f82000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f83000 b6fb7000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fba000 b708e000 r-xp /usr/lib/libedje.so.1.13.0
b7091000 b70bd000 r-xp /usr/lib/libecore.so.1.13.0
b70ce000 b72f4000 r-xp /usr/lib/libevas.so.1.13.0
b731c000 b7334000 r-xp /lib/libpthread-2.20-2014.11.so
b7338000 b76b2000 r-xp /usr/lib/libelementary.so.1.13.0
b76d2000 b76d6000 r-xp /usr/lib/libsmack.so.1.0.0
b76d7000 b76e0000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76e1000 b76e4000 r-xp /usr/lib/libdlog.so.0.0.0
b76e5000 b76ea000 r-xp /usr/lib/libbundle.so.0.1.22
b76eb000 b76ee000 r-xp /lib/libdl-2.20-2014.11.so
b76f0000 b7715000 r-xp /usr/lib/libaul.so.0.1.0
b7718000 b771a000 r-xp /usr/lib/libappsvc.so.0.1.0
b771b000 b7720000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7721000 b7728000 r-xp /usr/lib/libappcore-efl.so.1.1
b772a000 b772f000 r-xp /usr/lib/libsys-assert.so
b7732000 b7733000 r-xp [vdso]
b7733000 b7755000 r-xp /lib/ld-2.20-2014.11.so
b7757000 b775f000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:4659)
Call Stack Count: 23
 0: db_read_cb + 0xc2 (0xb3793ac2) [/opt/usr/apps/org.example.example/bin/example] + 0x5ac2
 1: sqlite3_exec + 0x27b (0xb6b3f04b) [/usr/lib/libsqlite3.so.0] + 0x7f04b
 2: read_db + 0xa9 (0xb37939e9) [/opt/usr/apps/org.example.example/bin/example] + 0x59e9
 3: init_db + 0x16f (0xb37934cf) [/opt/usr/apps/org.example.example/bin/example] + 0x54cf
 4: create_button_view + 0x411 (0xb37931d1) [/opt/usr/apps/org.example.example/bin/example] + 0x51d1
 5: feeding_view_cb + 0x54 (0xb3792d04) [/opt/usr/apps/org.example.example/bin/example] + 0x4d04
 6: (0xb7102449) [/usr/lib/libevas.so.1] + 0x34449
 7: (0xb638e319) [/usr/lib/libeo.so.1] + 0xe319
 8: eo_event_callback_call + 0xb3 (0xb638bd63) [/usr/lib/libeo.so.1] + 0xbd63
 9: (0xb7102a62) [/usr/lib/libevas.so.1] + 0x34a62
10: (0xb7111441) [/usr/lib/libevas.so.1] + 0x43441
11: evas_canvas_event_feed_mouse_down + 0xcf (0xb711b20f) [/usr/lib/libevas.so.1] + 0x4d20f
12: evas_event_feed_mouse_down + 0x6a (0xb7121c2a) [/usr/lib/libevas.so.1] + 0x53c2a
13: (0xb439b49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
14: (0xb709e055) [/usr/lib/libecore.so.1] + 0xd055
15: (0xb70a71b9) [/usr/lib/libecore.so.1] + 0x161b9
16: ecore_main_loop_begin + 0x57 (0xb70a7587) [/usr/lib/libecore.so.1] + 0x16587
17: elm_run + 0x2d (0xb750022d) [/usr/lib/libelementary.so.1] + 0x1c822d
18: appcore_efl_main + 0x4de (0xb7724dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
19: ui_app_main + 0x140 (0xb771dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
20: main + 0x296 (0xb37966b6) [/opt/usr/apps/org.example.example/bin/example] + 0x86b6
21: (0xb7759148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7759148
22: __libc_start_main + 0xde (0xb6c46e4e) [/lib/libc.so.6] + 0x17e4e
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
uster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 07:02:53.254+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-04 07:02:53.254+0900 D/BADGE   ( 2867): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-04 07:02:53.254+0900 E/cluster-home( 2867): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-04 07:02:53.254+0900 D/cluster-home( 2867): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[4, 3] pageId[100001]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 07:02:53.254+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-04 07:02:53.254+0900 D/BADGE   ( 2867): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-04 07:02:53.254+0900 E/cluster-home( 2867): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-04 07:02:53.254+0900 D/cluster-home( 2867): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[1, 4] pageId[100001]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 07:02:53.254+0900 E/cluster-home( 2867): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-04 07:02:53.254+0900 D/BADGE   ( 2867): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-04 07:02:53.254+0900 E/cluster-home( 2867): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-04 07:02:53.254+0900 D/cluster-home( 2867): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[2, 4] pageId[100001]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-04 07:02:53.254+0900 D/cluster-view( 2867): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-04 07:02:53.344+0900 D/rpm-installer( 4806): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-04 07:02:53.344+0900 D/rpm-installer( 4806): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-04 07:02:53.344+0900 D/rpm-installer( 4806): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-04 07:02:53.344+0900 D/rpm-installer( 4806): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-04 07:02:53.354+0900 D/PKGMGR_SERVER( 4791): pkgmgr-server.c: sighandler(387) > child exit [4806]
06-04 07:02:53.354+0900 E/PKGMGR_SERVER( 4791): pkgmgr-server.c: sighandler(402) > child NORMAL exit [4806]
06-04 07:02:53.964+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 0
06-04 07:02:53.974+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-04 07:02:53.974+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 07:02:53.974+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 07:02:53.974+0900 I/AUL     ( 2753): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-04 07:02:53.974+0900 D/AUL     ( 2753): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 4859, pid = 4861
06-04 07:02:53.974+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 07:02:53.974+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 07:02:53.974+0900 I/AUL     ( 2753): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-04 07:02:53.974+0900 E/AUL_AMD ( 2753): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-04 07:02:53.974+0900 W/AUL_AMD ( 2753): amd_launch.c: _start_app(2233) > caller pid : 4861
06-04 07:02:53.974+0900 E/AUL_AMD ( 2753): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-04 07:02:53.974+0900 W/AUL_AMD ( 2753): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-04 07:02:53.974+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2648) > process_pool: false
06-04 07:02:53.974+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-04 07:02:53.974+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-04 07:02:53.974+0900 W/AUL_AMD ( 2753): amd_launch.c: _start_app(2665) > pad pid(-5)
06-04 07:02:53.974+0900 D/AUL_AMD ( 2753): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-04 07:02:53.974+0900 D/AUL_AMD ( 2753): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-04 07:02:53.974+0900 D/AUL     ( 2753): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-04 07:02:53.974+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-04 07:02:53.974+0900 D/RESOURCED( 2854): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-04 07:02:53.974+0900 E/RESOURCED( 2854): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-04 07:02:53.974+0900 W/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-04 07:02:53.974+0900 D/AUL     ( 2921): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 4659, bin path: /opt/usr/apps/org.example.example/bin/example
06-04 07:02:53.974+0900 W/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(265) > Check app launching
06-04 07:02:53.974+0900 D/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-04 07:02:53.974+0900 D/AUL     ( 4659): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (4662) is sent.
06-04 07:02:53.974+0900 D/AUL     ( 4659): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 4662, signo: 10
06-04 07:02:53.974+0900 D/AUL     ( 4659): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY1MjczNzMvOTc5NzU4AA==##
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA0ODYxAA==##
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-04 07:02:53.974+0900 D/AUL_PAD ( 4659): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-04 07:02:53.984+0900 I/CAPI_APPFW_APPLICATION( 4659): app_main.c: ui_app_main(788) > app_efl_main
06-04 07:02:53.984+0900 D/LAUNCH  ( 4659): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-04 07:02:53.984+0900 D/APP_CORE( 4659): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-04 07:02:53.984+0900 D/APP_CORE( 4659): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-04 07:02:53.984+0900 D/APP_CORE( 4659): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-04 07:02:53.994+0900 D/APP_CORE( 4659): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-04 07:02:53.994+0900 D/AUL     ( 4659): app_sock.c: __create_server_sock(156) > pg path - already exists
06-04 07:02:53.994+0900 D/APP_CORE( 4659): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb427d520
06-04 07:02:53.994+0900 D/LAUNCH  ( 4659): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-04 07:02:53.994+0900 I/CAPI_APPFW_APPLICATION( 4659): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-04 07:02:54.024+0900 D/LAUNCH  ( 4659): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-04 07:02:54.024+0900 E/E17     ( 2783): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02400002)
06-04 07:02:54.024+0900 D/APP_CORE( 4659): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-04 07:02:54.034+0900 E/E17     ( 2783): e_border.c: e_border_show(2088) > BD_SHOW(0x02400002)
06-04 07:02:54.034+0900 D/APP_CORE( 4659): appcore.c: __aul_handler(587) > [APP 4659]     AUL event: AUL_START
06-04 07:02:54.034+0900 I/APP_CORE( 4659): appcore-efl.c: __do_app(496) > [APP 4659] Event: RESET State: CREATED
06-04 07:02:54.034+0900 D/APP_CORE( 4659): appcore-efl.c: __do_app(527) > [APP 4659] RESET
06-04 07:02:54.034+0900 D/LAUNCH  ( 4659): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-04 07:02:54.034+0900 D/APP_CORE( 4659): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-04 07:02:54.034+0900 D/APP_CORE( 4659): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 07:02:54.034+0900 I/CAPI_APPFW_APPLICATION( 4659): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 07:02:54.034+0900 D/AUL     ( 4659): service.c: __set_bundle(186) > __set_bundle
06-04 07:02:54.034+0900 D/LAUNCH  ( 4659): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 07:02:54.034+0900 D/APP_CORE( 4659): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 07:02:54.034+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:02:54.034+0900 E/EFL     ( 4659): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:02:54.034+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:02:54.034+0900 E/EFL     ( 4659): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:02:54.034+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:02:54.034+0900 E/EFL     ( 4659): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:02:54.034+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:02:54.034+0900 E/EFL     ( 4659): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:02:54.034+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 07:02:54.034+0900 E/EFL     ( 4659): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 07:02:54.034+0900 W/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4659
06-04 07:02:54.034+0900 W/APP_CORE( 4659): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2400002
06-04 07:02:54.034+0900 D/APP_CORE( 4659): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2400002
06-04 07:02:54.034+0900 D/APP_CORE( 4659): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 07:02:54.034+0900 D/AUL     ( 4659): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 07:02:54.034+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 07:02:54.034+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 07:02:54.044+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 07:02:54.044+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 07:02:54.044+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 07:02:54.044+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 07:02:54.044+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 07:02:54.044+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-04 07:02:54.074+0900 D/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 07:02:54.074+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 4659, appid: org.example.example
06-04 07:02:54.074+0900 D/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 07:02:54.074+0900 E/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 07:02:54.074+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2700) > add app group info
06-04 07:02:54.074+0900 E/AUL     ( 2753): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 07:02:54.074+0900 D/AUL_AMD ( 2753): amd_status.c: _status_add_app_info_list(427) > pid(4659) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 07:02:54.074+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 07:02:54.074+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 07:02:54.074+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 4659
06-04 07:02:54.074+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 07:02:54.074+0900 E/RESOURCED( 2854): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 07:02:54.074+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 07:02:54.074+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 07:02:54.074+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(888) > available memory = 316
06-04 07:02:54.084+0900 D/AUL_AMD ( 2753): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 4659 is org.example.example
06-04 07:02:54.084+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 4659 : 0
06-04 07:02:54.084+0900 D/AUL     ( 2937): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 07:02:54.314+0900 D/APP_CORE( 4659): appcore.c: __prt_ltime(236) > [APP 4659] first idle after reset: 350 msec
06-04 07:02:54.384+0900 E/E17     ( 2783): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 07:02:54.384+0900 D/APP_CORE( 4659): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2400002 fully_obscured 0
06-04 07:02:54.384+0900 D/APP_CORE( 2867): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 07:02:54.384+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 07:02:54.384+0900 D/APP_CORE( 4659): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 07:02:54.384+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 07:02:54.384+0900 D/APP_CORE( 4659): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 07:02:54.384+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: PAUSE State: RUNNING
06-04 07:02:54.384+0900 D/APP_CORE( 2867): appcore-efl.c: __do_app(565) > [APP 2867] PAUSE
06-04 07:02:54.384+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 07:02:54.384+0900 I/APP_CORE( 4659): appcore-efl.c: __do_app(496) > [APP 4659] Event: RESUME State: CREATED
06-04 07:02:54.384+0900 D/LAUNCH  ( 4659): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 07:02:54.384+0900 D/APP_CORE( 4659): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 07:02:54.384+0900 D/APP_CORE( 4659): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 07:02:54.384+0900 D/APP_CORE( 4659): appcore-efl.c: __do_app(607) > [APP 4659] RESUME
06-04 07:02:54.384+0900 E/cluster-home( 2867): homescreen.cpp: OnPause(84) >  app pause
06-04 07:02:54.384+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 07:02:54.384+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 07:02:54.384+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 07:02:54.384+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 07:02:54.384+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(4)
06-04 07:02:54.384+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 07:02:54.384+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 07:02:54.384+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: bg
06-04 07:02:54.394+0900 I/APP_CORE( 4659): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 07:02:54.394+0900 I/APP_CORE( 4659): appcore-efl.c: __do_app(614) > [APP 4659] Initial Launching, call the resume_cb
06-04 07:02:54.394+0900 I/CAPI_APPFW_APPLICATION( 4659): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 07:02:54.394+0900 D/LAUNCH  ( 4659): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 07:02:54.394+0900 D/LAUNCH  ( 4659): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 07:02:54.394+0900 D/APP_CORE( 4659): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 07:02:54.394+0900 E/APP_CORE( 4659): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 07:02:54.394+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2891) > pid(4659) status(3)
06-04 07:02:54.394+0900 D/AUL_AMD ( 2753): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 07:02:54.394+0900 W/AUL_AMD ( 2753): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 07:02:54.394+0900 W/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 07:02:54.394+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(4659) status(3)
06-04 07:02:54.394+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(4659) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 07:02:54.394+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 07:02:54.394+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 4659, appid: org.example.example, status: fg
06-04 07:02:54.394+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 4659
06-04 07:02:54.394+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 4659, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 07:02:54.394+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 4659
06-04 07:02:54.404+0900 D/DATA_PROVIDER_MASTER( 2924): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2867 is paused
06-04 07:02:54.404+0900 D/DATA_PROVIDER_MASTER( 2924): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 07:02:54.404+0900 I/CAPI_WIDGET_APPLICATION( 3018): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 07:02:54.404+0900 I/CAPI_WIDGET_APPLICATION( 3018): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 07:02:54.404+0900 W/AUL     ( 3018): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3018, appid: org.tizen.calendar.widget, status: bg
06-04 07:02:54.454+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 4659, appname = org.example.example, pkgname = org.example.example
06-04 07:02:54.454+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 4659, appname = org.example.example
06-04 07:02:54.454+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4659
06-04 07:02:54.454+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3018, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 07:02:54.454+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3018
06-04 07:02:54.454+0900 D/RESOURCED( 2854): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3018, appname = org.tizen.calendar.widget
06-04 07:02:54.454+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3018
06-04 07:02:54.454+0900 I/RESOURCED( 2854): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 07:02:54.454+0900 I/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 07:02:54.494+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2910) > pid(4659) status(0)
06-04 07:02:55.004+0900 E/PKGMGR_SERVER( 4791): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 07:02:55.004+0900 E/PKGMGR_SERVER( 4791): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 07:02:55.074+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 07:02:55.074+0900 D/AUL_PAD ( 4871): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 07:02:55.084+0900 D/AUL_PAD ( 2921): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 07:02:55.094+0900 E/RESOURCED( 2854): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.311
06-04 07:02:55.584+0900 D/AUL_AMD ( 2753): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 07:02:55.584+0900 D/RUA     ( 2753): rua.c: rua_add_history(179) > rua_add_history start
06-04 07:02:55.584+0900 D/RUA     ( 2753): rua.c: rua_add_history(247) > rua_add_history ok
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b80f5760
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preload.h: __preload_init(69) > get pre-initialization function
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preload.h: __preload_init(73) > get shutdown function
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b80f5a40
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b80f7640
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preload.h: __preload_init(69) > get pre-initialization function
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preload.h: __preload_init(73) > get shutdown function
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): preexec.h: __preexec_init(76) > preexec start
06-04 07:02:56.134+0900 D/AUL_PAD ( 4871): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 07:02:56.134+0900 D/AUL     ( 4871): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 07:02:56.134+0900 D/AUL     ( 4871): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 07:02:56.134+0900 D/AUL     ( 4871): process_pool.c: __connect_to_launchpad(132) > send(4871) : 4
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 07:02:56.134+0900 D/AUL_PAD ( 2921): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 4871
06-04 07:02:56.144+0900 D/AUL     ( 4871): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 07:02:56.194+0900 D/AUL_PAD ( 4871): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 07:02:56.204+0900 D/AUL_PAD ( 4871): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 07:02:56.204+0900 D/AUL_PAD ( 4871): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 07:02:56.204+0900 D/AUL_PAD ( 4871): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 07:02:58.204+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 07:02:58.204+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 07:02:58.204+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 07:02:58.204+0900 E/INDICATOR( 2856): 
06-04 07:02:58.574+0900 I/user_tag0( 4659): /opt/usr/apps/org.example.example/data/feeding.db
06-04 07:02:58.574+0900 I/tag     ( 4659): eonji~
06-04 07:02:58.604+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4007d8 
06-04 07:02:59.354+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4007d8 
06-04 07:02:59.394+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 07:02:59.394+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: MEM_FLUSH State: PAUSED
06-04 07:02:59.394+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 07:02:59.394+0900 D/APP_CORE( 2867): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2867
06-04 07:02:59.394+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 07:02:59.394+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2867
06-04 07:02:59.474+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.474+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.514+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.514+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.524+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.524+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.524+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.524+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.524+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:02:59.534+0900 D/IMMODULE( 4659): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 07:02:59.534+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 07:02:59.534+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:02:59.534+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 07:02:59.534+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:02:59.544+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 07:02:59.544+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:02:59.544+0900 D/ISF_QUERY( 4659): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 07:02:59.544+0900 D/ISF_QUERY( 4659): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:02:59.544+0900 D/ISF_QUERY( 4659): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:02:59.544+0900 D/ISF_QUERY( 4659): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:02:59.544+0900 D/ISF_QUERY( 4659): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:02:59.544+0900 D/ISF_QUERY( 4659): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:02:59.544+0900 D/ISF_QUERY( 4659): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 07:02:59.554+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 07:02:59.554+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:02:59.554+0900 D/IMMODULE( 4659): scim_panel_client.cpp: open_connection(162) > 
06-04 07:02:59.554+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 07:02:59.554+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:02:59.554+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 07:02:59.554+0900 D/ISF_SOCKET( 4659): scim_socket.cpp: connect(524) > connect() succeeded
06-04 07:02:59.554+0900 D/IMMODULE( 4659): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 07:03:00.244+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 07:03:00.244+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 07:03:00.244+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 07:03:00.244+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 7:03 4 h"
06-04 07:03:00.244+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 7:03"
06-04 07:03:00.244+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 7&#x2236;03"
06-04 07:03:00.244+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147123519 Time: <font_size=33>7&#x2236;03</font_size> <font_size=32>AM</font_size></font>
06-04 07:03:00.344+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4007d8 
06-04 07:03:00.464+0900 I/tag     ( 4659): insert
06-04 07:03:00.464+0900 I/user_tag( 4659): 07:02 AM
06-04 07:03:00.474+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:03:00.474+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:03:00.484+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:03:00.484+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:03:00.494+0900 E/EFL     ( 4659): edje<4659> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 07:03:01.034+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4007d8 
06-04 07:03:01.754+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4007d8 
06-04 07:03:02.754+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 07:03:03.054+0900 I/user_tag0( 4659): /opt/usr/apps/org.example.example/data/feeding.db
06-04 07:03:03.054+0900 I/tag     ( 4659): eonji~
06-04 07:03:03.054+0900 I/tag     ( 4659): 들어와!
06-04 07:03:03.054+0900 I/tag     ( 4659): 언지
06-04 07:03:03.074+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x4007d8 
06-04 07:03:03.084+0900 W/CRASH_MANAGER( 4874): worker.c: worker_job(1204) > 1104659657861149652738
