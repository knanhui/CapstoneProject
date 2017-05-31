S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 2960
Date: 2017-05-30 16:46:07+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb7500dcd

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000004, esi = 0xb7500dc9
ebp = 0xbfc765c8, esp = 0xbfc76550
eax = 0x8007eff9, ebx = 0xb374e000
ecx = 0x000001e0, edx = 0x00000320
eip = 0xb3746954

Memory Information
MemTotal:      123 KB
MemFree:        33 KB
Buffers:         3 KB
Cached:     162060 KB
VmPeak:     112696 KB
VmSize:     112696 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       26192 KB
VmRSS:       26192 KB
VmData:      44712 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34452 KB
VmPTE:         100 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 2960 TID = 2960
2960 3060 3361 3362 3367 

Maps Information
b2b0c000 b2b16000 r-xp /usr/lib/libfeedback.so.0.1.4
b2b1c000 b2b28000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2b29000 b2b4a000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2b4f000 b2b50000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2b51000 b2b56000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2b57000 b2b58000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2b59000 b2b5b000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2b5c000 b2b5e000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2b5f000 b2b6b000 r-xp /usr/lib/libdrm.so.2.4.0
b2b6c000 b2b76000 r-xp /usr/lib/libtbm.so.1.0.0
b2b77000 b2b8c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2b8d000 b2b9f000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b33a1000 b33d2000 r-xp /usr/lib/libidn.so.11.5.44
b33d3000 b33f5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b33f6000 b3406000 r-xp /usr/lib/libcares.so.2.1.0
b3407000 b3410000 r-xp /usr/lib/libeventsystem.so.0.0.1
b3411000 b341a000 r-xp /usr/lib/libefl-extension.so.0.1.0
b341b000 b3492000 r-xp /usr/lib/libcurl.so.4.3.0
b3494000 b34a6000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b34a7000 b34c8000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b34cf000 b34d0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b34d1000 b34d2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b34d3000 b34d6000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b34d7000 b34da000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b35e2000 b35e8000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b35e9000 b372d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b373e000 b3741000 r-xp /usr/lib/libdri2.so.0.0.0
b3742000 b3743000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b3744000 b374d000 r-xp /opt/usr/apps/org.example.example/bin/example
b374f000 b3788000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b418b000 b4196000 r-xp /lib/libnss_files-2.20-2014.11.so
b4198000 b41a3000 r-xp /lib/libnss_nis-2.20-2014.11.so
b41a5000 b41bc000 r-xp /lib/libnsl-2.20-2014.11.so
b41c0000 b41c8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b41ca000 b41ee000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b41ef000 b41f0000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b41f1000 b41f4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b41f5000 b41fc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b41fd000 b4207000 r-xp /usr/lib/libsensord-share.so
b4208000 b4224000 r-xp /usr/lib/libsensor.so.1.2.0
b4226000 b422f000 r-xp /usr/lib/libappcore-common.so.1.1
b4232000 b4234000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4249000 b424b000 r-xp /usr/lib/libXau.so.6.0.0
b424c000 b426e000 r-xp /usr/lib/libxcb.so.1.1.0
b4270000 b4279000 r-xp /lib/libcrypt-2.20-2014.11.so
b42a2000 b42a4000 r-xp /usr/lib/libiri.so
b42a5000 b42cb000 r-xp /lib/libexpat.so.1.5.2
b42cd000 b4338000 r-xp /usr/lib/libssl.so.1.0.0
b433e000 b434a000 r-xp /usr/lib/libethumb.so.1.13.0
b434b000 b434f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4350000 b45a1000 r-xp /usr/lib/libcrypto.so.1.0.0
b5b1c000 b5b2c000 r-xp /usr/lib/libXi.so.6.1.0
b5b2d000 b5b2f000 r-xp /usr/lib/libXgesture.so.7.0.0
b5b30000 b5b36000 r-xp /usr/lib/libXtst.so.6.1.0
b5b37000 b5b41000 r-xp /usr/lib/libXrender.so.1.3.0
b5b42000 b5b4b000 r-xp /usr/lib/libXrandr.so.2.2.0
b5b4d000 b5b4f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5b50000 b5b55000 r-xp /usr/lib/libXfixes.so.3.1.0
b5b56000 b5b68000 r-xp /usr/lib/libXext.so.6.4.0
b5b69000 b5b6b000 r-xp /usr/lib/libXdamage.so.1.1.0
b5b6c000 b5b6e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5b70000 b5cb2000 r-xp /usr/lib/libX11.so.6.3.0
b5cb6000 b5cc0000 r-xp /usr/lib/libXcursor.so.1.0.2
b5cc1000 b5cd7000 r-xp /usr/lib/libudev.so.1.6.0
b5cda000 b5cde000 r-xp /lib/libattr.so.1.1.0
b5cdf000 b5d0e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5d10000 b5d16000 r-xp /usr/lib/libffi.so.6.0.2
b5d17000 b5d3a000 r-xp /lib/libz.so.1.2.8
b5d3b000 b5d3e000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5d3f000 b5e9b000 r-xp /usr/lib/libxml2.so.2.9.2
b5ea1000 b5f88000 r-xp /usr/lib/libstdc++.so.6.0.20
b5f95000 b5f98000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5f99000 b5fbb000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5fbc000 b5fd0000 r-xp /lib/libresolv-2.20-2014.11.so
b5fd4000 b5ff8000 r-xp /usr/lib/liblzma.so.5.0.3
b5ff9000 b5ffb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5ffd000 b6007000 r-xp /usr/lib/libembryo.so.1.13.0
b6008000 b6031000 r-xp /usr/lib/libpng12.so.0.50.0
b6032000 b607b000 r-xp /usr/lib/libjpeg.so.8.0.2
b608c000 b6093000 r-xp /lib/librt-2.20-2014.11.so
b6095000 b60b4000 r-xp /usr/lib/libector.so.1.13.0
b60b7000 b60e4000 r-xp /usr/lib/liblua-5.1.so
b60e5000 b6175000 r-xp /usr/lib/libfreetype.so.6.11.3
b6179000 b61b7000 r-xp /usr/lib/libfontconfig.so.1.8.0
b61b8000 b61ce000 r-xp /usr/lib/libfribidi.so.0.3.1
b61cf000 b6228000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b622b000 b6276000 r-xp /lib/libm-2.20-2014.11.so
b6278000 b628a000 r-xp /usr/lib/libeio.so.1.13.0
b628b000 b628e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b628f000 b6295000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6296000 b62b9000 r-xp /usr/lib/libefreet.so.1.13.0
b62bc000 b62e7000 r-xp /usr/lib/libeldbus.so.1.13.0
b62e8000 b631c000 r-xp /usr/lib/libecore_con.so.1.13.0
b631e000 b6327000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6328000 b6331000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6332000 b6345000 r-xp /usr/lib/libeo.so.1.13.0
b6347000 b635a000 r-xp /usr/lib/libecore_input.so.1.13.0
b635b000 b6362000 r-xp /usr/lib/libecore_file.so.1.13.0
b6363000 b6386000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6387000 b63b3000 r-xp /usr/lib/libeet.so.1.13.0
b63bc000 b6427000 r-xp /usr/lib/libeina.so.1.13.0
b642a000 b6441000 r-xp /usr/lib/libefl.so.1.13.0
b6443000 b65aa000 r-xp /usr/lib/libicuuc.so.51.1
b65b8000 b67c4000 r-xp /usr/lib/libicui18n.so.51.1
b67cc000 b681b000 r-xp /usr/lib/libecore_x.so.1.13.0
b681d000 b6837000 r-xp /lib/libgcc_s-4.9.so.1
b6839000 b683d000 r-xp /lib/libcap.so.2.21
b683e000 b6884000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6885000 b688c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b688e000 b68e0000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b68e2000 b6a6d000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6a72000 b6b40000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6b43000 b6b47000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6b48000 b6b57000 r-xp /usr/lib/libvconf.so.0.2.45
b6b58000 b6b5b000 r-xp /usr/lib/libvasum.so.0.3.1
b6b5c000 b6b5f000 r-xp /usr/lib/libttrace.so.1.1
b6b61000 b6b65000 r-xp /usr/lib/libiniparser.so.0
b6b66000 b6b96000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b97000 b6ba0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6ba1000 b6bc6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bc7000 b6bd7000 r-xp /usr/lib/libunwind.so.8.0.1
b6be1000 b6d8f000 r-xp /lib/libc-2.20-2014.11.so
b6d97000 b6eda000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6edc000 b6f34000 r-xp /usr/lib/libdbus-1.so.3.8.11
b6f35000 b6f69000 r-xp /usr/lib/libsystemd.so.0.4.0
b6f6c000 b7040000 r-xp /usr/lib/libedje.so.1.13.0
b7043000 b706f000 r-xp /usr/lib/libecore.so.1.13.0
b7080000 b72a6000 r-xp /usr/lib/libevas.so.1.13.0
b72ce000 b72e6000 r-xp /lib/libpthread-2.20-2014.11.so
b72ea000 b7664000 r-xp /usr/lib/libelementary.so.1.13.0
b7684000 b7688000 r-xp /usr/lib/libsmack.so.1.0.0
b7689000 b7692000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7693000 b7696000 r-xp /usr/lib/libdlog.so.0.0.0
b7697000 b769c000 r-xp /usr/lib/libbundle.so.0.1.22
b769d000 b76a0000 r-xp /lib/libdl-2.20-2014.11.so
b76a2000 b76c7000 r-xp /usr/lib/libaul.so.0.1.0
b76ca000 b76cc000 r-xp /usr/lib/libappsvc.so.0.1.0
b76cd000 b76d2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b76d3000 b76da000 r-xp /usr/lib/libappcore-efl.so.1.1
b76dc000 b76e1000 r-xp /usr/lib/libsys-assert.so
b76e4000 b76e5000 r-xp [vdso]
b76e5000 b7707000 r-xp /lib/ld-2.20-2014.11.so
b7709000 b7711000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:2960)
Call Stack Count: 23
 0:  + 0x0 (0xb3746954) [/opt/usr/apps/org.example.example/bin/example] + 0x2954
 1: create_option_view + 0x45 (0xb3747615) [/opt/usr/apps/org.example.example/bin/example] + 0x3615
 2: diary_option_view_cb + 0x14c (0xb374750c) [/opt/usr/apps/org.example.example/bin/example] + 0x350c
 3: (0xb7109116) [/usr/lib/libevas.so.1] + 0x89116
 4: (0xb6340319) [/usr/lib/libeo.so.1] + 0xe319
 5: eo_event_callback_call + 0xb3 (0xb633dd63) [/usr/lib/libeo.so.1] + 0xbd63
 6: evas_object_smart_callback_call + 0x75 (0xb710b9e5) [/usr/lib/libevas.so.1] + 0x8b9e5
 7: (0xb73c2049) [/usr/lib/libelementary.so.1] + 0xd8049
 8: (0xb6feff39) [/usr/lib/libedje.so.1] + 0x83f39
 9: (0xb6ff6a11) [/usr/lib/libedje.so.1] + 0x8aa11
10: (0xb6ff0fdc) [/usr/lib/libedje.so.1] + 0x84fdc
11: (0xb6ff14cb) [/usr/lib/libedje.so.1] + 0x854cb
12: (0xb6ff168f) [/usr/lib/libedje.so.1] + 0x8568f
13: (0xb7056702) [/usr/lib/libecore.so.1] + 0x13702
14: (0xb7050055) [/usr/lib/libecore.so.1] + 0xd055
15: (0xb70591b9) [/usr/lib/libecore.so.1] + 0x161b9
16: ecore_main_loop_begin + 0x57 (0xb7059587) [/usr/lib/libecore.so.1] + 0x16587
17: elm_run + 0x2d (0xb74b222d) [/usr/lib/libelementary.so.1] + 0x1c822d
18: appcore_efl_main + 0x4de (0xb76d6dde) [/usr/lib/libappcore-efl.so.1] + 0x3dde
19: ui_app_main + 0x140 (0xb76cfc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
20: main + 0x27e (0xb3749d4e) [/opt/usr/apps/org.example.example/bin/example] + 0x5d4e
21: (0xb770b148) [/opt/usr/apps/org.example.example/bin/example] + 0xb770b148
22: __libc_start_main + 0xde (0xb6bf8e4e) [/lib/libc.so.6] + 0x17e4e
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
5-30 16:45:57.598+0900 D/AUL_PAD ( 2955): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 2960, bin path: /opt/usr/apps/org.example.example/bin/example
05-30 16:45:57.598+0900 W/AUL_PAD ( 2955): launchpad.c: __send_result_to_caller(265) > Check app launching
05-30 16:45:57.598+0900 D/AUL_PAD ( 2955): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
05-30 16:45:57.598+0900 D/AUL     ( 2960): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3060) is sent.
05-30 16:45:57.598+0900 D/AUL     ( 2960): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3060, signo: 10
05-30 16:45:57.598+0900 D/RESOURCED( 2880): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
05-30 16:45:57.598+0900 D/RESOURCED( 2880): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
05-30 16:45:57.598+0900 E/RESOURCED( 2880): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
05-30 16:45:57.598+0900 D/AUL     ( 2960): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTYxMzAzNTcvNTgyNTc0AA==##
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAzMzU3AA==##
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
05-30 16:45:57.598+0900 D/AUL_PAD ( 2960): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
05-30 16:45:57.608+0900 I/CAPI_APPFW_APPLICATION( 2960): app_main.c: ui_app_main(788) > app_efl_main
05-30 16:45:57.608+0900 D/LAUNCH  ( 2960): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
05-30 16:45:57.608+0900 D/APP_CORE( 2960): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
05-30 16:45:57.608+0900 D/APP_CORE( 2960): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
05-30 16:45:57.608+0900 D/APP_CORE( 2960): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
05-30 16:45:57.628+0900 D/APP_CORE( 2960): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
05-30 16:45:57.628+0900 D/AUL     ( 2960): app_sock.c: __create_server_sock(156) > pg path - already exists
05-30 16:45:57.628+0900 D/APP_CORE( 2960): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb422f520
05-30 16:45:57.628+0900 D/LAUNCH  ( 2960): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
05-30 16:45:57.628+0900 I/CAPI_APPFW_APPLICATION( 2960): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
05-30 16:45:57.648+0900 D/STARTER ( 2876): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8ebffb8), lock_pid(2887)
05-30 16:45:57.668+0900 D/STARTER ( 2876): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8ebffb8), lock_pid(2887)
05-30 16:45:57.698+0900 D/AUL_PAD ( 2955): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
05-30 16:45:57.698+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 2960, appid: org.example.example
05-30 16:45:57.698+0900 D/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-30 16:45:57.698+0900 E/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(330) > access
05-30 16:45:57.698+0900 D/AUL_AMD ( 2787): amd_launch.c: _start_app(2700) > add app group info
05-30 16:45:57.698+0900 E/AUL     ( 2787): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
05-30 16:45:57.698+0900 D/AUL_AMD ( 2787): amd_status.c: _status_add_app_info_list(427) > pid(2960) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
05-30 16:45:57.708+0900 D/RESOURCED( 2880): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 2960
05-30 16:45:57.708+0900 D/RESOURCED( 2880): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
05-30 16:45:57.708+0900 E/RESOURCED( 2880): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
05-30 16:45:57.708+0900 D/RESOURCED( 2880): proc-main.c: resourced_proc_status_change(888) > available memory = 295
05-30 16:45:57.748+0900 D/LAUNCH  ( 2960): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
05-30 16:45:57.758+0900 E/E17     ( 2739): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x02000002)
05-30 16:45:57.758+0900 D/APP_CORE( 2960): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
05-30 16:45:57.758+0900 D/STARTER ( 2876): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8ebffb8), lock_pid(2887)
05-30 16:45:57.778+0900 E/STARTER ( 2876): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
05-30 16:45:57.788+0900 D/rpm-installer( 3303): rpm-installer-privilege.c: __ri_privilege_perm_end(55) > [smack] perm_end, result=[0]
05-30 16:45:57.788+0900 D/rpm-installer( 3303): rpm-appcore-intf.c: main(259) > ------------------------------------------------
05-30 16:45:57.788+0900 D/rpm-installer( 3303): rpm-appcore-intf.c: main(260) >  [END] rpm-installer: result=[0]
05-30 16:45:57.788+0900 D/rpm-installer( 3303): rpm-appcore-intf.c: main(261) > ------------------------------------------------
05-30 16:45:57.798+0900 D/PKGMGR_SERVER( 3300): pkgmgr-server.c: sighandler(387) > child exit [3303]
05-30 16:45:57.798+0900 E/PKGMGR_SERVER( 3300): pkgmgr-server.c: sighandler(402) > child NORMAL exit [3303]
05-30 16:45:57.818+0900 E/E17     ( 2739): e_border.c: e_border_show(2088) > BD_SHOW(0x02000002)
05-30 16:45:57.828+0900 D/STARTER ( 2876): lock_mgr.c: _lock_show_cb(321) > [_lock_show_cb:321] lockw(0xb8ebffb8), lock_pid(2887)
05-30 16:45:57.838+0900 D/STARTER ( 2876): window_mgr.c: window_mgr_set_prop(206) > [window_mgr_set_prop:206] Check PID(2960) window. (lock_app_pid : 2887)
05-30 16:45:57.838+0900 D/APP_CORE( 2960): appcore.c: __aul_handler(587) > [APP 2960]     AUL event: AUL_START
05-30 16:45:57.838+0900 I/APP_CORE( 2960): appcore-efl.c: __do_app(496) > [APP 2960] Event: RESET State: CREATED
05-30 16:45:57.838+0900 D/APP_CORE( 2960): appcore-efl.c: __do_app(527) > [APP 2960] RESET
05-30 16:45:57.838+0900 D/LAUNCH  ( 2960): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
05-30 16:45:57.838+0900 D/APP_CORE( 2960): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
05-30 16:45:57.838+0900 D/APP_CORE( 2960): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-30 16:45:57.838+0900 I/CAPI_APPFW_APPLICATION( 2960): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
05-30 16:45:57.838+0900 D/AUL     ( 2960): service.c: __set_bundle(186) > __set_bundle
05-30 16:45:57.838+0900 D/LAUNCH  ( 2960): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
05-30 16:45:57.838+0900 D/APP_CORE( 2960): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
05-30 16:45:57.838+0900 E/EFL     ( 2960): edje<2960> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 16:45:57.838+0900 E/EFL     ( 2960): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 16:45:57.838+0900 E/EFL     ( 2960): edje<2960> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 16:45:57.838+0900 E/EFL     ( 2960): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 16:45:57.838+0900 E/EFL     ( 2960): edje<2960> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 16:45:57.838+0900 E/EFL     ( 2960): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 16:45:57.848+0900 E/EFL     ( 2960): edje<2960> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 16:45:57.848+0900 E/EFL     ( 2960): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 16:45:57.848+0900 E/EFL     ( 2960): edje<2960> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
05-30 16:45:57.848+0900 E/EFL     ( 2960): By the power of Grayskull, your previous Embryo stack is now broken!
05-30 16:45:57.858+0900 W/APP_CORE( 2960): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2000002
05-30 16:45:57.858+0900 D/APP_CORE( 2960): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:2000002
05-30 16:45:57.858+0900 D/APP_CORE( 2960): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
05-30 16:45:57.858+0900 D/AUL     ( 2960): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
05-30 16:45:57.868+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 34
05-30 16:45:57.998+0900 E/PKGMGR_SERVER( 3300): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
05-30 16:45:57.998+0900 E/PKGMGR_SERVER( 3300): pkgmgr-server.c: main(2265) > package manager server terminated.
05-30 16:45:58.098+0900 E/EFL     ( 2739): evas-software_x11<2739> modules/evas/engines/software_x11/evas_xlib_dri_image.c:157 _drm_init() Not supported by DRI2 version(1.4)
05-30 16:45:58.188+0900 D/APP_CORE( 2960): appcore.c: __prt_ltime(236) > [APP 2960] first idle after reset: 616 msec
05-30 16:45:58.498+0900 E/E17     ( 2739): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
05-30 16:45:58.498+0900 D/APP_CORE( 2960): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2000002 fully_obscured 1
05-30 16:45:58.498+0900 D/APP_CORE( 2960): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active -1
05-30 16:45:58.498+0900 D/APP_CORE( 2960): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
05-30 16:45:58.498+0900 I/APP_CORE( 2960): appcore-efl.c: __do_app(496) > [APP 2960] Event: PAUSE State: CREATED
05-30 16:45:58.498+0900 D/APP_CORE( 2960): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-30 16:45:58.498+0900 E/APP_CORE( 2960): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-30 16:45:58.508+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(2892) status(4)
05-30 16:45:58.508+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(2892) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
05-30 16:45:58.508+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
05-30 16:45:58.508+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2892, appid: org.tizen.homescreen, status: bg
05-30 16:45:58.548+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2910) > pid(2960) status(0)
05-30 16:45:58.708+0900 D/AUL_AMD ( 2787): amd_launch.c: __grab_timeout_handler(1445) > pid(2960) ecore_x_pointer_ungrab
05-30 16:45:58.708+0900 D/AUL_AMD ( 2787): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-30 16:45:58.708+0900 W/AUL_AMD ( 2787): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-30 16:45:58.708+0900 W/AUL_AMD ( 2787): amd_launch.c: __grab_timeout_handler(1447) > back key ungrab error
05-30 16:45:58.708+0900 D/AUL_PAD ( 2955): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
05-30 16:45:58.708+0900 D/AUL_PAD ( 3365): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
05-30 16:45:58.728+0900 D/AUL_PAD ( 2955): sigchild.h: __send_app_launch_signal(131) > send launch signal done
05-30 16:45:59.208+0900 D/AUL_AMD ( 2787): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
05-30 16:45:59.208+0900 D/RUA     ( 2787): rua.c: rua_add_history(179) > rua_add_history start
05-30 16:45:59.228+0900 D/RUA     ( 2787): rua.c: rua_add_history(247) > rua_add_history ok
05-30 16:45:59.748+0900 D/AUL_PAD ( 3365): launchpad_loader.c: main(588) > sleeping 1 sec...
05-30 16:45:59.748+0900 D/AUL_PAD ( 3365): preload.h: __preload_init(52) > max_cmdline_size = 1053
05-30 16:45:59.758+0900 D/AUL_PAD ( 3365): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b77f3760
05-30 16:45:59.758+0900 D/AUL_PAD ( 3365): preload.h: __preload_init(69) > get pre-initialization function
05-30 16:45:59.758+0900 D/AUL_PAD ( 3365): preload.h: __preload_init(73) > get shutdown function
05-30 16:45:59.758+0900 D/AUL_PAD ( 3365): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b77f3a40
05-30 16:45:59.768+0900 D/AUL_PAD ( 3365): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b77f5640
05-30 16:45:59.768+0900 D/AUL_PAD ( 3365): preload.h: __preload_init(69) > get pre-initialization function
05-30 16:45:59.768+0900 D/AUL_PAD ( 3365): preload.h: __preload_init(73) > get shutdown function
05-30 16:45:59.768+0900 D/AUL_PAD ( 3365): preexec.h: __preexec_init(76) > preexec start
05-30 16:45:59.768+0900 D/AUL_PAD ( 3365): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
05-30 16:45:59.768+0900 D/AUL     ( 3365): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
05-30 16:45:59.768+0900 D/AUL     ( 3365): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
05-30 16:45:59.768+0900 D/AUL     ( 3365): process_pool.c: __connect_to_launchpad(132) > send(3365) : 4
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
05-30 16:45:59.778+0900 D/AUL_PAD ( 2955): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3365
05-30 16:45:59.778+0900 D/AUL     ( 3365): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
05-30 16:45:59.798+0900 E/RESOURCED( 2880): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.151
05-30 16:45:59.918+0900 D/STARTER ( 2876): lock_mgr.c: _lock_create_cb(306) > [_lock_create_cb:306] lockw(0xb8ebffb8), lock_pid(2887)
05-30 16:45:59.928+0900 E/STARTER ( 2876): window_mgr.c: window_mgr_set_effect(239) > [window_mgr_set_effect:239] (ret != 1) -> window_mgr_set_effect() return
05-30 16:45:59.948+0900 D/AUL_PAD ( 3365): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
05-30 16:45:59.948+0900 D/AUL_PAD ( 3365): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
05-30 16:45:59.958+0900 D/AUL_PAD ( 3365): launchpad_loader.c: main(693) > [candidate] ecore handler add
05-30 16:45:59.958+0900 D/AUL_PAD ( 3365): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
05-30 16:46:00.218+0900 D/LOCKSCREEN( 2887): lockscreen.c: lockscreen_lcd_off_count_raise(133) > [lockscreen_lcd_off_count_raise:133:D] count for lcd off timer : 0
05-30 16:46:00.218+0900 E/EFL     ( 2887): eo<2887> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80013ea0 is not pointing to a valid object. Maybe it has already been freed.
05-30 16:46:00.218+0900 E/EFL     ( 2887): eo<2887> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80013ea0) is an invalid ref.
05-30 16:46:00.218+0900 D/LOCKSCREEN( 2887): default_lock.c: _default_lock_mouse_down_cb(115) > [_default_lock_mouse_down_cb:115:D] clicked x(203), y(825)
05-30 16:46:00.218+0900 D/LOCKSCREEN( 2887): default_lock.c: _default_lock_mouse_down_cb(125) > [_default_lock_mouse_down_cb:125:D] touch upper y : 38
05-30 16:46:00.218+0900 D/LOCKSCREEN( 2887): default_lock.c: _default_lock_mouse_down_cb(137) > [_default_lock_mouse_down_cb:137:D] camera icon : x(559), y(1119), w(124), h(124)
05-30 16:46:00.288+0900 D/LOCKSCREEN( 2887): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496130360) formatted(Tue, May 30)
05-30 16:46:00.288+0900 D/LOCKSCREEN( 2887): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496130360) formatted(4:46)
05-30 16:46:00.288+0900 D/LOCKSCREEN( 2887): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496130360) formatted(PM)
05-30 16:46:00.398+0900 D/LOCKSCREEN( 2887): default_lock.c: _default_lock_mouse_up_cb(214) > [_default_lock_mouse_up_cb:214:D] exit lockscreen
05-30 16:46:00.428+0900 D/LOCKSCREEN( 2887): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496130360) formatted(Tue, May 30)
05-30 16:46:00.428+0900 D/LOCKSCREEN( 2887): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496130360) formatted(4:46)
05-30 16:46:00.428+0900 D/LOCKSCREEN( 2887): lock_time.c: __util_time_formatted_time_get(345) > [__util_time_formatted_time_get:345:D] time(1496130360) formatted(PM)
05-30 16:46:00.508+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x60006f 
05-30 16:46:00.928+0900 D/LOCKSCREEN( 2887): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-30 16:46:00.928+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: ui_app_exit(799) > ui_app_exit
05-30 16:46:00.928+0900 D/LOCKSCREEN( 2887): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-30 16:46:00.938+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: ui_app_exit(799) > ui_app_exit
05-30 16:46:00.938+0900 D/LOCKSCREEN( 2887): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-30 16:46:00.938+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: ui_app_exit(799) > ui_app_exit
05-30 16:46:00.938+0900 D/LOCKSCREEN( 2887): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-30 16:46:00.938+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: ui_app_exit(799) > ui_app_exit
05-30 16:46:00.938+0900 D/LOCKSCREEN( 2887): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-30 16:46:00.938+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: ui_app_exit(799) > ui_app_exit
05-30 16:46:00.938+0900 D/LOCKSCREEN( 2887): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-30 16:46:00.938+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: ui_app_exit(799) > ui_app_exit
05-30 16:46:00.938+0900 D/LOCKSCREEN( 2887): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-30 16:46:00.938+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: ui_app_exit(799) > ui_app_exit
05-30 16:46:00.938+0900 D/LOCKSCREEN( 2887): default_lock.c: _vi_effect_end_cb(263) > [_vi_effect_end_cb:263:D] _vi_effect_end_cb
05-30 16:46:00.938+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: ui_app_exit(799) > ui_app_exit
05-30 16:46:00.938+0900 D/AUL     ( 2887): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
05-30 16:46:00.938+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 22
05-30 16:46:00.938+0900 W/AUL_AMD ( 2787): amd_request.c: __request_handler(1056) > app status : 5
05-30 16:46:00.938+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(2887) status(5)
05-30 16:46:00.938+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(2887) appid(org.tizen.lockscreen) pkgid(org.tizen.lockscreen) status(5)
05-30 16:46:00.938+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.lockscreen
05-30 16:46:00.938+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2887, appid: org.tizen.lockscreen, status: bg
05-30 16:46:00.938+0900 D/RESOURCED( 2880): heart-cpu.c: heart_cpu_background_state(230) > heart_cpu_background_state : pid = 2887, appname = org.tizen.lockscreen, pkgname = org.tizen.lockscreen
05-30 16:46:00.938+0900 D/RESOURCED( 2880): cpu.c: cpu_background_state(233) > cpu_background_state : pid = 2887, appname = org.tizen.lockscreen
05-30 16:46:00.938+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 2887
05-30 16:46:00.938+0900 D/RESOURCED( 2880): proc-process.c: proc_backgrd_manage(170) > BACKGRD : process 2929 increase lru 2
05-30 16:46:00.938+0900 D/RESOURCED( 2880): proc-process.c: proc_backgrd_manage(179) > BACKGRD : process 2929 set score 330 (before 300)
05-30 16:46:00.938+0900 D/RESOURCED( 2880): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2929, proc_name: org.tizen.volume, cg_name: background, oom_score_adj: 330
05-30 16:46:00.938+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/background//cgroup.procs, value 2929
05-30 16:46:00.938+0900 D/APP_CORE( 2887): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
05-30 16:46:00.948+0900 D/APP_CORE( 2887): appcore-efl.c: __after_loop(1169) > [APP 2887] PAUSE before termination
05-30 16:46:00.948+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
05-30 16:46:00.948+0900 D/LOCKSCREEN( 2887): lockscreen.c: _pause_app(255) > [_pause_app:255:D] _pause_app
05-30 16:46:00.958+0900 I/CAPI_APPFW_APPLICATION( 2887): app_main.c: _ui_app_appcore_terminate(662) > app_appcore_terminate
05-30 16:46:00.958+0900 D/LOCKSCREEN( 2887): lockscreen.c: _terminate_app(243) > [_terminate_app:243:D] _terminate_app
05-30 16:46:00.968+0900 D/COM_CORE( 2887): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(48) for pid(-1)
05-30 16:46:00.968+0900 D/COM_CORE( 2887): com-core_thread.c: client_cb(378) > [SECURE_LOG] Thread is canceled
05-30 16:46:00.968+0900 D/COM_CORE( 2887): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (48)
05-30 16:46:00.968+0900 D/COM_CORE( 2957): secure_socket.c: secure_socket_recv_with_fd(610) > [SECURE_LOG] Disconnected
05-30 16:46:00.968+0900 E/COM_CORE( 2887): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -125
05-30 16:46:00.968+0900 E/LOCKSCREEN( 2887): contextual_event.c: lock_contextual_event_page_get(388) > [lock_contextual_event_page_get:388:E] (!s_info.box) -> lock_contextual_event_page_get() return
05-30 16:46:00.968+0900 E/LOCKSCREEN( 2887): contextual_event.c: lock_contextual_event_missed_event_del(643) > [lock_contextual_event_missed_event_del:643:E] (!page) -> lock_contextual_event_missed_event_del() return
05-30 16:46:00.968+0900 D/LOCKSCREEN( 2887): sim_state.c: lock_sim_state_deinit(640) > [lock_sim_state_deinit:640:D] De-initialization
05-30 16:46:00.968+0900 D/CALL_MGR_CLIENT( 2887): <LIB:__cm_unset_cb:313> noti_id: '/org/tizen/callmgr:org.tizen.callmgr:CallStatus'
05-30 16:46:00.968+0900 D/CALL_MGR_CLIENT( 2887): <LIB:__cm_evt_list_key_destroyed_cb:341> __cm_evt_list_key_destroyed_cb()
05-30 16:46:00.968+0900 W/CALL_MGR_CLIENT( 2887): <LIB:__cm_evt_list_key_destroyed_cb:345> Key[/org/tizen/callmgr:org.tizen.callmgr:CallStatus] is removed from hash table.
05-30 16:46:00.968+0900 D/CALL_MGR_CLIENT( 2887): <LIB:__cm_evt_list_value_destroyed_cb:352> __cm_evt_list_value_destroyed_cb()
05-30 16:46:00.968+0900 D/CALL_MGR_CLIENT( 2887): <LIB:cm_deinit:444> cm_deinit
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=16
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 15, key = 16, type = 1
05-30 16:46:00.968+0900 D/SYSTEM-SETTINGS( 2887): system_setting_platform.c: system_setting_unset_changed_callback_time_changed(1669) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_time_changed. [0m
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=14
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 13, key = 14, type = 2
05-30 16:46:00.968+0900 D/SYSTEM-SETTINGS( 2887): system_setting_platform.c: system_setting_unset_changed_callback_locale_timeformat_24hour(1614) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_timeformat_24hour. [0m
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=12
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 11, key = 12, type = 0
05-30 16:46:00.968+0900 D/SYSTEM-SETTINGS( 2887): system_setting_platform.c: system_setting_unset_changed_callback_locale_country(1504) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_locale_country. [0m
05-30 16:46:00.968+0900 D/LOCKSCREEN( 2887): property.c: lock_property_unregister(254) > [lock_property_unregister:254:D] unregister property cb
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=17
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 16, key = 17, type = 2
05-30 16:46:00.968+0900 D/SYSTEM-SETTINGS( 2887): system_setting_platform.c: system_setting_unset_changed_callback_sound_lock(1697) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_lock. [0m
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_unset_changed_cb(589) > Enter [system_settings_unset_changed_cb]
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=19
05-30 16:46:00.968+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2887): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 18, key = 19, type = 2
05-30 16:46:00.968+0900 D/SYSTEM-SETTINGS( 2887): system_setting_platform.c: system_setting_unset_changed_callback_sound_touch(1810) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_unset_changed_callback_sound_touch. [0m
05-30 16:46:00.978+0900 D/DATA_PROVIDER_MASTER( 2957): notification_service.c: service_thread_main(851) > [SECURE_LOG] TCB: 0xb2a009c0 is terminated
05-30 16:46:00.978+0900 D/DATA_PROVIDER_MASTER( 2957): service_common.c: tcb_destroy(613) > [SECURE_LOG] Thread returns: 0xffffff83
05-30 16:46:00.978+0900 D/RESOURCED( 2880): proc-process.c: proc_backgrd_manage(189) > detect favorite application : org.tizen.lockscreen
05-30 16:46:00.978+0900 D/INDICATOR( 2886): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
05-30 16:46:00.978+0900 D/RESOURCED( 2880): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2887, proc_name: org.tizen.lockscreen, cg_name: favorite, oom_score_adj: 270
05-30 16:46:00.978+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/favorite//cgroup.procs, value 2887
05-30 16:46:00.978+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
05-30 16:46:00.978+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
05-30 16:46:00.988+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:46 4 h"
05-30 16:46:00.988+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:46"
05-30 16:46:00.988+0900 D/INDICATOR( 2886): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;46"
05-30 16:46:00.988+0900 D/INDICATOR( 2886): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147242537 Time: <font_size=33>4&#x2236;46</font_size> <font_size=32>PM</font_size></font>
05-30 16:46:01.008+0900 D/LOCKSCREEN( 2887): dbus.c: lock_dbus_fini(328) > [lock_dbus_fini:328:D] DBUS connection is closed
05-30 16:46:01.008+0900 E/EFL     ( 2887): eo<2887> lib/eo/eo_ptr_indirection.x:294 _eo_obj_pointer_get() obj_id 0x80006433 is not pointing to a valid object. Maybe it has already been freed.
05-30 16:46:01.008+0900 E/EFL     ( 2887): eo<2887> lib/eo/eo.c:485 _eo_do_internal() Obj (0x80006433) is an invalid ref.
05-30 16:46:01.218+0900 E/E17     ( 2739): e_border.c: e_border_hide(2248) > BD_HIDE(0x01000007), visible:1
05-30 16:46:01.218+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-30 16:46:01.228+0900 E/E17_TZSH( 2739): policy_tzsh.c: _policy_tzsh_service_destroy(118) > TZSH SERVICE DESTROY.. WIN:b391d5c0, role:118
05-30 16:46:01.228+0900 W/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=2960
05-30 16:46:01.238+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_wininfo_del(160) > [PROCESSMGR] delete anr_trigger_timer!
05-30 16:46:01.248+0900 D/INDICATOR( 2886): main.c: _property_changed_cb(432) > UNSNIFF API 1000007
05-30 16:46:01.268+0900 D/INDICATOR( 2886): util.c: util_signal_emit_by_win(116) > emission bg.opaque
05-30 16:46:01.268+0900 D/AUL_AMD ( 2787): amd_request.c: __sigchld_handler(1289) > Sig child 2887
05-30 16:46:01.268+0900 I/AUL_AMD ( 2787): amd_request.c: __release_app(1259) > [SECURE_LOG] appid: org.tizen.lockscreen
05-30 16:46:01.268+0900 D/AUL_AMD ( 2787): amd_request.c: __check_restart(471) > ri (b8477d28)
05-30 16:46:01.268+0900 D/AUL_AMD ( 2787): amd_request.c: __check_restart(472) > [SECURE_LOG] appid (org.tizen.lockscreen)
05-30 16:46:01.268+0900 W/AUL_AMD ( 2787): amd_request.c: __send_app_termination_signal(549) > send dead signal done
05-30 16:46:01.278+0900 D/INDICATOR( 2886): main.c: _rotate_window(229) > Indicator angle is 0 degree
05-30 16:46:01.278+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
05-30 16:46:01.278+0900 D/INDICATOR( 2886): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
05-30 16:46:01.278+0900 D/INDICATOR( 2886): main.c: _rotate_window(252) > port :: hide more icon
05-30 16:46:01.278+0900 D/STARTER ( 2876): starter.c: _check_dead_signal(181) > [_check_dead_signal:181] Process 2887 is termianted
05-30 16:46:01.278+0900 D/STARTER ( 2876): starter.c: _check_dead_signal(199) > [_check_dead_signal:199] lockscreen is dead
05-30 16:46:01.278+0900 E/STARTER ( 2876): lock_pwd_util.c: lock_pwd_util_win_visible_get(71) > [lock_pwd_util_win_visible_get:71] (!s_lock_pwd_util.lock_pwd_win) -> lock_pwd_util_win_visible_get() return
05-30 16:46:01.278+0900 D/STARTER ( 2876): lock_mgr.c: lock_mgr_unlock(339) > [lock_mgr_unlock:339] pwd win visible(0), lock type(1)
05-30 16:46:01.278+0900 D/STARTER ( 2876): lock_mgr.c: lock_mgr_idle_lock_state_set(253) > [lock_mgr_idle_lock_state_set:253] lock state : 0
05-30 16:46:01.278+0900 W/AUL_AMD ( 2787): amd_main.c: __app_dead_handler(324) > __app_dead_handler, pid: 2887
05-30 16:46:01.278+0900 W/AUL_AMD ( 2787): amd_main.c: __app_dead_handler(334) > app_group_leader_app, pid: 2887
05-30 16:46:01.278+0900 D/AUL_AMD ( 2787): amd_key.c: _unregister_key_event(179) > ===key stack===
05-30 16:46:01.278+0900 E/AUL_AMD ( 2787): amd_launch.c: _revoke_temporary_permission(2129) > list or callee_label was null
05-30 16:46:01.278+0900 D/AUL_AMD ( 2787): amd_status.c: __remove_pkg_info(266) > ~STATUS_SERVICE : appid(org.tizen.lockscreen)
05-30 16:46:01.278+0900 D/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
05-30 16:46:01.278+0900 E/AUL     ( 2787): simple_util.c: __trm_app_info_send_socket(330) > access
05-30 16:46:01.278+0900 I/ESD     ( 2967): esd_main.c: __esd_app_dead_handler(1771) > pid: 2887
05-30 16:46:01.278+0900 W/STARTER ( 2876): window_mgr.c: _pwd_transient_unset(159) > [_pwd_transient_unset:159] 0x1000007 is not transient
05-30 16:46:01.288+0900 D/RESOURCED( 2880): proc-monitor.c: proc_dbus_aul_terminated(1080) > received terminated process : pid 2887
05-30 16:46:01.288+0900 D/RESOURCED( 2880): appinfo-list.c: resourced_appinfo_put(132) > appid org.tizen.lockscreen, pkgname = org.tizen.lockscreen, ref = 0
05-30 16:46:01.298+0900 D/INDICATOR( 2886): util.c: util_signal_emit(84) > [SECURE_LOG] util_signal_emit[84]	 "emission clock.font.12"
05-30 16:46:01.308+0900 I/TZSH    ( 2965): tzsh.c: _tizen_ws_shell_cb_service_remove(56) > INF: Removed service: 'lockscreen'
05-30 16:46:01.308+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-30 16:46:01.328+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(838) > __request_handler: 15
05-30 16:46:01.328+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-30 16:46:01.328+0900 D/PKGMGR_INFO( 2787): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
05-30 16:46:01.328+0900 D/AUL_AMD ( 2787): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 2960 is org.example.example
05-30 16:46:01.328+0900 D/AUL_AMD ( 2787): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 2960 : 0
05-30 16:46:01.328+0900 D/AUL     ( 2969): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
05-30 16:46:01.338+0900 D/VOLUME  ( 2929): control.c: _idle_lock_state_vconf_changed_cb(810) > [_idle_lock_state_vconf_changed_cb:810] idle lock state : 0
05-30 16:46:01.338+0900 D/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2891) > pid(2960) status(3)
05-30 16:46:01.338+0900 D/AUL_AMD ( 2787): amd_key.c: _key_ungrab(265) > _key_ungrab, win : a00002
05-30 16:46:01.338+0900 W/AUL_AMD ( 2787): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
05-30 16:46:01.338+0900 W/AUL_AMD ( 2787): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
05-30 16:46:01.338+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(456) > pid(2960) status(3)
05-30 16:46:01.338+0900 D/AUL_AMD ( 2787): amd_status.c: _status_update_app_info_list(468) > pid(2960) appid(org.example.example) pkgid(org.example.example) status(3)
05-30 16:46:01.338+0900 D/AUL     ( 2787): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
05-30 16:46:01.338+0900 W/AUL     ( 2787): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2960, appid: org.example.example, status: fg
05-30 16:46:01.338+0900 D/RESOURCED( 2880): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 2960
05-30 16:46:01.338+0900 D/RESOURCED( 2880): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 2960, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
05-30 16:46:01.338+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 2960
05-30 16:46:01.378+0900 D/RESOURCED( 2880): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 2960, appname = org.example.example, pkgname = org.example.example
05-30 16:46:01.378+0900 D/RESOURCED( 2880): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 2960, appname = org.example.example
05-30 16:46:01.378+0900 D/RESOURCED( 2880): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2960
05-30 16:46:01.378+0900 I/RESOURCED( 2880): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
05-30 16:46:01.378+0900 I/RESOURCED( 2880): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
05-30 16:46:01.418+0900 D/APP_CORE( 2960): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:2000002 fully_obscured 0
05-30 16:46:01.418+0900 D/APP_CORE( 2960): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active 0
05-30 16:46:01.418+0900 D/APP_CORE( 2960): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
05-30 16:46:01.418+0900 I/APP_CORE( 2960): appcore-efl.c: __do_app(496) > [APP 2960] Event: RESUME State: CREATED
05-30 16:46:01.418+0900 D/LAUNCH  ( 2960): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
05-30 16:46:01.418+0900 D/APP_CORE( 2960): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
05-30 16:46:01.418+0900 D/APP_CORE( 2960): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
05-30 16:46:01.418+0900 D/APP_CORE( 2960): appcore-efl.c: __do_app(607) > [APP 2960] RESUME
05-30 16:46:01.418+0900 I/APP_CORE( 2960): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
05-30 16:46:01.418+0900 I/APP_CORE( 2960): appcore-efl.c: __do_app(614) > [APP 2960] Initial Launching, call the resume_cb
05-30 16:46:01.418+0900 I/CAPI_APPFW_APPLICATION( 2960): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
05-30 16:46:01.418+0900 D/LAUNCH  ( 2960): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
05-30 16:46:01.418+0900 D/LAUNCH  ( 2960): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
05-30 16:46:01.418+0900 D/APP_CORE( 2960): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
05-30 16:46:01.418+0900 E/APP_CORE( 2960): appcore-efl.c: __trm_app_info_send_socket(242) > access
05-30 16:46:05.268+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_value_string(540) > Enter [system_settings_get_value_string]
05-30 16:46:05.268+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
05-30 16:46:05.268+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
05-30 16:46:05.268+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
05-30 16:46:05.268+0900 D/SYSTEM-SETTINGS( 2960): system_setting_platform.c: system_setting_get_locale_timezone(1620) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_timezone. [0m
05-30 16:46:05.268+0900 I/SYSTEM-SETTINGS( 2960): system_setting_platform.c: system_setting_get_locale_timezone(1631) > [SECURE_LOG] [0;36mtzpath : Asia/Seoul [0m
05-30 16:46:05.328+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_value_string(540) > Enter [system_settings_get_value_string]
05-30 16:46:05.328+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
05-30 16:46:05.328+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
05-30 16:46:05.328+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
05-30 16:46:05.328+0900 D/SYSTEM-SETTINGS( 2960): system_setting_platform.c: system_setting_get_locale_timezone(1620) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_timezone. [0m
05-30 16:46:05.328+0900 I/SYSTEM-SETTINGS( 2960): system_setting_platform.c: system_setting_get_locale_timezone(1631) > [SECURE_LOG] [0;36mtzpath : Asia/Seoul [0m
05-30 16:46:05.328+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_value_string(540) > Enter [system_settings_get_value_string]
05-30 16:46:05.328+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
05-30 16:46:05.328+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
05-30 16:46:05.328+0900 E/TIZEN_N_SYSTEM_SETTINGS( 2960): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
05-30 16:46:05.328+0900 D/SYSTEM-SETTINGS( 2960): system_setting_platform.c: system_setting_get_locale_timezone(1620) > [SECURE_LOG] [0;35mENTER FUNCTION: system_setting_get_locale_timezone. [0m
05-30 16:46:05.328+0900 I/SYSTEM-SETTINGS( 2960): system_setting_platform.c: system_setting_get_locale_timezone(1631) > [SECURE_LOG] [0;36mtzpath : Asia/Seoul [0m
05-30 16:46:05.458+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6000fa 
05-30 16:46:05.628+0900 E/CAPI_NETWORK_WIFI( 2886): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
05-30 16:46:05.628+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
05-30 16:46:05.628+0900 E/INDICATOR( 2886): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
05-30 16:46:05.628+0900 E/INDICATOR( 2886): 
05-30 16:46:05.948+0900 D/AUL_AMD ( 2787): amd_status.c: __app_terminate_timer_cb(442) > pid(2887)
05-30 16:46:05.948+0900 W/AUL_AMD ( 2787): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
05-30 16:46:06.468+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0x2000002
05-30 16:46:07.008+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x60002e  register trigger_timer!  pointed_win=0x6000fa 
05-30 16:46:07.058+0900 I/user_tag( 2960): current05-05pre
05-30 16:46:07.118+0900 D/AUL_PAD ( 2955): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
05-30 16:46:07.118+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
05-30 16:46:07.118+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
05-30 16:46:07.118+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
05-30 16:46:07.118+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
05-30 16:46:07.118+0900 D/AUL_PAD ( 2955): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
05-30 16:46:07.118+0900 D/AUL_PAD ( 2955): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
05-30 16:46:07.118+0900 I/AUL_PAD ( 2955): sigchild.h: __launchpad_process_sigchld(161) > dead_pid = 2960 pgid = 2960
05-30 16:46:07.118+0900 I/AUL_PAD ( 2955): sigchild.h: __sigchild_action(142) > dead_pid(2960)
05-30 16:46:07.128+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
05-30 16:46:07.158+0900 E/E17     ( 2739): e_border.c: e_border_show(2088) > BD_SHOW(0x01600002)
05-30 16:46:07.168+0900 W/CRASH_MANAGER( 3368): worker.c: worker_job(1204) > 1102960657861149613036
