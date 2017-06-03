S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 9117
Date: 2017-06-03 21:53:31+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb37d02b8, esi = 0xbf8f6fb0
ebp = 0xbf8f7038, esp = 0xbf8f6fac
eax = 0xb37cda55, ebx = 0xb37d0000
ecx = 0x00000050, edx = 0x00000000
eip = 0xb6d94c0b

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         4 KB
Cached:     151716 KB
VmPeak:     123308 KB
VmSize:     123308 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36164 KB
VmRSS:       36164 KB
VmData:      53396 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9117 TID = 9117
9117 9119 9319 9320 9325 

Maps Information
b180a000 b1811000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1814000 b182c000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b182d000 b1834000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b18b1000 b18b5000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b8a000 b2b94000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b9a000 b2ba6000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2ba7000 b2bc8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bcd000 b2bce000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bcf000 b2bd4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bd5000 b2bd6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bd7000 b2bd9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bda000 b2bdc000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bdd000 b2be9000 r-xp /usr/lib/libdrm.so.2.4.0
b2bea000 b2bed000 r-xp /usr/lib/libdri2.so.0.0.0
b2bee000 b2bf8000 r-xp /usr/lib/libtbm.so.1.0.0
b2bf9000 b2c0e000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c0f000 b2c21000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3423000 b3454000 r-xp /usr/lib/libidn.so.11.5.44
b3455000 b3477000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3478000 b3488000 r-xp /usr/lib/libcares.so.2.1.0
b3489000 b3492000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3493000 b349c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b349d000 b3514000 r-xp /usr/lib/libcurl.so.4.3.0
b3516000 b3528000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3529000 b354a000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3551000 b3552000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3553000 b3554000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3555000 b3558000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3559000 b355c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3664000 b366a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b366b000 b37af000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37c0000 b37c1000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37c2000 b37cf000 r-xp /opt/usr/apps/org.example.example/bin/example
b37d1000 b380a000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b420d000 b4218000 r-xp /lib/libnss_files-2.20-2014.11.so
b421a000 b4225000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4227000 b423e000 r-xp /lib/libnsl-2.20-2014.11.so
b4242000 b424a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b424c000 b4270000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4271000 b4272000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4273000 b4276000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4277000 b427e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427f000 b4289000 r-xp /usr/lib/libsensord-share.so
b428a000 b42a6000 r-xp /usr/lib/libsensor.so.1.2.0
b42a8000 b42b1000 r-xp /usr/lib/libappcore-common.so.1.1
b42b4000 b42b6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42cb000 b42cd000 r-xp /usr/lib/libXau.so.6.0.0
b42ce000 b42f0000 r-xp /usr/lib/libxcb.so.1.1.0
b42f2000 b42fb000 r-xp /lib/libcrypt-2.20-2014.11.so
b4324000 b4326000 r-xp /usr/lib/libiri.so
b4327000 b434d000 r-xp /lib/libexpat.so.1.5.2
b434f000 b43ba000 r-xp /usr/lib/libssl.so.1.0.0
b43c0000 b43cc000 r-xp /usr/lib/libethumb.so.1.13.0
b43cd000 b43d1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43d2000 b4623000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9e000 b5bae000 r-xp /usr/lib/libXi.so.6.1.0
b5baf000 b5bb1000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bb2000 b5bb8000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb9000 b5bc3000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc4000 b5bcd000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bcf000 b5bd1000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bd2000 b5bd7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd8000 b5bea000 r-xp /usr/lib/libXext.so.6.4.0
b5beb000 b5bed000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bee000 b5bf0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bf2000 b5d34000 r-xp /usr/lib/libX11.so.6.3.0
b5d38000 b5d42000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d43000 b5d59000 r-xp /usr/lib/libudev.so.1.6.0
b5d5c000 b5d60000 r-xp /lib/libattr.so.1.1.0
b5d61000 b5d90000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d92000 b5d98000 r-xp /usr/lib/libffi.so.6.0.2
b5d99000 b5dbc000 r-xp /lib/libz.so.1.2.8
b5dbd000 b5dc0000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dc1000 b5f1d000 r-xp /usr/lib/libxml2.so.2.9.2
b5f23000 b600a000 r-xp /usr/lib/libstdc++.so.6.0.20
b6017000 b601a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b601b000 b603d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603e000 b6052000 r-xp /lib/libresolv-2.20-2014.11.so
b6056000 b607a000 r-xp /usr/lib/liblzma.so.5.0.3
b607b000 b607d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607f000 b6089000 r-xp /usr/lib/libembryo.so.1.13.0
b608a000 b60b3000 r-xp /usr/lib/libpng12.so.0.50.0
b60b4000 b60fd000 r-xp /usr/lib/libjpeg.so.8.0.2
b610e000 b6115000 r-xp /lib/librt-2.20-2014.11.so
b6117000 b6136000 r-xp /usr/lib/libector.so.1.13.0
b6139000 b6166000 r-xp /usr/lib/liblua-5.1.so
b6167000 b61f7000 r-xp /usr/lib/libfreetype.so.6.11.3
b61fb000 b6239000 r-xp /usr/lib/libfontconfig.so.1.8.0
b623a000 b6250000 r-xp /usr/lib/libfribidi.so.0.3.1
b6251000 b62aa000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62ad000 b62f8000 r-xp /lib/libm-2.20-2014.11.so
b62fa000 b630c000 r-xp /usr/lib/libeio.so.1.13.0
b630d000 b6310000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6311000 b6317000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6318000 b633b000 r-xp /usr/lib/libefreet.so.1.13.0
b633e000 b6369000 r-xp /usr/lib/libeldbus.so.1.13.0
b636a000 b639e000 r-xp /usr/lib/libecore_con.so.1.13.0
b63a0000 b63a9000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63aa000 b63b3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b4000 b63c7000 r-xp /usr/lib/libeo.so.1.13.0
b63c9000 b63dc000 r-xp /usr/lib/libecore_input.so.1.13.0
b63dd000 b63e4000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e5000 b6408000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6409000 b6435000 r-xp /usr/lib/libeet.so.1.13.0
b643e000 b64a9000 r-xp /usr/lib/libeina.so.1.13.0
b64ac000 b64c3000 r-xp /usr/lib/libefl.so.1.13.0
b64c5000 b662c000 r-xp /usr/lib/libicuuc.so.51.1
b663a000 b6846000 r-xp /usr/lib/libicui18n.so.51.1
b684e000 b689d000 r-xp /usr/lib/libecore_x.so.1.13.0
b689f000 b68b9000 r-xp /lib/libgcc_s-4.9.so.1
b68bb000 b68bf000 r-xp /lib/libcap.so.2.21
b68c0000 b6906000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6907000 b690e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6910000 b6962000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6964000 b6aef000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af4000 b6bc2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc5000 b6bc9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bca000 b6bd9000 r-xp /usr/lib/libvconf.so.0.2.45
b6bda000 b6bdd000 r-xp /usr/lib/libvasum.so.0.3.1
b6bde000 b6be1000 r-xp /usr/lib/libttrace.so.1.1
b6be3000 b6be7000 r-xp /usr/lib/libiniparser.so.0
b6be8000 b6c18000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c19000 b6c22000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c23000 b6c48000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c49000 b6c59000 r-xp /usr/lib/libunwind.so.8.0.1
b6c63000 b6e11000 r-xp /lib/libc-2.20-2014.11.so
b6e19000 b6f5c000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5e000 b6fb6000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb7000 b6feb000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fee000 b70c2000 r-xp /usr/lib/libedje.so.1.13.0
b70c5000 b70f1000 r-xp /usr/lib/libecore.so.1.13.0
b7102000 b7328000 r-xp /usr/lib/libevas.so.1.13.0
b7350000 b7368000 r-xp /lib/libpthread-2.20-2014.11.so
b736c000 b76e6000 r-xp /usr/lib/libelementary.so.1.13.0
b7706000 b770a000 r-xp /usr/lib/libsmack.so.1.0.0
b770b000 b7714000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7715000 b7718000 r-xp /usr/lib/libdlog.so.0.0.0
b7719000 b771e000 r-xp /usr/lib/libbundle.so.0.1.22
b771f000 b7722000 r-xp /lib/libdl-2.20-2014.11.so
b7724000 b7749000 r-xp /usr/lib/libaul.so.0.1.0
b774c000 b774e000 r-xp /usr/lib/libappsvc.so.0.1.0
b774f000 b7754000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7755000 b775c000 r-xp /usr/lib/libappcore-efl.so.1.1
b775e000 b7763000 r-xp /usr/lib/libsys-assert.so
b7766000 b7767000 r-xp [vdso]
b7767000 b7789000 r-xp /lib/ld-2.20-2014.11.so
b778b000 b7793000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:9117)
Call Stack Count: 28
 0: (0xb6d94c0b) [/lib/libc.so.6] + 0x131c0b
 1: (0xb74c81f9) [/usr/lib/libelementary.so.1] + 0x15c1f9
 2: (0xb74c873e) [/usr/lib/libelementary.so.1] + 0x15c73e
 3: elm_wdg_item_del_pre + 0x93 (0xb75c9363) [/usr/lib/libelementary.so.1] + 0x25d363
 4: (0xb75d6f07) [/usr/lib/libelementary.so.1] + 0x26af07
 5: elm_wdg_item_del + 0x99 (0xb75c7489) [/usr/lib/libelementary.so.1] + 0x25b489
 6: elm_object_item_del + 0x53 (0xb75d9483) [/usr/lib/libelementary.so.1] + 0x26d483
 7: gl_del_cb + 0x1fb (0xb37c925b) [/opt/usr/apps/org.example.example/bin/example] + 0x725b
 8: (0xb718b116) [/usr/lib/libevas.so.1] + 0x89116
 9: (0xb63c2319) [/usr/lib/libeo.so.1] + 0xe319
10: eo_event_callback_call + 0xb3 (0xb63bfd63) [/usr/lib/libeo.so.1] + 0xbd63
11: evas_object_smart_callback_call + 0x75 (0xb718d9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
12: (0xb743e404) [/usr/lib/libelementary.so.1] + 0xd2404
13: (0xb7071f39) [/usr/lib/libedje.so.1] + 0x83f39
14: (0xb7078a11) [/usr/lib/libedje.so.1] + 0x8aa11
15: (0xb7072fdc) [/usr/lib/libedje.so.1] + 0x84fdc
16: (0xb70734cb) [/usr/lib/libedje.so.1] + 0x854cb
17: (0xb707368f) [/usr/lib/libedje.so.1] + 0x8568f
18: (0xb70d8702) [/usr/lib/libecore.so.1] + 0x13702
19: (0xb70d2055) [/usr/lib/libecore.so.1] + 0xd055
20: (0xb70db1b9) [/usr/lib/libecore.so.1] + 0x161b9
21: ecore_main_loop_begin + 0x57 (0xb70db587) [/usr/lib/libecore.so.1] + 0x16587
22: elm_run + 0x2d (0xb753422d) [/usr/lib/libelementary.so.1] + 0x1c822d
23: appcore_efl_main + 0x4de (0xb7758dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
24: ui_app_main + 0x140 (0xb7751c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
25: main + 0x296 (0xb37ca6c6) [/opt/usr/apps/org.example.example/bin/example] + 0x86c6
26: (0xb778d148) [/opt/usr/apps/org.example.example/bin/example] + 0xb778d148
27: __libc_start_main + 0xde (0xb6c7ae4e) [/lib/libc.so.6] + 0x17e4e
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
 [1]th page, updated[1]
06-03 21:53:24.464+0900 E/cluster-home( 2868): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-03 21:53:24.464+0900 D/BADGE   ( 2868): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-03 21:53:24.464+0900 E/cluster-home( 2868): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-03 21:53:24.464+0900 D/cluster-home( 2868): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[3, 3] pageId[100001]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-03 21:53:24.464+0900 E/cluster-home( 2868): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-03 21:53:24.464+0900 D/BADGE   ( 2868): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-03 21:53:24.464+0900 E/cluster-home( 2868): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-03 21:53:24.464+0900 D/cluster-home( 2868): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[4, 3] pageId[100001]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-03 21:53:24.464+0900 E/cluster-home( 2868): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-03 21:53:24.464+0900 D/BADGE   ( 2868): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-03 21:53:24.464+0900 E/cluster-home( 2868): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-03 21:53:24.464+0900 D/cluster-home( 2868): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[1, 4] pageId[100001]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-03 21:53:24.464+0900 E/cluster-home( 2868): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-03 21:53:24.464+0900 D/BADGE   ( 2868): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-03 21:53:24.464+0900 E/cluster-home( 2868): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-03 21:53:24.464+0900 D/cluster-home( 2868): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[2, 4] pageId[100001]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-03 21:53:24.464+0900 D/cluster-view( 2868): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-03 21:53:24.464+0900 D/rpm-installer( 9260): rpm-appcore-intf.c: main(238) > sync() end
06-03 21:53:24.604+0900 D/rpm-installer( 9260): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-03 21:53:24.604+0900 D/rpm-installer( 9260): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-03 21:53:24.604+0900 D/rpm-installer( 9260): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-03 21:53:24.604+0900 D/rpm-installer( 9260): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-03 21:53:24.604+0900 D/PKGMGR_SERVER( 9244): pkgmgr-server.c: sighandler(387) > child exit [9260]
06-03 21:53:24.604+0900 E/PKGMGR_SERVER( 9244): pkgmgr-server.c: sighandler(402) > child NORMAL exit [9260]
06-03 21:53:24.854+0900 D/AUL_AMD ( 2723): amd_request.c: __request_handler(838) > __request_handler: 0
06-03 21:53:24.854+0900 D/AUL_AMD ( 2723): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-03 21:53:24.854+0900 D/PKGMGR_INFO( 2723): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-03 21:53:24.854+0900 D/PKGMGR_INFO( 2723): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-03 21:53:24.854+0900 I/AUL     ( 2723): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-03 21:53:24.854+0900 D/AUL     ( 2723): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 9313, pid = 9315
06-03 21:53:24.854+0900 D/PKGMGR_INFO( 2723): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-03 21:53:24.854+0900 D/PKGMGR_INFO( 2723): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-03 21:53:24.854+0900 I/AUL     ( 2723): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-03 21:53:24.854+0900 E/AUL_AMD ( 2723): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-03 21:53:24.854+0900 W/AUL_AMD ( 2723): amd_launch.c: _start_app(2233) > caller pid : 9315
06-03 21:53:24.854+0900 E/AUL_AMD ( 2723): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-03 21:53:24.854+0900 W/AUL_AMD ( 2723): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-03 21:53:24.854+0900 D/AUL_AMD ( 2723): amd_launch.c: _start_app(2648) > process_pool: false
06-03 21:53:24.854+0900 D/AUL_AMD ( 2723): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-03 21:53:24.854+0900 D/AUL_AMD ( 2723): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-03 21:53:24.854+0900 W/AUL_AMD ( 2723): amd_launch.c: _start_app(2665) > pad pid(-5)
06-03 21:53:24.854+0900 D/AUL_AMD ( 2723): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-03 21:53:24.854+0900 D/AUL_AMD ( 2723): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-03 21:53:24.854+0900 D/AUL     ( 2723): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-03 21:53:24.854+0900 W/AUL_PAD ( 2917): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-03 21:53:24.854+0900 D/AUL     ( 2917): process_pool.c: __send_pkt_raw_data(219) > send(13) : 620 / 620
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 9117, bin path: /opt/usr/apps/org.example.example/bin/example
06-03 21:53:24.854+0900 W/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(265) > Check app launching
06-03 21:53:24.854+0900 D/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-03 21:53:24.854+0900 D/AUL     ( 9117): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (9119) is sent.
06-03 21:53:24.854+0900 D/RESOURCED( 2851): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-03 21:53:24.854+0900 D/RESOURCED( 2851): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-03 21:53:24.854+0900 D/AUL     ( 9117): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 9119, signo: 10
06-03 21:53:24.854+0900 E/RESOURCED( 2851): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 21:53:24.854+0900 D/AUL     ( 9117): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY0OTQ0MDQvODYyNzg2AA==##
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA5MzE1AA==##
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-03 21:53:24.854+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-03 21:53:24.864+0900 D/AUL_PAD ( 9117): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-03 21:53:24.864+0900 D/AUL_PAD ( 9117): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-03 21:53:24.864+0900 I/CAPI_APPFW_APPLICATION( 9117): app_main.c: ui_app_main(788) > app_efl_main
06-03 21:53:24.864+0900 D/LAUNCH  ( 9117): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-03 21:53:24.864+0900 D/APP_CORE( 9117): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-03 21:53:24.864+0900 D/APP_CORE( 9117): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-03 21:53:24.864+0900 D/APP_CORE( 9117): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-03 21:53:24.874+0900 D/APP_CORE( 9117): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-03 21:53:24.874+0900 D/AUL     ( 9117): app_sock.c: __create_server_sock(156) > pg path - already exists
06-03 21:53:24.874+0900 D/APP_CORE( 9117): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42b1520
06-03 21:53:24.874+0900 D/LAUNCH  ( 9117): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-03 21:53:24.874+0900 I/CAPI_APPFW_APPLICATION( 9117): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-03 21:53:24.914+0900 D/LAUNCH  ( 9117): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-03 21:53:24.914+0900 E/E17     ( 2772): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02e00002)
06-03 21:53:24.914+0900 D/APP_CORE( 9117): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-03 21:53:24.914+0900 E/E17     ( 2772): e_border.c: e_border_show(2088) > BD_SHOW(0x02e00002)
06-03 21:53:24.924+0900 D/APP_CORE( 9117): appcore.c: __aul_handler(587) > [APP 9117]     AUL event: AUL_START
06-03 21:53:24.924+0900 I/APP_CORE( 9117): appcore-efl.c: __do_app(496) > [APP 9117] Event: RESET State: CREATED
06-03 21:53:24.924+0900 D/APP_CORE( 9117): appcore-efl.c: __do_app(527) > [APP 9117] RESET
06-03 21:53:24.924+0900 D/LAUNCH  ( 9117): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-03 21:53:24.924+0900 D/APP_CORE( 9117): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-03 21:53:24.924+0900 D/APP_CORE( 9117): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-03 21:53:24.924+0900 I/CAPI_APPFW_APPLICATION( 9117): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-03 21:53:24.924+0900 D/AUL     ( 9117): service.c: __set_bundle(186) > __set_bundle
06-03 21:53:24.924+0900 D/LAUNCH  ( 9117): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-03 21:53:24.924+0900 D/APP_CORE( 9117): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-03 21:53:24.924+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-03 21:53:24.924+0900 E/EFL     ( 9117): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 21:53:24.924+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-03 21:53:24.924+0900 E/EFL     ( 9117): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 21:53:24.924+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-03 21:53:24.924+0900 E/EFL     ( 9117): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 21:53:24.924+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-03 21:53:24.924+0900 E/EFL     ( 9117): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 21:53:24.924+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-03 21:53:24.924+0900 E/EFL     ( 9117): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 21:53:24.934+0900 W/PROCESSMGR( 2772): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9117
06-03 21:53:24.944+0900 E/EFL     ( 2772): eo<2772> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-03 21:53:24.944+0900 E/EFL     ( 2772): eo<2772> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-03 21:53:24.944+0900 D/INDICATOR( 2853): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-03 21:53:24.954+0900 D/INDICATOR( 2853): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-03 21:53:24.954+0900 D/INDICATOR( 2853): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-03 21:53:24.954+0900 D/INDICATOR( 2853): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-03 21:53:24.954+0900 D/INDICATOR( 2853): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-03 21:53:24.954+0900 D/INDICATOR( 2853): main.c: _rotate_window(252) > port :: hide more icon
06-03 21:53:24.954+0900 D/AUL_PAD ( 2917): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-03 21:53:24.954+0900 W/AUL     ( 2723): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 9117, appid: org.example.example
06-03 21:53:24.954+0900 D/AUL     ( 2723): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-03 21:53:24.954+0900 E/AUL     ( 2723): simple_util.c: __trm_app_info_send_socket(330) > access
06-03 21:53:24.954+0900 D/AUL_AMD ( 2723): amd_launch.c: _start_app(2700) > add app group info
06-03 21:53:24.954+0900 E/AUL     ( 2723): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-03 21:53:24.954+0900 D/AUL_AMD ( 2723): amd_status.c: _status_add_app_info_list(427) > pid(9117) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-03 21:53:24.954+0900 D/AUL_AMD ( 2723): amd_request.c: __request_handler(838) > __request_handler: 15
06-03 21:53:24.954+0900 D/PKGMGR_INFO( 2723): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-03 21:53:24.954+0900 D/PKGMGR_INFO( 2723): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-03 21:53:24.954+0900 D/AUL_AMD ( 2723): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 9117 is org.example.example
06-03 21:53:24.954+0900 D/AUL_AMD ( 2723): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 9117 : 0
06-03 21:53:24.954+0900 D/AUL     ( 2936): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-03 21:53:24.964+0900 D/RESOURCED( 2851): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 9117
06-03 21:53:24.964+0900 D/RESOURCED( 2851): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-03 21:53:24.964+0900 E/RESOURCED( 2851): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-03 21:53:24.964+0900 D/RESOURCED( 2851): proc-main.c: resourced_proc_status_change(888) > available memory = 299
06-03 21:53:25.024+0900 D/APP_CORE( 9117): appcore.c: __prt_ltime(236) > [APP 9117] first idle after reset: 171 msec
06-03 21:53:25.044+0900 W/APP_CORE( 9117): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
06-03 21:53:25.044+0900 D/APP_CORE( 9117): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2e00002
06-03 21:53:25.044+0900 D/APP_CORE( 9117): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-03 21:53:25.044+0900 D/AUL     ( 9117): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-03 21:53:25.044+0900 D/AUL_AMD ( 2723): amd_request.c: __request_handler(838) > __request_handler: 34
06-03 21:53:25.244+0900 E/E17     ( 2772): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-03 21:53:25.244+0900 D/APP_CORE( 9117): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 0
06-03 21:53:25.244+0900 D/APP_CORE( 2868): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-03 21:53:25.244+0900 D/APP_CORE( 2868): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-03 21:53:25.244+0900 D/APP_CORE( 2868): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-03 21:53:25.244+0900 I/APP_CORE( 2868): appcore-efl.c: __do_app(496) > [APP 2868] Event: PAUSE State: RUNNING
06-03 21:53:25.244+0900 D/APP_CORE( 2868): appcore-efl.c: __do_app(565) > [APP 2868] PAUSE
06-03 21:53:25.244+0900 I/CAPI_APPFW_APPLICATION( 2868): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-03 21:53:25.244+0900 E/cluster-home( 2868): homescreen.cpp: OnPause(84) >  app pause
06-03 21:53:25.244+0900 D/cluster-view( 2868): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-03 21:53:25.244+0900 D/cluster-view( 2868): homescreen-view-manager.cpp: AppPause(923) >  END
06-03 21:53:25.244+0900 D/APP_CORE( 2868): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-03 21:53:25.244+0900 E/APP_CORE( 2868): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-03 21:53:25.244+0900 D/AUL_AMD ( 2723): amd_status.c: _status_update_app_info_list(456) > pid(2868) status(4)
06-03 21:53:25.244+0900 D/AUL_AMD ( 2723): amd_status.c: _status_update_app_info_list(468) > pid(2868) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-03 21:53:25.244+0900 D/AUL     ( 2723): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-03 21:53:25.244+0900 W/AUL     ( 2723): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2868, appid: org.tizen.homescreen, status: bg
06-03 21:53:25.244+0900 D/APP_CORE( 9117): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-03 21:53:25.244+0900 D/APP_CORE( 9117): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-03 21:53:25.244+0900 I/APP_CORE( 9117): appcore-efl.c: __do_app(496) > [APP 9117] Event: RESUME State: CREATED
06-03 21:53:25.244+0900 D/LAUNCH  ( 9117): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-03 21:53:25.244+0900 D/APP_CORE( 9117): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-03 21:53:25.254+0900 D/APP_CORE( 9117): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-03 21:53:25.254+0900 D/APP_CORE( 9117): appcore-efl.c: __do_app(607) > [APP 9117] RESUME
06-03 21:53:25.254+0900 I/APP_CORE( 9117): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-03 21:53:25.254+0900 I/APP_CORE( 9117): appcore-efl.c: __do_app(614) > [APP 9117] Initial Launching, call the resume_cb
06-03 21:53:25.254+0900 I/CAPI_APPFW_APPLICATION( 9117): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-03 21:53:25.254+0900 D/LAUNCH  ( 9117): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-03 21:53:25.254+0900 D/LAUNCH  ( 9117): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-03 21:53:25.254+0900 D/APP_CORE( 9117): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-03 21:53:25.254+0900 E/APP_CORE( 9117): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-03 21:53:25.254+0900 D/AUL_AMD ( 2723): amd_launch.c: __e17_status_handler(2891) > pid(9117) status(3)
06-03 21:53:25.254+0900 D/AUL_AMD ( 2723): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-03 21:53:25.254+0900 W/AUL_AMD ( 2723): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 21:53:25.254+0900 W/AUL_AMD ( 2723): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-03 21:53:25.254+0900 D/AUL_AMD ( 2723): amd_status.c: _status_update_app_info_list(456) > pid(9117) status(3)
06-03 21:53:25.254+0900 D/AUL_AMD ( 2723): amd_status.c: _status_update_app_info_list(468) > pid(9117) appid(org.example.example) pkgid(org.example.example) status(3)
06-03 21:53:25.254+0900 D/AUL     ( 2723): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-03 21:53:25.254+0900 W/AUL     ( 2723): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 9117, appid: org.example.example, status: fg
06-03 21:53:25.254+0900 D/RESOURCED( 2851): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 9117
06-03 21:53:25.254+0900 D/RESOURCED( 2851): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 9117, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-03 21:53:25.254+0900 D/RESOURCED( 2851): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 9117
06-03 21:53:25.254+0900 D/DATA_PROVIDER_MASTER( 2920): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2868 is paused
06-03 21:53:25.254+0900 D/DATA_PROVIDER_MASTER( 2920): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-03 21:53:25.254+0900 I/CAPI_WIDGET_APPLICATION( 3010): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-03 21:53:25.254+0900 I/CAPI_WIDGET_APPLICATION( 3010): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-03 21:53:25.254+0900 W/AUL     ( 3010): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3010, appid: org.tizen.calendar.widget, status: bg
06-03 21:53:25.304+0900 D/RESOURCED( 2851): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 9117, appname = org.example.example, pkgname = org.example.example
06-03 21:53:25.304+0900 D/RESOURCED( 2851): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 9117, appname = org.example.example
06-03 21:53:25.304+0900 D/RESOURCED( 2851): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 9117
06-03 21:53:25.304+0900 I/RESOURCED( 2851): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-03 21:53:25.304+0900 I/RESOURCED( 2851): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-03 21:53:25.304+0900 D/RESOURCED( 2851): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3010, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-03 21:53:25.304+0900 D/RESOURCED( 2851): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3010
06-03 21:53:25.304+0900 D/RESOURCED( 2851): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3010, appname = org.tizen.calendar.widget
06-03 21:53:25.304+0900 D/RESOURCED( 2851): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3010
06-03 21:53:25.434+0900 D/AUL_AMD ( 2723): amd_launch.c: __e17_status_handler(2910) > pid(9117) status(0)
06-03 21:53:25.964+0900 D/AUL_PAD ( 2917): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-03 21:53:25.964+0900 D/AUL_PAD ( 9322): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-03 21:53:25.964+0900 D/AUL_PAD ( 2917): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-03 21:53:25.964+0900 E/RESOURCED( 2851): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.786
06-03 21:53:25.994+0900 E/PKGMGR_SERVER( 9244): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 21:53:25.994+0900 E/PKGMGR_SERVER( 9244): pkgmgr-server.c: main(2265) > package manager server terminated.
06-03 21:53:26.354+0900 E/CAPI_NETWORK_WIFI( 2853): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-03 21:53:26.354+0900 E/INDICATOR( 2853): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-03 21:53:26.354+0900 E/INDICATOR( 2853): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-03 21:53:26.354+0900 E/INDICATOR( 2853): 
06-03 21:53:26.464+0900 D/AUL_AMD ( 2723): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-03 21:53:26.464+0900 D/RUA     ( 2723): rua.c: rua_add_history(179) > rua_add_history start
06-03 21:53:26.464+0900 D/RUA     ( 2723): rua.c: rua_add_history(247) > rua_add_history ok
06-03 21:53:26.934+0900 I/user_tag0( 9117): /opt/usr/apps/org.example.example/data/feeding.db
06-03 21:53:26.954+0900 I/tag     ( 9117): eonji~
06-03 21:53:26.994+0900 D/PROCESSMGR( 2772): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x602040 
06-03 21:53:26.994+0900 D/AUL_PAD ( 9322): launchpad_loader.c: main(588) > sleeping 1 sec...
06-03 21:53:26.994+0900 D/AUL_PAD ( 9322): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-03 21:53:26.994+0900 D/AUL_PAD ( 9322): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b835a760
06-03 21:53:26.994+0900 D/AUL_PAD ( 9322): preload.h: __preload_init(69) > get pre-initialization function
06-03 21:53:26.994+0900 D/AUL_PAD ( 9322): preload.h: __preload_init(73) > get shutdown function
06-03 21:53:27.004+0900 D/AUL_PAD ( 9322): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b835aa40
06-03 21:53:27.004+0900 D/AUL_PAD ( 9322): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b835c640
06-03 21:53:27.004+0900 D/AUL_PAD ( 9322): preload.h: __preload_init(69) > get pre-initialization function
06-03 21:53:27.004+0900 D/AUL_PAD ( 9322): preload.h: __preload_init(73) > get shutdown function
06-03 21:53:27.004+0900 D/AUL_PAD ( 9322): preexec.h: __preexec_init(76) > preexec start
06-03 21:53:27.004+0900 D/AUL_PAD ( 9322): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-03 21:53:27.004+0900 D/AUL     ( 9322): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-03 21:53:27.004+0900 D/AUL     ( 9322): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-03 21:53:27.004+0900 D/AUL     ( 9322): process_pool.c: __connect_to_launchpad(132) > send(9322) : 4
06-03 21:53:27.004+0900 D/AUL     ( 9322): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-03 21:53:27.004+0900 D/AUL_PAD ( 2917): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 9322
06-03 21:53:27.124+0900 D/AUL_PAD ( 9322): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-03 21:53:27.124+0900 D/AUL_PAD ( 9322): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-03 21:53:27.124+0900 D/AUL_PAD ( 9322): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-03 21:53:27.124+0900 D/AUL_PAD ( 9322): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-03 21:53:27.814+0900 D/PROCESSMGR( 2772): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x602040 
06-03 21:53:27.914+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.914+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.964+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.964+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.964+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.964+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.964+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.974+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.974+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:27.974+0900 D/IMMODULE( 9117): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-03 21:53:27.974+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-socket-frontend, example
06-03 21:53:27.974+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(524) > connect() succeeded
06-03 21:53:27.984+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-socket-frontend, example
06-03 21:53:27.984+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(524) > connect() succeeded
06-03 21:53:27.984+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-socket-frontend, example
06-03 21:53:27.984+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(524) > connect() succeeded
06-03 21:53:27.984+0900 D/ISF_QUERY( 9117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-03 21:53:27.984+0900 D/ISF_QUERY( 9117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-03 21:53:27.984+0900 D/ISF_QUERY( 9117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-03 21:53:27.984+0900 D/ISF_QUERY( 9117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-03 21:53:27.984+0900 D/ISF_QUERY( 9117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-03 21:53:27.984+0900 D/ISF_QUERY( 9117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-03 21:53:27.984+0900 D/ISF_QUERY( 9117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-03 21:53:27.994+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-socket-frontend, example
06-03 21:53:27.994+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(524) > connect() succeeded
06-03 21:53:27.994+0900 D/IMMODULE( 9117): scim_panel_client.cpp: open_connection(162) > 
06-03 21:53:27.994+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-panel-socket:0, example
06-03 21:53:27.994+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(524) > connect() succeeded
06-03 21:53:27.994+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(515) > ppid:2917  trying connect() to local:/tmp/scim-panel-socket:0, example
06-03 21:53:27.994+0900 D/ISF_SOCKET( 9117): scim_socket.cpp: connect(524) > connect() succeeded
06-03 21:53:27.994+0900 D/IMMODULE( 9117): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-03 21:53:28.754+0900 D/PROCESSMGR( 2772): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x602040 
06-03 21:53:29.184+0900 D/PROCESSMGR( 2772): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x602040 
06-03 21:53:29.334+0900 I/tag     ( 9117): insert~~~
06-03 21:53:29.334+0900 I/user_tag( 9117): 09:53 PM
06-03 21:53:29.344+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:29.344+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:29.344+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:29.344+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:29.354+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-03 21:53:29.934+0900 D/PROCESSMGR( 2772): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x602040 
06-03 21:53:30.254+0900 D/APP_CORE( 2868): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-03 21:53:30.254+0900 I/APP_CORE( 2868): appcore-efl.c: __do_app(496) > [APP 2868] Event: MEM_FLUSH State: PAUSED
06-03 21:53:30.254+0900 D/APP_CORE( 2868): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-03 21:53:30.254+0900 D/APP_CORE( 2868): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2868
06-03 21:53:30.254+0900 D/APP_CORE( 2868): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-03 21:53:30.254+0900 D/RESOURCED( 2851): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2868
06-03 21:53:30.794+0900 D/PROCESSMGR( 2772): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x602040 
06-03 21:53:30.944+0900 E/EFL     ( 9117): edje<9117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-03 21:53:30.944+0900 E/EFL     ( 9117): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 21:53:31.344+0900 I/tag     ( 9117): abc
06-03 21:53:31.344+0900 I/tag     ( 9117): delete~~~
06-03 21:53:31.374+0900 W/CRASH_MANAGER( 9326): worker.c: worker_job(1204) > 1109117657861149649441
