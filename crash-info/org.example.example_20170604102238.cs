S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 7213
Date: 2017-06-04 10:22:38+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x100

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb7748f84
ebp = 0xbff65d18, esp = 0xbff657d8
eax = 0x00000100, ebx = 0xb6dcc000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6c96a13

Memory Information
MemTotal:      123 KB
MemFree:        24 KB
Buffers:         7 KB
Cached:     183508 KB
VmPeak:     122140 KB
VmSize:     118200 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35096 KB
VmRSS:       31084 KB
VmData:      48288 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7213 TID = 7213
7213 7215 7375 7376 7380 

Maps Information
b1808000 b180f000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1812000 b182a000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b182b000 b1832000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1869000 b186d000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b42000 b2b4c000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b52000 b2b5e000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b5f000 b2b80000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b85000 b2b86000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b87000 b2b8c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b8d000 b2b8e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b8f000 b2b91000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b92000 b2b94000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b95000 b2ba1000 r-xp /usr/lib/libdrm.so.2.4.0
b2ba2000 b2ba5000 r-xp /usr/lib/libdri2.so.0.0.0
b2ba6000 b2bb0000 r-xp /usr/lib/libtbm.so.1.0.0
b2bb1000 b2bc6000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bc7000 b2bd9000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33db000 b340c000 r-xp /usr/lib/libidn.so.11.5.44
b340d000 b342f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3430000 b3440000 r-xp /usr/lib/libcares.so.2.1.0
b3441000 b344a000 r-xp /usr/lib/libeventsystem.so.0.0.1
b344b000 b3454000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3455000 b34cc000 r-xp /usr/lib/libcurl.so.4.3.0
b34ce000 b34e0000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34e1000 b3502000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3509000 b350a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b350b000 b350c000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b350d000 b3510000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3511000 b3514000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b361c000 b3622000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3623000 b3767000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3778000 b3779000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b377a000 b3787000 r-xp /opt/usr/apps/org.example.example/bin/example
b3789000 b37c2000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41c5000 b41d0000 r-xp /lib/libnss_files-2.20-2014.11.so
b41d2000 b41dd000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41df000 b41f6000 r-xp /lib/libnsl-2.20-2014.11.so
b41fa000 b4202000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4204000 b4228000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4229000 b422a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b422b000 b422e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b422f000 b4236000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4237000 b4241000 r-xp /usr/lib/libsensord-share.so
b4242000 b425e000 r-xp /usr/lib/libsensor.so.1.2.0
b4260000 b4269000 r-xp /usr/lib/libappcore-common.so.1.1
b426c000 b426e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4283000 b4285000 r-xp /usr/lib/libXau.so.6.0.0
b4286000 b42a8000 r-xp /usr/lib/libxcb.so.1.1.0
b42aa000 b42b3000 r-xp /lib/libcrypt-2.20-2014.11.so
b42dc000 b42de000 r-xp /usr/lib/libiri.so
b42df000 b4305000 r-xp /lib/libexpat.so.1.5.2
b4307000 b4372000 r-xp /usr/lib/libssl.so.1.0.0
b4378000 b4384000 r-xp /usr/lib/libethumb.so.1.13.0
b4385000 b4389000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b438a000 b45db000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b56000 b5b66000 r-xp /usr/lib/libXi.so.6.1.0
b5b67000 b5b69000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b6a000 b5b70000 r-xp /usr/lib/libXtst.so.6.1.0
b5b71000 b5b7b000 r-xp /usr/lib/libXrender.so.1.3.0
b5b7c000 b5b85000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b87000 b5b89000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b8a000 b5b8f000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b90000 b5ba2000 r-xp /usr/lib/libXext.so.6.4.0
b5ba3000 b5ba5000 r-xp /usr/lib/libXdamage.so.1.1.0
b5ba6000 b5ba8000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5baa000 b5cec000 r-xp /usr/lib/libX11.so.6.3.0
b5cf0000 b5cfa000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cfb000 b5d11000 r-xp /usr/lib/libudev.so.1.6.0
b5d14000 b5d18000 r-xp /lib/libattr.so.1.1.0
b5d19000 b5d48000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d4a000 b5d50000 r-xp /usr/lib/libffi.so.6.0.2
b5d51000 b5d74000 r-xp /lib/libz.so.1.2.8
b5d75000 b5d78000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d79000 b5ed5000 r-xp /usr/lib/libxml2.so.2.9.2
b5edb000 b5fc2000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fcf000 b5fd2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fd3000 b5ff5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ff6000 b600a000 r-xp /lib/libresolv-2.20-2014.11.so
b600e000 b6032000 r-xp /usr/lib/liblzma.so.5.0.3
b6033000 b6035000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6037000 b6041000 r-xp /usr/lib/libembryo.so.1.13.0
b6042000 b606b000 r-xp /usr/lib/libpng12.so.0.50.0
b606c000 b60b5000 r-xp /usr/lib/libjpeg.so.8.0.2
b60c6000 b60cd000 r-xp /lib/librt-2.20-2014.11.so
b60cf000 b60ee000 r-xp /usr/lib/libector.so.1.13.0
b60f1000 b611e000 r-xp /usr/lib/liblua-5.1.so
b611f000 b61af000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b3000 b61f1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61f2000 b6208000 r-xp /usr/lib/libfribidi.so.0.3.1
b6209000 b6262000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6265000 b62b0000 r-xp /lib/libm-2.20-2014.11.so
b62b2000 b62c4000 r-xp /usr/lib/libeio.so.1.13.0
b62c5000 b62c8000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62c9000 b62cf000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62d0000 b62f3000 r-xp /usr/lib/libefreet.so.1.13.0
b62f6000 b6321000 r-xp /usr/lib/libeldbus.so.1.13.0
b6322000 b6356000 r-xp /usr/lib/libecore_con.so.1.13.0
b6358000 b6361000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6362000 b636b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b636c000 b637f000 r-xp /usr/lib/libeo.so.1.13.0
b6381000 b6394000 r-xp /usr/lib/libecore_input.so.1.13.0
b6395000 b639c000 r-xp /usr/lib/libecore_file.so.1.13.0
b639d000 b63c0000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63c1000 b63ed000 r-xp /usr/lib/libeet.so.1.13.0
b63f6000 b6461000 r-xp /usr/lib/libeina.so.1.13.0
b6464000 b647b000 r-xp /usr/lib/libefl.so.1.13.0
b647d000 b65e4000 r-xp /usr/lib/libicuuc.so.51.1
b65f2000 b67fe000 r-xp /usr/lib/libicui18n.so.51.1
b6806000 b6855000 r-xp /usr/lib/libecore_x.so.1.13.0
b6857000 b6871000 r-xp /lib/libgcc_s-4.9.so.1
b6873000 b6877000 r-xp /lib/libcap.so.2.21
b6878000 b68be000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68bf000 b68c6000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68c8000 b691a000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b691c000 b6aa7000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6aac000 b6b7a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b7d000 b6b81000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b82000 b6b91000 r-xp /usr/lib/libvconf.so.0.2.45
b6b92000 b6b95000 r-xp /usr/lib/libvasum.so.0.3.1
b6b96000 b6b99000 r-xp /usr/lib/libttrace.so.1.1
b6b9b000 b6b9f000 r-xp /usr/lib/libiniparser.so.0
b6ba0000 b6bd0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bd1000 b6bda000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bdb000 b6c00000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c01000 b6c11000 r-xp /usr/lib/libunwind.so.8.0.1
b6c1b000 b6dc9000 r-xp /lib/libc-2.20-2014.11.so
b6dd1000 b6f14000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f16000 b6f6e000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f6f000 b6fa3000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fa6000 b707a000 r-xp /usr/lib/libedje.so.1.13.0
b707d000 b70a9000 r-xp /usr/lib/libecore.so.1.13.0
b70ba000 b72e0000 r-xp /usr/lib/libevas.so.1.13.0
b7308000 b7320000 r-xp /lib/libpthread-2.20-2014.11.so
b7324000 b769e000 r-xp /usr/lib/libelementary.so.1.13.0
b76be000 b76c2000 r-xp /usr/lib/libsmack.so.1.0.0
b76c3000 b76cc000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76cd000 b76d0000 r-xp /usr/lib/libdlog.so.0.0.0
b76d1000 b76d6000 r-xp /usr/lib/libbundle.so.0.1.22
b76d7000 b76da000 r-xp /lib/libdl-2.20-2014.11.so
b76dc000 b7701000 r-xp /usr/lib/libaul.so.0.1.0
b7704000 b7706000 r-xp /usr/lib/libappsvc.so.0.1.0
b7707000 b770c000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b770d000 b7714000 r-xp /usr/lib/libappcore-efl.so.1.1
b7716000 b771b000 r-xp /usr/lib/libsys-assert.so
b771e000 b771f000 r-xp [vdso]
b771f000 b7741000 r-xp /lib/ld-2.20-2014.11.so
b7743000 b774b000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:7213)
Call Stack Count: 25
 0: strchrnul + 0x63 (0xb6c96a13) [/lib/libc.so.6] + 0x7ba13
 1: vsprintf + 0x69 (0xb6c7e889) [/lib/libc.so.6] + 0x63889
 2: db_read_cb + 0x1ce (0xb377fc0e) [/opt/usr/apps/org.example.example/bin/example] + 0x5c0e
 3: sqlite3_exec + 0x27b (0xb6b2b04b) [/usr/lib/libsqlite3.so.0] + 0x7f04b
 4: read_db + 0xa3 (0xb377fa23) [/opt/usr/apps/org.example.example/bin/example] + 0x5a23
 5: init_db + 0x16f (0xb377f50f) [/opt/usr/apps/org.example.example/bin/example] + 0x550f
 6: create_button_view + 0x411 (0xb377f211) [/opt/usr/apps/org.example.example/bin/example] + 0x5211
 7: feeding_view_cb + 0x64 (0xb377ed24) [/opt/usr/apps/org.example.example/bin/example] + 0x4d24
 8: (0xb70ee449) [/usr/lib/libevas.so.1] + 0x34449
 9: (0xb637a319) [/usr/lib/libeo.so.1] + 0xe319
10: eo_event_callback_call + 0xb3 (0xb6377d63) [/usr/lib/libeo.so.1] + 0xbd63
11: (0xb70eea62) [/usr/lib/libevas.so.1] + 0x34a62
12: (0xb70fd441) [/usr/lib/libevas.so.1] + 0x43441
13: evas_canvas_event_feed_mouse_down + 0xcf (0xb710720f) [/usr/lib/libevas.so.1] + 0x4d20f
14: evas_event_feed_mouse_down + 0x6a (0xb710dc2a) [/usr/lib/libevas.so.1] + 0x53c2a
15: (0xb438749c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
16: (0xb708a055) [/usr/lib/libecore.so.1] + 0xd055
17: (0xb70931b9) [/usr/lib/libecore.so.1] + 0x161b9
18: ecore_main_loop_begin + 0x57 (0xb7093587) [/usr/lib/libecore.so.1] + 0x16587
19: elm_run + 0x2d (0xb74ec22d) [/usr/lib/libelementary.so.1] + 0x1c822d
20: appcore_efl_main + 0x4de (0xb7710dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
21: ui_app_main + 0x140 (0xb7709c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
22: main + 0x296 (0xb3782856) [/opt/usr/apps/org.example.example/bin/example] + 0x8856
23: (0xb7745148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7745148
24: __libc_start_main + 0xde (0xb6c32e4e) [/lib/libc.so.6] + 0x17e4e
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
NORMAL exit [7317]
06-04 10:20:47.725+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(838) > __request_handler: 0
06-04 10:20:47.725+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-04 10:20:47.725+0900 D/PKGMGR_INFO( 2744): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 10:20:47.725+0900 D/PKGMGR_INFO( 2744): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-04 10:20:47.725+0900 I/AUL     ( 2744): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-04 10:20:47.725+0900 D/AUL     ( 2744): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 7369, pid = 7371
06-04 10:20:47.725+0900 D/PKGMGR_INFO( 2744): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 10:20:47.725+0900 D/PKGMGR_INFO( 2744): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-04 10:20:47.725+0900 I/AUL     ( 2744): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-04 10:20:47.725+0900 E/AUL_AMD ( 2744): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-04 10:20:47.725+0900 W/AUL_AMD ( 2744): amd_launch.c: _start_app(2233) > caller pid : 7371
06-04 10:20:47.725+0900 E/AUL_AMD ( 2744): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-04 10:20:47.725+0900 W/AUL_AMD ( 2744): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-04 10:20:47.725+0900 D/AUL_AMD ( 2744): amd_launch.c: _start_app(2648) > process_pool: false
06-04 10:20:47.725+0900 D/AUL_AMD ( 2744): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-04 10:20:47.725+0900 D/AUL_AMD ( 2744): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-04 10:20:47.725+0900 W/AUL_AMD ( 2744): amd_launch.c: _start_app(2665) > pad pid(-5)
06-04 10:20:47.725+0900 D/AUL_AMD ( 2744): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-04 10:20:47.725+0900 D/AUL_AMD ( 2744): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-04 10:20:47.725+0900 D/AUL     ( 2744): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-04 10:20:47.725+0900 W/AUL_PAD ( 2903): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-04 10:20:47.725+0900 D/AUL     ( 2903): process_pool.c: __send_pkt_raw_data(219) > send(12) : 620 / 620
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 7213, bin path: /opt/usr/apps/org.example.example/bin/example
06-04 10:20:47.725+0900 W/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(265) > Check app launching
06-04 10:20:47.725+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-04 10:20:47.725+0900 D/RESOURCED( 2829): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-04 10:20:47.725+0900 D/RESOURCED( 2829): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-04 10:20:47.725+0900 E/RESOURCED( 2829): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-04 10:20:47.725+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-04 10:20:47.725+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-04 10:20:47.725+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-04 10:20:47.725+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-04 10:20:47.725+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-04 10:20:47.725+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-04 10:20:47.725+0900 D/AUL     ( 7213): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (7215) is sent.
06-04 10:20:47.725+0900 D/AUL     ( 7213): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 7215, signo: 10
06-04 10:20:47.735+0900 D/AUL     ( 7213): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTY1MzkyNDcvNzMzMDgxAA==##
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA3MzcxAA==##
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-04 10:20:47.735+0900 D/AUL_PAD ( 7213): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-04 10:20:47.735+0900 I/CAPI_APPFW_APPLICATION( 7213): app_main.c: ui_app_main(788) > app_efl_main
06-04 10:20:47.735+0900 D/LAUNCH  ( 7213): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-04 10:20:47.735+0900 D/APP_CORE( 7213): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-04 10:20:47.735+0900 D/APP_CORE( 7213): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-04 10:20:47.735+0900 D/APP_CORE( 7213): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-04 10:20:47.745+0900 D/APP_CORE( 7213): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-04 10:20:47.745+0900 D/AUL     ( 7213): app_sock.c: __create_server_sock(156) > pg path - already exists
06-04 10:20:47.745+0900 D/APP_CORE( 7213): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4269520
06-04 10:20:47.745+0900 D/LAUNCH  ( 7213): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-04 10:20:47.745+0900 I/CAPI_APPFW_APPLICATION( 7213): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-04 10:20:47.795+0900 D/LAUNCH  ( 7213): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-04 10:20:47.795+0900 E/E17     ( 2764): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02400002)
06-04 10:20:47.795+0900 D/APP_CORE( 7213): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-04 10:20:47.795+0900 E/E17     ( 2764): e_border.c: e_border_show(2088) > BD_SHOW(0x02400002)
06-04 10:20:47.805+0900 W/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=7213
06-04 10:20:47.805+0900 D/APP_CORE( 7213): appcore.c: __aul_handler(587) > [APP 7213]     AUL event: AUL_START
06-04 10:20:47.805+0900 I/APP_CORE( 7213): appcore-efl.c: __do_app(496) > [APP 7213] Event: RESET State: CREATED
06-04 10:20:47.805+0900 D/APP_CORE( 7213): appcore-efl.c: __do_app(527) > [APP 7213] RESET
06-04 10:20:47.805+0900 D/LAUNCH  ( 7213): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-04 10:20:47.805+0900 D/APP_CORE( 7213): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-04 10:20:47.805+0900 D/APP_CORE( 7213): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 10:20:47.805+0900 I/CAPI_APPFW_APPLICATION( 7213): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-04 10:20:47.805+0900 D/AUL     ( 7213): service.c: __set_bundle(186) > __set_bundle
06-04 10:20:47.805+0900 D/LAUNCH  ( 7213): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-04 10:20:47.805+0900 D/APP_CORE( 7213): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-04 10:20:47.805+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 10:20:47.805+0900 E/EFL     ( 7213): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 10:20:47.805+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 10:20:47.805+0900 E/EFL     ( 7213): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 10:20:47.805+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 10:20:47.805+0900 E/EFL     ( 7213): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 10:20:47.805+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 10:20:47.805+0900 E/EFL     ( 7213): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 10:20:47.805+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-04 10:20:47.805+0900 E/EFL     ( 7213): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 10:20:47.815+0900 E/EFL     ( 2764): eo<2764> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 10:20:47.815+0900 E/EFL     ( 2764): eo<2764> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 10:20:47.815+0900 D/INDICATOR( 2838): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-04 10:20:47.815+0900 D/INDICATOR( 2838): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 10:20:47.815+0900 D/INDICATOR( 2838): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 10:20:47.815+0900 D/INDICATOR( 2838): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 10:20:47.815+0900 D/INDICATOR( 2838): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 10:20:47.815+0900 D/INDICATOR( 2838): main.c: _rotate_window(252) > port :: hide more icon
06-04 10:20:47.825+0900 W/APP_CORE( 7213): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2400002
06-04 10:20:47.825+0900 D/APP_CORE( 7213): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2400002
06-04 10:20:47.825+0900 D/APP_CORE( 7213): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-04 10:20:47.825+0900 D/AUL     ( 7213): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-04 10:20:47.825+0900 D/AUL_PAD ( 2903): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-04 10:20:47.825+0900 W/AUL     ( 2744): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 7213, appid: org.example.example
06-04 10:20:47.825+0900 D/AUL     ( 2744): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 10:20:47.825+0900 E/AUL     ( 2744): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 10:20:47.825+0900 D/AUL_AMD ( 2744): amd_launch.c: _start_app(2700) > add app group info
06-04 10:20:47.825+0900 E/AUL     ( 2744): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-04 10:20:47.825+0900 D/AUL_AMD ( 2744): amd_status.c: _status_add_app_info_list(427) > pid(7213) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-04 10:20:47.825+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 10:20:47.825+0900 D/PKGMGR_INFO( 2744): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 10:20:47.825+0900 D/PKGMGR_INFO( 2744): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 10:20:47.835+0900 D/AUL_AMD ( 2744): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 7213 is org.example.example
06-04 10:20:47.835+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 7213 : 0
06-04 10:20:47.835+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(838) > __request_handler: 34
06-04 10:20:47.835+0900 D/AUL     ( 2925): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 10:20:47.835+0900 D/RESOURCED( 2829): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 7213
06-04 10:20:47.835+0900 D/RESOURCED( 2829): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-04 10:20:47.835+0900 E/RESOURCED( 2829): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-04 10:20:47.835+0900 D/RESOURCED( 2829): proc-main.c: resourced_proc_status_change(888) > available memory = 317
06-04 10:20:48.015+0900 D/APP_CORE( 7213): appcore.c: __prt_ltime(236) > [APP 7213] first idle after reset: 290 msec
06-04 10:20:48.065+0900 E/E17     ( 2764): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-04 10:20:48.065+0900 D/APP_CORE( 2852): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-04 10:20:48.065+0900 D/APP_CORE( 2852): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-04 10:20:48.065+0900 D/APP_CORE( 2852): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-04 10:20:48.065+0900 I/APP_CORE( 2852): appcore-efl.c: __do_app(496) > [APP 2852] Event: PAUSE State: RUNNING
06-04 10:20:48.065+0900 D/APP_CORE( 2852): appcore-efl.c: __do_app(565) > [APP 2852] PAUSE
06-04 10:20:48.065+0900 I/CAPI_APPFW_APPLICATION( 2852): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-04 10:20:48.065+0900 E/cluster-home( 2852): homescreen.cpp: OnPause(84) >  app pause
06-04 10:20:48.065+0900 D/cluster-view( 2852): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-04 10:20:48.065+0900 D/cluster-view( 2852): homescreen-view-manager.cpp: AppPause(923) >  END
06-04 10:20:48.065+0900 D/APP_CORE( 2852): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 10:20:48.065+0900 E/APP_CORE( 2852): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 10:20:48.065+0900 D/AUL_AMD ( 2744): amd_status.c: _status_update_app_info_list(456) > pid(2852) status(4)
06-04 10:20:48.065+0900 D/AUL_AMD ( 2744): amd_status.c: _status_update_app_info_list(468) > pid(2852) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-04 10:20:48.065+0900 D/AUL     ( 2744): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-04 10:20:48.065+0900 W/AUL     ( 2744): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2852, appid: org.tizen.homescreen, status: bg
06-04 10:20:48.065+0900 D/AUL_AMD ( 2744): amd_launch.c: __e17_status_handler(2891) > pid(7213) status(3)
06-04 10:20:48.065+0900 D/AUL_AMD ( 2744): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 10:20:48.065+0900 W/AUL_AMD ( 2744): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 10:20:48.065+0900 W/AUL_AMD ( 2744): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 10:20:48.065+0900 D/AUL_AMD ( 2744): amd_status.c: _status_update_app_info_list(456) > pid(7213) status(3)
06-04 10:20:48.065+0900 D/AUL_AMD ( 2744): amd_status.c: _status_update_app_info_list(468) > pid(7213) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 10:20:48.065+0900 D/AUL     ( 2744): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 10:20:48.065+0900 W/AUL     ( 2744): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 7213, appid: org.example.example, status: fg
06-04 10:20:48.065+0900 D/RESOURCED( 2829): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 7213
06-04 10:20:48.065+0900 D/RESOURCED( 2829): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 7213, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 10:20:48.065+0900 D/RESOURCED( 2829): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 7213
06-04 10:20:48.075+0900 D/DATA_PROVIDER_MASTER( 2905): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2852 is paused
06-04 10:20:48.075+0900 D/DATA_PROVIDER_MASTER( 2905): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 10:20:48.075+0900 I/CAPI_WIDGET_APPLICATION( 2995): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-04 10:20:48.075+0900 I/CAPI_WIDGET_APPLICATION( 2995): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-04 10:20:48.075+0900 W/AUL     ( 2995): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2995, appid: org.tizen.calendar.widget, status: bg
06-04 10:20:48.105+0900 D/RESOURCED( 2829): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 7213, appname = org.example.example, pkgname = org.example.example
06-04 10:20:48.105+0900 D/RESOURCED( 2829): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 7213, appname = org.example.example
06-04 10:20:48.105+0900 D/RESOURCED( 2829): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 7213
06-04 10:20:48.105+0900 D/RESOURCED( 2829): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2995, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-04 10:20:48.105+0900 D/RESOURCED( 2829): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 2995
06-04 10:20:48.105+0900 D/RESOURCED( 2829): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 2995, appname = org.tizen.calendar.widget
06-04 10:20:48.105+0900 D/RESOURCED( 2829): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2995
06-04 10:20:48.105+0900 I/RESOURCED( 2829): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 10:20:48.105+0900 I/RESOURCED( 2829): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 10:20:48.125+0900 D/APP_CORE( 7213): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2400002 fully_obscured 0
06-04 10:20:48.125+0900 D/APP_CORE( 7213): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-04 10:20:48.125+0900 D/APP_CORE( 7213): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 10:20:48.125+0900 I/APP_CORE( 7213): appcore-efl.c: __do_app(496) > [APP 7213] Event: RESUME State: CREATED
06-04 10:20:48.125+0900 D/LAUNCH  ( 7213): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 10:20:48.125+0900 D/APP_CORE( 7213): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 10:20:48.125+0900 D/APP_CORE( 7213): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 10:20:48.125+0900 D/APP_CORE( 7213): appcore-efl.c: __do_app(607) > [APP 7213] RESUME
06-04 10:20:48.125+0900 I/APP_CORE( 7213): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 10:20:48.125+0900 I/APP_CORE( 7213): appcore-efl.c: __do_app(614) > [APP 7213] Initial Launching, call the resume_cb
06-04 10:20:48.125+0900 I/CAPI_APPFW_APPLICATION( 7213): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 10:20:48.125+0900 D/LAUNCH  ( 7213): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 10:20:48.125+0900 D/LAUNCH  ( 7213): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 10:20:48.125+0900 D/APP_CORE( 7213): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 10:20:48.125+0900 E/APP_CORE( 7213): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 10:20:48.165+0900 D/AUL_AMD ( 2744): amd_launch.c: __e17_status_handler(2910) > pid(7213) status(0)
06-04 10:20:48.835+0900 D/AUL_PAD ( 2903): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-04 10:20:48.835+0900 D/AUL_PAD ( 7378): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-04 10:20:48.835+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-04 10:20:48.835+0900 E/RESOURCED( 2829): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.578
06-04 10:20:48.995+0900 E/PKGMGR_SERVER( 7302): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-04 10:20:48.995+0900 E/PKGMGR_SERVER( 7302): pkgmgr-server.c: main(2265) > package manager server terminated.
06-04 10:20:49.335+0900 D/AUL_AMD ( 2744): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-04 10:20:49.335+0900 D/RUA     ( 2744): rua.c: rua_add_history(179) > rua_add_history start
06-04 10:20:49.335+0900 D/RUA     ( 2744): rua.c: rua_add_history(247) > rua_add_history ok
06-04 10:20:49.865+0900 D/AUL_PAD ( 7378): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 10:20:49.865+0900 D/AUL_PAD ( 7378): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 10:20:49.875+0900 D/AUL_PAD ( 7378): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b7a06760
06-04 10:20:49.875+0900 D/AUL_PAD ( 7378): preload.h: __preload_init(69) > get pre-initialization function
06-04 10:20:49.875+0900 D/AUL_PAD ( 7378): preload.h: __preload_init(73) > get shutdown function
06-04 10:20:49.875+0900 D/AUL_PAD ( 7378): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b7a06a40
06-04 10:20:49.885+0900 D/AUL_PAD ( 7378): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b7a08640
06-04 10:20:49.885+0900 D/AUL_PAD ( 7378): preload.h: __preload_init(69) > get pre-initialization function
06-04 10:20:49.885+0900 D/AUL_PAD ( 7378): preload.h: __preload_init(73) > get shutdown function
06-04 10:20:49.885+0900 D/AUL_PAD ( 7378): preexec.h: __preexec_init(76) > preexec start
06-04 10:20:49.885+0900 D/AUL_PAD ( 7378): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 10:20:49.885+0900 D/AUL     ( 7378): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 10:20:49.885+0900 D/AUL     ( 7378): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 10:20:49.885+0900 D/AUL     ( 7378): process_pool.c: __connect_to_launchpad(132) > send(7378) : 4
06-04 10:20:49.885+0900 D/AUL     ( 7378): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 10:20:49.885+0900 D/AUL_PAD ( 2903): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 7378
06-04 10:20:49.955+0900 D/AUL_PAD ( 7378): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 10:20:49.965+0900 D/AUL_PAD ( 7378): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 10:20:49.965+0900 D/AUL_PAD ( 7378): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 10:20:49.965+0900 D/AUL_PAD ( 7378): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 10:20:51.045+0900 I/user_tag0( 7213): /opt/usr/apps/org.example.example/data/feeding.db
06-04 10:20:51.045+0900 I/tag     ( 7213): eonji~
06-04 10:20:51.105+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40171f 
06-04 10:20:52.105+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 10:20:52.115+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40171f 
06-04 10:20:52.575+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40171f 
06-04 10:20:52.725+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.725+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.775+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.775+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.775+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.775+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.785+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.785+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.785+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:52.795+0900 D/IMMODULE( 7213): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 10:20:52.795+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 10:20:52.795+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:20:52.795+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 10:20:52.795+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:20:52.795+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 10:20:52.805+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:20:52.805+0900 D/ISF_QUERY( 7213): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 10:20:52.805+0900 D/ISF_QUERY( 7213): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:20:52.805+0900 D/ISF_QUERY( 7213): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:20:52.805+0900 D/ISF_QUERY( 7213): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:20:52.805+0900 D/ISF_QUERY( 7213): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:20:52.805+0900 D/ISF_QUERY( 7213): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:20:52.805+0900 D/ISF_QUERY( 7213): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:20:52.805+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 10:20:52.805+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:20:52.805+0900 D/IMMODULE( 7213): scim_panel_client.cpp: open_connection(162) > 
06-04 10:20:52.805+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 10:20:52.805+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:20:52.805+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 10:20:52.805+0900 D/ISF_SOCKET( 7213): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:20:52.805+0900 D/IMMODULE( 7213): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 10:20:53.065+0900 D/APP_CORE( 2852): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-04 10:20:53.065+0900 I/APP_CORE( 2852): appcore-efl.c: __do_app(496) > [APP 2852] Event: MEM_FLUSH State: PAUSED
06-04 10:20:53.065+0900 D/APP_CORE( 2852): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-04 10:20:53.065+0900 D/APP_CORE( 2852): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2852
06-04 10:20:53.065+0900 D/APP_CORE( 2852): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-04 10:20:53.065+0900 D/RESOURCED( 2829): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2852
06-04 10:20:54.245+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40171f 
06-04 10:20:54.435+0900 I/tag     ( 7213): insert
06-04 10:20:54.435+0900 I/user_tag( 7213): 10:20 AM
06-04 10:20:54.435+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:54.445+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:54.445+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:54.445+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:54.445+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:20:57.105+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x40171f bd->visible=1
06-04 10:21:00.555+0900 D/INDICATOR( 2838): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 10:21:00.555+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 10:21:00.555+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 10:21:00.555+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 10:21 5 h"
06-04 10:21:00.555+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 10:21"
06-04 10:21:00.555+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 10&#x2236;21"
06-04 10:21:00.555+0900 D/INDICATOR( 2838): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146945506 Time: <font_size=33>10&#x2236;21</font_size> <font_size=32>AM</font_size></font>
06-04 10:21:00.575+0900 E/CAPI_NETWORK_WIFI( 2838): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 10:21:00.575+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 10:21:00.575+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 10:21:00.575+0900 E/INDICATOR( 2838): 
06-04 10:21:11.895+0900 D/RESOURCED( 2829): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 10:21:11.895+0900 I/RESOURCED( 2829): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 10:21:11.895+0900 D/RESOURCED( 2829): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 10:21:11.895+0900 I/RESOURCED( 2829): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 10:21:11.895+0900 I/RESOURCED( 2829): logging.c: logging_save_to_storage(978) > storage cache is empty
06-04 10:21:20.605+0900 E/CAPI_NETWORK_WIFI( 2838): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 10:21:20.605+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 10:21:20.605+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 10:21:20.605+0900 E/INDICATOR( 2838): 
06-04 10:21:40.625+0900 E/CAPI_NETWORK_WIFI( 2838): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 10:21:40.625+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 10:21:40.625+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 10:21:40.625+0900 E/INDICATOR( 2838): 
06-04 10:22:00.574+0900 D/INDICATOR( 2838): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-04 10:22:00.574+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 10:22:00.574+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 10:22:00.574+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 10:22 5 h"
06-04 10:22:00.574+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 10:22"
06-04 10:22:00.574+0900 D/INDICATOR( 2838): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 10&#x2236;22"
06-04 10:22:00.574+0900 D/INDICATOR( 2838): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146943454 Time: <font_size=33>10&#x2236;22</font_size> <font_size=32>AM</font_size></font>
06-04 10:22:00.624+0900 E/CAPI_NETWORK_WIFI( 2838): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 10:22:00.624+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 10:22:00.624+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 10:22:00.624+0900 E/INDICATOR( 2838): 
06-04 10:22:11.944+0900 D/RESOURCED( 2829): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-04 10:22:11.944+0900 I/RESOURCED( 2829): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-04 10:22:11.944+0900 D/RESOURCED( 2829): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-04 10:22:11.944+0900 I/RESOURCED( 2829): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-04 10:22:20.644+0900 E/CAPI_NETWORK_WIFI( 2838): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 10:22:20.644+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001aed8)
06-04 10:22:20.644+0900 E/INDICATOR( 2838): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 10:22:20.644+0900 E/INDICATOR( 2838): 
06-04 10:22:31.874+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40171f 
06-04 10:22:31.944+0900 I/tag     ( 7213): make!
06-04 10:22:32.854+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40171f 
06-04 10:22:32.974+0900 E/EFL     ( 7213): edje<7213> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-04 10:22:32.974+0900 E/EFL     ( 7213): By the power of Grayskull, your previous Embryo stack is now broken!
06-04 10:22:33.854+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2400002
06-04 10:22:37.234+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40171f 
06-04 10:22:38.204+0900 I/user_tag0( 7213): /opt/usr/apps/org.example.example/data/feeding.db
06-04 10:22:38.204+0900 I/tag     ( 7213): eonji~
06-04 10:22:38.204+0900 I/tag     ( 7213): 들어와!
06-04 10:22:38.204+0900 I/tag     ( 7213): 언지
06-04 10:22:38.204+0900 I/tag     ( 7213): 10 20
06-04 10:22:38.204+0900 E/EFL     ( 7213): eo<7213> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800acf6a is not pointing to a valid object. Maybe it has already been freed.
06-04 10:22:38.204+0900 E/EFL     ( 7213): eo<7213> lib/eo/eo.c:485 _eo_do_internal() Obj (0x800acf6a) is an invalid ref.
06-04 10:22:38.234+0900 W/CRASH_MANAGER( 7381): worker.c: worker_job(1204) > 1107213657861149653935
