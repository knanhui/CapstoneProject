S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 3887
Date: 2017-06-13 13:39:39+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb8508870
ebp = 0xbfcf48d8, esp = 0xbfcf4870
eax = 0xb8508870, ebx = 0xb6c310d4
ecx = 0xb383e000, edx = 0x00000000
eip = 0xb6c0f1f6

Memory Information
MemTotal:      123 KB
MemFree:        30 KB
Buffers:         6 KB
Cached:     169508 KB
VmPeak:     110832 KB
VmSize:     110832 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24160 KB
VmRSS:       24160 KB
VmData:      43104 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34612 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3887 TID = 3887
3887 3911 4011 4014 4016 

Maps Information
b2bcf000 b2bd9000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bdf000 b2beb000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bec000 b2c0d000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c12000 b2c13000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c14000 b2c19000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c1a000 b2c1b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c1c000 b2c1e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c1f000 b2c21000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c22000 b2c2e000 r-xp /usr/lib/libdrm.so.2.4.0
b2c2f000 b2c32000 r-xp /usr/lib/libdri2.so.0.0.0
b2c33000 b2c3d000 r-xp /usr/lib/libtbm.so.1.0.0
b2c3e000 b2c3f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2c40000 b2c55000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c56000 b2c68000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b346a000 b349b000 r-xp /usr/lib/libidn.so.11.5.44
b349c000 b34be000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34bf000 b34cf000 r-xp /usr/lib/libcares.so.2.1.0
b34d0000 b34d9000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34da000 b34e0000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b34e1000 b34f7000 r-xp /usr/lib/libalarm.so.0.0.0
b34f9000 b3502000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3503000 b357a000 r-xp /usr/lib/libcurl.so.4.3.0
b357c000 b358e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b358f000 b3592000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b3593000 b3596000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b3597000 b35b8000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b35bf000 b35c0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35c1000 b35c2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35c3000 b35c6000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35c7000 b35ca000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36d2000 b36d8000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36d9000 b381d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b382d000 b383c000 r-xp /opt/usr/apps/org.example.example/bin/example
b383f000 b3878000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b427b000 b4286000 r-xp /lib/libnss_files-2.20-2014.11.so
b4288000 b4293000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4295000 b42ac000 r-xp /lib/libnsl-2.20-2014.11.so
b42b0000 b42b8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42ba000 b42de000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42df000 b42e0000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42e1000 b42e4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42e5000 b42ec000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42ed000 b42f7000 r-xp /usr/lib/libsensord-share.so
b42f8000 b4314000 r-xp /usr/lib/libsensor.so.1.2.0
b4316000 b431f000 r-xp /usr/lib/libappcore-common.so.1.1
b4322000 b4324000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4339000 b433b000 r-xp /usr/lib/libXau.so.6.0.0
b433c000 b435e000 r-xp /usr/lib/libxcb.so.1.1.0
b4360000 b4369000 r-xp /lib/libcrypt-2.20-2014.11.so
b4392000 b4394000 r-xp /usr/lib/libiri.so
b4395000 b43bb000 r-xp /lib/libexpat.so.1.5.2
b43bd000 b4428000 r-xp /usr/lib/libssl.so.1.0.0
b442e000 b443a000 r-xp /usr/lib/libethumb.so.1.13.0
b443b000 b443f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4440000 b4691000 r-xp /usr/lib/libcrypto.so.1.0.0
b5c0c000 b5c1c000 r-xp /usr/lib/libXi.so.6.1.0
b5c1d000 b5c1f000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c20000 b5c26000 r-xp /usr/lib/libXtst.so.6.1.0
b5c27000 b5c31000 r-xp /usr/lib/libXrender.so.1.3.0
b5c32000 b5c3b000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c3d000 b5c3f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c40000 b5c45000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c46000 b5c58000 r-xp /usr/lib/libXext.so.6.4.0
b5c59000 b5c5b000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c5c000 b5c5e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c60000 b5da2000 r-xp /usr/lib/libX11.so.6.3.0
b5da6000 b5db0000 r-xp /usr/lib/libXcursor.so.1.0.2
b5db1000 b5dc7000 r-xp /usr/lib/libudev.so.1.6.0
b5dca000 b5dce000 r-xp /lib/libattr.so.1.1.0
b5dcf000 b5dfe000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5e00000 b5e06000 r-xp /usr/lib/libffi.so.6.0.2
b5e07000 b5e2a000 r-xp /lib/libz.so.1.2.8
b5e2b000 b5e2e000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e2f000 b5f8b000 r-xp /usr/lib/libxml2.so.2.9.2
b5f91000 b6078000 r-xp /usr/lib/libstdc++.so.6.0.20
b6085000 b6088000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6089000 b60ab000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60ac000 b60c0000 r-xp /lib/libresolv-2.20-2014.11.so
b60c4000 b60e8000 r-xp /usr/lib/liblzma.so.5.0.3
b60e9000 b60eb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60ed000 b60f7000 r-xp /usr/lib/libembryo.so.1.13.0
b60f8000 b6121000 r-xp /usr/lib/libpng12.so.0.50.0
b6122000 b616b000 r-xp /usr/lib/libjpeg.so.8.0.2
b617c000 b6183000 r-xp /lib/librt-2.20-2014.11.so
b6185000 b61a4000 r-xp /usr/lib/libector.so.1.13.0
b61a7000 b61d4000 r-xp /usr/lib/liblua-5.1.so
b61d5000 b6265000 r-xp /usr/lib/libfreetype.so.6.11.3
b6269000 b62a7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b62a8000 b62be000 r-xp /usr/lib/libfribidi.so.0.3.1
b62bf000 b6318000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b631b000 b6366000 r-xp /lib/libm-2.20-2014.11.so
b6368000 b637a000 r-xp /usr/lib/libeio.so.1.13.0
b637b000 b637e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b637f000 b6385000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6386000 b63a9000 r-xp /usr/lib/libefreet.so.1.13.0
b63ac000 b63d7000 r-xp /usr/lib/libeldbus.so.1.13.0
b63d8000 b640c000 r-xp /usr/lib/libecore_con.so.1.13.0
b640e000 b6417000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6418000 b6421000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6422000 b6435000 r-xp /usr/lib/libeo.so.1.13.0
b6437000 b644a000 r-xp /usr/lib/libecore_input.so.1.13.0
b644b000 b6452000 r-xp /usr/lib/libecore_file.so.1.13.0
b6453000 b6476000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6477000 b64a3000 r-xp /usr/lib/libeet.so.1.13.0
b64ac000 b6517000 r-xp /usr/lib/libeina.so.1.13.0
b651a000 b6531000 r-xp /usr/lib/libefl.so.1.13.0
b6533000 b669a000 r-xp /usr/lib/libicuuc.so.51.1
b66a8000 b68b4000 r-xp /usr/lib/libicui18n.so.51.1
b68bc000 b690b000 r-xp /usr/lib/libecore_x.so.1.13.0
b690d000 b6927000 r-xp /lib/libgcc_s-4.9.so.1
b6929000 b692d000 r-xp /lib/libcap.so.2.21
b692e000 b6974000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6975000 b697c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b697e000 b69d0000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69d2000 b6b5d000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b62000 b6c30000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c33000 b6c37000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c38000 b6c47000 r-xp /usr/lib/libvconf.so.0.2.45
b6c48000 b6c4b000 r-xp /usr/lib/libvasum.so.0.3.1
b6c4c000 b6c4f000 r-xp /usr/lib/libttrace.so.1.1
b6c51000 b6c55000 r-xp /usr/lib/libiniparser.so.0
b6c56000 b6c86000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c87000 b6c90000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c91000 b6cb6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6cb7000 b6cc7000 r-xp /usr/lib/libunwind.so.8.0.1
b6cd1000 b6e7f000 r-xp /lib/libc-2.20-2014.11.so
b6e87000 b6fca000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fcc000 b7024000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7025000 b7059000 r-xp /usr/lib/libsystemd.so.0.4.0
b705c000 b7130000 r-xp /usr/lib/libedje.so.1.13.0
b7133000 b715f000 r-xp /usr/lib/libecore.so.1.13.0
b7170000 b7396000 r-xp /usr/lib/libevas.so.1.13.0
b73be000 b73d6000 r-xp /lib/libpthread-2.20-2014.11.so
b73da000 b7754000 r-xp /usr/lib/libelementary.so.1.13.0
b7774000 b7778000 r-xp /usr/lib/libsmack.so.1.0.0
b7779000 b7782000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7783000 b7786000 r-xp /usr/lib/libdlog.so.0.0.0
b7787000 b778c000 r-xp /usr/lib/libbundle.so.0.1.22
b778d000 b7790000 r-xp /lib/libdl-2.20-2014.11.so
b7792000 b77b7000 r-xp /usr/lib/libaul.so.0.1.0
b77ba000 b77bc000 r-xp /usr/lib/libappsvc.so.0.1.0
b77bd000 b77c2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77c3000 b77ca000 r-xp /usr/lib/libappcore-efl.so.1.1
b77cc000 b77d1000 r-xp /usr/lib/libsys-assert.so
b77d4000 b77d5000 r-xp [vdso]
b77d5000 b77f7000 r-xp /lib/ld-2.20-2014.11.so
b77f9000 b7801000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3887)
Call Stack Count: 15
 0: (0xb6c0f1f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: open_setting_db + 0x143 (0xb3838393) [/opt/usr/apps/org.example.example/bin/example] + 0xb393
 2: app_pause + 0x29 (0xb3836e49) [/opt/usr/apps/org.example.example/bin/example] + 0x9e49
 3: (0xb77bece2) [/usr/lib/libcapi-appfw-application.so.0] + 0x1ce2
 4: (0xb77c6134) [/usr/lib/libappcore-efl.so.1] + 0x3134
 5: (0xb77c66d9) [/usr/lib/libappcore-efl.so.1] + 0x36d9
 6: (0xb7140055) [/usr/lib/libecore.so.1] + 0xd055
 7: (0xb71491b9) [/usr/lib/libecore.so.1] + 0x161b9
 8: ecore_main_loop_begin + 0x57 (0xb7149587) [/usr/lib/libecore.so.1] + 0x16587
 9: elm_run + 0x2d (0xb75a222d) [/usr/lib/libelementary.so.1] + 0x1c822d
10: appcore_efl_main + 0x4de (0xb77c6dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
11: ui_app_main + 0x140 (0xb77bfc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
12: main + 0x2a5 (0xb3836d75) [/opt/usr/apps/org.example.example/bin/example] + 0x9d75
13: (0xb77fb148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77fb148
14: __libc_start_main + 0xde (0xb6ce8e4e) [/lib/libc.so.6] + 0x17e4e
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
ler(587) > [APP 4019]     AUL event: AUL_START
06-13 13:34:21.236+0900 I/APP_CORE( 4019): appcore-efl.c: __do_app(496) > [APP 4019] Event: RESET State: CREATED
06-13 13:34:21.236+0900 D/APP_CORE( 4019): appcore-efl.c: __do_app(527) > [APP 4019] RESET
06-13 13:34:21.236+0900 D/LAUNCH  ( 4019): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
06-13 13:34:21.236+0900 D/APP_CORE( 4019): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 13:34:21.236+0900 D/APP_CORE( 4019): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 13:34:21.236+0900 E/SYSPOPUP( 4019): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-13 13:34:21.236+0900 E/SYSPOPUP( 4019): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-13 13:34:21.236+0900 E/SYSPOPUP( 4019): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
06-13 13:34:21.236+0900 D/LAUNCH  ( 4019): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
06-13 13:34:21.236+0900 D/APP_CORE( 4019): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 13:34:21.276+0900 D/AUL     ( 4019): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 13:34:21.276+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 13:34:21.276+0900 W/AUL_AMD ( 2808): amd_request.c: __request_handler(1056) > app status : 5
06-13 13:34:21.276+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(4019) status(5)
06-13 13:34:21.276+0900 D/APP_CORE( 4019): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 13:34:21.276+0900 E/EFL     ( 4019): eo<4019> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
06-13 13:34:21.276+0900 E/EFL     ( 4019): eo<4019> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
06-13 13:34:21.936+0900 D/AUL_AMD ( 2808): amd_status.c: __app_terminate_timer_cb(442) > pid(3768)
06-13 13:34:21.936+0900 W/AUL_AMD ( 2808): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-13 13:34:21.936+0900 D/AUL_AMD ( 2808): amd_status.c: __app_terminate_timer_cb(442) > pid(3768)
06-13 13:34:21.936+0900 W/AUL_AMD ( 2808): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-13 13:34:23.126+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 13:34:23.126+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: MEM_FLUSH State: PAUSED
06-13 13:34:23.126+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 13:34:23.126+0900 D/APP_CORE( 2870): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2870
06-13 13:34:23.126+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 13:34:23.126+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2870
06-13 13:34:31.106+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:34:31.106+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:34:31.106+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:34:31.106+0900 E/INDICATOR( 2856): 
06-13 13:34:44.506+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:34:44.506+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:34:44.506+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:34:44.506+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:34:44.506+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > abnormal cache is empty
06-13 13:34:51.106+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:34:51.106+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:34:51.106+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:34:51.106+0900 E/INDICATOR( 2856): 
06-13 13:35:00.596+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:35:00.596+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:35:00.596+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:35:00.596+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:35 4 h"
06-13 13:35:00.596+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:35"
06-13 13:35:00.596+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;35"
06-13 13:35:00.596+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147117876 Time: <font_size=33>1&#x2236;35</font_size> <font_size=32>PM</font_size></font>
06-13 13:35:11.126+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:35:11.126+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:35:11.126+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:35:11.126+0900 E/INDICATOR( 2856): 
06-13 13:35:31.145+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:35:31.145+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:35:31.145+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:35:31.145+0900 E/INDICATOR( 2856): 
06-13 13:35:44.535+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:35:44.535+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:35:44.535+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:35:44.535+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:35:51.155+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:35:51.155+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:35:51.155+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:35:51.155+0900 E/INDICATOR( 2856): 
06-13 13:36:00.605+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:36:00.605+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:36:00.605+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:36:00.605+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:36 4 h"
06-13 13:36:00.605+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:36"
06-13 13:36:00.605+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;36"
06-13 13:36:00.605+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147115824 Time: <font_size=33>1&#x2236;36</font_size> <font_size=32>PM</font_size></font>
06-13 13:36:11.165+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:36:11.165+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:36:11.165+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:36:11.165+0900 E/INDICATOR( 2856): 
06-13 13:36:31.175+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:36:31.175+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:36:31.175+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:36:31.175+0900 E/INDICATOR( 2856): 
06-13 13:36:44.544+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:36:44.544+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:36:44.544+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:36:44.544+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:36:44.544+0900 I/RESOURCED( 2854): logging.c: logging_save_to_storage(978) > battery cache is empty
06-13 13:36:44.544+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.lockscreen org.tizen.lockscreen 1497327446 37 5 3321 1
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1497327446 48 42 2870 1
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.lockscreen org.tizen.lockscreen 1497327495 41 5 3321 2
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1497327543 27 5 3341 1
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1497328086 59 50 2870 1
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1497328091 29 6 3558 1
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1497328423 68 59 2870 1
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1497328425 53 11 3768 1
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.tizen.homescreen org.tizen.homescreen 1497328456 76 62 2870 1
06-13 13:36:44.554+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_update(576) > org.example.example org.example.example 1497328458 28 4 3887 1
06-13 13:36:51.194+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:36:51.194+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:36:51.194+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:36:51.194+0900 E/INDICATOR( 2856): 
06-13 13:37:00.614+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:37:00.614+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:37:00.614+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:37:00.614+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:37 4 h"
06-13 13:37:00.614+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:37"
06-13 13:37:00.614+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;37"
06-13 13:37:00.614+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147113772 Time: <font_size=33>1&#x2236;37</font_size> <font_size=32>PM</font_size></font>
06-13 13:37:11.204+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:37:11.204+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:37:11.204+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:37:11.204+0900 E/INDICATOR( 2856): 
06-13 13:37:31.214+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:37:31.214+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:37:31.214+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:37:31.214+0900 E/INDICATOR( 2856): 
06-13 13:37:44.544+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:37:44.544+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:37:44.544+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:37:44.544+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:37:46.684+0900 I/service ( 3887): socket
06-13 13:37:46.684+0900 I/example ( 3887): m
06-13 13:37:46.824+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60040e 
06-13 13:37:47.824+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2e00002
06-13 13:37:51.224+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:37:51.224+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:37:51.234+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:37:51.234+0900 E/INDICATOR( 2856): 
06-13 13:37:52.824+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60040e bd->visible=1
06-13 13:38:00.623+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:38:00.623+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:38:00.623+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:38:00.623+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:38 4 h"
06-13 13:38:00.623+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:38"
06-13 13:38:00.623+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;38"
06-13 13:38:00.623+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147111720 Time: <font_size=33>1&#x2236;38</font_size> <font_size=32>PM</font_size></font>
06-13 13:38:04.473+0900 I/service ( 3887): socket
06-13 13:38:04.473+0900 I/example ( 3887): m
06-13 13:38:04.563+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60040e 
06-13 13:38:11.233+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:38:11.233+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:38:11.233+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:38:11.233+0900 E/INDICATOR( 2856): 
06-13 13:38:31.263+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:38:31.263+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:38:31.263+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:38:31.263+0900 E/INDICATOR( 2856): 
06-13 13:38:44.533+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 13:38:44.533+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 13:38:44.533+0900 D/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 13:38:44.533+0900 I/RESOURCED( 2854): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 13:38:51.283+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:38:51.283+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:38:51.283+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:38:51.283+0900 E/INDICATOR( 2856): 
06-13 13:39:00.633+0900 D/INDICATOR( 2856): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 13:39:00.633+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 13:39:00.633+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 13:39:00.633+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 1:39 4 h"
06-13 13:39:00.633+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 1:39"
06-13 13:39:00.633+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 1&#x2236;39"
06-13 13:39:00.633+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147109668 Time: <font_size=33>1&#x2236;39</font_size> <font_size=32>PM</font_size></font>
06-13 13:39:11.283+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:39:11.283+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:39:11.283+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:39:11.283+0900 E/INDICATOR( 2856): 
06-13 13:39:31.302+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 13:39:31.302+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 13:39:31.302+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 13:39:31.302+0900 E/INDICATOR( 2856): 
06-13 13:39:38.882+0900 D/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60040e 
06-13 13:39:39.562+0900 D/STARTER ( 2851): hw_key.c: _key_press_cb(302) > [_key_press_cb:302] _key_press_cb : XF86Home Pressed
06-13 13:39:39.562+0900 W/STARTER ( 2851): hw_key.c: _key_press_cb(334) > [_key_press_cb:334] Home Key is pressed
06-13 13:39:39.562+0900 W/STARTER ( 2851): hw_key.c: _key_press_cb(341) > [_key_press_cb:341] homekey count : 1
06-13 13:39:39.562+0900 D/STARTER ( 2851): hw_key.c: _key_press_cb(349) > [_key_press_cb:349] create long press timer
06-13 13:39:39.632+0900 D/STARTER ( 2851): hw_key.c: _key_release_cb(206) > [_key_release_cb:206] _key_release_cb : XF86Home Released
06-13 13:39:39.632+0900 W/STARTER ( 2851): hw_key.c: _key_release_cb(243) > [_key_release_cb:243] Home Key is released
06-13 13:39:39.832+0900 W/STARTER ( 2851): hw_key.c: _home_multi_press_timer_cb(138) > [_home_multi_press_timer_cb:138] homekey count[1]
06-13 13:39:39.832+0900 D/STARTER ( 2851): process_mgr.c: process_mgr_must_launch(114) > [process_mgr_must_launch:114] Must launch org.tizen.homescreen
06-13 13:39:39.832+0900 D/AUL     ( 2851): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.tizen.homescreen
06-13 13:39:39.832+0900 D/AUL     ( 2851): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
06-13 13:39:39.832+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 0
06-13 13:39:39.832+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.tizen.homescreen
06-13 13:39:39.832+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
06-13 13:39:39.832+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
06-13 13:39:39.832+0900 I/AUL     ( 2808): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/starter, ret : 0
06-13 13:39:39.832+0900 D/AUL     ( 2808): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 2851, pid = 2851
06-13 13:39:39.832+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
06-13 13:39:39.832+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
06-13 13:39:39.842+0900 I/AUL     ( 2808): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/starter, ret : 0
06-13 13:39:39.842+0900 E/AUL_AMD ( 2808): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-13 13:39:39.842+0900 W/AUL_AMD ( 2808): amd_launch.c: _start_app(2233) > caller pid : 2851
06-13 13:39:39.842+0900 E/AUL_AMD ( 2808): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-13 13:39:39.842+0900 D/RESOURCED( 2854): proc-noti.c: process_message(173) > process message caller pid 2808
06-13 13:39:39.842+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_action(1043) > [SECURE_LOG] appid org.tizen.homescreen, pid 2870, status 5
06-13 13:39:39.842+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(914) > [SECURE_LOG] resume request 2870
06-13 13:39:39.842+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(934) > available memory = 303
06-13 13:39:39.852+0900 D/AUL_AMD ( 2808): amd_launch.c: __nofork_processing(1249) > org.tizen.system.deviced.PmQos-AppLaunch : 0
06-13 13:39:39.852+0900 W/AUL_AMD ( 2808): amd_launch.c: __nofork_processing(1252) > __nofork_processing, cmd: 0, pid: 2870
06-13 13:39:39.852+0900 D/AUL_AMD ( 2808): amd_launch.c: __nofork_processing(1268) > fake launch pid : 2870
06-13 13:39:39.852+0900 D/AUL     ( 2808): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(2870) : cmd(0)
06-13 13:39:39.852+0900 D/AUL_AMD ( 2808): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-13 13:39:39.852+0900 D/AUL_AMD ( 2808): amd_launch.c: __nofork_processing(1271) > fake launch done
06-13 13:39:39.852+0900 D/APP_CORE( 2870): appcore.c: __aul_handler(587) > [APP 2870]     AUL event: AUL_START
06-13 13:39:39.852+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: RESET State: PAUSED
06-13 13:39:39.852+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(527) > [APP 2870] RESET
06-13 13:39:39.852+0900 W/AUL_AMD ( 2808): amd_request.c: __send_home_launch_signal(517) > send a home launch signal
06-13 13:39:39.852+0900 D/LAUNCH  ( 2870): appcore-efl.c: __do_app(529) > [homescreen:Application:reset:start]
06-13 13:39:39.852+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 13:39:39.852+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 13:39:39.852+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-13 13:39:39.852+0900 E/cluster-home( 2870): homescreen.cpp: OnAppsControl(129) >  app control
06-13 13:39:39.852+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: HomekeyOperation(929) >  block [0]
06-13 13:39:39.852+0900 D/LAUNCH  ( 2870): appcore-efl.c: __do_app(544) > [homescreen:Application:reset:done]
06-13 13:39:39.852+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(548) > Legacy lifecycle: 1
06-13 13:39:39.852+0900 D/APP_CORE( 2870): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 13:39:39.852+0900 D/APP_CORE( 2870): appcore.c: __prt_ltime(236) > [APP 2870] first idle after reset: 2163574 msec
06-13 13:39:39.852+0900 W/AUL_AMD ( 2808): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(2870), cmd(0)
06-13 13:39:39.852+0900 D/AUL     ( 2851): launch.c: app_request_to_launchpad(425) > launch request result : 2870
06-13 13:39:39.852+0900 D/STARTER ( 2851): process_mgr.c: _try_to_launch(62) > [_try_to_launch:62] Succeed to launch org.tizen.homescreen
06-13 13:39:39.862+0900 E/E17     ( 2766): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
06-13 13:39:39.862+0900 D/STARTER ( 2851): dbus_util.c: dbus_util_send_oomadj(285) > [dbus_util_send_oomadj:285] org.tizen.system.deviced.Process-oomadj_set : 0
06-13 13:39:39.862+0900 D/STARTER ( 2851): dbus_util.c: _dbus_message_send(229) > [_dbus_message_send:229] dbus_connection_send, ret=1
06-13 13:39:39.862+0900 E/STARTER ( 2851): dbus_util.c: dbus_util_send_home_raise_signal(243) > [dbus_util_send_home_raise_signal:243] Sending HOME RAISE signal, result:0
06-13 13:39:39.862+0900 D/APP_CORE( 2870): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 0
06-13 13:39:39.862+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
06-13 13:39:39.862+0900 D/APP_CORE( 2870): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 13:39:39.862+0900 I/APP_CORE( 2870): appcore-efl.c: __do_app(496) > [APP 2870] Event: RESUME State: PAUSED
06-13 13:39:39.862+0900 D/LAUNCH  ( 2870): appcore-efl.c: __do_app(597) > [homescreen:Application:resume:start]
06-13 13:39:39.862+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 13:39:39.862+0900 D/APP_CORE( 2870): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 13:39:39.862+0900 D/APP_CORE( 2870): appcore-efl.c: __do_app(607) > [APP 2870] RESUME
06-13 13:39:39.862+0900 I/CAPI_APPFW_APPLICATION( 2870): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 13:39:39.862+0900 E/cluster-home( 2870): homescreen.cpp: OnResume(66) >  app resume
06-13 13:39:39.862+0900 D/cluster-home( 2870): widget-data-provider.cpp: SetBoxVisibility(1543) >  
06-13 13:39:39.862+0900 D/cluster-home( 2870): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[1]
06-13 13:39:39.862+0900 D/WIDGET_VIEWER( 2870): widget.c: widget_viewer_set_visibility(3865) > [SECURE_LOG] org.tizen.calendar.widget has no changes
06-13 13:39:39.862+0900 D/cluster-home( 2870): cluster-data-list.cpp: GetWidgetListByPage(776) >  cluster[0] pageNum[2]
06-13 13:39:39.862+0900 D/cluster-home( 2870): widget-data-provider.cpp: SetBoxVisibility(1552) >  No boxes in page[2]
06-13 13:39:39.862+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppResume(892) >  BEGIN
06-13 13:39:39.862+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: _MoveHomeScreenView(869) >  Go Home View
06-13 13:39:39.862+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: _OnScrollStart(128) >  scrollPos[-0, 1280] 
06-13 13:39:39.862+0900 D/test-log( 2870): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[0] [void ClusterHome3D::Internal::CMainMenuAppsView::OnMainScrollStart():2115]
06-13 13:39:39.862+0900 D/cluster-view( 2870): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
06-13 13:39:39.862+0900 D/test-log( 2870): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[0] [void ClusterHome3D::Internal::CMainMenuAppsView::SetViewTouchSensitive(bool):2245]
06-13 13:39:39.862+0900 D/cluster-view( 2870): cluster-impl.cpp: SetScrollSensitive(442) >  Scroll touch disabled
06-13 13:39:39.862+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnMainScrollStart(6736) >  BEGIN
06-13 13:39:39.862+0900 D/cluster-view( 2870): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
06-13 13:39:39.862+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.862+0900 D/test-log( 2870): cluster-impl.cpp: ScrollTo(460) >  scroll to page 0
06-13 13:39:39.862+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnCustomScrollStart(5043) >  ##################### scroll start ########################### 
06-13 13:39:39.862+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
06-13 13:39:39.862+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.862+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.862+0900 E/E17     ( 2766): e_border.c: e_border_hide(2248) > BD_HIDE(0x02e00002), visible:1
06-13 13:39:39.862+0900 E/EFL     ( 2766): eo<2766> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:39:39.872+0900 D/APP_CORE( 3887): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 1
06-13 13:39:39.872+0900 D/APP_CORE( 3887): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 13:39:39.872+0900 D/APP_CORE( 3887): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 13:39:39.872+0900 I/APP_CORE( 3887): appcore-efl.c: __do_app(496) > [APP 3887] Event: PAUSE State: RUNNING
06-13 13:39:39.872+0900 D/APP_CORE( 3887): appcore-efl.c: __do_app(565) > [APP 3887] PAUSE
06-13 13:39:39.872+0900 I/CAPI_APPFW_APPLICATION( 3887): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 13:39:39.872+0900 I/user_tag0( 3887): /opt/usr/apps/org.example.example/data/test.db
06-13 13:39:39.882+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: AppResume(910) >  END
06-13 13:39:39.882+0900 D/cluster-view( 2870): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
06-13 13:39:39.882+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
06-13 13:39:39.882+0900 D/cluster-view( 2870): homescreen-page-indicator.cpp: CancelOperation(300) >  CancelOperation
06-13 13:39:39.882+0900 D/cluster-view( 2870): cluster-impl.cpp: ScrollToFitPage(466) >  ScrollToFitPage
06-13 13:39:39.882+0900 D/LAUNCH  ( 2870): appcore-efl.c: __do_app(636) > [homescreen:Application:resume:done]
06-13 13:39:39.882+0900 D/LAUNCH  ( 2870): appcore-efl.c: __do_app(638) > [homescreen:Application:Launching:done]
06-13 13:39:39.882+0900 D/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 13:39:39.882+0900 E/APP_CORE( 2870): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 13:39:39.902+0900 D/DATA_PROVIDER_MASTER( 2928): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2870 is resumed
06-13 13:39:39.902+0900 D/DATA_PROVIDER_MASTER( 2928): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
06-13 13:39:39.902+0900 E/DATA_PROVIDER_MASTER( 2928): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
06-13 13:39:39.902+0900 D/test-log( 2870): custom-cluster-impl.cpp: HomeViewPageOpacityConstraint(141) >  position.y: 0.00, size.y: 1280.00, posY: 1118.67
06-13 13:39:39.912+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
06-13 13:39:39.912+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
06-13 13:39:39.912+0900 W/AUL     ( 3017): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3017, appid: org.tizen.calendar.widget, status: fg
06-13 13:39:39.912+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3017
06-13 13:39:39.912+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3017, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
06-13 13:39:39.912+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3017
06-13 13:39:39.942+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 13:39:39.942+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-13 13:39:39.942+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 13:39:39.942+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 13:39:39.942+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 13:39:39.942+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 13:39:39.942+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 13:39:39.942+0900 I/AUL_PAD ( 2921): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 3887 pgid = 3887
06-13 13:39:39.942+0900 I/AUL_PAD ( 2921): sigchild.h: __sigchild_action(142) > dead_pid(3887)
06-13 13:39:39.952+0900 D/AUL_PAD ( 2921): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-13 13:39:39.952+0900 I/AUL_PAD ( 2921): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-13 13:39:39.952+0900 I/AUL_PAD ( 2921): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-13 13:39:39.952+0900 E/AUL_PAD ( 2921): launchpad.c: main(688) > error reading sigchld info
06-13 13:39:39.952+0900 W/PROCESSMGR( 2766): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2870
06-13 13:39:39.952+0900 I/ESD     ( 2934): esd_main.c: __esd_app_dead_handler(1771) > pid: 3887
06-13 13:39:39.952+0900 W/AUL_AMD ( 2808): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 3887
06-13 13:39:39.952+0900 W/AUL_AMD ( 2808): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 3887
06-13 13:39:39.952+0900 D/STARTER ( 2851): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 3887 is termianted
06-13 13:39:39.952+0900 D/AUL_AMD ( 2808): amd_key.c: _unregister_key_event(179) > ===key stack===
06-13 13:39:39.952+0900 D/STARTER ( 2851): starter.c: _check_dead_signal(202) > [_check_dead_signal:202] Unknown process, ignore it
06-13 13:39:39.952+0900 E/AUL_AMD ( 2808): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-13 13:39:39.952+0900 D/AUL_AMD ( 2808): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.example.example)
06-13 13:39:39.952+0900 D/AUL     ( 2808): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-13 13:39:39.952+0900 E/AUL     ( 2808): simple_util.c: __trm_app_info_send_socket(330) > access
06-13 13:39:39.952+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: _OnScrollComplete(180) >  scrollPos[-0, 0] 
06-13 13:39:39.952+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: _OnScrollComplete(197) >  HOME_SCREEN_VIEW layout
06-13 13:39:39.952+0900 D/test-log( 2870): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[0] [void ClusterHome3D::Internal::CMainMenuAppsView::SetViewTouchSensitive(bool):2245]
06-13 13:39:39.952+0900 D/cluster-view( 2870): cluster-impl.cpp: SetScrollSensitive(435) >  Scroll touch enabled
06-13 13:39:39.952+0900 D/cluster-view( 2870): homescreen-view-manager.cpp: _ShowIndicator(830) >  SHOW INDICATOR 1
06-13 13:39:39.952+0900 D/cluster-view( 2870): mainmenu-apps-view-impl.cpp: OnMainScrollComplete(2154) >  self is OnState
06-13 13:39:39.952+0900 D/test-log( 2870): mainmenu-apps-view-impl.cpp: SetScrollSensitive(2261) >  horizontal apps scrollview sensitive[1] [void ClusterHome3D::Internal::CMainMenuAppsView::OnMainScrollComplete():2155]
06-13 13:39:39.952+0900 W/test-log( 2870): mainmenu-page-impl.cpp: SetPageEditMode(451) >  editState:[1]
06-13 13:39:39.952+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.952+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.952+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.952+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.952+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.952+0900 D/cluster-home( 2870): custom-cluster-impl.cpp: AllPageModeFinished(2750) >  BEGIN
06-13 13:39:39.952+0900 D/cluster-view( 2870): cluster-view-controller.cpp: OnCustomClusterSwichAllPageModeFinished(2055) >  Cluster[0:] all page mode switched 0
06-13 13:39:39.952+0900 D/cluster-view( 2870): cluster-home-accessibility.cpp: SetCurrentGroup(62) >  Focus Group changed [12]->[1] Block[0]
06-13 13:39:39.952+0900 D/cluster-view( 2870): cluster-view-controller.cpp: UpdateScreenReader(854) >  [TTS] For Home update type[1], group[1]
06-13 13:39:39.952+0900 D/cluster-view( 2870): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
06-13 13:39:39.952+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
06-13 13:39:39.952+0900 D/cluster-view( 2870): cluster-view-controller.cpp: _OnTTSFocusChanged(1652) >  _OnTTSFocusChanged Order[0]
06-13 13:39:39.952+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnFocusChanged(5705) >  OnFocusChanged[0]
06-13 13:39:39.952+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.952+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnUpdateScreenReader(5538) >  Set FocusOrder[1]
06-13 13:39:39.952+0900 D/cluster-view( 2870): custom-box-impl.cpp: UpdateScreenReader(1388) >  [TTS] CustomBox[1], focus order[2100], badge[0]
06-13 13:39:39.952+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.952+0900 D/cluster-view( 2870): cluster-impl.cpp: SetPageNavigator(283) >  BEGIN
06-13 13:39:39.952+0900 D/cluster-home( 2870): widget-data-provider.cpp: OnFocusedViewChanged(2973) >  changed view type[0]
06-13 13:39:39.952+0900 D/cluster-view( 2870): cluster-view-controller.cpp: _OnScreenViewTypeChanged(1604) >  Do not need to update tts
06-13 13:39:39.952+0900 E/EFL     ( 2766): eo<2766> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 13:39:39.952+0900 D/AUL_AMD ( 2808): amd_launch.c: __e17_status_handler(2891) > pid(2870) status(3)
06-13 13:39:39.952+0900 D/AUL_AMD ( 2808): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 13:39:39.952+0900 W/AUL_AMD ( 2808): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 13:39:39.952+0900 W/AUL_AMD ( 2808): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 13:39:39.952+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(2870) status(3)
06-13 13:39:39.952+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(468) > pid(2870) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
06-13 13:39:39.952+0900 D/AUL     ( 2808): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
06-13 13:39:39.952+0900 W/AUL     ( 2808): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2870, appid: org.tizen.homescreen, status: fg
06-13 13:39:39.952+0900 D/AUL_AMD ( 2808): amd_status.c: _status_update_app_info_list(456) > pid(3887) status(4)
06-13 13:39:39.952+0900 D/cluster-view( 2870): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
06-13 13:39:39.962+0900 D/cluster-view( 2870): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
06-13 13:39:39.962+0900 D/cluster-view( 2870): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
06-13 13:39:39.962+0900 D/test-log( 2870): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
06-13 13:39:39.962+0900 D/test-log( 2870): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
06-13 13:39:39.962+0900 D/cluster-view( 2870): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
06-13 13:39:39.962+0900 D/cluster-home( 2870): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
06-13 13:39:39.962+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 2e00002
06-13 13:39:39.962+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.translucent
06-13 13:39:39.962+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 13:39:39.962+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 13:39:39.962+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 13:39:39.962+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-13 13:39:39.962+0900 I/TIZEN_N_SOUND_MANAGER( 2936): sound_manager.c: sound_manager_get_volume(80) > returns : type=0, volume=9, ret=0x0
06-13 13:39:39.962+0900 E/TIZEN_N_SOUND_MANAGER( 2936): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:39:39.962+0900 I/TIZEN_N_SOUND_MANAGER( 2936): sound_manager.c: sound_manager_get_volume(80) > returns : type=4, volume=7, ret=0x0
06-13 13:39:39.962+0900 E/TIZEN_N_SOUND_MANAGER( 2936): sound_manager_private.c: __convert_sound_manager_error_code(74) > [sound_manager_get_volume(82)] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-13 13:39:39.962+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 13:39:39.962+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
06-13 13:39:39.962+0900 D/PKGMGR_INFO( 2808): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
06-13 13:39:39.962+0900 D/AUL_AMD ( 2808): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2870 is org.tizen.homescreen
06-13 13:39:39.962+0900 D/AUL_AMD ( 2808): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2870 : 0
06-13 13:39:39.972+0900 D/AUL     ( 2936): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
06-13 13:39:39.992+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3017, appname = org.tizen.calendar.widget
06-13 13:39:39.992+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3017
06-13 13:39:39.992+0900 E/RESOURCED( 2854): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.225
06-13 13:39:39.992+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 3887
06-13 13:39:39.992+0900 D/RESOURCED( 2854): appinfo-list.c: resourced_appinfo_put(132) > appid org.example.example, pkgname = org.example.example, ref = 0
06-13 13:39:39.992+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2870
06-13 13:39:39.992+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2870, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
06-13 13:39:39.992+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2870, appname = org.tizen.homescreen
06-13 13:39:39.992+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2870
06-13 13:39:39.992+0900 I/RESOURCED( 2854): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 13:39:39.992+0900 I/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 13:39:40.012+0900 W/CRASH_MANAGER( 4052): worker.c: worker_job(1204) > 1103887657861149732877
