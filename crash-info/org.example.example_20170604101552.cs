S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 6257
Date: 2017-06-04 10:15:52+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x100

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb775af84
ebp = 0xbff3f5c8, esp = 0xbff3f088
eax = 0x00000100, ebx = 0xb6dde000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6ca8a13

Memory Information
MemTotal:      123 KB
MemFree:        28 KB
Buffers:         7 KB
Cached:     168460 KB
VmPeak:     124264 KB
VmSize:     119204 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36072 KB
VmRSS:       31040 KB
VmData:      49292 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 6257 TID = 6257
6257 6258 6418 6419 6428 

Maps Information
b0bb1000 b0bb8000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1501000 b1519000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1805000 b180c000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b187b000 b187f000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b54000 b2b5e000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b64000 b2b70000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b71000 b2b92000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b97000 b2b98000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b99000 b2b9e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b9f000 b2ba0000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2ba1000 b2ba3000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2ba4000 b2ba6000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2ba7000 b2bb3000 r-xp /usr/lib/libdrm.so.2.4.0
b2bb4000 b2bb7000 r-xp /usr/lib/libdri2.so.0.0.0
b2bb8000 b2bc2000 r-xp /usr/lib/libtbm.so.1.0.0
b2bc3000 b2bd8000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bd9000 b2beb000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33ed000 b341e000 r-xp /usr/lib/libidn.so.11.5.44
b341f000 b3441000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3442000 b3452000 r-xp /usr/lib/libcares.so.2.1.0
b3453000 b345c000 r-xp /usr/lib/libeventsystem.so.0.0.1
b345d000 b3466000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3467000 b34de000 r-xp /usr/lib/libcurl.so.4.3.0
b34e0000 b34f2000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34f3000 b3514000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b351b000 b351c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b351d000 b351e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b351f000 b3522000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3523000 b3526000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b362e000 b3634000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3635000 b3779000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b378a000 b378b000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b378c000 b3799000 r-xp /opt/usr/apps/org.example.example/bin/example
b379b000 b37d4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41d7000 b41e2000 r-xp /lib/libnss_files-2.20-2014.11.so
b41e4000 b41ef000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41f1000 b4208000 r-xp /lib/libnsl-2.20-2014.11.so
b420c000 b4214000 r-xp /lib/libnss_compat-2.20-2014.11.so
b4216000 b423a000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b423b000 b423c000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b423d000 b4240000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4241000 b4248000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4249000 b4253000 r-xp /usr/lib/libsensord-share.so
b4254000 b4270000 r-xp /usr/lib/libsensor.so.1.2.0
b4272000 b427b000 r-xp /usr/lib/libappcore-common.so.1.1
b427e000 b4280000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4295000 b4297000 r-xp /usr/lib/libXau.so.6.0.0
b4298000 b42ba000 r-xp /usr/lib/libxcb.so.1.1.0
b42bc000 b42c5000 r-xp /lib/libcrypt-2.20-2014.11.so
b42ee000 b42f0000 r-xp /usr/lib/libiri.so
b42f1000 b4317000 r-xp /lib/libexpat.so.1.5.2
b4319000 b4384000 r-xp /usr/lib/libssl.so.1.0.0
b438a000 b4396000 r-xp /usr/lib/libethumb.so.1.13.0
b4397000 b439b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b439c000 b45ed000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b68000 b5b78000 r-xp /usr/lib/libXi.so.6.1.0
b5b79000 b5b7b000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b7c000 b5b82000 r-xp /usr/lib/libXtst.so.6.1.0
b5b83000 b5b8d000 r-xp /usr/lib/libXrender.so.1.3.0
b5b8e000 b5b97000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b99000 b5b9b000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b9c000 b5ba1000 r-xp /usr/lib/libXfixes.so.3.1.0
b5ba2000 b5bb4000 r-xp /usr/lib/libXext.so.6.4.0
b5bb5000 b5bb7000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bb8000 b5bba000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bbc000 b5cfe000 r-xp /usr/lib/libX11.so.6.3.0
b5d02000 b5d0c000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d0d000 b5d23000 r-xp /usr/lib/libudev.so.1.6.0
b5d26000 b5d2a000 r-xp /lib/libattr.so.1.1.0
b5d2b000 b5d5a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d5c000 b5d62000 r-xp /usr/lib/libffi.so.6.0.2
b5d63000 b5d86000 r-xp /lib/libz.so.1.2.8
b5d87000 b5d8a000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d8b000 b5ee7000 r-xp /usr/lib/libxml2.so.2.9.2
b5eed000 b5fd4000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fe1000 b5fe4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fe5000 b6007000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6008000 b601c000 r-xp /lib/libresolv-2.20-2014.11.so
b6020000 b6044000 r-xp /usr/lib/liblzma.so.5.0.3
b6045000 b6047000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6049000 b6053000 r-xp /usr/lib/libembryo.so.1.13.0
b6054000 b607d000 r-xp /usr/lib/libpng12.so.0.50.0
b607e000 b60c7000 r-xp /usr/lib/libjpeg.so.8.0.2
b60d8000 b60df000 r-xp /lib/librt-2.20-2014.11.so
b60e1000 b6100000 r-xp /usr/lib/libector.so.1.13.0
b6103000 b6130000 r-xp /usr/lib/liblua-5.1.so
b6131000 b61c1000 r-xp /usr/lib/libfreetype.so.6.11.3
b61c5000 b6203000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6204000 b621a000 r-xp /usr/lib/libfribidi.so.0.3.1
b621b000 b6274000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6277000 b62c2000 r-xp /lib/libm-2.20-2014.11.so
b62c4000 b62d6000 r-xp /usr/lib/libeio.so.1.13.0
b62d7000 b62da000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62db000 b62e1000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62e2000 b6305000 r-xp /usr/lib/libefreet.so.1.13.0
b6308000 b6333000 r-xp /usr/lib/libeldbus.so.1.13.0
b6334000 b6368000 r-xp /usr/lib/libecore_con.so.1.13.0
b636a000 b6373000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6374000 b637d000 r-xp /usr/lib/libethumb_client.so.1.13.0
b637e000 b6391000 r-xp /usr/lib/libeo.so.1.13.0
b6393000 b63a6000 r-xp /usr/lib/libecore_input.so.1.13.0
b63a7000 b63ae000 r-xp /usr/lib/libecore_file.so.1.13.0
b63af000 b63d2000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63d3000 b63ff000 r-xp /usr/lib/libeet.so.1.13.0
b6408000 b6473000 r-xp /usr/lib/libeina.so.1.13.0
b6476000 b648d000 r-xp /usr/lib/libefl.so.1.13.0
b648f000 b65f6000 r-xp /usr/lib/libicuuc.so.51.1
b6604000 b6810000 r-xp /usr/lib/libicui18n.so.51.1
b6818000 b6867000 r-xp /usr/lib/libecore_x.so.1.13.0
b6869000 b6883000 r-xp /lib/libgcc_s-4.9.so.1
b6885000 b6889000 r-xp /lib/libcap.so.2.21
b688a000 b68d0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68d1000 b68d8000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68da000 b692c000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b692e000 b6ab9000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6abe000 b6b8c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b8f000 b6b93000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b94000 b6ba3000 r-xp /usr/lib/libvconf.so.0.2.45
b6ba4000 b6ba7000 r-xp /usr/lib/libvasum.so.0.3.1
b6ba8000 b6bab000 r-xp /usr/lib/libttrace.so.1.1
b6bad000 b6bb1000 r-xp /usr/lib/libiniparser.so.0
b6bb2000 b6be2000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6be3000 b6bec000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bed000 b6c12000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c13000 b6c23000 r-xp /usr/lib/libunwind.so.8.0.1
b6c2d000 b6ddb000 r-xp /lib/libc-2.20-2014.11.so
b6de3000 b6f26000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f28000 b6f80000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f81000 b6fb5000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fb8000 b708c000 r-xp /usr/lib/libedje.so.1.13.0
b708f000 b70bb000 r-xp /usr/lib/libecore.so.1.13.0
b70cc000 b72f2000 r-xp /usr/lib/libevas.so.1.13.0
b731a000 b7332000 r-xp /lib/libpthread-2.20-2014.11.so
b7336000 b76b0000 r-xp /usr/lib/libelementary.so.1.13.0
b76d0000 b76d4000 r-xp /usr/lib/libsmack.so.1.0.0
b76d5000 b76de000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76df000 b76e2000 r-xp /usr/lib/libdlog.so.0.0.0
b76e3000 b76e8000 r-xp /usr/lib/libbundle.so.0.1.22
b76e9000 b76ec000 r-xp /lib/libdl-2.20-2014.11.so
b76ee000 b7713000 r-xp /usr/lib/libaul.so.0.1.0
b7716000 b7718000 r-xp /usr/lib/libappsvc.so.0.1.0
b7719000 b771e000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b771f000 b7726000 r-xp /usr/lib/libappcore-efl.so.1.1
b7728000 b772d000 r-xp /usr/lib/libsys-assert.so
b7730000 b7731000 r-xp [vdso]
b7731000 b7753000 r-xp /lib/ld-2.20-2014.11.so
b7755000 b775d000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:6257)
Call Stack Count: 25
 0: strchrnul + 0x63 (0xb6ca8a13) [/lib/libc.so.6] + 0x7ba13
 1: vsprintf + 0x69 (0xb6c90889) [/lib/libc.so.6] + 0x63889
 2: db_read_cb + 0x1ce (0xb3791c0e) [/opt/usr/apps/org.example.example/bin/example] + 0x5c0e
 3: sqlite3_exec + 0x27b (0xb6b3d04b) [/usr/lib/libsqlite3.so.0] + 0x7f04b
 4: read_db + 0xa3 (0xb3791a23) [/opt/usr/apps/org.example.example/bin/example] + 0x5a23
 5: init_db + 0x16f (0xb379150f) [/opt/usr/apps/org.example.example/bin/example] + 0x550f
 6: create_button_view + 0x411 (0xb3791211) [/opt/usr/apps/org.example.example/bin/example] + 0x5211
 7: feeding_view_cb + 0x64 (0xb3790d24) [/opt/usr/apps/org.example.example/bin/example] + 0x4d24
 8: (0xb7100449) [/usr/lib/libevas.so.1] + 0x34449
 9: (0xb638c319) [/usr/lib/libeo.so.1] + 0xe319
10: eo_event_callback_call + 0xb3 (0xb6389d63) [/usr/lib/libeo.so.1] + 0xbd63
11: (0xb7100a62) [/usr/lib/libevas.so.1] + 0x34a62
12: (0xb710f441) [/usr/lib/libevas.so.1] + 0x43441
13: evas_canvas_event_feed_mouse_down + 0xcf (0xb711920f) [/usr/lib/libevas.so.1] + 0x4d20f
14: evas_event_feed_mouse_down + 0x6a (0xb711fc2a) [/usr/lib/libevas.so.1] + 0x53c2a
15: (0xb439949c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
16: (0xb709c055) [/usr/lib/libecore.so.1] + 0xd055
17: (0xb70a51b9) [/usr/lib/libecore.so.1] + 0x161b9
18: ecore_main_loop_begin + 0x57 (0xb70a5587) [/usr/lib/libecore.so.1] + 0x16587
19: elm_run + 0x2d (0xb74fe22d) [/usr/lib/libelementary.so.1] + 0x1c822d
20: appcore_efl_main + 0x4de (0xb7722dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
21: ui_app_main + 0x140 (0xb771bc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
22: main + 0x296 (0xb3794906) [/opt/usr/apps/org.example.example/bin/example] + 0x8906
23: (0xb7757148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7757148
24: __libc_start_main + 0xde (0xb6c44e4e) [/lib/libc.so.6] + 0x17e4e
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
atted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496538945) formatted(10:15)
06-04 10:15:45.519+0900 D/LOCKSCREEN( 6243): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496538945) formatted(AM)
06-04 10:15:45.519+0900 E/EFL     ( 6243): eo<6243> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800142a2 is not pointing to a valid object. Maybe it has already been freed.
06-04 10:15:45.519+0900 E/EFL     ( 6243): eo<6243> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x800142a2) is an invalid ref.
06-04 10:15:45.519+0900 D/INDICATOR( 2838): battery.c: indicator_battery_update_display(606) > indicator_battery_update_display[606]	 "Battery Capacity: 50"
06-04 10:15:45.519+0900 E/EFL     ( 6243): <6243> lib/ecore/ecore_timer.c:432 _ecore_timer_del() safety check failed: timer == NULL
06-04 10:15:45.519+0900 D/INDICATOR( 2838): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.battery.percentage.two.digits.show"
06-04 10:15:45.519+0900 D/INDICATOR( 2838): battery.c: hide_digits(487) > hide_digits[487]	 "Hide digits"
06-04 10:15:45.519+0900 E/INDICATOR( 2838): list.c: list_try_to_find_icon_to_remove(335) > (!icon) -> list_try_to_find_icon_to_remove() return
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_enabled_system_count(654) > Noti count : 0 , MiniCtrl count : 0
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_enabled_system_count(654) > Noti count : 0 , MiniCtrl count : 0
06-04 10:15:45.519+0900 E/INDICATOR( 2838): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_minictrl_list(693) > Noti count : 0, System count : 0, Minictrl count : 3
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_minictrl_list(693) > Noti count : 0, System count : 0, Minictrl count : 3
06-04 10:15:45.519+0900 E/INDICATOR( 2838): list.c: list_try_to_find_icon_to_show(269) > default
06-04 10:15:45.519+0900 E/INDICATOR( 2838): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
06-04 10:15:45.519+0900 E/INDICATOR( 2838): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
06-04 10:15:45.519+0900 D/INDICATOR( 2838): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.hide"
06-04 10:15:45.519+0900 D/INDICATOR( 2838): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
06-04 10:15:45.519+0900 D/INDICATOR( 2838): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.hide"
06-04 10:15:45.519+0900 E/INDICATOR( 2838): box.c: _update_icon(172) > (!list) -> _update_icon() return
06-04 10:15:45.519+0900 E/INDICATOR( 2838): box.c: _update_icon(172) > (!list) -> _update_icon() return
06-04 10:15:45.519+0900 E/INDICATOR( 2838): box.c: _update_icon(172) > (!list) -> _update_icon() return
06-04 10:15:45.519+0900 E/INDICATOR( 2838): box.c: _update_icon(172) > (!list) -> _update_icon() return
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 10:15:45.519+0900 D/INDICATOR( 2838): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 10:15:45.519+0900 D/INDICATOR( 2838): icon.c: _hide_more_noti(779) > port :: hide more icon
06-04 10:15:45.519+0900 E/INDICATOR( 2838): rssi.c: wake_up_cb(162) > (!s_info.updated_while_lcd_off) -> wake_up_cb() return
06-04 10:15:45.529+0900 D/ALARM_MANAGER( 2826): alarm-lib.c: alarmmgr_enum_alarm_ids(1382) > [SECURE_LOG] alarm_manager_call_alarm_get_number_of_ids_sync() is called
06-04 10:15:45.529+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3042) > before getting actual pid[2826]
06-04 10:15:45.529+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3044) > after getting actual pid[2826]
06-04 10:15:45.539+0900 E/ALARM_MANAGER( 2777): alarm-manager.c: _get_zone_name(573) > zone name [/]
06-04 10:15:45.539+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: __check_privilege_by_cookie(1966) > uid : 200
06-04 10:15:45.539+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: __check_privilege_by_cookie(1982) > The process(2826) was authenticated successfully.
06-04 10:15:45.539+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(838) > __request_handler: 37
06-04 10:15:45.539+0900 E/AUL_AMD ( 2744): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
06-04 10:15:45.539+0900 E/AUL_AMD ( 2744): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
06-04 10:15:45.539+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2826 : 0
06-04 10:15:45.539+0900 D/AUL     ( 2777): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
06-04 10:15:45.539+0900 D/AUL     ( 2777): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
06-04 10:15:45.539+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: __zone_get_appid_bypid(387) > cmdline(/usr/bin/starter)
06-04 10:15:45.539+0900 D/PKGMGR_INFO( 2777): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
06-04 10:15:45.539+0900 D/PKGMGR_INFO( 2777): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
06-04 10:15:45.539+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(838) > __request_handler: 37
06-04 10:15:45.539+0900 E/AUL_AMD ( 2744): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
06-04 10:15:45.539+0900 E/AUL_AMD ( 2744): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
06-04 10:15:45.539+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2826 : 0
06-04 10:15:45.539+0900 D/AUL     ( 2777): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
06-04 10:15:45.539+0900 D/AUL     ( 2777): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
06-04 10:15:45.539+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: __get_caller_unique_name(2015) > [SECURE_LOG] unique_name= /usr/bin/starter
06-04 10:15:45.539+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3065) > [SECURE_LOG] Called by process (pid:2826, unique_name:/usr/bin/starter)
06-04 10:15:45.539+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3073) > [SECURE_LOG] app_name=/usr/bin/starter, quark_app_unique_name=context-service
06-04 10:15:45.539+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3082) > [SECURE_LOG] number of alarms of the process (pid:2826, unique_name:/usr/bin/starter) is 0.
06-04 10:15:45.549+0900 D/ALARM_MANAGER( 2826): alarm-lib.c: alarmmgr_enum_alarm_ids(1401) > maxnum_of_ids[0]
06-04 10:15:45.549+0900 D/ALARM_MANAGER( 2826): alarm-lib.c: alarmmgr_enum_alarm_ids(1404) > [SECURE_LOG] alarm_manager_call_alarm_get_list_of_ids_sync() is called
06-04 10:15:45.549+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3104) > before getting actual pid[2826]
06-04 10:15:45.549+0900 D/ALARM_MANAGER( 2777): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3106) > after getting actual pid[2826]
06-04 10:15:45.549+0900 E/ALARM_MANAGER( 2777): alarm-manager.c: _get_zone_name(573) > zone name [/]
06-04 10:15:45.549+0900 E/ALARM_MANAGER( 2777): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3115) > [SECURE_LOG] called for pid(2826), but max_number_of_ids(0) is less than 0.
06-04 10:15:45.549+0900 D/ALARM_MANAGER( 2826): alarm-lib.c: alarmmgr_enum_alarm_ids(1435) > [SECURE_LOG] Leave
06-04 10:15:45.599+0900 D/eventsystem( 2682): eventsystem.c: eventsystem_send_system_event(1011) > event_name(tizen.system.event.display_state)
06-04 10:15:45.599+0900 D/eventsystem( 2682): eventsystem.c: __get_member_name_from_eventname(259) > member_name(display_state)
06-04 10:15:45.599+0900 D/eventsystem( 2682): eventsystem.c: __eventsystem_send_event(851) > interface_name(tizen.system.event)
06-04 10:15:45.599+0900 D/eventsystem( 2682): eventsystem.c: __eventsystem_send_event(852) > object_path(/tizen/system/event)
06-04 10:15:45.599+0900 D/eventsystem( 2682): eventsystem.c: __eventsystem_send_event(853) > member_name(display_state)
06-04 10:15:45.599+0900 D/DATA_PROVIDER_MASTER( 2905): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 10:15:45.599+0900 D/INDICATOR( 2838): main.c: _indicator_notify_pm_state_cb(169) > LCD is on
06-04 10:15:45.629+0900 D/APP_CORE( 6257): appcore-rotation.c: __changed_cb(121) > [APP 6257] Rotation: 0 -> 1
06-04 10:15:45.629+0900 D/APP_CORE( 6257): appcore-rotation.c: __changed_cb(124) > [APP 6257] Rotation: 0 -> 1
06-04 10:15:45.629+0900 I/CAPI_APPFW_APPLICATION( 6257): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
06-04 10:15:45.629+0900 D/APP_CORE( 2852): appcore-rotation.c: __changed_cb(121) > [APP 2852] Rotation: 1 -> 1
06-04 10:15:45.709+0900 D/STARTER ( 2826): hw_key.c: _key_release_cb(206) > [_key_release_cb:206] _key_release_cb : XF86PowerOff Released
06-04 10:15:45.709+0900 D/STARTER ( 2826): hw_key.c: _key_release_cb(233) > [_key_release_cb:233] phone lock state, ignore home key.
06-04 10:15:45.749+0900 D/AUL_PAD ( 6421): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 10:15:45.749+0900 D/AUL_PAD ( 6421): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 10:15:45.749+0900 D/AUL_PAD ( 6421): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b936c760
06-04 10:15:45.749+0900 D/AUL_PAD ( 6421): preload.h: __preload_init(69) > get pre-initialization function
06-04 10:15:45.749+0900 D/AUL_PAD ( 6421): preload.h: __preload_init(73) > get shutdown function
06-04 10:15:45.749+0900 D/AUL_PAD ( 6421): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b936ca40
06-04 10:15:45.759+0900 D/AUL_PAD ( 6421): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b936e640
06-04 10:15:45.759+0900 D/AUL_PAD ( 6421): preload.h: __preload_init(69) > get pre-initialization function
06-04 10:15:45.759+0900 D/AUL_PAD ( 6421): preload.h: __preload_init(73) > get shutdown function
06-04 10:15:45.759+0900 D/AUL_PAD ( 6421): preexec.h: __preexec_init(76) > preexec start
06-04 10:15:45.759+0900 D/AUL_PAD ( 6421): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 10:15:45.759+0900 D/AUL     ( 6421): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 10:15:45.759+0900 D/AUL     ( 6421): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 10:15:45.759+0900 D/AUL     ( 6421): process_pool.c: __connect_to_launchpad(132) > send(6421) : 4
06-04 10:15:45.759+0900 D/AUL     ( 6421): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 10:15:45.759+0900 D/AUL_PAD ( 2903): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 6421
06-04 10:15:45.759+0900 E/RESOURCED( 2829): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.481
06-04 10:15:45.819+0900 D/STARTER ( 2826): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb7d29ce0), lock_pid(6243)
06-04 10:15:45.819+0900 E/STARTER ( 2826): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
06-04 10:15:45.829+0900 D/AUL_PAD ( 6421): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 10:15:45.829+0900 D/AUL_PAD ( 6421): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 10:15:45.829+0900 D/AUL_PAD ( 6421): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 10:15:45.829+0900 D/AUL_PAD ( 6421): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 10:15:46.129+0900 D/LOCKSCREEN( 6243): lockscreen.c: lockscreen_lcd_off_count_raise(133) > [lockscreen_lcd_off_count_raise:133:D] count for lcd off timer : 0
06-04 10:15:46.129+0900 D/LOCKSCREEN( 6243): default_lock.c: _default_lock_mouse_down_cb(115) > [_default_lock_mouse_down_cb:115:D] clicked x(275), y(893)
06-04 10:15:46.129+0900 D/LOCKSCREEN( 6243): default_lock.c: _default_lock_mouse_down_cb(125) > [_default_lock_mouse_down_cb:125:D] touch upper y : 38
06-04 10:15:46.129+0900 D/LOCKSCREEN( 6243): default_lock.c: _default_lock_mouse_down_cb(137) > [_default_lock_mouse_down_cb:137:D] camera icon : x(559), y(1119), w(124), h(124)
06-04 10:15:46.189+0900 D/LOCKSCREEN( 6243): default_lock.c: _default_lock_mouse_up_cb(211) > [_default_lock_mouse_up_cb:211:D] cancel unlock
06-04 10:15:46.309+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x401311 
06-04 10:15:46.439+0900 D/LOCKSCREEN( 6243): lockscreen.c: lockscreen_lcd_off_count_raise(133) > [lockscreen_lcd_off_count_raise:133:D] count for lcd off timer : 1
06-04 10:15:46.439+0900 D/LOCKSCREEN( 6243): default_lock.c: _default_lock_mouse_down_cb(115) > [_default_lock_mouse_down_cb:115:D] clicked x(269), y(985)
06-04 10:15:46.439+0900 D/LOCKSCREEN( 6243): default_lock.c: _default_lock_mouse_down_cb(125) > [_default_lock_mouse_down_cb:125:D] touch upper y : 38
06-04 10:15:46.439+0900 D/LOCKSCREEN( 6243): default_lock.c: _default_lock_mouse_down_cb(137) > [_default_lock_mouse_down_cb:137:D] camera icon : x(559), y(1119), w(124), h(124)
06-04 10:15:46.569+0900 D/LOCKSCREEN( 6243): default_lock.c: _default_lock_mouse_up_cb(214) > [_default_lock_mouse_up_cb:214:D] exit lockscreen
06-04 10:15:46.639+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x401311 
06-04 10:15:47.089+0900 D/LOCKSCREEN( 6243): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 10:15:47.089+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 10:15:47.089+0900 D/LOCKSCREEN( 6243): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 10:15:47.089+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 10:15:47.089+0900 D/LOCKSCREEN( 6243): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 10:15:47.089+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 10:15:47.089+0900 D/LOCKSCREEN( 6243): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 10:15:47.089+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 10:15:47.089+0900 D/LOCKSCREEN( 6243): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 10:15:47.089+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 10:15:47.089+0900 D/LOCKSCREEN( 6243): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 10:15:47.089+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 10:15:47.089+0900 D/LOCKSCREEN( 6243): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 10:15:47.089+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 10:15:47.089+0900 D/LOCKSCREEN( 6243): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 10:15:47.089+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 10:15:47.089+0900 D/AUL     ( 6243): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 10:15:47.089+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 10:15:47.089+0900 W/AUL_AMD ( 2744): amd_request.c: __request_handler(1056) > app status : 5
06-04 10:15:47.089+0900 D/AUL_AMD ( 2744): amd_status.c: _status_update_app_info_list(456) > pid(6243) status(5)
06-04 10:15:47.089+0900 D/AUL_AMD ( 2744): amd_status.c: _status_update_app_info_list(468) > pid(6243) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
06-04 10:15:47.089+0900 D/AUL     ( 2744): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
06-04 10:15:47.089+0900 W/AUL     ( 2744): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6243, appid: org.tizen.lockscreen, status: bg
06-04 10:15:47.099+0900 D/APP_CORE( 6243): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-04 10:15:47.099+0900 I/CAPI_APPFW_APPLICATION( 6243): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
06-04 10:15:47.099+0900 D/LOCKSCREEN( 6243): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
06-04 10:15:47.099+0900 D/RESOURCED( 2829): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 6243, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
06-04 10:15:47.099+0900 D/RESOURCED( 2829): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 6243, appname = org.tizen.lockscreen
06-04 10:15:47.099+0900 D/RESOURCED( 2829): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 6243
06-04 10:15:47.099+0900 D/RESOURCED( 2829): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2845 increase lru 4
06-04 10:15:47.099+0900 D/RESOURCED( 2829): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2845 set score 390 (before 360)
06-04 10:15:47.099+0900 D/RESOURCED( 2829): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
06-04 10:15:47.099+0900 D/RESOURCED( 2829): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6243, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
06-04 10:15:47.099+0900 D/RESOURCED( 2829): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 6243
06-04 10:15:47.099+0900 D/COM_CORE( 6243): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(41) for pid(-1)
06-04 10:15:47.099+0900 D/COM_CORE( 6243): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
06-04 10:15:47.099+0900 D/COM_CORE( 6243): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
06-04 10:15:47.099+0900 D/COM_CORE( 2905): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-04 10:15:47.099+0900 D/DATA_PROVIDER_MASTER( 2905): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb2100618 is terminated
06-04 10:15:47.099+0900 D/DATA_PROVIDER_MASTER( 2905): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-04 10:15:47.159+0900 E/COM_CORE( 6243): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
06-04 10:15:47.159+0900 E/LOCKSCREEN( 6243): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
06-04 10:15:47.159+0900 E/LOCKSCREEN( 6243): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
06-04 10:15:47.159+0900 D/LOCKSCREEN( 6243): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
06-04 10:15:47.159+0900 D/CALL_MGR_CLIENT( 6243): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
06-04 10:15:47.159+0900 D/CALL_MGR_CLIENT( 6243): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
06-04 10:15:47.159+0900 W/CALL_MGR_CLIENT( 6243): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
06-04 10:15:47.159+0900 D/CALL_MGR_CLIENT( 6243): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
06-04 10:15:47.159+0900 D/CALL_MGR_CLIENT( 6243): <LIB:cm_deinit:444> cm_deinit
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
06-04 10:15:47.159+0900 D/SYSTEM-SETTINGS( 6243): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
06-04 10:15:47.159+0900 D/SYSTEM-SETTINGS( 6243): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
06-04 10:15:47.159+0900 D/SYSTEM-SETTINGS( 6243): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
06-04 10:15:47.159+0900 D/LOCKSCREEN( 6243): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
06-04 10:15:47.159+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
06-04 10:15:47.159+0900 D/SYSTEM-SETTINGS( 6243): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
06-04 10:15:47.169+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 10:15:47.169+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
06-04 10:15:47.169+0900 E/TIZEN_N_SYSTEM_SETTINGS( 6243): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
06-04 10:15:47.169+0900 D/SYSTEM-SETTINGS( 6243): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
06-04 10:15:47.169+0900 D/LOCKSCREEN( 6243): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
06-04 10:15:47.169+0900 E/EFL     ( 6243): eo<6243> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
06-04 10:15:47.169+0900 E/EFL     ( 6243): eo<6243> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
06-04 10:15:47.259+0900 E/E17     ( 2764): e_border.c: e_border_hide(2248) > BD_HIDE(0x01200007), visible:1
06-04 10:15:47.259+0900 E/EFL     ( 2764): eo<2764> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 10:15:47.259+0900 E/E17_TZSH( 2764): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b39e05c0, role:118
06-04 10:15:47.259+0900 W/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=6257
06-04 10:15:47.259+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
06-04 10:15:47.269+0900 D/INDICATOR( 2838): main.c: _property_changed_cb(432) > UNSNIFF API 1200007
06-04 10:15:47.269+0900 D/INDICATOR( 2838): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 10:15:47.269+0900 D/INDICATOR( 2838): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 10:15:47.269+0900 D/INDICATOR( 2838): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 10:15:47.269+0900 D/INDICATOR( 2838): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 10:15:47.269+0900 D/INDICATOR( 2838): main.c: _rotate_window(252) > port :: hide more icon
06-04 10:15:47.279+0900 E/EFL     ( 2764): eo<2764> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 10:15:47.279+0900 I/TZSH    ( 2916): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
06-04 10:15:47.279+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 10:15:47.279+0900 D/PKGMGR_INFO( 2744): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 10:15:47.279+0900 D/PKGMGR_INFO( 2744): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 10:15:47.289+0900 D/AUL_AMD ( 2744): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 6257 is org.example.example
06-04 10:15:47.289+0900 D/AUL_AMD ( 2744): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 6257 : 0
06-04 10:15:47.289+0900 D/AUL     ( 2925): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 10:15:47.289+0900 D/APP_CORE( 6257): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
06-04 10:15:47.289+0900 D/APP_CORE( 6257): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
06-04 10:15:47.289+0900 D/APP_CORE( 6257): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 10:15:47.289+0900 I/APP_CORE( 6257): appcore-efl.c: __do_app(496) > [APP 6257] Event: RESUME State: CREATED
06-04 10:15:47.289+0900 D/LAUNCH  ( 6257): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 10:15:47.289+0900 D/APP_CORE( 6257): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 10:15:47.289+0900 D/APP_CORE( 6257): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 10:15:47.289+0900 D/APP_CORE( 6257): appcore-efl.c: __do_app(607) > [APP 6257] RESUME
06-04 10:15:47.289+0900 D/AUL_AMD ( 2744): amd_launch.c: __e17_status_handler(2891) > pid(6257) status(3)
06-04 10:15:47.289+0900 D/AUL_AMD ( 2744): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 10:15:47.289+0900 I/APP_CORE( 6257): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 10:15:47.289+0900 I/APP_CORE( 6257): appcore-efl.c: __do_app(614) > [APP 6257] Initial Launching, call the resume_cb
06-04 10:15:47.289+0900 I/CAPI_APPFW_APPLICATION( 6257): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 10:15:47.289+0900 D/LAUNCH  ( 6257): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 10:15:47.289+0900 D/LAUNCH  ( 6257): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 10:15:47.289+0900 D/APP_CORE( 6257): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 10:15:47.289+0900 E/APP_CORE( 6257): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 10:15:47.289+0900 W/AUL_AMD ( 2744): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 10:15:47.289+0900 W/AUL_AMD ( 2744): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 10:15:47.289+0900 D/AUL_AMD ( 2744): amd_status.c: _status_update_app_info_list(456) > pid(6257) status(3)
06-04 10:15:47.289+0900 D/AUL_AMD ( 2744): amd_status.c: _status_update_app_info_list(468) > pid(6257) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 10:15:47.289+0900 D/AUL     ( 2744): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 10:15:47.289+0900 W/AUL     ( 2744): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 6257, appid: org.example.example, status: fg
06-04 10:15:47.289+0900 D/RESOURCED( 2829): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 6257
06-04 10:15:47.289+0900 D/RESOURCED( 2829): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 6257, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 10:15:47.289+0900 D/RESOURCED( 2829): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 6257
06-04 10:15:47.329+0900 D/RESOURCED( 2829): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 6257, appname = org.example.example, pkgname = org.example.example
06-04 10:15:47.329+0900 D/RESOURCED( 2829): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 6257, appname = org.example.example
06-04 10:15:47.329+0900 D/RESOURCED( 2829): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 6257
06-04 10:15:47.329+0900 I/RESOURCED( 2829): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 10:15:47.329+0900 I/RESOURCED( 2829): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 10:15:47.339+0900 D/AUL_PAD ( 2903): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 10:15:47.339+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 10:15:47.339+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 10:15:47.339+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 10:15:47.339+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 10:15:47.339+0900 D/AUL_PAD ( 2903): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 10:15:47.339+0900 D/AUL_PAD ( 2903): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 10:15:47.339+0900 I/AUL_PAD ( 2903): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 6243 pgid = 6243
06-04 10:15:47.339+0900 I/AUL_PAD ( 2903): sigchild.h: __sigchild_action(142) > dead_pid(6243)
06-04 10:15:47.349+0900 D/AUL_PAD ( 2903): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-04 10:15:47.349+0900 I/AUL_PAD ( 2903): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-04 10:15:47.349+0900 I/AUL_PAD ( 2903): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-04 10:15:47.349+0900 E/AUL_PAD ( 2903): launchpad.c: main(688) > error reading sigchld info
06-04 10:15:47.349+0900 I/ESD     ( 2919): esd_main.c: __esd_app_dead_handler(1771) > pid: 6243
06-04 10:15:47.349+0900 D/STARTER ( 2826): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 6243 is termianted
06-04 10:15:47.349+0900 D/STARTER ( 2826): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
06-04 10:15:47.349+0900 E/STARTER ( 2826): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
06-04 10:15:47.349+0900 D/STARTER ( 2826): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
06-04 10:15:47.349+0900 D/STARTER ( 2826): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
06-04 10:15:47.349+0900 W/AUL_AMD ( 2744): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 6243
06-04 10:15:47.349+0900 W/AUL_AMD ( 2744): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 6243
06-04 10:15:47.349+0900 D/AUL_AMD ( 2744): amd_key.c: _unregister_key_event(179) > ===key stack===
06-04 10:15:47.349+0900 E/AUL_AMD ( 2744): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-04 10:15:47.349+0900 D/AUL_AMD ( 2744): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
06-04 10:15:47.349+0900 D/AUL     ( 2744): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 10:15:47.349+0900 E/AUL     ( 2744): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 10:15:47.349+0900 W/STARTER ( 2826): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x1200007 is not transient
06-04 10:15:47.349+0900 D/INDICATOR( 2838): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
06-04 10:15:47.349+0900 D/RESOURCED( 2829): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 6243
06-04 10:15:47.349+0900 D/RESOURCED( 2829): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
06-04 10:15:47.409+0900 D/VOLUME  ( 2845): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
06-04 10:15:48.019+0900 I/user_tag0( 6257): /opt/usr/apps/org.example.example/data/feeding.db
06-04 10:15:48.029+0900 I/tag     ( 6257): eonji~
06-04 10:15:48.079+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40133e 
06-04 10:15:49.029+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40133e 
06-04 10:15:49.149+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.149+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.199+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.199+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.199+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.199+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.199+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.199+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.209+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:49.209+0900 D/IMMODULE( 6257): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 10:15:49.209+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 10:15:49.209+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:15:49.219+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 10:15:49.219+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:15:49.219+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 10:15:49.219+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:15:49.219+0900 D/ISF_QUERY( 6257): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 10:15:49.219+0900 D/ISF_QUERY( 6257): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:15:49.219+0900 D/ISF_QUERY( 6257): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:15:49.219+0900 D/ISF_QUERY( 6257): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:15:49.219+0900 D/ISF_QUERY( 6257): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:15:49.219+0900 D/ISF_QUERY( 6257): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:15:49.219+0900 D/ISF_QUERY( 6257): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 10:15:49.229+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 10:15:49.229+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:15:49.229+0900 D/IMMODULE( 6257): scim_panel_client.cpp: open_connection(162) > 
06-04 10:15:49.229+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 10:15:49.229+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:15:49.229+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(515) > ppid:2903  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 10:15:49.229+0900 D/ISF_SOCKET( 6257): scim_socket.cpp: connect(524) > connect() succeeded
06-04 10:15:49.229+0900 D/IMMODULE( 6257): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 10:15:50.029+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
06-04 10:15:50.509+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40133e 
06-04 10:15:50.659+0900 I/tag     ( 6257): insert
06-04 10:15:50.669+0900 I/user_tag( 6257): 10:15 AM
06-04 10:15:50.669+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:50.669+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:50.679+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:50.679+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:50.679+0900 E/EFL     ( 6257): edje<6257> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 10:15:51.349+0900 D/PROCESSMGR( 2764): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002e  register trigger_timer!  pointed_win=0x40133e 
06-04 10:15:52.099+0900 D/AUL_AMD ( 2744): amd_status.c: __app_terminate_timer_cb(442) > pid(6243)
06-04 10:15:52.099+0900 W/AUL_AMD ( 2744): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 10:15:52.439+0900 I/user_tag0( 6257): /opt/usr/apps/org.example.example/data/feeding.db
06-04 10:15:52.449+0900 I/tag     ( 6257): eonji~
06-04 10:15:52.449+0900 I/tag     ( 6257): 들어와!
06-04 10:15:52.449+0900 I/tag     ( 6257): 언지
06-04 10:15:52.449+0900 I/tag     ( 6257): 10 15
06-04 10:15:52.449+0900 E/EFL     ( 6257): eo<6257> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800a9b50 is not pointing to a valid object. Maybe it has already been freed.
06-04 10:15:52.449+0900 E/EFL     ( 6257): eo<6257> lib/eo/eo.c:485 _eo_do_internal() Obj (0x800a9b50) is an invalid ref.
06-04 10:15:52.489+0900 W/CRASH_MANAGER( 6429): worker.c: worker_job(1204) > 1106257657861149653895
