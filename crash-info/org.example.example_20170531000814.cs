S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 9460
Date: 2017-05-31 00:08:13+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xffffff8c

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xfbad8001, esi = 0xb7760f84
ebp = 0xbf9a8d88, esp = 0xbf9a8848
eax = 0xffffff8c, ebx = 0xb6de4000
ecx = 0x00002525, edx = 0x25252525
eip = 0xb6caea13

Memory Information
MemTotal:      123 KB
MemFree:        19 KB
Buffers:         4 KB
Cached:     193832 KB
VmPeak:     123344 KB
VmSize:     123344 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       35204 KB
VmRSS:       35204 KB
VmData:      53444 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34624 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 9460 TID = 9460
9460 9461 9649 9650 9669 

Maps Information
b0b3e000 b0b45000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b0b48000 b0b60000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1801000 b1808000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1885000 b1889000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b5e000 b2b68000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b6e000 b2b7a000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b7b000 b2b9c000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2ba1000 b2ba2000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2ba3000 b2ba8000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2ba9000 b2baa000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bab000 b2bad000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bae000 b2bb0000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bb1000 b2bbd000 r-xp /usr/lib/libdrm.so.2.4.0
b2bbe000 b2bc8000 r-xp /usr/lib/libtbm.so.1.0.0
b2bc9000 b2bde000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2bdf000 b2bf1000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33f3000 b3424000 r-xp /usr/lib/libidn.so.11.5.44
b3425000 b3447000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3448000 b3458000 r-xp /usr/lib/libcares.so.2.1.0
b3459000 b3462000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3463000 b346c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b346d000 b34e4000 r-xp /usr/lib/libcurl.so.4.3.0
b34e6000 b34f8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34f9000 b351a000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b3521000 b3522000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3523000 b3524000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3525000 b3528000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3529000 b352c000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3634000 b363a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b363b000 b377f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b378f000 b3792000 r-xp /usr/lib/libdri2.so.0.0.0
b3793000 b3794000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3795000 b379f000 r-xp /opt/usr/apps/org.example.example/bin/example
b37a1000 b37da000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b41dd000 b41e8000 r-xp /lib/libnss_files-2.20-2014.11.so
b41ea000 b41f5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41f7000 b420e000 r-xp /lib/libnsl-2.20-2014.11.so
b4212000 b421a000 r-xp /lib/libnss_compat-2.20-2014.11.so
b421c000 b4240000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b4241000 b4242000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4243000 b4246000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4247000 b424e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b424f000 b4259000 r-xp /usr/lib/libsensord-share.so
b425a000 b4276000 r-xp /usr/lib/libsensor.so.1.2.0
b4278000 b4281000 r-xp /usr/lib/libappcore-common.so.1.1
b4284000 b4286000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b429b000 b429d000 r-xp /usr/lib/libXau.so.6.0.0
b429e000 b42c0000 r-xp /usr/lib/libxcb.so.1.1.0
b42c2000 b42cb000 r-xp /lib/libcrypt-2.20-2014.11.so
b42f4000 b42f6000 r-xp /usr/lib/libiri.so
b42f7000 b431d000 r-xp /lib/libexpat.so.1.5.2
b431f000 b438a000 r-xp /usr/lib/libssl.so.1.0.0
b4390000 b439c000 r-xp /usr/lib/libethumb.so.1.13.0
b439d000 b43a1000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43a2000 b45f3000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b6e000 b5b7e000 r-xp /usr/lib/libXi.so.6.1.0
b5b7f000 b5b81000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b82000 b5b88000 r-xp /usr/lib/libXtst.so.6.1.0
b5b89000 b5b93000 r-xp /usr/lib/libXrender.so.1.3.0
b5b94000 b5b9d000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b9f000 b5ba1000 r-xp /usr/lib/libXinerama.so.1.0.0
b5ba2000 b5ba7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5ba8000 b5bba000 r-xp /usr/lib/libXext.so.6.4.0
b5bbb000 b5bbd000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bbe000 b5bc0000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bc2000 b5d04000 r-xp /usr/lib/libX11.so.6.3.0
b5d08000 b5d12000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d13000 b5d29000 r-xp /usr/lib/libudev.so.1.6.0
b5d2c000 b5d30000 r-xp /lib/libattr.so.1.1.0
b5d31000 b5d60000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d62000 b5d68000 r-xp /usr/lib/libffi.so.6.0.2
b5d69000 b5d8c000 r-xp /lib/libz.so.1.2.8
b5d8d000 b5d90000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d91000 b5eed000 r-xp /usr/lib/libxml2.so.2.9.2
b5ef3000 b5fda000 r-xp /usr/lib/libstdc++.so.6.0.20
b5fe7000 b5fea000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5feb000 b600d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b600e000 b6022000 r-xp /lib/libresolv-2.20-2014.11.so
b6026000 b604a000 r-xp /usr/lib/liblzma.so.5.0.3
b604b000 b604d000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b604f000 b6059000 r-xp /usr/lib/libembryo.so.1.13.0
b605a000 b6083000 r-xp /usr/lib/libpng12.so.0.50.0
b6084000 b60cd000 r-xp /usr/lib/libjpeg.so.8.0.2
b60de000 b60e5000 r-xp /lib/librt-2.20-2014.11.so
b60e7000 b6106000 r-xp /usr/lib/libector.so.1.13.0
b6109000 b6136000 r-xp /usr/lib/liblua-5.1.so
b6137000 b61c7000 r-xp /usr/lib/libfreetype.so.6.11.3
b61cb000 b6209000 r-xp /usr/lib/libfontconfig.so.1.8.0
b620a000 b6220000 r-xp /usr/lib/libfribidi.so.0.3.1
b6221000 b627a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b627d000 b62c8000 r-xp /lib/libm-2.20-2014.11.so
b62ca000 b62dc000 r-xp /usr/lib/libeio.so.1.13.0
b62dd000 b62e0000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b62e1000 b62e7000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b62e8000 b630b000 r-xp /usr/lib/libefreet.so.1.13.0
b630e000 b6339000 r-xp /usr/lib/libeldbus.so.1.13.0
b633a000 b636e000 r-xp /usr/lib/libecore_con.so.1.13.0
b6370000 b6379000 r-xp /usr/lib/libecore_imf.so.1.13.0
b637a000 b6383000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6384000 b6397000 r-xp /usr/lib/libeo.so.1.13.0
b6399000 b63ac000 r-xp /usr/lib/libecore_input.so.1.13.0
b63ad000 b63b4000 r-xp /usr/lib/libecore_file.so.1.13.0
b63b5000 b63d8000 r-xp /usr/lib/libecore_evas.so.1.13.0
b63d9000 b6405000 r-xp /usr/lib/libeet.so.1.13.0
b640e000 b6479000 r-xp /usr/lib/libeina.so.1.13.0
b647c000 b6493000 r-xp /usr/lib/libefl.so.1.13.0
b6495000 b65fc000 r-xp /usr/lib/libicuuc.so.51.1
b660a000 b6816000 r-xp /usr/lib/libicui18n.so.51.1
b681e000 b686d000 r-xp /usr/lib/libecore_x.so.1.13.0
b686f000 b6889000 r-xp /lib/libgcc_s-4.9.so.1
b688b000 b688f000 r-xp /lib/libcap.so.2.21
b6890000 b68d6000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b68d7000 b68de000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b68e0000 b6932000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6934000 b6abf000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6ac4000 b6b92000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b95000 b6b99000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b9a000 b6ba9000 r-xp /usr/lib/libvconf.so.0.2.45
b6baa000 b6bad000 r-xp /usr/lib/libvasum.so.0.3.1
b6bae000 b6bb1000 r-xp /usr/lib/libttrace.so.1.1
b6bb3000 b6bb7000 r-xp /usr/lib/libiniparser.so.0
b6bb8000 b6be8000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6be9000 b6bf2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bf3000 b6c18000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c19000 b6c29000 r-xp /usr/lib/libunwind.so.8.0.1
b6c33000 b6de1000 r-xp /lib/libc-2.20-2014.11.so
b6de9000 b6f2c000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f2e000 b6f86000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f87000 b6fbb000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fbe000 b7092000 r-xp /usr/lib/libedje.so.1.13.0
b7095000 b70c1000 r-xp /usr/lib/libecore.so.1.13.0
b70d2000 b72f8000 r-xp /usr/lib/libevas.so.1.13.0
b7320000 b7338000 r-xp /lib/libpthread-2.20-2014.11.so
b733c000 b76b6000 r-xp /usr/lib/libelementary.so.1.13.0
b76d6000 b76da000 r-xp /usr/lib/libsmack.so.1.0.0
b76db000 b76e4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76e5000 b76e8000 r-xp /usr/lib/libdlog.so.0.0.0
b76e9000 b76ee000 r-xp /usr/lib/libbundle.so.0.1.22
b76ef000 b76f2000 r-xp /lib/libdl-2.20-2014.11.so
b76f4000 b7719000 r-xp /usr/lib/libaul.so.0.1.0
b771c000 b771e000 r-xp /usr/lib/libappsvc.so.0.1.0
b771f000 b7724000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7725000 b772c000 r-xp /usr/lib/libappcore-efl.so.1.1
b772e000 b7733000 r-xp /usr/lib/libsys-assert.so
b7736000 b7737000 r-xp [vdso]
b7737000 b7759000 r-xp /lib/ld-2.20-2014.11.so
b775b000 b7763000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:9460)
Call Stack Count: 3
 0: strchrnul + 0x63 (0xb6caea13) [/lib/libc.so.6] + 0x7ba13
 1: __vsnprintf_chk + 0xac (0xb6d287ac) [/lib/libc.so.6] + 0xf57ac
 2: (0xb75b57e0) [/usr/lib/libelementary.so.1] + 0x2797e0
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
> [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-31 00:05:21.716+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: ui_app_exit(799) > ui_app_exit
05-31 00:05:21.766+0900 D/LOCKSCREEN( 9652): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-31 00:05:21.786+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: ui_app_exit(799) > ui_app_exit
05-31 00:05:21.786+0900 D/LOCKSCREEN( 9652): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-31 00:05:21.786+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: ui_app_exit(799) > ui_app_exit
05-31 00:05:21.786+0900 D/LOCKSCREEN( 9652): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-31 00:05:21.786+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: ui_app_exit(799) > ui_app_exit
05-31 00:05:21.786+0900 D/LOCKSCREEN( 9652): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-31 00:05:21.786+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: ui_app_exit(799) > ui_app_exit
05-31 00:05:21.786+0900 D/LOCKSCREEN( 9652): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-31 00:05:21.786+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: ui_app_exit(799) > ui_app_exit
05-31 00:05:21.786+0900 D/LOCKSCREEN( 9652): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-31 00:05:21.786+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: ui_app_exit(799) > ui_app_exit
05-31 00:05:21.786+0900 D/LOCKSCREEN( 9652): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-31 00:05:21.786+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: ui_app_exit(799) > ui_app_exit
05-31 00:05:21.796+0900 D/AUL     ( 9652): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
05-31 00:05:21.796+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 22
05-31 00:05:21.796+0900 W/AUL_AMD ( 2787): amd_request.c: __request_handler(1056) > app status : 5
05-31 00:05:21.796+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(9652) status(5)
05-31 00:05:21.796+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(9652) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
05-31 00:05:21.796+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
05-31 00:05:21.796+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 9652, appid: org.tizen.lockscreen, status: bg
05-31 00:05:21.806+0900 D/RESOURCED( 2880): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 9652, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
05-31 00:05:21.816+0900 D/RESOURCED( 2880): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 9652, appname = org.tizen.lockscreen
05-31 00:05:21.836+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 9652
05-31 00:05:21.836+0900 D/RESOURCED( 2880): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
05-31 00:05:21.836+0900 D/RESOURCED( 2880): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 9652, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
05-31 00:05:21.836+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 9652
05-31 00:05:21.856+0900 D/APP_CORE( 9652): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
05-31 00:05:21.856+0900 I/CAPI_APPFW_APPLICATION( 9652): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
05-31 00:05:21.856+0900 D/LOCKSCREEN( 9652): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
05-31 00:05:21.996+0900 D/COM_CORE( 9652): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(41) for pid(-1)
05-31 00:05:22.006+0900 D/COM_CORE( 9652): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
05-31 00:05:22.006+0900 D/COM_CORE( 9652): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
05-31 00:05:22.006+0900 D/COM_CORE( 2957): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
05-31 00:05:22.006+0900 E/COM_CORE( 9652): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
05-31 00:05:22.006+0900 E/LOCKSCREEN( 9652): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
05-31 00:05:22.006+0900 E/LOCKSCREEN( 9652): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
05-31 00:05:22.026+0900 D/DATA_PROVIDER_MASTER( 2957): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb2a16500 is terminated
05-31 00:05:22.026+0900 D/DATA_PROVIDER_MASTER( 2957): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
05-31 00:05:22.046+0900 D/LOCKSCREEN( 9652): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
05-31 00:05:22.056+0900 D/CALL_MGR_CLIENT( 9652): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
05-31 00:05:22.066+0900 D/CALL_MGR_CLIENT( 9652): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
05-31 00:05:22.076+0900 W/CALL_MGR_CLIENT( 9652): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
05-31 00:05:22.086+0900 D/CALL_MGR_CLIENT( 9652): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
05-31 00:05:22.086+0900 D/CALL_MGR_CLIENT( 9652): <LIB:cm_deinit:444> cm_deinit
05-31 00:05:22.106+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-31 00:05:22.106+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
05-31 00:05:22.106+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
05-31 00:05:22.116+0900 D/SYSTEM-SETTINGS( 9652): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
05-31 00:05:22.116+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-31 00:05:22.116+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
05-31 00:05:22.116+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
05-31 00:05:22.116+0900 D/SYSTEM-SETTINGS( 9652): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
05-31 00:05:22.116+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-31 00:05:22.116+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
05-31 00:05:22.116+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
05-31 00:05:22.116+0900 D/SYSTEM-SETTINGS( 9652): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
05-31 00:05:22.226+0900 D/LOCKSCREEN( 9652): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
05-31 00:05:22.246+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-31 00:05:22.256+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
05-31 00:05:22.266+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
05-31 00:05:22.266+0900 D/SYSTEM-SETTINGS( 9652): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
05-31 00:05:22.286+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-31 00:05:22.306+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
05-31 00:05:22.306+0900 E/TIZEN_N_SYSTEM_SETTINGS( 9652): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
05-31 00:05:22.306+0900 D/SYSTEM-SETTINGS( 9652): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
05-31 00:05:22.386+0900 D/LOCKSCREEN( 9652): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
05-31 00:05:22.396+0900 E/EFL     ( 9652): eo<9652> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
05-31 00:05:22.396+0900 E/EFL     ( 9652): eo<9652> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
05-31 00:05:22.926+0900 E/E17     ( 2739): e_border.c: e_border_hide(2248) > BD_HIDE(0x02c00007), visible:1
05-31 00:05:22.926+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 00:05:23.016+0900 E/EFL     ( 2739): <2739> e_mod_processmgr.c:481 _e_mod_processmgr_anr_ping() safety check failed: bd == NULL
05-31 00:05:23.026+0900 E/E17_TZSH( 2739): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b391d5c0, role:118
05-31 00:05:23.146+0900 W/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9460
05-31 00:05:23.166+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
05-31 00:05:23.196+0900 D/INDICATOR( 2886): main.c: _property_changed_cb(432) > UNSNIFF API 2c00007
05-31 00:05:23.196+0900 D/INDICATOR( 2886): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-31 00:05:23.196+0900 D/INDICATOR( 2886): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-31 00:05:23.196+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-31 00:05:23.196+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-31 00:05:23.196+0900 D/INDICATOR( 2886): main.c: _rotate_window(252) > port :: hide more icon
05-31 00:05:23.346+0900 I/TZSH    ( 2965): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
05-31 00:05:23.356+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-31 00:05:23.476+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 15
05-31 00:05:23.476+0900 D/APP_CORE( 9460): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2000002 fully_obscured 0
05-31 00:05:23.476+0900 D/APP_CORE( 9460): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
05-31 00:05:23.476+0900 D/APP_CORE( 9460): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-31 00:05:23.476+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-31 00:05:23.476+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-31 00:05:23.476+0900 I/APP_CORE( 9460): appcore-efl.c: __do_app(496) > [APP 9460] Event: RESUME State: PAUSED
05-31 00:05:23.476+0900 D/LAUNCH  ( 9460): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-31 00:05:23.476+0900 D/APP_CORE( 9460): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-31 00:05:23.476+0900 D/APP_CORE( 9460): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-31 00:05:23.476+0900 D/APP_CORE( 9460): appcore-efl.c: __do_app(607) > [APP 9460] RESUME
05-31 00:05:23.476+0900 I/CAPI_APPFW_APPLICATION( 9460): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-31 00:05:23.476+0900 D/LAUNCH  ( 9460): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-31 00:05:23.476+0900 D/LAUNCH  ( 9460): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-31 00:05:23.476+0900 D/APP_CORE( 9460): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-31 00:05:23.476+0900 E/APP_CORE( 9460): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-31 00:05:23.516+0900 D/AUL_AMD ( 2787): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 9460 is org.example.example
05-31 00:05:23.516+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 9460 : 0
05-31 00:05:23.516+0900 D/AUL     ( 2969): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-31 00:05:23.596+0900 D/AUL_PAD ( 2955): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-31 00:05:23.596+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-31 00:05:23.596+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-31 00:05:23.596+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-31 00:05:23.596+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-31 00:05:23.596+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-31 00:05:23.596+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-31 00:05:23.596+0900 I/AUL_PAD ( 2955): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 9652 pgid = 9652
05-31 00:05:23.596+0900 I/AUL_PAD ( 2955): sigchild.h: __sigchild_action(142) > dead_pid(9652)
05-31 00:05:23.806+0900 D/AUL_PAD ( 2955): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-31 00:05:23.806+0900 I/AUL_PAD ( 2955): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-31 00:05:23.806+0900 I/AUL_PAD ( 2955): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-31 00:05:23.806+0900 E/AUL_PAD ( 2955): launchpad.c: main(688) > error reading sigchld info
05-31 00:05:23.816+0900 I/ESD     ( 2967): esd_main.c: __esd_app_dead_handler(1771) > pid: 9652
05-31 00:05:23.816+0900 W/AUL_AMD ( 2787): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 9652
05-31 00:05:23.816+0900 W/AUL_AMD ( 2787): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 9652
05-31 00:05:23.816+0900 D/AUL_AMD ( 2787): amd_key.c: _unregister_key_event(179) > ===key stack===
05-31 00:05:23.816+0900 E/AUL_AMD ( 2787): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-31 00:05:23.816+0900 D/AUL_AMD ( 2787): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
05-31 00:05:23.816+0900 D/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-31 00:05:23.816+0900 E/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(330) > access
05-31 00:05:23.826+0900 D/STARTER ( 2876): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 9652 is termianted
05-31 00:05:23.826+0900 D/STARTER ( 2876): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
05-31 00:05:23.826+0900 E/STARTER ( 2876): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
05-31 00:05:23.826+0900 D/STARTER ( 2876): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
05-31 00:05:23.826+0900 D/STARTER ( 2876): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
05-31 00:05:23.826+0900 D/INDICATOR( 2886): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
05-31 00:05:23.846+0900 D/VOLUME  ( 2929): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
05-31 00:05:23.886+0900 W/STARTER ( 2876): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x2c00007 is not transient
05-31 00:05:24.056+0900 E/RESOURCED( 2880): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.706
05-31 00:05:24.076+0900 D/RESOURCED( 2880): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 9652
05-31 00:05:24.076+0900 D/RESOURCED( 2880): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
05-31 00:05:24.136+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:05:25.216+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-31 00:05:26.806+0900 D/AUL_AMD ( 2787): amd_status.c: __app_terminate_timer_cb(442) > pid(9652)
05-31 00:05:26.806+0900 W/AUL_AMD ( 2787): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-31 00:05:27.296+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:05:28.626+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:05:29.986+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:30.056+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:30.226+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60171f bd->visible=1
05-31 00:05:31.586+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:31.666+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:31.686+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:31.756+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:31.816+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:31.856+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:31.936+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:32.216+0900 D/IMMODULE( 9460): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-31 00:05:32.216+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 00:05:32.226+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(524) > connect() succeeded
05-31 00:05:32.516+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 00:05:32.516+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(524) > connect() succeeded
05-31 00:05:33.066+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 00:05:33.066+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(524) > connect() succeeded
05-31 00:05:33.166+0900 D/ISF_QUERY( 9460): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-31 00:05:33.166+0900 D/ISF_QUERY( 9460): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 00:05:33.166+0900 D/ISF_QUERY( 9460): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 00:05:33.166+0900 D/ISF_QUERY( 9460): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 00:05:33.166+0900 D/ISF_QUERY( 9460): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 00:05:33.166+0900 D/ISF_QUERY( 9460): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 00:05:33.166+0900 D/ISF_QUERY( 9460): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-31 00:05:33.226+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-socket-frontend, example
05-31 00:05:33.236+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(524) > connect() succeeded
05-31 00:05:33.276+0900 D/IMMODULE( 9460): scim_panel_client.cpp: open_connection(162) > 
05-31 00:05:33.276+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-panel-socket:0, example
05-31 00:05:33.276+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(524) > connect() succeeded
05-31 00:05:33.326+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(515) > ppid:2955  trying connect() to local:/tmp/scim-panel-socket:0, example
05-31 00:05:33.356+0900 D/ISF_SOCKET( 9460): scim_socket.cpp: connect(524) > connect() succeeded
05-31 00:05:33.506+0900 D/IMMODULE( 9460): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-31 00:05:35.236+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:35.406+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:35.516+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:35.616+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:35.706+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:40.956+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 00:05:40.956+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 00:05:40.956+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 00:05:40.956+0900 E/INDICATOR( 2886): 
05-31 00:05:51.626+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:05:51.946+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-31 00:05:51.946+0900 E/EFL     ( 9460): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 00:05:54.296+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-31 00:05:54.616+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:54.716+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:55.786+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:05:56.596+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:56.656+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:56.686+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:56.756+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:56.836+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:56.906+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:56.956+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:57.486+0900 E/E17     ( 2739): e_border.c: _e_border_cb_ping_poller(15414) > [ANR] - 1 time no response, org.example.example(9460,0x2000002)
05-31 00:05:57.506+0900 E/E17_EXTRA_MODULES( 2739): e_mod_anr.c: _e_mod_anr_dbus_msg_send(162) > [ANR][_e_mod_anr_dbus_msg_send] send dbus msg to resourced for 9460. type[0]
05-31 00:05:57.546+0900 E/RESOURCED( 2880): proc-monitor.c: edbus_signal_trigger(780) > Receive watchdog signal to pid: 9460(example)
05-31 00:05:58.796+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:58.906+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:58.996+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:59.076+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:59.156+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:05:59.396+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60171f bd->visible=1
05-31 00:06:00.596+0900 D/INDICATOR( 2886): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
05-31 00:06:00.606+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
05-31 00:06:00.606+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
05-31 00:06:00.606+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 12:06 5 h"
05-31 00:06:00.606+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 12:06"
05-31 00:06:00.606+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 12&#x2236;06"
05-31 00:06:00.606+0900 D/INDICATOR( 2886): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146627957 Time: <font_size=33>12&#x2236;06</font_size> <font_size=32>AM</font_size></font>
05-31 00:06:01.166+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 00:06:01.166+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 00:06:01.166+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 00:06:01.166+0900 E/INDICATOR( 2886): 
05-31 00:06:02.146+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:06:02.496+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p15';
05-31 00:06:02.496+0900 E/EFL     ( 9460): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 00:06:05.276+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:05.346+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:07.396+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:07.466+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:07.486+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:07.536+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:07.626+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:07.686+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:07.756+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-31 00:06:19.556+0900 D/RESOURCED( 2880): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
05-31 00:06:19.586+0900 I/RESOURCED( 2880): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
05-31 00:06:19.586+0900 D/RESOURCED( 2880): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
05-31 00:06:19.616+0900 I/RESOURCED( 2880): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
05-31 00:06:21.186+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 00:06:21.206+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 00:06:21.206+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 00:06:21.206+0900 E/INDICATOR( 2886): 
05-31 00:06:28.486+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:06:29.516+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-31 00:06:29.676+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-31 00:06:29.676+0900 E/EFL     ( 9460): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 00:06:34.725+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60171f bd->visible=1
05-31 00:06:40.695+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:06:41.245+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 00:06:41.245+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 00:06:41.245+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 00:06:41.245+0900 E/INDICATOR( 2886): 
05-31 00:06:41.775+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-31 00:06:43.475+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:06:44.065+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:06:49.295+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60171f bd->visible=1
05-31 00:07:00.605+0900 D/INDICATOR( 2886): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
05-31 00:07:00.615+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
05-31 00:07:00.645+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
05-31 00:07:00.655+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 12:07 5 h"
05-31 00:07:00.655+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 12:07"
05-31 00:07:00.655+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 12&#x2236;07"
05-31 00:07:00.665+0900 D/INDICATOR( 2886): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146625905 Time: <font_size=33>12&#x2236;07</font_size> <font_size=32>AM</font_size></font>
05-31 00:07:01.285+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 00:07:01.285+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 00:07:01.285+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 00:07:01.285+0900 E/INDICATOR( 2886): 
05-31 00:07:19.575+0900 D/RESOURCED( 2880): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
05-31 00:07:19.585+0900 I/RESOURCED( 2880): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
05-31 00:07:19.585+0900 D/RESOURCED( 2880): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
05-31 00:07:19.625+0900 I/RESOURCED( 2880): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
05-31 00:07:21.335+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 00:07:21.335+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 00:07:21.335+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 00:07:21.335+0900 E/INDICATOR( 2886): 
05-31 00:07:41.385+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 00:07:41.385+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 00:07:41.385+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 00:07:41.385+0900 E/INDICATOR( 2886): 
05-31 00:08:00.634+0900 D/INDICATOR( 2886): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
05-31 00:08:00.674+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
05-31 00:08:00.674+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
05-31 00:08:00.684+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 12:08 5 h"
05-31 00:08:00.684+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 12:08"
05-31 00:08:00.694+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 12&#x2236;08"
05-31 00:08:00.704+0900 D/INDICATOR( 2886): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146623853 Time: <font_size=33>12&#x2236;08</font_size> <font_size=32>AM</font_size></font>
05-31 00:08:01.664+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-31 00:08:01.674+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-31 00:08:01.684+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-31 00:08:01.684+0900 E/INDICATOR( 2886): 
05-31 00:08:06.684+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60171f 
05-31 00:08:07.804+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-31 00:08:08.454+0900 E/EFL     ( 9460): edje<9460> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p19';
05-31 00:08:08.454+0900 E/EFL     ( 9460): By the power of Grayskull, your previous Embryo stack is now broken!
05-31 00:08:13.084+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x60171f bd->visible=1
05-31 00:08:14.794+0900 W/CRASH_MANAGER( 9671): worker.c: worker_job(1204) > 1109460657861149615689
