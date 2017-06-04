S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 12284
Date: 2017-06-04 08:50:53+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xbff23920
ebp = 0xbff23a38, esp = 0xbff238e0
eax = 0x00000021, ebx = 0xb37f3000
ecx = 0x00000000, edx = 0xbff2391c
eip = 0xb37ec99d

Memory Information
MemTotal:      123 KB
MemFree:        19 KB
Buffers:         8 KB
Cached:     169256 KB
VmPeak:     125500 KB
VmSize:     125500 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       38464 KB
VmRSS:       38464 KB
VmData:      55588 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12284 TID = 12284
12284 12287 12488 12489 12495 

Maps Information
b0ee6000 b0efe000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b180e000 b1815000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1818000 b181f000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b18d4000 b18d8000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2bad000 b2bb7000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bbd000 b2bc9000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bca000 b2beb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bf0000 b2bf1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bf2000 b2bf7000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bf8000 b2bf9000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bfa000 b2bfc000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bfd000 b2bff000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c00000 b2c0c000 r-xp /usr/lib/libdrm.so.2.4.0
b2c0d000 b2c10000 r-xp /usr/lib/libdri2.so.0.0.0
b2c11000 b2c1b000 r-xp /usr/lib/libtbm.so.1.0.0
b2c1c000 b2c31000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c32000 b2c44000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3446000 b3477000 r-xp /usr/lib/libidn.so.11.5.44
b3478000 b349a000 r-xp /usr/lib/libnghttp2.so.5.4.0
b349b000 b34ab000 r-xp /usr/lib/libcares.so.2.1.0
b34ac000 b34b5000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34b6000 b34bf000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34c0000 b3537000 r-xp /usr/lib/libcurl.so.4.3.0
b3539000 b354b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b354c000 b356d000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3574000 b3575000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3576000 b3577000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3578000 b357b000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b357c000 b357f000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3687000 b368d000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b368e000 b37d2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37e3000 b37e4000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37e5000 b37f2000 r-xp /opt/usr/apps/org.example.example/bin/example
b37f4000 b382d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4230000 b423b000 r-xp /lib/libnss_files-2.20-2014.11.so
b423d000 b4248000 r-xp /lib/libnss_nis-2.20-2014.11.so
b424a000 b4261000 r-xp /lib/libnsl-2.20-2014.11.so
b4265000 b426d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b426f000 b4293000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4294000 b4295000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4296000 b4299000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b429a000 b42a1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42a2000 b42ac000 r-xp /usr/lib/libsensord-share.so
b42ad000 b42c9000 r-xp /usr/lib/libsensor.so.1.2.0
b42cb000 b42d4000 r-xp /usr/lib/libappcore-common.so.1.1
b42d7000 b42d9000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42ee000 b42f0000 r-xp /usr/lib/libXau.so.6.0.0
b42f1000 b4313000 r-xp /usr/lib/libxcb.so.1.1.0
b4315000 b431e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4347000 b4349000 r-xp /usr/lib/libiri.so
b434a000 b4370000 r-xp /lib/libexpat.so.1.5.2
b4372000 b43dd000 r-xp /usr/lib/libssl.so.1.0.0
b43e3000 b43ef000 r-xp /usr/lib/libethumb.so.1.13.0
b43f0000 b43f4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43f5000 b4646000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bc1000 b5bd1000 r-xp /usr/lib/libXi.so.6.1.0
b5bd2000 b5bd4000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bd5000 b5bdb000 r-xp /usr/lib/libXtst.so.6.1.0
b5bdc000 b5be6000 r-xp /usr/lib/libXrender.so.1.3.0
b5be7000 b5bf0000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bf2000 b5bf4000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bf5000 b5bfa000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bfb000 b5c0d000 r-xp /usr/lib/libXext.so.6.4.0
b5c0e000 b5c10000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c11000 b5c13000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c15000 b5d57000 r-xp /usr/lib/libX11.so.6.3.0
b5d5b000 b5d65000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d66000 b5d7c000 r-xp /usr/lib/libudev.so.1.6.0
b5d7f000 b5d83000 r-xp /lib/libattr.so.1.1.0
b5d84000 b5db3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5db5000 b5dbb000 r-xp /usr/lib/libffi.so.6.0.2
b5dbc000 b5ddf000 r-xp /lib/libz.so.1.2.8
b5de0000 b5de3000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5de4000 b5f40000 r-xp /usr/lib/libxml2.so.2.9.2
b5f46000 b602d000 r-xp /usr/lib/libstdc++.so.6.0.20
b603a000 b603d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b603e000 b6060000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6061000 b6075000 r-xp /lib/libresolv-2.20-2014.11.so
b6079000 b609d000 r-xp /usr/lib/liblzma.so.5.0.3
b609e000 b60a0000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60a2000 b60ac000 r-xp /usr/lib/libembryo.so.1.13.0
b60ad000 b60d6000 r-xp /usr/lib/libpng12.so.0.50.0
b60d7000 b6120000 r-xp /usr/lib/libjpeg.so.8.0.2
b6131000 b6138000 r-xp /lib/librt-2.20-2014.11.so
b613a000 b6159000 r-xp /usr/lib/libector.so.1.13.0
b615c000 b6189000 r-xp /usr/lib/liblua-5.1.so
b618a000 b621a000 r-xp /usr/lib/libfreetype.so.6.11.3
b621e000 b625c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b625d000 b6273000 r-xp /usr/lib/libfribidi.so.0.3.1
b6274000 b62cd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62d0000 b631b000 r-xp /lib/libm-2.20-2014.11.so
b631d000 b632f000 r-xp /usr/lib/libeio.so.1.13.0
b6330000 b6333000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6334000 b633a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b633b000 b635e000 r-xp /usr/lib/libefreet.so.1.13.0
b6361000 b638c000 r-xp /usr/lib/libeldbus.so.1.13.0
b638d000 b63c1000 r-xp /usr/lib/libecore_con.so.1.13.0
b63c3000 b63cc000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63cd000 b63d6000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63d7000 b63ea000 r-xp /usr/lib/libeo.so.1.13.0
b63ec000 b63ff000 r-xp /usr/lib/libecore_input.so.1.13.0
b6400000 b6407000 r-xp /usr/lib/libecore_file.so.1.13.0
b6408000 b642b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b642c000 b6458000 r-xp /usr/lib/libeet.so.1.13.0
b6461000 b64cc000 r-xp /usr/lib/libeina.so.1.13.0
b64cf000 b64e6000 r-xp /usr/lib/libefl.so.1.13.0
b64e8000 b664f000 r-xp /usr/lib/libicuuc.so.51.1
b665d000 b6869000 r-xp /usr/lib/libicui18n.so.51.1
b6871000 b68c0000 r-xp /usr/lib/libecore_x.so.1.13.0
b68c2000 b68dc000 r-xp /lib/libgcc_s-4.9.so.1
b68de000 b68e2000 r-xp /lib/libcap.so.2.21
b68e3000 b6929000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b692a000 b6931000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6933000 b6985000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6987000 b6b12000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b17000 b6be5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6be8000 b6bec000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bed000 b6bfc000 r-xp /usr/lib/libvconf.so.0.2.45
b6bfd000 b6c00000 r-xp /usr/lib/libvasum.so.0.3.1
b6c01000 b6c04000 r-xp /usr/lib/libttrace.so.1.1
b6c06000 b6c0a000 r-xp /usr/lib/libiniparser.so.0
b6c0b000 b6c3b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c3c000 b6c45000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c46000 b6c6b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c6c000 b6c7c000 r-xp /usr/lib/libunwind.so.8.0.1
b6c86000 b6e34000 r-xp /lib/libc-2.20-2014.11.so
b6e3c000 b6f7f000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f81000 b6fd9000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fda000 b700e000 r-xp /usr/lib/libsystemd.so.0.4.0
b7011000 b70e5000 r-xp /usr/lib/libedje.so.1.13.0
b70e8000 b7114000 r-xp /usr/lib/libecore.so.1.13.0
b7125000 b734b000 r-xp /usr/lib/libevas.so.1.13.0
b7373000 b738b000 r-xp /lib/libpthread-2.20-2014.11.so
b738f000 b7709000 r-xp /usr/lib/libelementary.so.1.13.0
b7729000 b772d000 r-xp /usr/lib/libsmack.so.1.0.0
b772e000 b7737000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7738000 b773b000 r-xp /usr/lib/libdlog.so.0.0.0
b773c000 b7741000 r-xp /usr/lib/libbundle.so.0.1.22
b7742000 b7745000 r-xp /lib/libdl-2.20-2014.11.so
b7747000 b776c000 r-xp /usr/lib/libaul.so.0.1.0
b776f000 b7771000 r-xp /usr/lib/libappsvc.so.0.1.0
b7772000 b7777000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7778000 b777f000 r-xp /usr/lib/libappcore-efl.so.1.1
b7781000 b7786000 r-xp /usr/lib/libsys-assert.so
b7789000 b778a000 r-xp [vdso]
b778a000 b77ac000 r-xp /lib/ld-2.20-2014.11.so
b77ae000 b77b6000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12284)
Call Stack Count: 22
 0: InsertRecord + 0xbd (0xb37ec99d) [/opt/usr/apps/org.example.example/bin/example] + 0x799d
 1: popup_set_btn_clicked_cb + 0x11c (0xb37ebe7c) [/opt/usr/apps/org.example.example/bin/example] + 0x6e7c
 2: (0xb71ae116) [/usr/lib/libevas.so.1] + 0x89116
 3: (0xb63e5319) [/usr/lib/libeo.so.1] + 0xe319
 4: eo_event_callback_call + 0xb3 (0xb63e2d63) [/usr/lib/libeo.so.1] + 0xbd63
 5: evas_object_smart_callback_call + 0x75 (0xb71b09e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 6: (0xb7461404) [/usr/lib/libelementary.so.1] + 0xd2404
 7: (0xb7094f39) [/usr/lib/libedje.so.1] + 0x83f39
 8: (0xb709ba11) [/usr/lib/libedje.so.1] + 0x8aa11
 9: (0xb7095fdc) [/usr/lib/libedje.so.1] + 0x84fdc
10: (0xb70964cb) [/usr/lib/libedje.so.1] + 0x854cb
11: (0xb709668f) [/usr/lib/libedje.so.1] + 0x8568f
12: (0xb70fb702) [/usr/lib/libecore.so.1] + 0x13702
13: (0xb70f5055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70fe1b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb70fe587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb755722d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb777bdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb7774c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x296 (0xb37ed7d6) [/opt/usr/apps/org.example.example/bin/example] + 0x87d6
20: (0xb77b0148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77b0148
21: __libc_start_main + 0xde (0xb6c9de4e) [/lib/libc.so.6] + 0x17e4e
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
------
06-04 08:50:37.012+0900 D/PKGMGR_SERVER(12415): pkgmgr-server.c: sighandler(387) > child exit [12430]
06-04 08:50:37.012+0900 E/PKGMGR_SERVER(12415): pkgmgr-server.c: sighandler(402) > child NORMAL exit [12430]
06-04 08:50:37.392+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 0
06-04 08:50:37.392+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-04 08:50:37.392+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 08:50:37.392+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 08:50:37.392+0900 I/AUL     ( 2753): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-04 08:50:37.392+0900 D/AUL     ( 2753): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 12482, pid = 12484
06-04 08:50:37.392+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 08:50:37.392+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 08:50:37.392+0900 I/AUL     ( 2753): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-04 08:50:37.392+0900 E/AUL_AMD ( 2753): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-04 08:50:37.392+0900 W/AUL_AMD ( 2753): amd_launch.c: _start_app(2233) > caller pid : 12484
06-04 08:50:37.392+0900 E/AUL_AMD ( 2753): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-04 08:50:37.392+0900 W/AUL_AMD ( 2753): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-04 08:50:37.392+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2648) > process_pool: false
06-04 08:50:37.392+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-04 08:50:37.392+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-04 08:50:37.392+0900 W/AUL_AMD ( 2753): amd_launch.c: _start_app(2665) > pad pid(-5)
06-04 08:50:37.392+0900 D/AUL_AMD ( 2753): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-04 08:50:37.392+0900 D/AUL_AMD ( 2753): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-04 08:50:37.392+0900 D/AUL     ( 2753): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-04 08:50:37.392+0900 W/AUL_PAD ( 2921): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-04 08:50:37.392+0900 D/AUL     ( 2921): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 12284, bin path: /opt/usr/apps/org.example.example/bin/example
06-04 08:50:37.392+0900 W/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(265) > Check app launching
06-04 08:50:37.392+0900 D/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-04 08:50:37.392+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-04 08:50:37.392+0900 D/RESOURCED( 2854): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-04 08:50:37.392+0900 E/RESOURCED( 2854): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-04 08:50:37.392+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-04 08:50:37.392+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-04 08:50:37.392+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-04 08:50:37.392+0900 D/AUL_PAD (12284): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-04 08:50:37.392+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-04 08:50:37.392+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-04 08:50:37.392+0900 D/AUL     (12284): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (12287) is sent.
06-04 08:50:37.392+0900 D/AUL     (12284): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 12287, signo: 10
06-04 08:50:37.402+0900 D/AUL     (12284): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY1MzM4MzcvNDAyOTA4AA==##
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMjQ4NAA=##
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-04 08:50:37.402+0900 D/AUL_PAD (12284): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-04 08:50:37.402+0900 I/CAPI_APPFW_APPLICATION(12284): app_main.c: ui_app_main(788) > app_efl_main
06-04 08:50:37.402+0900 D/LAUNCH  (12284): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-04 08:50:37.402+0900 D/APP_CORE(12284): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-04 08:50:37.402+0900 D/APP_CORE(12284): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-04 08:50:37.402+0900 D/APP_CORE(12284): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-04 08:50:37.402+0900 D/APP_CORE(12284): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-04 08:50:37.412+0900 D/AUL     (12284): app_sock.c: __create_server_sock(156) > pg path - already exists
06-04 08:50:37.412+0900 D/APP_CORE(12284): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42d4520
06-04 08:50:37.412+0900 D/LAUNCH  (12284): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-04 08:50:37.412+0900 I/CAPI_APPFW_APPLICATION(12284): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-04 08:50:37.442+0900 D/LAUNCH  (12284): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-04 08:50:37.442+0900 E/E17     ( 2783): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02400002)
06-04 08:50:37.442+0900 D/APP_CORE(12284): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-04 08:50:37.452+0900 E/E17     ( 2783): e_border.c: e_border_show(2088) > BD_SHOW(0x02400002)
06-04 08:50:37.452+0900 D/APP_CORE(12284): appcore.c: __aul_handler(587) > [APP 12284]     AUL event: AUL_START
06-04 08:50:37.452+0900 I/APP_CORE(12284): appcore-efl.c: __do_app(496) > [APP 12284] Event: RESET State: CREATED
06-04 08:50:37.452+0900 D/APP_CORE(12284): appcore-efl.c: __do_app(527) > [APP 12284] RESET
06-04 08:50:37.452+0900 D/LAUNCH  (12284): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-04 08:50:37.452+0900 D/APP_CORE(12284): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-04 08:50:37.452+0900 D/APP_CORE(12284): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 08:50:37.452+0900 I/CAPI_APPFW_APPLICATION(12284): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 08:50:37.462+0900 D/AUL     (12284): service.c: __set_bundle(186) > __set_bundle
06-04 08:50:37.462+0900 D/LAUNCH  (12284): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 08:50:37.462+0900 D/APP_CORE(12284): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 08:50:37.462+0900 E/EFL     (12284): edje<12284> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:50:37.462+0900 E/EFL     (12284): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:50:37.462+0900 W/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12284
06-04 08:50:37.462+0900 E/EFL     (12284): edje<12284> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:50:37.462+0900 E/EFL     (12284): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:50:37.462+0900 E/EFL     (12284): edje<12284> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:50:37.462+0900 E/EFL     (12284): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:50:37.462+0900 E/EFL     (12284): edje<12284> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:50:37.462+0900 E/EFL     (12284): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:50:37.462+0900 E/EFL     (12284): edje<12284> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 08:50:37.462+0900 E/EFL     (12284): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:50:37.462+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 08:50:37.462+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 08:50:37.472+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 08:50:37.472+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 08:50:37.472+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 08:50:37.472+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 08:50:37.472+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 08:50:37.472+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-04 08:50:37.482+0900 W/APP_CORE(12284): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2400002
06-04 08:50:37.482+0900 D/APP_CORE(12284): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2400002
06-04 08:50:37.482+0900 D/APP_CORE(12284): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 08:50:37.482+0900 D/AUL     (12284): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 08:50:37.492+0900 D/AUL_PAD ( 2921): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 08:50:37.492+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 12284, appid: org.example.example
06-04 08:50:37.492+0900 D/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 08:50:37.492+0900 E/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 08:50:37.492+0900 D/AUL_AMD ( 2753): amd_launch.c: _start_app(2700) > add app group info
06-04 08:50:37.492+0900 E/AUL     ( 2753): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 08:50:37.492+0900 D/AUL_AMD ( 2753): amd_status.c: _status_add_app_info_list(427) > pid(12284) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 08:50:37.492+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 08:50:37.492+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 08:50:37.492+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 08:50:37.502+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 12284
06-04 08:50:37.502+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 08:50:37.502+0900 E/RESOURCED( 2854): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 08:50:37.502+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(888) > available memory = 289
06-04 08:50:37.502+0900 D/AUL_AMD ( 2753): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12284 is org.example.example
06-04 08:50:37.502+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12284 : 0
06-04 08:50:37.502+0900 D/AUL     ( 2937): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 08:50:37.502+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 08:50:37.752+0900 D/APP_CORE(12284): appcore.c: __prt_ltime(236) > [APP 12284] first idle after reset: 359 msec
06-04 08:50:37.802+0900 E/E17     ( 2783): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 08:50:37.802+0900 D/APP_CORE( 2867): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 08:50:37.802+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 08:50:37.802+0900 D/APP_CORE( 2867): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 08:50:37.802+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: PAUSE State: RUNNING
06-04 08:50:37.802+0900 D/APP_CORE( 2867): appcore-efl.c: __do_app(565) > [APP 2867] PAUSE
06-04 08:50:37.802+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 08:50:37.802+0900 E/cluster-home( 2867): homescreen.cpp: OnPause(84) >  app pause
06-04 08:50:37.802+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 08:50:37.802+0900 D/cluster-view( 2867): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 08:50:37.802+0900 D/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 08:50:37.802+0900 E/APP_CORE( 2867): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 08:50:37.802+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(2867) status(4)
06-04 08:50:37.802+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(2867) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 08:50:37.802+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 08:50:37.802+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2867, appid: org.tizen.homescreen, status: bg
06-04 08:50:37.802+0900 D/APP_CORE(12284): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2400002 fully_obscured 0
06-04 08:50:37.802+0900 D/APP_CORE(12284): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 08:50:37.802+0900 D/APP_CORE(12284): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 08:50:37.802+0900 I/APP_CORE(12284): appcore-efl.c: __do_app(496) > [APP 12284] Event: RESUME State: CREATED
06-04 08:50:37.812+0900 D/LAUNCH  (12284): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 08:50:37.812+0900 D/APP_CORE(12284): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 08:50:37.812+0900 D/APP_CORE(12284): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 08:50:37.812+0900 D/APP_CORE(12284): appcore-efl.c: __do_app(607) > [APP 12284] RESUME
06-04 08:50:37.812+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2891) > pid(12284) status(3)
06-04 08:50:37.812+0900 D/AUL_AMD ( 2753): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 08:50:37.812+0900 W/AUL_AMD ( 2753): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 08:50:37.812+0900 W/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 08:50:37.812+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(12284) status(3)
06-04 08:50:37.812+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(12284) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 08:50:37.812+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 08:50:37.812+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12284, appid: org.example.example, status: fg
06-04 08:50:37.812+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12284
06-04 08:50:37.812+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12284, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 08:50:37.812+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12284
06-04 08:50:37.812+0900 I/APP_CORE(12284): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 08:50:37.812+0900 I/APP_CORE(12284): appcore-efl.c: __do_app(614) > [APP 12284] Initial Launching, call the resume_cb
06-04 08:50:37.812+0900 I/CAPI_APPFW_APPLICATION(12284): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 08:50:37.812+0900 D/LAUNCH  (12284): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 08:50:37.812+0900 D/LAUNCH  (12284): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 08:50:37.812+0900 D/APP_CORE(12284): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 08:50:37.812+0900 E/APP_CORE(12284): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 08:50:37.812+0900 D/DATA_PROVIDER_MASTER( 2924): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2867 is paused
06-04 08:50:37.812+0900 D/DATA_PROVIDER_MASTER( 2924): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 08:50:37.862+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12284, appname = org.example.example, pkgname = org.example.example
06-04 08:50:37.862+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12284, appname = org.example.example
06-04 08:50:37.862+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12284
06-04 08:50:37.862+0900 I/RESOURCED( 2854): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 08:50:37.862+0900 I/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 08:50:37.922+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2910) > pid(12284) status(0)
06-04 08:50:38.512+0900 D/AUL_PAD ( 2921): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 08:50:38.512+0900 D/AUL_PAD (12491): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 08:50:38.512+0900 D/AUL_PAD ( 2921): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 08:50:38.512+0900 E/RESOURCED( 2854): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1097
06-04 08:50:39.002+0900 E/PKGMGR_SERVER(12415): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 08:50:39.002+0900 E/PKGMGR_SERVER(12415): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 08:50:39.002+0900 D/AUL_AMD ( 2753): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 08:50:39.002+0900 D/RUA     ( 2753): rua.c: rua_add_history(179) > rua_add_history start
06-04 08:50:39.002+0900 D/RUA     ( 2753): rua.c: rua_add_history(247) > rua_add_history ok
06-04 08:50:39.542+0900 D/AUL_PAD (12491): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7e66760
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preload.h: __preload_init(69) > get pre-initialization function
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preload.h: __preload_init(73) > get shutdown function
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7e66a40
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7e68640
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preload.h: __preload_init(69) > get pre-initialization function
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preload.h: __preload_init(73) > get shutdown function
06-04 08:50:39.542+0900 D/AUL_PAD (12491): preexec.h: __preexec_init(76) > preexec start
06-04 08:50:39.542+0900 D/AUL_PAD (12491): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 08:50:39.542+0900 D/AUL     (12491): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 08:50:39.542+0900 D/AUL     (12491): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 08:50:39.542+0900 D/AUL     (12491): process_pool.c: __connect_to_launchpad(132) > send(12491) : 4
06-04 08:50:39.552+0900 D/AUL     (12491): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 08:50:39.552+0900 D/AUL_PAD ( 2921): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 12491
06-04 08:50:39.552+0900 E/RESOURCED( 2854): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1098
06-04 08:50:39.602+0900 D/AUL_PAD (12491): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 08:50:39.612+0900 D/AUL_PAD (12491): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 08:50:39.612+0900 D/AUL_PAD (12491): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 08:50:39.612+0900 D/AUL_PAD (12491): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 08:50:42.172+0900 I/user_tag0(12284): /opt/usr/apps/org.example.example/data/feeding.db
06-04 08:50:42.172+0900 I/tag     (12284): eonji~
06-04 08:50:42.232+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:42.812+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 08:50:42.812+0900 I/APP_CORE( 2867): appcore-efl.c: __do_app(496) > [APP 2867] Event: MEM_FLUSH State: PAUSED
06-04 08:50:42.812+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 08:50:42.812+0900 D/APP_CORE( 2867): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2867
06-04 08:50:42.812+0900 D/APP_CORE( 2867): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 08:50:42.812+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2867
06-04 08:50:43.022+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:43.132+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.142+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.182+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:43.202+0900 D/IMMODULE(12284): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 08:50:43.202+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 08:50:43.202+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:50:43.202+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 08:50:43.202+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:50:43.212+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 08:50:43.212+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:50:43.212+0900 D/ISF_QUERY(12284): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 08:50:43.212+0900 D/ISF_QUERY(12284): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:50:43.212+0900 D/ISF_QUERY(12284): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:50:43.212+0900 D/ISF_QUERY(12284): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:50:43.212+0900 D/ISF_QUERY(12284): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:50:43.212+0900 D/ISF_QUERY(12284): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:50:43.212+0900 D/ISF_QUERY(12284): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 08:50:43.222+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 08:50:43.222+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:50:43.222+0900 D/IMMODULE(12284): scim_panel_client.cpp: open_connection(162) > 
06-04 08:50:43.222+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 08:50:43.222+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:50:43.222+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 08:50:43.222+0900 D/ISF_SOCKET(12284): scim_socket.cpp: connect(524) > connect() succeeded
06-04 08:50:43.222+0900 D/IMMODULE(12284): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 08:50:44.022+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:44.182+0900 I/tag     (12284): insert
06-04 08:50:44.182+0900 I/user_tag(12284): 08:50 AM
06-04 08:50:44.182+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:44.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:44.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:44.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:44.192+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:45.032+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 08:50:45.242+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:45.832+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 08:50:45.832+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 08:50:45.832+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 08:50:45.832+0900 E/INDICATOR( 2856): 
06-04 08:50:46.032+0900 I/user_tag0(12284): /opt/usr/apps/org.example.example/data/feeding.db
06-04 08:50:46.032+0900 I/tag     (12284): eonji~
06-04 08:50:46.032+0900 I/tag     (12284): 들어와!
06-04 08:50:46.032+0900 I/tag     (12284): 언지
06-04 08:50:46.032+0900 I/tag     (12284): 8 50
06-04 08:50:46.032+0900 E/EFL     (12284): eo<12284> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800a9b50 is not pointing to a valid object. Maybe it has already been freed.
06-04 08:50:46.032+0900 E/EFL     (12284): eo<12284> lib/eo/eo.c:485 _eo_do_internal() Obj (0x800a9b50) is an invalid ref.
06-04 08:50:46.042+0900 I/tag     (12284): aa
06-04 08:50:46.042+0900 E/EFL     (12284): eo<12284> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8004522b is not pointing to a valid object. Maybe it has already been freed.
06-04 08:50:46.042+0900 E/EFL     (12284): eo<12284> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x8004522b) is an invalid ref.
06-04 08:50:46.082+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:47.142+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:47.212+0900 I/tag     (12284): make!
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elc_popup.c:1915 elm_popup_add() safety check failed: parent == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_label.c:947 elm_label_add() safety check failed: parent == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_main.c:1218 elm_object_part_text_set() safety check failed: obj == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_main.c:1265 elm_object_part_content_set() safety check failed: obj == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_button.c:339 elm_button_add() safety check failed: parent == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_button.c:339 elm_button_add() safety check failed: parent == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_main.c:1287 elm_object_style_set() safety check failed: obj == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_main.c:1218 elm_object_part_text_set() safety check failed: obj == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_main.c:1265 elm_object_part_content_set() safety check failed: obj == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_main.c:1287 elm_object_style_set() safety check failed: obj == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_main.c:1218 elm_object_part_text_set() safety check failed: obj == NULL
06-04 08:50:47.212+0900 E/EFL     (12284): <12284> elm_main.c:1265 elm_object_part_content_set() safety check failed: obj == NULL
06-04 08:50:47.212+0900 E/efl-extension(12284): eext_events.c: _eext_key_grab_obj_create(299) > Failed to grab BACK KEY
06-04 08:50:47.212+0900 E/efl-extension(12284): eext_events.c: _eext_key_grab_obj_create(302) > Failed to grab MENU KEY
06-04 08:50:50.032+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x402f3f bd->visible=1
06-04 08:50:50.092+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:50.292+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.292+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.332+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.332+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.332+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.342+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.342+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.342+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.342+0900 E/EFL     (12284): edje<12284> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 08:50:50.462+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 08:50:50.462+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 08:50:50.462+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 08:50:50.462+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 08:50:51.822+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:51.922+0900 E/EFL     (12284): edje<12284> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-04 08:50:51.922+0900 E/EFL     (12284): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 08:50:52.962+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x402f3f 
06-04 08:50:53.172+0900 I/tag     (12284): insert
06-04 08:50:53.202+0900 W/CRASH_MANAGER(12496): worker.c: worker_job(1204) > 1112284657861149653385
