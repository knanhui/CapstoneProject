S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10482
Date: 2017-06-01 02:48:38+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7b04d70, esi = 0x00000000
ebp = 0xbfb5d778, esp = 0xbfb5d710
eax = 0xb7b29000, ebx = 0xb72b05f0
ecx = 0xb79a20f8, edx = 0x00000020
eip = 0xb71152cb

Memory Information
MemTotal:      123 KB
MemFree:        23 KB
Buffers:         6 KB
Cached:     173696 KB
VmPeak:     100304 KB
VmSize:     100304 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22040 KB
VmRSS:       22040 KB
VmData:      32752 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34460 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 10482 TID = 10482
10482 10487 10688 10689 

Maps Information
b2b13000 b2b1d000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b23000 b2b2f000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b30000 b2b51000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b56000 b2b57000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b58000 b2b5d000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b5e000 b2b5f000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b60000 b2b62000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b63000 b2b6f000 r-xp /usr/lib/libdrm.so.2.4.0
b2b70000 b2b73000 r-xp /usr/lib/libdri2.so.0.0.0
b2b74000 b2b7e000 r-xp /usr/lib/libtbm.so.1.0.0
b2b7f000 b2b94000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b95000 b2ba7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33a9000 b33da000 r-xp /usr/lib/libidn.so.11.5.44
b33db000 b33fd000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33fe000 b340e000 r-xp /usr/lib/libcares.so.2.1.0
b340f000 b3418000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3419000 b3422000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3423000 b349a000 r-xp /usr/lib/libcurl.so.4.3.0
b349c000 b34ae000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34af000 b34d0000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34d7000 b34d8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34d9000 b34da000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34db000 b34de000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34df000 b34e2000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35ea000 b35f0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f1000 b3735000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3745000 b3747000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3748000 b3749000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b374a000 b3755000 r-xp /opt/usr/apps/org.example.example/bin/example
b3757000 b3790000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4193000 b419e000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a0000 b41ab000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41ad000 b41c4000 r-xp /lib/libnsl-2.20-2014.11.so
b41c8000 b41d0000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41d2000 b41f6000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41f7000 b41f8000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41f9000 b41fc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41fd000 b4204000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4205000 b420f000 r-xp /usr/lib/libsensord-share.so
b4210000 b422c000 r-xp /usr/lib/libsensor.so.1.2.0
b422e000 b4237000 r-xp /usr/lib/libappcore-common.so.1.1
b423a000 b423c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4251000 b4253000 r-xp /usr/lib/libXau.so.6.0.0
b4254000 b4276000 r-xp /usr/lib/libxcb.so.1.1.0
b4278000 b4281000 r-xp /lib/libcrypt-2.20-2014.11.so
b42aa000 b42ac000 r-xp /usr/lib/libiri.so
b42ad000 b42d3000 r-xp /lib/libexpat.so.1.5.2
b42d5000 b4340000 r-xp /usr/lib/libssl.so.1.0.0
b4346000 b4352000 r-xp /usr/lib/libethumb.so.1.13.0
b4353000 b4357000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4358000 b45a9000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b24000 b5b34000 r-xp /usr/lib/libXi.so.6.1.0
b5b35000 b5b37000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b38000 b5b3e000 r-xp /usr/lib/libXtst.so.6.1.0
b5b3f000 b5b49000 r-xp /usr/lib/libXrender.so.1.3.0
b5b4a000 b5b53000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b55000 b5b57000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b58000 b5b5d000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b5e000 b5b70000 r-xp /usr/lib/libXext.so.6.4.0
b5b71000 b5b73000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b74000 b5b76000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b78000 b5cba000 r-xp /usr/lib/libX11.so.6.3.0
b5cbe000 b5cc8000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cc9000 b5cdf000 r-xp /usr/lib/libudev.so.1.6.0
b5ce2000 b5ce6000 r-xp /lib/libattr.so.1.1.0
b5ce7000 b5d16000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d18000 b5d1e000 r-xp /usr/lib/libffi.so.6.0.2
b5d1f000 b5d42000 r-xp /lib/libz.so.1.2.8
b5d43000 b5d46000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d47000 b5ea3000 r-xp /usr/lib/libxml2.so.2.9.2
b5ea9000 b5f90000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f9d000 b5fa0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fa1000 b5fc3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc4000 b5fd8000 r-xp /lib/libresolv-2.20-2014.11.so
b5fdc000 b6000000 r-xp /usr/lib/liblzma.so.5.0.3
b6001000 b6003000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6005000 b600f000 r-xp /usr/lib/libembryo.so.1.13.0
b6010000 b6039000 r-xp /usr/lib/libpng12.so.0.50.0
b603a000 b6083000 r-xp /usr/lib/libjpeg.so.8.0.2
b6094000 b609b000 r-xp /lib/librt-2.20-2014.11.so
b609d000 b60bc000 r-xp /usr/lib/libector.so.1.13.0
b60bf000 b60ec000 r-xp /usr/lib/liblua-5.1.so
b60ed000 b617d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6181000 b61bf000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c0000 b61d6000 r-xp /usr/lib/libfribidi.so.0.3.1
b61d7000 b6230000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6233000 b627e000 r-xp /lib/libm-2.20-2014.11.so
b6280000 b6292000 r-xp /usr/lib/libeio.so.1.13.0
b6293000 b6296000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6297000 b629d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b629e000 b62c1000 r-xp /usr/lib/libefreet.so.1.13.0
b62c4000 b62ef000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f0000 b6324000 r-xp /usr/lib/libecore_con.so.1.13.0
b6326000 b632f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6330000 b6339000 r-xp /usr/lib/libethumb_client.so.1.13.0
b633a000 b634d000 r-xp /usr/lib/libeo.so.1.13.0
b634f000 b6362000 r-xp /usr/lib/libecore_input.so.1.13.0
b6363000 b636a000 r-xp /usr/lib/libecore_file.so.1.13.0
b636b000 b638e000 r-xp /usr/lib/libecore_evas.so.1.13.0
b638f000 b63bb000 r-xp /usr/lib/libeet.so.1.13.0
b63c4000 b642f000 r-xp /usr/lib/libeina.so.1.13.0
b6432000 b6449000 r-xp /usr/lib/libefl.so.1.13.0
b644b000 b65b2000 r-xp /usr/lib/libicuuc.so.51.1
b65c0000 b67cc000 r-xp /usr/lib/libicui18n.so.51.1
b67d4000 b6823000 r-xp /usr/lib/libecore_x.so.1.13.0
b6825000 b683f000 r-xp /lib/libgcc_s-4.9.so.1
b6841000 b6845000 r-xp /lib/libcap.so.2.21
b6846000 b688c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b688d000 b6894000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6896000 b68e8000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68ea000 b6a75000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a7a000 b6b48000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b4b000 b6b4f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b50000 b6b5f000 r-xp /usr/lib/libvconf.so.0.2.45
b6b60000 b6b63000 r-xp /usr/lib/libvasum.so.0.3.1
b6b64000 b6b67000 r-xp /usr/lib/libttrace.so.1.1
b6b69000 b6b6d000 r-xp /usr/lib/libiniparser.so.0
b6b6e000 b6b9e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b9f000 b6ba8000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6ba9000 b6bce000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bcf000 b6bdf000 r-xp /usr/lib/libunwind.so.8.0.1
b6be9000 b6d97000 r-xp /lib/libc-2.20-2014.11.so
b6d9f000 b6ee2000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee4000 b6f3c000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f3d000 b6f71000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f74000 b7048000 r-xp /usr/lib/libedje.so.1.13.0
b704b000 b7077000 r-xp /usr/lib/libecore.so.1.13.0
b7088000 b72ae000 r-xp /usr/lib/libevas.so.1.13.0
b72d6000 b72ee000 r-xp /lib/libpthread-2.20-2014.11.so
b72f2000 b766c000 r-xp /usr/lib/libelementary.so.1.13.0
b768c000 b7690000 r-xp /usr/lib/libsmack.so.1.0.0
b7691000 b769a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b769b000 b769e000 r-xp /usr/lib/libdlog.so.0.0.0
b769f000 b76a4000 r-xp /usr/lib/libbundle.so.0.1.22
b76a5000 b76a8000 r-xp /lib/libdl-2.20-2014.11.so
b76aa000 b76cf000 r-xp /usr/lib/libaul.so.0.1.0
b76d2000 b76d4000 r-xp /usr/lib/libappsvc.so.0.1.0
b76d5000 b76da000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76db000 b76e2000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e4000 b76e9000 r-xp /usr/lib/libsys-assert.so
b76ec000 b76ed000 r-xp [vdso]
b76ed000 b770f000 r-xp /lib/ld-2.20-2014.11.so
b7711000 b7719000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:10482)
Call Stack Count: 30
 0: (0xb71152cb) [/usr/lib/libevas.so.1] + 0x8d2cb
 1: evas_obj_smart_member_add + 0xa7 (0xb7112927) [/usr/lib/libevas.so.1] + 0x8a927
 2: (0xb71170e2) [/usr/lib/libevas.so.1] + 0x8f0e2
 3: evas_obj_smart_member_add + 0xa7 (0xb7112927) [/usr/lib/libevas.so.1] + 0x8a927
 4: evas_object_smart_member_add + 0x5d (0xb71137ed) [/usr/lib/libevas.so.1] + 0x8b7ed
 5: (0xb71593c1) [/usr/lib/libevas.so.1] + 0xd13c1
 6: evas_obj_grid_pack + 0xdd (0xb71590dd) [/usr/lib/libevas.so.1] + 0xd10dd
 7: evas_object_grid_pack + 0x71 (0xb715a7e1) [/usr/lib/libevas.so.1] + 0xd27e1
 8: (0xb745fff1) [/usr/lib/libelementary.so.1] + 0x16dff1
 9: elm_obj_grid_pack + 0xdd (0xb745fd5d) [/usr/lib/libelementary.so.1] + 0x16dd5d
10: elm_grid_pack + 0x71 (0xb7461261) [/usr/lib/libelementary.so.1] + 0x16f261
11: create_button_view + 0x31f (0xb375290f) [/opt/usr/apps/org.example.example/bin/example] + 0x890f
12: setting_view_cb + 0x57 (0xb3752537) [/opt/usr/apps/org.example.example/bin/example] + 0x8537
13: (0xb70bc449) [/usr/lib/libevas.so.1] + 0x34449
14: (0xb6348319) [/usr/lib/libeo.so.1] + 0xe319
15: eo_event_callback_call + 0xb3 (0xb6345d63) [/usr/lib/libeo.so.1] + 0xbd63
16: (0xb70bca62) [/usr/lib/libevas.so.1] + 0x34a62
17: (0xb70cb441) [/usr/lib/libevas.so.1] + 0x43441
18: evas_canvas_event_feed_mouse_down + 0xcf (0xb70d520f) [/usr/lib/libevas.so.1] + 0x4d20f
19: evas_event_feed_mouse_down + 0x6a (0xb70dbc2a) [/usr/lib/libevas.so.1] + 0x53c2a
20: (0xb435549c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
21: (0xb7058055) [/usr/lib/libecore.so.1] + 0xd055
22: (0xb70611b9) [/usr/lib/libecore.so.1] + 0x161b9
23: ecore_main_loop_begin + 0x57 (0xb7061587) [/usr/lib/libecore.so.1] + 0x16587
24: elm_run + 0x2d (0xb74ba22d) [/usr/lib/libelementary.so.1] + 0x1c822d
25: appcore_efl_main + 0x4de (0xb76dedde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
26: ui_app_main + 0x140 (0xb76d7c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
27: main + 0x2a5 (0xb3751625) [/opt/usr/apps/org.example.example/bin/example] + 0x7625
28: (0xb7713148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7713148
29: __libc_start_main + 0xde (0xb6c00e4e) [/lib/libc.so.6] + 0x17e4e
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
]
06-01 02:48:36.131+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.example][-17956860][0]
06-01 02:48:36.131+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.example]
06-01 02:48:36.131+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[forpet] pos[4, 2] pageId[100001]
06-01 02:48:36.131+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[0]
06-01 02:48:36.131+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(787) >  AddBoxToMenuView
06-01 02:48:36.131+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(347) >  AddBox Name[forpet] pageid[100001] pos[4, 2]
06-01 02:48:36.131+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: AddBoxToMenuView(354) >  menuPage.GetPageId() = 100001, boxPageId = 100001
06-01 02:48:36.131+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(112) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 112
06-01 02:48:36.131+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: AddBoxToPage(122) >  void ClusterHome3D::Internal::CMainMenuPage::AddBoxToPage(std::shared_ptr<CMainMenuBoxData>) : 122
06-01 02:48:36.131+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(123) >  create box[org.example.example] [4,2]
06-01 02:48:36.131+0900 D/test-log( 2904): mainmenu-box-impl.cpp: CMainMenuBox(148) >  create box
06-01 02:48:36.131+0900 D/test-log( 2904): mainmenu-box-impl.cpp: SetPosition(459) >  cut Animation : forpet
06-01 02:48:36.141+0900 D/test-log( 2904): mainmenu-page-impl.cpp: AddBoxToPage(177) >  add created box
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.gallery] Name[Gallery] Icon[/usr/share/icons/default/small/org.tizen.gallery.png] enable[1] system[1]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.gallery'], count[0]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.gallery][-17956860][0]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.gallery]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[1, 3] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[8], [4, 2]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.uibuildernavigationview] Name[uibuildernavigationview] Icon[/opt/usr/apps/org.example.uibuildernavigationview/shared/res/uibuildernavigationview.png] enable[1] system[0]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.uibuildernavigationview'], count[0]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.uibuildernavigationview][-17956860][0]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.uibuildernavigationview]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[uibuildernavigationview] pos[4, 4] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[14]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 02:48:36.141+0900 D/BADGE   ( 2904): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 02:48:36.141+0900 E/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 02:48:36.141+0900 D/cluster-home( 2904): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[1, 5] pageId[100001]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[17], [1, 5]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 02:48:36.141+0900 D/cluster-view( 2904): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 02:48:36.151+0900 D/rpm-installer(10629): rpm-appcore-intf.c: main(238) > sync() end
06-01 02:48:36.351+0900 D/rpm-installer(10629): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 02:48:36.371+0900 D/rpm-installer(10629): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 02:48:36.371+0900 D/rpm-installer(10629): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 02:48:36.371+0900 D/rpm-installer(10629): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 02:48:36.371+0900 D/PKGMGR_SERVER(10615): pkgmgr-server.c: sighandler(387) > child exit [10629]
06-01 02:48:36.371+0900 E/PKGMGR_SERVER(10615): pkgmgr-server.c: sighandler(402) > child NORMAL exit [10629]
06-01 02:48:37.001+0900 E/PKGMGR_SERVER(10615): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 02:48:37.001+0900 E/PKGMGR_SERVER(10615): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 02:48:37.171+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 02:48:37.181+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 02:48:37.181+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 02:48:37.181+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 02:48:37.181+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 02:48:37.181+0900 D/AUL     ( 2773): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 10682, pid = 10684
06-01 02:48:37.181+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 02:48:37.181+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 02:48:37.181+0900 I/AUL     ( 2773): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 02:48:37.181+0900 E/AUL_AMD ( 2773): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 02:48:37.181+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2233) > caller pid : 10684
06-01 02:48:37.181+0900 E/AUL_AMD ( 2773): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 02:48:37.181+0900 W/AUL_AMD ( 2773): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 02:48:37.181+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2648) > process_pool: false
06-01 02:48:37.181+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 02:48:37.181+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 02:48:37.181+0900 W/AUL_AMD ( 2773): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 02:48:37.181+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 02:48:37.181+0900 D/AUL_AMD ( 2773): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 02:48:37.181+0900 D/AUL     ( 2773): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 02:48:37.181+0900 W/AUL_PAD ( 2951): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 02:48:37.181+0900 D/AUL     ( 2951): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10482, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 02:48:37.181+0900 W/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 02:48:37.181+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 02:48:37.181+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 02:48:37.181+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-01 02:48:37.181+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 02:48:37.181+0900 D/AUL_PAD (10482): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 02:48:37.181+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 02:48:37.181+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 02:48:37.181+0900 D/AUL     (10482): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10487) is sent.
06-01 02:48:37.181+0900 D/AUL     (10482): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10487, signo: 10
06-01 02:48:37.191+0900 D/AUL     (10482): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyNTI5MTcvMTg3OTYxAA==##
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMDY4NAA=##
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 02:48:37.191+0900 D/AUL_PAD (10482): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 02:48:37.191+0900 I/CAPI_APPFW_APPLICATION(10482): app_main.c: ui_app_main(788) > app_efl_main
06-01 02:48:37.191+0900 D/LAUNCH  (10482): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 02:48:37.191+0900 D/APP_CORE(10482): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 02:48:37.191+0900 D/APP_CORE(10482): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 02:48:37.191+0900 D/APP_CORE(10482): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 02:48:37.211+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 02:48:37.211+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 02:48:37.211+0900 E/RESOURCED( 2886): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 02:48:37.221+0900 D/APP_CORE(10482): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 02:48:37.221+0900 D/AUL     (10482): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 02:48:37.221+0900 D/APP_CORE(10482): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4237520
06-01 02:48:37.221+0900 D/LAUNCH  (10482): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 02:48:37.221+0900 I/CAPI_APPFW_APPLICATION(10482): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 02:48:37.291+0900 D/AUL_PAD ( 2951): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 02:48:37.291+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 10482, appid: org.example.example
06-01 02:48:37.291+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 02:48:37.291+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 02:48:37.291+0900 D/AUL_AMD ( 2773): amd_launch.c: _start_app(2700) > add app group info
06-01 02:48:37.291+0900 E/AUL     ( 2773): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 02:48:37.291+0900 D/AUL_AMD ( 2773): amd_status.c: _status_add_app_info_list(427) > pid(10482) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 02:48:37.291+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 10482
06-01 02:48:37.291+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 02:48:37.291+0900 E/RESOURCED( 2886): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 02:48:37.291+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(888) > available memory = 296
06-01 02:48:37.341+0900 D/LAUNCH  (10482): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 02:48:37.341+0900 D/APP_CORE(10482): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 02:48:37.341+0900 E/E17     ( 2798): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02e00002)
06-01 02:48:37.391+0900 E/E17     ( 2798): e_border.c: e_border_show(2088) > BD_SHOW(0x02e00002)
06-01 02:48:37.411+0900 D/APP_CORE(10482): appcore.c: __aul_handler(587) > [APP 10482]     AUL event: AUL_START
06-01 02:48:37.411+0900 I/APP_CORE(10482): appcore-efl.c: __do_app(496) > [APP 10482] Event: RESET State: CREATED
06-01 02:48:37.411+0900 D/APP_CORE(10482): appcore-efl.c: __do_app(527) > [APP 10482] RESET
06-01 02:48:37.411+0900 D/LAUNCH  (10482): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 02:48:37.411+0900 D/APP_CORE(10482): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 02:48:37.411+0900 D/APP_CORE(10482): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 02:48:37.411+0900 I/CAPI_APPFW_APPLICATION(10482): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 02:48:37.411+0900 D/AUL     (10482): service.c: __set_bundle(186) > __set_bundle
06-01 02:48:37.411+0900 D/LAUNCH  (10482): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 02:48:37.411+0900 D/APP_CORE(10482): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 02:48:37.411+0900 E/EFL     (10482): edje<10482> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:48:37.411+0900 E/EFL     (10482): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:48:37.411+0900 E/EFL     (10482): edje<10482> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:48:37.411+0900 E/EFL     (10482): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:48:37.411+0900 E/EFL     (10482): edje<10482> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:48:37.411+0900 E/EFL     (10482): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:48:37.411+0900 E/EFL     (10482): edje<10482> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:48:37.411+0900 E/EFL     (10482): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:48:37.411+0900 E/EFL     (10482): edje<10482> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 02:48:37.411+0900 E/EFL     (10482): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 02:48:37.431+0900 W/PROCESSMGR( 2798): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=10482
06-01 02:48:37.441+0900 W/APP_CORE(10482): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
06-01 02:48:37.441+0900 D/APP_CORE(10482): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2e00002
06-01 02:48:37.441+0900 D/APP_CORE(10482): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 02:48:37.441+0900 D/AUL     (10482): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 02:48:37.441+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 02:48:37.451+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 02:48:37.451+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 02:48:37.481+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 02:48:37.481+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 02:48:37.481+0900 D/PKGMGR_INFO( 2773): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 02:48:37.481+0900 D/AUL_AMD ( 2773): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 10482 is org.example.example
06-01 02:48:37.481+0900 D/AUL_AMD ( 2773): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 10482 : 0
06-01 02:48:37.491+0900 D/AUL     ( 2966): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 02:48:37.491+0900 D/INDICATOR( 2891): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 02:48:37.491+0900 D/INDICATOR( 2891): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 02:48:37.491+0900 D/INDICATOR( 2891): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 02:48:37.491+0900 D/INDICATOR( 2891): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 02:48:37.491+0900 D/INDICATOR( 2891): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 02:48:37.491+0900 D/INDICATOR( 2891): main.c: _rotate_window(252) > port :: hide more icon
06-01 02:48:37.511+0900 D/APP_CORE(10482): appcore.c: __prt_ltime(236) > [APP 10482] first idle after reset: 335 msec
06-01 02:48:37.851+0900 E/E17     ( 2798): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 02:48:37.851+0900 D/APP_CORE(10482): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 0
06-01 02:48:37.851+0900 D/APP_CORE(10482): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 02:48:37.851+0900 D/APP_CORE(10482): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 02:48:37.851+0900 D/APP_CORE( 2904): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 02:48:37.851+0900 D/APP_CORE( 2904): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 02:48:37.851+0900 D/APP_CORE( 2904): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 02:48:37.851+0900 I/APP_CORE( 2904): appcore-efl.c: __do_app(496) > [APP 2904] Event: PAUSE State: RUNNING
06-01 02:48:37.851+0900 D/APP_CORE( 2904): appcore-efl.c: __do_app(565) > [APP 2904] PAUSE
06-01 02:48:37.851+0900 I/CAPI_APPFW_APPLICATION( 2904): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 02:48:37.851+0900 I/APP_CORE(10482): appcore-efl.c: __do_app(496) > [APP 10482] Event: RESUME State: CREATED
06-01 02:48:37.851+0900 D/LAUNCH  (10482): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 02:48:37.851+0900 D/APP_CORE(10482): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 02:48:37.851+0900 D/APP_CORE(10482): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 02:48:37.851+0900 D/APP_CORE(10482): appcore-efl.c: __do_app(607) > [APP 10482] RESUME
06-01 02:48:37.851+0900 E/cluster-home( 2904): homescreen.cpp: OnPause(84) >  app pause
06-01 02:48:37.851+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 02:48:37.851+0900 D/cluster-view( 2904): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 02:48:37.851+0900 D/APP_CORE( 2904): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 02:48:37.851+0900 E/APP_CORE( 2904): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 02:48:37.851+0900 I/APP_CORE(10482): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 02:48:37.851+0900 I/APP_CORE(10482): appcore-efl.c: __do_app(614) > [APP 10482] Initial Launching, call the resume_cb
06-01 02:48:37.851+0900 I/CAPI_APPFW_APPLICATION(10482): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 02:48:37.851+0900 D/LAUNCH  (10482): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 02:48:37.851+0900 D/LAUNCH  (10482): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 02:48:37.851+0900 D/APP_CORE(10482): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 02:48:37.851+0900 E/APP_CORE(10482): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 02:48:37.871+0900 D/DATA_PROVIDER_MASTER( 2954): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2904 is paused
06-01 02:48:37.871+0900 D/DATA_PROVIDER_MASTER( 2954): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 02:48:37.881+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(2904) status(4)
06-01 02:48:37.881+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(2904) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 02:48:37.881+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 02:48:37.881+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2904, appid: org.tizen.homescreen, status: bg
06-01 02:48:37.881+0900 I/CAPI_WIDGET_APPLICATION( 3032): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 02:48:37.881+0900 I/CAPI_WIDGET_APPLICATION( 3032): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 02:48:37.881+0900 W/AUL     ( 3032): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3032, appid: org.tizen.calendar.widget, status: bg
06-01 02:48:37.881+0900 D/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3032, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 02:48:37.881+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3032
06-01 02:48:37.881+0900 D/RESOURCED( 2886): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3032, appname = org.tizen.calendar.widget
06-01 02:48:37.881+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3032
06-01 02:48:37.901+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2891) > pid(10482) status(3)
06-01 02:48:37.901+0900 D/AUL_AMD ( 2773): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-01 02:48:37.931+0900 W/AUL_AMD ( 2773): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 02:48:37.931+0900 W/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 02:48:37.931+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(456) > pid(10482) status(3)
06-01 02:48:37.931+0900 D/AUL_AMD ( 2773): amd_status.c: _status_update_app_info_list(468) > pid(10482) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 02:48:37.931+0900 D/AUL     ( 2773): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 02:48:37.931+0900 W/AUL     ( 2773): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 10482, appid: org.example.example, status: fg
06-01 02:48:37.931+0900 D/RESOURCED( 2886): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 10482
06-01 02:48:37.931+0900 D/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 10482, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 02:48:37.931+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 10482
06-01 02:48:37.981+0900 D/RESOURCED( 2886): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 10482, appname = org.example.example, pkgname = org.example.example
06-01 02:48:37.981+0900 D/RESOURCED( 2886): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 10482, appname = org.example.example
06-01 02:48:37.981+0900 D/RESOURCED( 2886): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10482
06-01 02:48:37.981+0900 I/RESOURCED( 2886): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 02:48:37.981+0900 I/RESOURCED( 2886): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 02:48:38.061+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2910) > pid(10482) status(0)
06-01 02:48:38.301+0900 D/AUL_PAD ( 2951): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 02:48:38.301+0900 D/AUL_PAD (10691): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 02:48:38.351+0900 D/AUL_PAD ( 2951): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 02:48:38.361+0900 E/RESOURCED( 2886): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.847
06-01 02:48:38.801+0900 D/AUL_AMD ( 2773): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 02:48:38.811+0900 D/RUA     ( 2773): rua.c: rua_add_history(179) > rua_add_history start
06-01 02:48:38.871+0900 D/RUA     ( 2773): rua.c: rua_add_history(247) > rua_add_history ok
06-01 02:48:38.941+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:1471 eo_isa() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:1471 eo_isa() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:1471 eo_isa() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7b04d70 is not pointing to a valid object. Maybe it has already been freed.
06-01 02:48:38.951+0900 E/EFL     (10482): eo<10482> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb7b04d70) is an invalid ref.
06-01 02:48:39.031+0900 D/AUL_PAD ( 2951): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 02:48:39.031+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 02:48:39.031+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 02:48:39.031+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 02:48:39.031+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 02:48:39.031+0900 D/AUL_PAD ( 2951): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 02:48:39.031+0900 D/AUL_PAD ( 2951): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 02:48:39.031+0900 I/AUL_PAD ( 2951): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 10482 pgid = 10482
06-01 02:48:39.031+0900 I/AUL_PAD ( 2951): sigchild.h: __sigchild_action(142) > dead_pid(10482)
06-01 02:48:39.031+0900 E/EFL     ( 2798): eo<2798> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 02:48:39.051+0900 D/PROCESSMGR( 2798): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x401373 
06-01 02:48:39.051+0900 D/AUL_PAD ( 2951): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-01 02:48:39.051+0900 I/AUL_PAD ( 2951): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-01 02:48:39.051+0900 I/AUL_PAD ( 2951): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-01 02:48:39.051+0900 E/AUL_PAD ( 2951): launchpad.c: main(688) > error reading sigchld info
06-01 02:48:39.051+0900 D/STARTER ( 2883): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 10482 is termianted
06-01 02:48:39.051+0900 D/STARTER ( 2883): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-01 02:48:39.051+0900 I/ESD     ( 2964): esd_main.c: __esd_app_dead_handler(1771) > pid: 10482
06-01 02:48:39.051+0900 W/AUL_AMD ( 2773): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 10482
06-01 02:48:39.051+0900 W/AUL_AMD ( 2773): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 10482
06-01 02:48:39.051+0900 D/AUL_AMD ( 2773): amd_key.c: _unregister_key_event(179) > ===key stack===
06-01 02:48:39.051+0900 E/AUL_AMD ( 2773): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-01 02:48:39.051+0900 D/AUL_AMD ( 2773): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
06-01 02:48:39.061+0900 D/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 02:48:39.061+0900 E/AUL     ( 2773): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 02:48:39.061+0900 E/RESOURCED( 2886): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.848
06-01 02:48:39.061+0900 D/AUL_AMD ( 2773): amd_launch.c: __e17_status_handler(2891) > pid(2904) status(3)
06-01 02:48:39.061+0900 D/RESOURCED( 2886): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 10482
06-01 02:48:39.061+0900 D/RESOURCED( 2886): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
06-01 02:48:39.061+0900 W/CRASH_MANAGER(10692): worker.c: worker_job(1204) > 1110482657861149625291
