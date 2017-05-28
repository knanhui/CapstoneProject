S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 19452
Date: 2017-05-09 13:41:17+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb75c8f90

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb349fb06, esi = 0xb75c8f90
ebp = 0xbf813168, esp = 0xbf813010
eax = 0xb88935f0, ebx = 0xb34a62f0
ecx = 0x00000000, edx = 0x0000000b
eip = 0xb349d423

Memory Information
MemTotal:      123 KB
MemFree:        21 KB
Buffers:         7 KB
Cached:     178820 KB
VmPeak:      99492 KB
VmSize:      99492 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22064 KB
VmRSS:       22064 KB
VmData:      32848 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33568 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 19452 TID = 19452
19452 19453 19481 19482 

Maps Information
b2bee000 b2bf8000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bfe000 b2c0a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c0b000 b2c2c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c31000 b2c32000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c33000 b2c38000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c39000 b2c3a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c3b000 b2c3d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c3e000 b2c4a000 r-xp /usr/lib/libdrm.so.2.4.0
b2c4b000 b2c55000 r-xp /usr/lib/libtbm.so.1.0.0
b2c56000 b2c6b000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c6c000 b2c7e000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3480000 b3489000 r-xp /usr/lib/libeventsystem.so.0.0.1
b348a000 b3493000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3494000 b34a6000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34a7000 b34c8000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34cf000 b34d0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34d1000 b34d2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34d3000 b34d6000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34d7000 b34da000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35e2000 b35e8000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35e9000 b372d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b373d000 b373f000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b3740000 b3743000 r-xp /usr/lib/libdri2.so.0.0.0
b3744000 b3745000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3746000 b374c000 r-xp /opt/usr/apps/org.example.example/bin/example
b374f000 b3788000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b418b000 b4196000 r-xp /lib/libnss_files-2.20-2014.11.so
b4198000 b41a3000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41a5000 b41bc000 r-xp /lib/libnsl-2.20-2014.11.so
b41c0000 b41c8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41ca000 b41ee000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41ef000 b41f0000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41f1000 b41f4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41f5000 b41fc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41fd000 b4207000 r-xp /usr/lib/libsensord-share.so
b4208000 b4224000 r-xp /usr/lib/libsensor.so.1.2.0
b4226000 b422f000 r-xp /usr/lib/libappcore-common.so.1.1
b4232000 b4234000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4249000 b424b000 r-xp /usr/lib/libXau.so.6.0.0
b424c000 b426e000 r-xp /usr/lib/libxcb.so.1.1.0
b4270000 b4279000 r-xp /lib/libcrypt-2.20-2014.11.so
b42a2000 b42a4000 r-xp /usr/lib/libiri.so
b42a5000 b42cb000 r-xp /lib/libexpat.so.1.5.2
b42cd000 b4338000 r-xp /usr/lib/libssl.so.1.0.0
b433e000 b434a000 r-xp /usr/lib/libethumb.so.1.13.0
b434b000 b434f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4350000 b45a1000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b1c000 b5b2c000 r-xp /usr/lib/libXi.so.6.1.0
b5b2d000 b5b2f000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b30000 b5b36000 r-xp /usr/lib/libXtst.so.6.1.0
b5b37000 b5b41000 r-xp /usr/lib/libXrender.so.1.3.0
b5b42000 b5b4b000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b4d000 b5b4f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b50000 b5b55000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b56000 b5b68000 r-xp /usr/lib/libXext.so.6.4.0
b5b69000 b5b6b000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b6c000 b5b6e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b70000 b5cb2000 r-xp /usr/lib/libX11.so.6.3.0
b5cb6000 b5cc0000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cc1000 b5cd7000 r-xp /usr/lib/libudev.so.1.6.0
b5cda000 b5cde000 r-xp /lib/libattr.so.1.1.0
b5cdf000 b5d0e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d10000 b5d16000 r-xp /usr/lib/libffi.so.6.0.2
b5d17000 b5d3a000 r-xp /lib/libz.so.1.2.8
b5d3b000 b5d3e000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d3f000 b5e9b000 r-xp /usr/lib/libxml2.so.2.9.2
b5ea1000 b5f88000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f95000 b5f98000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f99000 b5fbb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fbc000 b5fd0000 r-xp /lib/libresolv-2.20-2014.11.so
b5fd4000 b5ff8000 r-xp /usr/lib/liblzma.so.5.0.3
b5ff9000 b5ffb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ffd000 b6007000 r-xp /usr/lib/libembryo.so.1.13.0
b6008000 b6031000 r-xp /usr/lib/libpng12.so.0.50.0
b6032000 b607b000 r-xp /usr/lib/libjpeg.so.8.0.2
b608c000 b6093000 r-xp /lib/librt-2.20-2014.11.so
b6095000 b60b4000 r-xp /usr/lib/libector.so.1.13.0
b60b7000 b60e4000 r-xp /usr/lib/liblua-5.1.so
b60e5000 b6175000 r-xp /usr/lib/libfreetype.so.6.11.3
b6179000 b61b7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61b8000 b61ce000 r-xp /usr/lib/libfribidi.so.0.3.1
b61cf000 b6228000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b622b000 b6276000 r-xp /lib/libm-2.20-2014.11.so
b6278000 b628a000 r-xp /usr/lib/libeio.so.1.13.0
b628b000 b628e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b628f000 b6295000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6296000 b62b9000 r-xp /usr/lib/libefreet.so.1.13.0
b62bc000 b62e7000 r-xp /usr/lib/libeldbus.so.1.13.0
b62e8000 b631c000 r-xp /usr/lib/libecore_con.so.1.13.0
b631e000 b6327000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6328000 b6331000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6332000 b6345000 r-xp /usr/lib/libeo.so.1.13.0
b6347000 b635a000 r-xp /usr/lib/libecore_input.so.1.13.0
b635b000 b6362000 r-xp /usr/lib/libecore_file.so.1.13.0
b6363000 b6386000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6387000 b63b3000 r-xp /usr/lib/libeet.so.1.13.0
b63bc000 b6427000 r-xp /usr/lib/libeina.so.1.13.0
b642a000 b6441000 r-xp /usr/lib/libefl.so.1.13.0
b6443000 b65aa000 r-xp /usr/lib/libicuuc.so.51.1
b65b8000 b67c4000 r-xp /usr/lib/libicui18n.so.51.1
b67cc000 b681b000 r-xp /usr/lib/libecore_x.so.1.13.0
b681d000 b6837000 r-xp /lib/libgcc_s-4.9.so.1
b6839000 b683d000 r-xp /lib/libcap.so.2.21
b683e000 b6884000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6885000 b688c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b688e000 b68e0000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68e2000 b6a6d000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a72000 b6b40000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b43000 b6b47000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b48000 b6b57000 r-xp /usr/lib/libvconf.so.0.2.45
b6b58000 b6b5b000 r-xp /usr/lib/libvasum.so.0.3.1
b6b5c000 b6b5f000 r-xp /usr/lib/libttrace.so.1.1
b6b61000 b6b65000 r-xp /usr/lib/libiniparser.so.0
b6b66000 b6b96000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b97000 b6ba0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6ba1000 b6bc6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bc7000 b6bd7000 r-xp /usr/lib/libunwind.so.8.0.1
b6be1000 b6d8f000 r-xp /lib/libc-2.20-2014.11.so
b6d97000 b6eda000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6edc000 b6f34000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f35000 b6f69000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f6c000 b7040000 r-xp /usr/lib/libedje.so.1.13.0
b7043000 b706f000 r-xp /usr/lib/libecore.so.1.13.0
b7080000 b72a6000 r-xp /usr/lib/libevas.so.1.13.0
b72ce000 b72e6000 r-xp /lib/libpthread-2.20-2014.11.so
b72ea000 b7664000 r-xp /usr/lib/libelementary.so.1.13.0
b7684000 b7688000 r-xp /usr/lib/libsmack.so.1.0.0
b7689000 b7692000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7693000 b7696000 r-xp /usr/lib/libdlog.so.0.0.0
b7697000 b769c000 r-xp /usr/lib/libbundle.so.0.1.22
b769d000 b76a0000 r-xp /lib/libdl-2.20-2014.11.so
b76a2000 b76c7000 r-xp /usr/lib/libaul.so.0.1.0
b76ca000 b76cc000 r-xp /usr/lib/libappsvc.so.0.1.0
b76cd000 b76d2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76d3000 b76da000 r-xp /usr/lib/libappcore-efl.so.1.1
b76dc000 b76e1000 r-xp /usr/lib/libsys-assert.so
b76e4000 b76e5000 r-xp [vdso]
b76e5000 b7707000 r-xp /lib/ld-2.20-2014.11.so
b7709000 b7711000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:19452)
Call Stack Count: 22
 0: system_setting_get_locale_timezone + 0x113 (0xb349d423) [/usr/lib/libcapi-system-system-settings.so.0] + 0x9423
 1: system_settings_get_value + 0xb8 (0xb3498418) [/usr/lib/libcapi-system-system-settings.so.0] + 0x4418
 2: system_settings_get_value_string + 0x80 (0xb3498b70) [/usr/lib/libcapi-system-system-settings.so.0] + 0x4b70
 3: create_button_view + 0x474 (0xb37481e4) [/opt/usr/apps/org.example.example/bin/example] + 0x21e4
 4: diary_view_cb + 0x54 (0xb3747cb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1cb4
 5: (0xb70b4449) [/usr/lib/libevas.so.1] + 0x34449
 6: (0xb6340319) [/usr/lib/libeo.so.1] + 0xe319
 7: eo_event_callback_call + 0xb3 (0xb633dd63) [/usr/lib/libeo.so.1] + 0xbd63
 8: (0xb70b4a62) [/usr/lib/libevas.so.1] + 0x34a62
 9: (0xb70c3441) [/usr/lib/libevas.so.1] + 0x43441
10: evas_canvas_event_feed_mouse_down + 0xcf (0xb70cd20f) [/usr/lib/libevas.so.1] + 0x4d20f
11: evas_event_feed_mouse_down + 0x6a (0xb70d3c2a) [/usr/lib/libevas.so.1] + 0x53c2a
12: (0xb434d49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
13: (0xb7050055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70591b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb7059587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb74b222d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb76d6dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb76cfc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x27e (0xb3749c0e) [/opt/usr/apps/org.example.example/bin/example] + 0x3c0e
20: create_button_view + 0x3d8 (0xb770b148) [/opt/usr/apps/org.example.example/bin/example] + 0xb770b148
21: __libc_start_main + 0xde (0xb6bf8e4e) [/lib/libc.so.6] + 0x17e4e
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
sibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
05-09 13:41:11.103+0900 D/cluster-home( 2878): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
05-09 13:41:11.103+0900 D/cluster-home( 2878): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
05-09 13:41:11.103+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
05-09 13:41:11.103+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppResume(910) >  END
05-09 13:41:11.103+0900 D/cluster-view( 2878): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
05-09 13:41:11.103+0900 D/cluster-view( 2878): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
05-09 13:41:11.103+0900 D/cluster-view( 2878): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
05-09 13:41:11.103+0900 D/cluster-view( 2878): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
05-09 13:41:11.103+0900 D/cluster-view( 2878): cluster-impl.cpp: OnScrollSnapStart(613) >  TODO current page[0] new page[0]
05-09 13:41:11.103+0900 D/cluster-view( 2878): cluster-impl.cpp: OnScrollSnapStart(623) >  TODO current page[0] new page[0]
05-09 13:41:11.103+0900 D/test-log( 2878): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
05-09 13:41:11.103+0900 D/test-log( 2878): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
05-09 13:41:11.103+0900 D/cluster-view( 2878): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
05-09 13:41:11.103+0900 D/cluster-home( 2878): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
05-09 13:41:11.103+0900 D/LAUNCH  ( 2878): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
05-09 13:41:11.103+0900 D/LAUNCH  ( 2878): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
05-09 13:41:11.103+0900 D/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-09 13:41:11.103+0900 E/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-09 13:41:11.103+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 13:41:11.123+0900 I/TIZEN_N_SOUND_MANAGER( 2940): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
05-09 13:41:11.123+0900 E/TIZEN_N_SOUND_MANAGER( 2940): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-09 13:41:11.123+0900 I/TIZEN_N_SOUND_MANAGER( 2940): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
05-09 13:41:11.123+0900 E/TIZEN_N_SOUND_MANAGER( 2940): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
05-09 13:41:11.123+0900 D/DATA_PROVIDER_MASTER( 2932): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2878 is resumed
05-09 13:41:11.123+0900 D/DATA_PROVIDER_MASTER( 2932): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
05-09 13:41:11.123+0900 E/DATA_PROVIDER_MASTER( 2932): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
05-09 13:41:11.123+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
05-09 13:41:11.123+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
05-09 13:41:11.123+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
05-09 13:41:11.123+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2878 is org.tizen.homescreen
05-09 13:41:11.123+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2878 : 0
05-09 13:41:11.123+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
05-09 13:41:11.123+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
05-09 13:41:11.123+0900 W/AUL     ( 3017): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3017, appid: org.tizen.calendar.widget, status: fg
05-09 13:41:11.123+0900 D/AUL     ( 2940): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
05-09 13:41:11.143+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3017
05-09 13:41:11.143+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3017, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
05-09 13:41:11.143+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3017
05-09 13:41:11.193+0900 D/RESOURCED( 2860): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3017, appname = org.tizen.calendar.widget
05-09 13:41:11.193+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3017
05-09 13:41:11.193+0900 I/RESOURCED( 2860): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-09 13:41:11.193+0900 I/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-09 13:41:11.373+0900 D/cluster-view( 2878): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
05-09 13:41:11.373+0900 D/cluster-view( 2878): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
05-09 13:41:11.373+0900 D/cluster-view( 2878): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
05-09 13:41:11.373+0900 D/test-log( 2878): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
05-09 13:41:11.373+0900 D/test-log( 2878): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
05-09 13:41:11.373+0900 D/cluster-view( 2878): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
05-09 13:41:11.373+0900 D/cluster-home( 2878): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
05-09 13:41:13.283+0900 E/VCONF   (19458): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
05-09 13:41:13.283+0900 E/VCONF   (19458): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
05-09 13:41:13.283+0900 E/VCONF   (19458): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
05-09 13:41:13.283+0900 E/VCONF   (19458): vconf.c: vconf_get_str(2891) > vconf_get_str(19458) : db/menu_widget/language error
05-09 13:41:13.283+0900 E/PKGMGR_INFO(19458): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
05-09 13:41:13.283+0900 D/PKGMGR_INFO(19458): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:41:13.283+0900 D/PKGMGR_INFO(19458): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:41:13.353+0900 E/VCONF   (19458): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
05-09 13:41:13.353+0900 E/VCONF   (19458): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
05-09 13:41:13.353+0900 E/VCONF   (19458): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
05-09 13:41:13.353+0900 E/VCONF   (19458): vconf.c: vconf_get_str(2891) > vconf_get_str(19458) : db/menu_widget/language error
05-09 13:41:13.353+0900 E/PKGMGR_INFO(19458): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
05-09 13:41:13.353+0900 D/PKGMGR_INFO(19458): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:41:13.353+0900 D/PKGMGR_INFO(19458): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:41:13.423+0900 E/VCONF   (19458): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
05-09 13:41:13.423+0900 E/VCONF   (19458): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
05-09 13:41:13.423+0900 E/VCONF   (19458): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
05-09 13:41:13.423+0900 E/VCONF   (19458): vconf.c: vconf_get_str(2891) > vconf_get_str(19458) : db/menu_widget/language error
05-09 13:41:13.423+0900 E/PKGMGR_INFO(19458): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
05-09 13:41:13.423+0900 D/PKGMGR_INFO(19458): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:41:13.423+0900 D/PKGMGR_INFO(19458): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:41:13.493+0900 E/VCONF   (19458): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
05-09 13:41:13.493+0900 E/VCONF   (19458): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
05-09 13:41:13.493+0900 E/VCONF   (19458): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
05-09 13:41:13.493+0900 E/VCONF   (19458): vconf.c: vconf_get_str(2891) > vconf_get_str(19458) : db/menu_widget/language error
05-09 13:41:13.493+0900 E/PKGMGR_INFO(19458): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
05-09 13:41:14.333+0900 D/LAUNCH  (19470): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
05-09 13:41:14.333+0900 D/PKGMGR_INFO(19470): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
05-09 13:41:14.333+0900 D/PKGMGR_INFO(19470): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
05-09 13:41:14.333+0900 D/AUL     (19470): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 19470 is org.tizen.crash-popup
05-09 13:41:14.513+0900 D/APP_CORE(19470): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-09 13:41:14.513+0900 D/APP_CORE(19470): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
05-09 13:41:14.513+0900 D/APP_CORE(19470): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-09 13:41:14.533+0900 D/APP_CORE(19470): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-09 13:41:14.533+0900 D/APP_CORE(19470): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb7792520
05-09 13:41:14.533+0900 D/LAUNCH  (19470): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
05-09 13:41:14.553+0900 D/AUL_AMD ( 2763): amd_status.c: __app_terminate_timer_cb(442) > pid(19249)
05-09 13:41:14.553+0900 W/AUL_AMD ( 2763): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-09 13:41:14.593+0900 D/APP_CORE(19470): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-09 13:41:14.603+0900 D/LAUNCH  (19470): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
05-09 13:41:14.613+0900 D/APP_CORE(19470): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-09 13:41:14.683+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
05-09 13:41:14.683+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
05-09 13:41:14.853+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
05-09 13:41:14.863+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
05-09 13:41:14.863+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
05-09 13:41:14.863+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
05-09 13:41:14.863+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[453.00][321.00] to[453.00][321.00]!
05-09 13:41:14.863+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
05-09 13:41:14.863+0900 D/cluster-home( 2878): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [13]MenuBox clicked
05-09 13:41:14.873+0900 D/cluster-home( 2878): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
05-09 13:41:14.873+0900 D/AUL     ( 2878): service.c: __set_bundle(186) > __set_bundle
05-09 13:41:14.873+0900 D/AUL     ( 2878): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
05-09 13:41:14.873+0900 D/AUL     ( 2878): service.c: __set_bundle(186) > __set_bundle
05-09 13:41:14.873+0900 D/AUL     ( 2878): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
05-09 13:41:14.873+0900 D/AUL     ( 2878): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
05-09 13:41:14.873+0900 D/AUL     ( 2878): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
05-09 13:41:14.873+0900 D/PROCESSMGR( 2725): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40004e 
05-09 13:41:14.873+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
05-09 13:41:14.883+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-09 13:41:14.883+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
05-09 13:41:14.883+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 2878
05-09 13:41:14.883+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
05-09 13:41:14.883+0900 D/AUL_AMD ( 2763): amd_key.c: _key_grab(243) > _key_grab, win : a00002
05-09 13:41:14.883+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2448) > back key grab
05-09 13:41:14.883+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-09 13:41:14.893+0900 D/RESOURCED( 2860): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-09 13:41:14.893+0900 D/RESOURCED( 2860): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
05-09 13:41:14.893+0900 E/RESOURCED( 2860): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-09 13:41:14.893+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
05-09 13:41:14.893+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
05-09 13:41:14.893+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-09 13:41:14.893+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-09 13:41:14.893+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
05-09 13:41:14.893+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-09 13:41:14.893+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-09 13:41:14.893+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-09 13:41:14.893+0900 W/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-09 13:41:14.893+0900 D/AUL     ( 2926): process_pool.c: __send_pkt_raw_data(219) > send(13) : 884 / 884
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 19452, bin path: /opt/usr/apps/org.example.example/bin/example
05-09 13:41:14.893+0900 W/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(265) > Check app launching
05-09 13:41:14.893+0900 D/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-09 13:41:14.893+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-09 13:41:14.893+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
05-09 13:41:14.893+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-09 13:41:14.893+0900 D/AUL_PAD (19452): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-09 13:41:14.893+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-09 13:41:14.893+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-09 13:41:14.893+0900 D/AUL     (19452): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (19453) is sent.
05-09 13:41:14.903+0900 D/AUL     (19452): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 19453, signo: 10
05-09 13:41:14.903+0900 D/AUL     (19452): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-09 13:41:14.903+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTQzMDQ4NzQvODg0NTQ2AA==##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODc4AA==##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-09 13:41:14.913+0900 D/AUL_PAD (19452): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-09 13:41:14.913+0900 I/CAPI_APPFW_APPLICATION(19452): app_main.c: ui_app_main(788) > app_efl_main
05-09 13:41:14.913+0900 D/LAUNCH  (19452): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-09 13:41:14.913+0900 D/APP_CORE(19452): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-09 13:41:14.913+0900 D/APP_CORE(19452): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-09 13:41:14.913+0900 D/APP_CORE(19452): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-09 13:41:14.933+0900 D/APP_CORE(19452): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-09 13:41:14.933+0900 D/AUL     (19452): app_sock.c: __create_server_sock(156) > pg path - already exists
05-09 13:41:14.933+0900 D/APP_CORE(19452): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb422f520
05-09 13:41:14.933+0900 D/LAUNCH  (19452): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-09 13:41:14.933+0900 I/CAPI_APPFW_APPLICATION(19452): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-09 13:41:14.993+0900 D/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-09 13:41:14.993+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 19452, appid: org.example.example
05-09 13:41:14.993+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-09 13:41:14.993+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
05-09 13:41:14.993+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2700) > add app group info
05-09 13:41:14.993+0900 E/AUL     ( 2763): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-09 13:41:14.993+0900 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(427) > pid(19452) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-09 13:41:14.993+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 19452
05-09 13:41:14.993+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-09 13:41:14.993+0900 E/RESOURCED( 2860): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-09 13:41:14.993+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(888) > available memory = 294
05-09 13:41:14.993+0900 D/AUL     ( 2878): launch.c: app_request_to_launchpad(425) > launch request result : 19452
05-09 13:41:14.993+0900 E/cluster-home( 2878): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.example]
05-09 13:41:14.993+0900 D/test-log( 2878): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
05-09 13:41:15.033+0900 D/LAUNCH  (19452): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-09 13:41:15.033+0900 D/APP_CORE(19452): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-09 13:41:15.043+0900 E/E17     ( 2725): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02c00002)
05-09 13:41:15.103+0900 E/E17     ( 2725): e_border.c: e_border_show(2088) > BD_SHOW(0x02c00002)
05-09 13:41:15.113+0900 D/APP_CORE(19452): appcore.c: __aul_handler(587) > [APP 19452]     AUL event: AUL_START
05-09 13:41:15.113+0900 I/APP_CORE(19452): appcore-efl.c: __do_app(496) > [APP 19452] Event: RESET State: CREATED
05-09 13:41:15.113+0900 D/APP_CORE(19452): appcore-efl.c: __do_app(527) > [APP 19452] RESET
05-09 13:41:15.113+0900 D/LAUNCH  (19452): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-09 13:41:15.113+0900 D/APP_CORE(19452): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-09 13:41:15.113+0900 D/APP_CORE(19452): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-09 13:41:15.113+0900 I/CAPI_APPFW_APPLICATION(19452): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-09 13:41:15.113+0900 D/LAUNCH  (19452): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-09 13:41:15.113+0900 D/APP_CORE(19452): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
05-09 13:41:15.113+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:41:15.113+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:41:15.113+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:41:15.113+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:41:15.113+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:41:15.113+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:41:15.113+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:41:15.113+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:41:15.113+0900 E/EFL     (19452): edje<19452> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:41:15.113+0900 E/EFL     (19452): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:41:15.133+0900 W/PROCESSMGR( 2725): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=19452
05-09 13:41:15.143+0900 W/APP_CORE(19452): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2c00002
05-09 13:41:15.143+0900 D/APP_CORE(19452): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2c00002
05-09 13:41:15.143+0900 D/APP_CORE(19452): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-09 13:41:15.143+0900 D/AUL     (19452): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-09 13:41:15.143+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 34
05-09 13:41:15.153+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 13:41:15.153+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 13:41:15.173+0900 D/INDICATOR( 2864): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-09 13:41:15.173+0900 D/INDICATOR( 2864): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-09 13:41:15.173+0900 D/INDICATOR( 2864): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-09 13:41:15.173+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
05-09 13:41:15.173+0900 D/INDICATOR( 2864): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-09 13:41:15.173+0900 D/INDICATOR( 2864): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-09 13:41:15.173+0900 D/INDICATOR( 2864): main.c: _rotate_window(252) > port :: hide more icon
05-09 13:41:15.173+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:41:15.173+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:41:15.173+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 19452 is org.example.example
05-09 13:41:15.173+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 19452 : 0
05-09 13:41:15.173+0900 D/AUL     ( 2940): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-09 13:41:15.433+0900 E/RESOURCED( 2860): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
05-09 13:41:15.503+0900 D/APP_CORE(19452): appcore.c: __prt_ltime(236) > [APP 19452] first idle after reset: 628 msec
05-09 13:41:15.533+0900 E/E17     ( 2725): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-09 13:41:15.543+0900 D/APP_CORE( 2878): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-09 13:41:15.543+0900 D/APP_CORE( 2878): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-09 13:41:15.543+0900 D/APP_CORE( 2878): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-09 13:41:15.543+0900 I/APP_CORE( 2878): appcore-efl.c: __do_app(496) > [APP 2878] Event: PAUSE State: RUNNING
05-09 13:41:15.543+0900 D/APP_CORE( 2878): appcore-efl.c: __do_app(565) > [APP 2878] PAUSE
05-09 13:41:15.543+0900 I/CAPI_APPFW_APPLICATION( 2878): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-09 13:41:15.543+0900 E/cluster-home( 2878): homescreen.cpp: OnPause(84) >  app pause
05-09 13:41:15.543+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-09 13:41:15.543+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppPause(923) >  END
05-09 13:41:15.543+0900 D/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-09 13:41:15.543+0900 E/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-09 13:41:15.543+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(2878) status(4)
05-09 13:41:15.543+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(2878) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-09 13:41:15.543+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-09 13:41:15.543+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2878, appid: org.tizen.homescreen, status: bg
05-09 13:41:15.553+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2891) > pid(19452) status(3)
05-09 13:41:15.553+0900 D/AUL_AMD ( 2763): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-09 13:41:15.613+0900 D/APP_CORE(19452): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
05-09 13:41:15.613+0900 D/APP_CORE(19452): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-09 13:41:15.613+0900 D/APP_CORE(19452): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-09 13:41:15.613+0900 I/APP_CORE(19452): appcore-efl.c: __do_app(496) > [APP 19452] Event: RESUME State: CREATED
05-09 13:41:15.613+0900 D/LAUNCH  (19452): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-09 13:41:15.613+0900 D/APP_CORE(19452): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-09 13:41:15.613+0900 D/APP_CORE(19452): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-09 13:41:15.613+0900 D/APP_CORE(19452): appcore-efl.c: __do_app(607) > [APP 19452] RESUME
05-09 13:41:15.613+0900 D/DATA_PROVIDER_MASTER( 2932): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2878 is paused
05-09 13:41:15.613+0900 D/DATA_PROVIDER_MASTER( 2932): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-09 13:41:15.613+0900 I/APP_CORE(19452): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-09 13:41:15.613+0900 I/APP_CORE(19452): appcore-efl.c: __do_app(614) > [APP 19452] Initial Launching, call the resume_cb
05-09 13:41:15.613+0900 I/CAPI_APPFW_APPLICATION(19452): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-09 13:41:15.613+0900 D/LAUNCH  (19452): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-09 13:41:15.613+0900 D/LAUNCH  (19452): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-09 13:41:15.613+0900 D/APP_CORE(19452): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-09 13:41:15.613+0900 E/APP_CORE(19452): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-09 13:41:15.613+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-09 13:41:15.613+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-09 13:41:15.613+0900 W/AUL     ( 3017): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3017, appid: org.tizen.calendar.widget, status: bg
05-09 13:41:15.613+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2897) > back key ungrab
05-09 13:41:15.613+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(19452) status(3)
05-09 13:41:15.613+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(19452) appid(org.example.example) pkgid(org.example.example) status(3)
05-09 13:41:15.613+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-09 13:41:15.613+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 19452, appid: org.example.example, status: fg
05-09 13:41:15.613+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3017, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-09 13:41:15.613+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3017
05-09 13:41:15.613+0900 D/RESOURCED( 2860): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3017, appname = org.tizen.calendar.widget
05-09 13:41:15.613+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3017
05-09 13:41:15.623+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 19452
05-09 13:41:15.623+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 19452, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-09 13:41:15.623+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 19452
05-09 13:41:15.683+0900 D/RESOURCED( 2860): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 19452, appname = org.example.example, pkgname = org.example.example
05-09 13:41:15.683+0900 D/RESOURCED( 2860): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 19452, appname = org.example.example
05-09 13:41:15.683+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 19452
05-09 13:41:15.683+0900 I/RESOURCED( 2860): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-09 13:41:15.683+0900 I/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-09 13:41:15.783+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2910) > pid(19452) status(0)
05-09 13:41:15.993+0900 D/AUL_PAD ( 2926): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-09 13:41:15.993+0900 D/AUL_PAD (19490): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-09 13:41:16.023+0900 D/AUL_PAD ( 2926): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-09 13:41:16.503+0900 D/AUL_AMD ( 2763): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-09 13:41:16.503+0900 D/RUA     ( 2763): rua.c: rua_add_history(179) > rua_add_history start
05-09 13:41:16.533+0900 D/RUA     ( 2763): rua.c: rua_add_history(247) > rua_add_history ok
05-09 13:41:16.983+0900 E/CAPI_NETWORK_WIFI( 2864): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-09 13:41:16.993+0900 E/INDICATOR( 2864): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001fcff)
05-09 13:41:16.993+0900 E/INDICATOR( 2864): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-09 13:41:16.993+0900 E/INDICATOR( 2864): 
05-09 13:41:17.043+0900 D/AUL_PAD (19490): launchpad_loader.c: main(588) > sleeping 1 sec...
05-09 13:41:17.043+0900 D/AUL_PAD (19490): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-09 13:41:17.063+0900 D/AUL_PAD (19490): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b836e760
05-09 13:41:17.073+0900 D/AUL_PAD (19490): preload.h: __preload_init(69) > get pre-initialization function
05-09 13:41:17.073+0900 D/AUL_PAD (19490): preload.h: __preload_init(73) > get shutdown function
05-09 13:41:17.073+0900 D/AUL_PAD (19490): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b836ea40
05-09 13:41:17.073+0900 D/AUL_PAD (19490): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8370640
05-09 13:41:17.073+0900 D/AUL_PAD (19490): preload.h: __preload_init(69) > get pre-initialization function
05-09 13:41:17.073+0900 D/AUL_PAD (19490): preload.h: __preload_init(73) > get shutdown function
05-09 13:41:17.073+0900 D/AUL_PAD (19490): preexec.h: __preexec_init(76) > preexec start
05-09 13:41:17.073+0900 D/AUL_PAD (19490): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-09 13:41:17.073+0900 D/AUL     (19490): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-09 13:41:17.073+0900 D/AUL     (19490): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-09 13:41:17.073+0900 D/AUL     (19490): process_pool.c: __connect_to_launchpad(132) > send(19490) : 4
05-09 13:41:17.073+0900 D/AUL     (19490): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-09 13:41:17.073+0900 D/AUL_PAD ( 2926): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-09 13:41:17.083+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-09 13:41:17.083+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-09 13:41:17.083+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-09 13:41:17.083+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-09 13:41:17.083+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-09 13:41:17.083+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-09 13:41:17.083+0900 D/AUL_PAD ( 2926): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-09 13:41:17.083+0900 D/AUL_PAD ( 2926): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 19490
05-09 13:41:17.213+0900 E/TIZEN_N_SYSTEM_SETTINGS(19452): system_settings.c: system_settings_get_value_string(540) > Enter [system_settings_get_value_string]
05-09 13:41:17.213+0900 E/TIZEN_N_SYSTEM_SETTINGS(19452): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
05-09 13:41:17.213+0900 E/TIZEN_N_SYSTEM_SETTINGS(19452): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
05-09 13:41:17.213+0900 E/TIZEN_N_SYSTEM_SETTINGS(19452): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
05-09 13:41:17.213+0900 D/SYSTEM-SETTINGS(19452): system_setting_platform.c: system_setting_get_locale_timezone(1620) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_timezone. [0m
05-09 13:41:17.213+0900 I/SYSTEM-SETTINGS(19452): system_setting_platform.c: system_setting_get_locale_timezone(1631) > [SECURE_LOG] [0;36mtzpath : Asia/Seoul [0m
05-09 13:41:17.233+0900 W/CRASH_MANAGER(19458): worker.c: worker_job(1204) > 1119452657861149430487
