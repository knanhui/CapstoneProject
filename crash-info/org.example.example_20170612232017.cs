S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 12047
Date: 2017-06-12 23:20:17+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa72

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000004, esi = 0x8000aa56
ebp = 0xbfb559a8, esp = 0xbfb55940
eax = 0x0000000b, ebx = 0xb37ea000
ecx = 0x8000aa56, edx = 0x00000000
eip = 0xb37e150e

Memory Information
MemTotal:      123 KB
MemFree:        22 KB
Buffers:        11 KB
Cached:     170972 KB
VmPeak:     122368 KB
VmSize:     116388 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35304 KB
VmRSS:       29212 KB
VmData:      46472 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34640 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 12047 TID = 12047
12047 12049 12228 12229 12233 

Maps Information
b0ee6000 b0efe000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1805000 b180c000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b180f000 b1816000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b18cb000 b18cf000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2ba4000 b2bae000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bb4000 b2bc0000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bc1000 b2be2000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2be7000 b2be8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2be9000 b2bee000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bef000 b2bf0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bf1000 b2bf3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bf4000 b2bf6000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bf7000 b2c03000 r-xp /usr/lib/libdrm.so.2.4.0
b2c04000 b2c07000 r-xp /usr/lib/libdri2.so.0.0.0
b2c08000 b2c12000 r-xp /usr/lib/libtbm.so.1.0.0
b2c13000 b2c28000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c29000 b2c3b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b343d000 b346e000 r-xp /usr/lib/libidn.so.11.5.44
b346f000 b3491000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3492000 b34a2000 r-xp /usr/lib/libcares.so.2.1.0
b34a3000 b34ac000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34ad000 b34b6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34b7000 b352e000 r-xp /usr/lib/libcurl.so.4.3.0
b3530000 b3542000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3543000 b3564000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b356b000 b356c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b356d000 b356e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b356f000 b3572000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3573000 b3576000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b367e000 b3684000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3685000 b37c9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37d9000 b37da000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37db000 b37e9000 r-xp /opt/usr/apps/org.example.example/bin/example
b37eb000 b3824000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4227000 b4232000 r-xp /lib/libnss_files-2.20-2014.11.so
b4234000 b423f000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4241000 b4258000 r-xp /lib/libnsl-2.20-2014.11.so
b425c000 b4264000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4266000 b428a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b428b000 b428c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b428d000 b4290000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4291000 b4298000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4299000 b42a3000 r-xp /usr/lib/libsensord-share.so
b42a4000 b42c0000 r-xp /usr/lib/libsensor.so.1.2.0
b42c2000 b42cb000 r-xp /usr/lib/libappcore-common.so.1.1
b42ce000 b42d0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42e5000 b42e7000 r-xp /usr/lib/libXau.so.6.0.0
b42e8000 b430a000 r-xp /usr/lib/libxcb.so.1.1.0
b430c000 b4315000 r-xp /lib/libcrypt-2.20-2014.11.so
b433e000 b4340000 r-xp /usr/lib/libiri.so
b4341000 b4367000 r-xp /lib/libexpat.so.1.5.2
b4369000 b43d4000 r-xp /usr/lib/libssl.so.1.0.0
b43da000 b43e6000 r-xp /usr/lib/libethumb.so.1.13.0
b43e7000 b43eb000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43ec000 b463d000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bb8000 b5bc8000 r-xp /usr/lib/libXi.so.6.1.0
b5bc9000 b5bcb000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bcc000 b5bd2000 r-xp /usr/lib/libXtst.so.6.1.0
b5bd3000 b5bdd000 r-xp /usr/lib/libXrender.so.1.3.0
b5bde000 b5be7000 r-xp /usr/lib/libXrandr.so.2.2.0
b5be9000 b5beb000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bec000 b5bf1000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bf2000 b5c04000 r-xp /usr/lib/libXext.so.6.4.0
b5c05000 b5c07000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c08000 b5c0a000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c0c000 b5d4e000 r-xp /usr/lib/libX11.so.6.3.0
b5d52000 b5d5c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d5d000 b5d73000 r-xp /usr/lib/libudev.so.1.6.0
b5d76000 b5d7a000 r-xp /lib/libattr.so.1.1.0
b5d7b000 b5daa000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5dac000 b5db2000 r-xp /usr/lib/libffi.so.6.0.2
b5db3000 b5dd6000 r-xp /lib/libz.so.1.2.8
b5dd7000 b5dda000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5ddb000 b5f37000 r-xp /usr/lib/libxml2.so.2.9.2
b5f3d000 b6024000 r-xp /usr/lib/libstdc++.so.6.0.20
b6031000 b6034000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6035000 b6057000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6058000 b606c000 r-xp /lib/libresolv-2.20-2014.11.so
b6070000 b6094000 r-xp /usr/lib/liblzma.so.5.0.3
b6095000 b6097000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6099000 b60a3000 r-xp /usr/lib/libembryo.so.1.13.0
b60a4000 b60cd000 r-xp /usr/lib/libpng12.so.0.50.0
b60ce000 b6117000 r-xp /usr/lib/libjpeg.so.8.0.2
b6128000 b612f000 r-xp /lib/librt-2.20-2014.11.so
b6131000 b6150000 r-xp /usr/lib/libector.so.1.13.0
b6153000 b6180000 r-xp /usr/lib/liblua-5.1.so
b6181000 b6211000 r-xp /usr/lib/libfreetype.so.6.11.3
b6215000 b6253000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6254000 b626a000 r-xp /usr/lib/libfribidi.so.0.3.1
b626b000 b62c4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62c7000 b6312000 r-xp /lib/libm-2.20-2014.11.so
b6314000 b6326000 r-xp /usr/lib/libeio.so.1.13.0
b6327000 b632a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b632b000 b6331000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6332000 b6355000 r-xp /usr/lib/libefreet.so.1.13.0
b6358000 b6383000 r-xp /usr/lib/libeldbus.so.1.13.0
b6384000 b63b8000 r-xp /usr/lib/libecore_con.so.1.13.0
b63ba000 b63c3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63c4000 b63cd000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63ce000 b63e1000 r-xp /usr/lib/libeo.so.1.13.0
b63e3000 b63f6000 r-xp /usr/lib/libecore_input.so.1.13.0
b63f7000 b63fe000 r-xp /usr/lib/libecore_file.so.1.13.0
b63ff000 b6422000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6423000 b644f000 r-xp /usr/lib/libeet.so.1.13.0
b6458000 b64c3000 r-xp /usr/lib/libeina.so.1.13.0
b64c6000 b64dd000 r-xp /usr/lib/libefl.so.1.13.0
b64df000 b6646000 r-xp /usr/lib/libicuuc.so.51.1
b6654000 b6860000 r-xp /usr/lib/libicui18n.so.51.1
b6868000 b68b7000 r-xp /usr/lib/libecore_x.so.1.13.0
b68b9000 b68d3000 r-xp /lib/libgcc_s-4.9.so.1
b68d5000 b68d9000 r-xp /lib/libcap.so.2.21
b68da000 b6920000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6921000 b6928000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b692a000 b697c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b697e000 b6b09000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b0e000 b6bdc000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bdf000 b6be3000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6be4000 b6bf3000 r-xp /usr/lib/libvconf.so.0.2.45
b6bf4000 b6bf7000 r-xp /usr/lib/libvasum.so.0.3.1
b6bf8000 b6bfb000 r-xp /usr/lib/libttrace.so.1.1
b6bfd000 b6c01000 r-xp /usr/lib/libiniparser.so.0
b6c02000 b6c32000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c33000 b6c3c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c3d000 b6c62000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c63000 b6c73000 r-xp /usr/lib/libunwind.so.8.0.1
b6c7d000 b6e2b000 r-xp /lib/libc-2.20-2014.11.so
b6e33000 b6f76000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f78000 b6fd0000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fd1000 b7005000 r-xp /usr/lib/libsystemd.so.0.4.0
b7008000 b70dc000 r-xp /usr/lib/libedje.so.1.13.0
b70df000 b710b000 r-xp /usr/lib/libecore.so.1.13.0
b711c000 b7342000 r-xp /usr/lib/libevas.so.1.13.0
b736a000 b7382000 r-xp /lib/libpthread-2.20-2014.11.so
b7386000 b7700000 r-xp /usr/lib/libelementary.so.1.13.0
b7720000 b7724000 r-xp /usr/lib/libsmack.so.1.0.0
b7725000 b772e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b772f000 b7732000 r-xp /usr/lib/libdlog.so.0.0.0
b7733000 b7738000 r-xp /usr/lib/libbundle.so.0.1.22
b7739000 b773c000 r-xp /lib/libdl-2.20-2014.11.so
b773e000 b7763000 r-xp /usr/lib/libaul.so.0.1.0
b7766000 b7768000 r-xp /usr/lib/libappsvc.so.0.1.0
b7769000 b776e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b776f000 b7776000 r-xp /usr/lib/libappcore-efl.so.1.1
b7778000 b777d000 r-xp /usr/lib/libsys-assert.so
b7780000 b7781000 r-xp [vdso]
b7781000 b77a3000 r-xp /lib/ld-2.20-2014.11.so
b77a5000 b77ad000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:12047)
Call Stack Count: 13
 0: list_item_clicked + 0x5e (0xb37e150e) [/opt/usr/apps/org.example.example/bin/example] + 0x650e
 1: (0xb74e61d0) [/usr/lib/libelementary.so.1] + 0x1601d0
 2: (0xb74e6315) [/usr/lib/libelementary.so.1] + 0x160315
 3: (0xb70fa370) [/usr/lib/libecore.so.1] + 0x1b370
 4: (0xb70fa4ff) [/usr/lib/libecore.so.1] + 0x1b4ff
 5: (0xb70f5061) [/usr/lib/libecore.so.1] + 0x16061
 6: ecore_main_loop_begin + 0x57 (0xb70f5587) [/usr/lib/libecore.so.1] + 0x16587
 7: elm_run + 0x2d (0xb754e22d) [/usr/lib/libelementary.so.1] + 0x1c822d
 8: appcore_efl_main + 0x4de (0xb7772dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
 9: ui_app_main + 0x140 (0xb776bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
10: main + 0x296 (0xb37e3de6) [/opt/usr/apps/org.example.example/bin/example] + 0x8de6
11: (0xb77a7148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77a7148
12: __libc_start_main + 0xde (0xb6c94e4e) [/lib/libc.so.6] + 0x17e4e
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
08.906+0900 E/PKGMGR_SERVER(12155): pkgmgr-server.c: sighandler(402) > child NORMAL exit [12170]
06-12 23:20:09.166+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 0
06-12 23:20:09.166+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-12 23:20:09.166+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-12 23:20:09.166+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-12 23:20:09.166+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-12 23:20:09.166+0900 D/AUL     ( 2740): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 12222, pid = 12224
06-12 23:20:09.166+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-12 23:20:09.166+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-12 23:20:09.166+0900 I/AUL     ( 2740): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-12 23:20:09.166+0900 E/AUL_AMD ( 2740): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-12 23:20:09.166+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2233) > caller pid : 12224
06-12 23:20:09.166+0900 E/AUL_AMD ( 2740): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-12 23:20:09.166+0900 W/AUL_AMD ( 2740): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-12 23:20:09.166+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2648) > process_pool: false
06-12 23:20:09.166+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-12 23:20:09.166+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-12 23:20:09.166+0900 W/AUL_AMD ( 2740): amd_launch.c: _start_app(2665) > pad pid(-5)
06-12 23:20:09.166+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-12 23:20:09.166+0900 D/AUL_AMD ( 2740): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-12 23:20:09.166+0900 D/AUL     ( 2740): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-12 23:20:09.166+0900 W/AUL_PAD ( 2914): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-12 23:20:09.166+0900 D/AUL     ( 2914): process_pool.c: __send_pkt_raw_data(219) > send(12) : 624 / 624
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 12047, bin path: /opt/usr/apps/org.example.example/bin/example
06-12 23:20:09.166+0900 W/AUL_PAD ( 2914): launchpad.c: __send_result_to_caller(265) > Check app launching
06-12 23:20:09.166+0900 D/AUL_PAD ( 2914): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-12 23:20:09.166+0900 D/RESOURCED( 2846): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-12 23:20:09.166+0900 D/RESOURCED( 2846): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-12 23:20:09.166+0900 E/RESOURCED( 2846): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-12 23:20:09.166+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-12 23:20:09.166+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 624, pkt->len: 616
06-12 23:20:09.166+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-12 23:20:09.166+0900 D/AUL_PAD (12047): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-12 23:20:09.166+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-12 23:20:09.166+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-12 23:20:09.166+0900 D/AUL     (12047): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (12049) is sent.
06-12 23:20:09.176+0900 D/AUL     (12047): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 12049, signo: 10
06-12 23:20:09.176+0900 D/AUL     (12047): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTcyNzcyMDkvMTcwMDE0AA==##
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KQAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAYAAAAxMjIyNAA=##
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-12 23:20:09.176+0900 D/AUL_PAD (12047): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-12 23:20:09.176+0900 I/CAPI_APPFW_APPLICATION(12047): app_main.c: ui_app_main(788) > app_efl_main
06-12 23:20:09.176+0900 D/LAUNCH  (12047): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-12 23:20:09.176+0900 D/APP_CORE(12047): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-12 23:20:09.176+0900 D/APP_CORE(12047): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-12 23:20:09.176+0900 D/APP_CORE(12047): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-12 23:20:09.186+0900 D/APP_CORE(12047): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-12 23:20:09.186+0900 D/AUL     (12047): app_sock.c: __create_server_sock(156) > pg path - already exists
06-12 23:20:09.186+0900 D/APP_CORE(12047): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42cb520
06-12 23:20:09.186+0900 D/LAUNCH  (12047): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-12 23:20:09.186+0900 I/CAPI_APPFW_APPLICATION(12047): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-12 23:20:09.236+0900 D/LAUNCH  (12047): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-12 23:20:09.236+0900 D/APP_CORE(12047): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-12 23:20:09.236+0900 E/E17     ( 2760): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02a00002)
06-12 23:20:09.246+0900 D/APP_CORE(12047): appcore.c: __aul_handler(587) > [APP 12047]     AUL event: AUL_START
06-12 23:20:09.246+0900 I/APP_CORE(12047): appcore-efl.c: __do_app(496) > [APP 12047] Event: RESET State: CREATED
06-12 23:20:09.246+0900 D/APP_CORE(12047): appcore-efl.c: __do_app(527) > [APP 12047] RESET
06-12 23:20:09.246+0900 D/LAUNCH  (12047): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-12 23:20:09.246+0900 D/APP_CORE(12047): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-12 23:20:09.246+0900 D/APP_CORE(12047): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-12 23:20:09.246+0900 I/CAPI_APPFW_APPLICATION(12047): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-12 23:20:09.246+0900 D/AUL     (12047): service.c: __set_bundle(186) > __set_bundle
06-12 23:20:09.246+0900 D/LAUNCH  (12047): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-12 23:20:09.246+0900 D/APP_CORE(12047): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-12 23:20:09.246+0900 E/EFL     (12047): edje<12047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 23:20:09.246+0900 E/EFL     (12047): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 23:20:09.246+0900 E/EFL     (12047): edje<12047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 23:20:09.246+0900 E/EFL     (12047): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 23:20:09.246+0900 E/EFL     (12047): edje<12047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 23:20:09.246+0900 E/EFL     (12047): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 23:20:09.246+0900 E/EFL     (12047): edje<12047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 23:20:09.246+0900 E/EFL     (12047): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 23:20:09.246+0900 E/EFL     (12047): edje<12047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-12 23:20:09.246+0900 E/EFL     (12047): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 23:20:09.266+0900 D/AUL_PAD ( 2914): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-12 23:20:09.266+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 12047, appid: org.example.example
06-12 23:20:09.266+0900 D/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-12 23:20:09.266+0900 E/AUL     ( 2740): simple_util.c: __trm_app_info_send_socket(330) > access
06-12 23:20:09.266+0900 D/AUL_AMD ( 2740): amd_launch.c: _start_app(2700) > add app group info
06-12 23:20:09.266+0900 E/AUL     ( 2740): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-12 23:20:09.266+0900 D/AUL_AMD ( 2740): amd_status.c: _status_add_app_info_list(427) > pid(12047) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-12 23:20:09.266+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 12047
06-12 23:20:09.266+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-12 23:20:09.266+0900 E/RESOURCED( 2846): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-12 23:20:09.266+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(888) > available memory = 311
06-12 23:20:09.286+0900 E/E17     ( 2760): e_border.c: e_border_show(2088) > BD_SHOW(0x02a00002)
06-12 23:20:09.316+0900 W/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=12047
06-12 23:20:09.316+0900 E/EFL     ( 2760): eo<2760> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-12 23:20:09.316+0900 E/EFL     ( 2760): eo<2760> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-12 23:20:09.316+0900 D/INDICATOR( 2850): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-12 23:20:09.326+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 15
06-12 23:20:09.326+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-12 23:20:09.326+0900 D/PKGMGR_INFO( 2740): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-12 23:20:09.326+0900 D/AUL_AMD ( 2740): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 12047 is org.example.example
06-12 23:20:09.326+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 12047 : 0
06-12 23:20:09.326+0900 D/AUL     ( 2930): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-12 23:20:09.346+0900 D/INDICATOR( 2850): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-12 23:20:09.346+0900 D/INDICATOR( 2850): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-12 23:20:09.346+0900 D/INDICATOR( 2850): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-12 23:20:09.346+0900 D/INDICATOR( 2850): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-12 23:20:09.346+0900 D/INDICATOR( 2850): main.c: _rotate_window(252) > port :: hide more icon
06-12 23:20:09.386+0900 D/APP_CORE(12047): appcore.c: __prt_ltime(236) > [APP 12047] first idle after reset: 229 msec
06-12 23:20:09.386+0900 W/APP_CORE(12047): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00002
06-12 23:20:09.386+0900 D/APP_CORE(12047): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2a00002
06-12 23:20:09.386+0900 D/APP_CORE(12047): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-12 23:20:09.386+0900 D/AUL     (12047): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-12 23:20:09.386+0900 D/AUL_AMD ( 2740): amd_request.c: __request_handler(838) > __request_handler: 34
06-12 23:20:09.636+0900 E/E17     ( 2760): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-12 23:20:09.636+0900 D/APP_CORE( 2866): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-12 23:20:09.636+0900 D/APP_CORE(12047): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2a00002 fully_obscured 0
06-12 23:20:09.636+0900 D/APP_CORE(12047): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-12 23:20:09.636+0900 D/APP_CORE( 2866): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-12 23:20:09.636+0900 D/APP_CORE(12047): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-12 23:20:09.636+0900 D/APP_CORE( 2866): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-12 23:20:09.636+0900 I/APP_CORE( 2866): appcore-efl.c: __do_app(496) > [APP 2866] Event: PAUSE State: RUNNING
06-12 23:20:09.636+0900 D/APP_CORE( 2866): appcore-efl.c: __do_app(565) > [APP 2866] PAUSE
06-12 23:20:09.636+0900 I/CAPI_APPFW_APPLICATION( 2866): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-12 23:20:09.636+0900 I/APP_CORE(12047): appcore-efl.c: __do_app(496) > [APP 12047] Event: RESUME State: CREATED
06-12 23:20:09.636+0900 D/LAUNCH  (12047): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-12 23:20:09.636+0900 D/APP_CORE(12047): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-12 23:20:09.636+0900 D/APP_CORE(12047): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-12 23:20:09.636+0900 D/APP_CORE(12047): appcore-efl.c: __do_app(607) > [APP 12047] RESUME
06-12 23:20:09.636+0900 E/cluster-home( 2866): homescreen.cpp: OnPause(84) >  app pause
06-12 23:20:09.636+0900 D/cluster-view( 2866): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-12 23:20:09.636+0900 D/cluster-view( 2866): homescreen-view-manager.cpp: AppPause(923) >  END
06-12 23:20:09.636+0900 D/APP_CORE( 2866): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-12 23:20:09.636+0900 E/APP_CORE( 2866): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-12 23:20:09.636+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(2866) status(4)
06-12 23:20:09.636+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(2866) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-12 23:20:09.636+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-12 23:20:09.636+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2866, appid: org.tizen.homescreen, status: bg
06-12 23:20:09.646+0900 I/APP_CORE(12047): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-12 23:20:09.646+0900 I/APP_CORE(12047): appcore-efl.c: __do_app(614) > [APP 12047] Initial Launching, call the resume_cb
06-12 23:20:09.646+0900 I/CAPI_APPFW_APPLICATION(12047): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-12 23:20:09.646+0900 D/LAUNCH  (12047): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-12 23:20:09.646+0900 D/LAUNCH  (12047): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-12 23:20:09.646+0900 D/APP_CORE(12047): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-12 23:20:09.646+0900 E/APP_CORE(12047): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-12 23:20:09.646+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2891) > pid(12047) status(3)
06-12 23:20:09.646+0900 D/AUL_AMD ( 2740): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-12 23:20:09.646+0900 W/AUL_AMD ( 2740): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-12 23:20:09.646+0900 W/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-12 23:20:09.646+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(456) > pid(12047) status(3)
06-12 23:20:09.646+0900 D/AUL_AMD ( 2740): amd_status.c: _status_update_app_info_list(468) > pid(12047) appid(org.example.example) pkgid(org.example.example) status(3)
06-12 23:20:09.646+0900 D/AUL     ( 2740): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-12 23:20:09.646+0900 W/AUL     ( 2740): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 12047, appid: org.example.example, status: fg
06-12 23:20:09.646+0900 D/RESOURCED( 2846): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 12047
06-12 23:20:09.646+0900 D/RESOURCED( 2846): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 12047, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-12 23:20:09.646+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 12047
06-12 23:20:09.656+0900 D/DATA_PROVIDER_MASTER( 2921): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2866 is paused
06-12 23:20:09.656+0900 D/DATA_PROVIDER_MASTER( 2921): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-12 23:20:09.656+0900 I/CAPI_WIDGET_APPLICATION( 3014): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-12 23:20:09.656+0900 I/CAPI_WIDGET_APPLICATION( 3014): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-12 23:20:09.656+0900 W/AUL     ( 3014): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3014, appid: org.tizen.calendar.widget, status: bg
06-12 23:20:09.696+0900 D/RESOURCED( 2846): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 12047, appname = org.example.example, pkgname = org.example.example
06-12 23:20:09.696+0900 D/RESOURCED( 2846): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 12047, appname = org.example.example
06-12 23:20:09.696+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 12047
06-12 23:20:09.696+0900 D/RESOURCED( 2846): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3014, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-12 23:20:09.696+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3014
06-12 23:20:09.696+0900 D/RESOURCED( 2846): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3014, appname = org.tizen.calendar.widget
06-12 23:20:09.696+0900 D/RESOURCED( 2846): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3014
06-12 23:20:09.696+0900 I/RESOURCED( 2846): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-12 23:20:09.696+0900 I/RESOURCED( 2846): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-12 23:20:09.806+0900 D/AUL_AMD ( 2740): amd_launch.c: __e17_status_handler(2910) > pid(12047) status(0)
06-12 23:20:10.186+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(11864)
06-12 23:20:10.186+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-12 23:20:10.186+0900 D/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(442) > pid(11864)
06-12 23:20:10.186+0900 W/AUL_AMD ( 2740): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-12 23:20:10.276+0900 D/AUL_PAD ( 2914): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-12 23:20:10.276+0900 D/AUL_PAD (12231): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-12 23:20:10.276+0900 D/AUL_PAD ( 2914): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-12 23:20:10.276+0900 E/RESOURCED( 2846): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1022
06-12 23:20:10.416+0900 I/user_tag0(12047): /opt/usr/apps/org.example.example/data/feeding.db
06-12 23:20:10.416+0900 I/tag     (12047): eonji~
06-12 23:20:10.476+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x603424 
06-12 23:20:10.766+0900 D/AUL_AMD ( 2740): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-12 23:20:10.766+0900 D/RUA     ( 2740): rua.c: rua_add_history(179) > rua_add_history start
06-12 23:20:10.776+0900 D/RUA     ( 2740): rua.c: rua_add_history(247) > rua_add_history ok
06-12 23:20:10.996+0900 E/PKGMGR_SERVER(12155): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-12 23:20:10.996+0900 E/PKGMGR_SERVER(12155): pkgmgr-server.c: main(2265) > package manager server terminated.
06-12 23:20:11.136+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x603424 
06-12 23:20:11.296+0900 D/AUL_PAD (12231): launchpad_loader.c: main(588) > sleeping 1 sec...
06-12 23:20:11.296+0900 D/AUL_PAD (12231): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-12 23:20:11.296+0900 D/AUL_PAD (12231): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8c85760
06-12 23:20:11.296+0900 D/AUL_PAD (12231): preload.h: __preload_init(69) > get pre-initialization function
06-12 23:20:11.296+0900 D/AUL_PAD (12231): preload.h: __preload_init(73) > get shutdown function
06-12 23:20:11.296+0900 D/AUL_PAD (12231): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8c85a40
06-12 23:20:11.296+0900 D/AUL_PAD (12231): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8c87640
06-12 23:20:11.306+0900 D/AUL_PAD (12231): preload.h: __preload_init(69) > get pre-initialization function
06-12 23:20:11.306+0900 D/AUL_PAD (12231): preload.h: __preload_init(73) > get shutdown function
06-12 23:20:11.306+0900 D/AUL_PAD (12231): preexec.h: __preexec_init(76) > preexec start
06-12 23:20:11.306+0900 D/AUL_PAD (12231): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-12 23:20:11.306+0900 D/AUL     (12231): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-12 23:20:11.306+0900 D/AUL     (12231): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-12 23:20:11.306+0900 D/AUL     (12231): process_pool.c: __connect_to_launchpad(132) > send(12231) : 4
06-12 23:20:11.306+0900 D/AUL     (12231): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-12 23:20:11.306+0900 D/AUL_PAD ( 2914): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 12231
06-12 23:20:11.306+0900 E/RESOURCED( 2846): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1023
06-12 23:20:11.366+0900 D/AUL_PAD (12231): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-12 23:20:11.376+0900 D/AUL_PAD (12231): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-12 23:20:11.376+0900 D/AUL_PAD (12231): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-12 23:20:11.376+0900 D/AUL_PAD (12231): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-12 23:20:11.846+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x603424 
06-12 23:20:11.956+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:11.956+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:11.996+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:11.996+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:11.996+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.006+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.006+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.006+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.016+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.016+0900 D/IMMODULE(12047): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-12 23:20:12.016+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-12 23:20:12.016+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(524) > connect() succeeded
06-12 23:20:12.016+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-12 23:20:12.016+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(524) > connect() succeeded
06-12 23:20:12.026+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-12 23:20:12.026+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(524) > connect() succeeded
06-12 23:20:12.026+0900 D/ISF_QUERY(12047): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-12 23:20:12.026+0900 D/ISF_QUERY(12047): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 23:20:12.026+0900 D/ISF_QUERY(12047): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 23:20:12.026+0900 D/ISF_QUERY(12047): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 23:20:12.026+0900 D/ISF_QUERY(12047): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 23:20:12.026+0900 D/ISF_QUERY(12047): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 23:20:12.026+0900 D/ISF_QUERY(12047): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-12 23:20:12.026+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-socket-frontend, example
06-12 23:20:12.036+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(524) > connect() succeeded
06-12 23:20:12.036+0900 D/IMMODULE(12047): scim_panel_client.cpp: open_connection(162) > 
06-12 23:20:12.036+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-panel-socket:0, example
06-12 23:20:12.036+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(524) > connect() succeeded
06-12 23:20:12.036+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(515) > ppid:2914  trying connect() to local:/tmp/scim-panel-socket:0, example
06-12 23:20:12.036+0900 D/ISF_SOCKET(12047): scim_socket.cpp: connect(524) > connect() succeeded
06-12 23:20:12.036+0900 D/IMMODULE(12047): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-12 23:20:12.636+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x603424 
06-12 23:20:12.696+0900 E/EFL     (12047): edje<12047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-12 23:20:12.696+0900 E/EFL     (12047): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 23:20:12.966+0900 I/tag     (12047): insert
06-12 23:20:12.966+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.966+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.966+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.976+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.976+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:12.976+0900 I/get     (12047): 20
06-12 23:20:12.976+0900 I/get     (12047): 20
06-12 23:20:12.976+0900 I/get     (12047): 20
06-12 23:20:12.976+0900 I/get     (12047): 20
06-12 23:20:12.996+0900 I/get     (12047): 20
06-12 23:20:12.996+0900 I/get     (12047): 20
06-12 23:20:12.996+0900 I/get     (12047): 20
06-12 23:20:12.996+0900 I/get     (12047): 20
06-12 23:20:13.476+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x603424 
06-12 23:20:13.646+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:13.646+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:13.696+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:13.696+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:13.696+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:13.706+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:13.706+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:13.706+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:13.706+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:14.476+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2a00002
06-12 23:20:14.646+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-12 23:20:14.646+0900 I/APP_CORE( 2866): appcore-efl.c: __do_app(496) > [APP 2866] Event: MEM_FLUSH State: PAUSED
06-12 23:20:14.646+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-12 23:20:14.646+0900 D/APP_CORE( 2866): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2866
06-12 23:20:14.646+0900 D/APP_CORE( 2866): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-12 23:20:14.646+0900 D/RESOURCED( 2846): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2866
06-12 23:20:14.856+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x603424 
06-12 23:20:15.606+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x603424 
06-12 23:20:15.696+0900 E/EFL     (12047): edje<12047> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
06-12 23:20:15.696+0900 E/EFL     (12047): By the power of Grayskull, your previous Embryo stack is now broken!
06-12 23:20:15.946+0900 I/tag     (12047): insert
06-12 23:20:15.956+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:15.956+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:15.956+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:15.966+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:15.966+0900 E/EFL     (12047): edje<12047> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-12 23:20:15.966+0900 I/get     (12047): 19
06-12 23:20:15.966+0900 I/get     (12047): 19
06-12 23:20:15.966+0900 I/get     (12047): 19
06-12 23:20:15.966+0900 I/get     (12047): 19
06-12 23:20:15.976+0900 I/get     (12047): 19
06-12 23:20:15.976+0900 I/get     (12047): 19
06-12 23:20:15.976+0900 I/get     (12047): 19
06-12 23:20:15.976+0900 I/get     (12047): 19
06-12 23:20:16.946+0900 D/PROCESSMGR( 2760): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002f  register trigger_timer!  pointed_win=0x603424 
06-12 23:20:17.016+0900 I/tag     (12047): make!
06-12 23:20:17.046+0900 W/CRASH_MANAGER(12234): worker.c: worker_job(1204) > 1112047657861149727721
