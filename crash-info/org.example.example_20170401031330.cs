S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 10258
Date: 2017-04-01 03:13:30+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8150e20, esi = 0x8000ba5e
ebp = 0xbfe411a8, esp = 0xbfe41170
eax = 0x00000000, ebx = 0xb73745f0
ecx = 0x0000005e, edx = 0x00000015
eip = 0xb71cbbbf

Memory Information
MemTotal:      123 KB
MemFree:        25 KB
Buffers:         8 KB
Cached:     173916 KB
VmPeak:      79188 KB
VmSize:      79188 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       14012 KB
VmRSS:       14012 KB
VmData:      19544 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33316 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10258 TID = 10258
10258 10286 10293 

Maps Information
b2cfc000 b2d06000 r-xp /usr/lib/libfeedback.so.0.1.4
b2d0c000 b2d18000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2d19000 b2d3a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d3f000 b2d40000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d41000 b2d46000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d47000 b2d48000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d49000 b2d4b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d4c000 b2d4e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d4f000 b2d5b000 r-xp /usr/lib/libdrm.so.2.4.0
b2d5c000 b2d5f000 r-xp /usr/lib/libdri2.so.0.0.0
b2d60000 b2d6a000 r-xp /usr/lib/libtbm.so.1.0.0
b2d71000 b2d72000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d73000 b2d74000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d75000 b2d78000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d79000 b2d7c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d7d000 b2d92000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d93000 b2da5000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b36ae000 b36b4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36b5000 b37f9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3809000 b380a000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b380b000 b3814000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3815000 b3818000 r-xp /opt/usr/apps/org.example.example/bin/example
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

Callstack Information (PID:10258)
Call Stack Count: 27
 0: (0xb71cbbbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb71bdce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb71b8629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb71c5fa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb755e7df) [/usr/lib/libelementary.so.1] + 0x1a87df
 5: elm_obj_layout_sizing_eval + 0x99 (0xb7561559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb7568205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb71d6809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb755f24b) [/usr/lib/libelementary.so.1] + 0x1a924b
 9: evas_obj_smart_add + 0x99 (0xb71d6809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb71d9d8b) [/usr/lib/libevas.so.1] + 0x8dd8b
11: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
12: (0xb76274a6) [/usr/lib/libelementary.so.1] + 0x2714a6
13: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb7569c37) [/usr/lib/libelementary.so.1] + 0x1b3c37
15: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb755f692) [/usr/lib/libelementary.so.1] + 0x1a9692
17: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
18: elm_label_add + 0x77 (0xb755dcf7) [/usr/lib/libelementary.so.1] + 0x1a7cf7
19: create_base_gui + 0x49e (0xb381706e) [/opt/usr/apps/org.example.example/bin/example] + 0x206e
20: app_create + 0x2c (0xb3816a3c) [/opt/usr/apps/org.example.example/bin/example] + 0x1a3c
21: (0xb779b65b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
22: appcore_efl_main + 0x327 (0xb77a2c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
23: ui_app_main + 0x140 (0xb779bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
24: main + 0x27e (0xb38169ae) [/opt/usr/apps/org.example.example/bin/example] + 0x19ae
25: create_base_gui + 0x578 (0xb77d7148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77d7148
26: __libc_start_main + 0xde (0xb6cc4e4e) [/lib/libc.so.6] + 0x17e4e
End of Call Stack

Package Information
Package Name: org.example.example
Package ID : org.example.example
Version: 1.0.0
Package Type: tpk
App Name: example
App ID: org.example.example
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
d(1370) > http://tizen.org/feature/network.wifi feature is disabled
04-01 03:13:25.558+0900 E/INDICATOR( 2896): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001fafe)
04-01 03:13:25.558+0900 E/INDICATOR( 2896): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
04-01 03:13:25.558+0900 E/INDICATOR( 2896): 
04-01 03:13:25.618+0900 W/STARTER ( 2890): hw_key.c: _home_multi_press_timer_cb(138) > [_home_multi_press_timer_cb:138] homekey count[1]
04-01 03:13:25.618+0900 D/STARTER ( 2890): process_mgr.c: process_mgr_must_launch(114) > [process_mgr_must_launch:114] Must launch org.tizen.homescreen
04-01 03:13:25.618+0900 D/AUL     ( 2890): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.tizen.homescreen
04-01 03:13:25.618+0900 D/AUL     ( 2890): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
04-01 03:13:25.618+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
04-01 03:13:25.618+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.tizen.homescreen
04-01 03:13:25.618+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
04-01 03:13:25.618+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
04-01 03:13:25.618+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/starter, ret : 0
04-01 03:13:25.618+0900 D/AUL     ( 2763): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 2890, pid = 2890
04-01 03:13:25.618+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
04-01 03:13:25.618+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
04-01 03:13:25.618+0900 I/AUL     ( 2763): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/starter, ret : 0
04-01 03:13:25.618+0900 E/AUL_AMD ( 2763): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-01 03:13:25.618+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 2890
04-01 03:13:25.618+0900 E/AUL_AMD ( 2763): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-01 03:13:25.618+0900 D/RESOURCED( 2892): proc-noti.c: process_message(173) > process message caller pid 2763
04-01 03:13:25.618+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_action(1043) > [SECURE_LOG] appid org.tizen.homescreen, pid 2906, status 5
04-01 03:13:25.618+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(914) > [SECURE_LOG] resume request 2906
04-01 03:13:25.618+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(934) > available memory = 293
04-01 03:13:25.618+0900 D/AUL_AMD ( 2763): amd_launch.c: __nofork_processing(1249) > org.tizen.system.deviced.PmQos-AppLaunch : 0
04-01 03:13:25.618+0900 W/AUL_AMD ( 2763): amd_launch.c: __nofork_processing(1252) > __nofork_processing, cmd: 0, pid: 2906
04-01 03:13:25.618+0900 D/AUL_AMD ( 2763): amd_launch.c: __nofork_processing(1268) > fake launch pid : 2906
04-01 03:13:25.618+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(2906) : cmd(0)
04-01 03:13:25.618+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
04-01 03:13:25.618+0900 D/AUL_AMD ( 2763): amd_launch.c: __nofork_processing(1271) > fake launch done
04-01 03:13:25.618+0900 D/APP_CORE( 2906): appcore.c: __aul_handler(587) > [APP 2906]     AUL event: AUL_START
04-01 03:13:25.618+0900 I/APP_CORE( 2906): appcore-efl.c: __do_app(496) > [APP 2906] Event: RESET State: PAUSED
04-01 03:13:25.618+0900 D/APP_CORE( 2906): appcore-efl.c: __do_app(527) > [APP 2906] RESET
04-01 03:13:25.618+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(529) > [homescreen:Application:reset:start]
04-01 03:13:25.618+0900 D/APP_CORE( 2906): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
04-01 03:13:25.618+0900 D/APP_CORE( 2906): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-01 03:13:25.618+0900 I/CAPI_APPFW_APPLICATION( 2906): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
04-01 03:13:25.618+0900 E/cluster-home( 2906): homescreen.cpp: OnAppsControl(129) >  app control
04-01 03:13:25.618+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: HomekeyOperation(929) >  block [0]
04-01 03:13:25.618+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(544) > [homescreen:Application:reset:done]
04-01 03:13:25.618+0900 W/AUL_AMD ( 2763): amd_request.c: __send_home_launch_signal(517) > send a home launch signal
04-01 03:13:25.618+0900 I/APP_CORE( 2906): appcore-efl.c: __do_app(548) > Legacy lifecycle: 1
04-01 03:13:25.618+0900 D/APP_CORE( 2906): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
04-01 03:13:25.618+0900 D/APP_CORE( 2906): appcore.c: __prt_ltime(236) > [APP 2906] first idle after reset: 17601201 msec
04-01 03:13:25.618+0900 W/AUL_AMD ( 2763): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(2906), cmd(0)
04-01 03:13:25.618+0900 D/AUL     ( 2890): launch.c: app_request_to_launchpad(425) > launch request result : 2906
04-01 03:13:25.618+0900 D/STARTER ( 2890): process_mgr.c: _try_to_launch(62) > [_try_to_launch:62] Succeed to launch org.tizen.homescreen
04-01 03:13:25.628+0900 E/E17     ( 2799): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
04-01 03:13:25.628+0900 D/APP_CORE( 2906): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 0
04-01 03:13:25.628+0900 D/APP_CORE( 2906): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
04-01 03:13:25.628+0900 D/APP_CORE( 2906): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
04-01 03:13:25.628+0900 I/APP_CORE( 2906): appcore-efl.c: __do_app(496) > [APP 2906] Event: RESUME State: PAUSED
04-01 03:13:25.628+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
04-01 03:13:25.628+0900 D/APP_CORE( 2906): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
04-01 03:13:25.628+0900 D/APP_CORE( 2906): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-01 03:13:25.628+0900 D/APP_CORE( 2906): appcore-efl.c: __do_app(607) > [APP 2906] RESUME
04-01 03:13:25.628+0900 I/CAPI_APPFW_APPLICATION( 2906): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
04-01 03:13:25.628+0900 E/cluster-home( 2906): homescreen.cpp: OnResume(66) >  app resume
04-01 03:13:25.628+0900 D/cluster-home( 2906): widget-data-provider.cpp: SetBoxVisibility(1543) >  
04-01 03:13:25.628+0900 D/cluster-home( 2906): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
04-01 03:13:25.628+0900 D/WIDGET_VIEWER( 2906): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.tizen.calendar.widget] visibility is changed 0x[0]
04-01 03:13:25.628+0900 D/cluster-home( 2906): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
04-01 03:13:25.628+0900 D/cluster-home( 2906): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
04-01 03:13:25.628+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
04-01 03:13:25.628+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _MoveHomeScreenView(869) >  Go Home View
04-01 03:13:25.628+0900 E/E17     ( 2799): e_border.c: e_border_hide(2248) > BD_HIDE(0x02a00002), visible:1
04-01 03:13:25.628+0900 E/EFL     ( 2799): eo<2799> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-01 03:13:25.628+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollStart(128) >  scrollPos[-0, 1280] 
04-01 03:13:25.628+0900 D/test-log( 2906): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[0] [void ClusterHome3D::Internal::CMainMenuAppsView::OnMainScrollStart():2115]
04-01 03:13:25.628+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
04-01 03:13:25.628+0900 D/test-log( 2906): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[0] [void ClusterHome3D::Internal::CMainMenuAppsView::SetViewTouchSensitive(bool):2245]
04-01 03:13:25.628+0900 D/cluster-view( 2906): cluster-impl.cpp: SetScrollSensitive(442) >  Scroll touch disabled
04-01 03:13:25.628+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnMainScrollStart(6736) >  BEGIN
04-01 03:13:25.628+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
04-01 03:13:25.628+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.628+0900 D/test-log( 2906): cluster-impl.cpp: ScrollTo(460) >  scroll to page 0
04-01 03:13:25.628+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnCustomScrollStart(5043) >  ##################### scroll start ########################### 
04-01 03:13:25.628+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
04-01 03:13:25.628+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.628+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.628+0900 D/APP_CORE( 6333): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2a00002 fully_obscured 1
04-01 03:13:25.628+0900 D/APP_CORE( 6333): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
04-01 03:13:25.628+0900 D/APP_CORE( 6333): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
04-01 03:13:25.628+0900 I/APP_CORE( 6333): appcore-efl.c: __do_app(496) > [APP 6333] Event: PAUSE State: RUNNING
04-01 03:13:25.628+0900 D/APP_CORE( 6333): appcore-efl.c: __do_app(565) > [APP 6333] PAUSE
04-01 03:13:25.628+0900 I/CAPI_APPFW_APPLICATION( 6333): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
04-01 03:13:25.628+0900 D/APP_CORE( 6333): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
04-01 03:13:25.628+0900 E/APP_CORE( 6333): appcore-efl.c: __trm_app_info_send_socket(242) > access
04-01 03:13:25.628+0900 D/STARTER ( 2890): dbus_util.c: dbus_util_send_oomadj(285) > [dbus_util_send_oomadj:285] org.tizen.system.deviced.Process-oomadj_set : 0
04-01 03:13:25.628+0900 D/STARTER ( 2890): dbus_util.c: _dbus_message_send(229) > [_dbus_message_send:229] dbus_connection_send, ret=1
04-01 03:13:25.628+0900 E/STARTER ( 2890): dbus_util.c: dbus_util_send_home_raise_signal(243) > [dbus_util_send_home_raise_signal:243] Sending HOME RAISE signal, result:0
04-01 03:13:25.628+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: AppResume(910) >  END
04-01 03:13:25.628+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
04-01 03:13:25.628+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
04-01 03:13:25.628+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
04-01 03:13:25.628+0900 D/cluster-view( 2906): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
04-01 03:13:25.628+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
04-01 03:13:25.628+0900 D/LAUNCH  ( 2906): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
04-01 03:13:25.628+0900 D/APP_CORE( 2906): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
04-01 03:13:25.628+0900 E/APP_CORE( 2906): appcore-efl.c: __trm_app_info_send_socket(242) > access
04-01 03:13:25.628+0900 D/test-log( 2906): custom-cluster-impl.cpp: HomeViewPageOpacityConstraint(141) >  position.y: 0.00, size.y: 1280.00, posY: 1118.67
04-01 03:13:25.668+0900 W/PROCESSMGR( 2799): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2906
04-01 03:13:25.668+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 1131] 
04-01 03:13:25.668+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 1131] 
04-01 03:13:25.668+0900 D/DATA_PROVIDER_MASTER( 2960): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
04-01 03:13:25.668+0900 E/EFL     ( 2799): eo<2799> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2891) > pid(2906) status(3)
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
04-01 03:13:25.668+0900 W/AUL_AMD ( 2763): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-01 03:13:25.668+0900 W/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(2906) status(3)
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(2906) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
04-01 03:13:25.668+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
04-01 03:13:25.668+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2906, appid: org.tizen.homescreen, status: fg
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(6333) status(4)
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(6333) appid(org.example.imageutil) pkgid(org.example.imageutil) status(4)
04-01 03:13:25.668+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.imageutil
04-01 03:13:25.668+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6333, appid: org.example.imageutil, status: bg
04-01 03:13:25.668+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2906
04-01 03:13:25.668+0900 D/INDICATOR( 2896): main.c: _property_changed_cb(432) > UNSNIFF API 2a00002
04-01 03:13:25.668+0900 D/RESOURCED( 2892): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2906, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
04-01 03:13:25.668+0900 D/RESOURCED( 2892): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2906, appname = org.tizen.homescreen
04-01 03:13:25.668+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2906
04-01 03:13:25.668+0900 D/INDICATOR( 2896): util.c: util_signal_emit_by_win(116) > emission bg.translucent
04-01 03:13:25.668+0900 D/INDICATOR( 2896): main.c: _rotate_window(229) > Indicator angle is 0 degree
04-01 03:13:25.668+0900 D/INDICATOR( 2896): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
04-01 03:13:25.668+0900 D/INDICATOR( 2896): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
04-01 03:13:25.668+0900 D/INDICATOR( 2896): main.c: _rotate_window(252) > port :: hide more icon
04-01 03:13:25.668+0900 I/TIZEN_N_SOUND_MANAGER( 2976): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
04-01 03:13:25.668+0900 E/TIZEN_N_SOUND_MANAGER( 2976): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 03:13:25.668+0900 I/TIZEN_N_SOUND_MANAGER( 2976): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
04-01 03:13:25.668+0900 E/TIZEN_N_SOUND_MANAGER( 2976): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
04-01 03:13:25.668+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
04-01 03:13:25.668+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2906 is org.tizen.homescreen
04-01 03:13:25.668+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2906 : 0
04-01 03:13:25.668+0900 D/AUL     ( 2976): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
04-01 03:13:25.668+0900 D/RESOURCED( 2892): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 6333, appname = org.example.imageutil, pkgname = org.example.imageutil
04-01 03:13:25.668+0900 D/RESOURCED( 2892): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 6333, appname = org.example.imageutil
04-01 03:13:25.668+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 6333
04-01 03:13:25.668+0900 D/RESOURCED( 2892): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2904 increase lru 15
04-01 03:13:25.668+0900 D/RESOURCED( 2892): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2904 set score 930 (before 900)
04-01 03:13:25.668+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6333, proc_name: org.example.imageutil, cg_name: previous, oom_score_adj: 300
04-01 03:13:25.668+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 6333
04-01 03:13:25.678+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 576] 
04-01 03:13:25.678+0900 D/DATA_PROVIDER_MASTER( 2960): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2906 is resumed
04-01 03:13:25.678+0900 D/DATA_PROVIDER_MASTER( 2960): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
04-01 03:13:25.678+0900 E/DATA_PROVIDER_MASTER( 2960): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
04-01 03:13:25.678+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
04-01 03:13:25.678+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
04-01 03:13:25.678+0900 W/AUL     ( 2963): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2963, appid: org.tizen.calendar.widget, status: fg
04-01 03:13:25.678+0900 D/RESOURCED( 2892): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2963
04-01 03:13:25.678+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2963, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
04-01 03:13:25.678+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 2963
04-01 03:13:25.708+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 213] 
04-01 03:13:25.738+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 51] 
04-01 03:13:25.758+0900 D/RESOURCED( 2892): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2963, appname = org.tizen.calendar.widget
04-01 03:13:25.758+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2963
04-01 03:13:25.758+0900 I/RESOURCED( 2892): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
04-01 03:13:25.758+0900 I/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
04-01 03:13:25.778+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 2] 
04-01 03:13:25.818+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 0] 
04-01 03:13:25.818+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollComplete(180) >  scrollPos[-0, 0] 
04-01 03:13:25.818+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollComplete(197) >  HOME_SCREEN_VIEW layout
04-01 03:13:25.818+0900 D/test-log( 2906): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[0] [void ClusterHome3D::Internal::CMainMenuAppsView::SetViewTouchSensitive(bool):2245]
04-01 03:13:25.818+0900 D/cluster-view( 2906): cluster-impl.cpp: SetScrollSensitive(435) >  Scroll touch enabled
04-01 03:13:25.818+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _ShowIndicator(830) >  SHOW INDICATOR 1
04-01 03:13:25.818+0900 D/cluster-view( 2906): mainmenu-apps-view-impl.cpp: OnMainScrollComplete(2154) >  self is OnState
04-01 03:13:25.818+0900 D/test-log( 2906): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[1] [void ClusterHome3D::Internal::CMainMenuAppsView::OnMainScrollComplete():2155]
04-01 03:13:25.818+0900 W/test-log( 2906): mainmenu-page-impl.cpp: SetPageEditMode(451) >  editState:[1]
04-01 03:13:25.818+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.818+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.818+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.818+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.818+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.818+0900 D/cluster-home( 2906): custom-cluster-impl.cpp: AllPageModeFinished(2750) >  BEGIN
04-01 03:13:25.818+0900 D/cluster-view( 2906): cluster-view-controller.cpp: OnCustomClusterSwichAllPageModeFinished(2055) >  Cluster[0:] all page mode switched 0
04-01 03:13:25.818+0900 D/cluster-view( 2906): cluster-home-accessibility.cpp: SetCurrentGroup(62) >  Focus Group changed [12]->[1] Block[0]
04-01 03:13:25.818+0900 D/cluster-view( 2906): cluster-view-controller.cpp: UpdateScreenReader(854) >  [TTS] For Home update type[1], group[1]
04-01 03:13:25.818+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
04-01 03:13:25.818+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
04-01 03:13:25.818+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
04-01 03:13:25.818+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
04-01 03:13:25.818+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.818+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnUpdateScreenReader(5538) >  Set FocusOrder[1]
04-01 03:13:25.818+0900 D/cluster-view( 2906): custom-box-impl.cpp: UpdateScreenReader(1388) >  [TTS] CustomBox[1], focus order[2100], badge[0]
04-01 03:13:25.818+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.818+0900 D/cluster-view( 2906): cluster-impl.cpp: SetPageNavigator(283) >  BEGIN
04-01 03:13:25.818+0900 D/cluster-home( 2906): widget-data-provider.cpp: OnFocusedViewChanged(2973) >  changed view type[0]
04-01 03:13:25.818+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnScreenViewTypeChanged(1604) >  Do not need to update tts
04-01 03:13:25.908+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
04-01 03:13:25.908+0900 D/cluster-view( 2906): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
04-01 03:13:25.908+0900 D/cluster-view( 2906): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
04-01 03:13:25.908+0900 D/test-log( 2906): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
04-01 03:13:25.908+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:25.908+0900 D/cluster-view( 2906): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
04-01 03:13:25.908+0900 D/cluster-home( 2906): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
04-01 03:13:25.978+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2910) > pid(2906) status(0)
04-01 03:13:26.828+0900 D/cluster-home( 2906): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
04-01 03:13:26.828+0900 D/WIDGET_VIEWER( 2906): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
04-01 03:13:27.138+0900 D/AUL_AMD ( 2763): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.tizen.homescreen /usr/apps/org.tizen.homescreen/bin/homescreen
04-01 03:13:27.138+0900 D/RUA     ( 2763): rua.c: rua_add_history(179) > rua_add_history start
04-01 03:13:27.138+0900 D/RUA     ( 2763): rua.c: rua_add_history(247) > rua_add_history ok
04-01 03:13:27.878+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: _OnButtonClicked(605) >  _OnButtonClicked
04-01 03:13:27.878+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: _OnButtonClicked(628) >  clicked button type : 3
04-01 03:13:27.878+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _MoveAppsScreenView(882) >  Go Apps View
04-01 03:13:27.878+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollStart(128) >  scrollPos[-0, 0] 
04-01 03:13:27.878+0900 D/test-log( 2906): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[0] [void ClusterHome3D::Internal::CMainMenuAppsView::OnMainScrollStart():2115]
04-01 03:13:27.878+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
04-01 03:13:27.878+0900 D/test-log( 2906): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[0] [void ClusterHome3D::Internal::CMainMenuAppsView::SetViewTouchSensitive(bool):2245]
04-01 03:13:27.878+0900 D/cluster-view( 2906): cluster-impl.cpp: SetScrollSensitive(442) >  Scroll touch disabled
04-01 03:13:27.878+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnMainScrollStart(6736) >  BEGIN
04-01 03:13:27.878+0900 D/cluster-view( 2906): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
04-01 03:13:27.878+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:27.878+0900 D/test-log( 2906): cluster-impl.cpp: ScrollTo(460) >  scroll to page 0
04-01 03:13:27.878+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnCustomScrollStart(5043) >  ##################### scroll start ########################### 
04-01 03:13:27.878+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
04-01 03:13:27.878+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:27.878+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:27.878+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollViewTouched(298) >  Stop boost timer of View manager by [1]
04-01 03:13:27.878+0900 D/PROCESSMGR( 2799): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40004d 
04-01 03:13:27.918+0900 D/test-log( 2906): custom-cluster-impl.cpp: HomeViewPageOpacityConstraint(141) >  position.y: 0.00, size.y: 1280.00, posY: 1118.67
04-01 03:13:27.918+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 863] 
04-01 03:13:27.968+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 1209] 
04-01 03:13:28.018+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollUpdate(159) >  scrollPos[-0, 1280] 
04-01 03:13:28.058+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollComplete(180) >  scrollPos[-0, 1280] 
04-01 03:13:28.058+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: _OnScrollComplete(209) >  APPS_SCREEN_VIEW layout
04-01 03:13:28.058+0900 D/test-log( 2906): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[1] [void ClusterHome3D::Internal::CMainMenuAppsView::SetViewTouchSensitive(bool):2245]
04-01 03:13:28.058+0900 D/cluster-view( 2906): mainmenu-apps-view-impl.cpp: OnMainScrollComplete(2154) >  self is OnState
04-01 03:13:28.058+0900 D/test-log( 2906): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[1] [void ClusterHome3D::Internal::CMainMenuAppsView::OnMainScrollComplete():2155]
04-01 03:13:28.058+0900 W/test-log( 2906): mainmenu-page-impl.cpp: SetPageEditMode(451) >  editState:[1]
04-01 03:13:28.058+0900 D/cluster-view( 2906): cluster-impl.cpp: SetScrollSensitive(435) >  Scroll touch enabled
04-01 03:13:28.058+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:28.058+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:28.058+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:28.058+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:28.058+0900 D/test-log( 2906): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
04-01 03:13:28.058+0900 D/cluster-home( 2906): custom-cluster-impl.cpp: AllPageModeFinished(2750) >  BEGIN
04-01 03:13:28.058+0900 D/cluster-view( 2906): cluster-view-controller.cpp: OnCustomClusterSwichAllPageModeFinished(2055) >  Cluster[0:] all page mode switched 0
04-01 03:13:28.058+0900 D/cluster-view( 2906): cluster-home-accessibility.cpp: SetCurrentGroup(62) >  Focus Group changed [1]->[1] Block[0]
04-01 03:13:28.058+0900 D/cluster-view( 2906): cluster-impl.cpp: SetPageNavigator(283) >  BEGIN
04-01 03:13:28.058+0900 D/cluster-home( 2906): widget-data-provider.cpp: OnFocusedViewChanged(2973) >  changed view type[1]
04-01 03:13:28.058+0900 D/cluster-view( 2906): cluster-home-accessibility.cpp: SetCurrentGroup(62) >  Focus Group changed [1]->[12] Block[0]
04-01 03:13:28.058+0900 D/cluster-view( 2906): mainmenu-view-manager-impl.cpp: _UpdateScreenReader(2054) >  [TTS] For Home update type[1], group[12]
04-01 03:13:28.058+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
04-01 03:13:28.058+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
04-01 03:13:28.058+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
04-01 03:13:28.058+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
04-01 03:13:28.058+0900 D/cluster-view( 2906): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[60010]
04-01 03:13:28.058+0900 D/cluster-view( 2906): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[60010]
04-01 03:13:28.468+0900 D/AUL_AMD ( 2763): amd_status.c: __app_terminate_timer_cb(442) > pid(10038)
04-01 03:13:28.468+0900 W/AUL_AMD ( 2763): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
04-01 03:13:28.898+0900 D/PROCESSMGR( 2799): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1600002
04-01 03:13:29.068+0900 D/cluster-home( 2906): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
04-01 03:13:29.068+0900 D/WIDGET_VIEWER( 2906): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.tizen.calendar.widget] visibility is changed 0x[2]
04-01 03:13:29.078+0900 D/DATA_PROVIDER_MASTER( 2960): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
04-01 03:13:29.098+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __provider_pause_cb(294) > widget obj was paused
04-01 03:13:29.098+0900 I/CAPI_WIDGET_APPLICATION( 2963): widget_app.c: __check_status_for_cgroup(142) > enter background group
04-01 03:13:29.098+0900 W/AUL     ( 2963): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2963, appid: org.tizen.calendar.widget, status: bg
04-01 03:13:29.098+0900 D/RESOURCED( 2892): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2963, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
04-01 03:13:29.098+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2963
04-01 03:13:29.098+0900 D/RESOURCED( 2892): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2963, appname = org.tizen.calendar.widget
04-01 03:13:29.098+0900 D/RESOURCED( 2892): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2963
04-01 03:13:29.888+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
04-01 03:13:29.888+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
04-01 03:13:30.058+0900 D/PROCESSMGR( 2799): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40004d 
04-01 03:13:30.058+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
04-01 03:13:30.058+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
04-01 03:13:30.058+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
04-01 03:13:30.058+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
04-01 03:13:30.058+0900 D/test-log( 2906): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[237.00][385.00] to[237.00][385.00]!
04-01 03:13:30.058+0900 D/cluster-view( 2906): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
04-01 03:13:30.068+0900 D/cluster-home( 2906): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [14]MenuBox clicked
04-01 03:13:30.068+0900 D/cluster-home( 2906): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
04-01 03:13:30.068+0900 D/AUL     ( 2906): service.c: __set_bundle(186) > __set_bundle
04-01 03:13:30.068+0900 D/AUL     ( 2906): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
04-01 03:13:30.068+0900 D/AUL     ( 2906): service.c: __set_bundle(186) > __set_bundle
04-01 03:13:30.068+0900 D/AUL     ( 2906): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
04-01 03:13:30.068+0900 D/AUL     ( 2906): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
04-01 03:13:30.068+0900 D/AUL     ( 2906): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-01 03:13:30.068+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
04-01 03:13:30.068+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 2906
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_key.c: _key_grab(243) > _key_grab, win : a00002
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2448) > back key grab
04-01 03:13:30.068+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-01 03:13:30.068+0900 D/RESOURCED( 2892): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-01 03:13:30.068+0900 D/RESOURCED( 2892): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
04-01 03:13:30.068+0900 E/RESOURCED( 2892): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-01 03:13:30.068+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-01 03:13:30.068+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-01 03:13:30.068+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-01 03:13:30.068+0900 W/AUL_PAD ( 2958): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-01 03:13:30.068+0900 D/AUL     ( 2958): process_pool.c: __send_pkt_raw_data(219) > send(13) : 884 / 884
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 10258, bin path: /opt/usr/apps/org.example.example/bin/example
04-01 03:13:30.068+0900 W/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(265) > Check app launching
04-01 03:13:30.068+0900 D/AUL_PAD ( 2958): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-01 03:13:30.068+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-01 03:13:30.068+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
04-01 03:13:30.068+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-01 03:13:30.068+0900 D/AUL_PAD (10258): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-01 03:13:30.068+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-01 03:13:30.068+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-01 03:13:30.068+0900 D/AUL     (10258): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (10286) is sent.
04-01 03:13:30.068+0900 D/AUL     (10258): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 10286, signo: 10
04-01 03:13:30.078+0900 D/AUL     (10258): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : MwAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEQAAADE0OTA5ODQwMTAvNzE2MDIA##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTA2AA==##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-01 03:13:30.078+0900 D/AUL_PAD (10258): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-01 03:13:30.078+0900 I/CAPI_APPFW_APPLICATION(10258): app_main.c: ui_app_main(788) > app_efl_main
04-01 03:13:30.078+0900 D/LAUNCH  (10258): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-01 03:13:30.078+0900 D/APP_CORE(10258): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-01 03:13:30.078+0900 D/APP_CORE(10258): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-01 03:13:30.078+0900 D/APP_CORE(10258): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-01 03:13:30.078+0900 D/APP_CORE(10258): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-01 03:13:30.078+0900 D/AUL     (10258): app_sock.c: __create_server_sock(156) > pg path - already exists
04-01 03:13:30.078+0900 D/APP_CORE(10258): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42fb520
04-01 03:13:30.078+0900 D/LAUNCH  (10258): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-01 03:13:30.078+0900 I/CAPI_APPFW_APPLICATION(10258): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-01 03:13:30.088+0900 E/EFL     (10258): <10258> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
04-01 03:13:30.108+0900 W/CRASH_MANAGER(10241): worker.c: worker_job(1204) > 1110258657861149098401
