S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 8525
Date: 2017-05-29 21:41:33+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8000aa56

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x8014924f, esi = 0xb37c8010
ebp = 0xbff0f0c8, esp = 0xbff0f020
eax = 0x801584c8, ebx = 0xb37ce000
ecx = 0x8000aa56, edx = 0x00000002
eip = 0xb37c846f

Memory Information
MemTotal:      123 KB
MemFree:        28 KB
Buffers:         5 KB
Cached:     167312 KB
VmPeak:     124260 KB
VmSize:     124260 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       36936 KB
VmRSS:       36936 KB
VmData:      54360 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34624 KB
VmPTE:         112 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 8525 TID = 8525
8525 8532 8713 8714 8721 

Maps Information
b0ce6000 b0cfe000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b1607000 b160e000 r-xp /usr/lib/elementary/modules/ctxpopup_copypasteUI/v-1.13.0/module.so
b1611000 b1618000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b16cd000 b16d1000 r-xp /usr/lib/elementary/modules/datetime_input_spinner/v-1.13.0/module.so
b2b8c000 b2b96000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b9c000 b2ba8000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2ba9000 b2bca000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2bcf000 b2bd0000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2bd1000 b2bd6000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2bd7000 b2bd8000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2bd9000 b2bdb000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2bdc000 b2bde000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2bdf000 b2beb000 r-xp /usr/lib/libdrm.so.2.4.0
b2bec000 b2bf6000 r-xp /usr/lib/libtbm.so.1.0.0
b2bf7000 b2c0c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c0d000 b2c1f000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b3421000 b3452000 r-xp /usr/lib/libidn.so.11.5.44
b3453000 b3475000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3476000 b3486000 r-xp /usr/lib/libcares.so.2.1.0
b3487000 b3490000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3491000 b349a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b349b000 b3512000 r-xp /usr/lib/libcurl.so.4.3.0
b3514000 b3526000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b3527000 b3548000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b354f000 b3550000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3551000 b3552000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b3553000 b3556000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b3557000 b355a000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3662000 b3668000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3669000 b37ad000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b37bd000 b37c0000 r-xp /usr/lib/libdri2.so.0.0.0
b37c1000 b37c2000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b37c3000 b37cd000 r-xp /opt/usr/apps/org.example.example/bin/example
b37cf000 b3808000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b420b000 b4216000 r-xp /lib/libnss_files-2.20-2014.11.so
b4218000 b4223000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4225000 b423c000 r-xp /lib/libnsl-2.20-2014.11.so
b4240000 b4248000 r-xp /lib/libnss_compat-2.20-2014.11.so
b424a000 b426e000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b426f000 b4270000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b4271000 b4274000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4275000 b427c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b427d000 b4287000 r-xp /usr/lib/libsensord-share.so
b4288000 b42a4000 r-xp /usr/lib/libsensor.so.1.2.0
b42a6000 b42af000 r-xp /usr/lib/libappcore-common.so.1.1
b42b2000 b42b4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b42c9000 b42cb000 r-xp /usr/lib/libXau.so.6.0.0
b42cc000 b42ee000 r-xp /usr/lib/libxcb.so.1.1.0
b42f0000 b42f9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4322000 b4324000 r-xp /usr/lib/libiri.so
b4325000 b434b000 r-xp /lib/libexpat.so.1.5.2
b434d000 b43b8000 r-xp /usr/lib/libssl.so.1.0.0
b43be000 b43ca000 r-xp /usr/lib/libethumb.so.1.13.0
b43cb000 b43cf000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b43d0000 b4621000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b9c000 b5bac000 r-xp /usr/lib/libXi.so.6.1.0
b5bad000 b5baf000 r-xp /usr/lib/libXgesture.so.7.0.0
b5bb0000 b5bb6000 r-xp /usr/lib/libXtst.so.6.1.0
b5bb7000 b5bc1000 r-xp /usr/lib/libXrender.so.1.3.0
b5bc2000 b5bcb000 r-xp /usr/lib/libXrandr.so.2.2.0
b5bcd000 b5bcf000 r-xp /usr/lib/libXinerama.so.1.0.0
b5bd0000 b5bd5000 r-xp /usr/lib/libXfixes.so.3.1.0
b5bd6000 b5be8000 r-xp /usr/lib/libXext.so.6.4.0
b5be9000 b5beb000 r-xp /usr/lib/libXdamage.so.1.1.0
b5bec000 b5bee000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5bf0000 b5d32000 r-xp /usr/lib/libX11.so.6.3.0
b5d36000 b5d40000 r-xp /usr/lib/libXcursor.so.1.0.2
b5d41000 b5d57000 r-xp /usr/lib/libudev.so.1.6.0
b5d5a000 b5d5e000 r-xp /lib/libattr.so.1.1.0
b5d5f000 b5d8e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d90000 b5d96000 r-xp /usr/lib/libffi.so.6.0.2
b5d97000 b5dba000 r-xp /lib/libz.so.1.2.8
b5dbb000 b5dbe000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5dbf000 b5f1b000 r-xp /usr/lib/libxml2.so.2.9.2
b5f21000 b6008000 r-xp /usr/lib/libstdc++.so.6.0.20
b6015000 b6018000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6019000 b603b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b603c000 b6050000 r-xp /lib/libresolv-2.20-2014.11.so
b6054000 b6078000 r-xp /usr/lib/liblzma.so.5.0.3
b6079000 b607b000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b607d000 b6087000 r-xp /usr/lib/libembryo.so.1.13.0
b6088000 b60b1000 r-xp /usr/lib/libpng12.so.0.50.0
b60b2000 b60fb000 r-xp /usr/lib/libjpeg.so.8.0.2
b610c000 b6113000 r-xp /lib/librt-2.20-2014.11.so
b6115000 b6134000 r-xp /usr/lib/libector.so.1.13.0
b6137000 b6164000 r-xp /usr/lib/liblua-5.1.so
b6165000 b61f5000 r-xp /usr/lib/libfreetype.so.6.11.3
b61f9000 b6237000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6238000 b624e000 r-xp /usr/lib/libfribidi.so.0.3.1
b624f000 b62a8000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b62ab000 b62f6000 r-xp /lib/libm-2.20-2014.11.so
b62f8000 b630a000 r-xp /usr/lib/libeio.so.1.13.0
b630b000 b630e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b630f000 b6315000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6316000 b6339000 r-xp /usr/lib/libefreet.so.1.13.0
b633c000 b6367000 r-xp /usr/lib/libeldbus.so.1.13.0
b6368000 b639c000 r-xp /usr/lib/libecore_con.so.1.13.0
b639e000 b63a7000 r-xp /usr/lib/libecore_imf.so.1.13.0
b63a8000 b63b1000 r-xp /usr/lib/libethumb_client.so.1.13.0
b63b2000 b63c5000 r-xp /usr/lib/libeo.so.1.13.0
b63c7000 b63da000 r-xp /usr/lib/libecore_input.so.1.13.0
b63db000 b63e2000 r-xp /usr/lib/libecore_file.so.1.13.0
b63e3000 b6406000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6407000 b6433000 r-xp /usr/lib/libeet.so.1.13.0
b643c000 b64a7000 r-xp /usr/lib/libeina.so.1.13.0
b64aa000 b64c1000 r-xp /usr/lib/libefl.so.1.13.0
b64c3000 b662a000 r-xp /usr/lib/libicuuc.so.51.1
b6638000 b6844000 r-xp /usr/lib/libicui18n.so.51.1
b684c000 b689b000 r-xp /usr/lib/libecore_x.so.1.13.0
b689d000 b68b7000 r-xp /lib/libgcc_s-4.9.so.1
b68b9000 b68bd000 r-xp /lib/libcap.so.2.21
b68be000 b6904000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6905000 b690c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b690e000 b6960000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b6962000 b6aed000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6af2000 b6bc0000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6bc3000 b6bc7000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6bc8000 b6bd7000 r-xp /usr/lib/libvconf.so.0.2.45
b6bd8000 b6bdb000 r-xp /usr/lib/libvasum.so.0.3.1
b6bdc000 b6bdf000 r-xp /usr/lib/libttrace.so.1.1
b6be1000 b6be5000 r-xp /usr/lib/libiniparser.so.0
b6be6000 b6c16000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c17000 b6c20000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c21000 b6c46000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6c47000 b6c57000 r-xp /usr/lib/libunwind.so.8.0.1
b6c61000 b6e0f000 r-xp /lib/libc-2.20-2014.11.so
b6e17000 b6f5a000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6f5c000 b6fb4000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6fb5000 b6fe9000 r-xp /usr/lib/libsystemd.so.0.4.0
b6fec000 b70c0000 r-xp /usr/lib/libedje.so.1.13.0
b70c3000 b70ef000 r-xp /usr/lib/libecore.so.1.13.0
b7100000 b7326000 r-xp /usr/lib/libevas.so.1.13.0
b734e000 b7366000 r-xp /lib/libpthread-2.20-2014.11.so
b736a000 b76e4000 r-xp /usr/lib/libelementary.so.1.13.0
b7704000 b7708000 r-xp /usr/lib/libsmack.so.1.0.0
b7709000 b7712000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7713000 b7716000 r-xp /usr/lib/libdlog.so.0.0.0
b7717000 b771c000 r-xp /usr/lib/libbundle.so.0.1.22
b771d000 b7720000 r-xp /lib/libdl-2.20-2014.11.so
b7722000 b7747000 r-xp /usr/lib/libaul.so.0.1.0
b774a000 b774c000 r-xp /usr/lib/libappsvc.so.0.1.0
b774d000 b7752000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b7753000 b775a000 r-xp /usr/lib/libappcore-efl.so.1.1
b775c000 b7761000 r-xp /usr/lib/libsys-assert.so
b7764000 b7765000 r-xp [vdso]
b7765000 b7787000 r-xp /lib/ld-2.20-2014.11.so
b7789000 b7791000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:8525)
Call Stack Count: 21
 0: make_popup_rep + 0x1df (0xb37c846f) [/opt/usr/apps/org.example.example/bin/example] + 0x546f
 1: (0xb7189116) [/usr/lib/libevas.so.1] + 0x89116
 2: (0xb63c0319) [/usr/lib/libeo.so.1] + 0xe319
 3: eo_event_callback_call + 0xb3 (0xb63bdd63) [/usr/lib/libeo.so.1] + 0xbd63
 4: evas_object_smart_callback_call + 0x75 (0xb718b9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 5: (0xb743c404) [/usr/lib/libelementary.so.1] + 0xd2404
 6: (0xb706ff39) [/usr/lib/libedje.so.1] + 0x83f39
 7: (0xb7076a11) [/usr/lib/libedje.so.1] + 0x8aa11
 8: (0xb7070fdc) [/usr/lib/libedje.so.1] + 0x84fdc
 9: (0xb70714cb) [/usr/lib/libedje.so.1] + 0x854cb
10: (0xb707168f) [/usr/lib/libedje.so.1] + 0x8568f
11: (0xb70d6702) [/usr/lib/libecore.so.1] + 0x13702
12: (0xb70d0055) [/usr/lib/libecore.so.1] + 0xd055
13: (0xb70d91b9) [/usr/lib/libecore.so.1] + 0x161b9
14: ecore_main_loop_begin + 0x57 (0xb70d9587) [/usr/lib/libecore.so.1] + 0x16587
15: elm_run + 0x2d (0xb753222d) [/usr/lib/libelementary.so.1] + 0x1c822d
16: appcore_efl_main + 0x4de (0xb7756dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
17: ui_app_main + 0x140 (0xb774fc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
18: main + 0x27e (0xb37c981e) [/opt/usr/apps/org.example.example/bin/example] + 0x681e
19: (0xb778b148) [/opt/usr/apps/org.example.example/bin/example] + 0xb778b148
20: __libc_start_main + 0xde (0xb6c78e4e) [/lib/libc.so.6] + 0x17e4e
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
73) > get shutdown function
05-29 21:41:22.680+0900 D/AUL_PAD ( 8716): preexec.h: __preexec_init(76) > preexec start
05-29 21:41:22.680+0900 D/AUL_PAD ( 8716): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-29 21:41:22.680+0900 D/AUL     ( 8716): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-29 21:41:22.680+0900 D/AUL     ( 8716): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-29 21:41:22.680+0900 D/AUL     ( 8716): process_pool.c: __connect_to_launchpad(132) > send(8716) : 4
05-29 21:41:22.680+0900 D/AUL     ( 8716): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-29 21:41:22.680+0900 D/AUL_PAD ( 2976): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 8716
05-29 21:41:22.710+0900 E/RESOURCED( 2889): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.547
05-29 21:41:22.860+0900 D/STARTER ( 2891): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8dbf560), lock_pid(8470)
05-29 21:41:22.860+0900 E/STARTER ( 2891): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
05-29 21:41:22.880+0900 D/AUL_PAD ( 8716): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-29 21:41:22.890+0900 D/AUL_PAD ( 8716): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-29 21:41:22.890+0900 D/AUL_PAD ( 8716): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-29 21:41:22.890+0900 D/AUL_PAD ( 8716): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-29 21:41:25.600+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(456) > pid(8525) status(4)
05-29 21:41:25.600+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(468) > pid(8525) appid(org.example.example) pkgid(org.example.example) status(4)
05-29 21:41:25.600+0900 D/AUL     ( 2837): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.example.example
05-29 21:41:25.600+0900 W/AUL     ( 2837): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8525, appid: org.example.example, status: bg
05-29 21:41:25.610+0900 D/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8525, proc_name: org.example.example, cg_name: previous, oom_score_adj: 300
05-29 21:41:25.610+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 8525
05-29 21:41:27.100+0900 E/CAPI_NETWORK_WIFI( 2919): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-29 21:41:27.100+0900 E/INDICATOR( 2919): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f2fa)
05-29 21:41:27.100+0900 E/INDICATOR( 2919): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-29 21:41:27.100+0900 E/INDICATOR( 2919): 
05-29 21:41:28.480+0900 I/LOCKSCREEN( 8470): dbus.c: _dbus_message_recv_cb(98) > [_dbus_message_recv_cb:98:I] LCD on
05-29 21:41:28.480+0900 I/LOCKSCREEN( 8470): dbus.c: _lcd_on_cb(248) > [_lcd_on_cb:248:I] Dbus LCD on
05-29 21:41:28.490+0900 D/LOCKSCREEN( 8470): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496061688) formatted(Mon, May 29)
05-29 21:41:28.490+0900 D/LOCKSCREEN( 8470): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496061688) formatted(9:41)
05-29 21:41:28.490+0900 D/LOCKSCREEN( 8470): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496061688) formatted(PM)
05-29 21:41:28.490+0900 E/EFL     ( 8470): eo<8470> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x800142a2 is not pointing to a valid object. Maybe it has already been freed.
05-29 21:41:28.490+0900 E/EFL     ( 8470): eo<8470> lib/eo/eo.c:1699 eo_data_scope_get() Obj (0x800142a2) is an invalid ref.
05-29 21:41:28.490+0900 E/EFL     ( 8470): <8470> lib/ecore/ecore_timer.c:432 _ecore_timer_del() safety check failed: timer == NULL
05-29 21:41:28.490+0900 D/INDICATOR( 2919): main.c: on_changed_receive(496) > LCD On handling
05-29 21:41:28.490+0900 D/INDICATOR( 2919): icon.c: icon_set_update_flag(633) > icon_set_update_flag[633]	 "SET UPDATE FLAG 1"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 9:41 4 h"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 9:41"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 9&#x2236;41"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2146898310 Time: <font_size=33>9&#x2236;41</font_size> <font_size=32>PM</font_size></font>
05-29 21:41:28.490+0900 D/INDICATOR( 2919): battery.c: indicator_battery_update_display(606) > indicator_battery_update_display[606]	 "Battery Capacity: 50"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.battery.percentage.two.digits.show"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): battery.c: hide_digits(487) > hide_digits[487]	 "Hide digits"
05-29 21:41:28.490+0900 E/INDICATOR( 2919): list.c: list_try_to_find_icon_to_remove(335) > (!icon) -> list_try_to_find_icon_to_remove() return
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_enabled_system_count(654) > Noti count : 0 , MiniCtrl count : 0
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_enabled_system_count(654) > Noti count : 0 , MiniCtrl count : 0
05-29 21:41:28.490+0900 E/INDICATOR( 2919): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_minictrl_list(693) > Noti count : 0, System count : 0, Minictrl count : 3
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_minictrl_list(693) > Noti count : 0, System count : 0, Minictrl count : 3
05-29 21:41:28.490+0900 E/INDICATOR( 2919): list.c: list_try_to_find_icon_to_show(269) > default
05-29 21:41:28.490+0900 E/INDICATOR( 2919): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_enabled_noti_count(634) > box_get_enabled_noti_count[634]	 "System Count : 0, Minictrl Count : 0"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_enabled_noti_count(641) > box_get_enabled_noti_count[641]	 "Notification icon enabled_noti_cnt 5"
05-29 21:41:28.490+0900 E/INDICATOR( 2919): list.c: list_try_to_find_icon_to_show(273) > (!icon) -> list_try_to_find_icon_to_show() return
05-29 21:41:28.490+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.system.hide"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.minictrl.hide"
05-29 21:41:28.490+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission indicator.noti.hide"
05-29 21:41:28.490+0900 E/INDICATOR( 2919): box.c: _update_icon(172) > (!list) -> _update_icon() return
05-29 21:41:28.490+0900 E/INDICATOR( 2919): box.c: _update_icon(172) > (!list) -> _update_icon() return
05-29 21:41:28.490+0900 E/INDICATOR( 2919): box.c: _update_icon(172) > (!list) -> _update_icon() return
05-29 21:41:28.490+0900 E/INDICATOR( 2919): box.c: _update_icon(172) > (!list) -> _update_icon() return
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-29 21:41:28.490+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-29 21:41:28.490+0900 D/INDICATOR( 2919): icon.c: _hide_more_noti(779) > port :: hide more icon
05-29 21:41:28.490+0900 E/INDICATOR( 2919): rssi.c: wake_up_cb(162) > (!s_info.updated_while_lcd_off) -> wake_up_cb() return
05-29 21:41:28.510+0900 D/STARTER ( 2891): hw_key.c: _key_press_cb(302) > [_key_press_cb:302] _key_press_cb : XF86PowerOff Pressed
05-29 21:41:28.510+0900 D/STARTER ( 2891): hw_key.c: _key_press_cb(321) > [_key_press_cb:321] phone lock state, ignore key events.
05-29 21:41:28.510+0900 D/STARTER ( 2891): lock_mgr.c: _on_lcd_changed_receive(398) > [_on_lcd_changed_receive:398] LCD signal is received
05-29 21:41:28.510+0900 W/STARTER ( 2891): lock_mgr.c: _on_lcd_changed_receive(404) > [_on_lcd_changed_receive:404] LCD on
05-29 21:41:28.510+0900 D/STARTER ( 2891): lock_mgr.c: _on_lcd_changed_receive(408) > [_on_lcd_changed_receive:408] delete alarm : id(-1)
05-29 21:41:28.510+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1345) > [SECURE_LOG] Enter
05-29 21:41:28.510+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1382) > [SECURE_LOG] alarm_manager_call_alarm_get_number_of_ids_sync() is called
05-29 21:41:28.510+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3042) > before getting actual pid[2891]
05-29 21:41:28.530+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3044) > after getting actual pid[2891]
05-29 21:41:28.530+0900 E/ALARM_MANAGER( 2864): alarm-manager.c: _get_zone_name(573) > zone name [/]
05-29 21:41:28.530+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: __check_privilege_by_cookie(1966) > uid : 200
05-29 21:41:28.530+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: __check_privilege_by_cookie(1982) > The process(2891) was authenticated successfully.
05-29 21:41:28.530+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 37
05-29 21:41:28.530+0900 E/AUL_AMD ( 2837): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
05-29 21:41:28.530+0900 E/AUL_AMD ( 2837): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
05-29 21:41:28.530+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2891 : 0
05-29 21:41:28.530+0900 D/AUL     ( 2864): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
05-29 21:41:28.530+0900 D/AUL     ( 2864): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
05-29 21:41:28.530+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: __zone_get_appid_bypid(387) > cmdline(/usr/bin/starter)
05-29 21:41:28.530+0900 D/PKGMGR_INFO( 2864): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
05-29 21:41:28.530+0900 D/PKGMGR_INFO( 2864): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/usr/bin/starter' and package_app_info.app_disable IN ('false','False')
05-29 21:41:28.530+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 37
05-29 21:41:28.530+0900 E/AUL_AMD ( 2837): amd_status.c: _status_get_cmdline(1091) > cmdline : /usr/bin/starter
05-29 21:41:28.530+0900 E/AUL_AMD ( 2837): amd_status.c: _status_get_cmdline(1094) > pkt->data : /usr/bin/starter
05-29 21:41:28.530+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(1121) > APP_GET_CMDLINE : 2891 : 0
05-29 21:41:28.530+0900 D/AUL     ( 2864): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 25
05-29 21:41:28.530+0900 D/AUL     ( 2864): pkginfo.c: aul_app_get_cmdline_bypid(389) > cmdline : /usr/bin/starter
05-29 21:41:28.530+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: __get_caller_unique_name(2015) > [SECURE_LOG] unique_name= /usr/bin/starter
05-29 21:41:28.530+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3065) > [SECURE_LOG] Called by process (pid:2891, unique_name:/usr/bin/starter)
05-29 21:41:28.530+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3073) > [SECURE_LOG] app_name=/usr/bin/starter, quark_app_unique_name=context-service
05-29 21:41:28.530+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_number_of_ids(3082) > [SECURE_LOG] number of alarms of the process (pid:2891, unique_name:/usr/bin/starter) is 0.
05-29 21:41:28.540+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1401) > maxnum_of_ids[0]
05-29 21:41:28.540+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1404) > [SECURE_LOG] alarm_manager_call_alarm_get_list_of_ids_sync() is called
05-29 21:41:28.540+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3104) > before getting actual pid[2891]
05-29 21:41:28.540+0900 D/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3106) > after getting actual pid[2891]
05-29 21:41:28.540+0900 E/ALARM_MANAGER( 2864): alarm-manager.c: _get_zone_name(573) > zone name [/]
05-29 21:41:28.540+0900 E/ALARM_MANAGER( 2864): alarm-manager.c: alarm_manager_alarm_get_list_of_ids(3115) > [SECURE_LOG] called for pid(2891), but max_number_of_ids(0) is less than 0.
05-29 21:41:28.540+0900 D/ALARM_MANAGER( 2891): alarm-lib.c: alarmmgr_enum_alarm_ids(1435) > [SECURE_LOG] Leave
05-29 21:41:28.570+0900 D/eventsystem( 2763): eventsystem.c: eventsystem_send_system_event(1011) > event_name(tizen.system.event.display_state)
05-29 21:41:28.570+0900 D/eventsystem( 2763): eventsystem.c: __get_member_name_from_eventname(259) > member_name(display_state)
05-29 21:41:28.570+0900 D/eventsystem( 2763): eventsystem.c: __eventsystem_send_event(851) > interface_name(tizen.system.event)
05-29 21:41:28.570+0900 D/eventsystem( 2763): eventsystem.c: __eventsystem_send_event(852) > object_path(/tizen/system/event)
05-29 21:41:28.570+0900 D/eventsystem( 2763): eventsystem.c: __eventsystem_send_event(853) > member_name(display_state)
05-29 21:41:28.570+0900 D/DATA_PROVIDER_MASTER( 2982): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-29 21:41:28.580+0900 D/INDICATOR( 2919): main.c: _indicator_notify_pm_state_cb(169) > LCD is on
05-29 21:41:28.590+0900 D/APP_CORE( 2923): appcore-rotation.c: __changed_cb(121) > [APP 2923] Rotation: 1 -> 1
05-29 21:41:28.840+0900 D/STARTER ( 2891): hw_key.c: _key_release_cb(206) > [_key_release_cb:206] _key_release_cb : XF86PowerOff Released
05-29 21:41:28.840+0900 D/STARTER ( 2891): hw_key.c: _key_release_cb(233) > [_key_release_cb:233] phone lock state, ignore home key.
05-29 21:41:29.180+0900 D/LOCKSCREEN( 8470): lockscreen.c: lockscreen_lcd_off_count_raise(133) > [lockscreen_lcd_off_count_raise:133:D] count for lcd off timer : 0
05-29 21:41:29.180+0900 D/LOCKSCREEN( 8470): default_lock.c: _default_lock_mouse_down_cb(115) > [_default_lock_mouse_down_cb:115:D] clicked x(311), y(781)
05-29 21:41:29.180+0900 D/LOCKSCREEN( 8470): default_lock.c: _default_lock_mouse_down_cb(125) > [_default_lock_mouse_down_cb:125:D] touch upper y : 38
05-29 21:41:29.180+0900 D/LOCKSCREEN( 8470): default_lock.c: _default_lock_mouse_down_cb(137) > [_default_lock_mouse_down_cb:137:D] camera icon : x(559), y(1119), w(124), h(124)
05-29 21:41:29.520+0900 D/LOCKSCREEN( 8470): default_lock.c: _default_lock_mouse_up_cb(214) > [_default_lock_mouse_up_cb:214:D] exit lockscreen
05-29 21:41:29.520+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200efd 
05-29 21:41:29.550+0900 I/LOCKSCREEN( 8470): lockscreen.c: _lcd_off_timer_cb(98) > [_lcd_off_timer_cb:98:I] lcd off : 10sec
05-29 21:41:29.550+0900 D/LOCKSCREEN( 8470): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496061689) formatted(Mon, May 29)
05-29 21:41:29.550+0900 D/LOCKSCREEN( 8470): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496061689) formatted(9:41)
05-29 21:41:29.550+0900 D/LOCKSCREEN( 8470): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496061689) formatted(PM)
05-29 21:41:30.050+0900 D/LOCKSCREEN( 8470): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:41:30.050+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:41:30.060+0900 D/LOCKSCREEN( 8470): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:41:30.060+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:41:30.060+0900 D/LOCKSCREEN( 8470): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:41:30.060+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:41:30.060+0900 D/LOCKSCREEN( 8470): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:41:30.060+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:41:30.060+0900 D/LOCKSCREEN( 8470): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:41:30.060+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:41:30.060+0900 D/LOCKSCREEN( 8470): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:41:30.060+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:41:30.060+0900 D/LOCKSCREEN( 8470): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:41:30.060+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:41:30.060+0900 D/LOCKSCREEN( 8470): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-29 21:41:30.060+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: ui_app_exit(799) > ui_app_exit
05-29 21:41:30.060+0900 D/AUL     ( 8470): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
05-29 21:41:30.060+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 22
05-29 21:41:30.060+0900 W/AUL_AMD ( 2837): amd_request.c: __request_handler(1056) > app status : 5
05-29 21:41:30.060+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(456) > pid(8470) status(5)
05-29 21:41:30.060+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(468) > pid(8470) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
05-29 21:41:30.060+0900 D/AUL     ( 2837): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
05-29 21:41:30.060+0900 W/AUL     ( 2837): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8470, appid: org.tizen.lockscreen, status: bg
05-29 21:41:30.060+0900 D/RESOURCED( 2889): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 8470, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
05-29 21:41:30.060+0900 D/RESOURCED( 2889): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 8470, appname = org.tizen.lockscreen
05-29 21:41:30.060+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 8470
05-29 21:41:30.060+0900 D/RESOURCED( 2889): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 8525 set score 330 (before 300)
05-29 21:41:30.060+0900 D/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8525, proc_name: org.example.example, cg_name: background, oom_score_adj: 330
05-29 21:41:30.060+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/background//cgroup.procs, value 8525
05-29 21:41:30.060+0900 D/APP_CORE( 8470): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
05-29 21:41:30.060+0900 I/CAPI_APPFW_APPLICATION( 8470): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
05-29 21:41:30.060+0900 D/LOCKSCREEN( 8470): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
05-29 21:41:30.070+0900 D/COM_CORE( 8470): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(41) for pid(-1)
05-29 21:41:30.070+0900 D/COM_CORE( 8470): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
05-29 21:41:30.070+0900 D/COM_CORE( 8470): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (41)
05-29 21:41:30.070+0900 E/COM_CORE( 8470): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
05-29 21:41:30.070+0900 E/LOCKSCREEN( 8470): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
05-29 21:41:30.070+0900 E/LOCKSCREEN( 8470): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
05-29 21:41:30.070+0900 D/COM_CORE( 2982): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
05-29 21:41:30.070+0900 D/LOCKSCREEN( 8470): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
05-29 21:41:30.070+0900 D/CALL_MGR_CLIENT( 8470): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
05-29 21:41:30.070+0900 D/CALL_MGR_CLIENT( 8470): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
05-29 21:41:30.070+0900 W/CALL_MGR_CLIENT( 8470): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
05-29 21:41:30.070+0900 D/CALL_MGR_CLIENT( 8470): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
05-29 21:41:30.070+0900 D/CALL_MGR_CLIENT( 8470): <LIB:cm_deinit:444> cm_deinit
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
05-29 21:41:30.070+0900 D/SYSTEM-SETTINGS( 8470): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
05-29 21:41:30.070+0900 D/SYSTEM-SETTINGS( 8470): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
05-29 21:41:30.070+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
05-29 21:41:30.070+0900 D/SYSTEM-SETTINGS( 8470): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
05-29 21:41:30.080+0900 D/DATA_PROVIDER_MASTER( 2982): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb1f00540 is terminated
05-29 21:41:30.080+0900 D/DATA_PROVIDER_MASTER( 2982): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
05-29 21:41:30.080+0900 D/LOCKSCREEN( 8470): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
05-29 21:41:30.080+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:41:30.080+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
05-29 21:41:30.080+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
05-29 21:41:30.080+0900 D/SYSTEM-SETTINGS( 8470): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
05-29 21:41:30.080+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-29 21:41:30.080+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
05-29 21:41:30.080+0900 E/TIZEN_N_SYSTEM_SETTINGS( 8470): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
05-29 21:41:30.080+0900 D/SYSTEM-SETTINGS( 8470): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
05-29 21:41:30.090+0900 D/LOCKSCREEN( 8470): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
05-29 21:41:30.090+0900 E/EFL     ( 8470): eo<8470> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
05-29 21:41:30.090+0900 E/EFL     ( 8470): eo<8470> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
05-29 21:41:30.100+0900 D/RESOURCED( 2889): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2921 increase lru 4
05-29 21:41:30.100+0900 D/RESOURCED( 2889): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2921 set score 390 (before 360)
05-29 21:41:30.100+0900 D/RESOURCED( 2889): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
05-29 21:41:30.100+0900 D/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8470, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
05-29 21:41:30.100+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 8470
05-29 21:41:30.230+0900 E/E17     ( 2733): e_border.c: e_border_hide(2248) > BD_HIDE(0x02a00007), visible:1
05-29 21:41:30.230+0900 E/EFL     ( 2733): eo<2733> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-29 21:41:30.240+0900 E/E17_TZSH( 2733): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b39c85c0, role:118
05-29 21:41:30.270+0900 W/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=8525
05-29 21:41:30.280+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
05-29 21:41:30.290+0900 D/INDICATOR( 2919): main.c: _property_changed_cb(432) > UNSNIFF API 2a00007
05-29 21:41:30.290+0900 D/INDICATOR( 2919): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-29 21:41:30.300+0900 D/INDICATOR( 2919): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-29 21:41:30.300+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-29 21:41:30.300+0900 D/INDICATOR( 2919): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-29 21:41:30.300+0900 D/INDICATOR( 2919): main.c: _rotate_window(252) > port :: hide more icon
05-29 21:41:30.310+0900 I/TZSH    ( 2987): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
05-29 21:41:30.310+0900 E/EFL     ( 2733): eo<2733> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-29 21:41:30.330+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(838) > __request_handler: 15
05-29 21:41:30.330+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-29 21:41:30.330+0900 D/PKGMGR_INFO( 2837): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-29 21:41:30.330+0900 D/AUL_AMD ( 2837): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 8525 is org.example.example
05-29 21:41:30.330+0900 D/AUL_AMD ( 2837): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 8525 : 0
05-29 21:41:30.330+0900 D/AUL     ( 2994): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-29 21:41:30.330+0900 D/AUL_PAD ( 2976): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-29 21:41:30.330+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-29 21:41:30.330+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-29 21:41:30.330+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-29 21:41:30.330+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-29 21:41:30.330+0900 D/AUL_PAD ( 2976): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-29 21:41:30.330+0900 D/AUL_PAD ( 2976): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-29 21:41:30.330+0900 I/AUL_PAD ( 2976): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 8470 pgid = 8470
05-29 21:41:30.330+0900 I/AUL_PAD ( 2976): sigchild.h: __sigchild_action(142) > dead_pid(8470)
05-29 21:41:30.330+0900 D/APP_CORE( 8525): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1000002 fully_obscured 0
05-29 21:41:30.330+0900 D/APP_CORE( 8525): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
05-29 21:41:30.330+0900 D/APP_CORE( 8525): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-29 21:41:30.330+0900 I/APP_CORE( 8525): appcore-efl.c: __do_app(496) > [APP 8525] Event: RESUME State: CREATED
05-29 21:41:30.330+0900 D/LAUNCH  ( 8525): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-29 21:41:30.330+0900 D/APP_CORE( 8525): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-29 21:41:30.330+0900 D/APP_CORE( 8525): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-29 21:41:30.330+0900 D/APP_CORE( 8525): appcore-efl.c: __do_app(607) > [APP 8525] RESUME
05-29 21:41:30.330+0900 I/APP_CORE( 8525): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-29 21:41:30.330+0900 I/APP_CORE( 8525): appcore-efl.c: __do_app(614) > [APP 8525] Initial Launching, call the resume_cb
05-29 21:41:30.330+0900 I/CAPI_APPFW_APPLICATION( 8525): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-29 21:41:30.330+0900 D/LAUNCH  ( 8525): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-29 21:41:30.330+0900 D/LAUNCH  ( 8525): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-29 21:41:30.330+0900 D/APP_CORE( 8525): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-29 21:41:30.330+0900 E/APP_CORE( 8525): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-29 21:41:30.350+0900 D/AUL_PAD ( 2976): sigchild.h: __send_app_dead_signal(90) > send dead signal done
05-29 21:41:30.350+0900 I/AUL_PAD ( 2976): sigchild.h: __sigchild_action(148) > __send_app_dead_signal(0)
05-29 21:41:30.350+0900 I/AUL_PAD ( 2976): sigchild.h: __launchpad_process_sigchld(169) > after __sigchild_action
05-29 21:41:30.350+0900 E/AUL_PAD ( 2976): launchpad.c: main(688) > error reading sigchld info
05-29 21:41:30.350+0900 D/STARTER ( 2891): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 8470 is termianted
05-29 21:41:30.350+0900 D/STARTER ( 2891): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
05-29 21:41:30.350+0900 E/STARTER ( 2891): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
05-29 21:41:30.350+0900 D/STARTER ( 2891): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
05-29 21:41:30.350+0900 D/STARTER ( 2891): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
05-29 21:41:30.350+0900 I/ESD     ( 2992): esd_main.c: __esd_app_dead_handler(1771) > pid: 8470
05-29 21:41:30.350+0900 W/STARTER ( 2891): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x2a00007 is not transient
05-29 21:41:30.350+0900 D/INDICATOR( 2919): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
05-29 21:41:30.360+0900 W/AUL_AMD ( 2837): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 8470
05-29 21:41:30.360+0900 W/AUL_AMD ( 2837): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 8470
05-29 21:41:30.360+0900 D/AUL_AMD ( 2837): amd_key.c: _unregister_key_event(179) > ===key stack===
05-29 21:41:30.360+0900 E/AUL_AMD ( 2837): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-29 21:41:30.360+0900 D/AUL_AMD ( 2837): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
05-29 21:41:30.360+0900 D/AUL     ( 2837): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-29 21:41:30.360+0900 E/AUL     ( 2837): simple_util.c: __trm_app_info_send_socket(330) > access
05-29 21:41:30.380+0900 D/AUL_AMD ( 2837): amd_launch.c: __e17_status_handler(2891) > pid(8525) status(3)
05-29 21:41:30.380+0900 D/AUL_AMD ( 2837): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-29 21:41:30.380+0900 W/AUL_AMD ( 2837): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-29 21:41:30.380+0900 W/AUL_AMD ( 2837): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-29 21:41:30.380+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(456) > pid(8525) status(3)
05-29 21:41:30.380+0900 D/AUL_AMD ( 2837): amd_status.c: _status_update_app_info_list(468) > pid(8525) appid(org.example.example) pkgid(org.example.example) status(3)
05-29 21:41:30.380+0900 D/AUL     ( 2837): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-29 21:41:30.380+0900 W/AUL     ( 2837): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 8525, appid: org.example.example, status: fg
05-29 21:41:30.380+0900 E/RESOURCED( 2889): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.549
05-29 21:41:30.380+0900 D/RESOURCED( 2889): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 8470
05-29 21:41:30.380+0900 D/RESOURCED( 2889): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
05-29 21:41:30.380+0900 D/RESOURCED( 2889): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 8525
05-29 21:41:30.380+0900 D/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 8525, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-29 21:41:30.380+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 8525
05-29 21:41:30.400+0900 D/VOLUME  ( 2921): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
05-29 21:41:30.440+0900 D/RESOURCED( 2889): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 8525, appname = org.example.example, pkgname = org.example.example
05-29 21:41:30.440+0900 D/RESOURCED( 2889): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 8525, appname = org.example.example
05-29 21:41:30.440+0900 D/RESOURCED( 2889): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 8525
05-29 21:41:30.440+0900 I/RESOURCED( 2889): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-29 21:41:30.440+0900 I/RESOURCED( 2889): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-29 21:41:31.040+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200f12 
05-29 21:41:31.840+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200f12 
05-29 21:41:31.990+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.000+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.070+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.070+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.070+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.070+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.070+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.070+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.070+0900 E/EFL     ( 8525): edje<8525> lib/edje/edje_util.c:3166 _edje_object_size_min_restricted_calc() file /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj, group elm/datetime/base/time_layout has a non-fixed part 'field5'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-29 21:41:32.090+0900 D/IMMODULE( 8525): isf_imf_context.cpp: initialize(3406) > Initializing Ecore ISF IMModule...
05-29 21:41:32.100+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:41:32.100+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:41:32.100+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:41:32.100+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:41:32.160+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:41:32.160+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:41:32.170+0900 D/ISF_QUERY( 8525): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="ise-default", label="Tizen keyboard", pkgid="ise-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-helper-launcher", mname="ise-default", mpath="/usr/lib/scim-1.0/1.4.0/Helper", mode=1, options=13, is_enabled=1, is_preinstalled=1, has_option=1, disp_lang="en_US.UTF-8"
05-29 21:41:32.170+0900 D/ISF_QUERY( 8525): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-anthy", label="Japanese keyboard", pkgid="ise-engine-anthy", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-anthy", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:41:32.170+0900 D/ISF_QUERY( 8525): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-default", label="Default keyboard", pkgid="ise-engine-default", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-default", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:41:32.170+0900 D/ISF_QUERY( 8525): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-hangul", label="Hangul keyboard", pkgid="hangul", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="hangul", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:41:32.170+0900 D/ISF_QUERY( 8525): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-sunpinyin", label="Chinese (sunpinyin) keyboard", pkgid="ise-engine-sunpinyin", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="ise-engine-sunpinyin", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:41:32.170+0900 D/ISF_QUERY( 8525): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.cangjie3", label="CanJie 3 keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:41:32.170+0900 D/ISF_QUERY( 8525): isf_query_utility.cpp: _db_select_all_ime_info(317) > [SECURE_LOG] appid="org.tizen.ise-engine-tables.zhuyin-big", label="ZhuYin Big keyboard", pkgid="table", pkgtype="rpm", exec="/usr/lib/scim-1.0/scim-launcher", mname="table", mpath="/usr/lib/scim-1.0/1.4.0/IMEngine", mode=0, options=0, is_enabled=1, is_preinstalled=1, has_option=0, disp_lang="en_US.UTF-8"
05-29 21:41:32.180+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-socket-frontend, example
05-29 21:41:32.180+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:41:32.190+0900 D/IMMODULE( 8525): scim_panel_client.cpp: open_connection(162) > 
05-29 21:41:32.190+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-panel-socket:0, example
05-29 21:41:32.190+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:41:32.190+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(515) > ppid:2976  trying connect() to local:/tmp/scim-panel-socket:0, example
05-29 21:41:32.190+0900 D/ISF_SOCKET( 8525): scim_socket.cpp: connect(524) > connect() succeeded
05-29 21:41:32.210+0900 D/IMMODULE( 8525): isf_imf_control_ui.cpp: isf_imf_input_panel_init(516) > keyboard mode(0:H/W Keyboard, 1:S/W Keyboard): 1
05-29 21:41:32.840+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x1000002
05-29 21:41:33.260+0900 D/PROCESSMGR( 2733): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002f  register trigger_timer!  pointed_win=0x200f12 
05-29 21:41:33.540+0900 W/CRASH_MANAGER( 8722): worker.c: worker_job(1204) > 1108525657861149606169
