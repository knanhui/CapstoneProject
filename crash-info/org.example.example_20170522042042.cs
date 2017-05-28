S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8412
Date: 2017-05-22 04:20:41+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb8418b88, esi = 0x8000aa56
ebp = 0xbfbea8b8, esp = 0xbfbea870
eax = 0x800552ab, ebx = 0xb3823000
ecx = 0x8000aa56, edx = 0x00000110
eip = 0xb381e1c6

Memory Information
MemTotal:      123 KB
MemFree:        29 KB
Buffers:         6 KB
Cached:     166760 KB
VmPeak:     115412 KB
VmSize:     115412 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27436 KB
VmRSS:       27436 KB
VmData:      46828 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       33576 KB
VmPTE:          92 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8412 TID = 8412
8412 8419 8600 8601 8609 

Maps Information
b2cc2000 b2ccc000 r-xp /usr/lib/libfeedback.so.0.1.4
b2cd2000 b2cde000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2cdf000 b2d00000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2d05000 b2d06000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2d07000 b2d0c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2d0d000 b2d0f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2d10000 b2d12000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2d13000 b2d1f000 r-xp /usr/lib/libdrm.so.2.4.0
b2d20000 b2d2a000 r-xp /usr/lib/libtbm.so.1.0.0
b2d2b000 b2d40000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2d41000 b2d53000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3555000 b355e000 r-xp /usr/lib/libeventsystem.so.0.0.1
b355f000 b3568000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3569000 b357b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b357c000 b359d000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b35a4000 b35a5000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35a6000 b35a7000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35a8000 b35ab000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35ac000 b35af000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36b7000 b36bd000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36be000 b3802000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3812000 b3813000 r-xp /usr/lib/libxshmfence.so.1.0.0
b3814000 b3817000 r-xp /usr/lib/libdri2.so.0.0.0
b3818000 b3819000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b381a000 b3822000 r-xp /opt/usr/apps/org.example.example/bin/example
b3824000 b385d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b4260000 b426b000 r-xp /lib/libnss_files-2.20-2014.11.so
b426d000 b4278000 r-xp /lib/libnss_nis-2.20-2014.11.so
b427a000 b4291000 r-xp /lib/libnsl-2.20-2014.11.so
b4295000 b429d000 r-xp /lib/libnss_compat-2.20-2014.11.so
b429f000 b42c3000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42c4000 b42c5000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42c6000 b42c9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42ca000 b42d1000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42d2000 b42dc000 r-xp /usr/lib/libsensord-share.so
b42dd000 b42f9000 r-xp /usr/lib/libsensor.so.1.2.0
b42fb000 b4304000 r-xp /usr/lib/libappcore-common.so.1.1
b4307000 b4309000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b431e000 b4320000 r-xp /usr/lib/libXau.so.6.0.0
b4321000 b4343000 r-xp /usr/lib/libxcb.so.1.1.0
b4345000 b434e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4377000 b4379000 r-xp /usr/lib/libiri.so
b437a000 b43a0000 r-xp /lib/libexpat.so.1.5.2
b43a2000 b440d000 r-xp /usr/lib/libssl.so.1.0.0
b4413000 b441f000 r-xp /usr/lib/libethumb.so.1.13.0
b4420000 b4424000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4425000 b4676000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bf1000 b5c01000 r-xp /usr/lib/libXi.so.6.1.0
b5c02000 b5c04000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c05000 b5c0b000 r-xp /usr/lib/libXtst.so.6.1.0
b5c0c000 b5c16000 r-xp /usr/lib/libXrender.so.1.3.0
b5c17000 b5c20000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c22000 b5c24000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c25000 b5c2a000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c2b000 b5c3d000 r-xp /usr/lib/libXext.so.6.4.0
b5c3e000 b5c40000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c41000 b5c43000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c45000 b5d87000 r-xp /usr/lib/libX11.so.6.3.0
b5d8b000 b5d95000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d96000 b5dac000 r-xp /usr/lib/libudev.so.1.6.0
b5daf000 b5db3000 r-xp /lib/libattr.so.1.1.0
b5db4000 b5de3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5de5000 b5deb000 r-xp /usr/lib/libffi.so.6.0.2
b5dec000 b5e0f000 r-xp /lib/libz.so.1.2.8
b5e10000 b5e13000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e14000 b5f70000 r-xp /usr/lib/libxml2.so.2.9.2
b5f76000 b605d000 r-xp /usr/lib/libstdc++.so.6.0.20
b606a000 b606d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b606e000 b6090000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6091000 b60a5000 r-xp /lib/libresolv-2.20-2014.11.so
b60a9000 b60cd000 r-xp /usr/lib/liblzma.so.5.0.3
b60ce000 b60d0000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60d2000 b60dc000 r-xp /usr/lib/libembryo.so.1.13.0
b60dd000 b6106000 r-xp /usr/lib/libpng12.so.0.50.0
b6107000 b6150000 r-xp /usr/lib/libjpeg.so.8.0.2
b6161000 b6168000 r-xp /lib/librt-2.20-2014.11.so
b616a000 b6189000 r-xp /usr/lib/libector.so.1.13.0
b618c000 b61b9000 r-xp /usr/lib/liblua-5.1.so
b61ba000 b624a000 r-xp /usr/lib/libfreetype.so.6.11.3
b624e000 b628c000 r-xp /usr/lib/libfontconfig.so.1.8.0
b628d000 b62a3000 r-xp /usr/lib/libfribidi.so.0.3.1
b62a4000 b62fd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6300000 b634b000 r-xp /lib/libm-2.20-2014.11.so
b634d000 b635f000 r-xp /usr/lib/libeio.so.1.13.0
b6360000 b6363000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b6364000 b636a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b636b000 b638e000 r-xp /usr/lib/libefreet.so.1.13.0
b6391000 b63bc000 r-xp /usr/lib/libeldbus.so.1.13.0
b63bd000 b63f1000 r-xp /usr/lib/libecore_con.so.1.13.0
b63f3000 b63fc000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63fd000 b6406000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6407000 b641a000 r-xp /usr/lib/libeo.so.1.13.0
b641c000 b642f000 r-xp /usr/lib/libecore_input.so.1.13.0
b6430000 b6437000 r-xp /usr/lib/libecore_file.so.1.13.0
b6438000 b645b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b645c000 b6488000 r-xp /usr/lib/libeet.so.1.13.0
b6491000 b64fc000 r-xp /usr/lib/libeina.so.1.13.0
b64ff000 b6516000 r-xp /usr/lib/libefl.so.1.13.0
b6518000 b667f000 r-xp /usr/lib/libicuuc.so.51.1
b668d000 b6899000 r-xp /usr/lib/libicui18n.so.51.1
b68a1000 b68f0000 r-xp /usr/lib/libecore_x.so.1.13.0
b68f2000 b690c000 r-xp /lib/libgcc_s-4.9.so.1
b690e000 b6912000 r-xp /lib/libcap.so.2.21
b6913000 b6959000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b695a000 b6961000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6963000 b69b5000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69b7000 b6b42000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b47000 b6c15000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c18000 b6c1c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c1d000 b6c2c000 r-xp /usr/lib/libvconf.so.0.2.45
b6c2d000 b6c30000 r-xp /usr/lib/libvasum.so.0.3.1
b6c31000 b6c34000 r-xp /usr/lib/libttrace.so.1.1
b6c36000 b6c3a000 r-xp /usr/lib/libiniparser.so.0
b6c3b000 b6c6b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c6c000 b6c75000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c76000 b6c9b000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c9c000 b6cac000 r-xp /usr/lib/libunwind.so.8.0.1
b6cb6000 b6e64000 r-xp /lib/libc-2.20-2014.11.so
b6e6c000 b6faf000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fb1000 b7009000 r-xp /usr/lib/libdbus-1.so.3.8.11
b700a000 b703e000 r-xp /usr/lib/libsystemd.so.0.4.0
b7041000 b7115000 r-xp /usr/lib/libedje.so.1.13.0
b7118000 b7144000 r-xp /usr/lib/libecore.so.1.13.0
b7155000 b737b000 r-xp /usr/lib/libevas.so.1.13.0
b73a3000 b73bb000 r-xp /lib/libpthread-2.20-2014.11.so
b73bf000 b7739000 r-xp /usr/lib/libelementary.so.1.13.0
b7759000 b775d000 r-xp /usr/lib/libsmack.so.1.0.0
b775e000 b7767000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7768000 b776b000 r-xp /usr/lib/libdlog.so.0.0.0
b776c000 b7771000 r-xp /usr/lib/libbundle.so.0.1.22
b7772000 b7775000 r-xp /lib/libdl-2.20-2014.11.so
b7777000 b779c000 r-xp /usr/lib/libaul.so.0.1.0
b779f000 b77a1000 r-xp /usr/lib/libappsvc.so.0.1.0
b77a2000 b77a7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77a8000 b77af000 r-xp /usr/lib/libappcore-efl.so.1.1
b77b1000 b77b6000 r-xp /usr/lib/libsys-assert.so
b77b9000 b77ba000 r-xp [vdso]
b77ba000 b77dc000 r-xp /lib/ld-2.20-2014.11.so
b77de000 b77e6000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8412)
Call Stack Count: 21
 0: make_popup_time + 0x46 (0xb381e1c6) [/opt/usr/apps/org.example.example/bin/example] + 0x41c6
 1: (0xb71de116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb6415319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb6412d63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb71e09e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb7491404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb70c4f39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb70cba11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb70c5fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70c64cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb70c668f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb712b702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb7125055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb712e1b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb712e587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb758722d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb77abdde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb77a4c80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb381ec0e) [/opt/usr/apps/org.example.example/bin/example] + 0x4c0e
19: time2string + 0x68 (0xb77e0148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77e0148
20: __libc_start_main + 0xde (0xb6ccde4e) [/lib/libc.so.6] + 0x17e4e
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
it(799) > ui_app_exit
05-22 04:20:37.769+0900 D/LOCKSCREEN( 8403): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-22 04:20:37.769+0900 I/CAPI_APPFW_APPLICATION( 8403): app_main.c: ui_app_exit(799) > ui_app_exit
05-22 04:20:37.769+0900 D/LOCKSCREEN( 8403): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-22 04:20:37.769+0900 I/CAPI_APPFW_APPLICATION( 8403): app_main.c: ui_app_exit(799) > ui_app_exit
05-22 04:20:37.769+0900 D/LOCKSCREEN( 8403): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-22 04:20:37.769+0900 I/CAPI_APPFW_APPLICATION( 8403): app_main.c: ui_app_exit(799) > ui_app_exit
05-22 04:20:37.769+0900 D/LOCKSCREEN( 8403): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-22 04:20:37.769+0900 I/CAPI_APPFW_APPLICATION( 8403): app_main.c: ui_app_exit(799) > ui_app_exit
05-22 04:20:37.769+0900 D/LOCKSCREEN( 8403): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-22 04:20:37.769+0900 I/CAPI_APPFW_APPLICATION( 8403): app_main.c: ui_app_exit(799) > ui_app_exit
05-22 04:20:37.769+0900 D/AUL     ( 8403): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
05-22 04:20:37.769+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 22
05-22 04:20:37.769+0900 W/AUL_AMD ( 2774): amd_request.c: __request_handler(1056) > app status : 5
05-22 04:20:37.769+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(8403) status(5)
05-22 04:20:37.769+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(8403) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
05-22 04:20:37.769+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
05-22 04:20:37.769+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8403, appid: org.tizen.lockscreen, status: bg
05-22 04:20:37.769+0900 D/APP_CORE( 8403): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
05-22 04:20:37.769+0900 I/CAPI_APPFW_APPLICATION( 8403): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
05-22 04:20:37.769+0900 D/LOCKSCREEN( 8403): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
05-22 04:20:37.769+0900 D/RESOURCED( 2878): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 8403, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
05-22 04:20:37.769+0900 D/RESOURCED( 2878): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 8403, appname = org.tizen.lockscreen
05-22 04:20:37.769+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 8403
05-22 04:20:37.769+0900 D/RESOURCED( 2878): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 8412 set score 330 (before 300)
05-22 04:20:37.769+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8412, proc_name: org.example.example, cg_name: background, oom_score_adj: 330
05-22 04:20:37.769+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/background//cgroup.procs, value 8412
05-22 04:20:37.779+0900 D/COM_CORE( 8403): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(41) for pid(-1)
05-22 04:20:37.779+0900 D/COM_CORE( 8403): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
05-22 04:20:37.779+0900 D/COM_CORE( 8403): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
05-22 04:20:37.779+0900 E/COM_CORE( 8403): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
05-22 04:20:37.779+0900 E/LOCKSCREEN( 8403): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
05-22 04:20:37.779+0900 E/LOCKSCREEN( 8403): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
05-22 04:20:37.779+0900 D/LOCKSCREEN( 8403): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
05-22 04:20:37.779+0900 D/CALL_MGR_CLIENT( 8403): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
05-22 04:20:37.779+0900 D/CALL_MGR_CLIENT( 8403): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
05-22 04:20:37.779+0900 W/CALL_MGR_CLIENT( 8403): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
05-22 04:20:37.779+0900 D/CALL_MGR_CLIENT( 8403): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
05-22 04:20:37.779+0900 D/CALL_MGR_CLIENT( 8403): <LIB:cm_deinit:444> cm_deinit
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
05-22 04:20:37.779+0900 D/SYSTEM-SETTINGS( 8403): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
05-22 04:20:37.779+0900 D/SYSTEM-SETTINGS( 8403): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
05-22 04:20:37.779+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
05-22 04:20:37.779+0900 D/SYSTEM-SETTINGS( 8403): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
05-22 04:20:37.789+0900 D/COM_CORE( 2965): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
05-22 04:20:37.789+0900 D/DATA_PROVIDER_MASTER( 2965): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb0400468 is terminated
05-22 04:20:37.789+0900 D/DATA_PROVIDER_MASTER( 2965): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
05-22 04:20:37.789+0900 D/LOCKSCREEN( 8403): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
05-22 04:20:37.789+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-22 04:20:37.789+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
05-22 04:20:37.789+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
05-22 04:20:37.789+0900 D/SYSTEM-SETTINGS( 8403): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
05-22 04:20:37.789+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-22 04:20:37.789+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
05-22 04:20:37.789+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8403): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
05-22 04:20:37.789+0900 D/SYSTEM-SETTINGS( 8403): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
05-22 04:20:37.799+0900 D/RESOURCED( 2878): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2918 increase lru 4
05-22 04:20:37.799+0900 D/RESOURCED( 2878): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2918 set score 390 (before 360)
05-22 04:20:37.799+0900 D/RESOURCED( 2878): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
05-22 04:20:37.799+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8403, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
05-22 04:20:37.799+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 8403
05-22 04:20:37.809+0900 D/LOCKSCREEN( 8403): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
05-22 04:20:37.809+0900 E/EFL     ( 8403): eo<8403> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
05-22 04:20:37.809+0900 E/EFL     ( 8403): eo<8403> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
05-22 04:20:38.019+0900 E/E17     ( 2775): e_border.c: e_border_hide(2248) > BD_HIDE(0x02a00007), visible:1
05-22 04:20:38.019+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 04:20:38.039+0900 E/E17_TZSH( 2775): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b39595c0, role:118
05-22 04:20:38.049+0900 D/AUL_PAD ( 2961): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-22 04:20:38.059+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-22 04:20:38.059+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-22 04:20:38.059+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-22 04:20:38.059+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-22 04:20:38.059+0900 D/AUL_PAD ( 2961): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-22 04:20:38.059+0900 D/AUL_PAD ( 2961): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-22 04:20:38.059+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8403 pgid = 8403
05-22 04:20:38.059+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(142) > dead_pid(8403)
05-22 04:20:38.069+0900 W/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8412
05-22 04:20:38.079+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
05-22 04:20:38.079+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(169) > [PROCESSMGR] delete anr_confirm_timer!
05-22 04:20:38.089+0900 D/INDICATOR( 2882): main.c: _property_changed_cb(432) > UNSNIFF API 2a00007
05-22 04:20:38.089+0900 D/AUL_PAD ( 2961): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-22 04:20:38.089+0900 I/AUL_PAD ( 2961): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-22 04:20:38.089+0900 I/AUL_PAD ( 2961): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-22 04:20:38.089+0900 E/AUL_PAD ( 2961): launchpad.c: main(688) > error reading sigchld info
05-22 04:20:38.089+0900 D/INDICATOR( 2882): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-22 04:20:38.089+0900 I/ESD     ( 2998): esd_main.c: __esd_app_dead_handler(1771) > pid: 8403
05-22 04:20:38.089+0900 W/AUL_AMD ( 2774): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 8403
05-22 04:20:38.089+0900 W/AUL_AMD ( 2774): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 8403
05-22 04:20:38.089+0900 D/AUL_AMD ( 2774): amd_key.c: _unregister_key_event(179) > ===key stack===
05-22 04:20:38.089+0900 E/AUL_AMD ( 2774): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-22 04:20:38.089+0900 D/AUL_AMD ( 2774): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
05-22 04:20:38.089+0900 D/AUL     ( 2774): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-22 04:20:38.089+0900 E/AUL     ( 2774): simple_util.c: __trm_app_info_send_socket(330) > access
05-22 04:20:38.089+0900 D/STARTER ( 2875): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 8403 is termianted
05-22 04:20:38.089+0900 D/STARTER ( 2875): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
05-22 04:20:38.089+0900 E/STARTER ( 2875): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
05-22 04:20:38.089+0900 D/STARTER ( 2875): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
05-22 04:20:38.089+0900 D/STARTER ( 2875): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
05-22 04:20:38.089+0900 W/STARTER ( 2875): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x2a00007 is not transient
05-22 04:20:38.089+0900 E/RESOURCED( 2878): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.542
05-22 04:20:38.099+0900 D/RESOURCED( 2878): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 8403
05-22 04:20:38.099+0900 D/RESOURCED( 2878): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
05-22 04:20:38.099+0900 D/INDICATOR( 2882): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-22 04:20:38.099+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-22 04:20:38.099+0900 D/INDICATOR( 2882): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-22 04:20:38.099+0900 D/INDICATOR( 2882): main.c: _rotate_window(252) > port :: hide more icon
05-22 04:20:38.119+0900 E/EFL     ( 2775): eo<2775> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-22 04:20:38.119+0900 I/TZSH    ( 2975): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
05-22 04:20:38.129+0900 D/VOLUME  ( 2918): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
05-22 04:20:38.139+0900 D/APP_CORE( 8412): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2c00002 fully_obscured 0
05-22 04:20:38.139+0900 D/APP_CORE( 8412): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
05-22 04:20:38.139+0900 D/APP_CORE( 8412): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-22 04:20:38.139+0900 I/APP_CORE( 8412): appcore-efl.c: __do_app(496) > [APP 8412] Event: RESUME State: CREATED
05-22 04:20:38.139+0900 D/LAUNCH  ( 8412): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-22 04:20:38.139+0900 D/APP_CORE( 8412): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-22 04:20:38.139+0900 D/APP_CORE( 8412): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-22 04:20:38.139+0900 D/APP_CORE( 8412): appcore-efl.c: __do_app(607) > [APP 8412] RESUME
05-22 04:20:38.139+0900 I/APP_CORE( 8412): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-22 04:20:38.139+0900 I/APP_CORE( 8412): appcore-efl.c: __do_app(614) > [APP 8412] Initial Launching, call the resume_cb
05-22 04:20:38.139+0900 I/CAPI_APPFW_APPLICATION( 8412): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-22 04:20:38.139+0900 D/LAUNCH  ( 8412): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-22 04:20:38.139+0900 D/LAUNCH  ( 8412): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-22 04:20:38.139+0900 D/APP_CORE( 8412): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-22 04:20:38.139+0900 E/APP_CORE( 8412): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-22 04:20:38.139+0900 D/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2891) > pid(8412) status(3)
05-22 04:20:38.139+0900 D/AUL_AMD ( 2774): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 800002
05-22 04:20:38.139+0900 W/AUL_AMD ( 2774): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-22 04:20:38.139+0900 W/AUL_AMD ( 2774): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-22 04:20:38.139+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(456) > pid(8412) status(3)
05-22 04:20:38.139+0900 D/AUL_AMD ( 2774): amd_status.c: _status_update_app_info_list(468) > pid(8412) appid(org.example.example) pkgid(org.example.example) status(3)
05-22 04:20:38.139+0900 D/AUL     ( 2774): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-22 04:20:38.139+0900 W/AUL     ( 2774): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8412, appid: org.example.example, status: fg
05-22 04:20:38.139+0900 D/RESOURCED( 2878): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8412
05-22 04:20:38.139+0900 D/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8412, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-22 04:20:38.139+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8412
05-22 04:20:38.149+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(838) > __request_handler: 15
05-22 04:20:38.159+0900 D/PKGMGR_INFO( 2774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 04:20:38.159+0900 D/PKGMGR_INFO( 2774): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-22 04:20:38.159+0900 D/AUL_AMD ( 2774): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8412 is org.example.example
05-22 04:20:38.159+0900 D/AUL_AMD ( 2774): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8412 : 0
05-22 04:20:38.159+0900 D/AUL     ( 3004): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-22 04:20:38.159+0900 D/INDICATOR( 2882): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
05-22 04:20:38.209+0900 D/RESOURCED( 2878): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8412, appname = org.example.example, pkgname = org.example.example
05-22 04:20:38.209+0900 D/RESOURCED( 2878): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8412, appname = org.example.example
05-22 04:20:38.209+0900 D/RESOURCED( 2878): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8412
05-22 04:20:38.209+0900 I/RESOURCED( 2878): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-22 04:20:38.209+0900 I/RESOURCED( 2878): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.229+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.239+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.249+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.259+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400d74 
05-22 04:20:39.259+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.259+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.259+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.259+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.259+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.269+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.269+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:39.269+0900 E/EFL     ( 8412): evas_main<8412> lib/evas/canvas/evas_object_smart.c:877 _evas_object_smart_need_recalculate_set() Object 0x800387c4 is not stable during recalc loop
05-22 04:20:40.259+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2c00002
05-22 04:20:41.769+0900 D/PROCESSMGR( 2775): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x40002f  register trigger_timer!  pointed_win=0x400d74 
05-22 04:20:42.069+0900 W/CRASH_MANAGER( 8610): worker.c: worker_job(1204) > 1108412657861149539444
