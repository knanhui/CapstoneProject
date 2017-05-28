S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 11944
Date: 2017-04-02 23:13:24+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x28

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb99292e8
ebp = 0xbfe1e138, esp = 0xbfe1e0e0
eax = 0xb42c0000, ebx = 0xb73335f0
ecx = 0xb42c0040, edx = 0xb42c0040
eip = 0xb713fcb6

Memory Information
MemTotal:      123 KB
MemFree:        35 KB
Buffers:         5 KB
Cached:     161536 KB
VmPeak:      79908 KB
VmSize:      79908 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16004 KB
VmRSS:       16004 KB
VmData:      19992 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33320 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 11944 TID = 11944
11944 11968 11972 

Maps Information
b2cbb000 b2cc5000 r-xp /usr/lib/libfeedback.so.0.1.4
b2ccb000 b2cd7000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cd8000 b2cf9000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2cfe000 b2cff000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d00000 b2d05000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d06000 b2d07000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2d08000 b2d0a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d0b000 b2d0d000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d0e000 b2d1a000 r-xp /usr/lib/libdrm.so.2.4.0
b2d1b000 b2d1e000 r-xp /usr/lib/libdri2.so.0.0.0
b2d1f000 b2d29000 r-xp /usr/lib/libtbm.so.1.0.0
b2d30000 b2d31000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b2d32000 b2d33000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b2d34000 b2d37000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b2d38000 b2d3b000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b2d3c000 b2d51000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d52000 b2d64000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b366d000 b3673000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3674000 b37b8000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37c8000 b37c9000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37ca000 b37d3000 r-xp /usr/lib/libefl-extension.so.0.1.0
b37d4000 b37d8000 r-xp /opt/usr/apps/org.example.example/bin/example
b37da000 b3813000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4216000 b4221000 r-xp /lib/libnss_files-2.20-2014.11.so
b4223000 b422e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4230000 b4247000 r-xp /lib/libnsl-2.20-2014.11.so
b424b000 b4253000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4255000 b4279000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b427a000 b427b000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b427c000 b427f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4280000 b4287000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4288000 b4292000 r-xp /usr/lib/libsensord-share.so
b4293000 b42af000 r-xp /usr/lib/libsensor.so.1.2.0
b42b1000 b42ba000 r-xp /usr/lib/libappcore-common.so.1.1
b42bd000 b42bf000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42d4000 b42d6000 r-xp /usr/lib/libXau.so.6.0.0
b42d7000 b42f9000 r-xp /usr/lib/libxcb.so.1.1.0
b42fb000 b4304000 r-xp /lib/libcrypt-2.20-2014.11.so
b432d000 b432f000 r-xp /usr/lib/libiri.so
b4330000 b4356000 r-xp /lib/libexpat.so.1.5.2
b4358000 b43c3000 r-xp /usr/lib/libssl.so.1.0.0
b43c9000 b43d5000 r-xp /usr/lib/libethumb.so.1.13.0
b43d6000 b43da000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43db000 b462c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5ba7000 b5bb7000 r-xp /usr/lib/libXi.so.6.1.0
b5bb8000 b5bba000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bbb000 b5bc1000 r-xp /usr/lib/libXtst.so.6.1.0
b5bc2000 b5bcc000 r-xp /usr/lib/libXrender.so.1.3.0
b5bcd000 b5bd6000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bd8000 b5bda000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bdb000 b5be0000 r-xp /usr/lib/libXfixes.so.3.1.0
b5be1000 b5bf3000 r-xp /usr/lib/libXext.so.6.4.0
b5bf4000 b5bf6000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bf7000 b5bf9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bfb000 b5d3d000 r-xp /usr/lib/libX11.so.6.3.0
b5d41000 b5d4b000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d4c000 b5d62000 r-xp /usr/lib/libudev.so.1.6.0
b5d65000 b5d69000 r-xp /lib/libattr.so.1.1.0
b5d6a000 b5d99000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d9b000 b5da1000 r-xp /usr/lib/libffi.so.6.0.2
b5da2000 b5dc5000 r-xp /lib/libz.so.1.2.8
b5dc6000 b5dc9000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dca000 b5f26000 r-xp /usr/lib/libxml2.so.2.9.2
b5f2c000 b6013000 r-xp /usr/lib/libstdc++.so.6.0.20
b6020000 b6023000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6024000 b6046000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6047000 b605b000 r-xp /lib/libresolv-2.20-2014.11.so
b605f000 b6083000 r-xp /usr/lib/liblzma.so.5.0.3
b6084000 b6086000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6088000 b6092000 r-xp /usr/lib/libembryo.so.1.13.0
b6093000 b60bc000 r-xp /usr/lib/libpng12.so.0.50.0
b60bd000 b6106000 r-xp /usr/lib/libjpeg.so.8.0.2
b6117000 b611e000 r-xp /lib/librt-2.20-2014.11.so
b6120000 b613f000 r-xp /usr/lib/libector.so.1.13.0
b6142000 b616f000 r-xp /usr/lib/liblua-5.1.so
b6170000 b6200000 r-xp /usr/lib/libfreetype.so.6.11.3
b6204000 b6242000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6243000 b6259000 r-xp /usr/lib/libfribidi.so.0.3.1
b625a000 b62b3000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62b6000 b6301000 r-xp /lib/libm-2.20-2014.11.so
b6303000 b6315000 r-xp /usr/lib/libeio.so.1.13.0
b6316000 b6319000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b631a000 b6320000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6321000 b6344000 r-xp /usr/lib/libefreet.so.1.13.0
b6347000 b6372000 r-xp /usr/lib/libeldbus.so.1.13.0
b6373000 b63a7000 r-xp /usr/lib/libecore_con.so.1.13.0
b63a9000 b63b2000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63b3000 b63bc000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63bd000 b63d0000 r-xp /usr/lib/libeo.so.1.13.0
b63d2000 b63e5000 r-xp /usr/lib/libecore_input.so.1.13.0
b63e6000 b63ed000 r-xp /usr/lib/libecore_file.so.1.13.0
b63ee000 b6411000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6412000 b643e000 r-xp /usr/lib/libeet.so.1.13.0
b6447000 b64b2000 r-xp /usr/lib/libeina.so.1.13.0
b64b5000 b64cc000 r-xp /usr/lib/libefl.so.1.13.0
b64ce000 b6635000 r-xp /usr/lib/libicuuc.so.51.1
b6643000 b684f000 r-xp /usr/lib/libicui18n.so.51.1
b6857000 b68a6000 r-xp /usr/lib/libecore_x.so.1.13.0
b68a8000 b68c2000 r-xp /lib/libgcc_s-4.9.so.1
b68c4000 b68c8000 r-xp /lib/libcap.so.2.21
b68c9000 b690f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6910000 b6917000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6919000 b696b000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b696d000 b6af8000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6afd000 b6bcb000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bce000 b6bd2000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bd3000 b6be2000 r-xp /usr/lib/libvconf.so.0.2.45
b6be3000 b6be6000 r-xp /usr/lib/libvasum.so.0.3.1
b6be7000 b6bea000 r-xp /usr/lib/libttrace.so.1.1
b6bec000 b6bf0000 r-xp /usr/lib/libiniparser.so.0
b6bf1000 b6c21000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c22000 b6c2b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c2c000 b6c51000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c52000 b6c62000 r-xp /usr/lib/libunwind.so.8.0.1
b6c6c000 b6e1a000 r-xp /lib/libc-2.20-2014.11.so
b6e22000 b6f65000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f67000 b6fbf000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fc0000 b6ff4000 r-xp /usr/lib/libsystemd.so.0.4.0
b6ff7000 b70cb000 r-xp /usr/lib/libedje.so.1.13.0
b70ce000 b70fa000 r-xp /usr/lib/libecore.so.1.13.0
b710b000 b7331000 r-xp /usr/lib/libevas.so.1.13.0
b7359000 b7371000 r-xp /lib/libpthread-2.20-2014.11.so
b7375000 b76ef000 r-xp /usr/lib/libelementary.so.1.13.0
b770f000 b7713000 r-xp /usr/lib/libsmack.so.1.0.0
b7714000 b771d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b771e000 b7721000 r-xp /usr/lib/libdlog.so.0.0.0
b7722000 b7727000 r-xp /usr/lib/libbundle.so.0.1.22
b7728000 b772b000 r-xp /lib/libdl-2.20-2014.11.so
b772d000 b7752000 r-xp /usr/lib/libaul.so.0.1.0
b7755000 b7757000 r-xp /usr/lib/libappsvc.so.0.1.0
b7758000 b775d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b775e000 b7765000 r-xp /usr/lib/libappcore-efl.so.1.1
b7767000 b776c000 r-xp /usr/lib/libsys-assert.so
b776f000 b7770000 r-xp [vdso]
b7770000 b7792000 r-xp /lib/ld-2.20-2014.11.so
b7794000 b779c000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:11944)
Call Stack Count: 22
 0: evas_object_event_callback_priority_add + 0xe6 (0xb713fcb6) [/usr/lib/libevas.so.1] + 0x34cb6
 1: evas_object_event_callback_add + 0x38 (0xb713fd48) [/usr/lib/libevas.so.1] + 0x34d48
 2: (0xb75270b8) [/usr/lib/libelementary.so.1] + 0x1b20b8
 3: elm_obj_widget_sub_object_add + 0xa1 (0xb75d8371) [/usr/lib/libelementary.so.1] + 0x263371
 4: elm_widget_sub_object_add + 0x55 (0xb75f2085) [/usr/lib/libelementary.so.1] + 0x27d085
 5: (0xb7523af2) [/usr/lib/libelementary.so.1] + 0x1aeaf2
 6: elm_obj_container_content_set + 0xb3 (0xb7471393) [/usr/lib/libelementary.so.1] + 0xfc393
 7: elm_widget_content_part_set + 0x71 (0xb75e4b41) [/usr/lib/libelementary.so.1] + 0x26fb41
 8: elm_object_part_content_set + 0x2f (0xb753db3f) [/usr/lib/libelementary.so.1] + 0x1c8b3f
 9: (0xb7412073) [/usr/lib/libelementary.so.1] + 0x9d073
10: (0xb74141fe) [/usr/lib/libelementary.so.1] + 0x9f1fe
11: (0xb7415ae9) [/usr/lib/libelementary.so.1] + 0xa0ae9
12: elm_obj_naviframe_item_push + 0xe0 (0xb74107e0) [/usr/lib/libelementary.so.1] + 0x9b7e0
13: elm_naviframe_item_push + 0x71 (0xb7416801) [/usr/lib/libelementary.so.1] + 0xa1801
14: create_base_gui + 0x8f2 (0xb37d6912) [/opt/usr/apps/org.example.example/bin/example] + 0x2912
15: app_create + 0x2c (0xb37d5e8c) [/opt/usr/apps/org.example.example/bin/example] + 0x1e8c
16: (0xb775a65b) [/usr/lib/libcapi-appfw-application.so.0] + 0x265b
17: appcore_efl_main + 0x327 (0xb7761c27) [/usr/lib/libappcore-efl.so.1] + 0x3c27
18: ui_app_main + 0x140 (0xb775ac80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x27e (0xb37d5dfe) [/opt/usr/apps/org.example.example/bin/example] + 0x1dfe
20: create_base_gui + 0x128 (0xb7796148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7796148
21: __libc_start_main + 0xde (0xb6c83e4e) [/lib/libc.so.6] + 0x17e4e
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
o(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-02 23:13:19.351+0900 D/PKGMGR_INFO( 2769): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
04-02 23:13:19.351+0900 I/AUL     ( 2769): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
04-02 23:13:19.351+0900 E/AUL_AMD ( 2769): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
04-02 23:13:19.351+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2233) > caller pid : 11919
04-02 23:13:19.351+0900 E/AUL_AMD ( 2769): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
04-02 23:13:19.351+0900 W/AUL_AMD ( 2769): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-02 23:13:19.351+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2648) > process_pool: false
04-02 23:13:19.351+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-02 23:13:19.351+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-02 23:13:19.351+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2665) > pad pid(-5)
04-02 23:13:19.351+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-02 23:13:19.351+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-02 23:13:19.351+0900 D/AUL     ( 2769): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-02 23:13:19.351+0900 W/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-02 23:13:19.351+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-02 23:13:19.351+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
04-02 23:13:19.351+0900 D/AUL     ( 2920): process_pool.c: __send_pkt_raw_data(219) > send(13) : 624 / 624
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 11684, bin path: /opt/usr/apps/org.example.example/bin/example
04-02 23:13:19.351+0900 W/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(265) > Check app launching
04-02 23:13:19.351+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-02 23:13:19.351+0900 E/RESOURCED( 2852): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-02 23:13:19.351+0900 D/AUL     (11684): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (11712) is sent.
04-02 23:13:19.351+0900 D/AUL     (11684): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 11712, signo: 10
04-02 23:13:19.351+0900 D/AUL     (11684): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTExNDIzOTkvMzU3ODg2AA==##
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMTkxOQA=##
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-02 23:13:19.351+0900 D/AUL_PAD (11684): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-02 23:13:19.351+0900 I/CAPI_APPFW_APPLICATION(11684): app_main.c: ui_app_main(788) > app_efl_main
04-02 23:13:19.351+0900 D/LAUNCH  (11684): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-02 23:13:19.351+0900 D/APP_CORE(11684): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-02 23:13:19.351+0900 D/APP_CORE(11684): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-02 23:13:19.351+0900 D/APP_CORE(11684): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-02 23:13:19.361+0900 D/APP_CORE(11684): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-02 23:13:19.361+0900 D/AUL     (11684): app_sock.c: __create_server_sock(156) > pg path - already exists
04-02 23:13:19.361+0900 D/APP_CORE(11684): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42b6520
04-02 23:13:19.361+0900 D/LAUNCH  (11684): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-02 23:13:19.361+0900 I/CAPI_APPFW_APPLICATION(11684): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-02 23:13:19.451+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
04-02 23:13:19.451+0900 W/AUL     ( 2769): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 11684, appid: org.example.example
04-02 23:13:19.451+0900 D/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-02 23:13:19.451+0900 E/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(330) > access
04-02 23:13:19.451+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2700) > add app group info
04-02 23:13:19.451+0900 E/AUL     ( 2769): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
04-02 23:13:19.451+0900 D/AUL_AMD ( 2769): amd_status.c: _status_add_app_info_list(427) > pid(11684) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
04-02 23:13:19.451+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 11684
04-02 23:13:19.451+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
04-02 23:13:19.451+0900 E/RESOURCED( 2852): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
04-02 23:13:19.451+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(888) > available memory = 316
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:676 _eo_call_resolve() in elm_grid.eo.c:24: func 'elm_obj_grid_pack' (1302) could not be resolved for class 'Elm_Naviframe'.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:676 _eo_call_resolve() in elm_grid.eo.c:24: func 'elm_obj_grid_pack' (1302) could not be resolved for class 'Elm_Naviframe'.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:1471 eo_isa() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:1471 eo_isa() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:1471 eo_isa() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb7bcc4f0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:19.471+0900 E/EFL     (11684): eo<11684> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb7bcc4f0) is an invalid ref.
04-02 23:13:19.511+0900 W/CRASH_MANAGER(11924): worker.c: worker_job(1204) > 11116846578611491142399
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: vconf_get_str(2891) > vconf_get_str(11924) : db/menu_widget/language error
04-02 23:13:20.221+0900 E/PKGMGR_INFO(11924): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-02 23:13:20.221+0900 D/PKGMGR_INFO(11924): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 23:13:20.221+0900 D/PKGMGR_INFO(11924): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: vconf_get_str(2891) > vconf_get_str(11924) : db/menu_widget/language error
04-02 23:13:20.221+0900 E/PKGMGR_INFO(11924): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-02 23:13:20.221+0900 D/PKGMGR_INFO(11924): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 23:13:20.221+0900 D/PKGMGR_INFO(11924): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: vconf_get_str(2891) > vconf_get_str(11924) : db/menu_widget/language error
04-02 23:13:20.221+0900 E/PKGMGR_INFO(11924): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-02 23:13:20.221+0900 D/PKGMGR_INFO(11924): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 23:13:20.221+0900 D/PKGMGR_INFO(11924): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
04-02 23:13:20.221+0900 E/VCONF   (11924): vconf.c: vconf_get_str(2891) > vconf_get_str(11924) : db/menu_widget/language error
04-02 23:13:20.221+0900 E/PKGMGR_INFO(11924): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
04-02 23:13:20.341+0900 D/LAUNCH  (11936): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
04-02 23:13:20.341+0900 D/PKGMGR_INFO(11936): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
04-02 23:13:20.341+0900 D/PKGMGR_INFO(11936): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
04-02 23:13:20.341+0900 D/AUL     (11936): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 11936 is org.tizen.crash-popup
04-02 23:13:20.381+0900 D/APP_CORE(11936): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-02 23:13:20.381+0900 D/APP_CORE(11936): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
04-02 23:13:20.381+0900 D/APP_CORE(11936): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-02 23:13:20.391+0900 D/APP_CORE(11936): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-02 23:13:20.391+0900 D/APP_CORE(11936): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb7768520
04-02 23:13:20.391+0900 D/LAUNCH  (11936): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
04-02 23:13:20.411+0900 D/APP_CORE(11936): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-02 23:13:20.411+0900 D/LAUNCH  (11936): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
04-02 23:13:20.411+0900 D/APP_CORE(11936): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
04-02 23:13:20.451+0900 D/AUL_PAD (11944): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
04-02 23:13:20.451+0900 D/AUL_AMD ( 2769): amd_launch.c: __grab_timeout_handler(1445) > pid(11684) ecore_x_pointer_ungrab
04-02 23:13:20.451+0900 D/AUL_AMD ( 2769): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
04-02 23:13:20.451+0900 W/AUL_AMD ( 2769): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-02 23:13:20.451+0900 W/AUL_AMD ( 2769): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): sigchild.h: __send_app_launch_signal(131) > send launch signal done
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 23:13:20.451+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 23:13:20.451+0900 I/AUL_PAD ( 2920): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 11684 pgid = 11684
04-02 23:13:20.451+0900 I/AUL_PAD ( 2920): sigchild.h: __sigchild_action(142) > dead_pid(11684)
04-02 23:13:20.461+0900 D/AUL_PAD ( 2920): sigchild.h: __send_app_dead_signal(90) > send dead signal done
04-02 23:13:20.461+0900 I/AUL_PAD ( 2920): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
04-02 23:13:20.461+0900 I/AUL_PAD ( 2920): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
04-02 23:13:20.461+0900 E/AUL_PAD ( 2920): launchpad.c: main(688) > error reading sigchld info
04-02 23:13:20.461+0900 I/ESD     ( 2942): esd_main.c: __esd_app_dead_handler(1771) > pid: 11684
04-02 23:13:20.461+0900 D/STARTER ( 2845): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 11684 is termianted
04-02 23:13:20.461+0900 D/STARTER ( 2845): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
04-02 23:13:20.461+0900 W/AUL_AMD ( 2769): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 11684
04-02 23:13:20.461+0900 W/AUL_AMD ( 2769): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 11684
04-02 23:13:20.461+0900 D/AUL_AMD ( 2769): amd_key.c: _unregister_key_event(179) > ===key stack===
04-02 23:13:20.461+0900 E/AUL_AMD ( 2769): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
04-02 23:13:20.461+0900 D/AUL_AMD ( 2769): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
04-02 23:13:20.461+0900 D/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
04-02 23:13:20.461+0900 E/AUL     ( 2769): simple_util.c: __trm_app_info_send_socket(330) > access
04-02 23:13:20.461+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 11684
04-02 23:13:20.461+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
04-02 23:13:20.671+0900 E/RESOURCED( 2852): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
04-02 23:13:20.961+0900 D/AUL_AMD ( 2769): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
04-02 23:13:20.961+0900 D/RUA     ( 2769): rua.c: rua_add_history(179) > rua_add_history start
04-02 23:13:20.961+0900 D/RUA     ( 2769): rua.c: rua_add_history(247) > rua_add_history ok
04-02 23:13:20.991+0900 E/PKGMGR_SERVER(11778): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-02 23:13:20.991+0900 E/PKGMGR_SERVER(11778): pkgmgr-server.c: main(2265) > package manager server terminated.
04-02 23:13:21.481+0900 D/AUL_PAD (11944): launchpad_loader.c: main(588) > sleeping 1 sec...
04-02 23:13:21.481+0900 D/AUL_PAD (11944): preload.h: __preload_init(52) > max_cmdline_size = 1053
04-02 23:13:21.481+0900 D/AUL_PAD (11944): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b978c760
04-02 23:13:21.481+0900 D/AUL_PAD (11944): preload.h: __preload_init(69) > get pre-initialization function
04-02 23:13:21.481+0900 D/AUL_PAD (11944): preload.h: __preload_init(73) > get shutdown function
04-02 23:13:21.491+0900 D/AUL_PAD (11944): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b978ca40
04-02 23:13:21.491+0900 D/AUL_PAD (11944): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b978e640
04-02 23:13:21.491+0900 D/AUL_PAD (11944): preload.h: __preload_init(69) > get pre-initialization function
04-02 23:13:21.491+0900 D/AUL_PAD (11944): preload.h: __preload_init(73) > get shutdown function
04-02 23:13:21.491+0900 D/AUL_PAD (11944): preexec.h: __preexec_init(76) > preexec start
04-02 23:13:21.491+0900 D/AUL_PAD (11944): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
04-02 23:13:21.491+0900 D/AUL     (11944): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
04-02 23:13:21.491+0900 D/AUL     (11944): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
04-02 23:13:21.491+0900 D/AUL     (11944): process_pool.c: __connect_to_launchpad(132) > send(11944) : 4
04-02 23:13:21.491+0900 D/AUL     (11944): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
04-02 23:13:21.491+0900 D/AUL_PAD ( 2920): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 11944
04-02 23:13:21.541+0900 D/AUL_PAD (11944): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
04-02 23:13:21.561+0900 D/AUL_PAD (11944): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
04-02 23:13:21.561+0900 D/AUL_PAD (11944): launchpad_loader.c: main(693) > [candidate] ecore handler add
04-02 23:13:21.561+0900 D/AUL_PAD (11944): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
04-02 23:13:23.431+0900 E/EFL     (11936): eldbus<11936> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-lEyyhdSq0A: Connection refused
04-02 23:13:23.431+0900 E/EFL     (11936): <11936> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
04-02 23:13:23.431+0900 E/EFL     (11936): elementary<11936> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
04-02 23:13:23.431+0900 D/APP_CORE(11936): appcore.c: __aul_handler(587) > [APP 11936]     AUL event: AUL_START
04-02 23:13:23.431+0900 I/APP_CORE(11936): appcore-efl.c: __do_app(496) > [APP 11936] Event: RESET State: CREATED
04-02 23:13:23.431+0900 D/APP_CORE(11936): appcore-efl.c: __do_app(527) > [APP 11936] RESET
04-02 23:13:23.431+0900 D/LAUNCH  (11936): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
04-02 23:13:23.431+0900 D/APP_CORE(11936): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
04-02 23:13:23.431+0900 D/APP_CORE(11936): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
04-02 23:13:23.431+0900 E/SYSPOPUP(11936): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
04-02 23:13:23.431+0900 E/SYSPOPUP(11936): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
04-02 23:13:23.431+0900 E/SYSPOPUP(11936): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
04-02 23:13:23.431+0900 D/LAUNCH  (11936): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
04-02 23:13:23.431+0900 D/APP_CORE(11936): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
04-02 23:13:23.481+0900 D/AUL     (11936): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
04-02 23:13:23.481+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 22
04-02 23:13:23.481+0900 W/AUL_AMD ( 2769): amd_request.c: __request_handler(1056) > app status : 5
04-02 23:13:23.481+0900 D/AUL_AMD ( 2769): amd_status.c: _status_update_app_info_list(456) > pid(11936) status(5)
04-02 23:13:23.491+0900 D/APP_CORE(11936): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
04-02 23:13:23.491+0900 E/EFL     (11936): eo<11936> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:23.491+0900 E/EFL     (11936): eo<11936> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
04-02 23:13:24.251+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
04-02 23:13:24.251+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
04-02 23:13:24.411+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
04-02 23:13:24.411+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
04-02 23:13:24.411+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
04-02 23:13:24.411+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
04-02 23:13:24.411+0900 D/test-log( 2870): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[151.00][321.00] to[151.00][321.00]!
04-02 23:13:24.411+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
04-02 23:13:24.411+0900 D/cluster-home( 2870): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [13]MenuBox clicked
04-02 23:13:24.411+0900 D/cluster-home( 2870): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
04-02 23:13:24.411+0900 D/AUL     ( 2870): service.c: __set_bundle(186) > __set_bundle
04-02 23:13:24.411+0900 D/AUL     ( 2870): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
04-02 23:13:24.411+0900 D/AUL     ( 2870): service.c: __set_bundle(186) > __set_bundle
04-02 23:13:24.411+0900 D/AUL     ( 2870): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
04-02 23:13:24.411+0900 D/AUL     ( 2870): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
04-02 23:13:24.411+0900 D/AUL     ( 2870): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
04-02 23:13:24.411+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(838) > __request_handler: 0
04-02 23:13:24.411+0900 D/PROCESSMGR( 2697): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x20004e 
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
04-02 23:13:24.421+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
04-02 23:13:24.421+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2233) > caller pid : 2870
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_key.c: _key_grab(243) > _key_grab, win : a00002
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2448) > back key grab
04-02 23:13:24.421+0900 W/AUL_AMD ( 2769): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
04-02 23:13:24.421+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
04-02 23:13:24.421+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
04-02 23:13:24.421+0900 E/RESOURCED( 2852): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2648) > process_pool: false
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
04-02 23:13:24.421+0900 W/AUL_AMD ( 2769): amd_launch.c: _start_app(2665) > pad pid(-5)
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
04-02 23:13:24.421+0900 D/AUL_AMD ( 2769): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
04-02 23:13:24.421+0900 D/AUL     ( 2769): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
04-02 23:13:24.421+0900 W/AUL_PAD ( 2920): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
04-02 23:13:24.421+0900 D/AUL     ( 2920): process_pool.c: __send_pkt_raw_data(219) > send(13) : 884 / 884
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 11944, bin path: /opt/usr/apps/org.example.example/bin/example
04-02 23:13:24.421+0900 W/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(265) > Check app launching
04-02 23:13:24.421+0900 D/AUL_PAD ( 2920): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
04-02 23:13:24.421+0900 D/AUL     (11944): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (11968) is sent.
04-02 23:13:24.421+0900 D/AUL     (11944): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 11968, signo: 10
04-02 23:13:24.421+0900 D/AUL     (11944): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTExNDI0MDQvNDI5MDkzAA==##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODcwAA==##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
04-02 23:13:24.421+0900 D/AUL_PAD (11944): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
04-02 23:13:24.421+0900 I/CAPI_APPFW_APPLICATION(11944): app_main.c: ui_app_main(788) > app_efl_main
04-02 23:13:24.431+0900 D/LAUNCH  (11944): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
04-02 23:13:24.431+0900 D/APP_CORE(11944): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
04-02 23:13:24.431+0900 D/APP_CORE(11944): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
04-02 23:13:24.431+0900 D/APP_CORE(11944): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
04-02 23:13:24.431+0900 D/APP_CORE(11944): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
04-02 23:13:24.431+0900 D/AUL     (11944): app_sock.c: __create_server_sock(156) > pg path - already exists
04-02 23:13:24.431+0900 D/APP_CORE(11944): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42ba520
04-02 23:13:24.431+0900 D/LAUNCH  (11944): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
04-02 23:13:24.431+0900 I/CAPI_APPFW_APPLICATION(11944): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:676 _eo_call_resolve() in elm_grid.eo.c:24: func 'elm_obj_grid_pack' (1302) could not be resolved for class 'Elm_Naviframe'.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:676 _eo_call_resolve() in elm_grid.eo.c:24: func 'elm_obj_grid_pack' (1302) could not be resolved for class 'Elm_Naviframe'.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:1471 eo_isa() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:1471 eo_isa() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:1471 eo_isa() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0xb990b7e0 is not pointing to a valid object. Maybe it has already been freed.
04-02 23:13:24.471+0900 E/EFL     (11944): eo<11944> lib/eo/eo.c:485 _eo_do_internal() Obj (0xb990b7e0) is an invalid ref.
04-02 23:13:24.491+0900 W/CRASH_MANAGER(11924): worker.c: worker_job(1204) > 1111944657861149114240
