S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 17946
Date: 2017-05-31 18:44:17+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x3ff

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb770af84
ebp = 0xbfe761a8, esp = 0xbfe75c68
eax = 0x000003ff, ebx = 0xb6d8e000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6c589c7

Memory Information
MemTotal:      123 KB
MemFree:        24 KB
Buffers:         6 KB
Cached:     188412 KB
VmPeak:     121112 KB
VmSize:     115132 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       34064 KB
VmRSS:       27976 KB
VmData:      45232 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34624 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 17946 TID = 17946
17946 17947 18127 18128 18132 

Maps Information
b1804000 b180b000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b180e000 b1826000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1827000 b182e000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b182f000 b1833000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b08000 b2b12000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b18000 b2b24000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b25000 b2b46000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b4b000 b2b4c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b4d000 b2b52000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b53000 b2b54000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b55000 b2b57000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b58000 b2b5a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b5b000 b2b67000 r-xp /usr/lib/libdrm.so.2.4.0
b2b68000 b2b72000 r-xp /usr/lib/libtbm.so.1.0.0
b2b73000 b2b88000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b89000 b2b9b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b339d000 b33ce000 r-xp /usr/lib/libidn.so.11.5.44
b33cf000 b33f1000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33f2000 b3402000 r-xp /usr/lib/libcares.so.2.1.0
b3403000 b340c000 r-xp /usr/lib/libeventsystem.so.0.0.1
b340d000 b3416000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3417000 b348e000 r-xp /usr/lib/libcurl.so.4.3.0
b3490000 b34a2000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34a3000 b34c4000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34cb000 b34cc000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34cd000 b34ce000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34cf000 b34d2000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34d3000 b34d6000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35de000 b35e4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35e5000 b3729000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3739000 b373c000 r-xp /usr/lib/libdri2.so.0.0.0
b373d000 b373e000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b373f000 b3749000 r-xp /opt/usr/apps/org.example.example/bin/example
b374b000 b3784000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4187000 b4192000 r-xp /lib/libnss_files-2.20-2014.11.so
b4194000 b419f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41a1000 b41b8000 r-xp /lib/libnsl-2.20-2014.11.so
b41bc000 b41c4000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41c6000 b41ea000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41eb000 b41ec000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41ed000 b41f0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41f1000 b41f8000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41f9000 b4203000 r-xp /usr/lib/libsensord-share.so
b4204000 b4220000 r-xp /usr/lib/libsensor.so.1.2.0
b4222000 b422b000 r-xp /usr/lib/libappcore-common.so.1.1
b422e000 b4230000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4245000 b4247000 r-xp /usr/lib/libXau.so.6.0.0
b4248000 b426a000 r-xp /usr/lib/libxcb.so.1.1.0
b426c000 b4275000 r-xp /lib/libcrypt-2.20-2014.11.so
b429e000 b42a0000 r-xp /usr/lib/libiri.so
b42a1000 b42c7000 r-xp /lib/libexpat.so.1.5.2
b42c9000 b4334000 r-xp /usr/lib/libssl.so.1.0.0
b433a000 b4346000 r-xp /usr/lib/libethumb.so.1.13.0
b4347000 b434b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b434c000 b459d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b18000 b5b28000 r-xp /usr/lib/libXi.so.6.1.0
b5b29000 b5b2b000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b2c000 b5b32000 r-xp /usr/lib/libXtst.so.6.1.0
b5b33000 b5b3d000 r-xp /usr/lib/libXrender.so.1.3.0
b5b3e000 b5b47000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b49000 b5b4b000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b4c000 b5b51000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b52000 b5b64000 r-xp /usr/lib/libXext.so.6.4.0
b5b65000 b5b67000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b68000 b5b6a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b6c000 b5cae000 r-xp /usr/lib/libX11.so.6.3.0
b5cb2000 b5cbc000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cbd000 b5cd3000 r-xp /usr/lib/libudev.so.1.6.0
b5cd6000 b5cda000 r-xp /lib/libattr.so.1.1.0
b5cdb000 b5d0a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d0c000 b5d12000 r-xp /usr/lib/libffi.so.6.0.2
b5d13000 b5d36000 r-xp /lib/libz.so.1.2.8
b5d37000 b5d3a000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d3b000 b5e97000 r-xp /usr/lib/libxml2.so.2.9.2
b5e9d000 b5f84000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f91000 b5f94000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f95000 b5fb7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fb8000 b5fcc000 r-xp /lib/libresolv-2.20-2014.11.so
b5fd0000 b5ff4000 r-xp /usr/lib/liblzma.so.5.0.3
b5ff5000 b5ff7000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ff9000 b6003000 r-xp /usr/lib/libembryo.so.1.13.0
b6004000 b602d000 r-xp /usr/lib/libpng12.so.0.50.0
b602e000 b6077000 r-xp /usr/lib/libjpeg.so.8.0.2
b6088000 b608f000 r-xp /lib/librt-2.20-2014.11.so
b6091000 b60b0000 r-xp /usr/lib/libector.so.1.13.0
b60b3000 b60e0000 r-xp /usr/lib/liblua-5.1.so
b60e1000 b6171000 r-xp /usr/lib/libfreetype.so.6.11.3
b6175000 b61b3000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61b4000 b61ca000 r-xp /usr/lib/libfribidi.so.0.3.1
b61cb000 b6224000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6227000 b6272000 r-xp /lib/libm-2.20-2014.11.so
b6274000 b6286000 r-xp /usr/lib/libeio.so.1.13.0
b6287000 b628a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b628b000 b6291000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6292000 b62b5000 r-xp /usr/lib/libefreet.so.1.13.0
b62b8000 b62e3000 r-xp /usr/lib/libeldbus.so.1.13.0
b62e4000 b6318000 r-xp /usr/lib/libecore_con.so.1.13.0
b631a000 b6323000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6324000 b632d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b632e000 b6341000 r-xp /usr/lib/libeo.so.1.13.0
b6343000 b6356000 r-xp /usr/lib/libecore_input.so.1.13.0
b6357000 b635e000 r-xp /usr/lib/libecore_file.so.1.13.0
b635f000 b6382000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6383000 b63af000 r-xp /usr/lib/libeet.so.1.13.0
b63b8000 b6423000 r-xp /usr/lib/libeina.so.1.13.0
b6426000 b643d000 r-xp /usr/lib/libefl.so.1.13.0
b643f000 b65a6000 r-xp /usr/lib/libicuuc.so.51.1
b65b4000 b67c0000 r-xp /usr/lib/libicui18n.so.51.1
b67c8000 b6817000 r-xp /usr/lib/libecore_x.so.1.13.0
b6819000 b6833000 r-xp /lib/libgcc_s-4.9.so.1
b6835000 b6839000 r-xp /lib/libcap.so.2.21
b683a000 b6880000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6881000 b6888000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b688a000 b68dc000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68de000 b6a69000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a6e000 b6b3c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b3f000 b6b43000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b44000 b6b53000 r-xp /usr/lib/libvconf.so.0.2.45
b6b54000 b6b57000 r-xp /usr/lib/libvasum.so.0.3.1
b6b58000 b6b5b000 r-xp /usr/lib/libttrace.so.1.1
b6b5d000 b6b61000 r-xp /usr/lib/libiniparser.so.0
b6b62000 b6b92000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b93000 b6b9c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6b9d000 b6bc2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bc3000 b6bd3000 r-xp /usr/lib/libunwind.so.8.0.1
b6bdd000 b6d8b000 r-xp /lib/libc-2.20-2014.11.so
b6d93000 b6ed6000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ed8000 b6f30000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f31000 b6f65000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f68000 b703c000 r-xp /usr/lib/libedje.so.1.13.0
b703f000 b706b000 r-xp /usr/lib/libecore.so.1.13.0
b707c000 b72a2000 r-xp /usr/lib/libevas.so.1.13.0
b72ca000 b72e2000 r-xp /lib/libpthread-2.20-2014.11.so
b72e6000 b7660000 r-xp /usr/lib/libelementary.so.1.13.0
b7680000 b7684000 r-xp /usr/lib/libsmack.so.1.0.0
b7685000 b768e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b768f000 b7692000 r-xp /usr/lib/libdlog.so.0.0.0
b7693000 b7698000 r-xp /usr/lib/libbundle.so.0.1.22
b7699000 b769c000 r-xp /lib/libdl-2.20-2014.11.so
b769e000 b76c3000 r-xp /usr/lib/libaul.so.0.1.0
b76c6000 b76c8000 r-xp /usr/lib/libappsvc.so.0.1.0
b76c9000 b76ce000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76cf000 b76d6000 r-xp /usr/lib/libappcore-efl.so.1.1
b76d8000 b76dd000 r-xp /usr/lib/libsys-assert.so
b76e0000 b76e1000 r-xp [vdso]
b76e1000 b7703000 r-xp /lib/ld-2.20-2014.11.so
b7705000 b770d000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:17946)
Call Stack Count: 30
 0: strchrnul + 0x17 (0xb6c589c7) [/lib/libc.so.6] + 0x7b9c7
 1: vsprintf + 0x69 (0xb6c40889) [/lib/libc.so.6] + 0x63889
 2: (0xb7431d77) [/usr/lib/libelementary.so.1] + 0x14bd77
 3: (0xb7437216) [/usr/lib/libelementary.so.1] + 0x151216
 4: (0xb7437802) [/usr/lib/libelementary.so.1] + 0x151802
 5: (0xb7437f64) [/usr/lib/libelementary.so.1] + 0x151f64
 6: (0xb7438440) [/usr/lib/libelementary.so.1] + 0x152440
 7: (0xb74392d9) [/usr/lib/libelementary.so.1] + 0x1532d9
 8: elm_genlist_item_append + 0x1bb (0xb7440bcb) [/usr/lib/libelementary.so.1] + 0x15abcb
 9: popup_set_btn_clicked_cb + 0x20e (0xb37442de) [/opt/usr/apps/org.example.example/bin/example] + 0x52de
10: (0xb7105116) [/usr/lib/libevas.so.1] + 0x89116
11: (0xb633c319) [/usr/lib/libeo.so.1] + 0xe319
12: eo_event_callback_call + 0xb3 (0xb6339d63) [/usr/lib/libeo.so.1] + 0xbd63
13: evas_object_smart_callback_call + 0x75 (0xb71079e5) [/usr/lib/libevas.so.1] + 0x8b9e5
14: (0xb73b8404) [/usr/lib/libelementary.so.1] + 0xd2404
15: (0xb6febf39) [/usr/lib/libedje.so.1] + 0x83f39
16: (0xb6ff2a11) [/usr/lib/libedje.so.1] + 0x8aa11
17: (0xb6fecfdc) [/usr/lib/libedje.so.1] + 0x84fdc
18: (0xb6fed4cb) [/usr/lib/libedje.so.1] + 0x854cb
19: (0xb6fed68f) [/usr/lib/libedje.so.1] + 0x8568f
20: (0xb7052702) [/usr/lib/libecore.so.1] + 0x13702
21: (0xb704c055) [/usr/lib/libecore.so.1] + 0xd055
22: (0xb70551b9) [/usr/lib/libecore.so.1] + 0x161b9
23: ecore_main_loop_begin + 0x57 (0xb7055587) [/usr/lib/libecore.so.1] + 0x16587
24: elm_run + 0x2d (0xb74ae22d) [/usr/lib/libelementary.so.1] + 0x1c822d
25: appcore_efl_main + 0x4de (0xb76d2dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
26: ui_app_main + 0x140 (0xb76cbc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
27: main + 0x27e (0xb37460fe) [/opt/usr/apps/org.example.example/bin/example] + 0x70fe
28: (0xb7707148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7707148
29: __libc_start_main + 0xde (0xb6bf4e4e) [/lib/libc.so.6] + 0x17e4e
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
ackage_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-31 18:44:08.847+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
05-31 18:44:08.847+0900 I/AUL     ( 2765): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
05-31 18:44:08.847+0900 D/AUL     ( 2765): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 18121, pid = 18123
05-31 18:44:08.847+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-31 18:44:08.847+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
05-31 18:44:08.857+0900 I/AUL     ( 2765): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
05-31 18:44:08.857+0900 E/AUL_AMD ( 2765): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
05-31 18:44:08.857+0900 W/AUL_AMD ( 2765): amd_launch.c: _start_app(2233) > caller pid : 18123
05-31 18:44:08.857+0900 E/AUL_AMD ( 2765): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
05-31 18:44:08.857+0900 W/AUL_AMD ( 2765): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-31 18:44:08.857+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2648) > process_pool: false
05-31 18:44:08.857+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-31 18:44:08.857+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-31 18:44:08.857+0900 W/AUL_AMD ( 2765): amd_launch.c: _start_app(2665) > pad pid(-5)
05-31 18:44:08.857+0900 D/AUL_AMD ( 2765): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-31 18:44:08.857+0900 D/AUL_AMD ( 2765): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-31 18:44:08.857+0900 D/AUL     ( 2765): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-31 18:44:08.857+0900 W/AUL_PAD ( 2922): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-31 18:44:08.857+0900 D/RESOURCED( 2857): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-31 18:44:08.857+0900 D/RESOURCED( 2857): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 3
05-31 18:44:08.857+0900 D/AUL     ( 2922): process_pool.c: __send_pkt_raw_data(219) > send(11) : 624 / 624
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 17946, bin path: /opt/usr/apps/org.example.example/bin/example
05-31 18:44:08.857+0900 E/RESOURCED( 2857): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-31 18:44:08.857+0900 W/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(265) > Check app launching
05-31 18:44:08.857+0900 D/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-31 18:44:08.857+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-31 18:44:08.857+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
05-31 18:44:08.857+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-31 18:44:08.857+0900 D/AUL_PAD (17946): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-31 18:44:08.857+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-31 18:44:08.857+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-31 18:44:08.857+0900 D/AUL     (17946): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (17947) is sent.
05-31 18:44:08.857+0900 D/AUL     (17946): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 17947, signo: 10
05-31 18:44:08.867+0900 D/AUL     (17946): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYyMjM4NDgvODUzNjU1AA==##
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxODEyMwA=##
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-31 18:44:08.867+0900 D/AUL_PAD (17946): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-31 18:44:08.867+0900 I/CAPI_APPFW_APPLICATION(17946): app_main.c: ui_app_main(788) > app_efl_main
05-31 18:44:08.867+0900 D/LAUNCH  (17946): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-31 18:44:08.867+0900 D/APP_CORE(17946): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-31 18:44:08.867+0900 D/APP_CORE(17946): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-31 18:44:08.867+0900 D/APP_CORE(17946): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-31 18:44:08.887+0900 D/APP_CORE(17946): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-31 18:44:08.887+0900 D/AUL     (17946): app_sock.c: __create_server_sock(156) > pg path - already exists
05-31 18:44:08.887+0900 D/APP_CORE(17946): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb422b520
05-31 18:44:08.887+0900 D/LAUNCH  (17946): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-31 18:44:08.887+0900 I/CAPI_APPFW_APPLICATION(17946): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-31 18:44:08.957+0900 D/AUL_PAD ( 2922): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-31 18:44:08.957+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 17946, appid: org.example.example
05-31 18:44:08.957+0900 D/AUL     ( 2765): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-31 18:44:08.957+0900 E/AUL     ( 2765): simple_util.c: __trm_app_info_send_socket(330) > access
05-31 18:44:08.957+0900 D/AUL_AMD ( 2765): amd_launch.c: _start_app(2700) > add app group info
05-31 18:44:08.957+0900 E/AUL     ( 2765): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-31 18:44:08.957+0900 D/AUL_AMD ( 2765): amd_status.c: _status_add_app_info_list(427) > pid(17946) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-31 18:44:08.957+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 17946
05-31 18:44:08.957+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-31 18:44:08.957+0900 E/RESOURCED( 2857): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-31 18:44:08.967+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(888) > available memory = 315
05-31 18:44:09.027+0900 D/LAUNCH  (17946): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-31 18:44:09.027+0900 D/APP_CORE(17946): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-31 18:44:09.027+0900 E/E17     ( 2735): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02000002)
05-31 18:44:09.087+0900 E/E17     ( 2735): e_border.c: e_border_show(2088) > BD_SHOW(0x02000002)
05-31 18:44:09.097+0900 D/APP_CORE(17946): appcore.c: __aul_handler(587) > [APP 17946]     AUL event: AUL_START
05-31 18:44:09.097+0900 I/APP_CORE(17946): appcore-efl.c: __do_app(496) > [APP 17946] Event: RESET State: CREATED
05-31 18:44:09.097+0900 D/APP_CORE(17946): appcore-efl.c: __do_app(527) > [APP 17946] RESET
05-31 18:44:09.097+0900 D/LAUNCH  (17946): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-31 18:44:09.097+0900 D/APP_CORE(17946): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-31 18:44:09.097+0900 D/APP_CORE(17946): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-31 18:44:09.097+0900 I/CAPI_APPFW_APPLICATION(17946): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-31 18:44:09.097+0900 D/AUL     (17946): service.c: __set_bundle(186) > __set_bundle
05-31 18:44:09.097+0900 D/LAUNCH  (17946): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-31 18:44:09.097+0900 D/APP_CORE(17946): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-31 18:44:09.097+0900 E/EFL     (17946): edje<17946> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:44:09.097+0900 E/EFL     (17946): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:44:09.097+0900 E/EFL     (17946): edje<17946> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:44:09.097+0900 E/EFL     (17946): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:44:09.097+0900 E/EFL     (17946): edje<17946> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:44:09.097+0900 E/EFL     (17946): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:44:09.097+0900 E/EFL     (17946): edje<17946> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:44:09.097+0900 E/EFL     (17946): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:44:09.097+0900 E/EFL     (17946): edje<17946> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-31 18:44:09.097+0900 E/EFL     (17946): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:44:09.117+0900 W/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=17946
05-31 18:44:09.137+0900 W/APP_CORE(17946): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000002
05-31 18:44:09.137+0900 E/EFL     ( 2735): eo<2735> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 18:44:09.137+0900 D/APP_CORE(17946): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2000002
05-31 18:44:09.137+0900 D/APP_CORE(17946): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-31 18:44:09.137+0900 E/EFL     ( 2735): eo<2735> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 18:44:09.137+0900 D/AUL     (17946): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-31 18:44:09.137+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(838) > __request_handler: 34
05-31 18:44:09.157+0900 D/INDICATOR( 2861): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-31 18:44:09.157+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(838) > __request_handler: 15
05-31 18:44:09.157+0900 D/INDICATOR( 2861): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-31 18:44:09.157+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-31 18:44:09.157+0900 D/PKGMGR_INFO( 2765): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-31 18:44:09.157+0900 D/AUL_AMD ( 2765): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 17946 is org.example.example
05-31 18:44:09.157+0900 D/AUL_AMD ( 2765): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 17946 : 0
05-31 18:44:09.157+0900 D/INDICATOR( 2861): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-31 18:44:09.157+0900 D/INDICATOR( 2861): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-31 18:44:09.157+0900 D/INDICATOR( 2861): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-31 18:44:09.157+0900 D/INDICATOR( 2861): main.c: _rotate_window(252) > port :: hide more icon
05-31 18:44:09.167+0900 D/AUL     ( 2938): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-31 18:44:09.347+0900 D/APP_CORE(17946): appcore.c: __prt_ltime(236) > [APP 17946] first idle after reset: 507 msec
05-31 18:44:09.517+0900 E/E17     ( 2735): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-31 18:44:09.517+0900 D/APP_CORE(17946): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2000002 fully_obscured 0
05-31 18:44:09.517+0900 D/APP_CORE(17946): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-31 18:44:09.517+0900 D/APP_CORE(17946): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-31 18:44:09.517+0900 I/APP_CORE(17946): appcore-efl.c: __do_app(496) > [APP 17946] Event: RESUME State: CREATED
05-31 18:44:09.517+0900 D/LAUNCH  (17946): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-31 18:44:09.517+0900 D/APP_CORE(17946): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-31 18:44:09.517+0900 D/APP_CORE(17946): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-31 18:44:09.517+0900 D/APP_CORE(17946): appcore-efl.c: __do_app(607) > [APP 17946] RESUME
05-31 18:44:09.517+0900 D/APP_CORE( 2870): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-31 18:44:09.517+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-31 18:44:09.517+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-31 18:44:09.517+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: PAUSE State: RUNNING
05-31 18:44:09.517+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(565) > [APP 2870] PAUSE
05-31 18:44:09.517+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-31 18:44:09.517+0900 E/cluster-home( 2870): homescreen.cpp: OnPause(84) >  app pause
05-31 18:44:09.517+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-31 18:44:09.517+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppPause(923) >  END
05-31 18:44:09.517+0900 D/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-31 18:44:09.517+0900 E/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-31 18:44:09.517+0900 I/APP_CORE(17946): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-31 18:44:09.517+0900 I/APP_CORE(17946): appcore-efl.c: __do_app(614) > [APP 17946] Initial Launching, call the resume_cb
05-31 18:44:09.517+0900 I/CAPI_APPFW_APPLICATION(17946): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-31 18:44:09.517+0900 D/LAUNCH  (17946): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-31 18:44:09.517+0900 D/LAUNCH  (17946): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-31 18:44:09.517+0900 D/APP_CORE(17946): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-31 18:44:09.517+0900 E/APP_CORE(17946): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-31 18:44:09.527+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(4)
05-31 18:44:09.527+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-31 18:44:09.527+0900 D/AUL     ( 2765): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-31 18:44:09.527+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: bg
05-31 18:44:09.537+0900 D/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2891) > pid(17946) status(3)
05-31 18:44:09.537+0900 D/DATA_PROVIDER_MASTER( 2929): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2870 is paused
05-31 18:44:09.537+0900 D/DATA_PROVIDER_MASTER( 2929): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-31 18:44:09.537+0900 D/AUL_AMD ( 2765): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-31 18:44:09.537+0900 I/CAPI_WIDGET_APPLICATION( 3020): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-31 18:44:09.537+0900 I/CAPI_WIDGET_APPLICATION( 3020): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-31 18:44:09.537+0900 W/AUL     ( 3020): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3020, appid: org.tizen.calendar.widget, status: bg
05-31 18:44:09.537+0900 W/AUL_AMD ( 2765): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 18:44:09.537+0900 W/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-31 18:44:09.537+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(456) > pid(17946) status(3)
05-31 18:44:09.537+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(468) > pid(17946) appid(org.example.example) pkgid(org.example.example) status(3)
05-31 18:44:09.537+0900 D/AUL     ( 2765): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-31 18:44:09.537+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 17946, appid: org.example.example, status: fg
05-31 18:44:09.547+0900 D/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3020, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-31 18:44:09.547+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3020
05-31 18:44:09.547+0900 D/RESOURCED( 2857): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3020, appname = org.tizen.calendar.widget
05-31 18:44:09.547+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3020
05-31 18:44:09.547+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 17946
05-31 18:44:09.547+0900 D/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 17946, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-31 18:44:09.547+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 17946
05-31 18:44:09.627+0900 D/RESOURCED( 2857): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 17946, appname = org.example.example, pkgname = org.example.example
05-31 18:44:09.627+0900 D/RESOURCED( 2857): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 17946, appname = org.example.example
05-31 18:44:09.627+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 17946
05-31 18:44:09.627+0900 I/RESOURCED( 2857): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-31 18:44:09.627+0900 I/RESOURCED( 2857): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-31 18:44:09.687+0900 D/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2910) > pid(17946) status(0)
05-31 18:44:09.967+0900 D/AUL_PAD ( 2922): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-31 18:44:09.967+0900 D/AUL_PAD (18130): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-31 18:44:09.997+0900 E/PKGMGR_SERVER(17982): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-31 18:44:09.997+0900 E/PKGMGR_SERVER(17982): pkgmgr-server.c: main(2265) > package manager server terminated.
05-31 18:44:10.037+0900 D/AUL_PAD ( 2922): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-31 18:44:10.047+0900 E/RESOURCED( 2857): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1213
05-31 18:44:10.467+0900 D/AUL_AMD ( 2765): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-31 18:44:10.467+0900 D/RUA     ( 2765): rua.c: rua_add_history(179) > rua_add_history start
05-31 18:44:10.517+0900 D/RUA     ( 2765): rua.c: rua_add_history(247) > rua_add_history ok
05-31 18:44:10.657+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x403165 
05-31 18:44:11.057+0900 D/AUL_AMD ( 2765): amd_status.c: __app_terminate_timer_cb(442) > pid(17758)
05-31 18:44:11.057+0900 W/AUL_AMD ( 2765): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-31 18:44:11.057+0900 D/AUL_AMD ( 2765): amd_status.c: __app_terminate_timer_cb(442) > pid(17758)
05-31 18:44:11.057+0900 W/AUL_AMD ( 2765): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-31 18:44:11.057+0900 D/AUL_PAD (18130): launchpad_loader.c: main(588) > sleeping 1 sec...
05-31 18:44:11.057+0900 D/AUL_PAD (18130): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-31 18:44:11.057+0900 D/AUL_PAD (18130): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b9577760
05-31 18:44:11.057+0900 D/AUL_PAD (18130): preload.h: __preload_init(69) > get pre-initialization function
05-31 18:44:11.057+0900 D/AUL_PAD (18130): preload.h: __preload_init(73) > get shutdown function
05-31 18:44:11.057+0900 D/AUL_PAD (18130): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b9577a40
05-31 18:44:11.067+0900 D/AUL_PAD (18130): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b9579640
05-31 18:44:11.067+0900 D/AUL_PAD (18130): preload.h: __preload_init(69) > get pre-initialization function
05-31 18:44:11.067+0900 D/AUL_PAD (18130): preload.h: __preload_init(73) > get shutdown function
05-31 18:44:11.067+0900 D/AUL_PAD (18130): preexec.h: __preexec_init(76) > preexec start
05-31 18:44:11.067+0900 D/AUL_PAD (18130): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-31 18:44:11.067+0900 D/AUL     (18130): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-31 18:44:11.067+0900 D/AUL     (18130): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-31 18:44:11.067+0900 D/AUL     (18130): process_pool.c: __connect_to_launchpad(132) > send(18130) : 4
05-31 18:44:11.067+0900 D/AUL     (18130): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-31 18:44:11.077+0900 D/AUL_PAD ( 2922): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 18130
05-31 18:44:11.237+0900 D/AUL_PAD (18130): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-31 18:44:11.237+0900 D/AUL_PAD (18130): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-31 18:44:11.237+0900 D/AUL_PAD (18130): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-31 18:44:11.247+0900 D/AUL_PAD (18130): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-31 18:44:11.677+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-31 18:44:11.687+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x403165 
05-31 18:44:12.017+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x403165 
05-31 18:44:12.287+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.297+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.347+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.357+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.357+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.357+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.357+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.367+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.367+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:12.377+0900 D/IMMODULE(17946): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-31 18:44:12.377+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 18:44:12.377+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:44:12.387+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 18:44:12.387+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:44:12.457+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 18:44:12.457+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:44:12.467+0900 D/ISF_QUERY(17946): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-31 18:44:12.467+0900 D/ISF_QUERY(17946): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:44:12.467+0900 D/ISF_QUERY(17946): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:44:12.467+0900 D/ISF_QUERY(17946): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:44:12.467+0900 D/ISF_QUERY(17946): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:44:12.467+0900 D/ISF_QUERY(17946): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:44:12.477+0900 D/ISF_QUERY(17946): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 18:44:12.477+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 18:44:12.477+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:44:12.487+0900 D/IMMODULE(17946): scim_panel_client.cpp: open_connection(162) > 
05-31 18:44:12.487+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-panel-socket:0, example
05-31 18:44:12.487+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:44:12.497+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(515) > ppid:2922  trying connect() to local:/tmp/scim-panel-socket:0, example
05-31 18:44:12.507+0900 D/ISF_SOCKET(17946): scim_socket.cpp: connect(524) > connect() succeeded
05-31 18:44:12.517+0900 D/IMMODULE(17946): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-31 18:44:13.487+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x403165 
05-31 18:44:13.557+0900 E/EFL     (17946): edje<17946> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-31 18:44:13.557+0900 E/EFL     (17946): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:44:14.527+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
05-31 18:44:14.527+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: MEM_FLUSH State: PAUSED
05-31 18:44:14.527+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
05-31 18:44:14.527+0900 D/APP_CORE( 2870): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2870
05-31 18:44:14.527+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
05-31 18:44:14.527+0900 D/RESOURCED( 2857): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2870
05-31 18:44:14.917+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x403165 
05-31 18:44:16.257+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x403165 
05-31 18:44:16.347+0900 E/EFL     (17946): edje<17946> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-31 18:44:16.347+0900 E/EFL     (17946): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:44:16.677+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x403165 bd->visible=1
05-31 18:44:16.687+0900 I/user_tag(17946): SUN
05-31 18:44:16.687+0900 I/user_tag(17946): 설마
05-31 18:44:16.707+0900 E/CAPI_NETWORK_WIFI( 2861): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 18:44:16.707+0900 E/INDICATOR( 2861): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 18:44:16.707+0900 E/INDICATOR( 2861): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 18:44:16.707+0900 E/INDICATOR( 2861): 
05-31 18:44:17.487+0900 D/PROCESSMGR( 2735): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x403165 
05-31 18:44:17.567+0900 E/EFL     (17946): edje<17946> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-31 18:44:17.567+0900 E/EFL     (17946): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 18:44:17.927+0900 I/user_tag(17946): 06:44 PM
05-31 18:44:17.927+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:17.937+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:17.937+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:17.947+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:17.947+0900 E/EFL     (17946): edje<17946> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 18:44:17.957+0900 D/RESOURCED( 2857): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
05-31 18:44:17.957+0900 I/RESOURCED( 2857): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
05-31 18:44:17.957+0900 D/RESOURCED( 2857): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
05-31 18:44:17.957+0900 I/RESOURCED( 2857): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
05-31 18:44:18.017+0900 D/AUL_PAD ( 2922): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-31 18:44:18.017+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-31 18:44:18.017+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 18:44:18.017+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 18:44:18.017+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 18:44:18.017+0900 D/AUL_PAD ( 2922): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 18:44:18.017+0900 D/AUL_PAD ( 2922): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 18:44:18.017+0900 I/AUL_PAD ( 2922): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 17946 pgid = 17946
05-31 18:44:18.017+0900 I/AUL_PAD ( 2922): sigchild.h: __sigchild_action(142) > dead_pid(17946)
05-31 18:44:18.027+0900 E/EFL     ( 2735): eo<2735> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 18:44:18.047+0900 D/AUL_PAD ( 2922): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-31 18:44:18.047+0900 I/AUL_PAD ( 2922): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-31 18:44:18.047+0900 I/AUL_PAD ( 2922): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-31 18:44:18.047+0900 E/AUL_PAD ( 2922): launchpad.c: main(688) > error reading sigchld info
05-31 18:44:18.047+0900 I/ESD     ( 2935): esd_main.c: __esd_app_dead_handler(1771) > pid: 17946
05-31 18:44:18.047+0900 D/STARTER ( 2854): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 17946 is termianted
05-31 18:44:18.047+0900 D/STARTER ( 2854): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
05-31 18:44:18.047+0900 W/AUL_AMD ( 2765): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 17946
05-31 18:44:18.047+0900 W/AUL_AMD ( 2765): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 17946
05-31 18:44:18.047+0900 D/AUL_AMD ( 2765): amd_key.c: _unregister_key_event(179) > ===key stack===
05-31 18:44:18.047+0900 E/AUL_AMD ( 2765): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-31 18:44:18.047+0900 D/AUL_AMD ( 2765): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
05-31 18:44:18.047+0900 D/AUL     ( 2765): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-31 18:44:18.047+0900 E/AUL     ( 2765): simple_util.c: __trm_app_info_send_socket(330) > access
05-31 18:44:18.047+0900 E/RESOURCED( 2857): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1218
05-31 18:44:18.067+0900 D/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2891) > pid(2870) status(3)
05-31 18:44:18.067+0900 D/RESOURCED( 2857): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 17946
05-31 18:44:18.067+0900 D/RESOURCED( 2857): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 2
05-31 18:44:18.067+0900 D/AUL_AMD ( 2765): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-31 18:44:18.067+0900 W/AUL_AMD ( 2765): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-31 18:44:18.067+0900 W/AUL_AMD ( 2765): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-31 18:44:18.067+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(3)
05-31 18:44:18.067+0900 D/AUL_AMD ( 2765): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
05-31 18:44:18.067+0900 D/AUL     ( 2765): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
05-31 18:44:18.067+0900 W/AUL     ( 2765): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: fg
05-31 18:44:18.067+0900 D/RESOURCED( 2857): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2870
05-31 18:44:18.077+0900 D/RESOURCED( 2857): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2870, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
05-31 18:44:18.077+0900 D/RESOURCED( 2857): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2870, appname = org.tizen.homescreen
05-31 18:44:18.077+0900 D/RESOURCED( 2857): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2870
05-31 18:44:18.087+0900 E/E17     ( 2735): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
05-31 18:44:18.097+0900 W/CRASH_MANAGER(18133): worker.c: worker_job(1204) > 1117946657861149622385
