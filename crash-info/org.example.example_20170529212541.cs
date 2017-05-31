S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8280
Date: 2017-05-29 21:25:41+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x8011e6e6, esi = 0xb3750050
ebp = 0xbfb58068, esp = 0xbfb57fa0
eax = 0x80123f09, ebx = 0xb3756000
ecx = 0x8000aa56, edx = 0x00000002
eip = 0xb375049a

Memory Information
MemTotal:      123 KB
MemFree:        29 KB
Buffers:         5 KB
Cached:     164600 KB
VmPeak:     125284 KB
VmSize:     125284 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       37008 KB
VmRSS:       37008 KB
VmData:      55384 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34624 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8280 TID = 8280
8280 8287 8467 8468 8477 

Maps Information
b0b68000 b0b80000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b150a000 b1511000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1512000 b1519000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b183b000 b183f000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b14000 b2b1e000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b24000 b2b30000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b31000 b2b52000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b57000 b2b58000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b59000 b2b5e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b5f000 b2b60000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b61000 b2b63000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b64000 b2b66000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b67000 b2b73000 r-xp /usr/lib/libdrm.so.2.4.0
b2b74000 b2b7e000 r-xp /usr/lib/libtbm.so.1.0.0
b2b7f000 b2b94000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b95000 b2ba7000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33a9000 b33da000 r-xp /usr/lib/libidn.so.11.5.44
b33db000 b33fd000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33fe000 b340e000 r-xp /usr/lib/libcares.so.2.1.0
b340f000 b3418000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3419000 b3422000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3423000 b349a000 r-xp /usr/lib/libcurl.so.4.3.0
b349c000 b34ae000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34af000 b34d0000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34d7000 b34d8000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34d9000 b34da000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34db000 b34de000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34df000 b34e2000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35ea000 b35f0000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35f1000 b3735000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3745000 b3748000 r-xp /usr/lib/libdri2.so.0.0.0
b3749000 b374a000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b374b000 b3755000 r-xp /opt/usr/apps/org.example.example/bin/example
b3757000 b3790000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4193000 b419e000 r-xp /lib/libnss_files-2.20-2014.11.so
b41a0000 b41ab000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41ad000 b41c4000 r-xp /lib/libnsl-2.20-2014.11.so
b41c8000 b41d0000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41d2000 b41f6000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41f7000 b41f8000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41f9000 b41fc000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41fd000 b4204000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b4205000 b420f000 r-xp /usr/lib/libsensord-share.so
b4210000 b422c000 r-xp /usr/lib/libsensor.so.1.2.0
b422e000 b4237000 r-xp /usr/lib/libappcore-common.so.1.1
b423a000 b423c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4251000 b4253000 r-xp /usr/lib/libXau.so.6.0.0
b4254000 b4276000 r-xp /usr/lib/libxcb.so.1.1.0
b4278000 b4281000 r-xp /lib/libcrypt-2.20-2014.11.so
b42aa000 b42ac000 r-xp /usr/lib/libiri.so
b42ad000 b42d3000 r-xp /lib/libexpat.so.1.5.2
b42d5000 b4340000 r-xp /usr/lib/libssl.so.1.0.0
b4346000 b4352000 r-xp /usr/lib/libethumb.so.1.13.0
b4353000 b4357000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4358000 b45a9000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b24000 b5b34000 r-xp /usr/lib/libXi.so.6.1.0
b5b35000 b5b37000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b38000 b5b3e000 r-xp /usr/lib/libXtst.so.6.1.0
b5b3f000 b5b49000 r-xp /usr/lib/libXrender.so.1.3.0
b5b4a000 b5b53000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b55000 b5b57000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b58000 b5b5d000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b5e000 b5b70000 r-xp /usr/lib/libXext.so.6.4.0
b5b71000 b5b73000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b74000 b5b76000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b78000 b5cba000 r-xp /usr/lib/libX11.so.6.3.0
b5cbe000 b5cc8000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cc9000 b5cdf000 r-xp /usr/lib/libudev.so.1.6.0
b5ce2000 b5ce6000 r-xp /lib/libattr.so.1.1.0
b5ce7000 b5d16000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d18000 b5d1e000 r-xp /usr/lib/libffi.so.6.0.2
b5d1f000 b5d42000 r-xp /lib/libz.so.1.2.8
b5d43000 b5d46000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d47000 b5ea3000 r-xp /usr/lib/libxml2.so.2.9.2
b5ea9000 b5f90000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f9d000 b5fa0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5fa1000 b5fc3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fc4000 b5fd8000 r-xp /lib/libresolv-2.20-2014.11.so
b5fdc000 b6000000 r-xp /usr/lib/liblzma.so.5.0.3
b6001000 b6003000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b6005000 b600f000 r-xp /usr/lib/libembryo.so.1.13.0
b6010000 b6039000 r-xp /usr/lib/libpng12.so.0.50.0
b603a000 b6083000 r-xp /usr/lib/libjpeg.so.8.0.2
b6094000 b609b000 r-xp /lib/librt-2.20-2014.11.so
b609d000 b60bc000 r-xp /usr/lib/libector.so.1.13.0
b60bf000 b60ec000 r-xp /usr/lib/liblua-5.1.so
b60ed000 b617d000 r-xp /usr/lib/libfreetype.so.6.11.3
b6181000 b61bf000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61c0000 b61d6000 r-xp /usr/lib/libfribidi.so.0.3.1
b61d7000 b6230000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6233000 b627e000 r-xp /lib/libm-2.20-2014.11.so
b6280000 b6292000 r-xp /usr/lib/libeio.so.1.13.0
b6293000 b6296000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6297000 b629d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b629e000 b62c1000 r-xp /usr/lib/libefreet.so.1.13.0
b62c4000 b62ef000 r-xp /usr/lib/libeldbus.so.1.13.0
b62f0000 b6324000 r-xp /usr/lib/libecore_con.so.1.13.0
b6326000 b632f000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6330000 b6339000 r-xp /usr/lib/libethumb_client.so.1.13.0
b633a000 b634d000 r-xp /usr/lib/libeo.so.1.13.0
b634f000 b6362000 r-xp /usr/lib/libecore_input.so.1.13.0
b6363000 b636a000 r-xp /usr/lib/libecore_file.so.1.13.0
b636b000 b638e000 r-xp /usr/lib/libecore_evas.so.1.13.0
b638f000 b63bb000 r-xp /usr/lib/libeet.so.1.13.0
b63c4000 b642f000 r-xp /usr/lib/libeina.so.1.13.0
b6432000 b6449000 r-xp /usr/lib/libefl.so.1.13.0
b644b000 b65b2000 r-xp /usr/lib/libicuuc.so.51.1
b65c0000 b67cc000 r-xp /usr/lib/libicui18n.so.51.1
b67d4000 b6823000 r-xp /usr/lib/libecore_x.so.1.13.0
b6825000 b683f000 r-xp /lib/libgcc_s-4.9.so.1
b6841000 b6845000 r-xp /lib/libcap.so.2.21
b6846000 b688c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b688d000 b6894000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6896000 b68e8000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68ea000 b6a75000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a7a000 b6b48000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b4b000 b6b4f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b50000 b6b5f000 r-xp /usr/lib/libvconf.so.0.2.45
b6b60000 b6b63000 r-xp /usr/lib/libvasum.so.0.3.1
b6b64000 b6b67000 r-xp /usr/lib/libttrace.so.1.1
b6b69000 b6b6d000 r-xp /usr/lib/libiniparser.so.0
b6b6e000 b6b9e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b9f000 b6ba8000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6ba9000 b6bce000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bcf000 b6bdf000 r-xp /usr/lib/libunwind.so.8.0.1
b6be9000 b6d97000 r-xp /lib/libc-2.20-2014.11.so
b6d9f000 b6ee2000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6ee4000 b6f3c000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f3d000 b6f71000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f74000 b7048000 r-xp /usr/lib/libedje.so.1.13.0
b704b000 b7077000 r-xp /usr/lib/libecore.so.1.13.0
b7088000 b72ae000 r-xp /usr/lib/libevas.so.1.13.0
b72d6000 b72ee000 r-xp /lib/libpthread-2.20-2014.11.so
b72f2000 b766c000 r-xp /usr/lib/libelementary.so.1.13.0
b768c000 b7690000 r-xp /usr/lib/libsmack.so.1.0.0
b7691000 b769a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b769b000 b769e000 r-xp /usr/lib/libdlog.so.0.0.0
b769f000 b76a4000 r-xp /usr/lib/libbundle.so.0.1.22
b76a5000 b76a8000 r-xp /lib/libdl-2.20-2014.11.so
b76aa000 b76cf000 r-xp /usr/lib/libaul.so.0.1.0
b76d2000 b76d4000 r-xp /usr/lib/libappsvc.so.0.1.0
b76d5000 b76da000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76db000 b76e2000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e4000 b76e9000 r-xp /usr/lib/libsys-assert.so
b76ec000 b76ed000 r-xp [vdso]
b76ed000 b770f000 r-xp /lib/ld-2.20-2014.11.so
b7711000 b7719000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8280)
Call Stack Count: 21
 0: make_popup_rep + 0x20a (0xb375049a) [/opt/usr/apps/org.example.example/bin/example] + 0x549a
 1: (0xb7111116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb6348319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6345d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71139e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb73c4404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb6ff7f39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb6ffea11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb6ff8fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb6ff94cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb6ff968f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb705e702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb7058055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70611b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb7061587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb74ba22d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb76dedde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb76d7c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb375185e) [/opt/usr/apps/org.example.example/bin/example] + 0x685e
19: (0xb7713148) [/opt/usr/apps/org.example.example/bin/example] + 0xb7713148
20: __libc_start_main + 0xde (0xb6c00e4e) [/lib/libc.so.6] + 0x17e4e
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
 Noti count : 0, System count : 0, Minictrl count : 3
05-29 21:25:34.592+0900 E/INDICATOR( 2919): list.c: list_try_to_find_icon_to_show(269) > default
05-29 21:25:34.592+0900 E/INDICATOR( 2919): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
05-29 21:25:34.592+0900 D/INDICATOR( 2919): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
05-29 21:25:34.592+0900 D/INDICATOR( 2919): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
05-29 21:25:34.592+0900 D/INDICATOR( 2919): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
05-29 21:25:34.592+0900 D/INDICATOR( 2919): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
05-29 21:25:34.592+0900 E/INDICATOR( 2919): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
05-29 21:25:34.592+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.hide"
05-29 21:25:34.592+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
05-29 21:25:34.592+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.hide"
05-29 21:25:34.592+0900 E/INDICATOR( 2919): box.c: _update_icon(172) > (!list) -> _update_icon() return
05-29 21:25:34.592+0900 E/INDICATOR( 2919): box.c: _update_icon(172) > (!list) -> _update_icon() return
05-29 21:25:34.592+0900 E/INDICATOR( 2919): box.c: _update_icon(172) > (!list) -> _update_icon() return
05-29 21:25:34.592+0900 E/INDICATOR( 2919): box.c: _update_icon(172) > (!list) -> _update_icon() return
05-29 21:25:34.592+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-29 21:25:34.592+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-29 21:25:34.592+0900 D/INDICATOR( 2919): icon.c: _hide_more_noti(779) > port :: hide more icon
05-29 21:25:34.592+0900 E/INDICATOR( 2919): rssi.c: wake_up_cb(162) > (!s_info.updated_while_lcd_off) -> wake_up_cb() return
05-29 21:25:34.612+0900 I/LOCKSCREEN( 8273): dbus.c: _dbus_message_recv_cb(98) > [_dbus_message_recv_cb:98:I] LCD on
05-29 21:25:34.612+0900 D/STARTER ( 2891): hw_key.c: _key_press_cb(302) > [_key_press_cb:302] _key_press_cb : XF86PowerOff Pressed
05-29 21:25:34.612+0900 D/STARTER ( 2891): hw_key.c: _key_press_cb(321) > [_key_press_cb:321] phone lock state, ignore key events.
05-29 21:25:34.612+0900 I/LOCKSCREEN( 8273): dbus.c: _lcd_on_cb(248) > [_lcd_on_cb:248:I] Dbus LCD on
05-29 21:25:34.612+0900 D/STARTER ( 2891): lock_mgr.c: _on_lcd_changed_receive(398) > [_on_lcd_changed_receive:398] LCD signal is received
05-29 21:25:34.612+0900 W/STARTER ( 2891): lock_mgr.c: _on_lcd_changed_receive(404) > [_on_lcd_changed_receive:404] LCD on
05-29 21:25:34.612+0900 D/STARTER ( 2891): lock_mgr.c: _on_lcd_changed_receive(408) > [_on_lcd_changed_receive:408] delete alarm : id(-1)
05-29 21:25:34.612+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1345) > [SECURE_LOG] Enter
05-29 21:25:34.612+0900 D/LOCKSCREEN( 8273): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496060734) formatted(Mon, May 29)
05-29 21:25:34.612+0900 D/LOCKSCREEN( 8273): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496060734) formatted(9:25)
05-29 21:25:34.612+0900 D/LOCKSCREEN( 8273): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496060734) formatted(PM)
05-29 21:25:34.612+0900 E/EFL     ( 8273): eo<8273> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800142a2 is not pointing to a valid object. Maybe it has already been freed.
05-29 21:25:34.612+0900 E/EFL     ( 8273): eo<8273> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x800142a2) is an invalid ref.
05-29 21:25:34.612+0900 E/EFL     ( 8273): <8273> lib/ecore/ecore_timer.c:432 _ecore_timer_del() safety check failed: timer == NULL
05-29 21:25:34.612+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1382) > [SECURE_LOG] alarm_manager_call_alarm_get_number_of_ids_sync() is called
05-29 21:25:34.612+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3042) > before getting actual pid[2891]
05-29 21:25:34.612+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3044) > after getting actual pid[2891]
05-29 21:25:34.612+0900 E/ALARM_MANAGER( 2864): alarm-manager.c: _get_zone_name(573) > zone name [/]
05-29 21:25:34.622+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: __check_privilege_by_cookie(1966) > uid : 200
05-29 21:25:34.622+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: __check_privilege_by_cookie(1982) > The process(2891) was authenticated successfully.
05-29 21:25:34.622+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 37
05-29 21:25:34.622+0900 E/AUL_AMD ( 2837): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
05-29 21:25:34.622+0900 E/AUL_AMD ( 2837): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
05-29 21:25:34.622+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2891 : 0
05-29 21:25:34.632+0900 D/AUL     ( 2864): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
05-29 21:25:34.632+0900 D/AUL     ( 2864): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
05-29 21:25:34.632+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: __zone_get_appid_bypid(387) > cmdline(/usr/bin/starter)
05-29 21:25:34.632+0900 D/PKGMGR_INFO( 2864): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
05-29 21:25:34.632+0900 D/PKGMGR_INFO( 2864): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
05-29 21:25:34.632+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 37
05-29 21:25:34.632+0900 E/AUL_AMD ( 2837): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
05-29 21:25:34.632+0900 E/AUL_AMD ( 2837): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
05-29 21:25:34.632+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2891 : 0
05-29 21:25:34.632+0900 D/AUL     ( 2864): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
05-29 21:25:34.632+0900 D/AUL     ( 2864): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
05-29 21:25:34.632+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: __get_caller_unique_name(2015) > [SECURE_LOG] unique_name= /usr/bin/starter
05-29 21:25:34.632+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3065) > [SECURE_LOG] Called by process (pid:2891, unique_name:/usr/bin/starter)
05-29 21:25:34.632+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3073) > [SECURE_LOG] app_name=/usr/bin/starter, quark_app_unique_name=context-service
05-29 21:25:34.632+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3082) > [SECURE_LOG] number of alarms of the process (pid:2891, unique_name:/usr/bin/starter) is 0.
05-29 21:25:34.632+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1401) > maxnum_of_ids[0]
05-29 21:25:34.632+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1404) > [SECURE_LOG] alarm_manager_call_alarm_get_list_of_ids_sync() is called
05-29 21:25:34.652+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3104) > before getting actual pid[2891]
05-29 21:25:34.652+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3106) > after getting actual pid[2891]
05-29 21:25:34.652+0900 E/ALARM_MANAGER( 2864): alarm-manager.c: _get_zone_name(573) > zone name [/]
05-29 21:25:34.652+0900 E/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3115) > [SECURE_LOG] called for pid(2891), but max_number_of_ids(0) is less than 0.
05-29 21:25:34.652+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1435) > [SECURE_LOG] Leave
05-29 21:25:34.682+0900 D/eventsystem( 2763): eventsystem.c: eventsystem_send_system_event(1011) > event_name(tizen.system.event.display_state)
05-29 21:25:34.682+0900 D/eventsystem( 2763): eventsystem.c: __get_member_name_from_eventname(259) > member_name(display_state)
05-29 21:25:34.682+0900 D/eventsystem( 2763): eventsystem.c: __eventsystem_send_event(851) > interface_name(tizen.system.event)
05-29 21:25:34.682+0900 D/eventsystem( 2763): eventsystem.c: __eventsystem_send_event(852) > object_path(/tizen/system/event)
05-29 21:25:34.682+0900 D/eventsystem( 2763): eventsystem.c: __eventsystem_send_event(853) > member_name(display_state)
05-29 21:25:34.682+0900 D/DATA_PROVIDER_MASTER( 2982): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-29 21:25:34.682+0900 D/INDICATOR( 2919): main.c: _indicator_notify_pm_state_cb(169) > LCD is on
05-29 21:25:34.762+0900 D/APP_CORE( 8280): appcore-rotation.c: __changed_cb(121) > [APP 8280] Rotation: 0 -> 1
05-29 21:25:34.762+0900 D/APP_CORE( 8280): appcore-rotation.c: __changed_cb(124) > [APP 8280] Rotation: 0 -> 1
05-29 21:25:34.762+0900 I/CAPI_APPFW_APPLICATION( 8280): app_main.c: _ui_app_appcore_rotation_event(484) > _ui_app_appcore_rotation_event
05-29 21:25:34.762+0900 D/APP_CORE( 2923): appcore-rotation.c: __changed_cb(121) > [APP 2923] Rotation: 1 -> 1
05-29 21:25:34.942+0900 D/STARTER ( 2891): hw_key.c: _key_release_cb(206) > [_key_release_cb:206] _key_release_cb : XF86PowerOff Released
05-29 21:25:34.942+0900 D/STARTER ( 2891): hw_key.c: _key_release_cb(233) > [_key_release_cb:233] phone lock state, ignore home key.
05-29 21:25:35.142+0900 D/LOCKSCREEN( 8273): lockscreen.c: lockscreen_lcd_off_count_raise(133) > [lockscreen_lcd_off_count_raise:133:D] count for lcd off timer : 0
05-29 21:25:35.142+0900 D/LOCKSCREEN( 8273): default_lock.c: _default_lock_mouse_down_cb(115) > [_default_lock_mouse_down_cb:115:D] clicked x(121), y(865)
05-29 21:25:35.142+0900 D/LOCKSCREEN( 8273): default_lock.c: _default_lock_mouse_down_cb(125) > [_default_lock_mouse_down_cb:125:D] touch upper y : 38
05-29 21:25:35.142+0900 D/LOCKSCREEN( 8273): default_lock.c: _default_lock_mouse_down_cb(137) > [_default_lock_mouse_down_cb:137:D] camera icon : x(559), y(1119), w(124), h(124)
05-29 21:25:35.522+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200dc9 
05-29 21:25:35.522+0900 D/LOCKSCREEN( 8273): default_lock.c: _default_lock_mouse_up_cb(214) > [_default_lock_mouse_up_cb:214:D] exit lockscreen
05-29 21:25:35.552+0900 I/LOCKSCREEN( 8273): lockscreen.c: _lcd_off_timer_cb(98) > [_lcd_off_timer_cb:98:I] lcd off : 10sec
05-29 21:25:35.552+0900 D/LOCKSCREEN( 8273): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496060735) formatted(Mon, May 29)
05-29 21:25:35.552+0900 D/LOCKSCREEN( 8273): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496060735) formatted(9:25)
05-29 21:25:35.552+0900 D/LOCKSCREEN( 8273): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496060735) formatted(PM)
05-29 21:25:36.042+0900 D/LOCKSCREEN( 8273): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:25:36.042+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:25:36.062+0900 D/LOCKSCREEN( 8273): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:25:36.062+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:25:36.062+0900 D/LOCKSCREEN( 8273): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:25:36.062+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:25:36.062+0900 D/LOCKSCREEN( 8273): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:25:36.062+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:25:36.062+0900 D/LOCKSCREEN( 8273): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:25:36.062+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:25:36.062+0900 D/LOCKSCREEN( 8273): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:25:36.062+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:25:36.062+0900 D/LOCKSCREEN( 8273): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:25:36.062+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:25:36.062+0900 D/LOCKSCREEN( 8273): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:25:36.062+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:25:36.062+0900 D/AUL     ( 8273): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
05-29 21:25:36.062+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 22
05-29 21:25:36.062+0900 W/AUL_AMD ( 2837): amd_request.c: __request_handler(1056) > app status : 5
05-29 21:25:36.062+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(456) > pid(8273) status(5)
05-29 21:25:36.062+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(468) > pid(8273) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
05-29 21:25:36.062+0900 D/AUL     ( 2837): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
05-29 21:25:36.062+0900 W/AUL     ( 2837): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8273, appid: org.tizen.lockscreen, status: bg
05-29 21:25:36.062+0900 D/RESOURCED( 2889): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 8273, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
05-29 21:25:36.062+0900 D/RESOURCED( 2889): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 8273, appname = org.tizen.lockscreen
05-29 21:25:36.062+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 8273
05-29 21:25:36.062+0900 D/RESOURCED( 2889): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2921 increase lru 3
05-29 21:25:36.062+0900 D/RESOURCED( 2889): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2921 set score 360 (before 330)
05-29 21:25:36.062+0900 D/RESOURCED( 2889): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
05-29 21:25:36.062+0900 D/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8273, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
05-29 21:25:36.062+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 8273
05-29 21:25:36.062+0900 D/APP_CORE( 8273): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
05-29 21:25:36.062+0900 I/CAPI_APPFW_APPLICATION( 8273): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
05-29 21:25:36.062+0900 D/LOCKSCREEN( 8273): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
05-29 21:25:36.062+0900 D/COM_CORE( 8273): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(41) for pid(-1)
05-29 21:25:36.072+0900 D/COM_CORE( 8273): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
05-29 21:25:36.072+0900 D/COM_CORE( 8273): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
05-29 21:25:36.072+0900 D/COM_CORE( 2982): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
05-29 21:25:36.072+0900 D/DATA_PROVIDER_MASTER( 2982): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb1f00540 is terminated
05-29 21:25:36.072+0900 D/DATA_PROVIDER_MASTER( 2982): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
05-29 21:25:36.122+0900 E/COM_CORE( 8273): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
05-29 21:25:36.122+0900 E/LOCKSCREEN( 8273): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
05-29 21:25:36.122+0900 E/LOCKSCREEN( 8273): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
05-29 21:25:36.122+0900 D/LOCKSCREEN( 8273): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
05-29 21:25:36.122+0900 D/CALL_MGR_CLIENT( 8273): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
05-29 21:25:36.122+0900 D/CALL_MGR_CLIENT( 8273): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
05-29 21:25:36.122+0900 W/CALL_MGR_CLIENT( 8273): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
05-29 21:25:36.122+0900 D/CALL_MGR_CLIENT( 8273): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
05-29 21:25:36.122+0900 D/CALL_MGR_CLIENT( 8273): <LIB:cm_deinit:444> cm_deinit
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
05-29 21:25:36.122+0900 D/SYSTEM-SETTINGS( 8273): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
05-29 21:25:36.122+0900 D/SYSTEM-SETTINGS( 8273): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
05-29 21:25:36.122+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
05-29 21:25:36.122+0900 D/SYSTEM-SETTINGS( 8273): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
05-29 21:25:36.132+0900 D/LOCKSCREEN( 8273): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
05-29 21:25:36.132+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:25:36.132+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
05-29 21:25:36.132+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
05-29 21:25:36.132+0900 D/SYSTEM-SETTINGS( 8273): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
05-29 21:25:36.132+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:25:36.132+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
05-29 21:25:36.132+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8273): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
05-29 21:25:36.132+0900 D/SYSTEM-SETTINGS( 8273): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
05-29 21:25:36.142+0900 D/LOCKSCREEN( 8273): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
05-29 21:25:36.142+0900 E/EFL     ( 8273): eo<8273> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
05-29 21:25:36.142+0900 E/EFL     ( 8273): eo<8273> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
05-29 21:25:36.242+0900 E/E17     ( 2733): e_border.c: e_border_hide(2248) > BD_HIDE(0x01000007), visible:1
05-29 21:25:36.242+0900 E/EFL     ( 2733): eo<2733> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-29 21:25:36.252+0900 E/E17_TZSH( 2733): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b39c85c0, role:118
05-29 21:25:36.292+0900 W/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8280
05-29 21:25:36.302+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
05-29 21:25:36.302+0900 D/INDICATOR( 2919): main.c: _property_changed_cb(432) > UNSNIFF API 1000007
05-29 21:25:36.302+0900 D/INDICATOR( 2919): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-29 21:25:36.322+0900 D/INDICATOR( 2919): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-29 21:25:36.322+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-29 21:25:36.322+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-29 21:25:36.322+0900 D/INDICATOR( 2919): main.c: _rotate_window(252) > port :: hide more icon
05-29 21:25:36.332+0900 E/EFL     ( 2733): eo<2733> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-29 21:25:36.332+0900 I/TZSH    ( 2987): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
05-29 21:25:36.342+0900 D/APP_CORE( 8280): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
05-29 21:25:36.342+0900 D/APP_CORE( 8280): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
05-29 21:25:36.342+0900 D/APP_CORE( 8280): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-29 21:25:36.342+0900 I/APP_CORE( 8280): appcore-efl.c: __do_app(496) > [APP 8280] Event: RESUME State: CREATED
05-29 21:25:36.342+0900 D/LAUNCH  ( 8280): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-29 21:25:36.342+0900 D/APP_CORE( 8280): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-29 21:25:36.342+0900 D/APP_CORE( 8280): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-29 21:25:36.342+0900 D/APP_CORE( 8280): appcore-efl.c: __do_app(607) > [APP 8280] RESUME
05-29 21:25:36.342+0900 I/APP_CORE( 8280): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-29 21:25:36.342+0900 I/APP_CORE( 8280): appcore-efl.c: __do_app(614) > [APP 8280] Initial Launching, call the resume_cb
05-29 21:25:36.342+0900 I/CAPI_APPFW_APPLICATION( 8280): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-29 21:25:36.342+0900 D/LAUNCH  ( 8280): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-29 21:25:36.342+0900 D/LAUNCH  ( 8280): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-29 21:25:36.342+0900 D/APP_CORE( 8280): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-29 21:25:36.342+0900 E/APP_CORE( 8280): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-29 21:25:36.362+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 15
05-29 21:25:36.362+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-29 21:25:36.362+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-29 21:25:36.362+0900 D/AUL_AMD ( 2837): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8280 is org.example.example
05-29 21:25:36.362+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8280 : 0
05-29 21:25:36.362+0900 D/AUL_AMD ( 2837): amd_launch.c: __e17_status_handler(2891) > pid(8280) status(3)
05-29 21:25:36.372+0900 D/AUL_AMD ( 2837): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-29 21:25:36.372+0900 D/AUL     ( 2994): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-29 21:25:36.372+0900 W/AUL_AMD ( 2837): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-29 21:25:36.372+0900 W/AUL_AMD ( 2837): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-29 21:25:36.372+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(456) > pid(8280) status(3)
05-29 21:25:36.372+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(468) > pid(8280) appid(org.example.example) pkgid(org.example.example) status(3)
05-29 21:25:36.372+0900 D/AUL     ( 2837): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-29 21:25:36.372+0900 W/AUL     ( 2837): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8280, appid: org.example.example, status: fg
05-29 21:25:36.372+0900 D/RESOURCED( 2889): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8280
05-29 21:25:36.372+0900 D/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8280, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-29 21:25:36.372+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8280
05-29 21:25:36.402+0900 D/RESOURCED( 2889): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8280, appname = org.example.example, pkgname = org.example.example
05-29 21:25:36.402+0900 D/RESOURCED( 2889): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8280, appname = org.example.example
05-29 21:25:36.402+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8280
05-29 21:25:36.402+0900 I/RESOURCED( 2889): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-29 21:25:36.402+0900 I/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-29 21:25:36.402+0900 D/AUL_PAD ( 2976): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-29 21:25:36.402+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-29 21:25:36.402+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-29 21:25:36.402+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-29 21:25:36.402+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-29 21:25:36.402+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-29 21:25:36.402+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-29 21:25:36.402+0900 I/AUL_PAD ( 2976): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8273 pgid = 8273
05-29 21:25:36.402+0900 I/AUL_PAD ( 2976): sigchild.h: __sigchild_action(142) > dead_pid(8273)
05-29 21:25:36.412+0900 D/AUL_PAD ( 2976): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-29 21:25:36.412+0900 I/AUL_PAD ( 2976): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-29 21:25:36.412+0900 I/AUL_PAD ( 2976): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-29 21:25:36.412+0900 E/AUL_PAD ( 2976): launchpad.c: main(688) > error reading sigchld info
05-29 21:25:36.422+0900 D/STARTER ( 2891): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 8273 is termianted
05-29 21:25:36.422+0900 D/STARTER ( 2891): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
05-29 21:25:36.422+0900 E/STARTER ( 2891): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
05-29 21:25:36.422+0900 D/STARTER ( 2891): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
05-29 21:25:36.422+0900 D/STARTER ( 2891): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
05-29 21:25:36.422+0900 I/ESD     ( 2992): esd_main.c: __esd_app_dead_handler(1771) > pid: 8273
05-29 21:25:36.422+0900 W/STARTER ( 2891): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x1000007 is not transient
05-29 21:25:36.422+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
05-29 21:25:36.422+0900 W/AUL_AMD ( 2837): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 8273
05-29 21:25:36.422+0900 W/AUL_AMD ( 2837): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 8273
05-29 21:25:36.422+0900 D/AUL_AMD ( 2837): amd_key.c: _unregister_key_event(179) > ===key stack===
05-29 21:25:36.422+0900 E/AUL_AMD ( 2837): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-29 21:25:36.422+0900 D/AUL_AMD ( 2837): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
05-29 21:25:36.422+0900 D/AUL     ( 2837): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-29 21:25:36.422+0900 E/AUL     ( 2837): simple_util.c: __trm_app_info_send_socket(330) > access
05-29 21:25:36.432+0900 E/RESOURCED( 2889): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.522
05-29 21:25:36.432+0900 D/RESOURCED( 2889): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 8273
05-29 21:25:36.432+0900 D/RESOURCED( 2889): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
05-29 21:25:36.472+0900 D/VOLUME  ( 2921): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
05-29 21:25:36.782+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200dfb 
05-29 21:25:37.542+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200dfb 
05-29 21:25:37.602+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-29 21:25:37.602+0900 E/EFL     ( 8280): By the power of Grayskull, your previous Embryo stack is now broken!
05-29 21:25:37.872+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.872+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.942+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.952+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.952+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.952+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.962+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.962+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.962+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:37.972+0900 D/IMMODULE( 8280): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-29 21:25:37.972+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:25:37.972+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:25:37.982+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200dfb 
05-29 21:25:37.992+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:25:37.992+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:25:38.052+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:25:38.052+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:25:38.062+0900 D/ISF_QUERY( 8280): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-29 21:25:38.062+0900 D/ISF_QUERY( 8280): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:25:38.062+0900 D/ISF_QUERY( 8280): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:25:38.062+0900 D/ISF_QUERY( 8280): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:25:38.062+0900 D/ISF_QUERY( 8280): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:25:38.062+0900 D/ISF_QUERY( 8280): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:25:38.062+0900 D/ISF_QUERY( 8280): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:25:38.072+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:25:38.072+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:25:38.072+0900 D/IMMODULE( 8280): scim_panel_client.cpp: open_connection(162) > 
05-29 21:25:38.072+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-panel-socket:0, example
05-29 21:25:38.072+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:25:38.082+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-panel-socket:0, example
05-29 21:25:38.082+0900 D/ISF_SOCKET( 8280): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:25:38.092+0900 D/IMMODULE( 8280): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-29 21:25:38.212+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:38.212+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:38.222+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:38.222+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:38.222+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.012+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
05-29 21:25:39.362+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200dfb 
05-29 21:25:39.462+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.472+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.542+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.542+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.542+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.552+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.552+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.552+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:39.552+0900 E/EFL     ( 8280): edje<8280> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:25:41.072+0900 D/AUL_AMD ( 2837): amd_status.c: __app_terminate_timer_cb(442) > pid(8273)
05-29 21:25:41.072+0900 W/AUL_AMD ( 2837): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-29 21:25:41.572+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200dfb 
05-29 21:25:41.842+0900 D/AUL_PAD ( 2976): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-29 21:25:41.842+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-29 21:25:41.842+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-29 21:25:41.842+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-29 21:25:41.842+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-29 21:25:41.842+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-29 21:25:41.842+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-29 21:25:41.842+0900 I/AUL_PAD ( 2976): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8280 pgid = 8280
05-29 21:25:41.842+0900 I/AUL_PAD ( 2976): sigchild.h: __sigchild_action(142) > dead_pid(8280)
05-29 21:25:41.842+0900 E/EFL     ( 2733): eo<2733> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-29 21:25:41.862+0900 W/CRASH_MANAGER( 8478): worker.c: worker_job(1204) > 1108280657861149606074
