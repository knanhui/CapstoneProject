S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 4603
Date: 2017-06-01 12:20:38+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb91d6dc0, esi = 0x8001a8d5
ebp = 0xbff43868, esp = 0xbff43830
eax = 0x00000000, ebx = 0xb72e35f0
ecx = 0x00000393, edx = 0x00000015
eip = 0xb713abbf

Memory Information
MemTotal:      123 KB
MemFree:        33 KB
Buffers:         4 KB
Cached:     164700 KB
VmPeak:     100304 KB
VmSize:     100304 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21868 KB
VmRSS:       21868 KB
VmData:      32752 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34456 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 4603 TID = 4603
4603 4604 4805 4806 

Maps Information
b2b46000 b2b50000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b56000 b2b62000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b63000 b2b84000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b89000 b2b8a000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b8b000 b2b90000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b91000 b2b92000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b93000 b2b95000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b96000 b2ba2000 r-xp /usr/lib/libdrm.so.2.4.0
b2ba3000 b2ba6000 r-xp /usr/lib/libdri2.so.0.0.0
b2ba7000 b2bb1000 r-xp /usr/lib/libtbm.so.1.0.0
b2bb2000 b2bc7000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bc8000 b2bda000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33dc000 b340d000 r-xp /usr/lib/libidn.so.11.5.44
b340e000 b3430000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3431000 b3441000 r-xp /usr/lib/libcares.so.2.1.0
b3442000 b344b000 r-xp /usr/lib/libeventsystem.so.0.0.1
b344c000 b3455000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3456000 b34cd000 r-xp /usr/lib/libcurl.so.4.3.0
b34cf000 b34e1000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34e2000 b3503000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b350a000 b350b000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b350c000 b350d000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b350e000 b3511000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3512000 b3515000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b361d000 b3623000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3624000 b3768000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3778000 b377a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b377b000 b377c000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b377d000 b3787000 r-xp /opt/usr/apps/org.example.example/bin/example
b378a000 b37c3000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c6000 b41d1000 r-xp /lib/libnss_files-2.20-2014.11.so
b41d3000 b41de000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41e0000 b41f7000 r-xp /lib/libnsl-2.20-2014.11.so
b41fb000 b4203000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4205000 b4229000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b422a000 b422b000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b422c000 b422f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4230000 b4237000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4238000 b4242000 r-xp /usr/lib/libsensord-share.so
b4243000 b425f000 r-xp /usr/lib/libsensor.so.1.2.0
b4261000 b426a000 r-xp /usr/lib/libappcore-common.so.1.1
b426d000 b426f000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4284000 b4286000 r-xp /usr/lib/libXau.so.6.0.0
b4287000 b42a9000 r-xp /usr/lib/libxcb.so.1.1.0
b42ab000 b42b4000 r-xp /lib/libcrypt-2.20-2014.11.so
b42dd000 b42df000 r-xp /usr/lib/libiri.so
b42e0000 b4306000 r-xp /lib/libexpat.so.1.5.2
b4308000 b4373000 r-xp /usr/lib/libssl.so.1.0.0
b4379000 b4385000 r-xp /usr/lib/libethumb.so.1.13.0
b4386000 b438a000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b438b000 b45dc000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b57000 b5b67000 r-xp /usr/lib/libXi.so.6.1.0
b5b68000 b5b6a000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b6b000 b5b71000 r-xp /usr/lib/libXtst.so.6.1.0
b5b72000 b5b7c000 r-xp /usr/lib/libXrender.so.1.3.0
b5b7d000 b5b86000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b88000 b5b8a000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b8b000 b5b90000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b91000 b5ba3000 r-xp /usr/lib/libXext.so.6.4.0
b5ba4000 b5ba6000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba7000 b5ba9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bab000 b5ced000 r-xp /usr/lib/libX11.so.6.3.0
b5cf1000 b5cfb000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cfc000 b5d12000 r-xp /usr/lib/libudev.so.1.6.0
b5d15000 b5d19000 r-xp /lib/libattr.so.1.1.0
b5d1a000 b5d49000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d4b000 b5d51000 r-xp /usr/lib/libffi.so.6.0.2
b5d52000 b5d75000 r-xp /lib/libz.so.1.2.8
b5d76000 b5d79000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d7a000 b5ed6000 r-xp /usr/lib/libxml2.so.2.9.2
b5edc000 b5fc3000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fd0000 b5fd3000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fd4000 b5ff6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff7000 b600b000 r-xp /lib/libresolv-2.20-2014.11.so
b600f000 b6033000 r-xp /usr/lib/liblzma.so.5.0.3
b6034000 b6036000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6038000 b6042000 r-xp /usr/lib/libembryo.so.1.13.0
b6043000 b606c000 r-xp /usr/lib/libpng12.so.0.50.0
b606d000 b60b6000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c7000 b60ce000 r-xp /lib/librt-2.20-2014.11.so
b60d0000 b60ef000 r-xp /usr/lib/libector.so.1.13.0
b60f2000 b611f000 r-xp /usr/lib/liblua-5.1.so
b6120000 b61b0000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b4000 b61f2000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61f3000 b6209000 r-xp /usr/lib/libfribidi.so.0.3.1
b620a000 b6263000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6266000 b62b1000 r-xp /lib/libm-2.20-2014.11.so
b62b3000 b62c5000 r-xp /usr/lib/libeio.so.1.13.0
b62c6000 b62c9000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62ca000 b62d0000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62d1000 b62f4000 r-xp /usr/lib/libefreet.so.1.13.0
b62f7000 b6322000 r-xp /usr/lib/libeldbus.so.1.13.0
b6323000 b6357000 r-xp /usr/lib/libecore_con.so.1.13.0
b6359000 b6362000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6363000 b636c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b636d000 b6380000 r-xp /usr/lib/libeo.so.1.13.0
b6382000 b6395000 r-xp /usr/lib/libecore_input.so.1.13.0
b6396000 b639d000 r-xp /usr/lib/libecore_file.so.1.13.0
b639e000 b63c1000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63c2000 b63ee000 r-xp /usr/lib/libeet.so.1.13.0
b63f7000 b6462000 r-xp /usr/lib/libeina.so.1.13.0
b6465000 b647c000 r-xp /usr/lib/libefl.so.1.13.0
b647e000 b65e5000 r-xp /usr/lib/libicuuc.so.51.1
b65f3000 b67ff000 r-xp /usr/lib/libicui18n.so.51.1
b6807000 b6856000 r-xp /usr/lib/libecore_x.so.1.13.0
b6858000 b6872000 r-xp /lib/libgcc_s-4.9.so.1
b6874000 b6878000 r-xp /lib/libcap.so.2.21
b6879000 b68bf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68c0000 b68c7000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68c9000 b691b000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b691d000 b6aa8000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aad000 b6b7b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b7e000 b6b82000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b83000 b6b92000 r-xp /usr/lib/libvconf.so.0.2.45
b6b93000 b6b96000 r-xp /usr/lib/libvasum.so.0.3.1
b6b97000 b6b9a000 r-xp /usr/lib/libttrace.so.1.1
b6b9c000 b6ba0000 r-xp /usr/lib/libiniparser.so.0
b6ba1000 b6bd1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bd2000 b6bdb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bdc000 b6c01000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c02000 b6c12000 r-xp /usr/lib/libunwind.so.8.0.1
b6c1c000 b6dca000 r-xp /lib/libc-2.20-2014.11.so
b6dd2000 b6f15000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f17000 b6f6f000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f70000 b6fa4000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa7000 b707b000 r-xp /usr/lib/libedje.so.1.13.0
b707e000 b70aa000 r-xp /usr/lib/libecore.so.1.13.0
b70bb000 b72e1000 r-xp /usr/lib/libevas.so.1.13.0
b7309000 b7321000 r-xp /lib/libpthread-2.20-2014.11.so
b7325000 b769f000 r-xp /usr/lib/libelementary.so.1.13.0
b76bf000 b76c3000 r-xp /usr/lib/libsmack.so.1.0.0
b76c4000 b76cd000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ce000 b76d1000 r-xp /usr/lib/libdlog.so.0.0.0
b76d2000 b76d7000 r-xp /usr/lib/libbundle.so.0.1.22
b76d8000 b76db000 r-xp /lib/libdl-2.20-2014.11.so
b76dd000 b7702000 r-xp /usr/lib/libaul.so.0.1.0
b7705000 b7707000 r-xp /usr/lib/libappsvc.so.0.1.0
b7708000 b770d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b770e000 b7715000 r-xp /usr/lib/libappcore-efl.so.1.1
b7717000 b771c000 r-xp /usr/lib/libsys-assert.so
b771f000 b7720000 r-xp [vdso]
b7720000 b7742000 r-xp /lib/ld-2.20-2014.11.so
b7744000 b774c000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:4603)
Call Stack Count: 41
 0: (0xb713abbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb712cce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb7127629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb7134fa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb7538d29) [/usr/lib/libelementary.so.1] + 0x213d29
 5: elm_obj_layout_sizing_eval + 0x99 (0xb74d0559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb74d7205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb7145809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb74c979a) [/usr/lib/libelementary.so.1] + 0x1a479a
 9: evas_obj_smart_add + 0x99 (0xb7145809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb753d27b) [/usr/lib/libelementary.so.1] + 0x21827b
11: evas_obj_smart_add + 0x99 (0xb7145809) [/usr/lib/libevas.so.1] + 0x8a809
12: (0xb7148d8b) [/usr/lib/libevas.so.1] + 0x8dd8b
13: eo_constructor + 0x99 (0xb6377899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb75964a6) [/usr/lib/libelementary.so.1] + 0x2714a6
15: eo_constructor + 0x99 (0xb6377899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb74d8c37) [/usr/lib/libelementary.so.1] + 0x1b3c37
17: eo_constructor + 0x99 (0xb6377899) [/usr/lib/libeo.so.1] + 0xa899
18: (0xb74c9879) [/usr/lib/libelementary.so.1] + 0x1a4879
19: eo_constructor + 0x99 (0xb6377899) [/usr/lib/libeo.so.1] + 0xa899
20: (0xb753d7c2) [/usr/lib/libelementary.so.1] + 0x2187c2
21: eo_constructor + 0x99 (0xb6377899) [/usr/lib/libeo.so.1] + 0xa899
22: elm_scroller_add + 0x77 (0xb753bdb7) [/usr/lib/libelementary.so.1] + 0x216db7
23: setting_view_cb + 0x3f (0xb37854ff) [/opt/usr/apps/org.example.example/bin/example] + 0x84ff
24: (0xb70ef449) [/usr/lib/libevas.so.1] + 0x34449
25: (0xb637b319) [/usr/lib/libeo.so.1] + 0xe319
26: eo_event_callback_call + 0xb3 (0xb6378d63) [/usr/lib/libeo.so.1] + 0xbd63
27: (0xb70efa62) [/usr/lib/libevas.so.1] + 0x34a62
28: (0xb70fe441) [/usr/lib/libevas.so.1] + 0x43441
29: evas_canvas_event_feed_mouse_down + 0xcf (0xb710820f) [/usr/lib/libevas.so.1] + 0x4d20f
30: evas_event_feed_mouse_down + 0x6a (0xb710ec2a) [/usr/lib/libevas.so.1] + 0x53c2a
31: (0xb438849c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
32: (0xb708b055) [/usr/lib/libecore.so.1] + 0xd055
33: (0xb70941b9) [/usr/lib/libecore.so.1] + 0x161b9
34: ecore_main_loop_begin + 0x57 (0xb7094587) [/usr/lib/libecore.so.1] + 0x16587
35: elm_run + 0x2d (0xb74ed22d) [/usr/lib/libelementary.so.1] + 0x1c822d
36: appcore_efl_main + 0x4de (0xb7711dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
37: ui_app_main + 0x140 (0xb770ac80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
38: main + 0x2a5 (0xb3784605) [/opt/usr/apps/org.example.example/bin/example] + 0x7605
39: (0xb7746148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7746148
40: __libc_start_main + 0xde (0xb6c33e4e) [/lib/libc.so.6] + 0x17e4e
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
12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Gallery] pos[4, 2] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[8], [4, 2]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[7], [3, 2]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.example.imageutil] Name[imageutil] Icon[/opt/usr/apps/org.example.imageutil/shared/res/imageutil.png] enable[1] system[0]
06-01 12:20:31.442+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.example.imageutil'], count[0]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.example.imageutil][-17956860][0]
06-01 12:20:31.442+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.example.imageutil]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[imageutil] pos[1, 3] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[15]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[9], [1, 3]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.browser] Name[Internet] Icon[/usr/share/icons/default/small/org.tizen.browser.png] enable[1] system[1]
06-01 12:20:31.442+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.browser'], count[0]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.browser][-17956860][0]
06-01 12:20:31.442+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.browser]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Internet] pos[2, 3] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[1]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[10], [2, 3]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.message] Name[Messages] Icon[/usr/share/icons/default/small/org.tizen.message.png] enable[1] system[1]
06-01 12:20:31.442+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.message'], count[1]
06-01 12:20:31.442+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.message]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Messages] pos[3, 3] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[7]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[11], [3, 3]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.music-player] Name[Music] Icon[/usr/share/icons/default/small/org.tizen.music-player.png] enable[1] system[1]
06-01 12:20:31.442+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.music-player'], count[0]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.music-player][-17956860][0]
06-01 12:20:31.442+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.music-player]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Music] pos[4, 3] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[8]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[12], [4, 3]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.myfile] Name[My Files] Icon[/usr/share/icons/default/small/org.tizen.myfile.png] enable[1] system[1]
06-01 12:20:31.442+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.myfile'], count[0]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.myfile][-17956860][0]
06-01 12:20:31.442+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.myfile]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[My Files] pos[1, 4] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[9]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[13], [1, 4]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.phone] Name[Phone] Icon[/usr/share/icons/default/small/org.tizen.phone.png] enable[1] system[1]
06-01 12:20:31.442+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.phone'], count[0]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.phone][-17956860][0]
06-01 12:20:31.442+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.phone]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Phone] pos[2, 4] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[10]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[14], [2, 4]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.setting] Name[Settings] Icon[/usr/share/icons/default/small/org.tizen.setting.png] enable[1] system[1]
06-01 12:20:31.442+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.setting'], count[0]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.setting][-17956860][0]
06-01 12:20:31.442+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.setting]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Settings] pos[3, 4] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[11]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[15], [3, 4]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-package-manager.cpp: GetAppInfo(523) >  Find a App Info AppId[org.tizen.videos] Name[Video] Icon[/usr/share/icons/default/small/org.tizen.videos.png] enable[1] system[1]
06-01 12:20:31.442+0900 D/BADGE   ( 2945): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.videos'], count[0]
06-01 12:20:31.442+0900 E/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(618) >  Failed to get badge count [org.tizen.videos][-17956860][0]
06-01 12:20:31.442+0900 D/cluster-home( 2945): mainmenu-presenter.cpp: _ReorderAppsItems(622) >  pageId[100001] appId[org.tizen.videos]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(768) >  MoveBox Name[Video] pos[4, 4] pageId[100001]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(976) >  Find box pageid[100001], boxid[12]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(980) >  nBoxOrder[16], [4, 4]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-page-impl.cpp: MoveMenuBox(1001) >  nOriBoxOrder[25], [5, 6]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: MoveMenuBox(777) >  [1]th page, updated[1]
06-01 12:20:31.442+0900 D/cluster-view( 2945): mainmenu-apps-view-impl.cpp: RearrangeItems(243) >  view type [1]
06-01 12:20:31.552+0900 D/rpm-installer( 4746): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
06-01 12:20:31.552+0900 D/rpm-installer( 4746): rpm-appcore-intf.c: main(259) > ------------------------------------------------
06-01 12:20:31.552+0900 D/rpm-installer( 4746): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
06-01 12:20:31.552+0900 D/rpm-installer( 4746): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-01 12:20:31.552+0900 D/PKGMGR_SERVER( 4732): pkgmgr-server.c: sighandler(387) > child exit [4746]
06-01 12:20:31.552+0900 E/PKGMGR_SERVER( 4732): pkgmgr-server.c: sighandler(402) > child NORMAL exit [4746]
06-01 12:20:31.992+0900 E/PKGMGR_SERVER( 4732): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-01 12:20:31.992+0900 E/PKGMGR_SERVER( 4732): pkgmgr-server.c: main(2265) > package manager server terminated.
06-01 12:20:32.722+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 12:20:32.722+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 12:20:32.722+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 12:20:32.722+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-01 12:20:32.732+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-01 12:20:32.732+0900 D/AUL     ( 2858): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 4799, pid = 4801
06-01 12:20:32.732+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 12:20:32.732+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-01 12:20:32.732+0900 I/AUL     ( 2858): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-01 12:20:32.732+0900 E/AUL_AMD ( 2858): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-01 12:20:32.732+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 4801
06-01 12:20:32.732+0900 E/AUL_AMD ( 2858): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-01 12:20:32.732+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 12:20:32.732+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 12:20:32.732+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 12:20:32.732+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 12:20:32.732+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 12:20:32.732+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 12:20:32.732+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 12:20:32.732+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 12:20:32.732+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 12:20:32.732+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 4603, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 12:20:32.732+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 12:20:32.732+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 12:20:32.732+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 12:20:32.732+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-01 12:20:32.732+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 12:20:32.732+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 12:20:32.732+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 12:20:32.732+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 12:20:32.732+0900 D/AUL     ( 4603): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (4604) is sent.
06-01 12:20:32.732+0900 D/AUL     ( 4603): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 4604, signo: 10
06-01 12:20:32.732+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 12:20:32.732+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 12:20:32.732+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 12:20:32.742+0900 D/AUL     ( 4603): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyODcyMzIvNzM2MTQ2AA==##
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA0ODAxAA==##
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 12:20:32.742+0900 D/AUL_PAD ( 4603): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 12:20:32.742+0900 I/CAPI_APPFW_APPLICATION( 4603): app_main.c: ui_app_main(788) > app_efl_main
06-01 12:20:32.742+0900 D/LAUNCH  ( 4603): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 12:20:32.742+0900 D/APP_CORE( 4603): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 12:20:32.742+0900 D/APP_CORE( 4603): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 12:20:32.742+0900 D/APP_CORE( 4603): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 12:20:32.752+0900 D/APP_CORE( 4603): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 12:20:32.752+0900 D/AUL     ( 4603): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 12:20:32.752+0900 D/APP_CORE( 4603): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb426a520
06-01 12:20:32.752+0900 D/LAUNCH  ( 4603): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 12:20:32.752+0900 I/CAPI_APPFW_APPLICATION( 4603): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 12:20:32.842+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 12:20:32.842+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 4603, appid: org.example.example
06-01 12:20:32.842+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 12:20:32.842+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 12:20:32.842+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 12:20:32.842+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 12:20:32.842+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(4603) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 12:20:32.842+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 4603
06-01 12:20:32.842+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 12:20:32.842+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 12:20:32.842+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 322
06-01 12:20:32.852+0900 D/LAUNCH  ( 4603): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 12:20:32.862+0900 E/E17     ( 2741): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02800002)
06-01 12:20:32.862+0900 D/APP_CORE( 4603): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 12:20:32.902+0900 E/E17     ( 2741): e_border.c: e_border_show(2088) > BD_SHOW(0x02800002)
06-01 12:20:32.922+0900 D/APP_CORE( 4603): appcore.c: __aul_handler(587) > [APP 4603]     AUL event: AUL_START
06-01 12:20:32.922+0900 I/APP_CORE( 4603): appcore-efl.c: __do_app(496) > [APP 4603] Event: RESET State: CREATED
06-01 12:20:32.922+0900 D/APP_CORE( 4603): appcore-efl.c: __do_app(527) > [APP 4603] RESET
06-01 12:20:32.922+0900 D/LAUNCH  ( 4603): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 12:20:32.922+0900 D/APP_CORE( 4603): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 12:20:32.922+0900 D/APP_CORE( 4603): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:20:32.922+0900 I/CAPI_APPFW_APPLICATION( 4603): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 12:20:32.922+0900 D/AUL     ( 4603): service.c: __set_bundle(186) > __set_bundle
06-01 12:20:32.922+0900 D/LAUNCH  ( 4603): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 12:20:32.922+0900 D/APP_CORE( 4603): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 12:20:32.922+0900 E/EFL     ( 4603): edje<4603> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:20:32.922+0900 E/EFL     ( 4603): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:20:32.922+0900 E/EFL     ( 4603): edje<4603> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:20:32.922+0900 E/EFL     ( 4603): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:20:32.922+0900 E/EFL     ( 4603): edje<4603> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:20:32.922+0900 E/EFL     ( 4603): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:20:32.922+0900 E/EFL     ( 4603): edje<4603> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:20:32.922+0900 E/EFL     ( 4603): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:20:32.922+0900 E/EFL     ( 4603): edje<4603> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:20:32.922+0900 E/EFL     ( 4603): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:20:32.942+0900 W/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4603
06-01 12:20:32.952+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:20:32.952+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:20:32.972+0900 W/APP_CORE( 4603): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
06-01 12:20:32.972+0900 D/APP_CORE( 4603): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2800002
06-01 12:20:32.972+0900 D/APP_CORE( 4603): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 12:20:32.972+0900 D/AUL     ( 4603): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 12:20:32.972+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 12:20:32.972+0900 D/INDICATOR( 2934): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 12:20:32.972+0900 D/INDICATOR( 2934): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 12:20:32.972+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 12:20:32.972+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:20:32.972+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:20:32.972+0900 D/INDICATOR( 2934): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 12:20:32.972+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 12:20:32.972+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 12:20:32.972+0900 D/INDICATOR( 2934): main.c: _rotate_window(252) > port :: hide more icon
06-01 12:20:32.972+0900 D/AUL_AMD ( 2858): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 4603 is org.example.example
06-01 12:20:32.972+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 4603 : 0
06-01 12:20:32.972+0900 D/AUL     ( 3022): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 12:20:33.272+0900 D/APP_CORE( 4603): appcore.c: __prt_ltime(236) > [APP 4603] first idle after reset: 549 msec
06-01 12:20:33.362+0900 E/E17     ( 2741): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 12:20:33.362+0900 D/APP_CORE( 4603): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2800002 fully_obscured 0
06-01 12:20:33.362+0900 D/APP_CORE( 4603): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 12:20:33.362+0900 D/APP_CORE( 4603): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 12:20:33.362+0900 I/APP_CORE( 4603): appcore-efl.c: __do_app(496) > [APP 4603] Event: RESUME State: CREATED
06-01 12:20:33.362+0900 D/LAUNCH  ( 4603): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 12:20:33.362+0900 D/APP_CORE( 4603): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 12:20:33.362+0900 D/APP_CORE( 4603): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:20:33.362+0900 D/APP_CORE( 4603): appcore-efl.c: __do_app(607) > [APP 4603] RESUME
06-01 12:20:33.362+0900 I/APP_CORE( 4603): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 12:20:33.362+0900 I/APP_CORE( 4603): appcore-efl.c: __do_app(614) > [APP 4603] Initial Launching, call the resume_cb
06-01 12:20:33.362+0900 I/CAPI_APPFW_APPLICATION( 4603): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 12:20:33.362+0900 D/LAUNCH  ( 4603): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 12:20:33.362+0900 D/LAUNCH  ( 4603): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 12:20:33.362+0900 D/APP_CORE( 4603): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:20:33.362+0900 E/APP_CORE( 4603): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:20:33.362+0900 D/APP_CORE( 2945): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 12:20:33.362+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 12:20:33.362+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 12:20:33.362+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: PAUSE State: RUNNING
06-01 12:20:33.362+0900 D/APP_CORE( 2945): appcore-efl.c: __do_app(565) > [APP 2945] PAUSE
06-01 12:20:33.362+0900 I/CAPI_APPFW_APPLICATION( 2945): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 12:20:33.362+0900 E/cluster-home( 2945): homescreen.cpp: OnPause(84) >  app pause
06-01 12:20:33.372+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 12:20:33.372+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 12:20:33.372+0900 D/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:20:33.372+0900 E/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:20:33.382+0900 D/DATA_PROVIDER_MASTER( 3009): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2945 is paused
06-01 12:20:33.382+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 12:20:33.382+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(4)
06-01 12:20:33.382+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 12:20:33.382+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 12:20:33.382+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: bg
06-01 12:20:33.382+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 12:20:33.382+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 12:20:33.382+0900 W/AUL     ( 3084): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3084, appid: org.tizen.calendar.widget, status: bg
06-01 12:20:33.392+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(4603) status(3)
06-01 12:20:33.392+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3084, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 12:20:33.392+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3084
06-01 12:20:33.392+0900 D/RESOURCED( 2893): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3084, appname = org.tizen.calendar.widget
06-01 12:20:33.392+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3084
06-01 12:20:33.392+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 12:20:33.392+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 12:20:33.392+0900 W/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 12:20:33.392+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(4603) status(3)
06-01 12:20:33.392+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(4603) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 12:20:33.392+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 12:20:33.392+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 4603, appid: org.example.example, status: fg
06-01 12:20:33.392+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 4603
06-01 12:20:33.392+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 4603, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 12:20:33.392+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 4603
06-01 12:20:33.462+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 4603, appname = org.example.example, pkgname = org.example.example
06-01 12:20:33.462+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 4603, appname = org.example.example
06-01 12:20:33.462+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4603
06-01 12:20:33.462+0900 I/RESOURCED( 2893): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 12:20:33.462+0900 I/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 12:20:33.502+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2910) > pid(4603) status(0)
06-01 12:20:33.852+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 12:20:33.852+0900 D/AUL_PAD ( 4808): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 12:20:33.862+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 12:20:34.352+0900 D/AUL_AMD ( 2858): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 12:20:34.352+0900 D/RUA     ( 2858): rua.c: rua_add_history(179) > rua_add_history start
06-01 12:20:34.362+0900 D/RUA     ( 2858): rua.c: rua_add_history(247) > rua_add_history ok
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): launchpad_loader.c: main(588) > sleeping 1 sec...
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8988760
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preload.h: __preload_init(69) > get pre-initialization function
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preload.h: __preload_init(73) > get shutdown function
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8988a40
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b898a640
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preload.h: __preload_init(69) > get pre-initialization function
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preload.h: __preload_init(73) > get shutdown function
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): preexec.h: __preexec_init(76) > preexec start
06-01 12:20:34.902+0900 D/AUL_PAD ( 4808): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-01 12:20:34.902+0900 D/AUL     ( 4808): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-01 12:20:34.902+0900 D/AUL     ( 4808): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-01 12:20:34.902+0900 D/AUL     ( 4808): process_pool.c: __connect_to_launchpad(132) > send(4808) : 4
06-01 12:20:34.902+0900 D/AUL     ( 4808): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-01 12:20:34.902+0900 D/AUL_PAD ( 3003): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 4808
06-01 12:20:35.102+0900 D/AUL_PAD ( 4808): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-01 12:20:35.112+0900 D/AUL_PAD ( 4808): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-01 12:20:35.112+0900 D/AUL_PAD ( 4808): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-01 12:20:35.112+0900 D/AUL_PAD ( 4808): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-01 12:20:38.382+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-01 12:20:38.382+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: MEM_FLUSH State: PAUSED
06-01 12:20:38.382+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-01 12:20:38.382+0900 D/APP_CORE( 2945): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2945
06-01 12:20:38.382+0900 D/APP_CORE( 2945): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-01 12:20:38.412+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2945
06-01 12:20:38.642+0900 E/EFL     ( 4603): eo<4603> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_common_interface.eo.c:1: func 'evas_common_evas_get' (62) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 12:20:38.642+0900 E/EFL     ( 4603): eo<4603> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_object.eo.c:74: func 'evas_obj_type_get' (128) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 12:20:38.642+0900 E/EFL     ( 4603): elementary<4603> elm_widget.c:1101 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8000b85d (null)). Elementary widget's parent should be an elementary widget.
06-01 12:20:38.642+0900 E/EFL     ( 4603): <4603> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
06-01 12:20:38.692+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-01 12:20:38.692+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 12:20:38.692+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 12:20:38.692+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 12:20:38.692+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 12:20:38.692+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 12:20:38.692+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 12:20:38.692+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 4603 pgid = 4603
06-01 12:20:38.692+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(142) > dead_pid(4603)
06-01 12:20:38.692+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:20:38.702+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-01 12:20:38.702+0900 I/AUL_PAD ( 3003): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-01 12:20:38.702+0900 I/AUL_PAD ( 3003): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-01 12:20:38.702+0900 E/AUL_PAD ( 3003): launchpad.c: main(688) > error reading sigchld info
06-01 12:20:38.702+0900 I/ESD     ( 3017): esd_main.c: __esd_app_dead_handler(1771) > pid: 4603
06-01 12:20:38.702+0900 D/STARTER ( 2935): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 4603 is termianted
06-01 12:20:38.702+0900 D/STARTER ( 2935): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-01 12:20:38.712+0900 W/AUL_AMD ( 2858): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 4603
06-01 12:20:38.712+0900 W/AUL_AMD ( 2858): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 4603
06-01 12:20:38.712+0900 D/AUL_AMD ( 2858): amd_key.c: _unregister_key_event(179) > ===key stack===
06-01 12:20:38.712+0900 E/AUL_AMD ( 2858): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-01 12:20:38.712+0900 D/AUL_AMD ( 2858): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
06-01 12:20:38.712+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 12:20:38.712+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 12:20:38.712+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.290
06-01 12:20:38.712+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(2945) status(3)
06-01 12:20:38.712+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 12:20:38.712+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 4603
06-01 12:20:38.712+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
06-01 12:20:38.712+0900 W/AUL_AMD ( 2858): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-01 12:20:38.712+0900 W/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-01 12:20:38.712+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(3)
06-01 12:20:38.712+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-01 12:20:38.712+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-01 12:20:38.712+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: fg
06-01 12:20:38.722+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2945
06-01 12:20:38.722+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2945, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-01 12:20:38.722+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2945, appname = org.tizen.homescreen
06-01 12:20:38.722+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2945
06-01 12:20:38.732+0900 E/E17     ( 2741): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
06-01 12:20:38.732+0900 W/CRASH_MANAGER( 4810): worker.c: worker_job(1204) > 1104603657861149628723
