S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 6019
Date: 2017-06-01 12:52:14+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x14

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb7b9aa20, esi = 0x8001b4db
ebp = 0xbfbe6528, esp = 0xbfbe64f0
eax = 0x00000000, ebx = 0xb73745f0
ecx = 0x00000390, edx = 0x00000015
eip = 0xb71cbbbf

Memory Information
MemTotal:      123 KB
MemFree:        32 KB
Buffers:         5 KB
Cached:     165468 KB
VmPeak:     100304 KB
VmSize:     100304 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22080 KB
VmRSS:       22080 KB
VmData:      32752 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34456 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 6019 TID = 6019
6019 6020 6061 6062 

Maps Information
b2bd7000 b2be1000 r-xp /usr/lib/libfeedback.so.0.1.4
b2be7000 b2bf3000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bf4000 b2c15000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c1a000 b2c1b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c1c000 b2c21000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c22000 b2c23000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c24000 b2c26000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c27000 b2c33000 r-xp /usr/lib/libdrm.so.2.4.0
b2c34000 b2c37000 r-xp /usr/lib/libdri2.so.0.0.0
b2c38000 b2c42000 r-xp /usr/lib/libtbm.so.1.0.0
b2c43000 b2c58000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c59000 b2c6b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b346d000 b349e000 r-xp /usr/lib/libidn.so.11.5.44
b349f000 b34c1000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34c2000 b34d2000 r-xp /usr/lib/libcares.so.2.1.0
b34d3000 b34dc000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34dd000 b34e6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34e7000 b355e000 r-xp /usr/lib/libcurl.so.4.3.0
b3560000 b3572000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3573000 b3594000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b359b000 b359c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b359d000 b359e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b359f000 b35a2000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35a3000 b35a6000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36ae000 b36b4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36b5000 b37f9000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3809000 b380b000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b380c000 b380d000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b380e000 b3818000 r-xp /opt/usr/apps/org.example.example/bin/example
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

Callstack Information (PID:6019)
Call Stack Count: 41
 0: (0xb71cbbbf) [/usr/lib/libevas.so.1] + 0x7fbbf
 1: (0xb71bdce8) [/usr/lib/libevas.so.1] + 0x71ce8
 2: evas_obj_size_hint_min_set + 0xb9 (0xb71b8629) [/usr/lib/libevas.so.1] + 0x6c629
 3: evas_object_size_hint_min_set + 0x60 (0xb71c5fa0) [/usr/lib/libevas.so.1] + 0x79fa0
 4: (0xb75c9d29) [/usr/lib/libelementary.so.1] + 0x213d29
 5: elm_obj_layout_sizing_eval + 0x99 (0xb7561559) [/usr/lib/libelementary.so.1] + 0x1ab559
 6: (0xb7568205) [/usr/lib/libelementary.so.1] + 0x1b2205
 7: evas_obj_smart_add + 0x99 (0xb71d6809) [/usr/lib/libevas.so.1] + 0x8a809
 8: (0xb755a79a) [/usr/lib/libelementary.so.1] + 0x1a479a
 9: evas_obj_smart_add + 0x99 (0xb71d6809) [/usr/lib/libevas.so.1] + 0x8a809
10: (0xb75ce27b) [/usr/lib/libelementary.so.1] + 0x21827b
11: evas_obj_smart_add + 0x99 (0xb71d6809) [/usr/lib/libevas.so.1] + 0x8a809
12: (0xb71d9d8b) [/usr/lib/libevas.so.1] + 0x8dd8b
13: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
14: (0xb76274a6) [/usr/lib/libelementary.so.1] + 0x2714a6
15: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
16: (0xb7569c37) [/usr/lib/libelementary.so.1] + 0x1b3c37
17: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
18: (0xb755a879) [/usr/lib/libelementary.so.1] + 0x1a4879
19: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
20: (0xb75ce7c2) [/usr/lib/libelementary.so.1] + 0x2187c2
21: eo_constructor + 0x99 (0xb6408899) [/usr/lib/libeo.so.1] + 0xa899
22: elm_scroller_add + 0x77 (0xb75ccdb7) [/usr/lib/libelementary.so.1] + 0x216db7
23: setting_view_cb + 0x75 (0xb3816535) [/opt/usr/apps/org.example.example/bin/example] + 0x8535
24: (0xb7180449) [/usr/lib/libevas.so.1] + 0x34449
25: (0xb640c319) [/usr/lib/libeo.so.1] + 0xe319
26: eo_event_callback_call + 0xb3 (0xb6409d63) [/usr/lib/libeo.so.1] + 0xbd63
27: (0xb7180a62) [/usr/lib/libevas.so.1] + 0x34a62
28: (0xb718f441) [/usr/lib/libevas.so.1] + 0x43441
29: evas_canvas_event_feed_mouse_down + 0xcf (0xb719920f) [/usr/lib/libevas.so.1] + 0x4d20f
30: evas_event_feed_mouse_down + 0x6a (0xb719fc2a) [/usr/lib/libevas.so.1] + 0x53c2a
31: (0xb441949c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
32: (0xb711c055) [/usr/lib/libecore.so.1] + 0xd055
33: (0xb71251b9) [/usr/lib/libecore.so.1] + 0x161b9
34: ecore_main_loop_begin + 0x57 (0xb7125587) [/usr/lib/libecore.so.1] + 0x16587
35: elm_run + 0x2d (0xb757e22d) [/usr/lib/libelementary.so.1] + 0x1c822d
36: appcore_efl_main + 0x4de (0xb77a2dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
37: ui_app_main + 0x140 (0xb779bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
38: main + 0x2a5 (0xb3815605) [/opt/usr/apps/org.example.example/bin/example] + 0x7605
39: (0xb77d7148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77d7148
40: __libc_start_main + 0xde (0xb6cc4e4e) [/lib/libc.so.6] + 0x17e4e
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
pl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
06-01 12:51:59.388+0900 D/test-log( 2945): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-01 12:51:59.388+0900 D/cluster-view( 2945): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
06-01 12:51:59.388+0900 D/cluster-home( 2945): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
06-01 12:51:59.388+0900 D/LAUNCH  ( 2945): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
06-01 12:51:59.388+0900 D/LAUNCH  ( 2945): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
06-01 12:51:59.388+0900 D/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:51:59.388+0900 E/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:51:59.398+0900 I/TIZEN_N_SOUND_MANAGER( 3022): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
06-01 12:51:59.398+0900 E/TIZEN_N_SOUND_MANAGER( 3022): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-01 12:51:59.398+0900 I/TIZEN_N_SOUND_MANAGER( 3022): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
06-01 12:51:59.398+0900 E/TIZEN_N_SOUND_MANAGER( 3022): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-01 12:51:59.398+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 12:51:59.398+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
06-01 12:51:59.398+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
06-01 12:51:59.408+0900 D/AUL_AMD ( 2858): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2945 is org.tizen.homescreen
06-01 12:51:59.408+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2945 : 0
06-01 12:51:59.408+0900 D/AUL     ( 3022): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
06-01 12:51:59.408+0900 D/DATA_PROVIDER_MASTER( 3009): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2945 is resumed
06-01 12:51:59.408+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
06-01 12:51:59.408+0900 E/DATA_PROVIDER_MASTER( 3009): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
06-01 12:51:59.408+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
06-01 12:51:59.408+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
06-01 12:51:59.408+0900 W/AUL     ( 3084): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3084, appid: org.tizen.calendar.widget, status: fg
06-01 12:51:59.408+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3084
06-01 12:51:59.408+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3084, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
06-01 12:51:59.408+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3084
06-01 12:51:59.448+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3084, appname = org.tizen.calendar.widget
06-01 12:51:59.448+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3084
06-01 12:51:59.448+0900 I/RESOURCED( 2893): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 12:51:59.448+0900 I/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 12:51:59.668+0900 D/cluster-view( 2945): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
06-01 12:51:59.668+0900 D/cluster-view( 2945): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
06-01 12:51:59.668+0900 D/cluster-view( 2945): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
06-01 12:51:59.668+0900 D/test-log( 2945): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
06-01 12:51:59.668+0900 D/test-log( 2945): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-01 12:51:59.668+0900 D/cluster-view( 2945): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
06-01 12:51:59.668+0900 D/cluster-home( 2945): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
06-01 12:52:00.408+0900 D/INDICATOR( 2934): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-01 12:52:00.408+0900 D/INDICATOR( 2934): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-01 12:52:00.408+0900 D/INDICATOR( 2934): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-01 12:52:00.408+0900 D/INDICATOR( 2934): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 12:52 5 h"
06-01 12:52:00.408+0900 D/INDICATOR( 2934): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 12:52"
06-01 12:52:00.408+0900 D/INDICATOR( 2934): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 12&#x2236;52"
06-01 12:52:00.408+0900 D/INDICATOR( 2934): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147081966 Time: <font_size=33>12&#x2236;52</font_size> <font_size=32>PM</font_size></font>
06-01 12:52:00.858+0900 E/VCONF   ( 5816): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 12:52:00.858+0900 E/VCONF   ( 5816): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 12:52:00.858+0900 E/VCONF   ( 5816): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 12:52:00.868+0900 E/VCONF   ( 5816): vconf.c: vconf_get_str(2891) > vconf_get_str(5816) : db/menu_widget/language error
06-01 12:52:00.868+0900 E/PKGMGR_INFO( 5816): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 12:52:00.868+0900 D/PKGMGR_INFO( 5816): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:00.868+0900 D/PKGMGR_INFO( 5816): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:00.928+0900 E/VCONF   ( 5816): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 12:52:00.928+0900 E/VCONF   ( 5816): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 12:52:00.928+0900 E/VCONF   ( 5816): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 12:52:00.928+0900 E/VCONF   ( 5816): vconf.c: vconf_get_str(2891) > vconf_get_str(5816) : db/menu_widget/language error
06-01 12:52:00.928+0900 E/PKGMGR_INFO( 5816): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 12:52:00.928+0900 D/PKGMGR_INFO( 5816): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:00.928+0900 D/PKGMGR_INFO( 5816): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:00.998+0900 E/VCONF   ( 5816): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 12:52:00.998+0900 E/VCONF   ( 5816): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 12:52:00.998+0900 E/VCONF   ( 5816): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 12:52:00.998+0900 E/VCONF   ( 5816): vconf.c: vconf_get_str(2891) > vconf_get_str(5816) : db/menu_widget/language error
06-01 12:52:00.998+0900 E/PKGMGR_INFO( 5816): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 12:52:00.998+0900 D/PKGMGR_INFO( 5816): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:00.998+0900 D/PKGMGR_INFO( 5816): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:01.068+0900 E/VCONF   ( 5816): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
06-01 12:52:01.068+0900 E/VCONF   ( 5816): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
06-01 12:52:01.068+0900 E/VCONF   ( 5816): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
06-01 12:52:01.068+0900 E/VCONF   ( 5816): vconf.c: vconf_get_str(2891) > vconf_get_str(5816) : db/menu_widget/language error
06-01 12:52:01.068+0900 E/PKGMGR_INFO( 5816): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
06-01 12:52:01.868+0900 D/LAUNCH  ( 6029): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
06-01 12:52:01.868+0900 D/PKGMGR_INFO( 6029): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
06-01 12:52:01.868+0900 D/PKGMGR_INFO( 6029): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
06-01 12:52:01.868+0900 D/AUL     ( 6029): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 6029 is org.tizen.crash-popup
06-01 12:52:02.058+0900 D/APP_CORE( 6029): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 12:52:02.058+0900 D/APP_CORE( 6029): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
06-01 12:52:02.058+0900 D/APP_CORE( 6029): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 12:52:02.068+0900 D/APP_CORE( 6029): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 12:52:02.078+0900 D/AUL     ( 6029): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 12:52:02.078+0900 D/APP_CORE( 6029): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb779c520
06-01 12:52:02.078+0900 D/LAUNCH  ( 6029): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
06-01 12:52:02.098+0900 E/CAPI_NETWORK_WIFI( 2934): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-01 12:52:02.108+0900 E/INDICATOR( 2934): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001fafe)
06-01 12:52:02.108+0900 E/INDICATOR( 2934): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-01 12:52:02.108+0900 E/INDICATOR( 2934): 
06-01 12:52:02.138+0900 D/APP_CORE( 6029): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 12:52:02.158+0900 D/LAUNCH  ( 6029): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
06-01 12:52:02.158+0900 D/APP_CORE( 6029): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 12:52:02.488+0900 E/RESOURCED( 2893): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
06-01 12:52:05.188+0900 E/EFL     ( 6029): eldbus<6029> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-mhT1B4cZWR: Connection refused
06-01 12:52:05.188+0900 E/EFL     ( 6029): <6029> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
06-01 12:52:05.188+0900 E/EFL     ( 6029): elementary<6029> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
06-01 12:52:05.188+0900 D/APP_CORE( 6029): appcore.c: __aul_handler(587) > [APP 6029]     AUL event: AUL_START
06-01 12:52:05.188+0900 I/APP_CORE( 6029): appcore-efl.c: __do_app(496) > [APP 6029] Event: RESET State: CREATED
06-01 12:52:05.188+0900 D/APP_CORE( 6029): appcore-efl.c: __do_app(527) > [APP 6029] RESET
06-01 12:52:05.188+0900 D/LAUNCH  ( 6029): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
06-01 12:52:05.188+0900 D/APP_CORE( 6029): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 12:52:05.188+0900 D/APP_CORE( 6029): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:52:05.188+0900 E/SYSPOPUP( 6029): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-01 12:52:05.188+0900 E/SYSPOPUP( 6029): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-01 12:52:05.188+0900 E/SYSPOPUP( 6029): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
06-01 12:52:05.188+0900 D/LAUNCH  ( 6029): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
06-01 12:52:05.188+0900 D/APP_CORE( 6029): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-01 12:52:05.228+0900 D/AUL     ( 6029): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-01 12:52:05.238+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 22
06-01 12:52:05.238+0900 W/AUL_AMD ( 2858): amd_request.c: __request_handler(1056) > app status : 5
06-01 12:52:05.238+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(6029) status(5)
06-01 12:52:05.238+0900 D/APP_CORE( 6029): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-01 12:52:05.238+0900 E/EFL     ( 6029): eo<6029> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
06-01 12:52:05.248+0900 E/EFL     ( 6029): eo<6029> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
06-01 12:52:12.938+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
06-01 12:52:12.938+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
06-01 12:52:12.978+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
06-01 12:52:12.978+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
06-01 12:52:12.978+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
06-01 12:52:12.978+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
06-01 12:52:12.978+0900 D/test-log( 2945): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[445.00][343.00] to[445.00][343.00]!
06-01 12:52:12.978+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
06-01 12:52:12.978+0900 D/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [29]MenuBox clicked
06-01 12:52:12.978+0900 D/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200050 
06-01 12:52:13.008+0900 D/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
06-01 12:52:13.008+0900 D/AUL     ( 2945): service.c: __set_bundle(186) > __set_bundle
06-01 12:52:13.008+0900 D/AUL     ( 2945): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
06-01 12:52:13.008+0900 D/AUL     ( 2945): service.c: __set_bundle(186) > __set_bundle
06-01 12:52:13.008+0900 D/AUL     ( 2945): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
06-01 12:52:13.008+0900 D/AUL     ( 2945): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
06-01 12:52:13.008+0900 D/AUL     ( 2945): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
06-01 12:52:13.008+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 0
06-01 12:52:13.018+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-01 12:52:13.018+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
06-01 12:52:13.018+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2233) > caller pid : 2945
06-01 12:52:13.028+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2443) > win(c00002) ecore_x_pointer_grab(1)
06-01 12:52:13.028+0900 D/AUL_AMD ( 2858): amd_key.c: _key_grab(243) > _key_grab, win : c00002
06-01 12:52:13.048+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2448) > back key grab
06-01 12:52:13.048+0900 W/AUL_AMD ( 2858): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-01 12:52:13.058+0900 D/RESOURCED( 2893): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-01 12:52:13.058+0900 D/RESOURCED( 2893): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-01 12:52:13.058+0900 E/RESOURCED( 2893): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-01 12:52:13.058+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
06-01 12:52:13.058+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2648) > process_pool: false
06-01 12:52:13.058+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-01 12:52:13.058+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-01 12:52:13.058+0900 W/AUL_AMD ( 2858): amd_launch.c: _start_app(2665) > pad pid(-5)
06-01 12:52:13.058+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-01 12:52:13.058+0900 D/AUL_AMD ( 2858): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-01 12:52:13.058+0900 D/AUL     ( 2858): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-01 12:52:13.058+0900 D/AUL_PAD ( 3003): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-01 12:52:13.058+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-01 12:52:13.058+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-01 12:52:13.058+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-01 12:52:13.058+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-01 12:52:13.058+0900 D/AUL_PAD ( 3003): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-01 12:52:13.058+0900 D/AUL_PAD ( 3003): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-01 12:52:13.058+0900 D/AUL_PAD ( 3003): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-01 12:52:13.068+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-01 12:52:13.068+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-01 12:52:13.068+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-01 12:52:13.068+0900 D/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-01 12:52:13.068+0900 D/AUL_PAD ( 3003): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-01 12:52:13.068+0900 D/AUL_PAD ( 3003): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-01 12:52:13.068+0900 W/AUL_PAD ( 3003): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-01 12:52:13.068+0900 D/AUL     ( 3003): process_pool.c: __send_pkt_raw_data(219) > send(11) : 884 / 884
06-01 12:52:13.068+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 6019, bin path: /opt/usr/apps/org.example.example/bin/example
06-01 12:52:13.068+0900 W/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(265) > Check app launching
06-01 12:52:13.068+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-01 12:52:13.068+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-01 12:52:13.068+0900 D/RESOURCED( 2893): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-01 12:52:13.068+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
06-01 12:52:13.068+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-01 12:52:13.068+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-01 12:52:13.068+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-01 12:52:13.068+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-01 12:52:13.068+0900 D/AUL     ( 6019): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (6020) is sent.
06-01 12:52:13.068+0900 I/RESOURCED( 2893): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-01 12:52:13.068+0900 D/RESOURCED( 2893): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-01 12:52:13.068+0900 I/RESOURCED( 2893): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-01 12:52:13.068+0900 D/AUL     ( 6019): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 6020, signo: 10
06-01 12:52:13.078+0900 D/AUL     ( 6019): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : MwAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEQAAADE0OTYyODkxMzMvMTg0NTYA##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyOTQ1AA==##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-01 12:52:13.078+0900 D/AUL_PAD ( 6019): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-01 12:52:13.078+0900 I/CAPI_APPFW_APPLICATION( 6019): app_main.c: ui_app_main(788) > app_efl_main
06-01 12:52:13.078+0900 D/LAUNCH  ( 6019): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-01 12:52:13.078+0900 D/APP_CORE( 6019): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-01 12:52:13.078+0900 D/APP_CORE( 6019): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-01 12:52:13.078+0900 D/APP_CORE( 6019): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-01 12:52:13.118+0900 D/APP_CORE( 6019): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-01 12:52:13.118+0900 D/AUL     ( 6019): app_sock.c: __create_server_sock(156) > pg path - already exists
06-01 12:52:13.118+0900 D/APP_CORE( 6019): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb42fb520
06-01 12:52:13.118+0900 D/LAUNCH  ( 6019): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-01 12:52:13.118+0900 I/CAPI_APPFW_APPLICATION( 6019): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-01 12:52:13.168+0900 D/AUL_PAD ( 3003): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-01 12:52:13.178+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 6019, appid: org.example.example
06-01 12:52:13.178+0900 D/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-01 12:52:13.178+0900 E/AUL     ( 2858): simple_util.c: __trm_app_info_send_socket(330) > access
06-01 12:52:13.178+0900 D/AUL_AMD ( 2858): amd_launch.c: _start_app(2700) > add app group info
06-01 12:52:13.178+0900 E/AUL     ( 2858): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-01 12:52:13.178+0900 D/AUL_AMD ( 2858): amd_status.c: _status_add_app_info_list(427) > pid(6019) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-01 12:52:13.178+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 6019
06-01 12:52:13.178+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-01 12:52:13.178+0900 E/RESOURCED( 2893): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-01 12:52:13.178+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(888) > available memory = 321
06-01 12:52:13.178+0900 D/AUL     ( 2945): launch.c: app_request_to_launchpad(425) > launch request result : 6019
06-01 12:52:13.178+0900 E/cluster-home( 2945): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.example]
06-01 12:52:13.178+0900 D/test-log( 2945): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
06-01 12:52:13.368+0900 D/LAUNCH  ( 6019): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-01 12:52:13.378+0900 D/APP_CORE( 6019): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-01 12:52:13.388+0900 E/E17     ( 2741): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02800002)
06-01 12:52:13.418+0900 D/APP_CORE( 6019): appcore.c: __aul_handler(587) > [APP 6019]     AUL event: AUL_START
06-01 12:52:13.418+0900 I/APP_CORE( 6019): appcore-efl.c: __do_app(496) > [APP 6019] Event: RESET State: CREATED
06-01 12:52:13.418+0900 D/APP_CORE( 6019): appcore-efl.c: __do_app(527) > [APP 6019] RESET
06-01 12:52:13.418+0900 D/LAUNCH  ( 6019): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-01 12:52:13.418+0900 D/APP_CORE( 6019): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-01 12:52:13.428+0900 D/APP_CORE( 6019): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:52:13.428+0900 I/CAPI_APPFW_APPLICATION( 6019): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-01 12:52:13.428+0900 D/LAUNCH  ( 6019): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-01 12:52:13.428+0900 D/APP_CORE( 6019): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
06-01 12:52:13.428+0900 E/EFL     ( 6019): edje<6019> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:13.428+0900 E/EFL     ( 6019): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:13.428+0900 E/EFL     ( 6019): edje<6019> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:13.428+0900 E/EFL     ( 6019): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:13.428+0900 E/EFL     ( 6019): edje<6019> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:13.428+0900 E/EFL     ( 6019): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:13.428+0900 E/EFL     ( 6019): edje<6019> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:13.428+0900 E/EFL     ( 6019): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:13.428+0900 E/EFL     ( 6019): edje<6019> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-01 12:52:13.428+0900 E/EFL     ( 6019): By the power of Grayskull, your previous Embryo stack is now broken!
06-01 12:52:13.508+0900 E/E17     ( 2741): e_border.c: e_border_show(2088) > BD_SHOW(0x02800002)
06-01 12:52:13.548+0900 W/PROCESSMGR( 2741): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=6019
06-01 12:52:13.558+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:52:13.568+0900 D/APP_CORE( 6019): appcore.c: __prt_ltime(236) > [APP 6019] first idle after reset: 560 msec
06-01 12:52:13.578+0900 E/EFL     ( 2741): eo<2741> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-01 12:52:13.588+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 15
06-01 12:52:13.588+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:13.588+0900 D/PKGMGR_INFO( 2858): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-01 12:52:13.598+0900 D/AUL_AMD ( 2858): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 6019 is org.example.example
06-01 12:52:13.598+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 6019 : 0
06-01 12:52:13.598+0900 D/AUL     ( 3022): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-01 12:52:13.608+0900 D/INDICATOR( 2934): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-01 12:52:13.608+0900 W/APP_CORE( 6019): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2800002
06-01 12:52:13.608+0900 D/APP_CORE( 6019): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2800002
06-01 12:52:13.608+0900 D/APP_CORE( 6019): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-01 12:52:13.608+0900 D/AUL     ( 6019): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-01 12:52:13.608+0900 D/AUL_AMD ( 2858): amd_request.c: __request_handler(838) > __request_handler: 34
06-01 12:52:13.608+0900 D/INDICATOR( 2934): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-01 12:52:13.618+0900 D/INDICATOR( 2934): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-01 12:52:13.618+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-01 12:52:13.618+0900 D/INDICATOR( 2934): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-01 12:52:13.618+0900 D/INDICATOR( 2934): main.c: _rotate_window(252) > port :: hide more icon
06-01 12:52:14.068+0900 E/E17     ( 2741): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-01 12:52:14.068+0900 D/APP_CORE( 2945): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-01 12:52:14.068+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-01 12:52:14.068+0900 D/APP_CORE( 2945): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-01 12:52:14.068+0900 I/APP_CORE( 2945): appcore-efl.c: __do_app(496) > [APP 2945] Event: PAUSE State: RUNNING
06-01 12:52:14.068+0900 D/APP_CORE( 2945): appcore-efl.c: __do_app(565) > [APP 2945] PAUSE
06-01 12:52:14.068+0900 I/CAPI_APPFW_APPLICATION( 2945): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-01 12:52:14.068+0900 E/cluster-home( 2945): homescreen.cpp: OnPause(84) >  app pause
06-01 12:52:14.068+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-01 12:52:14.068+0900 D/cluster-view( 2945): homescreen-view-manager.cpp: AppPause(923) >  END
06-01 12:52:14.068+0900 D/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:52:14.068+0900 E/APP_CORE( 2945): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:52:14.078+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(2945) status(4)
06-01 12:52:14.078+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(2945) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-01 12:52:14.078+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-01 12:52:14.078+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2945, appid: org.tizen.homescreen, status: bg
06-01 12:52:14.088+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2891) > pid(6019) status(3)
06-01 12:52:14.088+0900 D/AUL_AMD ( 2858): amd_key.c: _key_ungrab(265) > _key_ungrab, win : c00002
06-01 12:52:14.088+0900 D/DATA_PROVIDER_MASTER( 3009): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2945 is paused
06-01 12:52:14.088+0900 D/DATA_PROVIDER_MASTER( 3009): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-01 12:52:14.098+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-01 12:52:14.098+0900 I/CAPI_WIDGET_APPLICATION( 3084): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-01 12:52:14.098+0900 W/AUL     ( 3084): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3084, appid: org.tizen.calendar.widget, status: bg
06-01 12:52:14.098+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3084, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-01 12:52:14.098+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3084
06-01 12:52:14.098+0900 D/RESOURCED( 2893): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3084, appname = org.tizen.calendar.widget
06-01 12:52:14.098+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3084
06-01 12:52:14.108+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2897) > back key ungrab
06-01 12:52:14.108+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(456) > pid(6019) status(3)
06-01 12:52:14.108+0900 D/AUL_AMD ( 2858): amd_status.c: _status_update_app_info_list(468) > pid(6019) appid(org.example.example) pkgid(org.example.example) status(3)
06-01 12:52:14.108+0900 D/AUL     ( 2858): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-01 12:52:14.108+0900 W/AUL     ( 2858): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6019, appid: org.example.example, status: fg
06-01 12:52:14.118+0900 D/RESOURCED( 2893): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 6019
06-01 12:52:14.118+0900 D/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6019, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-01 12:52:14.118+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 6019
06-01 12:52:14.158+0900 D/APP_CORE( 6019): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2800002 fully_obscured 0
06-01 12:52:14.158+0900 D/APP_CORE( 6019): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-01 12:52:14.158+0900 D/APP_CORE( 6019): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-01 12:52:14.158+0900 I/APP_CORE( 6019): appcore-efl.c: __do_app(496) > [APP 6019] Event: RESUME State: CREATED
06-01 12:52:14.158+0900 D/LAUNCH  ( 6019): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-01 12:52:14.158+0900 D/APP_CORE( 6019): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-01 12:52:14.158+0900 D/APP_CORE( 6019): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-01 12:52:14.158+0900 D/APP_CORE( 6019): appcore-efl.c: __do_app(607) > [APP 6019] RESUME
06-01 12:52:14.158+0900 I/APP_CORE( 6019): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-01 12:52:14.158+0900 D/AUL_AMD ( 2858): amd_launch.c: __e17_status_handler(2910) > pid(6019) status(0)
06-01 12:52:14.158+0900 I/APP_CORE( 6019): appcore-efl.c: __do_app(614) > [APP 6019] Initial Launching, call the resume_cb
06-01 12:52:14.158+0900 I/CAPI_APPFW_APPLICATION( 6019): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-01 12:52:14.158+0900 D/LAUNCH  ( 6019): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-01 12:52:14.158+0900 D/LAUNCH  ( 6019): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-01 12:52:14.158+0900 D/APP_CORE( 6019): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-01 12:52:14.158+0900 E/APP_CORE( 6019): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-01 12:52:14.168+0900 D/RESOURCED( 2893): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 6019, appname = org.example.example, pkgname = org.example.example
06-01 12:52:14.168+0900 D/RESOURCED( 2893): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 6019, appname = org.example.example
06-01 12:52:14.168+0900 D/RESOURCED( 2893): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 6019
06-01 12:52:14.168+0900 I/RESOURCED( 2893): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-01 12:52:14.168+0900 I/RESOURCED( 2893): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-01 12:52:14.188+0900 D/AUL_PAD ( 3003): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-01 12:52:14.198+0900 D/AUL_PAD ( 6064): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-01 12:52:14.208+0900 D/AUL_PAD ( 3003): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-01 12:52:14.218+0900 E/RESOURCED( 2893): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.420
06-01 12:52:14.678+0900 D/AUL_AMD ( 2858): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-01 12:52:14.678+0900 D/RUA     ( 2858): rua.c: rua_add_history(179) > rua_add_history start
06-01 12:52:14.698+0900 D/RUA     ( 2858): rua.c: rua_add_history(247) > rua_add_history ok
06-01 12:52:14.838+0900 I/user_tag( 6019): 설마
06-01 12:52:14.838+0900 E/EFL     ( 6019): eo<6019> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_common_interface.eo.c:1: func 'evas_common_evas_get' (62) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 12:52:14.838+0900 E/EFL     ( 6019): eo<6019> lib/eo/eo.c:676 _eo_call_resolve() in ../src/lib/evas/canvas/evas_object.eo.c:74: func 'evas_obj_type_get' (128) could not be resolved for class 'Elm_Naviframe_Item'.
06-01 12:52:14.838+0900 E/EFL     ( 6019): elementary<6019> elm_widget.c:1101 elm_widget_sub_object_parent_add() You passed a wrong parent parameter (0x8000b85d (null)). Elementary widget's parent should be an elementary widget.
06-01 12:52:14.838+0900 E/EFL     ( 6019): <6019> lib/edje/edje_smart.c:22 edje_object_add() safety check failed: evas == NULL
06-01 12:52:14.858+0900 W/CRASH_MANAGER( 5816): worker.c: worker_job(1204) > 1106019657861149628913
