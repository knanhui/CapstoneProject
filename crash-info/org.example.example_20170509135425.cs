S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 19962
Date: 2017-05-09 13:54:25+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb75e2f90

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb34b9b06, esi = 0xb75e2f90
ebp = 0xbfcfd578, esp = 0xbfcfd420
eax = 0xb93b1400, ebx = 0xb34c02f0
ecx = 0x00000000, edx = 0x0000000b
eip = 0xb34b7423

Memory Information
MemTotal:      123 KB
MemFree:        12 KB
Buffers:         7 KB
Cached:     215488 KB
VmPeak:      99492 KB
VmSize:      99492 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22048 KB
VmRSS:       22048 KB
VmData:      32848 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33568 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 19962 TID = 19962
19962 19963 19980 19982 

Maps Information
b2c08000 b2c12000 r-xp /usr/lib/libfeedback.so.0.1.4
b2c18000 b2c24000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2c25000 b2c46000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c4b000 b2c4c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c4d000 b2c52000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c53000 b2c54000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c55000 b2c57000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c58000 b2c64000 r-xp /usr/lib/libdrm.so.2.4.0
b2c65000 b2c6f000 r-xp /usr/lib/libtbm.so.1.0.0
b2c70000 b2c85000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c86000 b2c98000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b349a000 b34a3000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34a4000 b34ad000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34ae000 b34c0000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34c1000 b34e2000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34e9000 b34ea000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34eb000 b34ec000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34ed000 b34f0000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34f1000 b34f4000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35fc000 b3602000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3603000 b3747000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3757000 b3759000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b375a000 b375d000 r-xp /usr/lib/libdri2.so.0.0.0
b375e000 b375f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3760000 b3766000 r-xp /opt/usr/apps/org.example.example/bin/example
b3769000 b37a2000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41a5000 b41b0000 r-xp /lib/libnss_files-2.20-2014.11.so
b41b2000 b41bd000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41bf000 b41d6000 r-xp /lib/libnsl-2.20-2014.11.so
b41da000 b41e2000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41e4000 b4208000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4209000 b420a000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b420b000 b420e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b420f000 b4216000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4217000 b4221000 r-xp /usr/lib/libsensord-share.so
b4222000 b423e000 r-xp /usr/lib/libsensor.so.1.2.0
b4240000 b4249000 r-xp /usr/lib/libappcore-common.so.1.1
b424c000 b424e000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4263000 b4265000 r-xp /usr/lib/libXau.so.6.0.0
b4266000 b4288000 r-xp /usr/lib/libxcb.so.1.1.0
b428a000 b4293000 r-xp /lib/libcrypt-2.20-2014.11.so
b42bc000 b42be000 r-xp /usr/lib/libiri.so
b42bf000 b42e5000 r-xp /lib/libexpat.so.1.5.2
b42e7000 b4352000 r-xp /usr/lib/libssl.so.1.0.0
b4358000 b4364000 r-xp /usr/lib/libethumb.so.1.13.0
b4365000 b4369000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b436a000 b45bb000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b36000 b5b46000 r-xp /usr/lib/libXi.so.6.1.0
b5b47000 b5b49000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b4a000 b5b50000 r-xp /usr/lib/libXtst.so.6.1.0
b5b51000 b5b5b000 r-xp /usr/lib/libXrender.so.1.3.0
b5b5c000 b5b65000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b67000 b5b69000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b6a000 b5b6f000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b70000 b5b82000 r-xp /usr/lib/libXext.so.6.4.0
b5b83000 b5b85000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b86000 b5b88000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b8a000 b5ccc000 r-xp /usr/lib/libX11.so.6.3.0
b5cd0000 b5cda000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cdb000 b5cf1000 r-xp /usr/lib/libudev.so.1.6.0
b5cf4000 b5cf8000 r-xp /lib/libattr.so.1.1.0
b5cf9000 b5d28000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d2a000 b5d30000 r-xp /usr/lib/libffi.so.6.0.2
b5d31000 b5d54000 r-xp /lib/libz.so.1.2.8
b5d55000 b5d58000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d59000 b5eb5000 r-xp /usr/lib/libxml2.so.2.9.2
b5ebb000 b5fa2000 r-xp /usr/lib/libstdc++.so.6.0.20
b5faf000 b5fb2000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fb3000 b5fd5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fd6000 b5fea000 r-xp /lib/libresolv-2.20-2014.11.so
b5fee000 b6012000 r-xp /usr/lib/liblzma.so.5.0.3
b6013000 b6015000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6017000 b6021000 r-xp /usr/lib/libembryo.so.1.13.0
b6022000 b604b000 r-xp /usr/lib/libpng12.so.0.50.0
b604c000 b6095000 r-xp /usr/lib/libjpeg.so.8.0.2
b60a6000 b60ad000 r-xp /lib/librt-2.20-2014.11.so
b60af000 b60ce000 r-xp /usr/lib/libector.so.1.13.0
b60d1000 b60fe000 r-xp /usr/lib/liblua-5.1.so
b60ff000 b618f000 r-xp /usr/lib/libfreetype.so.6.11.3
b6193000 b61d1000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61d2000 b61e8000 r-xp /usr/lib/libfribidi.so.0.3.1
b61e9000 b6242000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6245000 b6290000 r-xp /lib/libm-2.20-2014.11.so
b6292000 b62a4000 r-xp /usr/lib/libeio.so.1.13.0
b62a5000 b62a8000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62a9000 b62af000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62b0000 b62d3000 r-xp /usr/lib/libefreet.so.1.13.0
b62d6000 b6301000 r-xp /usr/lib/libeldbus.so.1.13.0
b6302000 b6336000 r-xp /usr/lib/libecore_con.so.1.13.0
b6338000 b6341000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6342000 b634b000 r-xp /usr/lib/libethumb_client.so.1.13.0
b634c000 b635f000 r-xp /usr/lib/libeo.so.1.13.0
b6361000 b6374000 r-xp /usr/lib/libecore_input.so.1.13.0
b6375000 b637c000 r-xp /usr/lib/libecore_file.so.1.13.0
b637d000 b63a0000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63a1000 b63cd000 r-xp /usr/lib/libeet.so.1.13.0
b63d6000 b6441000 r-xp /usr/lib/libeina.so.1.13.0
b6444000 b645b000 r-xp /usr/lib/libefl.so.1.13.0
b645d000 b65c4000 r-xp /usr/lib/libicuuc.so.51.1
b65d2000 b67de000 r-xp /usr/lib/libicui18n.so.51.1
b67e6000 b6835000 r-xp /usr/lib/libecore_x.so.1.13.0
b6837000 b6851000 r-xp /lib/libgcc_s-4.9.so.1
b6853000 b6857000 r-xp /lib/libcap.so.2.21
b6858000 b689e000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b689f000 b68a6000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68a8000 b68fa000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68fc000 b6a87000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a8c000 b6b5a000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b5d000 b6b61000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b62000 b6b71000 r-xp /usr/lib/libvconf.so.0.2.45
b6b72000 b6b75000 r-xp /usr/lib/libvasum.so.0.3.1
b6b76000 b6b79000 r-xp /usr/lib/libttrace.so.1.1
b6b7b000 b6b7f000 r-xp /usr/lib/libiniparser.so.0
b6b80000 b6bb0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6bb1000 b6bba000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bbb000 b6be0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6be1000 b6bf1000 r-xp /usr/lib/libunwind.so.8.0.1
b6bfb000 b6da9000 r-xp /lib/libc-2.20-2014.11.so
b6db1000 b6ef4000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ef6000 b6f4e000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f4f000 b6f83000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f86000 b705a000 r-xp /usr/lib/libedje.so.1.13.0
b705d000 b7089000 r-xp /usr/lib/libecore.so.1.13.0
b709a000 b72c0000 r-xp /usr/lib/libevas.so.1.13.0
b72e8000 b7300000 r-xp /lib/libpthread-2.20-2014.11.so
b7304000 b767e000 r-xp /usr/lib/libelementary.so.1.13.0
b769e000 b76a2000 r-xp /usr/lib/libsmack.so.1.0.0
b76a3000 b76ac000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76ad000 b76b0000 r-xp /usr/lib/libdlog.so.0.0.0
b76b1000 b76b6000 r-xp /usr/lib/libbundle.so.0.1.22
b76b7000 b76ba000 r-xp /lib/libdl-2.20-2014.11.so
b76bc000 b76e1000 r-xp /usr/lib/libaul.so.0.1.0
b76e4000 b76e6000 r-xp /usr/lib/libappsvc.so.0.1.0
b76e7000 b76ec000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76ed000 b76f4000 r-xp /usr/lib/libappcore-efl.so.1.1
b76f6000 b76fb000 r-xp /usr/lib/libsys-assert.so
b76fe000 b76ff000 r-xp [vdso]
b76ff000 b7721000 r-xp /lib/ld-2.20-2014.11.so
b7723000 b772b000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:19962)
Call Stack Count: 22
 0: system_setting_get_locale_timezone + 0x113 (0xb34b7423) [/usr/lib/libcapi-system-system-settings.so.0] + 0x9423
 1: system_settings_get_value + 0xb8 (0xb34b2418) [/usr/lib/libcapi-system-system-settings.so.0] + 0x4418
 2: system_settings_get_value_string + 0x80 (0xb34b2b70) [/usr/lib/libcapi-system-system-settings.so.0] + 0x4b70
 3: create_button_view + 0x488 (0xb37621f8) [/opt/usr/apps/org.example.example/bin/example] + 0x21f8
 4: diary_view_cb + 0x54 (0xb3761cb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1cb4
 5: (0xb70ce449) [/usr/lib/libevas.so.1] + 0x34449
 6: (0xb635a319) [/usr/lib/libeo.so.1] + 0xe319
 7: eo_event_callback_call + 0xb3 (0xb6357d63) [/usr/lib/libeo.so.1] + 0xbd63
 8: (0xb70cea62) [/usr/lib/libevas.so.1] + 0x34a62
 9: (0xb70dd441) [/usr/lib/libevas.so.1] + 0x43441
10: evas_canvas_event_feed_mouse_down + 0xcf (0xb70e720f) [/usr/lib/libevas.so.1] + 0x4d20f
11: evas_event_feed_mouse_down + 0x6a (0xb70edc2a) [/usr/lib/libevas.so.1] + 0x53c2a
12: (0xb436749c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
13: (0xb706a055) [/usr/lib/libecore.so.1] + 0xd055
14: (0xb70731b9) [/usr/lib/libecore.so.1] + 0x161b9
15: ecore_main_loop_begin + 0x57 (0xb7073587) [/usr/lib/libecore.so.1] + 0x16587
16: elm_run + 0x2d (0xb74cc22d) [/usr/lib/libelementary.so.1] + 0x1c822d
17: appcore_efl_main + 0x4de (0xb76f0dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
18: ui_app_main + 0x140 (0xb76e9c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
19: main + 0x27e (0xb3763c1e) [/opt/usr/apps/org.example.example/bin/example] + 0x3c1e
20: create_button_view + 0x3d8 (0xb7725148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7725148
21: __libc_start_main + 0xde (0xb6c12e4e) [/lib/libc.so.6] + 0x17e4e
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
:Launching:done]
05-09 13:54:21.893+0900 D/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-09 13:54:21.893+0900 E/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-09 13:54:21.893+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 13:54:21.903+0900 D/DATA_PROVIDER_MASTER( 2932): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2878 is resumed
05-09 13:54:21.903+0900 D/DATA_PROVIDER_MASTER( 2932): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
05-09 13:54:21.903+0900 E/DATA_PROVIDER_MASTER( 2932): setting.c: setting_is_lcd_off(95) > [SECURE_LOG] State: 1, (3:lcdoff, 4:sleep)
05-09 13:54:21.903+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __provider_resume_cb(312) > widget obj was resumed
05-09 13:54:21.903+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __check_status_for_cgroup(132) > enter foreground group
05-09 13:54:21.903+0900 W/AUL     ( 3017): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3017, appid: org.tizen.calendar.widget, status: fg
05-09 13:54:21.903+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
05-09 13:54:21.903+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3017
05-09 13:54:21.903+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3017, proc_name: org.tizen.calendar.widget, cg_name: foreground, oom_score_adj: 200
05-09 13:54:21.903+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3017
05-09 13:54:21.903+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
05-09 13:54:21.903+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.homescreen/bin/homescreen' and package_app_info.app_disable IN ('false','False')
05-09 13:54:21.913+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2878 is org.tizen.homescreen
05-09 13:54:21.913+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2878 : 0
05-09 13:54:21.913+0900 D/AUL     ( 2940): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 29
05-09 13:54:21.943+0900 D/RESOURCED( 2860): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3017, appname = org.tizen.calendar.widget
05-09 13:54:21.943+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3017
05-09 13:54:21.943+0900 I/RESOURCED( 2860): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-09 13:54:21.943+0900 I/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-09 13:54:22.143+0900 D/cluster-view( 2878): custom-cluster-impl.cpp: OnCustomScrollComplete(5141) >  ##################### scroll complete ########################### 
05-09 13:54:22.143+0900 D/cluster-view( 2878): cluster-impl.cpp: OnScrollComplete(639) >  Horizontal Cluster scrollview is stopped normally, pos[0.00, 0.00]
05-09 13:54:22.143+0900 D/cluster-view( 2878): cluster-impl.cpp: OnScrollComplete(653) >  scroll position x : -0.00 (page:0)
05-09 13:54:22.143+0900 D/test-log( 2878): cluster-impl.cpp: SetFocusedPage(791) >  Set mFocusedPage: 1
05-09 13:54:22.143+0900 D/test-log( 2878): cluster-impl.cpp: GetFocusedPage(798) >  mFocusedPage: 1
05-09 13:54:22.143+0900 D/cluster-view( 2878): cluster-view-controller.cpp: OnClusterChangeFocusedPage(1779) >  Cluster[0:] 1 page focused
05-09 13:54:22.143+0900 D/cluster-home( 2878): widget-data-provider.cpp: OnCustomClusterFocusedPageChanged(2934) >  Cluster[0] page[1] focused
05-09 13:54:22.473+0900 D/WIDGET_PROVIDER( 3017): widget_provider.c: widget_provider_send_ping(1671) > [SECURE_LOG] name[0_36.784294]
05-09 13:54:23.493+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1023) >  menu box Pick touched
05-09 13:54:23.493+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1034) >  Long Tap Timer Start
05-09 13:54:23.663+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1194) >  Box[0] pick ended by Up
05-09 13:54:23.663+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1199) >  Cancel Long Tap Timer
05-09 13:54:23.663+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1240) >  app launch state[1]
05-09 13:54:23.663+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1249) >  touch is moved upper position!!!
05-09 13:54:23.663+0900 D/test-log( 2878): mainmenu-box-impl.cpp: OnPickEventMenuBoxTouchEvent(1298) >  laundch!!!!! touch position is moved from[489.00][335.00] to[489.00][335.00]!
05-09 13:54:23.663+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: IsOverScrollThreshold(997) >  is Over Scrollview TreshHold?[0]
05-09 13:54:23.663+0900 D/cluster-home( 2878): mainmenu-custom-box-impl.cpp: OnClicked(171) >  [13]MenuBox clicked
05-09 13:54:23.673+0900 D/cluster-home( 2878): mainmenu-custom-box-impl.cpp: OnClicked(184) >  launch application via service(operation APP_CONTROL_OPERATION_DEFAULT)
05-09 13:54:23.673+0900 D/AUL     ( 2878): service.c: __set_bundle(186) > __set_bundle
05-09 13:54:23.673+0900 D/AUL     ( 2878): service.c: __get_alias_appid(548) > [SECURE_LOG] alias_id : (null)
05-09 13:54:23.673+0900 D/AUL     ( 2878): service.c: __set_bundle(186) > __set_bundle
05-09 13:54:23.673+0900 D/AUL     ( 2878): service.c: __run_svc_with_pkgname(276) > [SECURE_LOG] pkg_name : org.example.example - no result
05-09 13:54:23.673+0900 D/AUL     ( 2878): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : org.example.example
05-09 13:54:23.673+0900 D/AUL     ( 2878): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(0)
05-09 13:54:23.673+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 0
05-09 13:54:23.673+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(882) > [SECURE_LOG] launch a single-instance appid: org.example.example
05-09 13:54:23.673+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2231) > [SECURE_LOG] caller appid : org.tizen.homescreen
05-09 13:54:23.673+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2233) > caller pid : 2878
05-09 13:54:23.683+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2443) > win(a00002) ecore_x_pointer_grab(1)
05-09 13:54:23.683+0900 D/AUL_AMD ( 2763): amd_key.c: _key_grab(243) > _key_grab, win : a00002
05-09 13:54:23.683+0900 D/PROCESSMGR( 2725): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40004e 
05-09 13:54:23.683+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2448) > back key grab
05-09 13:54:23.683+0900 W/AUL_AMD ( 2763): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
05-09 13:54:23.683+0900 D/RESOURCED( 2860): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-09 13:54:23.683+0900 D/RESOURCED( 2860): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 2
05-09 13:54:23.683+0900 E/RESOURCED( 2860): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-09 13:54:23.693+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2518) > org.tizen.system.deviced.PmQos-AppLaunch : 0
05-09 13:54:23.693+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2648) > process_pool: false
05-09 13:54:23.693+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
05-09 13:54:23.693+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
05-09 13:54:23.693+0900 W/AUL_AMD ( 2763): amd_launch.c: _start_app(2665) > pad pid(-5)
05-09 13:54:23.693+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-09 13:54:23.693+0900 D/AUL_AMD ( 2763): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
05-09 13:54:23.693+0900 D/AUL     ( 2763): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
05-09 13:54:23.693+0900 W/AUL_PAD ( 2926): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
05-09 13:54:23.693+0900 D/AUL     ( 2926): process_pool.c: __send_pkt_raw_data(219) > send(13) : 884 / 884
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 19962, bin path: /opt/usr/apps/org.example.example/bin/example
05-09 13:54:23.693+0900 W/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(265) > Check app launching
05-09 13:54:23.693+0900 D/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 884, pkt->len: 876
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-09 13:54:23.693+0900 D/AUL     (19962): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (19963) is sent.
05-09 13:54:23.693+0900 D/AUL     (19962): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 19963, signo: 10
05-09 13:54:23.693+0900 D/AUL     (19962): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : UgAAAAEEAAAUAAAAX19BUFBfU1ZDX09QX1RZUEVfXwAuAAAAaHR0cDovL3RpemVuLm9yZy9hcHBjb250cm9sL29wZXJhdGlvbi9kZWZhdWx0AA==##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __APP_SVC_PKG_NAME__##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : OQAAAAEEAAAVAAAAX19BUFBfU1ZDX1BLR19OQU1FX18AFAAAAG9yZy5leGFtcGxlLmV4YW1wbGUA##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_STARTTIME__##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTQzMDU2NjMvNjg0MTc1AA==##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 8 : __AUL_CALLER_PID__##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 9 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAyODc4AA==##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 10 : __AUL_CALLER_APPID__##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 11 : OgAAAAEEAAAVAAAAX19BVUxfQ0FMTEVSX0FQUElEX18AFQAAAG9yZy50aXplbi5ob21lc2NyZWVuAA==##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 12 : __AUL_INTERNAL_POOL__##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 13 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 14
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-09 13:54:23.693+0900 D/AUL_PAD (19962): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-09 13:54:23.693+0900 I/CAPI_APPFW_APPLICATION(19962): app_main.c: ui_app_main(788) > app_efl_main
05-09 13:54:23.693+0900 D/LAUNCH  (19962): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-09 13:54:23.693+0900 D/APP_CORE(19962): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-09 13:54:23.693+0900 D/APP_CORE(19962): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-09 13:54:23.693+0900 D/APP_CORE(19962): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-09 13:54:23.723+0900 D/APP_CORE(19962): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-09 13:54:23.723+0900 D/AUL     (19962): app_sock.c: __create_server_sock(156) > pg path - already exists
05-09 13:54:23.723+0900 D/APP_CORE(19962): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb4249520
05-09 13:54:23.723+0900 D/LAUNCH  (19962): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-09 13:54:23.723+0900 I/CAPI_APPFW_APPLICATION(19962): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-09 13:54:23.793+0900 D/AUL_PAD ( 2926): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-09 13:54:23.793+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 19962, appid: org.example.example
05-09 13:54:23.793+0900 D/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-09 13:54:23.793+0900 E/AUL     ( 2763): simple_util.c: __trm_app_info_send_socket(330) > access
05-09 13:54:23.793+0900 D/AUL_AMD ( 2763): amd_launch.c: _start_app(2700) > add app group info
05-09 13:54:23.793+0900 E/AUL     ( 2763): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-09 13:54:23.793+0900 D/AUL_AMD ( 2763): amd_status.c: _status_add_app_info_list(427) > pid(19962) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-09 13:54:23.793+0900 D/AUL     ( 2878): launch.c: app_request_to_launchpad(425) > launch request result : 19962
05-09 13:54:23.793+0900 E/cluster-home( 2878): mainmenu-custom-box-impl.cpp: OnClicked(202) >  Success to launch [0][org.example.example]
05-09 13:54:23.793+0900 D/test-log( 2878): mainmenu-apps-view-impl.cpp: _OnScrollViewTouched(1592) >  Stop boost timer of Apps view by [1]
05-09 13:54:23.793+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 19962
05-09 13:54:23.793+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-09 13:54:23.793+0900 E/RESOURCED( 2860): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-09 13:54:23.793+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(888) > available memory = 297
05-09 13:54:23.863+0900 D/LAUNCH  (19962): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-09 13:54:23.873+0900 D/APP_CORE(19962): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-09 13:54:23.973+0900 E/VCONF   (19967): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
05-09 13:54:23.973+0900 E/VCONF   (19967): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
05-09 13:54:23.973+0900 E/VCONF   (19967): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
05-09 13:54:23.973+0900 E/VCONF   (19967): vconf.c: vconf_get_str(2891) > vconf_get_str(19967) : db/menu_widget/language error
05-09 13:54:23.973+0900 E/PKGMGR_INFO(19967): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
05-09 13:54:23.973+0900 D/PKGMGR_INFO(19967): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3502) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:54:23.973+0900 D/PKGMGR_INFO(19967): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3508) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='No Locale' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:54:23.973+0900 D/APP_CORE(19962): appcore.c: __aul_handler(587) > [APP 19962]     AUL event: AUL_START
05-09 13:54:23.973+0900 I/APP_CORE(19962): appcore-efl.c: __do_app(496) > [APP 19962] Event: RESET State: CREATED
05-09 13:54:23.973+0900 D/APP_CORE(19962): appcore-efl.c: __do_app(527) > [APP 19962] RESET
05-09 13:54:23.973+0900 D/LAUNCH  (19962): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-09 13:54:23.973+0900 D/APP_CORE(19962): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-09 13:54:23.973+0900 D/APP_CORE(19962): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-09 13:54:23.973+0900 I/CAPI_APPFW_APPLICATION(19962): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-09 13:54:23.973+0900 D/LAUNCH  (19962): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-09 13:54:23.973+0900 D/APP_CORE(19962): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : org.tizen.homescreen
05-09 13:54:23.973+0900 E/EFL     (19962): edje<19962> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:54:23.973+0900 E/EFL     (19962): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:54:23.973+0900 E/EFL     (19962): edje<19962> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:54:23.973+0900 E/EFL     (19962): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:54:23.973+0900 E/EFL     (19962): edje<19962> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:54:23.973+0900 E/EFL     (19962): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:54:23.973+0900 E/EFL     (19962): edje<19962> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:54:23.973+0900 E/EFL     (19962): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:54:23.973+0900 E/EFL     (19962): edje<19962> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-09 13:54:23.973+0900 E/EFL     (19962): By the power of Grayskull, your previous Embryo stack is now broken!
05-09 13:54:23.983+0900 E/E17     ( 2725): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02e00002)
05-09 13:54:24.033+0900 E/E17     ( 2725): e_border.c: e_border_show(2088) > BD_SHOW(0x02e00002)
05-09 13:54:24.043+0900 E/VCONF   (19967): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
05-09 13:54:24.043+0900 E/VCONF   (19967): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
05-09 13:54:24.043+0900 E/VCONF   (19967): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
05-09 13:54:24.043+0900 E/VCONF   (19967): vconf.c: vconf_get_str(2891) > vconf_get_str(19967) : db/menu_widget/language error
05-09 13:54:24.043+0900 E/PKGMGR_INFO(19967): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
05-09 13:54:24.043+0900 D/PKGMGR_INFO(19967): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:54:24.043+0900 D/PKGMGR_INFO(19967): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:54:24.063+0900 W/PROCESSMGR( 2725): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=19962
05-09 13:54:24.073+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 13:54:24.073+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 13:54:24.083+0900 D/APP_CORE(19962): appcore.c: __prt_ltime(236) > [APP 19962] first idle after reset: 418 msec
05-09 13:54:24.103+0900 W/APP_CORE(19962): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2e00002
05-09 13:54:24.103+0900 D/APP_CORE(19962): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2e00002
05-09 13:54:24.103+0900 D/APP_CORE(19962): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-09 13:54:24.103+0900 D/AUL     (19962): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-09 13:54:24.103+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 34
05-09 13:54:24.123+0900 E/VCONF   (19967): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
05-09 13:54:24.123+0900 E/VCONF   (19967): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
05-09 13:54:24.123+0900 E/VCONF   (19967): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
05-09 13:54:24.123+0900 E/VCONF   (19967): vconf.c: vconf_get_str(2891) > vconf_get_str(19967) : db/menu_widget/language error
05-09 13:54:24.123+0900 E/PKGMGR_INFO(19967): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
05-09 13:54:24.123+0900 D/PKGMGR_INFO(19967): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:54:24.123+0900 D/PKGMGR_INFO(19967): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'No Locale') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:54:24.133+0900 D/INDICATOR( 2864): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
05-09 13:54:24.133+0900 D/INDICATOR( 2864): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-09 13:54:24.133+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(838) > __request_handler: 15
05-09 13:54:24.143+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:54:24.143+0900 D/PKGMGR_INFO( 2763): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-09 13:54:24.143+0900 D/AUL_AMD ( 2763): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 19962 is org.example.example
05-09 13:54:24.143+0900 D/AUL_AMD ( 2763): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 19962 : 0
05-09 13:54:24.143+0900 D/INDICATOR( 2864): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-09 13:54:24.143+0900 D/INDICATOR( 2864): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-09 13:54:24.143+0900 D/INDICATOR( 2864): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-09 13:54:24.143+0900 D/INDICATOR( 2864): main.c: _rotate_window(252) > port :: hide more icon
05-09 13:54:24.153+0900 D/AUL     ( 2940): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-09 13:54:24.183+0900 E/VCONF   (19967): vconf.c: _vconf_check_retry_err(1368) > db/menu_widget/language : check retry err (-21/13).
05-09 13:54:24.193+0900 E/VCONF   (19967): vconf.c: _vconf_get_key_filesys(2375) > _vconf_get_key_filesys(db/menu_widget/language) step(-21) failed(13 / Permission denied) retry(0) 
05-09 13:54:24.193+0900 E/VCONF   (19967): vconf.c: _vconf_get_key(2411) > _vconf_get_key(db/menu_widget/language) step(-21) failed(13 / Permission denied)
05-09 13:54:24.193+0900 E/VCONF   (19967): vconf.c: vconf_get_str(2891) > vconf_get_str(19967) : db/menu_widget/language error
05-09 13:54:24.193+0900 E/PKGMGR_INFO(19967): pkgmgrinfo_private.c: __convert_system_locale_to_manifest_locale(354) > syslocale is null
05-09 13:54:24.493+0900 E/E17     ( 2725): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-09 13:54:24.493+0900 D/APP_CORE( 2878): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
05-09 13:54:24.493+0900 D/APP_CORE( 2878): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
05-09 13:54:24.493+0900 D/APP_CORE( 2878): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-09 13:54:24.493+0900 I/APP_CORE( 2878): appcore-efl.c: __do_app(496) > [APP 2878] Event: PAUSE State: RUNNING
05-09 13:54:24.493+0900 D/APP_CORE( 2878): appcore-efl.c: __do_app(565) > [APP 2878] PAUSE
05-09 13:54:24.493+0900 I/CAPI_APPFW_APPLICATION( 2878): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-09 13:54:24.493+0900 E/cluster-home( 2878): homescreen.cpp: OnPause(84) >  app pause
05-09 13:54:24.493+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
05-09 13:54:24.493+0900 D/cluster-view( 2878): homescreen-view-manager.cpp: AppPause(923) >  END
05-09 13:54:24.493+0900 D/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-09 13:54:24.493+0900 E/APP_CORE( 2878): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-09 13:54:24.513+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(2878) status(4)
05-09 13:54:24.513+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(2878) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-09 13:54:24.513+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-09 13:54:24.513+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2878, appid: org.tizen.homescreen, status: bg
05-09 13:54:24.513+0900 D/DATA_PROVIDER_MASTER( 2932): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2878 is paused
05-09 13:54:24.513+0900 D/DATA_PROVIDER_MASTER( 2932): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-09 13:54:24.513+0900 D/APP_CORE(19962): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2e00002 fully_obscured 0
05-09 13:54:24.513+0900 D/APP_CORE(19962): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
05-09 13:54:24.513+0900 D/APP_CORE(19962): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-09 13:54:24.513+0900 I/APP_CORE(19962): appcore-efl.c: __do_app(496) > [APP 19962] Event: RESUME State: CREATED
05-09 13:54:24.513+0900 D/LAUNCH  (19962): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-09 13:54:24.513+0900 D/APP_CORE(19962): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-09 13:54:24.513+0900 D/APP_CORE(19962): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-09 13:54:24.513+0900 D/APP_CORE(19962): appcore-efl.c: __do_app(607) > [APP 19962] RESUME
05-09 13:54:24.523+0900 I/APP_CORE(19962): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-09 13:54:24.523+0900 I/APP_CORE(19962): appcore-efl.c: __do_app(614) > [APP 19962] Initial Launching, call the resume_cb
05-09 13:54:24.523+0900 I/CAPI_APPFW_APPLICATION(19962): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-09 13:54:24.523+0900 D/LAUNCH  (19962): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-09 13:54:24.523+0900 D/LAUNCH  (19962): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-09 13:54:24.523+0900 D/APP_CORE(19962): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-09 13:54:24.523+0900 E/APP_CORE(19962): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-09 13:54:24.533+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __provider_pause_cb(294) > widget obj was paused
05-09 13:54:24.533+0900 I/CAPI_WIDGET_APPLICATION( 3017): widget_app.c: __check_status_for_cgroup(142) > enter background group
05-09 13:54:24.533+0900 W/AUL     ( 3017): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3017, appid: org.tizen.calendar.widget, status: bg
05-09 13:54:24.533+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3017, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
05-09 13:54:24.533+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3017
05-09 13:54:24.533+0900 D/RESOURCED( 2860): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3017, appname = org.tizen.calendar.widget
05-09 13:54:24.533+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3017
05-09 13:54:24.533+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2891) > pid(19962) status(3)
05-09 13:54:24.543+0900 D/AUL_AMD ( 2763): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-09 13:54:24.543+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2897) > back key ungrab
05-09 13:54:24.543+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(19962) status(3)
05-09 13:54:24.543+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(19962) appid(org.example.example) pkgid(org.example.example) status(3)
05-09 13:54:24.543+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-09 13:54:24.543+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 19962, appid: org.example.example, status: fg
05-09 13:54:24.553+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 19962
05-09 13:54:24.553+0900 D/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 19962, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-09 13:54:24.553+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 19962
05-09 13:54:24.613+0900 D/RESOURCED( 2860): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 19962, appname = org.example.example, pkgname = org.example.example
05-09 13:54:24.613+0900 D/RESOURCED( 2860): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 19962, appname = org.example.example
05-09 13:54:24.613+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 19962
05-09 13:54:24.613+0900 I/RESOURCED( 2860): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-09 13:54:24.613+0900 I/RESOURCED( 2860): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-09 13:54:24.623+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2910) > pid(19962) status(0)
05-09 13:54:24.793+0900 D/AUL_PAD ( 2926): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-09 13:54:24.803+0900 D/AUL_PAD (19985): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-09 13:54:24.813+0900 D/AUL_PAD ( 2926): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-09 13:54:24.813+0900 E/RESOURCED( 2860): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1279
05-09 13:54:25.043+0900 D/AUL_AMD ( 2763): amd_status.c: __app_terminate_timer_cb(442) > pid(19726)
05-09 13:54:25.043+0900 W/AUL_AMD ( 2763): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-09 13:54:25.113+0900 D/LAUNCH  (19986): appcore-efl.c: appcore_efl_main(1692) > [crash-popup:Application:main:done]
05-09 13:54:25.113+0900 D/PKGMGR_INFO(19986): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
05-09 13:54:25.113+0900 D/PKGMGR_INFO(19986): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/apps/org.tizen.crash-popup/bin/crash-popup' and package_app_info.app_disable IN ('false','False')
05-09 13:54:25.113+0900 D/AUL     (19986): pkginfo.c: aul_app_get_appid_bypid(241) > [SECURE_LOG] appid for 19986 is org.tizen.crash-popup
05-09 13:54:25.293+0900 D/AUL_AMD ( 2763): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-09 13:54:25.293+0900 D/RUA     ( 2763): rua.c: rua_add_history(179) > rua_add_history start
05-09 13:54:25.303+0900 D/APP_CORE(19986): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-09 13:54:25.303+0900 D/APP_CORE(19986): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
05-09 13:54:25.303+0900 D/APP_CORE(19986): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-09 13:54:25.323+0900 D/RUA     ( 2763): rua.c: rua_add_history(247) > rua_add_history ok
05-09 13:54:25.323+0900 D/APP_CORE(19986): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-09 13:54:25.323+0900 D/APP_CORE(19986): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb76cf520
05-09 13:54:25.323+0900 D/LAUNCH  (19986): appcore-efl.c: __before_loop(1136) > [crash-popup:Platform:appcore_init:done]
05-09 13:54:25.423+0900 D/APP_CORE(19986): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-09 13:54:25.433+0900 D/LAUNCH  (19986): appcore-efl.c: __before_loop(1154) > [crash-popup:Application:create:done]
05-09 13:54:25.443+0900 D/APP_CORE(19986): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-09 13:54:25.843+0900 E/TIZEN_N_SYSTEM_SETTINGS(19962): system_settings.c: system_settings_get_value_string(540) > Enter [system_settings_get_value_string]
05-09 13:54:25.843+0900 E/TIZEN_N_SYSTEM_SETTINGS(19962): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
05-09 13:54:25.843+0900 E/TIZEN_N_SYSTEM_SETTINGS(19962): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
05-09 13:54:25.843+0900 E/TIZEN_N_SYSTEM_SETTINGS(19962): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
05-09 13:54:25.843+0900 D/SYSTEM-SETTINGS(19962): system_setting_platform.c: system_setting_get_locale_timezone(1620) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_timezone. [0m
05-09 13:54:25.843+0900 I/SYSTEM-SETTINGS(19962): system_setting_platform.c: system_setting_get_locale_timezone(1631) > [SECURE_LOG] [0;36mtzpath : Asia/Seoul [0m
05-09 13:54:25.843+0900 D/AUL_PAD (19985): launchpad_loader.c: main(588) > sleeping 1 sec...
05-09 13:54:25.843+0900 D/AUL_PAD (19985): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-09 13:54:25.853+0900 D/AUL_PAD (19985): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8fa8760
05-09 13:54:25.853+0900 D/AUL_PAD (19985): preload.h: __preload_init(69) > get pre-initialization function
05-09 13:54:25.853+0900 D/AUL_PAD (19985): preload.h: __preload_init(73) > get shutdown function
05-09 13:54:25.853+0900 D/AUL_PAD (19985): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8fa8a40
05-09 13:54:25.853+0900 D/AUL_PAD (19985): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8faa640
05-09 13:54:25.853+0900 D/AUL_PAD (19985): preload.h: __preload_init(69) > get pre-initialization function
05-09 13:54:25.853+0900 D/AUL_PAD (19985): preload.h: __preload_init(73) > get shutdown function
05-09 13:54:25.853+0900 D/AUL_PAD (19985): preexec.h: __preexec_init(76) > preexec start
05-09 13:54:25.853+0900 D/AUL_PAD (19985): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-09 13:54:25.853+0900 D/AUL     (19985): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-09 13:54:25.853+0900 D/AUL     (19985): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-09 13:54:25.853+0900 D/AUL     (19985): process_pool.c: __connect_to_launchpad(132) > send(19985) : 4
05-09 13:54:25.853+0900 D/AUL     (19985): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-09 13:54:25.853+0900 D/AUL_PAD ( 2926): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 19985
05-09 13:54:25.883+0900 E/RESOURCED( 2860): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1283
05-09 13:54:25.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-09 13:54:25.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-09 13:54:25.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-09 13:54:25.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-09 13:54:25.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-09 13:54:25.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-09 13:54:25.893+0900 D/AUL_PAD ( 2926): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-09 13:54:25.893+0900 I/AUL_PAD ( 2926): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 19962 pgid = 19962
05-09 13:54:25.893+0900 I/AUL_PAD ( 2926): sigchild.h: __sigchild_action(142) > dead_pid(19962)
05-09 13:54:25.893+0900 E/EFL     ( 2725): eo<2725> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-09 13:54:25.923+0900 D/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2891) > pid(2878) status(3)
05-09 13:54:25.923+0900 D/AUL_AMD ( 2763): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-09 13:54:25.923+0900 W/AUL_AMD ( 2763): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-09 13:54:25.923+0900 W/AUL_AMD ( 2763): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-09 13:54:25.923+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(456) > pid(2878) status(3)
05-09 13:54:25.923+0900 D/AUL_AMD ( 2763): amd_status.c: _status_update_app_info_list(468) > pid(2878) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(3)
05-09 13:54:25.923+0900 D/AUL     ( 2763): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.tizen.homescreen
05-09 13:54:25.923+0900 W/AUL     ( 2763): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2878, appid: org.tizen.homescreen, status: fg
05-09 13:54:25.933+0900 D/RESOURCED( 2860): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2878
05-09 13:54:25.933+0900 D/RESOURCED( 2860): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2878, appname = org.tizen.homescreen, pkgname = org.tizen.homescreen
05-09 13:54:25.933+0900 D/RESOURCED( 2860): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2878, appname = org.tizen.homescreen
05-09 13:54:25.933+0900 D/RESOURCED( 2860): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2878
05-09 13:54:25.933+0900 W/CRASH_MANAGER(19967): worker.c: worker_job(1204) > 1119962657861149430566
