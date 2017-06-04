S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 12117
Date: 2017-06-04 08:50:07+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xbfbb0120
ebp = 0xbfbb0238, esp = 0xbfbb00e0
eax = 0x00000021, ebx = 0xb37ec000
ecx = 0x00000000, edx = 0xbfbb011c
eip = 0xb37e59ad

Memory Information
MemTotal:      123 KB
MemFree:        19 KB
Buffers:         8 KB
Cached:     169816 KB
VmPeak:     125496 KB
VmSize:     125496 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       38436 KB
VmRSS:       38436 KB
VmData:      55584 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12117 TID = 12117
12117 12119 12281 12282 12288 

Maps Information
b0ee6000 b0efe000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1807000 b180e000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1811000 b1818000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b18cd000 b18d1000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2ba6000 b2bb0000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bb6000 b2bc2000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bc3000 b2be4000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2be9000 b2bea000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2beb000 b2bf0000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bf1000 b2bf2000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bf3000 b2bf5000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bf6000 b2bf8000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bf9000 b2c05000 r-xp /usr/lib/libdrm.so.2.4.0
b2c06000 b2c09000 r-xp /usr/lib/libdri2.so.0.0.0
b2c0a000 b2c14000 r-xp /usr/lib/libtbm.so.1.0.0
b2c15000 b2c2a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c2b000 b2c3d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b343f000 b3470000 r-xp /usr/lib/libidn.so.11.5.44
b3471000 b3493000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3494000 b34a4000 r-xp /usr/lib/libcares.so.2.1.0
b34a5000 b34ae000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34af000 b34b8000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34b9000 b3530000 r-xp /usr/lib/libcurl.so.4.3.0
b3532000 b3544000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3545000 b3566000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b356d000 b356e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b356f000 b3570000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3571000 b3574000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3575000 b3578000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3680000 b3686000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3687000 b37cb000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37dc000 b37dd000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37de000 b37eb000 r-xp /opt/usr/apps/org.example.example/bin/example
b37ed000 b3826000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4229000 b4234000 r-xp /lib/libnss_files-2.20-2014.11.so
b4236000 b4241000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4243000 b425a000 r-xp /lib/libnsl-2.20-2014.11.so
b425e000 b4266000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4268000 b428c000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b428d000 b428e000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b428f000 b4292000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4293000 b429a000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b429b000 b42a5000 r-xp /usr/lib/libsensord-share.so
b42a6000 b42c2000 r-xp /usr/lib/libsensor.so.1.2.0
b42c4000 b42cd000 r-xp /usr/lib/libappcore-common.so.1.1
b42d0000 b42d2000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42e7000 b42e9000 r-xp /usr/lib/libXau.so.6.0.0
b42ea000 b430c000 r-xp /usr/lib/libxcb.so.1.1.0
b430e000 b4317000 r-xp /lib/libcrypt-2.20-2014.11.so
b4340000 b4342000 r-xp /usr/lib/libiri.so
b4343000 b4369000 r-xp /lib/libexpat.so.1.5.2
b436b000 b43d6000 r-xp /usr/lib/libssl.so.1.0.0
b43dc000 b43e8000 r-xp /usr/lib/libethumb.so.1.13.0
b43e9000 b43ed000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ee000 b463f000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bba000 b5bca000 r-xp /usr/lib/libXi.so.6.1.0
b5bcb000 b5bcd000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bce000 b5bd4000 r-xp /usr/lib/libXtst.so.6.1.0
b5bd5000 b5bdf000 r-xp /usr/lib/libXrender.so.1.3.0
b5be0000 b5be9000 r-xp /usr/lib/libXrandr.so.2.2.0
b5beb000 b5bed000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bee000 b5bf3000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bf4000 b5c06000 r-xp /usr/lib/libXext.so.6.4.0
b5c07000 b5c09000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c0a000 b5c0c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c0e000 b5d50000 r-xp /usr/lib/libX11.so.6.3.0
b5d54000 b5d5e000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d5f000 b5d75000 r-xp /usr/lib/libudev.so.1.6.0
b5d78000 b5d7c000 r-xp /lib/libattr.so.1.1.0
b5d7d000 b5dac000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dae000 b5db4000 r-xp /usr/lib/libffi.so.6.0.2
b5db5000 b5dd8000 r-xp /lib/libz.so.1.2.8
b5dd9000 b5ddc000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5ddd000 b5f39000 r-xp /usr/lib/libxml2.so.2.9.2
b5f3f000 b6026000 r-xp /usr/lib/libstdc++.so.6.0.20
b6033000 b6036000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6037000 b6059000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b605a000 b606e000 r-xp /lib/libresolv-2.20-2014.11.so
b6072000 b6096000 r-xp /usr/lib/liblzma.so.5.0.3
b6097000 b6099000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b609b000 b60a5000 r-xp /usr/lib/libembryo.so.1.13.0
b60a6000 b60cf000 r-xp /usr/lib/libpng12.so.0.50.0
b60d0000 b6119000 r-xp /usr/lib/libjpeg.so.8.0.2
b612a000 b6131000 r-xp /lib/librt-2.20-2014.11.so
b6133000 b6152000 r-xp /usr/lib/libector.so.1.13.0
b6155000 b6182000 r-xp /usr/lib/liblua-5.1.so
b6183000 b6213000 r-xp /usr/lib/libfreetype.so.6.11.3
b6217000 b6255000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6256000 b626c000 r-xp /usr/lib/libfribidi.so.0.3.1
b626d000 b62c6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62c9000 b6314000 r-xp /lib/libm-2.20-2014.11.so
b6316000 b6328000 r-xp /usr/lib/libeio.so.1.13.0
b6329000 b632c000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b632d000 b6333000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6334000 b6357000 r-xp /usr/lib/libefreet.so.1.13.0
b635a000 b6385000 r-xp /usr/lib/libeldbus.so.1.13.0
b6386000 b63ba000 r-xp /usr/lib/libecore_con.so.1.13.0
b63bc000 b63c5000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63c6000 b63cf000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63d0000 b63e3000 r-xp /usr/lib/libeo.so.1.13.0
b63e5000 b63f8000 r-xp /usr/lib/libecore_input.so.1.13.0
b63f9000 b6400000 r-xp /usr/lib/libecore_file.so.1.13.0
b6401000 b6424000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6425000 b6451000 r-xp /usr/lib/libeet.so.1.13.0
b645a000 b64c5000 r-xp /usr/lib/libeina.so.1.13.0
b64c8000 b64df000 r-xp /usr/lib/libefl.so.1.13.0
b64e1000 b6648000 r-xp /usr/lib/libicuuc.so.51.1
b6656000 b6862000 r-xp /usr/lib/libicui18n.so.51.1
b686a000 b68b9000 r-xp /usr/lib/libecore_x.so.1.13.0
b68bb000 b68d5000 r-xp /lib/libgcc_s-4.9.so.1
b68d7000 b68db000 r-xp /lib/libcap.so.2.21
b68dc000 b6922000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6923000 b692a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b692c000 b697e000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6980000 b6b0b000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b10000 b6bde000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6be1000 b6be5000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6be6000 b6bf5000 r-xp /usr/lib/libvconf.so.0.2.45
b6bf6000 b6bf9000 r-xp /usr/lib/libvasum.so.0.3.1
b6bfa000 b6bfd000 r-xp /usr/lib/libttrace.so.1.1
b6bff000 b6c03000 r-xp /usr/lib/libiniparser.so.0
b6c04000 b6c34000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c35000 b6c3e000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c3f000 b6c64000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c65000 b6c75000 r-xp /usr/lib/libunwind.so.8.0.1
b6c7f000 b6e2d000 r-xp /lib/libc-2.20-2014.11.so
b6e35000 b6f78000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f7a000 b6fd2000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fd3000 b7007000 r-xp /usr/lib/libsystemd.so.0.4.0
b700a000 b70de000 r-xp /usr/lib/libedje.so.1.13.0
b70e1000 b710d000 r-xp /usr/lib/libecore.so.1.13.0
b711e000 b7344000 r-xp /usr/lib/libevas.so.1.13.0
b736c000 b7384000 r-xp /lib/libpthread-2.20-2014.11.so
b7388000 b7702000 r-xp /usr/lib/libelementary.so.1.13.0
b7722000 b7726000 r-xp /usr/lib/libsmack.so.1.0.0
b7727000 b7730000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7731000 b7734000 r-xp /usr/lib/libdlog.so.0.0.0
b7735000 b773a000 r-xp /usr/lib/libbundle.so.0.1.22
b773b000 b773e000 r-xp /lib/libdl-2.20-2014.11.so
b7740000 b7765000 r-xp /usr/lib/libaul.so.0.1.0
b7768000 b776a000 r-xp /usr/lib/libappsvc.so.0.1.0
b776b000 b7770000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7771000 b7778000 r-xp /usr/lib/libappcore-efl.so.1.1
b777a000 b777f000 r-xp /usr/lib/libsys-assert.so
b7782000 b7783000 r-xp [vdso]
b7783000 b77a5000 r-xp /lib/ld-2.20-2014.11.so
b77a7000 b77af000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12117)
Call Stack Count: 22
 0: InsertRecord + 0xbd (0xb37e59ad) [/opt/usr/apps/org.example.example/bin/example] + 0x79ad
 1: popup_set_btn_clicked_cb + 0x11c (0xb37e4e8c) [/opt/usr/apps/org.example.example/bin/example] + 0x6e8c
 2: (0xb71a7116) [/usr/lib/libevas.so.1] + 0x89116
 3: (0xb63de319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb63dbd63) [/usr/lib/libeo.so.1] + 0xbd63
 5: evas_object_smart_callback_call + 0x75 (0xb71a99e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 6: (0xb745a404) [/usr/lib/libelementary.so.1] + 0xd2404
 7: (0xb708df39) [/usr/lib/libedje.so.1] + 0x83f39
 8: (0xb7094a11) [/usr/lib/libedje.so.1] + 0x8aa11
 9: (0xb708efdc) [/usr/lib/libedje.so.1] + 0x84fdc
10: (0xb708f4cb) [/usr/lib/libedje.so.1] + 0x854cb
11: (0xb708f68f) [/usr/lib/libedje.so.1] + 0x8568f
12: (0xb70f4702) [/usr/lib/libecore.so.1] + 0x13702
13: (0xb70ee055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70f71b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb70f7587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb755022d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb7774dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb776dc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x296 (0xb37e67e6) [/opt/usr/apps/org.example.example/bin/example] + 0x87e6
20: (0xb77a9148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77a9148
21: __libc_start_main + 0xde (0xb6c96e4e) [/lib/libc.so.6] + 0x17e4e
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
2222): rpm-appcore-intf.c: main(261) > ------------------------------------------------
06-04 08:49:50.283+0900 D/PKGMGR_SERVER(12207): pkgmgr-server.c: sighandler(387) > child exit [12222]
06-04 08:49:50.283+0900 E/PKGMGR_SERVER(12207): pkgmgr-server.c: sighandler(402) > child NORMAL exit [12222]
06-04 08:49:50.423+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 08:49:50.423+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 08:49:50.423+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 08:49:50.423+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 08:49:50.753+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 0
06-04 08:49:50.753+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-04 08:49:50.753+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 08:49:50.753+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 08:49:50.753+0900 I/AUL     ( 2753): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-04 08:49:50.753+0900 D/AUL     ( 2753): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 12275, pid = 12277
06-04 08:49:50.753+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 08:49:50.753+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 08:49:50.753+0900 I/AUL     ( 2753): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-04 08:49:50.753+0900 E/AUL_AMD ( 2753): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-04 08:49:50.753+0900 W/AUL_AMD ( 2753): amd_launch.c: _start_app(2233) > caller pid : 12277
06-04 08:49:50.753+0900 E/AUL_AMD ( 2753): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-04 08:49:50.753+0900 W/AUL_AMD ( 2753): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-04 08:49:50.753+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2648) > process_pool: false
06-04 08:49:50.753+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-04 08:49:50.753+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-04 08:49:50.753+0900 W/AUL_AMD ( 2753): amd_launch.c: _start_app(2665) > pad pid(-5)
06-04 08:49:50.753+0900 D/AUL_AMD ( 2753): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-04 08:49:50.753+0900 D/AUL_AMD ( 2753): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-04 08:49:50.753+0900 D/AUL     ( 2753): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-04 08:49:50.753+0900 W/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-04 08:49:50.753+0900 D/AUL     ( 2921): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 12117, bin path: /opt/usr/apps/org.example.example/bin/example
06-04 08:49:50.753+0900 W/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(265) > Check app launching
06-04 08:49:50.753+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-04 08:49:50.753+0900 D/RESOURCED( 2854): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-04 08:49:50.753+0900 D/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-04 08:49:50.753+0900 E/RESOURCED( 2854): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-04 08:49:50.753+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-04 08:49:50.753+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-04 08:49:50.763+0900 D/AUL     (12117): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (12119) is sent.
06-04 08:49:50.763+0900 D/AUL     (12117): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 12119, signo: 10
06-04 08:49:50.763+0900 D/AUL     (12117): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY1MzM3OTAvNzY0NjAzAA==##
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMjI3NwA=##
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-04 08:49:50.763+0900 D/AUL_PAD (12117): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-04 08:49:50.763+0900 I/CAPI_APPFW_APPLICATION(12117): app_main.c: ui_app_main(788) > app_efl_main
06-04 08:49:50.763+0900 D/LAUNCH  (12117): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-04 08:49:50.763+0900 D/APP_CORE(12117): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-04 08:49:50.763+0900 D/APP_CORE(12117): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-04 08:49:50.763+0900 D/APP_CORE(12117): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-04 08:49:50.763+0900 D/APP_CORE(12117): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-04 08:49:50.763+0900 D/AUL     (12117): app_sock.c: __create_server_sock(156) > pg path - already exists
06-04 08:49:50.763+0900 D/APP_CORE(12117): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42cd520
06-04 08:49:50.763+0900 D/LAUNCH  (12117): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-04 08:49:50.763+0900 I/CAPI_APPFW_APPLICATION(12117): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-04 08:49:50.793+0900 D/LAUNCH  (12117): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-04 08:49:50.803+0900 E/E17     ( 2783): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-04 08:49:50.803+0900 D/APP_CORE(12117): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-04 08:49:50.803+0900 E/E17     ( 2783): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-04 08:49:50.813+0900 D/APP_CORE(12117): appcore.c: __aul_handler(587) > [APP 12117]     AUL event: AUL_START
06-04 08:49:50.813+0900 I/APP_CORE(12117): appcore-efl.c: __do_app(496) > [APP 12117] Event: RESET State: CREATED
06-04 08:49:50.813+0900 D/APP_CORE(12117): appcore-efl.c: __do_app(527) > [APP 12117] RESET
06-04 08:49:50.813+0900 D/LAUNCH  (12117): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-04 08:49:50.813+0900 D/APP_CORE(12117): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-04 08:49:50.813+0900 D/APP_CORE(12117): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 08:49:50.813+0900 I/CAPI_APPFW_APPLICATION(12117): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 08:49:50.813+0900 D/AUL     (12117): service.c: __set_bundle(186) > __set_bundle
06-04 08:49:50.813+0900 D/LAUNCH  (12117): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 08:49:50.813+0900 D/APP_CORE(12117): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 08:49:50.813+0900 E/EFL     (12117): edje<12117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:49:50.813+0900 E/EFL     (12117): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:49:50.813+0900 E/EFL     (12117): edje<12117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:49:50.813+0900 E/EFL     (12117): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:49:50.813+0900 E/EFL     (12117): edje<12117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:49:50.813+0900 E/EFL     (12117): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:49:50.813+0900 E/EFL     (12117): edje<12117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:49:50.813+0900 E/EFL     (12117): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:49:50.813+0900 E/EFL     (12117): edje<12117> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:49:50.813+0900 E/EFL     (12117): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:49:50.813+0900 W/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12117
06-04 08:49:50.813+0900 W/APP_CORE(12117): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-04 08:49:50.813+0900 D/APP_CORE(12117): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-04 08:49:50.813+0900 D/APP_CORE(12117): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 08:49:50.813+0900 D/AUL     (12117): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 08:49:50.813+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 08:49:50.813+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 08:49:50.823+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 08:49:50.823+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 08:49:50.823+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 08:49:50.823+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 08:49:50.823+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 08:49:50.823+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-04 08:49:50.863+0900 D/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 08:49:50.863+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 12117, appid: org.example.example
06-04 08:49:50.863+0900 D/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 08:49:50.863+0900 E/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 08:49:50.863+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2700) > add app group info
06-04 08:49:50.863+0900 E/AUL     ( 2753): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 08:49:50.863+0900 D/AUL_AMD ( 2753): amd_status.c: _status_add_app_info_list(427) > pid(12117) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 08:49:50.863+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 12117
06-04 08:49:50.863+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 08:49:50.863+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 08:49:50.863+0900 E/RESOURCED( 2854): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 08:49:50.863+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(888) > available memory = 289
06-04 08:49:50.863+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 08:49:50.863+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 08:49:50.863+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 08:49:50.863+0900 D/AUL_AMD ( 2753): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12117 is org.example.example
06-04 08:49:50.863+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12117 : 0
06-04 08:49:50.863+0900 D/AUL     ( 2937): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 08:49:51.053+0900 D/APP_CORE(12117): appcore.c: __prt_ltime(236) > [APP 12117] first idle after reset: 304 msec
06-04 08:49:51.093+0900 E/E17     ( 2783): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 08:49:51.093+0900 D/APP_CORE( 2867): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 08:49:51.093+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 08:49:51.093+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 08:49:51.093+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: PAUSE State: RUNNING
06-04 08:49:51.093+0900 D/APP_CORE( 2867): appcore-efl.c: __do_app(565) > [APP 2867] PAUSE
06-04 08:49:51.093+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 08:49:51.093+0900 E/cluster-home( 2867): homescreen.cpp: OnPause(84) >  app pause
06-04 08:49:51.093+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 08:49:51.093+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 08:49:51.093+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 08:49:51.093+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 08:49:51.093+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(4)
06-04 08:49:51.103+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 08:49:51.103+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 08:49:51.103+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: bg
06-04 08:49:51.103+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2891) > pid(12117) status(3)
06-04 08:49:51.103+0900 D/AUL_AMD ( 2753): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 08:49:51.103+0900 W/AUL_AMD ( 2753): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 08:49:51.103+0900 W/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 08:49:51.103+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(12117) status(3)
06-04 08:49:51.103+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(12117) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 08:49:51.103+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 08:49:51.103+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12117, appid: org.example.example, status: fg
06-04 08:49:51.103+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12117
06-04 08:49:51.103+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12117, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 08:49:51.103+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12117
06-04 08:49:51.113+0900 D/DATA_PROVIDER_MASTER( 2924): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2867 is paused
06-04 08:49:51.113+0900 D/DATA_PROVIDER_MASTER( 2924): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 08:49:51.113+0900 I/CAPI_WIDGET_APPLICATION( 3018): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 08:49:51.113+0900 I/CAPI_WIDGET_APPLICATION( 3018): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 08:49:51.113+0900 W/AUL     ( 3018): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3018, appid: org.tizen.calendar.widget, status: bg
06-04 08:49:51.133+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12117, appname = org.example.example, pkgname = org.example.example
06-04 08:49:51.133+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12117, appname = org.example.example
06-04 08:49:51.133+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12117
06-04 08:49:51.133+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3018, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 08:49:51.133+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3018
06-04 08:49:51.133+0900 D/RESOURCED( 2854): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3018, appname = org.tizen.calendar.widget
06-04 08:49:51.133+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3018
06-04 08:49:51.133+0900 I/RESOURCED( 2854): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 08:49:51.133+0900 I/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 08:49:51.183+0900 D/APP_CORE(12117): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-04 08:49:51.183+0900 D/APP_CORE(12117): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 08:49:51.183+0900 D/APP_CORE(12117): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 08:49:51.183+0900 I/APP_CORE(12117): appcore-efl.c: __do_app(496) > [APP 12117] Event: RESUME State: CREATED
06-04 08:49:51.183+0900 D/LAUNCH  (12117): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 08:49:51.183+0900 D/APP_CORE(12117): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 08:49:51.183+0900 D/APP_CORE(12117): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 08:49:51.183+0900 D/APP_CORE(12117): appcore-efl.c: __do_app(607) > [APP 12117] RESUME
06-04 08:49:51.183+0900 I/APP_CORE(12117): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 08:49:51.183+0900 I/APP_CORE(12117): appcore-efl.c: __do_app(614) > [APP 12117] Initial Launching, call the resume_cb
06-04 08:49:51.183+0900 I/CAPI_APPFW_APPLICATION(12117): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 08:49:51.183+0900 D/LAUNCH  (12117): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 08:49:51.183+0900 D/LAUNCH  (12117): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 08:49:51.183+0900 D/APP_CORE(12117): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 08:49:51.183+0900 E/APP_CORE(12117): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 08:49:51.253+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2910) > pid(12117) status(0)
06-04 08:49:51.623+0900 D/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(442) > pid(11952)
06-04 08:49:51.623+0900 W/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 08:49:51.623+0900 D/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(442) > pid(11952)
06-04 08:49:51.623+0900 W/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 08:49:51.873+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 08:49:51.873+0900 D/AUL_PAD (12284): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 08:49:51.873+0900 D/AUL_PAD ( 2921): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 08:49:51.993+0900 E/PKGMGR_SERVER(12207): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 08:49:51.993+0900 E/PKGMGR_SERVER(12207): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 08:49:52.373+0900 D/AUL_AMD ( 2753): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 08:49:52.373+0900 D/RUA     ( 2753): rua.c: rua_add_history(179) > rua_add_history start
06-04 08:49:52.373+0900 D/RUA     ( 2753): rua.c: rua_add_history(247) > rua_add_history ok
06-04 08:49:52.893+0900 D/AUL_PAD (12284): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8ed7760
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preload.h: __preload_init(69) > get pre-initialization function
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preload.h: __preload_init(73) > get shutdown function
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8ed7a40
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8ed9640
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preload.h: __preload_init(69) > get pre-initialization function
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preload.h: __preload_init(73) > get shutdown function
06-04 08:49:52.893+0900 D/AUL_PAD (12284): preexec.h: __preexec_init(76) > preexec start
06-04 08:49:52.893+0900 D/AUL_PAD (12284): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 08:49:52.893+0900 D/AUL     (12284): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 08:49:52.893+0900 D/AUL     (12284): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 08:49:52.893+0900 D/AUL     (12284): process_pool.c: __connect_to_launchpad(132) > send(12284) : 4
06-04 08:49:52.893+0900 D/AUL     (12284): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 08:49:52.893+0900 D/AUL_PAD ( 2921): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 12284
06-04 08:49:52.963+0900 D/AUL_PAD (12284): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 08:49:52.963+0900 D/AUL_PAD (12284): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 08:49:52.963+0900 D/AUL_PAD (12284): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 08:49:52.963+0900 D/AUL_PAD (12284): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 08:49:56.113+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 08:49:56.113+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: MEM_FLUSH State: PAUSED
06-04 08:49:56.113+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 08:49:56.113+0900 D/APP_CORE( 2867): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2867
06-04 08:49:56.113+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 08:49:56.113+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2867
06-04 08:49:56.303+0900 I/user_tag0(12117): /opt/usr/apps/org.example.example/data/feeding.db
06-04 08:49:56.313+0900 I/tag     (12117): eonji~
06-04 08:49:56.353+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402e4b 
06-04 08:49:57.363+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-04 08:49:58.053+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402e4b 
06-04 08:49:58.153+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.153+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.213+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.213+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.213+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.213+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.223+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.223+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.223+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:58.233+0900 D/IMMODULE(12117): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 08:49:58.233+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 08:49:58.233+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:49:58.233+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 08:49:58.233+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:49:58.243+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 08:49:58.243+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:49:58.243+0900 D/ISF_QUERY(12117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 08:49:58.243+0900 D/ISF_QUERY(12117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:49:58.243+0900 D/ISF_QUERY(12117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:49:58.243+0900 D/ISF_QUERY(12117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:49:58.243+0900 D/ISF_QUERY(12117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:49:58.243+0900 D/ISF_QUERY(12117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:49:58.243+0900 D/ISF_QUERY(12117): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:49:58.243+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 08:49:58.243+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:49:58.253+0900 D/IMMODULE(12117): scim_panel_client.cpp: open_connection(162) > 
06-04 08:49:58.253+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 08:49:58.253+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:49:58.253+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 08:49:58.253+0900 D/ISF_SOCKET(12117): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:49:58.253+0900 D/IMMODULE(12117): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 08:49:59.773+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402e4b 
06-04 08:49:59.923+0900 I/tag     (12117): insert
06-04 08:49:59.923+0900 I/user_tag(12117): 08:49 AM
06-04 08:49:59.923+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:59.933+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:59.933+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:59.933+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:49:59.943+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:00.823+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 08:50:00.823+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 08:50:00.823+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 08:50:00.823+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 8:50 4 h"
06-04 08:50:00.823+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 8:50"
06-04 08:50:00.823+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 8&#x2236;50"
06-04 08:50:00.823+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146648477 Time: <font_size=33>8&#x2236;50</font_size> <font_size=32>AM</font_size></font>
06-04 08:50:01.713+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402e4b 
06-04 08:50:02.363+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x402e4b bd->visible=1
06-04 08:50:03.633+0900 I/user_tag0(12117): /opt/usr/apps/org.example.example/data/feeding.db
06-04 08:50:03.633+0900 I/tag     (12117): eonji~
06-04 08:50:03.633+0900 I/tag     (12117): 들어와!
06-04 08:50:03.633+0900 I/tag     (12117): 언지
06-04 08:50:03.633+0900 I/tag     (12117): 8 49
06-04 08:50:03.633+0900 E/EFL     (12117): eo<12117> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800a994f is not pointing to a valid object. Maybe it has already been freed.
06-04 08:50:03.633+0900 E/EFL     (12117): eo<12117> lib/eo/eo.c:485 _eo_do_internal() Obj (0x800a994f) is an invalid ref.
06-04 08:50:03.633+0900 I/tag     (12117): aa
06-04 08:50:03.633+0900 E/EFL     (12117): eo<12117> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8004502a is not pointing to a valid object. Maybe it has already been freed.
06-04 08:50:03.633+0900 E/EFL     (12117): eo<12117> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x8004502a) is an invalid ref.
06-04 08:50:03.713+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402e4b 
06-04 08:50:05.813+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 08:50:05.813+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 08:50:05.813+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 08:50:05.813+0900 E/INDICATOR( 2856): 
06-04 08:50:06.473+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402e4b 
06-04 08:50:06.613+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:06.613+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:06.653+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:06.653+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:06.653+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:06.663+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:06.663+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:06.663+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:06.663+0900 E/EFL     (12117): edje<12117> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:07.533+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402e4b 
06-04 08:50:07.733+0900 I/tag     (12117): insert
06-04 08:50:07.763+0900 W/CRASH_MANAGER(12289): worker.c: worker_job(1204) > 1112117657861149653380
