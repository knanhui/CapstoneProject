S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8256
Date: 2017-06-13 15:45:22+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb96c3b70
ebp = 0xbff2ed98, esp = 0xbff2ed30
eax = 0xb96c3b70, ebx = 0xb6b600d4
ecx = 0xb376d000, edx = 0x00000000
eip = 0xb6b3e1f6

Memory Information
MemTotal:      123 KB
MemFree:        30 KB
Buffers:         8 KB
Cached:     157164 KB
VmPeak:     110816 KB
VmSize:     110816 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24328 KB
VmRSS:       24328 KB
VmData:      43088 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34612 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8256 TID = 8256
8256 8258 8395 8397 

Maps Information
b2afe000 b2b08000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b0e000 b2b1a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b1b000 b2b3c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b41000 b2b42000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b43000 b2b48000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b49000 b2b4a000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b4b000 b2b4d000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b4e000 b2b50000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b51000 b2b5d000 r-xp /usr/lib/libdrm.so.2.4.0
b2b5e000 b2b61000 r-xp /usr/lib/libdri2.so.0.0.0
b2b62000 b2b6c000 r-xp /usr/lib/libtbm.so.1.0.0
b2b6d000 b2b6e000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2b6f000 b2b84000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b85000 b2b97000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3399000 b33ca000 r-xp /usr/lib/libidn.so.11.5.44
b33cb000 b33ed000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33ee000 b33fe000 r-xp /usr/lib/libcares.so.2.1.0
b33ff000 b3408000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3409000 b340f000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b3410000 b3426000 r-xp /usr/lib/libalarm.so.0.0.0
b3428000 b3431000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3432000 b34a9000 r-xp /usr/lib/libcurl.so.4.3.0
b34ab000 b34bd000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34be000 b34c1000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b34c2000 b34c5000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b34c6000 b34e7000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34ee000 b34ef000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34f0000 b34f1000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34f2000 b34f5000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34f6000 b34f9000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3601000 b3607000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3608000 b374c000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b375c000 b376b000 r-xp /opt/usr/apps/org.example.example/bin/example
b376e000 b37a7000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41aa000 b41b5000 r-xp /lib/libnss_files-2.20-2014.11.so
b41b7000 b41c2000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41c4000 b41db000 r-xp /lib/libnsl-2.20-2014.11.so
b41df000 b41e7000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41e9000 b420d000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b420e000 b420f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4210000 b4213000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4214000 b421b000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b421c000 b4226000 r-xp /usr/lib/libsensord-share.so
b4227000 b4243000 r-xp /usr/lib/libsensor.so.1.2.0
b4245000 b424e000 r-xp /usr/lib/libappcore-common.so.1.1
b4251000 b4253000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4268000 b426a000 r-xp /usr/lib/libXau.so.6.0.0
b426b000 b428d000 r-xp /usr/lib/libxcb.so.1.1.0
b428f000 b4298000 r-xp /lib/libcrypt-2.20-2014.11.so
b42c1000 b42c3000 r-xp /usr/lib/libiri.so
b42c4000 b42ea000 r-xp /lib/libexpat.so.1.5.2
b42ec000 b4357000 r-xp /usr/lib/libssl.so.1.0.0
b435d000 b4369000 r-xp /usr/lib/libethumb.so.1.13.0
b436a000 b436e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b436f000 b45c0000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b3b000 b5b4b000 r-xp /usr/lib/libXi.so.6.1.0
b5b4c000 b5b4e000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b4f000 b5b55000 r-xp /usr/lib/libXtst.so.6.1.0
b5b56000 b5b60000 r-xp /usr/lib/libXrender.so.1.3.0
b5b61000 b5b6a000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b6c000 b5b6e000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b6f000 b5b74000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b75000 b5b87000 r-xp /usr/lib/libXext.so.6.4.0
b5b88000 b5b8a000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b8b000 b5b8d000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b8f000 b5cd1000 r-xp /usr/lib/libX11.so.6.3.0
b5cd5000 b5cdf000 r-xp /usr/lib/libXcursor.so.1.0.2
b5ce0000 b5cf6000 r-xp /usr/lib/libudev.so.1.6.0
b5cf9000 b5cfd000 r-xp /lib/libattr.so.1.1.0
b5cfe000 b5d2d000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d2f000 b5d35000 r-xp /usr/lib/libffi.so.6.0.2
b5d36000 b5d59000 r-xp /lib/libz.so.1.2.8
b5d5a000 b5d5d000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d5e000 b5eba000 r-xp /usr/lib/libxml2.so.2.9.2
b5ec0000 b5fa7000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fb4000 b5fb7000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fb8000 b5fda000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fdb000 b5fef000 r-xp /lib/libresolv-2.20-2014.11.so
b5ff3000 b6017000 r-xp /usr/lib/liblzma.so.5.0.3
b6018000 b601a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b601c000 b6026000 r-xp /usr/lib/libembryo.so.1.13.0
b6027000 b6050000 r-xp /usr/lib/libpng12.so.0.50.0
b6051000 b609a000 r-xp /usr/lib/libjpeg.so.8.0.2
b60ab000 b60b2000 r-xp /lib/librt-2.20-2014.11.so
b60b4000 b60d3000 r-xp /usr/lib/libector.so.1.13.0
b60d6000 b6103000 r-xp /usr/lib/liblua-5.1.so
b6104000 b6194000 r-xp /usr/lib/libfreetype.so.6.11.3
b6198000 b61d6000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61d7000 b61ed000 r-xp /usr/lib/libfribidi.so.0.3.1
b61ee000 b6247000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b624a000 b6295000 r-xp /lib/libm-2.20-2014.11.so
b6297000 b62a9000 r-xp /usr/lib/libeio.so.1.13.0
b62aa000 b62ad000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62ae000 b62b4000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62b5000 b62d8000 r-xp /usr/lib/libefreet.so.1.13.0
b62db000 b6306000 r-xp /usr/lib/libeldbus.so.1.13.0
b6307000 b633b000 r-xp /usr/lib/libecore_con.so.1.13.0
b633d000 b6346000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6347000 b6350000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6351000 b6364000 r-xp /usr/lib/libeo.so.1.13.0
b6366000 b6379000 r-xp /usr/lib/libecore_input.so.1.13.0
b637a000 b6381000 r-xp /usr/lib/libecore_file.so.1.13.0
b6382000 b63a5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63a6000 b63d2000 r-xp /usr/lib/libeet.so.1.13.0
b63db000 b6446000 r-xp /usr/lib/libeina.so.1.13.0
b6449000 b6460000 r-xp /usr/lib/libefl.so.1.13.0
b6462000 b65c9000 r-xp /usr/lib/libicuuc.so.51.1
b65d7000 b67e3000 r-xp /usr/lib/libicui18n.so.51.1
b67eb000 b683a000 r-xp /usr/lib/libecore_x.so.1.13.0
b683c000 b6856000 r-xp /lib/libgcc_s-4.9.so.1
b6858000 b685c000 r-xp /lib/libcap.so.2.21
b685d000 b68a3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68a4000 b68ab000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68ad000 b68ff000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6901000 b6a8c000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a91000 b6b5f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b62000 b6b66000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b67000 b6b76000 r-xp /usr/lib/libvconf.so.0.2.45
b6b77000 b6b7a000 r-xp /usr/lib/libvasum.so.0.3.1
b6b7b000 b6b7e000 r-xp /usr/lib/libttrace.so.1.1
b6b80000 b6b84000 r-xp /usr/lib/libiniparser.so.0
b6b85000 b6bb5000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bb6000 b6bbf000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bc0000 b6be5000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6be6000 b6bf6000 r-xp /usr/lib/libunwind.so.8.0.1
b6c00000 b6dae000 r-xp /lib/libc-2.20-2014.11.so
b6db6000 b6ef9000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6efb000 b6f53000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f54000 b6f88000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f8b000 b705f000 r-xp /usr/lib/libedje.so.1.13.0
b7062000 b708e000 r-xp /usr/lib/libecore.so.1.13.0
b709f000 b72c5000 r-xp /usr/lib/libevas.so.1.13.0
b72ed000 b7305000 r-xp /lib/libpthread-2.20-2014.11.so
b7309000 b7683000 r-xp /usr/lib/libelementary.so.1.13.0
b76a3000 b76a7000 r-xp /usr/lib/libsmack.so.1.0.0
b76a8000 b76b1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76b2000 b76b5000 r-xp /usr/lib/libdlog.so.0.0.0
b76b6000 b76bb000 r-xp /usr/lib/libbundle.so.0.1.22
b76bc000 b76bf000 r-xp /lib/libdl-2.20-2014.11.so
b76c1000 b76e6000 r-xp /usr/lib/libaul.so.0.1.0
b76e9000 b76eb000 r-xp /usr/lib/libappsvc.so.0.1.0
b76ec000 b76f1000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76f2000 b76f9000 r-xp /usr/lib/libappcore-efl.so.1.1
b76fb000 b7700000 r-xp /usr/lib/libsys-assert.so
b7703000 b7704000 r-xp [vdso]
b7704000 b7726000 r-xp /lib/ld-2.20-2014.11.so
b7728000 b7730000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8256)
Call Stack Count: 9
 0: (0xb6b3e1f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: open_setting_db + 0x143 (0xb3767223) [/opt/usr/apps/org.example.example/bin/example] + 0xb223
 2: app_pause + 0x29 (0xb3765cd9) [/opt/usr/apps/org.example.example/bin/example] + 0x9cd9
 3: (0xb76edce2) [/usr/lib/libcapi-appfw-application.so.0] + 0x1ce2
 4: appcore_efl_main + 0x85a (0xb76f615a) [/usr/lib/libappcore-efl.so.1] + 0x415a
 5: ui_app_main + 0x140 (0xb76eec80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 6: main + 0x2a5 (0xb3765c05) [/opt/usr/apps/org.example.example/bin/example] + 0x9c05
 7: (0xb772a148) [/opt/usr/apps/org.example.example/bin/example] + 0xb772a148
 8: __libc_start_main + 0xde (0xb6c17e4e) [/lib/libc.so.6] + 0x17e4e
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
-13 15:44:14.517+0900 D/AUL_AMD ( 2747): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.tizen.homescreen /usr/apps/org.tizen.homescreen/bin/homescreen
06-13 15:44:14.517+0900 D/RUA     ( 2747): rua.c: rua_add_history(179) > rua_add_history start
06-13 15:44:14.517+0900 D/RUA     ( 2747): rua.c: rua_add_history(247) > rua_add_history ok
06-13 15:44:14.867+0900 E/RESOURCED( 2842): heart-abnormal.c: heart_abnormal_process_crashed(77) > Failed: dbus_message_get_args()
06-13 15:44:17.247+0900 E/EFL     ( 8275): eldbus<8275> lib/eldbus/eldbus_core.c:1005 _connection_get() Error connecting to bus of type 1. error name: org.freedesktop.DBus.Error.NoServer error message: Failed to connect to socket /tmp/dbus-H6c1xka2eG: Connection refused
06-13 15:44:17.247+0900 E/EFL     ( 8275): <8275> lib/eldbus/eldbus_core.c:1068 eldbus_connection_get() safety check failed: conn == NULL
06-13 15:44:17.247+0900 E/EFL     ( 8275): elementary<8275> elm_atspi_bridge.c:4750 _elm_atspi_bridge_eo_base_constructor() Unable to connect to Session Bus
06-13 15:44:17.247+0900 D/APP_CORE( 8275): appcore.c: __aul_handler(587) > [APP 8275]     AUL event: AUL_START
06-13 15:44:17.247+0900 I/APP_CORE( 8275): appcore-efl.c: __do_app(496) > [APP 8275] Event: RESET State: CREATED
06-13 15:44:17.247+0900 D/APP_CORE( 8275): appcore-efl.c: __do_app(527) > [APP 8275] RESET
06-13 15:44:17.247+0900 D/LAUNCH  ( 8275): appcore-efl.c: __do_app(529) > [crash-popup:Application:reset:start]
06-13 15:44:17.247+0900 D/APP_CORE( 8275): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 15:44:17.247+0900 D/APP_CORE( 8275): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 15:44:17.247+0900 E/SYSPOPUP( 8275): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-13 15:44:17.247+0900 E/SYSPOPUP( 8275): syspopup_core.c: _syspopup_get_name_from_bundle(228) > syspopup permission error
06-13 15:44:17.247+0900 E/SYSPOPUP( 8275): syspopup_efl.c: syspopup_create(95) > popup_name or handler is NULL
06-13 15:44:17.247+0900 D/LAUNCH  ( 8275): appcore-efl.c: __do_app(544) > [crash-popup:Application:reset:done]
06-13 15:44:17.247+0900 D/APP_CORE( 8275): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 15:44:17.277+0900 D/AUL     ( 8275): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 15:44:17.277+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 15:44:17.277+0900 W/AUL_AMD ( 2747): amd_request.c: __request_handler(1056) > app status : 5
06-13 15:44:17.277+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(8275) status(5)
06-13 15:44:17.287+0900 D/APP_CORE( 8275): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 15:44:17.287+0900 E/EFL     ( 8275): eo<8275> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x8000542b is not pointing to a valid object. Maybe it has already been freed.
06-13 15:44:17.287+0900 E/EFL     ( 8275): eo<8275> lib/eo/eo.c:485 _eo_do_internal() Obj (0x8000542b) is an invalid ref.
06-13 15:44:22.827+0900 D/cluster-view( 2863): custom-cluster-impl.cpp: OnScrollViewTouched(5256) >  Stop boost timer of cluster by [1]
06-13 15:44:22.827+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40004e 
06-13 15:44:22.927+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 15:44:22.927+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 15:44:22.927+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 15:44:22.927+0900 E/INDICATOR( 2846): 
06-13 15:44:23.827+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1600002
06-13 15:44:28.827+0900 D/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x40004e bd->visible=1
06-13 15:44:42.957+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 15:44:42.957+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 15:44:42.957+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 15:44:42.957+0900 E/INDICATOR( 2846): 
06-13 15:44:49.547+0900 E/PKGMGR_SERVER( 8338): pkgmgr-server.c: main(2209) > package manager server start
06-13 15:44:49.547+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 15:44:49.547+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 15:44:49.557+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 15:44:49.557+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 15:44:49.567+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 15:44:49.567+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.728
06-13 15:44:49.567+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 8336
06-13 15:44:49.567+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 8336
06-13 15:44:49.567+0900 D/PKGMGR  ( 8338): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_-978998268, 14, tpk, org.example.example, , host)
06-13 15:44:49.567+0900 D/PKGMGR_SERVER( 8338): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_-978998268] [14] [tpk] [org.example.example] [] [] [host]
06-13 15:44:49.567+0900 D/PKGMGR_SERVER( 8338): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 15:44:49.567+0900 D/PKGMGR_SERVER( 8338): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 15:44:49.567+0900 D/PKGMGR_SERVER( 8338): pkgmgr-server.c: queue_job(1884) > child forked [8341] for request type [14]
06-13 15:44:49.567+0900 D/PKGMGR_SERVER( 8338): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 15:44:49.567+0900 D/PKGMGR_SERVER( 8341): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 15:44:49.567+0900 D/PKGMGR_SERVER( 8341): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 15:44:49.567+0900 D/PKGMGR  ( 8336): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 15:44:49.567+0900 D/PKGMGR  ( 8336): . 
06-13 15:44:49.567+0900 E/PKGMGR  ( 8336): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 15:44:49.577+0900 D/PKGMGR_SERVER( 8341): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 15:44:49.577+0900 D/AUL     ( 8341): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 15:44:49.577+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 15:44:49.577+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : -1
06-13 15:44:49.577+0900 W/AUL_AMD ( 2747): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: -1
06-13 15:44:49.577+0900 D/PKGMGR_SERVER( 8341): pkgmgr-server.c: __make_pid_info_file(1384) > cano_path(tmp/org.example.example)
06-13 15:44:49.577+0900 D/PKGMGR_SERVER( 8341): pkgmgr-server.c: __make_pid_info_file(1403) > security_server_label_access(tmp/org.example.example, *) is ok.
06-13 15:44:49.587+0900 D/PKGMGR_SERVER( 8338): pkgmgr-server.c: sighandler(387) > child exit [8341]
06-13 15:44:49.587+0900 E/PKGMGR_SERVER( 8338): pkgmgr-server.c: sighandler(402) > child NORMAL exit [8341]
06-13 15:44:50.117+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 0
06-13 15:44:50.127+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
06-13 15:44:50.127+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-13 15:44:50.127+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/launch_app' and package_app_info.app_disable IN ('false','False')
06-13 15:44:50.127+0900 I/AUL     ( 2747): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /usr/bin/launch_app, ret : 0
06-13 15:44:50.127+0900 D/AUL     ( 2747): pkginfo.c: aul_app_get_appid_bypid(255) > second change pgid = 8388, pid = 8390
06-13 15:44:50.127+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-13 15:44:50.127+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/bin/bash' and package_app_info.app_disable IN ('false','False')
06-13 15:44:50.127+0900 I/AUL     ( 2747): menu_db_util.h: _get_app_info_from_db_by_apppath(238) > path : /bin/bash, ret : 0
06-13 15:44:50.127+0900 E/AUL_AMD ( 2747): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-13 15:44:50.127+0900 W/AUL_AMD ( 2747): amd_launch.c: _start_app(2233) > caller pid : 8390
06-13 15:44:50.127+0900 E/AUL_AMD ( 2747): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-13 15:44:50.127+0900 W/AUL_AMD ( 2747): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-13 15:44:50.127+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2648) > process_pool: false
06-13 15:44:50.127+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-13 15:44:50.127+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-13 15:44:50.127+0900 W/AUL_AMD ( 2747): amd_launch.c: _start_app(2665) > pad pid(-5)
06-13 15:44:50.127+0900 D/AUL_AMD ( 2747): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-13 15:44:50.127+0900 D/AUL_AMD ( 2747): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-13 15:44:50.127+0900 D/AUL     ( 2747): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-13 15:44:50.127+0900 D/RESOURCED( 2842): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-13 15:44:50.127+0900 D/RESOURCED( 2842): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-13 15:44:50.127+0900 E/RESOURCED( 2842): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-13 15:44:50.127+0900 W/AUL_PAD ( 2910): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-13 15:44:50.127+0900 D/AUL     ( 2910): process_pool.c: __send_pkt_raw_data(219) > send(11) : 620 / 620
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 8256, bin path: /opt/usr/apps/org.example.example/bin/example
06-13 15:44:50.127+0900 W/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(265) > Check app launching
06-13 15:44:50.127+0900 D/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-13 15:44:50.127+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-13 15:44:50.127+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-13 15:44:50.127+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-13 15:44:50.127+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-13 15:44:50.127+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-13 15:44:50.127+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-13 15:44:50.127+0900 D/AUL     ( 8256): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (8258) is sent.
06-13 15:44:50.127+0900 D/AUL     ( 8256): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 8258, signo: 10
06-13 15:44:50.137+0900 D/AUL     ( 8256): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTczMzYyOTAvMTI5NTQ2AA==##
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAA4MzkwAA==##
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-13 15:44:50.137+0900 D/AUL_PAD ( 8256): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-13 15:44:50.137+0900 I/CAPI_APPFW_APPLICATION( 8256): app_main.c: ui_app_main(788) > app_efl_main
06-13 15:44:50.137+0900 D/LAUNCH  ( 8256): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-13 15:44:50.137+0900 D/APP_CORE( 8256): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-13 15:44:50.137+0900 D/APP_CORE( 8256): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-13 15:44:50.137+0900 D/APP_CORE( 8256): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-13 15:44:50.147+0900 D/APP_CORE( 8256): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-13 15:44:50.147+0900 D/AUL     ( 8256): app_sock.c: __create_server_sock(156) > pg path - already exists
06-13 15:44:50.147+0900 D/APP_CORE( 8256): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb424e520
06-13 15:44:50.147+0900 D/LAUNCH  ( 8256): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-13 15:44:50.147+0900 I/CAPI_APPFW_APPLICATION( 8256): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-13 15:44:50.187+0900 D/LAUNCH  ( 8256): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-13 15:44:50.187+0900 E/E17     ( 2765): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x01200002)
06-13 15:44:50.187+0900 D/APP_CORE( 8256): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-13 15:44:50.197+0900 E/E17     ( 2765): e_border.c: e_border_show(2088) > BD_SHOW(0x01200002)
06-13 15:44:50.197+0900 D/APP_CORE( 8256): appcore.c: __aul_handler(587) > [APP 8256]     AUL event: AUL_START
06-13 15:44:50.197+0900 I/APP_CORE( 8256): appcore-efl.c: __do_app(496) > [APP 8256] Event: RESET State: CREATED
06-13 15:44:50.197+0900 D/APP_CORE( 8256): appcore-efl.c: __do_app(527) > [APP 8256] RESET
06-13 15:44:50.197+0900 D/LAUNCH  ( 8256): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-13 15:44:50.197+0900 D/APP_CORE( 8256): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 15:44:50.197+0900 D/APP_CORE( 8256): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 15:44:50.197+0900 I/CAPI_APPFW_APPLICATION( 8256): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-13 15:44:50.197+0900 D/AUL     ( 8256): service.c: __set_bundle(186) > __set_bundle
06-13 15:44:50.197+0900 D/tag     ( 8256): 왜안돼 ㅠㅠㅠ
06-13 15:44:50.207+0900 D/LAUNCH  ( 8256): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-13 15:44:50.207+0900 D/APP_CORE( 8256): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 15:44:50.207+0900 I/run     ( 8256): socket
06-13 15:44:50.207+0900 I/tag     ( 8256): eonji~
06-13 15:44:50.207+0900 I/run     ( 8256): connect
06-13 15:44:50.207+0900 I/run     ( 8256): new
06-13 15:44:50.207+0900 I/run     ( 8256): send
06-13 15:44:50.207+0900 E/EFL     ( 8256): edje<8256> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:44:50.207+0900 E/EFL     ( 8256): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:44:50.207+0900 E/EFL     ( 8256): edje<8256> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:44:50.207+0900 E/EFL     ( 8256): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:44:50.207+0900 E/EFL     ( 8256): edje<8256> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:44:50.207+0900 E/EFL     ( 8256): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:44:50.207+0900 E/EFL     ( 8256): edje<8256> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:44:50.207+0900 E/EFL     ( 8256): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:44:50.207+0900 E/EFL     ( 8256): edje<8256> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 15:44:50.207+0900 E/EFL     ( 8256): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 15:44:50.207+0900 W/APP_CORE( 8256): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1200002
06-13 15:44:50.207+0900 W/PROCESSMGR( 2765): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8256
06-13 15:44:50.207+0900 D/APP_CORE( 8256): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:1200002
06-13 15:44:50.207+0900 D/APP_CORE( 8256): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-13 15:44:50.207+0900 D/AUL     ( 8256): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-13 15:44:50.217+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 15:44:50.217+0900 E/EFL     ( 2765): eo<2765> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 15:44:50.217+0900 D/INDICATOR( 2846): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-13 15:44:50.217+0900 D/INDICATOR( 2846): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-13 15:44:50.217+0900 D/INDICATOR( 2846): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 15:44:50.217+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 15:44:50.217+0900 D/INDICATOR( 2846): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 15:44:50.217+0900 D/INDICATOR( 2846): main.c: _rotate_window(252) > port :: hide more icon
06-13 15:44:50.227+0900 D/AUL_PAD ( 2910): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-13 15:44:50.227+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 8256, appid: org.example.example
06-13 15:44:50.227+0900 D/AUL     ( 2747): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-13 15:44:50.227+0900 E/AUL     ( 2747): simple_util.c: __trm_app_info_send_socket(330) > access
06-13 15:44:50.227+0900 D/AUL_AMD ( 2747): amd_launch.c: _start_app(2700) > add app group info
06-13 15:44:50.227+0900 E/AUL     ( 2747): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-13 15:44:50.227+0900 D/AUL_AMD ( 2747): amd_status.c: _status_add_app_info_list(427) > pid(8256) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-13 15:44:50.227+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 34
06-13 15:44:50.227+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 8256
06-13 15:44:50.227+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-13 15:44:50.227+0900 E/RESOURCED( 2842): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-13 15:44:50.227+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 15:44:50.227+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(888) > available memory = 313
06-13 15:44:50.227+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 15:44:50.227+0900 D/PKGMGR_INFO( 2747): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 15:44:50.237+0900 D/AUL_AMD ( 2747): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8256 is org.example.example
06-13 15:44:50.237+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8256 : 0
06-13 15:44:50.237+0900 D/AUL     ( 2934): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-13 15:44:50.637+0900 D/APP_CORE( 8256): appcore.c: __prt_ltime(236) > [APP 8256] first idle after reset: 520 msec
06-13 15:44:50.797+0900 E/E17     ( 2765): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-13 15:44:50.797+0900 D/APP_CORE( 2863): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-13 15:44:50.797+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 15:44:50.797+0900 D/APP_CORE( 2863): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 15:44:50.797+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: PAUSE State: RUNNING
06-13 15:44:50.797+0900 D/APP_CORE( 2863): appcore-efl.c: __do_app(565) > [APP 2863] PAUSE
06-13 15:44:50.797+0900 I/CAPI_APPFW_APPLICATION( 2863): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 15:44:50.797+0900 E/cluster-home( 2863): homescreen.cpp: OnPause(84) >  app pause
06-13 15:44:50.797+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-13 15:44:50.797+0900 D/cluster-view( 2863): homescreen-view-manager.cpp: AppPause(923) >  END
06-13 15:44:50.797+0900 D/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 15:44:50.797+0900 E/APP_CORE( 2863): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 15:44:50.797+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(2863) status(4)
06-13 15:44:50.797+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(2863) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-13 15:44:50.797+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-13 15:44:50.797+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2863, appid: org.tizen.homescreen, status: bg
06-13 15:44:50.797+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2891) > pid(8256) status(3)
06-13 15:44:50.797+0900 D/AUL_AMD ( 2747): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-13 15:44:50.807+0900 W/AUL_AMD ( 2747): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 15:44:50.807+0900 W/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 15:44:50.807+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(8256) status(3)
06-13 15:44:50.807+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(8256) appid(org.example.example) pkgid(org.example.example) status(3)
06-13 15:44:50.807+0900 D/AUL     ( 2747): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-13 15:44:50.807+0900 W/AUL     ( 2747): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8256, appid: org.example.example, status: fg
06-13 15:44:50.807+0900 D/RESOURCED( 2842): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8256
06-13 15:44:50.807+0900 D/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8256, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 15:44:50.807+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8256
06-13 15:44:50.807+0900 D/DATA_PROVIDER_MASTER( 2922): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2863 is paused
06-13 15:44:50.807+0900 D/DATA_PROVIDER_MASTER( 2922): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-13 15:44:50.807+0900 I/CAPI_WIDGET_APPLICATION( 3008): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-13 15:44:50.807+0900 I/CAPI_WIDGET_APPLICATION( 3008): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-13 15:44:50.807+0900 W/AUL     ( 3008): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3008, appid: org.tizen.calendar.widget, status: bg
06-13 15:44:50.827+0900 D/APP_CORE( 8256): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-13 15:44:50.827+0900 D/APP_CORE( 8256): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-13 15:44:50.827+0900 D/APP_CORE( 8256): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 15:44:50.827+0900 I/APP_CORE( 8256): appcore-efl.c: __do_app(496) > [APP 8256] Event: RESUME State: CREATED
06-13 15:44:50.827+0900 D/LAUNCH  ( 8256): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-13 15:44:50.827+0900 D/APP_CORE( 8256): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 15:44:50.827+0900 D/APP_CORE( 8256): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 15:44:50.827+0900 D/APP_CORE( 8256): appcore-efl.c: __do_app(607) > [APP 8256] RESUME
06-13 15:44:50.827+0900 D/AUL_AMD ( 2747): amd_launch.c: __e17_status_handler(2910) > pid(8256) status(0)
06-13 15:44:50.827+0900 I/APP_CORE( 8256): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-13 15:44:50.827+0900 I/APP_CORE( 8256): appcore-efl.c: __do_app(614) > [APP 8256] Initial Launching, call the resume_cb
06-13 15:44:50.827+0900 I/CAPI_APPFW_APPLICATION( 8256): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 15:44:50.827+0900 D/LAUNCH  ( 8256): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-13 15:44:50.827+0900 D/LAUNCH  ( 8256): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-13 15:44:50.827+0900 D/APP_CORE( 8256): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 15:44:50.827+0900 E/APP_CORE( 8256): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 15:44:50.857+0900 D/RESOURCED( 2842): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8256, appname = org.example.example, pkgname = org.example.example
06-13 15:44:50.857+0900 D/RESOURCED( 2842): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8256, appname = org.example.example
06-13 15:44:50.857+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8256
06-13 15:44:50.857+0900 D/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3008, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-13 15:44:50.857+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3008
06-13 15:44:50.857+0900 D/RESOURCED( 2842): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3008, appname = org.tizen.calendar.widget
06-13 15:44:50.857+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3008
06-13 15:44:50.857+0900 I/RESOURCED( 2842): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 15:44:50.857+0900 I/RESOURCED( 2842): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 15:44:51.237+0900 D/AUL_PAD ( 2910): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 15:44:51.237+0900 D/AUL_PAD ( 8398): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 15:44:51.237+0900 D/AUL_PAD ( 2910): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 15:44:51.247+0900 E/RESOURCED( 2842): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.732
06-13 15:44:51.737+0900 D/AUL_AMD ( 2747): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 15:44:51.737+0900 D/RUA     ( 2747): rua.c: rua_add_history(179) > rua_add_history start
06-13 15:44:51.737+0900 D/RUA     ( 2747): rua.c: rua_add_history(247) > rua_add_history ok
06-13 15:44:51.997+0900 E/PKGMGR_SERVER( 8338): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 15:44:51.997+0900 E/PKGMGR_SERVER( 8338): pkgmgr-server.c: main(2265) > package manager server terminated.
06-13 15:44:52.277+0900 D/AUL_PAD ( 8398): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 15:44:52.277+0900 D/AUL_PAD ( 8398): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 15:44:52.287+0900 D/AUL_PAD ( 8398): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8c91760
06-13 15:44:52.287+0900 D/AUL_PAD ( 8398): preload.h: __preload_init(69) > get pre-initialization function
06-13 15:44:52.287+0900 D/AUL_PAD ( 8398): preload.h: __preload_init(73) > get shutdown function
06-13 15:44:52.287+0900 D/AUL_PAD ( 8398): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8c91a40
06-13 15:44:52.297+0900 D/AUL_PAD ( 8398): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8c93640
06-13 15:44:52.297+0900 D/AUL_PAD ( 8398): preload.h: __preload_init(69) > get pre-initialization function
06-13 15:44:52.297+0900 D/AUL_PAD ( 8398): preload.h: __preload_init(73) > get shutdown function
06-13 15:44:52.297+0900 D/AUL_PAD ( 8398): preexec.h: __preexec_init(76) > preexec start
06-13 15:44:52.297+0900 D/AUL_PAD ( 8398): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 15:44:52.297+0900 D/AUL     ( 8398): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 15:44:52.297+0900 D/AUL     ( 8398): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 15:44:52.297+0900 D/AUL     ( 8398): process_pool.c: __connect_to_launchpad(132) > send(8398) : 4
06-13 15:44:52.297+0900 D/AUL     ( 8398): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 15:44:52.297+0900 D/AUL_PAD ( 2910): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8398
06-13 15:44:52.367+0900 D/AUL_PAD ( 8398): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 15:44:52.367+0900 D/AUL_PAD ( 8398): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 15:44:52.367+0900 D/AUL_PAD ( 8398): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 15:44:52.377+0900 D/AUL_PAD ( 8398): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 15:44:55.797+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 15:44:55.797+0900 I/APP_CORE( 2863): appcore-efl.c: __do_app(496) > [APP 2863] Event: MEM_FLUSH State: PAUSED
06-13 15:44:55.807+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 15:44:55.807+0900 D/APP_CORE( 2863): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2863
06-13 15:44:55.807+0900 D/APP_CORE( 2863): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 15:44:55.807+0900 D/RESOURCED( 2842): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2863
06-13 15:45:00.546+0900 D/INDICATOR( 2846): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 15:45:00.546+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 15:45:00.546+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 15:45:00.546+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 3:45 4 h"
06-13 15:45:00.546+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 3:45"
06-13 15:45:00.546+0900 D/INDICATOR( 2846): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 3&#x2236;45"
06-13 15:45:00.546+0900 D/INDICATOR( 2846): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146461745 Time: <font_size=33>3&#x2236;45</font_size> <font_size=32>PM</font_size></font>
06-13 15:45:02.956+0900 E/CAPI_NETWORK_WIFI( 2846): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 15:45:02.956+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
06-13 15:45:02.956+0900 E/INDICATOR( 2846): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 15:45:02.956+0900 E/INDICATOR( 2846): 
06-13 15:45:13.126+0900 D/RESOURCED( 2842): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 15:45:13.126+0900 I/RESOURCED( 2842): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 15:45:13.126+0900 D/RESOURCED( 2842): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 15:45:13.126+0900 I/RESOURCED( 2842): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 15:45:13.136+0900 I/RESOURCED( 2842): logging.c: logging_save_to_storage(978) > battery cache is empty
06-13 15:45:22.076+0900 E/PKGMGR_SERVER( 8434): pkgmgr-server.c: main(2209) > package manager server start
06-13 15:45:22.086+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 15:45:22.086+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 15:45:22.096+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 15:45:22.096+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 15:45:22.096+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 15:45:22.096+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.735
06-13 15:45:22.106+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 8432
06-13 15:45:22.106+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 8432
06-13 15:45:22.106+0900 D/PKGMGR  ( 8434): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_-946460677, 14, tpk, org.example.example, , host)
06-13 15:45:22.106+0900 D/PKGMGR_SERVER( 8434): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_-946460677] [14] [tpk] [org.example.example] [] [] [host]
06-13 15:45:22.106+0900 D/PKGMGR_SERVER( 8434): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 15:45:22.106+0900 D/PKGMGR_SERVER( 8434): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 15:45:22.106+0900 D/PKGMGR_SERVER( 8434): pkgmgr-server.c: queue_job(1884) > child forked [8437] for request type [14]
06-13 15:45:22.106+0900 D/PKGMGR_SERVER( 8437): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 15:45:22.106+0900 D/PKGMGR_SERVER( 8437): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 15:45:22.106+0900 D/PKGMGR_SERVER( 8434): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 15:45:22.106+0900 D/PKGMGR  ( 8432): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 15:45:22.106+0900 D/PKGMGR  ( 8432): . 
06-13 15:45:22.106+0900 E/PKGMGR  ( 8432): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 15:45:22.106+0900 D/PKGMGR_SERVER( 8437): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 15:45:22.116+0900 D/AUL     ( 8437): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 8256
06-13 15:45:22.116+0900 W/AUL_AMD ( 2747): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 8256
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 12
06-13 15:45:22.116+0900 D/AUL     ( 8437): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 292
06-13 15:45:22.116+0900 D/AUL     ( 8437): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 8256
06-13 15:45:22.116+0900 D/AUL     ( 8437): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 5
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 8256, 
06-13 15:45:22.116+0900 D/AUL     ( 2747): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(8256) : cmd(4)
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_launch.c: _term_app(1076) > term done
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-13 15:45:22.116+0900 D/APP_CORE( 8256): appcore.c: __aul_handler(632) > [APP 8256]     AUL event: AUL_TERMINATE
06-13 15:45:22.116+0900 I/APP_CORE( 8256): appcore-efl.c: __do_app(496) > [APP 8256] Event: TERMINATE State: RUNNING
06-13 15:45:22.116+0900 D/APP_CORE( 8256): appcore-efl.c: __do_app(517) > [APP 8256] TERMINATE
06-13 15:45:22.116+0900 W/AUL_AMD ( 2747): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(8256), cmd(4)
06-13 15:45:22.116+0900 D/AUL     ( 8437): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-13 15:45:22.116+0900 D/AUL     ( 8437): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 8256
06-13 15:45:22.116+0900 W/AUL_AMD ( 2747): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 8256
06-13 15:45:22.116+0900 D/AUL     ( 8256): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 15:45:22.116+0900 W/AUL_AMD ( 2747): amd_request.c: __request_handler(1056) > app status : 5
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(8256) status(5)
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(8256) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 15:45:22.116+0900 D/AUL     ( 8256): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 15:45:22.116+0900 W/AUL_AMD ( 2747): amd_request.c: __request_handler(1056) > app status : 5
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(456) > pid(8256) status(5)
06-13 15:45:22.116+0900 D/AUL_AMD ( 2747): amd_status.c: _status_update_app_info_list(468) > pid(8256) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 15:45:22.116+0900 D/RESOURCED( 2842): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8256
06-13 15:45:22.116+0900 D/APP_CORE( 8256): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 15:45:22.116+0900 D/APP_CORE( 8256): appcore-efl.c: __after_loop(1169) > [APP 8256] PAUSE before termination
06-13 15:45:22.116+0900 I/CAPI_APPFW_APPLICATION( 8256): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 15:45:22.116+0900 I/user_tag0( 8256): /opt/usr/apps/org.example.example/data/test.db
06-13 15:45:22.146+0900 W/CRASH_MANAGER( 8439): worker.c: worker_job(1204) > 1108256657861149733632
