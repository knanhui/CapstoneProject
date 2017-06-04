S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 4073
Date: 2017-06-04 06:54:24+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x2

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb37bd931, esi = 0xb37bd685
ebp = 0xbfd6a2d8, esp = 0xbfd6a100
eax = 0x0000000c, ebx = 0xb37c0000
ecx = 0x00000002, edx = 0x00000000
eip = 0xb37b7ac2

Memory Information
MemTotal:      123 KB
MemFree:        28 KB
Buffers:         5 KB
Cached:     177784 KB
VmPeak:     123240 KB
VmSize:     118180 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36020 KB
VmRSS:       31012 KB
VmData:      48268 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34636 KB
VmPTE:         104 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 4073 TID = 4073
4073 4076 4236 4237 4245 

Maps Information
b0cd6000 b0cdd000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b0cde000 b0cf6000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b0cf7000 b0cfe000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b16bb000 b16bf000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b7a000 b2b84000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b8a000 b2b96000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b97000 b2bb8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bbd000 b2bbe000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bbf000 b2bc4000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bc5000 b2bc6000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bc7000 b2bc9000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bca000 b2bcc000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bcd000 b2bd9000 r-xp /usr/lib/libdrm.so.2.4.0
b2bda000 b2bdd000 r-xp /usr/lib/libdri2.so.0.0.0
b2bde000 b2be8000 r-xp /usr/lib/libtbm.so.1.0.0
b2be9000 b2bfe000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bff000 b2c11000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3413000 b3444000 r-xp /usr/lib/libidn.so.11.5.44
b3445000 b3467000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3468000 b3478000 r-xp /usr/lib/libcares.so.2.1.0
b3479000 b3482000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3483000 b348c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b348d000 b3504000 r-xp /usr/lib/libcurl.so.4.3.0
b3506000 b3518000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3519000 b353a000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3541000 b3542000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3543000 b3544000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3545000 b3548000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3549000 b354c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3654000 b365a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b365b000 b379f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37b0000 b37b1000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37b2000 b37bf000 r-xp /opt/usr/apps/org.example.example/bin/example
b37c1000 b37fa000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41fd000 b4208000 r-xp /lib/libnss_files-2.20-2014.11.so
b420a000 b4215000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4217000 b422e000 r-xp /lib/libnsl-2.20-2014.11.so
b4232000 b423a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b423c000 b4260000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4261000 b4262000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4263000 b4266000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4267000 b426e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b426f000 b4279000 r-xp /usr/lib/libsensord-share.so
b427a000 b4296000 r-xp /usr/lib/libsensor.so.1.2.0
b4298000 b42a1000 r-xp /usr/lib/libappcore-common.so.1.1
b42a4000 b42a6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42bb000 b42bd000 r-xp /usr/lib/libXau.so.6.0.0
b42be000 b42e0000 r-xp /usr/lib/libxcb.so.1.1.0
b42e2000 b42eb000 r-xp /lib/libcrypt-2.20-2014.11.so
b4314000 b4316000 r-xp /usr/lib/libiri.so
b4317000 b433d000 r-xp /lib/libexpat.so.1.5.2
b433f000 b43aa000 r-xp /usr/lib/libssl.so.1.0.0
b43b0000 b43bc000 r-xp /usr/lib/libethumb.so.1.13.0
b43bd000 b43c1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43c2000 b4613000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b8e000 b5b9e000 r-xp /usr/lib/libXi.so.6.1.0
b5b9f000 b5ba1000 r-xp /usr/lib/libXgesture.so.7.0.0
b5ba2000 b5ba8000 r-xp /usr/lib/libXtst.so.6.1.0
b5ba9000 b5bb3000 r-xp /usr/lib/libXrender.so.1.3.0
b5bb4000 b5bbd000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bbf000 b5bc1000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bc2000 b5bc7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bc8000 b5bda000 r-xp /usr/lib/libXext.so.6.4.0
b5bdb000 b5bdd000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bde000 b5be0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5be2000 b5d24000 r-xp /usr/lib/libX11.so.6.3.0
b5d28000 b5d32000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d33000 b5d49000 r-xp /usr/lib/libudev.so.1.6.0
b5d4c000 b5d50000 r-xp /lib/libattr.so.1.1.0
b5d51000 b5d80000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d82000 b5d88000 r-xp /usr/lib/libffi.so.6.0.2
b5d89000 b5dac000 r-xp /lib/libz.so.1.2.8
b5dad000 b5db0000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5db1000 b5f0d000 r-xp /usr/lib/libxml2.so.2.9.2
b5f13000 b5ffa000 r-xp /usr/lib/libstdc++.so.6.0.20
b6007000 b600a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b600b000 b602d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b602e000 b6042000 r-xp /lib/libresolv-2.20-2014.11.so
b6046000 b606a000 r-xp /usr/lib/liblzma.so.5.0.3
b606b000 b606d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b606f000 b6079000 r-xp /usr/lib/libembryo.so.1.13.0
b607a000 b60a3000 r-xp /usr/lib/libpng12.so.0.50.0
b60a4000 b60ed000 r-xp /usr/lib/libjpeg.so.8.0.2
b60fe000 b6105000 r-xp /lib/librt-2.20-2014.11.so
b6107000 b6126000 r-xp /usr/lib/libector.so.1.13.0
b6129000 b6156000 r-xp /usr/lib/liblua-5.1.so
b6157000 b61e7000 r-xp /usr/lib/libfreetype.so.6.11.3
b61eb000 b6229000 r-xp /usr/lib/libfontconfig.so.1.8.0
b622a000 b6240000 r-xp /usr/lib/libfribidi.so.0.3.1
b6241000 b629a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b629d000 b62e8000 r-xp /lib/libm-2.20-2014.11.so
b62ea000 b62fc000 r-xp /usr/lib/libeio.so.1.13.0
b62fd000 b6300000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6301000 b6307000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6308000 b632b000 r-xp /usr/lib/libefreet.so.1.13.0
b632e000 b6359000 r-xp /usr/lib/libeldbus.so.1.13.0
b635a000 b638e000 r-xp /usr/lib/libecore_con.so.1.13.0
b6390000 b6399000 r-xp /usr/lib/libecore_imf.so.1.13.0
b639a000 b63a3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63a4000 b63b7000 r-xp /usr/lib/libeo.so.1.13.0
b63b9000 b63cc000 r-xp /usr/lib/libecore_input.so.1.13.0
b63cd000 b63d4000 r-xp /usr/lib/libecore_file.so.1.13.0
b63d5000 b63f8000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63f9000 b6425000 r-xp /usr/lib/libeet.so.1.13.0
b642e000 b6499000 r-xp /usr/lib/libeina.so.1.13.0
b649c000 b64b3000 r-xp /usr/lib/libefl.so.1.13.0
b64b5000 b661c000 r-xp /usr/lib/libicuuc.so.51.1
b662a000 b6836000 r-xp /usr/lib/libicui18n.so.51.1
b683e000 b688d000 r-xp /usr/lib/libecore_x.so.1.13.0
b688f000 b68a9000 r-xp /lib/libgcc_s-4.9.so.1
b68ab000 b68af000 r-xp /lib/libcap.so.2.21
b68b0000 b68f6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68f7000 b68fe000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6900000 b6952000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6954000 b6adf000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ae4000 b6bb2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bb5000 b6bb9000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bba000 b6bc9000 r-xp /usr/lib/libvconf.so.0.2.45
b6bca000 b6bcd000 r-xp /usr/lib/libvasum.so.0.3.1
b6bce000 b6bd1000 r-xp /usr/lib/libttrace.so.1.1
b6bd3000 b6bd7000 r-xp /usr/lib/libiniparser.so.0
b6bd8000 b6c08000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c09000 b6c12000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c13000 b6c38000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c39000 b6c49000 r-xp /usr/lib/libunwind.so.8.0.1
b6c53000 b6e01000 r-xp /lib/libc-2.20-2014.11.so
b6e09000 b6f4c000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f4e000 b6fa6000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fa7000 b6fdb000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fde000 b70b2000 r-xp /usr/lib/libedje.so.1.13.0
b70b5000 b70e1000 r-xp /usr/lib/libecore.so.1.13.0
b70f2000 b7318000 r-xp /usr/lib/libevas.so.1.13.0
b7340000 b7358000 r-xp /lib/libpthread-2.20-2014.11.so
b735c000 b76d6000 r-xp /usr/lib/libelementary.so.1.13.0
b76f6000 b76fa000 r-xp /usr/lib/libsmack.so.1.0.0
b76fb000 b7704000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7705000 b7708000 r-xp /usr/lib/libdlog.so.0.0.0
b7709000 b770e000 r-xp /usr/lib/libbundle.so.0.1.22
b770f000 b7712000 r-xp /lib/libdl-2.20-2014.11.so
b7714000 b7739000 r-xp /usr/lib/libaul.so.0.1.0
b773c000 b773e000 r-xp /usr/lib/libappsvc.so.0.1.0
b773f000 b7744000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7745000 b774c000 r-xp /usr/lib/libappcore-efl.so.1.1
b774e000 b7753000 r-xp /usr/lib/libsys-assert.so
b7756000 b7757000 r-xp [vdso]
b7757000 b7779000 r-xp /lib/ld-2.20-2014.11.so
b777b000 b7783000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:4073)
Call Stack Count: 23
 0: db_read_cb + 0xc2 (0xb37b7ac2) [/opt/usr/apps/org.example.example/bin/example] + 0x5ac2
 1: sqlite3_exec + 0x27b (0xb6b6304b) [/usr/lib/libsqlite3.so.0] + 0x7f04b
 2: read_db + 0xa9 (0xb37b79e9) [/opt/usr/apps/org.example.example/bin/example] + 0x59e9
 3: init_db + 0x176 (0xb37b74d6) [/opt/usr/apps/org.example.example/bin/example] + 0x54d6
 4: create_button_view + 0x411 (0xb37b71d1) [/opt/usr/apps/org.example.example/bin/example] + 0x51d1
 5: feeding_view_cb + 0x54 (0xb37b6d04) [/opt/usr/apps/org.example.example/bin/example] + 0x4d04
 6: (0xb7126449) [/usr/lib/libevas.so.1] + 0x34449
 7: (0xb63b2319) [/usr/lib/libeo.so.1] + 0xe319
 8: eo_event_callback_call + 0xb3 (0xb63afd63) [/usr/lib/libeo.so.1] + 0xbd63
 9: (0xb7126a62) [/usr/lib/libevas.so.1] + 0x34a62
10: (0xb7135441) [/usr/lib/libevas.so.1] + 0x43441
11: evas_canvas_event_feed_mouse_down + 0xcf (0xb713f20f) [/usr/lib/libevas.so.1] + 0x4d20f
12: evas_event_feed_mouse_down + 0x6a (0xb7145c2a) [/usr/lib/libevas.so.1] + 0x53c2a
13: (0xb43bf49c) [/usr/lib/libecore_input_evas.so.1] + 0x249c
14: (0xb70c2055) [/usr/lib/libecore.so.1] + 0xd055
15: (0xb70cb1b9) [/usr/lib/libecore.so.1] + 0x161b9
16: ecore_main_loop_begin + 0x57 (0xb70cb587) [/usr/lib/libecore.so.1] + 0x16587
17: elm_run + 0x2d (0xb752422d) [/usr/lib/libelementary.so.1] + 0x1c822d
18: appcore_efl_main + 0x4de (0xb7748dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
19: ui_app_main + 0x140 (0xb7741c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
20: main + 0x296 (0xb37ba736) [/opt/usr/apps/org.example.example/bin/example] + 0x8736
21: (0xb777d148) [/opt/usr/apps/org.example.example/bin/example] + 0xb777d148
22: __libc_start_main + 0xde (0xb6c6ae4e) [/lib/libc.so.6] + 0x17e4e
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
: <3963> lib/ecore/ecore_timer.c:432 _ecore_timer_del() safety check failed: timer == NULL
06-04 06:54:14.210+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 6:54 4 h"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 6:54"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 6&#x2236;54"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147168150 Time: <font_size=33>6&#x2236;54</font_size> <font_size=32>AM</font_size></font>
06-04 06:54:14.210+0900 D/INDICATOR( 2856): battery.c: indicator_battery_update_display(606) > indicator_battery_update_display[606]	 "Battery Capacity: 50"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.battery.percentage.two.digits.show"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): battery.c: hide_digits(487) > hide_digits[487]	 "Hide digits"
06-04 06:54:14.210+0900 E/INDICATOR( 2856): list.c: list_try_to_find_icon_to_remove(335) > (!icon) -> list_try_to_find_icon_to_remove() return
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_enabled_system_count(654) > Noti count : 0 , MiniCtrl count : 0
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_enabled_system_count(654) > Noti count : 0 , MiniCtrl count : 0
06-04 06:54:14.210+0900 E/INDICATOR( 2856): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_minictrl_list(693) > Noti count : 0, System count : 0, Minictrl count : 3
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_minictrl_list(693) > Noti count : 0, System count : 0, Minictrl count : 3
06-04 06:54:14.210+0900 E/INDICATOR( 2856): list.c: list_try_to_find_icon_to_show(269) > default
06-04 06:54:14.210+0900 E/INDICATOR( 2856): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
06-04 06:54:14.210+0900 E/INDICATOR( 2856): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
06-04 06:54:14.210+0900 D/INDICATOR( 2856): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.hide"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
06-04 06:54:14.210+0900 D/INDICATOR( 2856): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.hide"
06-04 06:54:14.210+0900 E/INDICATOR( 2856): box.c: _update_icon(172) > (!list) -> _update_icon() return
06-04 06:54:14.210+0900 E/INDICATOR( 2856): box.c: _update_icon(172) > (!list) -> _update_icon() return
06-04 06:54:14.210+0900 E/INDICATOR( 2856): box.c: _update_icon(172) > (!list) -> _update_icon() return
06-04 06:54:14.210+0900 E/INDICATOR( 2856): box.c: _update_icon(172) > (!list) -> _update_icon() return
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 06:54:14.210+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 06:54:14.210+0900 D/INDICATOR( 2856): icon.c: _hide_more_noti(779) > port :: hide more icon
06-04 06:54:14.210+0900 E/INDICATOR( 2856): rssi.c: wake_up_cb(162) > (!s_info.updated_while_lcd_off) -> wake_up_cb() return
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2847): alarm-lib.c: alarmmgr_enum_alarm_ids(1382) > [SECURE_LOG] alarm_manager_call_alarm_get_number_of_ids_sync() is called
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3042) > before getting actual pid[2847]
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3044) > after getting actual pid[2847]
06-04 06:54:14.210+0900 E/ALARM_MANAGER( 2795): alarm-manager.c: _get_zone_name(573) > zone name [/]
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: __check_privilege_by_cookie(1966) > uid : 200
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: __check_privilege_by_cookie(1982) > The process(2847) was authenticated successfully.
06-04 06:54:14.210+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 37
06-04 06:54:14.210+0900 E/AUL_AMD ( 2753): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
06-04 06:54:14.210+0900 E/AUL_AMD ( 2753): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
06-04 06:54:14.210+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2847 : 0
06-04 06:54:14.210+0900 D/AUL     ( 2795): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
06-04 06:54:14.210+0900 D/AUL     ( 2795): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: __zone_get_appid_bypid(387) > cmdline(/usr/bin/starter)
06-04 06:54:14.210+0900 D/PKGMGR_INFO( 2795): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
06-04 06:54:14.210+0900 D/PKGMGR_INFO( 2795): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
06-04 06:54:14.210+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 37
06-04 06:54:14.210+0900 E/AUL_AMD ( 2753): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
06-04 06:54:14.210+0900 E/AUL_AMD ( 2753): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
06-04 06:54:14.210+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2847 : 0
06-04 06:54:14.210+0900 D/AUL     ( 2795): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
06-04 06:54:14.210+0900 D/AUL     ( 2795): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: __get_caller_unique_name(2015) > [SECURE_LOG] unique_name= /usr/bin/starter
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3065) > [SECURE_LOG] Called by process (pid:2847, unique_name:/usr/bin/starter)
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3073) > [SECURE_LOG] app_name=/usr/bin/starter, quark_app_unique_name=context-service
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3082) > [SECURE_LOG] number of alarms of the process (pid:2847, unique_name:/usr/bin/starter) is 0.
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2847): alarm-lib.c: alarmmgr_enum_alarm_ids(1401) > maxnum_of_ids[0]
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2847): alarm-lib.c: alarmmgr_enum_alarm_ids(1404) > [SECURE_LOG] alarm_manager_call_alarm_get_list_of_ids_sync() is called
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3104) > before getting actual pid[2847]
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2795): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3106) > after getting actual pid[2847]
06-04 06:54:14.210+0900 E/ALARM_MANAGER( 2795): alarm-manager.c: _get_zone_name(573) > zone name [/]
06-04 06:54:14.210+0900 E/ALARM_MANAGER( 2795): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3115) > [SECURE_LOG] called for pid(2847), but max_number_of_ids(0) is less than 0.
06-04 06:54:14.210+0900 D/ALARM_MANAGER( 2847): alarm-lib.c: alarmmgr_enum_alarm_ids(1435) > [SECURE_LOG] Leave
06-04 06:54:14.240+0900 D/eventsystem( 2699): eventsystem.c: eventsystem_send_system_event(1011) > event_name(tizen.system.event.display_state)
06-04 06:54:14.240+0900 D/eventsystem( 2699): eventsystem.c: __get_member_name_from_eventname(259) > member_name(display_state)
06-04 06:54:14.240+0900 D/eventsystem( 2699): eventsystem.c: __eventsystem_send_event(851) > interface_name(tizen.system.event)
06-04 06:54:14.240+0900 D/eventsystem( 2699): eventsystem.c: __eventsystem_send_event(852) > object_path(/tizen/system/event)
06-04 06:54:14.240+0900 D/eventsystem( 2699): eventsystem.c: __eventsystem_send_event(853) > member_name(display_state)
06-04 06:54:14.240+0900 D/INDICATOR( 2856): main.c: _indicator_notify_pm_state_cb(169) > LCD is on
06-04 06:54:14.240+0900 D/DATA_PROVIDER_MASTER( 2924): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-04 06:54:14.330+0900 D/APP_CORE( 2867): appcore-rotation.c: __changed_cb(121) > [APP 2867] Rotation: 0 -> 1
06-04 06:54:14.330+0900 D/APP_CORE( 2867): appcore-rotation.c: __changed_cb(124) > [APP 2867] Rotation: 0 -> 1
06-04 06:54:14.330+0900 I/CAPI_APPFW_APPLICATION( 2867): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
06-04 06:54:14.380+0900 D/STARTER ( 2847): hw_key.c: _key_release_cb(206) > [_key_release_cb:206] _key_release_cb : XF86PowerOff Released
06-04 06:54:14.380+0900 D/STARTER ( 2847): hw_key.c: _key_release_cb(233) > [_key_release_cb:233] phone lock state, ignore home key.
06-04 06:54:14.390+0900 D/AUL_PAD ( 4240): launchpad_loader.c: main(588) > sleeping 1 sec...
06-04 06:54:14.390+0900 D/AUL_PAD ( 4240): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b85b2760
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): preload.h: __preload_init(69) > get pre-initialization function
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): preload.h: __preload_init(73) > get shutdown function
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b85b2a40
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b85b4640
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): preload.h: __preload_init(69) > get pre-initialization function
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): preload.h: __preload_init(73) > get shutdown function
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): preexec.h: __preexec_init(76) > preexec start
06-04 06:54:14.400+0900 D/AUL_PAD ( 4240): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-04 06:54:14.400+0900 D/AUL     ( 4240): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-04 06:54:14.400+0900 D/AUL     ( 4240): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-04 06:54:14.400+0900 D/AUL     ( 4240): process_pool.c: __connect_to_launchpad(132) > send(4240) : 4
06-04 06:54:14.400+0900 D/AUL     ( 4240): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-04 06:54:14.400+0900 D/AUL_PAD ( 2921): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 4240
06-04 06:54:14.480+0900 D/STARTER ( 2847): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb7bb6040), lock_pid(3963)
06-04 06:54:14.480+0900 E/STARTER ( 2847): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
06-04 06:54:14.490+0900 D/AUL_PAD ( 4240): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-04 06:54:14.490+0900 D/AUL_PAD ( 4240): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-04 06:54:14.490+0900 D/AUL_PAD ( 4240): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-04 06:54:14.490+0900 D/AUL_PAD ( 4240): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-04 06:54:15.210+0900 D/LOCKSCREEN( 3963): lockscreen.c: lockscreen_lcd_off_count_raise(133) > [lockscreen_lcd_off_count_raise:133:D] count for lcd off timer : 0
06-04 06:54:15.210+0900 D/LOCKSCREEN( 3963): default_lock.c: _default_lock_mouse_down_cb(115) > [_default_lock_mouse_down_cb:115:D] clicked x(559), y(997)
06-04 06:54:15.210+0900 D/LOCKSCREEN( 3963): default_lock.c: _default_lock_mouse_down_cb(125) > [_default_lock_mouse_down_cb:125:D] touch upper y : 38
06-04 06:54:15.210+0900 D/LOCKSCREEN( 3963): default_lock.c: _default_lock_mouse_down_cb(137) > [_default_lock_mouse_down_cb:137:D] camera icon : x(559), y(1119), w(124), h(124)
06-04 06:54:15.340+0900 D/LOCKSCREEN( 3963): default_lock.c: _default_lock_mouse_up_cb(214) > [_default_lock_mouse_up_cb:214:D] exit lockscreen
06-04 06:54:15.370+0900 I/LOCKSCREEN( 3963): lockscreen.c: _lcd_off_timer_cb(98) > [_lcd_off_timer_cb:98:I] lcd off : 10sec
06-04 06:54:15.370+0900 D/LOCKSCREEN( 3963): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496526855) formatted(Sun, June 4)
06-04 06:54:15.370+0900 D/LOCKSCREEN( 3963): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496526855) formatted(6:54)
06-04 06:54:15.370+0900 D/LOCKSCREEN( 3963): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496526855) formatted(AM)
06-04 06:54:15.390+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x40053e 
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: ui_app_exit(799) > ui_app_exit
06-04 06:54:15.860+0900 D/AUL     ( 3963): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-04 06:54:15.860+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 22
06-04 06:54:15.860+0900 W/AUL_AMD ( 2753): amd_request.c: __request_handler(1056) > app status : 5
06-04 06:54:15.860+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(3963) status(5)
06-04 06:54:15.860+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(3963) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
06-04 06:54:15.860+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
06-04 06:54:15.860+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3963, appid: org.tizen.lockscreen, status: bg
06-04 06:54:15.860+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 3963, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
06-04 06:54:15.860+0900 D/RESOURCED( 2854): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 3963, appname = org.tizen.lockscreen
06-04 06:54:15.860+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3963
06-04 06:54:15.860+0900 D/RESOURCED( 2854): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2864 increase lru 3
06-04 06:54:15.860+0900 D/RESOURCED( 2854): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2864 set score 360 (before 330)
06-04 06:54:15.860+0900 D/RESOURCED( 2854): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
06-04 06:54:15.860+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3963, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
06-04 06:54:15.860+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 3963
06-04 06:54:15.860+0900 D/APP_CORE( 3963): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-04 06:54:15.860+0900 I/CAPI_APPFW_APPLICATION( 3963): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
06-04 06:54:15.860+0900 D/LOCKSCREEN( 3963): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
06-04 06:54:15.860+0900 D/COM_CORE( 3963): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(41) for pid(-1)
06-04 06:54:15.860+0900 D/COM_CORE( 3963): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
06-04 06:54:15.860+0900 D/COM_CORE( 2924): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
06-04 06:54:15.860+0900 D/DATA_PROVIDER_MASTER( 2924): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb1600540 is terminated
06-04 06:54:15.860+0900 D/DATA_PROVIDER_MASTER( 2924): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
06-04 06:54:15.860+0900 D/COM_CORE( 3963): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
06-04 06:54:15.910+0900 E/COM_CORE( 3963): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
06-04 06:54:15.910+0900 E/LOCKSCREEN( 3963): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
06-04 06:54:15.910+0900 E/LOCKSCREEN( 3963): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
06-04 06:54:15.910+0900 D/LOCKSCREEN( 3963): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
06-04 06:54:15.910+0900 D/CALL_MGR_CLIENT( 3963): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
06-04 06:54:15.910+0900 D/CALL_MGR_CLIENT( 3963): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
06-04 06:54:15.910+0900 W/CALL_MGR_CLIENT( 3963): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
06-04 06:54:15.910+0900 D/CALL_MGR_CLIENT( 3963): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
06-04 06:54:15.910+0900 D/CALL_MGR_CLIENT( 3963): <LIB:cm_deinit:444> cm_deinit
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
06-04 06:54:15.910+0900 D/SYSTEM-SETTINGS( 3963): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
06-04 06:54:15.910+0900 D/SYSTEM-SETTINGS( 3963): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
06-04 06:54:15.910+0900 D/SYSTEM-SETTINGS( 3963): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
06-04 06:54:15.910+0900 D/LOCKSCREEN( 3963): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
06-04 06:54:15.910+0900 D/SYSTEM-SETTINGS( 3963): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
06-04 06:54:15.910+0900 E/TIZEN_N_SYSTEM_SETTINGS( 3963): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
06-04 06:54:15.910+0900 D/SYSTEM-SETTINGS( 3963): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
06-04 06:54:15.910+0900 D/LOCKSCREEN( 3963): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
06-04 06:54:15.920+0900 E/EFL     ( 3963): eo<3963> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
06-04 06:54:15.920+0900 E/EFL     ( 3963): eo<3963> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
06-04 06:54:16.080+0900 E/E17     ( 2783): e_border.c: e_border_hide(2248) > BD_HIDE(0x02400007), visible:1
06-04 06:54:16.080+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 06:54:16.080+0900 E/E17_TZSH( 2783): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b395b5c0, role:118
06-04 06:54:16.080+0900 W/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=4073
06-04 06:54:16.080+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
06-04 06:54:16.080+0900 D/INDICATOR( 2856): main.c: _property_changed_cb(432) > UNSNIFF API 2400007
06-04 06:54:16.080+0900 D/INDICATOR( 2856): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-04 06:54:16.080+0900 D/INDICATOR( 2856): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-04 06:54:16.080+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-04 06:54:16.080+0900 D/INDICATOR( 2856): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-04 06:54:16.080+0900 D/INDICATOR( 2856): main.c: _rotate_window(252) > port :: hide more icon
06-04 06:54:16.100+0900 D/AUL_PAD ( 2921): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-04 06:54:16.100+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-04 06:54:16.100+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-04 06:54:16.100+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-04 06:54:16.100+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-04 06:54:16.100+0900 D/AUL_PAD ( 2921): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-04 06:54:16.100+0900 D/AUL_PAD ( 2921): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-04 06:54:16.100+0900 I/AUL_PAD ( 2921): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 3963 pgid = 3963
06-04 06:54:16.100+0900 I/AUL_PAD ( 2921): sigchild.h: __sigchild_action(142) > dead_pid(3963)
06-04 06:54:16.100+0900 D/AUL_PAD ( 2921): sigchild.h: __send_app_dead_signal(90) > send dead signal done
06-04 06:54:16.100+0900 I/AUL_PAD ( 2921): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
06-04 06:54:16.100+0900 I/AUL_PAD ( 2921): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
06-04 06:54:16.100+0900 E/AUL_PAD ( 2921): launchpad.c: main(688) > error reading sigchld info
06-04 06:54:16.100+0900 W/AUL_AMD ( 2753): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 3963
06-04 06:54:16.100+0900 W/AUL_AMD ( 2753): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 3963
06-04 06:54:16.100+0900 D/AUL_AMD ( 2753): amd_key.c: _unregister_key_event(179) > ===key stack===
06-04 06:54:16.100+0900 E/AUL_AMD ( 2753): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
06-04 06:54:16.100+0900 D/AUL_AMD ( 2753): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
06-04 06:54:16.100+0900 D/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-04 06:54:16.100+0900 E/AUL     ( 2753): simple_util.c: __trm_app_info_send_socket(330) > access
06-04 06:54:16.100+0900 D/STARTER ( 2847): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 3963 is termianted
06-04 06:54:16.100+0900 D/STARTER ( 2847): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
06-04 06:54:16.100+0900 E/STARTER ( 2847): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
06-04 06:54:16.100+0900 D/STARTER ( 2847): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
06-04 06:54:16.100+0900 D/STARTER ( 2847): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
06-04 06:54:16.100+0900 W/STARTER ( 2847): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x2400007 is not transient
06-04 06:54:16.100+0900 I/ESD     ( 2934): esd_main.c: __esd_app_dead_handler(1771) > pid: 3963
06-04 06:54:16.100+0900 D/RESOURCED( 2854): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 3963
06-04 06:54:16.100+0900 D/RESOURCED( 2854): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
06-04 06:54:16.100+0900 D/INDICATOR( 2856): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
06-04 06:54:16.100+0900 I/TZSH    ( 2932): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
06-04 06:54:16.100+0900 E/EFL     ( 2783): eo<2783> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-04 06:54:16.110+0900 D/APP_CORE( 4073): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1200002 fully_obscured 0
06-04 06:54:16.110+0900 D/APP_CORE( 4073): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
06-04 06:54:16.110+0900 D/APP_CORE( 4073): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-04 06:54:16.110+0900 I/APP_CORE( 4073): appcore-efl.c: __do_app(496) > [APP 4073] Event: RESUME State: CREATED
06-04 06:54:16.110+0900 D/LAUNCH  ( 4073): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-04 06:54:16.110+0900 D/APP_CORE( 4073): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-04 06:54:16.110+0900 D/APP_CORE( 4073): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-04 06:54:16.110+0900 D/APP_CORE( 4073): appcore-efl.c: __do_app(607) > [APP 4073] RESUME
06-04 06:54:16.110+0900 I/APP_CORE( 4073): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-04 06:54:16.110+0900 I/APP_CORE( 4073): appcore-efl.c: __do_app(614) > [APP 4073] Initial Launching, call the resume_cb
06-04 06:54:16.110+0900 I/CAPI_APPFW_APPLICATION( 4073): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-04 06:54:16.110+0900 D/LAUNCH  ( 4073): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-04 06:54:16.110+0900 D/LAUNCH  ( 4073): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-04 06:54:16.110+0900 D/APP_CORE( 4073): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-04 06:54:16.110+0900 E/APP_CORE( 4073): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-04 06:54:16.110+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(838) > __request_handler: 15
06-04 06:54:16.110+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 06:54:16.110+0900 D/PKGMGR_INFO( 2753): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-04 06:54:16.110+0900 D/AUL_AMD ( 2753): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 4073 is org.example.example
06-04 06:54:16.110+0900 D/AUL_AMD ( 2753): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 4073 : 0
06-04 06:54:16.110+0900 D/AUL     ( 2937): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-04 06:54:16.110+0900 D/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2891) > pid(4073) status(3)
06-04 06:54:16.110+0900 D/AUL_AMD ( 2753): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
06-04 06:54:16.110+0900 W/AUL_AMD ( 2753): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-04 06:54:16.110+0900 W/AUL_AMD ( 2753): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-04 06:54:16.110+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(456) > pid(4073) status(3)
06-04 06:54:16.110+0900 D/AUL_AMD ( 2753): amd_status.c: _status_update_app_info_list(468) > pid(4073) appid(org.example.example) pkgid(org.example.example) status(3)
06-04 06:54:16.110+0900 D/AUL     ( 2753): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-04 06:54:16.110+0900 W/AUL     ( 2753): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 4073, appid: org.example.example, status: fg
06-04 06:54:16.110+0900 D/RESOURCED( 2854): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 4073
06-04 06:54:16.110+0900 D/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 4073, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-04 06:54:16.110+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 4073
06-04 06:54:16.160+0900 D/RESOURCED( 2854): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 4073, appname = org.example.example, pkgname = org.example.example
06-04 06:54:16.160+0900 D/RESOURCED( 2854): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 4073, appname = org.example.example
06-04 06:54:16.160+0900 D/RESOURCED( 2854): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4073
06-04 06:54:16.160+0900 I/RESOURCED( 2854): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-04 06:54:16.160+0900 I/RESOURCED( 2854): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-04 06:54:16.160+0900 D/VOLUME  ( 2864): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
06-04 06:54:17.720+0900 E/CAPI_NETWORK_WIFI( 2856): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-04 06:54:17.720+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-04 06:54:17.720+0900 E/INDICATOR( 2856): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-04 06:54:17.720+0900 E/INDICATOR( 2856): 
06-04 06:54:20.700+0900 I/user_tag0( 4073): /opt/usr/apps/org.example.example/data/feeding.db
06-04 06:54:20.700+0900 I/tag     ( 4073): eonji~
06-04 06:54:20.720+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400596 
06-04 06:54:20.870+0900 D/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(442) > pid(3963)
06-04 06:54:20.870+0900 W/AUL_AMD ( 2753): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-04 06:54:21.520+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400596 
06-04 06:54:21.630+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.630+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.670+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.670+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.670+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.670+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.680+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.680+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.680+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:21.680+0900 D/IMMODULE( 4073): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
06-04 06:54:21.680+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 06:54:21.680+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(524) > connect() succeeded
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(524) > connect() succeeded
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(524) > connect() succeeded
06-04 06:54:21.700+0900 D/ISF_QUERY( 4073): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
06-04 06:54:21.700+0900 D/ISF_QUERY( 4073): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 06:54:21.700+0900 D/ISF_QUERY( 4073): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 06:54:21.700+0900 D/ISF_QUERY( 4073): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 06:54:21.700+0900 D/ISF_QUERY( 4073): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 06:54:21.700+0900 D/ISF_QUERY( 4073): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 06:54:21.700+0900 D/ISF_QUERY( 4073): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-socket-frontend, example
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(524) > connect() succeeded
06-04 06:54:21.700+0900 D/IMMODULE( 4073): scim_panel_client.cpp: open_connection(162) > 
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(524) > connect() succeeded
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(515) > ppid:2921  trying connect() to local:/tmp/scim-panel-socket:0, example
06-04 06:54:21.700+0900 D/ISF_SOCKET( 4073): scim_socket.cpp: connect(524) > connect() succeeded
06-04 06:54:21.710+0900 D/IMMODULE( 4073): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
06-04 06:54:22.530+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400596 
06-04 06:54:22.680+0900 I/tag     ( 4073): insert
06-04 06:54:22.680+0900 I/user_tag( 4073): 06:54 AM
06-04 06:54:22.680+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:22.680+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:22.690+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:22.690+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:22.690+0900 E/EFL     ( 4073): edje<4073> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
06-04 06:54:23.520+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1200002
06-04 06:54:23.730+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400596 
06-04 06:54:24.550+0900 I/user_tag0( 4073): /opt/usr/apps/org.example.example/data/feeding.db
06-04 06:54:24.550+0900 I/tag     ( 4073): eonji~
06-04 06:54:24.550+0900 I/tag     ( 4073): 들어와!
06-04 06:54:24.550+0900 I/tag     ( 4073): 언지
06-04 06:54:24.550+0900 D/PROCESSMGR( 2783): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400596 
06-04 06:54:24.570+0900 W/CRASH_MANAGER( 4246): worker.c: worker_job(1204) > 1104073657861149652686
