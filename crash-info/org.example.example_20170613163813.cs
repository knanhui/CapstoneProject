S/W Version Information
Model: Emulator
Tizen-Version: 2.4.0
Build-Number: Tizen-2.4.0_Mobile-Emulator_20160526.1540
Build-Date: 2016.05.26 15:40:57

Crash Information
Process Name: example
PID: 3300
Date: 2017-06-13 16:38:13+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb871db38
ebp = 0xbf86ca88, esp = 0xbf86ca20
eax = 0xb871db38, ebx = 0xb6c210d4
ecx = 0xb382e000, edx = 0x00000000
eip = 0xb6bff1f6

Memory Information
MemTotal:      123 KB
MemFree:        37 KB
Buffers:         3 KB
Cached:     151276 KB
VmPeak:     141512 KB
VmSize:     141512 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27436 KB
VmRSS:       27436 KB
VmData:      55568 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       34616 KB
VmPTE:         108 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 3300 TID = 3300
3300 3301 3510 3512 3516 

Maps Information
b2bbf000 b2bc9000 r-xp /usr/lib/libfeedback.so.0.1.4
b2bcf000 b2bdb000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b2bdc000 b2bfd000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b2c02000 b2c03000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b2c04000 b2c09000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b2c0a000 b2c0b000 r-xp /usr/lib/libxshmfence.so.1.0.0
b2c0c000 b2c0e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b2c0f000 b2c11000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b2c12000 b2c1e000 r-xp /usr/lib/libdrm.so.2.4.0
b2c1f000 b2c22000 r-xp /usr/lib/libdri2.so.0.0.0
b2c23000 b2c2d000 r-xp /usr/lib/libtbm.so.1.0.0
b2c2e000 b2c2f000 r-xp /usr/lib/libgthread-2.0.so.0.4400.1
b2c30000 b2c45000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b2c46000 b2c58000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b345a000 b348b000 r-xp /usr/lib/libidn.so.11.5.44
b348c000 b34ae000 r-xp /usr/lib/libnghttp2.so.5.4.0
b34af000 b34bf000 r-xp /usr/lib/libcares.so.2.1.0
b34c0000 b34c9000 r-xp /usr/lib/libeventsystem.so.0.0.1
b34ca000 b34d0000 r-xp /usr/lib/libmessage-port.so.1.2.2.1
b34d1000 b34e7000 r-xp /usr/lib/libalarm.so.0.0.0
b34e9000 b34f2000 r-xp /usr/lib/libefl-extension.so.0.1.0
b34f3000 b356a000 r-xp /usr/lib/libcurl.so.4.3.0
b356c000 b357e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b357f000 b3582000 r-xp /usr/lib/libcapi-message-port.so.1.2.2.1
b3583000 b3586000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b3587000 b35a8000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b35af000 b35b0000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b35b1000 b35b2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b35b3000 b35b6000 r-xp /usr/lib/libdrm_vigs.so.10.0.0
b35b7000 b35ba000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b36c2000 b36c8000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b36c9000 b380d000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b381d000 b382d000 r-xp /opt/usr/apps/org.example.example/bin/example
b382f000 b3868000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b426b000 b4276000 r-xp /lib/libnss_files-2.20-2014.11.so
b4278000 b4283000 r-xp /lib/libnss_nis-2.20-2014.11.so
b4285000 b429c000 r-xp /lib/libnsl-2.20-2014.11.so
b42a0000 b42a8000 r-xp /lib/libnss_compat-2.20-2014.11.so
b42aa000 b42ce000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.6
b42cf000 b42d0000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b42d1000 b42d4000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b42d5000 b42dc000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b42dd000 b42e7000 r-xp /usr/lib/libsensord-share.so
b42e8000 b4304000 r-xp /usr/lib/libsensor.so.1.2.0
b4306000 b430f000 r-xp /usr/lib/libappcore-common.so.1.1
b4312000 b4314000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b4329000 b432b000 r-xp /usr/lib/libXau.so.6.0.0
b432c000 b434e000 r-xp /usr/lib/libxcb.so.1.1.0
b4350000 b4359000 r-xp /lib/libcrypt-2.20-2014.11.so
b4382000 b4384000 r-xp /usr/lib/libiri.so
b4385000 b43ab000 r-xp /lib/libexpat.so.1.5.2
b43ad000 b4418000 r-xp /usr/lib/libssl.so.1.0.0
b441e000 b442a000 r-xp /usr/lib/libethumb.so.1.13.0
b442b000 b442f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4430000 b4681000 r-xp /usr/lib/libcrypto.so.1.0.0
b5bfc000 b5c0c000 r-xp /usr/lib/libXi.so.6.1.0
b5c0d000 b5c0f000 r-xp /usr/lib/libXgesture.so.7.0.0
b5c10000 b5c16000 r-xp /usr/lib/libXtst.so.6.1.0
b5c17000 b5c21000 r-xp /usr/lib/libXrender.so.1.3.0
b5c22000 b5c2b000 r-xp /usr/lib/libXrandr.so.2.2.0
b5c2d000 b5c2f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5c30000 b5c35000 r-xp /usr/lib/libXfixes.so.3.1.0
b5c36000 b5c48000 r-xp /usr/lib/libXext.so.6.4.0
b5c49000 b5c4b000 r-xp /usr/lib/libXdamage.so.1.1.0
b5c4c000 b5c4e000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5c50000 b5d92000 r-xp /usr/lib/libX11.so.6.3.0
b5d96000 b5da0000 r-xp /usr/lib/libXcursor.so.1.0.2
b5da1000 b5db7000 r-xp /usr/lib/libudev.so.1.6.0
b5dba000 b5dbe000 r-xp /lib/libattr.so.1.1.0
b5dbf000 b5dee000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5df0000 b5df6000 r-xp /usr/lib/libffi.so.6.0.2
b5df7000 b5e1a000 r-xp /lib/libz.so.1.2.8
b5e1b000 b5e1e000 r-xp /usr/lib/libgmodule-2.0.so.0.4400.1
b5e1f000 b5f7b000 r-xp /usr/lib/libxml2.so.2.9.2
b5f81000 b6068000 r-xp /usr/lib/libstdc++.so.6.0.20
b6075000 b6078000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6079000 b609b000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b609c000 b60b0000 r-xp /lib/libresolv-2.20-2014.11.so
b60b4000 b60d8000 r-xp /usr/lib/liblzma.so.5.0.3
b60d9000 b60db000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b60dd000 b60e7000 r-xp /usr/lib/libembryo.so.1.13.0
b60e8000 b6111000 r-xp /usr/lib/libpng12.so.0.50.0
b6112000 b615b000 r-xp /usr/lib/libjpeg.so.8.0.2
b616c000 b6173000 r-xp /lib/librt-2.20-2014.11.so
b6175000 b6194000 r-xp /usr/lib/libector.so.1.13.0
b6197000 b61c4000 r-xp /usr/lib/liblua-5.1.so
b61c5000 b6255000 r-xp /usr/lib/libfreetype.so.6.11.3
b6259000 b6297000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6298000 b62ae000 r-xp /usr/lib/libfribidi.so.0.3.1
b62af000 b6308000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b630b000 b6356000 r-xp /lib/libm-2.20-2014.11.so
b6358000 b636a000 r-xp /usr/lib/libeio.so.1.13.0
b636b000 b636e000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b636f000 b6375000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b6376000 b6399000 r-xp /usr/lib/libefreet.so.1.13.0
b639c000 b63c7000 r-xp /usr/lib/libeldbus.so.1.13.0
b63c8000 b63fc000 r-xp /usr/lib/libecore_con.so.1.13.0
b63fe000 b6407000 r-xp /usr/lib/libecore_imf.so.1.13.0
b6408000 b6411000 r-xp /usr/lib/libethumb_client.so.1.13.0
b6412000 b6425000 r-xp /usr/lib/libeo.so.1.13.0
b6427000 b643a000 r-xp /usr/lib/libecore_input.so.1.13.0
b643b000 b6442000 r-xp /usr/lib/libecore_file.so.1.13.0
b6443000 b6466000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6467000 b6493000 r-xp /usr/lib/libeet.so.1.13.0
b649c000 b6507000 r-xp /usr/lib/libeina.so.1.13.0
b650a000 b6521000 r-xp /usr/lib/libefl.so.1.13.0
b6523000 b668a000 r-xp /usr/lib/libicuuc.so.51.1
b6698000 b68a4000 r-xp /usr/lib/libicui18n.so.51.1
b68ac000 b68fb000 r-xp /usr/lib/libecore_x.so.1.13.0
b68fd000 b6917000 r-xp /lib/libgcc_s-4.9.so.1
b6919000 b691d000 r-xp /lib/libcap.so.2.21
b691e000 b6964000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6965000 b696c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b696e000 b69c0000 r-xp /usr/lib/libgobject-2.0.so.0.4400.1
b69c2000 b6b4d000 r-xp /usr/lib/libgio-2.0.so.0.4400.1
b6b52000 b6c20000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6c23000 b6c27000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6c28000 b6c37000 r-xp /usr/lib/libvconf.so.0.2.45
b6c38000 b6c3b000 r-xp /usr/lib/libvasum.so.0.3.1
b6c3c000 b6c3f000 r-xp /usr/lib/libttrace.so.1.1
b6c41000 b6c45000 r-xp /usr/lib/libiniparser.so.0
b6c46000 b6c76000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6c77000 b6c80000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6c81000 b6ca6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6ca7000 b6cb7000 r-xp /usr/lib/libunwind.so.8.0.1
b6cc1000 b6e6f000 r-xp /lib/libc-2.20-2014.11.so
b6e77000 b6fba000 r-xp /usr/lib/libglib-2.0.so.0.4400.1
b6fbc000 b7014000 r-xp /usr/lib/libdbus-1.so.3.8.11
b7015000 b7049000 r-xp /usr/lib/libsystemd.so.0.4.0
b704c000 b7120000 r-xp /usr/lib/libedje.so.1.13.0
b7123000 b714f000 r-xp /usr/lib/libecore.so.1.13.0
b7160000 b7386000 r-xp /usr/lib/libevas.so.1.13.0
b73ae000 b73c6000 r-xp /lib/libpthread-2.20-2014.11.so
b73ca000 b7744000 r-xp /usr/lib/libelementary.so.1.13.0
b7764000 b7768000 r-xp /usr/lib/libsmack.so.1.0.0
b7769000 b7772000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7773000 b7776000 r-xp /usr/lib/libdlog.so.0.0.0
b7777000 b777c000 r-xp /usr/lib/libbundle.so.0.1.22
b777d000 b7780000 r-xp /lib/libdl-2.20-2014.11.so
b7782000 b77a7000 r-xp /usr/lib/libaul.so.0.1.0
b77aa000 b77ac000 r-xp /usr/lib/libappsvc.so.0.1.0
b77ad000 b77b2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b77b3000 b77ba000 r-xp /usr/lib/libappcore-efl.so.1.1
b77bc000 b77c1000 r-xp /usr/lib/libsys-assert.so
b77c4000 b77c5000 r-xp [vdso]
b77c5000 b77e7000 r-xp /lib/ld-2.20-2014.11.so
b77e9000 b77f1000 r-xp /usr/bin/launchpad-loader
End of Maps Information

Callstack Information (PID:3300)
Call Stack Count: 9
 0: (0xb6bff1f6) [/usr/lib/libsqlite3.so.0] + 0xad1f6
 1: open_setting_db + 0x116 (0xb3828236) [/opt/usr/apps/org.example.example/bin/example] + 0xb236
 2: app_pause + 0x2f (0xb3826caf) [/opt/usr/apps/org.example.example/bin/example] + 0x9caf
 3: (0xb77aece2) [/usr/lib/libcapi-appfw-application.so.0] + 0x1ce2
 4: appcore_efl_main + 0x85a (0xb77b715a) [/usr/lib/libappcore-efl.so.1] + 0x415a
 5: ui_app_main + 0x140 (0xb77afc80) [/usr/lib/libcapi-appfw-application.so.0] + 0x2c80
 6: main + 0x2a5 (0xb3826bd5) [/opt/usr/apps/org.example.example/bin/example] + 0x9bd5
 7: (0xb77eb148) [/opt/usr/apps/org.example.example/bin/example] + 0xb77eb148
 8: __libc_start_main + 0xde (0xb6cd8e4e) [/lib/libc.so.6] + 0x17e4e
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
772): amd_launch.c: _start_app(2224) > no caller appid info, ret: -1
06-13 16:35:22.098+0900 W/AUL_AMD ( 2772): amd_launch.c: _start_app(2233) > caller pid : 3505
06-13 16:35:22.098+0900 E/AUL_AMD ( 2772): amd_appinfo.c: appinfo_get_value(881) > appinfo get value: Invalid argument, 17
06-13 16:35:22.108+0900 W/AUL_AMD ( 2772): amd_launch.c: __send_proc_prelaunch_signal(433) > [SECURE_LOG] send a prelaunch signal done: appid(org.example.example) pkgid(org.example.example) attribute(600)
06-13 16:35:22.108+0900 D/AUL_AMD ( 2772): amd_launch.c: _start_app(2648) > process_pool: false
06-13 16:35:22.108+0900 D/AUL_AMD ( 2772): amd_launch.c: _start_app(2651) > h/w acceleration: SYS
06-13 16:35:22.108+0900 D/AUL_AMD ( 2772): amd_launch.c: _start_app(2653) > [SECURE_LOG] appid: org.example.example
06-13 16:35:22.108+0900 W/AUL_AMD ( 2772): amd_launch.c: _start_app(2665) > pad pid(-5)
06-13 16:35:22.108+0900 D/AUL_AMD ( 2772): amd_launch.c: __set_appinfo_for_launchpad(2951) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-13 16:35:22.108+0900 D/AUL_AMD ( 2772): amd_launch.c: __set_appinfo_for_launchpad(2954) > bundle_del error: -126
06-13 16:35:22.108+0900 D/AUL     ( 2772): app_sock.c: __app_send_raw(285) > pid(-5) : cmd(0)
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x1
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x0
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: main(696) > pfds[LAUNCH_PAD].revents & POLLIN
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: __launchpad_main_loop(464) > [SECURE_LOG] pkg name : org.example.example
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: __launchpad_main_loop(488) > [SECURE_LOG] exec : /opt/usr/apps/org.example.example/bin/example
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: __launchpad_main_loop(490) > [SECURE_LOG] internal pool : false
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: __launchpad_main_loop(491) > [SECURE_LOG] hwacc : SYS
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): process_pool.h: __get_launchpad_type(92) > [launchpad] launchpad type: COMMON(0)
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: __modify_bundle(236) > parsing app_path: No arguments
06-13 16:35:22.108+0900 W/AUL_PAD ( 2923): launchpad.c: __launchpad_main_loop(510) > Launch on type-based process-pool
06-13 16:35:22.108+0900 D/AUL     ( 2923): process_pool.c: __send_pkt_raw_data(219) > send(12) : 620 / 620
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: __send_launchpad_loader(413) > [SECURE_LOG] Request to candidate process, pid: 3300, bin path: /opt/usr/apps/org.example.example/bin/example
06-13 16:35:22.108+0900 W/AUL_PAD ( 2923): launchpad.c: __send_result_to_caller(265) > Check app launching
06-13 16:35:22.108+0900 D/AUL_PAD ( 2923): launchpad.c: __send_result_to_caller(297) > -- now wait cmdline changing --
06-13 16:35:22.108+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_prelaunch_signal_handler(531) > call proc_dbus_prelaunch_handler: appid = org.example.example, pkgid = org.example.example, flags = 1536
06-13 16:35:22.108+0900 D/RESOURCED( 2852): appinfo-list.c: resourced_appinfo_get(117) > appid org.example.example, pkgname = org.example.example, ref = 1
06-13 16:35:22.108+0900 E/RESOURCED( 2852): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_proces_fd_handler(498) > [candidate] ECORE_FD_READ
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_proces_fd_handler(513) > [candidate] recv_ret: 620, pkt->len: 612
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(389) > [SECURE_LOG] app id: org.example.example, launchpad type: 0
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __modify_bundle(276) > parsing app_path: No arguments
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(410) > [SECURE_LOG] app id: org.example.example
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(425) > [SECURE_LOG] pkg id: org.example.example
06-13 16:35:22.108+0900 D/AUL     ( 3300): smack_util.c: send_SIGUSR1_to_threads(127) > [SECURE_LOG] SIGUSR1 signal to the sub-thread (3301) is sent.
06-13 16:35:22.108+0900 D/AUL     ( 3300): smack_util.c: SIGUSR1_handler(75) > [SECURE_LOG] tid: 3301, signo: 10
06-13 16:35:22.108+0900 D/AUL     ( 3300): smack_util.c: set_app_smack_label(198) > signal count: 1, launchpad type: 0
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_prepare_exec(297) > [SECURE_LOG] [candidata] pkg_name : org.example.example / pkg_type : rpm / app_path : /opt/usr/apps/org.example.example/bin/example
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.example/bin/example##
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 1 : `zaybxcwdveuftgsh`##
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 3 : NAAAAAEEAAASAAAAX19BVUxfU1RBUlRUSU1FX18AEgAAADE0OTczMzkzMjIvMTA4MDg3AA==##
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 5 : KAAAAAEEAAATAAAAX19BVUxfQ0FMTEVSX1BJRF9fAAUAAAAzNTA1AA==##
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 6 : __AUL_INTERNAL_POOL__##
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_process_launchpad_main_loop(469) > [SECURE_LOG] input argument 7 : LAAAAAEEAAAWAAAAX19BVUxfSU5URVJOQUxfUE9PTF9fAAYAAABmYWxzZQA=##
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_proces_fd_handler(518) > [SECURE_LOG] [candidate] real app argv[0]: /opt/usr/apps/org.example.example/bin/example, real app argc: 8
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: __candidate_proces_fd_handler(522) > [candidate] ecore main loop quit
06-13 16:35:22.108+0900 D/AUL_PAD ( 3300): launchpad_loader.c: main(710) > [SECURE_LOG] [candidate] Launch real application (/opt/usr/apps/org.example.example/bin/example)
06-13 16:35:22.108+0900 I/CAPI_APPFW_APPLICATION( 3300): app_main.c: ui_app_main(788) > app_efl_main
06-13 16:35:22.108+0900 D/LAUNCH  ( 3300): appcore-efl.c: appcore_efl_main(1692) > [example:Application:main:done]
06-13 16:35:22.108+0900 D/APP_CORE( 3300): appcore-efl.c: __before_loop(1114) > elm_config_preferred_engine_set is not called
06-13 16:35:22.108+0900 D/APP_CORE( 3300): appcore.c: appcore_init(738) > [SECURE_LOG] dir : /opt/usr/apps/org.example.example/res/locale
06-13 16:35:22.108+0900 D/APP_CORE( 3300): appcore-i18n.c: update_region(94) > *****appcore setlocale=en_US.UTF-8
06-13 16:35:22.118+0900 D/APP_CORE( 3300): appcore.c: _appcore_init_suspend_dbus_handler(910) > [__SUSPEND__] suspend signal initialized
06-13 16:35:22.118+0900 D/AUL     ( 3300): app_sock.c: __create_server_sock(156) > pg path - already exists
06-13 16:35:22.118+0900 D/APP_CORE( 3300): appcore-efl.c: __before_loop(1134) > [SECURE_LOG] [__SUSPEND__] appcore initialized, appcore addr: 0xb430f520
06-13 16:35:22.118+0900 D/LAUNCH  ( 3300): appcore-efl.c: __before_loop(1136) > [example:Platform:appcore_init:done]
06-13 16:35:22.118+0900 I/CAPI_APPFW_APPLICATION( 3300): app_main.c: _ui_app_appcore_create(640) > app_appcore_create
06-13 16:35:22.208+0900 D/AUL_PAD ( 2923): launchpad.c: __send_result_to_caller(287) > -- now wait app mainloop creation --
06-13 16:35:22.208+0900 W/AUL     ( 2772): app_signal.c: aul_send_app_launch_request_signal(433) > send_app_launch_signal, pid: 3300, appid: org.example.example
06-13 16:35:22.208+0900 D/AUL     ( 2772): simple_util.c: __trm_app_info_send_socket(325) > __trm_app_info_send_socket
06-13 16:35:22.208+0900 E/AUL     ( 2772): simple_util.c: __trm_app_info_send_socket(330) > access
06-13 16:35:22.208+0900 D/AUL_AMD ( 2772): amd_launch.c: _start_app(2700) > add app group info
06-13 16:35:22.208+0900 E/AUL     ( 2772): amd_app_group.c: app_group_start_app(1032) > app_group_start_app
06-13 16:35:22.208+0900 D/AUL_AMD ( 2772): amd_status.c: _status_add_app_info_list(427) > pid(3300) appid(org.example.example) pkgid(org.example.example) comp(uiapp)
06-13 16:35:22.208+0900 D/AUL_AMD ( 2772): amd_status.c: __app_terminate_timer_cb(442) > pid(2928)
06-13 16:35:22.208+0900 W/AUL_AMD ( 2772): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-13 16:35:22.208+0900 D/AUL_AMD ( 2772): amd_status.c: __app_terminate_timer_cb(442) > pid(2928)
06-13 16:35:22.208+0900 W/AUL_AMD ( 2772): amd_status.c: __app_terminate_timer_cb(446) > send SIGKILL: No such process
06-13 16:35:22.208+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(876) > [SECURE_LOG] launch request org.example.example, 3300
06-13 16:35:22.208+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(878) > [SECURE_LOG] launch request org.example.example with pkgname
06-13 16:35:22.208+0900 E/RESOURCED( 2852): proc-main.c: proc_add_program_list(231) > not found ppi : org.example.example
06-13 16:35:22.208+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(888) > available memory = 321
06-13 16:35:22.268+0900 D/LAUNCH  ( 3300): appcore-efl.c: __before_loop(1154) > [example:Application:create:done]
06-13 16:35:22.268+0900 E/E17     ( 2739): e_manager.c: _e_manager_cb_window_show_request(1134) > Show request(0x00e00002)
06-13 16:35:22.268+0900 D/APP_CORE( 3300): appcore-efl.c: __check_wm_rotation_support(835) > Disable window manager rotation
06-13 16:35:22.278+0900 E/E17     ( 2739): e_border.c: e_border_show(2088) > BD_SHOW(0x00e00002)
06-13 16:35:22.278+0900 D/APP_CORE( 3300): appcore.c: __aul_handler(587) > [APP 3300]     AUL event: AUL_START
06-13 16:35:22.278+0900 I/APP_CORE( 3300): appcore-efl.c: __do_app(496) > [APP 3300] Event: RESET State: CREATED
06-13 16:35:22.278+0900 D/APP_CORE( 3300): appcore-efl.c: __do_app(527) > [APP 3300] RESET
06-13 16:35:22.278+0900 D/LAUNCH  ( 3300): appcore-efl.c: __do_app(529) > [example:Application:reset:start]
06-13 16:35:22.278+0900 D/APP_CORE( 3300): appcore-efl.c: __do_app(533) > [__SUSPEND__] reset case
06-13 16:35:22.278+0900 D/APP_CORE( 3300): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 16:35:22.278+0900 I/CAPI_APPFW_APPLICATION( 3300): app_main.c: _ui_app_appcore_reset(722) > app_appcore_reset
06-13 16:35:22.278+0900 D/AUL     ( 3300): service.c: __set_bundle(186) > __set_bundle
06-13 16:35:22.278+0900 D/LAUNCH  ( 3300): appcore-efl.c: __do_app(544) > [example:Application:reset:done]
06-13 16:35:22.278+0900 I/run     ( 3300): socket
06-13 16:35:22.278+0900 D/APP_CORE( 3300): appcore.c: __aul_handler(608) > [SECURE_LOG] caller_appid : (null)
06-13 16:35:22.278+0900 I/run     ( 3300): connect
06-13 16:35:22.278+0900 I/run     ( 3300): new
06-13 16:35:22.288+0900 I/run     ( 3300): send
06-13 16:35:22.288+0900 E/EFL     ( 3300): edje<3300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:35:22.288+0900 E/EFL     ( 3300): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:35:22.288+0900 E/EFL     ( 3300): edje<3300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:35:22.288+0900 E/EFL     ( 3300): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:35:22.288+0900 E/EFL     ( 3300): edje<3300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:35:22.288+0900 E/EFL     ( 3300): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:35:22.288+0900 E/EFL     ( 3300): edje<3300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:35:22.288+0900 E/EFL     ( 3300): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:35:22.288+0900 E/EFL     ( 3300): edje<3300> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p24';
06-13 16:35:22.288+0900 E/EFL     ( 3300): By the power of Grayskull, your previous Embryo stack is now broken!
06-13 16:35:22.288+0900 W/APP_CORE( 3300): appcore-efl.c: __show_cb(914) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:e00002
06-13 16:35:22.288+0900 D/APP_CORE( 3300): appcore-efl.c: __add_win(753) > [EVENT_TEST][EVENT] __add_win WIN:e00002
06-13 16:35:22.288+0900 D/APP_CORE( 3300): appcore-group.c: appcore_group_attach(13) > appcore_group_attach
06-13 16:35:22.288+0900 D/AUL     ( 3300): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(34)
06-13 16:35:22.288+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(838) > __request_handler: 34
06-13 16:35:22.288+0900 W/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(612) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=3300
06-13 16:35:22.298+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 16:35:22.298+0900 E/EFL     ( 2739): eo<2739> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (410) could not be resolved for class 'Evas_Object_Smart'.
06-13 16:35:22.298+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(838) > __request_handler: 15
06-13 16:35:22.298+0900 D/PKGMGR_INFO( 2772): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3617) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 16:35:22.298+0900 D/PKGMGR_INFO( 2772): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3623) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.example/bin/example' and package_app_info.app_disable IN ('false','False')
06-13 16:35:22.298+0900 D/AUL_AMD ( 2772): amd_status.c: _status_get_appid_bypid(971) > [SECURE_LOG] appid for 3300 is org.example.example
06-13 16:35:22.298+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(1039) > APP_GET_APPID_BYPID : 3300 : 0
06-13 16:35:22.308+0900 D/AUL     ( 2948): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 28
06-13 16:35:22.308+0900 D/INDICATOR( 2854): main.c: _property_changed_cb(432) > UNSNIFF API 1600002
06-13 16:35:22.308+0900 D/INDICATOR( 2854): util.c: util_signal_emit_by_win(116) > emission bg.opaque
06-13 16:35:22.308+0900 D/INDICATOR( 2854): main.c: _rotate_window(229) > Indicator angle is 0 degree
06-13 16:35:22.308+0900 D/INDICATOR( 2854): box.c: box_get_right_item_count(242) > system cnt : 0, minictrl cnt : 0, noti cnt : 0
06-13 16:35:22.308+0900 D/INDICATOR( 2854): box.c: box_get_right_item_count(243) > system_cnt + minictrl_cnt + noti_cnt = 0
06-13 16:35:22.308+0900 D/INDICATOR( 2854): main.c: _rotate_window(252) > port :: hide more icon
06-13 16:35:22.517+0900 D/APP_CORE( 3300): appcore.c: __prt_ltime(236) > [APP 3300] first idle after reset: 412 msec
06-13 16:35:22.587+0900 E/E17     ( 2739): e_border.c: e_border_hide(2248) > BD_HIDE(0x01600002), visible:1
06-13 16:35:22.587+0900 D/APP_CORE( 2871): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:1600002 fully_obscured 1
06-13 16:35:22.587+0900 D/APP_CORE( 2871): appcore-efl.c: __visibility_cb(974) > bvisibility 0, b_active 1
06-13 16:35:22.587+0900 D/APP_CORE( 2871): appcore-efl.c: __visibility_cb(989) >  Go to Pasue state 
06-13 16:35:22.587+0900 I/APP_CORE( 2871): appcore-efl.c: __do_app(496) > [APP 2871] Event: PAUSE State: RUNNING
06-13 16:35:22.587+0900 D/APP_CORE( 2871): appcore-efl.c: __do_app(565) > [APP 2871] PAUSE
06-13 16:35:22.587+0900 I/CAPI_APPFW_APPLICATION( 2871): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 16:35:22.587+0900 E/cluster-home( 2871): homescreen.cpp: OnPause(84) >  app pause
06-13 16:35:22.587+0900 D/cluster-view( 2871): homescreen-view-manager.cpp: AppPause(915) >  BEGIN
06-13 16:35:22.587+0900 D/cluster-view( 2871): homescreen-view-manager.cpp: AppPause(923) >  END
06-13 16:35:22.587+0900 D/APP_CORE( 2871): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 16:35:22.587+0900 E/APP_CORE( 2871): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 16:35:22.597+0900 D/AUL_AMD ( 2772): amd_status.c: _status_update_app_info_list(456) > pid(2871) status(4)
06-13 16:35:22.597+0900 D/AUL_AMD ( 2772): amd_status.c: _status_update_app_info_list(468) > pid(2871) appid(org.tizen.homescreen) pkgid(org.tizen.homescreen) status(4)
06-13 16:35:22.597+0900 D/AUL     ( 2772): amd_app_group.c: __set_fg_flag(180) > send_signal BG org.tizen.homescreen
06-13 16:35:22.597+0900 W/AUL     ( 2772): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 2871, appid: org.tizen.homescreen, status: bg
06-13 16:35:22.597+0900 D/AUL_AMD ( 2772): amd_launch.c: __e17_status_handler(2891) > pid(3300) status(3)
06-13 16:35:22.597+0900 D/AUL_AMD ( 2772): amd_key.c: _key_ungrab(265) > _key_ungrab, win : 600002
06-13 16:35:22.597+0900 W/AUL_AMD ( 2772): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 16:35:22.597+0900 W/AUL_AMD ( 2772): amd_launch.c: __e17_status_handler(2895) > back key ungrab error
06-13 16:35:22.597+0900 D/AUL_AMD ( 2772): amd_status.c: _status_update_app_info_list(456) > pid(3300) status(3)
06-13 16:35:22.597+0900 D/AUL_AMD ( 2772): amd_status.c: _status_update_app_info_list(468) > pid(3300) appid(org.example.example) pkgid(org.example.example) status(3)
06-13 16:35:22.597+0900 D/AUL     ( 2772): amd_app_group.c: __set_fg_flag(172) > send_signal FG org.example.example
06-13 16:35:22.597+0900 W/AUL     ( 2772): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3300, appid: org.example.example, status: fg
06-13 16:35:22.597+0900 D/RESOURCED( 2852): proc-main.c: resourced_proc_status_change(843) > [SECURE_LOG] set foreground : 3300
06-13 16:35:22.597+0900 D/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3300, proc_name: org.example.example, cg_name: foreground, oom_score_adj: 200
06-13 16:35:22.597+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/foreground//cgroup.procs, value 3300
06-13 16:35:22.607+0900 D/DATA_PROVIDER_MASTER( 2925): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2871 is paused
06-13 16:35:22.607+0900 D/DATA_PROVIDER_MASTER( 2925): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-13 16:35:22.607+0900 I/CAPI_WIDGET_APPLICATION( 3030): widget_app.c: __provider_pause_cb(294) > widget obj was paused
06-13 16:35:22.607+0900 I/CAPI_WIDGET_APPLICATION( 3030): widget_app.c: __check_status_for_cgroup(142) > enter background group
06-13 16:35:22.607+0900 W/AUL     ( 3030): app_signal.c: aul_send_app_status_change_signal(591) > send_app_status_change_signal, pid: 3030, appid: org.tizen.calendar.widget, status: bg
06-13 16:35:22.637+0900 D/APP_CORE( 3300): appcore-efl.c: __update_win(799) > [EVENT_TEST][EVENT] __update_win WIN:e00002 fully_obscured 0
06-13 16:35:22.637+0900 D/APP_CORE( 3300): appcore-efl.c: __visibility_cb(974) > bvisibility 1, b_active -1
06-13 16:35:22.637+0900 D/APP_CORE( 3300): appcore-efl.c: __visibility_cb(977) >  Go to Resume state
06-13 16:35:22.637+0900 I/APP_CORE( 3300): appcore-efl.c: __do_app(496) > [APP 3300] Event: RESUME State: CREATED
06-13 16:35:22.637+0900 D/LAUNCH  ( 3300): appcore-efl.c: __do_app(597) > [example:Application:resume:start]
06-13 16:35:22.637+0900 D/APP_CORE( 3300): appcore-efl.c: __do_app(601) > [__SUSPEND__] resume case
06-13 16:35:22.637+0900 D/APP_CORE( 3300): appcore-efl.c: __appcore_efl_exit_from_suspend(380) > [__SUSPEND__]
06-13 16:35:22.637+0900 D/APP_CORE( 3300): appcore-efl.c: __do_app(607) > [APP 3300] RESUME
06-13 16:35:22.637+0900 I/APP_CORE( 3300): appcore-efl.c: __do_app(612) > Legacy lifecycle: 0
06-13 16:35:22.637+0900 I/APP_CORE( 3300): appcore-efl.c: __do_app(614) > [APP 3300] Initial Launching, call the resume_cb
06-13 16:35:22.637+0900 I/CAPI_APPFW_APPLICATION( 3300): app_main.c: _ui_app_appcore_resume(705) > app_appcore_resume
06-13 16:35:22.637+0900 D/LAUNCH  ( 3300): appcore-efl.c: __do_app(636) > [example:Application:resume:done]
06-13 16:35:22.637+0900 D/LAUNCH  ( 3300): appcore-efl.c: __do_app(638) > [example:Application:Launching:done]
06-13 16:35:22.637+0900 D/APP_CORE( 3300): appcore-efl.c: __trm_app_info_send_socket(239) > __trm_app_info_send_socket
06-13 16:35:22.637+0900 E/APP_CORE( 3300): appcore-efl.c: __trm_app_info_send_socket(242) > access
06-13 16:35:22.667+0900 D/RESOURCED( 2852): heart-cpu.c: heart_cpu_foreground_state(201) > heart_cpu_foreground_state : pid = 3300, appname = org.example.example, pkgname = org.example.example
06-13 16:35:22.667+0900 D/RESOURCED( 2852): cpu.c: cpu_foreground_state(221) > cpu_foreground_state : pid = 3300, appname = org.example.example
06-13 16:35:22.667+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3300
06-13 16:35:22.667+0900 D/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1670) > pid: 3030, proc_name: org.tizen.calendar.widget, cg_name: previous, oom_score_adj: 230
06-13 16:35:22.667+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/memory/previous//cgroup.procs, value 3030
06-13 16:35:22.667+0900 D/RESOURCED( 2852): cpu.c: cpu_control_state(212) > cpu_service_launch : pid = 3030, appname = org.tizen.calendar.widget
06-13 16:35:22.667+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/background/cgroup.procs, value 3030
06-13 16:35:22.667+0900 I/RESOURCED( 2852): memcontrol.c: memcg_get_anon_usage(165) > get mem usage anon from /sys/fs/cgroup/memory/foreground/memory.stat
06-13 16:35:22.667+0900 I/RESOURCED( 2852): vmpressure-lowmem-handler.c: lowmem_press_cgroup_handler(1775) > anon page 0 MB < medium threshold 0 MB
06-13 16:35:22.707+0900 D/AUL_AMD ( 2772): amd_launch.c: __e17_status_handler(2910) > pid(3300) status(0)
06-13 16:35:22.997+0900 E/PKGMGR_SERVER( 3436): pkgmgr-server.c: exit_server(1240) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-13 16:35:22.997+0900 E/PKGMGR_SERVER( 3436): pkgmgr-server.c: main(2265) > package manager server terminated.
06-13 16:35:23.207+0900 D/AUL_PAD ( 2923): launchpad.c: __send_launchpad_loader(429) > Prepare another candidate process
06-13 16:35:23.207+0900 D/AUL_PAD ( 3514): sigchild.h: __signal_unblock_sigchld(224) > SIGCHLD unblocked
06-13 16:35:23.227+0900 D/AUL_PAD ( 2923): sigchild.h: __send_app_launch_signal(131) > send launch signal done
06-13 16:35:23.237+0900 E/RESOURCED( 2852): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.165
06-13 16:35:23.477+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:35:23.477+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:35:23.477+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:35:23.477+0900 E/INDICATOR( 2854): 
06-13 16:35:23.707+0900 D/AUL_AMD ( 2772): amd_request.c: __add_history_handler(385) > [SECURE_LOG] add rua history org.example.example /opt/usr/apps/org.example.example/bin/example
06-13 16:35:23.707+0900 D/RUA     ( 2772): rua.c: rua_add_history(179) > rua_add_history start
06-13 16:35:23.717+0900 D/RUA     ( 2772): rua.c: rua_add_history(247) > rua_add_history ok
06-13 16:35:24.267+0900 D/AUL_PAD ( 3514): launchpad_loader.c: main(588) > sleeping 1 sec...
06-13 16:35:24.267+0900 D/AUL_PAD ( 3514): preload.h: __preload_init(52) > max_cmdline_size = 1053
06-13 16:35:24.277+0900 D/AUL_PAD ( 3514): preload.h: __preload_init(65) > preload /usr/lib/libappcore-efl.so.1# - handle : b8944760
06-13 16:35:24.277+0900 D/AUL_PAD ( 3514): preload.h: __preload_init(69) > get pre-initialization function
06-13 16:35:24.277+0900 D/AUL_PAD ( 3514): preload.h: __preload_init(73) > get shutdown function
06-13 16:35:24.277+0900 D/AUL_PAD ( 3514): preload.h: __preload_init(65) > preload /usr/lib/libappcore-common.so.1# - handle : b8944a40
06-13 16:35:24.287+0900 D/AUL_PAD ( 3514): preload.h: __preload_init(65) > preload /usr/lib/libcapi-appfw-application.so.0# - handle : b8946640
06-13 16:35:24.297+0900 D/AUL_PAD ( 3514): preload.h: __preload_init(69) > get pre-initialization function
06-13 16:35:24.297+0900 D/AUL_PAD ( 3514): preload.h: __preload_init(73) > get shutdown function
06-13 16:35:24.297+0900 D/AUL_PAD ( 3514): preexec.h: __preexec_init(76) > preexec start
06-13 16:35:24.297+0900 D/AUL_PAD ( 3514): launchpad_loader.c: main(599) > [candidate] Another candidate process was forked.
06-13 16:35:24.297+0900 D/AUL     ( 3514): process_pool.c: __connect_to_launchpad(107) > [launchpad] enter, type: 0
06-13 16:35:24.297+0900 D/AUL     ( 3514): process_pool.c: __connect_to_launchpad(119) > connect to /tmp/.launchpad-type0
06-13 16:35:24.297+0900 D/AUL     ( 3514): process_pool.c: __connect_to_launchpad(132) > send(3514) : 4
06-13 16:35:24.297+0900 D/AUL     ( 3514): process_pool.c: __connect_to_launchpad(139) > [SECURE_LOG] [launchpad] done, connect fd: 9
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(665) > pfds[LAUNCH_PAD].revent  : 0x0
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(667) > pfds[POOL_TYPE + 0].revents : 0x1
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 0].revents : 0x0
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(667) > pfds[POOL_TYPE + 1].revents : 0x0
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 1].revents : 0x0
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(667) > pfds[POOL_TYPE + 2].revents : 0x0
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(668) > pfds[CANDIDATE_TYPE + 2].revents : 0x0
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(707) > pfds[POOL_TYPE + 0].revents & POLLIN
06-13 16:35:24.297+0900 D/AUL_PAD ( 2923): launchpad.c: main(719) > [SECURE_LOG] Type 0 candidate process was connected, pid: 3514
06-13 16:35:24.377+0900 D/AUL_PAD ( 3514): launchpad_loader.c: main(631) > [candidate] elm init, returned: 1
06-13 16:35:24.377+0900 D/AUL_PAD ( 3514): launchpad_loader.c: main(678) > theme path: /usr/share/elementary/themes/tizen-2.4-mobile-HD.edj
06-13 16:35:24.377+0900 D/AUL_PAD ( 3514): launchpad_loader.c: main(693) > [candidate] ecore handler add
06-13 16:35:24.387+0900 D/AUL_PAD ( 3514): launchpad_loader.c: main(707) > [candidate] ecore main loop begin
06-13 16:35:25.307+0900 I/user    ( 3300): on
06-13 16:35:25.327+0900 I/user2   ( 3300): on
06-13 16:35:25.327+0900 I/user_tag0( 3300): /opt/usr/apps/org.example.example/data/test.db
06-13 16:35:25.347+0900 I/tag     ( 3300): insert~~~
06-13 16:35:25.357+0900 I/tag     ( 3300): insert~~~
06-13 16:35:25.367+0900 I/tag     ( 3300): eonji~
06-13 16:35:25.367+0900 I/tag     ( 3300): 들어와!
06-13 16:35:25.367+0900 I/tag     ( 3300): 언지
06-13 16:35:25.367+0900 I/db      ( 3300): 여기 ㅠ
06-13 16:35:25.367+0900 I/db      ( 3300): rd->index 1 rd->onoff 1 
06-13 16:35:25.367+0900 I/tag     ( 3300): 들어와!
06-13 16:35:25.367+0900 I/tag     ( 3300): 언지
06-13 16:35:25.367+0900 I/db      ( 3300): rd->index 2 rd->onoff 1 
06-13 16:35:25.367+0900 I/user_tag0( 3300): /opt/usr/apps/org.example.example/data/test.db
06-13 16:35:25.367+0900 I/tag     ( 3300): insert~~~
06-13 16:35:25.367+0900 I/tag     ( 3300): insert~~~
06-13 16:35:25.367+0900 I/tag     ( 3300): eonji~
06-13 16:35:25.367+0900 I/tag     ( 3300): 들어와!
06-13 16:35:25.367+0900 I/tag     ( 3300): 언지
06-13 16:35:25.367+0900 I/db      ( 3300): 여기 ㅠ
06-13 16:35:25.367+0900 I/db      ( 3300): rd->index 1 rd->onoff 1 
06-13 16:35:25.367+0900 I/tag     ( 3300): 들어와!
06-13 16:35:25.367+0900 I/tag     ( 3300): 언지
06-13 16:35:25.367+0900 I/db      ( 3300): rd->index 2 rd->onoff 1 
06-13 16:35:25.397+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200234 
06-13 16:35:26.407+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_begin_handler(439) > [PROCESSMGR] ecore_x_netwm_ping_send to the client_win=0xe00002
06-13 16:35:26.547+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping(499) > [PROCESSMGR] ev_win=0x20002e  register trigger_timer!  pointed_win=0x200234 
06-13 16:35:26.557+0900 I/check2  ( 3300): on
06-13 16:35:26.557+0900 I/tag2323 ( 3300): index 2 onoff 2 
06-13 16:35:26.567+0900 I/tag     ( 3300): eonji~
06-13 16:35:26.567+0900 I/tag     ( 3300): 들어와!
06-13 16:35:26.567+0900 I/tag     ( 3300): 언지
06-13 16:35:26.567+0900 I/db      ( 3300): 여기 ㅠ
06-13 16:35:26.567+0900 I/db      ( 3300): rd->index 1 rd->onoff 1 
06-13 16:35:26.567+0900 I/tag     ( 3300): 들어와!
06-13 16:35:26.567+0900 I/tag     ( 3300): 언지
06-13 16:35:26.567+0900 I/db      ( 3300): rd->index 2 rd->onoff 2 
06-13 16:35:27.597+0900 D/APP_CORE( 2871): appcore-efl.c: __appcore_memory_flush_cb(387) > [__SUSPEND__]
06-13 16:35:27.597+0900 I/APP_CORE( 2871): appcore-efl.c: __do_app(496) > [APP 2871] Event: MEM_FLUSH State: PAUSED
06-13 16:35:27.597+0900 D/APP_CORE( 2871): appcore-efl.c: __appcore_memory_flush_cb(396) > [__SUSPEND__] flush case
06-13 16:35:27.597+0900 D/APP_CORE( 2871): appcore.c: _appcore_request_to_suspend(532) > [SECURE_LOG] [__SUSPEND__] Send suspend hint, pid: 2871
06-13 16:35:27.597+0900 D/APP_CORE( 2871): appcore-efl.c: __appcore_efl_prepare_to_suspend(362) > [__SUSPEND__]
06-13 16:35:27.597+0900 D/RESOURCED( 2852): proc-monitor.c: proc_dbus_suspend_hint(1106) > received susnepd hint : pid 2871
06-13 16:35:31.407+0900 D/PROCESSMGR( 2739): e_mod_processmgr.c: _e_mod_processmgr_anr_ping_confirm_handler(360) > [PROCESSMGR] last_pointed_win=0x200234 bd->visible=1
06-13 16:35:32.127+0900 I/tag     ( 3300): here
06-13 16:35:32.127+0900 I/tag     ( 3300): receive: watern
06-13 16:35:32.127+0900 I/water   ( 3300): water
06-13 16:35:32.127+0900 E/EFL     ( 3300): ecore<3300> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
06-13 16:35:32.127+0900 E/EFL     ( 3300): ecore<3300> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
06-13 16:35:34.127+0900 I/run     ( 3300): new
06-13 16:35:34.127+0900 I/run     ( 3300): send
06-13 16:35:41.097+0900 I/tag     ( 3300): here
06-13 16:35:41.097+0900 I/tag     ( 3300): receive: watern
06-13 16:35:41.097+0900 I/water   ( 3300): water
06-13 16:35:41.097+0900 E/EFL     ( 3300): ecore<3300> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
06-13 16:35:41.097+0900 E/EFL     ( 3300): ecore<3300> lib/ecore/ecore_job.c:63 _ecore_job_constructor() You are calling _ecore_job_constructor from outside of the main loop threads. Program cannot run nomally
06-13 16:35:43.097+0900 I/run     ( 3300): new
06-13 16:35:43.097+0900 I/run     ( 3300): send
06-13 16:35:43.497+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:35:43.497+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:35:43.497+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:35:43.497+0900 E/INDICATOR( 2854): 
06-13 16:35:58.177+0900 D/RESOURCED( 2852): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 16:35:58.177+0900 I/RESOURCED( 2852): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 16:35:58.177+0900 D/RESOURCED( 2852): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 16:35:58.177+0900 I/RESOURCED( 2852): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 16:36:00.177+0900 D/INDICATOR( 2854): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 16:36:00.177+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 16:36:00.177+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 16:36:00.177+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:36 4 h"
06-13 16:36:00.177+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:36"
06-13 16:36:00.187+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;36"
06-13 16:36:00.187+0900 D/INDICATOR( 2854): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147218937 Time: <font_size=33>4&#x2236;36</font_size> <font_size=32>PM</font_size></font>
06-13 16:36:03.507+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:36:03.507+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:36:03.507+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:36:03.507+0900 E/INDICATOR( 2854): 
06-13 16:36:23.537+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:36:23.537+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:36:23.537+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:36:23.537+0900 E/INDICATOR( 2854): 
06-13 16:36:43.566+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:36:43.566+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:36:43.566+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:36:43.566+0900 E/INDICATOR( 2854): 
06-13 16:36:58.236+0900 D/RESOURCED( 2852): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 16:36:58.236+0900 I/RESOURCED( 2852): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 16:36:58.236+0900 D/RESOURCED( 2852): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 16:36:58.236+0900 I/RESOURCED( 2852): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 16:37:00.206+0900 D/INDICATOR( 2854): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 16:37:00.206+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 16:37:00.206+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 16:37:00.206+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:37 4 h"
06-13 16:37:00.206+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:37"
06-13 16:37:00.206+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;37"
06-13 16:37:00.206+0900 D/INDICATOR( 2854): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147216885 Time: <font_size=33>4&#x2236;37</font_size> <font_size=32>PM</font_size></font>
06-13 16:37:03.576+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:37:03.576+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:37:03.576+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:37:03.576+0900 E/INDICATOR( 2854): 
06-13 16:37:23.616+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:37:23.616+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:37:23.616+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:37:23.616+0900 E/INDICATOR( 2854): 
06-13 16:37:43.636+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:37:43.636+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:37:43.636+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:37:43.636+0900 E/INDICATOR( 2854): 
06-13 16:37:58.226+0900 D/RESOURCED( 2852): logging.c: logging_send_signal_to_data(1097) > logging timer callback function start
06-13 16:37:58.226+0900 I/RESOURCED( 2852): logging.c: logging_send_signal_to_data(1106) > send signal to logging data thread
06-13 16:37:58.226+0900 D/RESOURCED( 2852): logging.c: logging_send_signal_to_update(1177) > logging timer callback function start
06-13 16:37:58.226+0900 I/RESOURCED( 2852): logging.c: logging_send_signal_to_update(1186) > send signal to logging update thread
06-13 16:38:00.226+0900 D/INDICATOR( 2854): clock.c: indicator_get_apm_by_region(666) > indicator_get_apm_by_region[666]	 "TimeZone is Asia/Seoul"
06-13 16:38:00.226+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(780) > indicator_get_time_by_region[780]	 "BestPattern is h"
06-13 16:38:00.226+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(781) > indicator_get_time_by_region[781]	 "TimeZone is Asia/Seoul"
06-13 16:38:00.226+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(801) > indicator_get_time_by_region[801]	 "DATE & TIME is en_US 4:38 4 h"
06-13 16:38:00.226+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(803) > indicator_get_time_by_region[803]	 "24H :: Before change 4:38"
06-13 16:38:00.226+0900 D/INDICATOR( 2854): clock.c: indicator_get_time_by_region(810) > indicator_get_time_by_region[810]	 "24H :: After change 4&#x2236;38"
06-13 16:38:00.226+0900 D/INDICATOR( 2854): clock.c: indicator_clock_changed_cb(295) > [CLOCK MODULE] Timer Status : -2147214833 Time: <font_size=33>4&#x2236;38</font_size> <font_size=32>PM</font_size></font>
06-13 16:38:03.645+0900 E/CAPI_NETWORK_WIFI( 2854): libnetwork.c: _wifi_check_feature_supported(1370) > http://tizen.org/feature/network.wifi feature is disabled
06-13 16:38:03.645+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(279) > wifi initialize is fail : -1073741822 (0x8001f0f9)
06-13 16:38:03.645+0900 E/INDICATOR( 2854): wifi.c: _wifi_init(294) > Interval is updated to 10.000000
06-13 16:38:03.645+0900 E/INDICATOR( 2854): 
06-13 16:38:13.375+0900 E/PKGMGR_SERVER( 3551): pkgmgr-server.c: main(2209) > package manager server start
06-13 16:38:13.375+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(405) > initialize_gdbus Enter
06-13 16:38:13.385+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: pkg_mgr_server_gdbus_init(423) > initialize_gdbus Exit
06-13 16:38:13.395+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: on_bus_acquired(376) > on_bus_acquired
06-13 16:38:13.395+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: on_bus_acquired(400) > on_bus_acquired done
06-13 16:38:13.405+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: pkgmgr_request(145) > Called
06-13 16:38:13.405+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: pkgmgr_request(164) > sender_name: :1.170
06-13 16:38:13.405+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: pkg_mgr_get_sender_pid(79) > zone pid : 3549
06-13 16:38:13.405+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: pkgmgr_request(166) > sender_pid: 3549
06-13 16:38:13.405+0900 D/PKGMGR  ( 3551): comm_pkg_mgr_server.c: pkgmgr_request(175) > [SECURE_LOG] Call request callback(obj, org.example.example_-2070126831, 14, tpk, org.example.example, , host)
06-13 16:38:13.405+0900 D/PKGMGR_SERVER( 3551): pkgmgr-server.c: req_cb(625) > [SECURE_LOG] >> in callback >> Got request: [org.example.example_-2070126831] [14] [tpk] [org.example.example] [] [] [host]
06-13 16:38:13.405+0900 D/PKGMGR_SERVER( 3551): pkgmgr-server.c: req_cb(646) > req_type=(14)  backend_flag=(0) zone(host)
06-13 16:38:13.405+0900 D/PKGMGR_SERVER( 3551): pkgmgr-server.c: queue_job(1880) > target zone(host, host)
06-13 16:38:13.405+0900 D/PKGMGR_SERVER( 3551): pkgmgr-server.c: queue_job(1884) > child forked [3554] for request type [14]
06-13 16:38:13.405+0900 D/PKGMGR_SERVER( 3551): pkgmgr-server.c: queue_job(2126) > parent exit
06-13 16:38:13.405+0900 D/PKGMGR_SERVER( 3554): pkgmgr-server.c: queue_job(1884) > child forked [0] for request type [14]
06-13 16:38:13.405+0900 D/PKGMGR_SERVER( 3554): pkgmgr-server.c: queue_job(2057) > kill/check request
06-13 16:38:13.405+0900 D/PKGMGR  ( 3549): pkgmgr.c: __check_sync_process(868) > info_file file is generated, result = 0
06-13 16:38:13.405+0900 D/PKGMGR  ( 3549): . 
06-13 16:38:13.405+0900 E/PKGMGR  ( 3549): pkgmgr.c: __check_sync_process(884) > file is can not remove[/tmp/org.example.example, -1]
06-13 16:38:13.405+0900 D/PKGMGR_SERVER( 3554): pkgmgr-server.c: __pkgcmd_app_cb(1458) > sub_cmd(kill), zone_name(host)
06-13 16:38:13.415+0900 D/AUL     ( 3554): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 3300
06-13 16:38:13.415+0900 W/AUL_AMD ( 2772): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 3300
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(838) > __request_handler: 12
06-13 16:38:13.415+0900 D/AUL     ( 3554): app_sock.c: __app_send_cmd_with_result(643) > recv result  = 292
06-13 16:38:13.415+0900 D/AUL     ( 3554): launch.c: app_request_to_launchpad(396) > [SECURE_LOG] launch request : 3300
06-13 16:38:13.415+0900 D/AUL     ( 3554): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(5)
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(838) > __request_handler: 5
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_appinfo.c: appinfo_set_value(905) > [SECURE_LOG] org.example.example : installed : norestart
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __app_process_by_pid(279) > [SECURE_LOG] __app_process_by_pid, pid: 3300, 
06-13 16:38:13.415+0900 D/AUL     ( 2772): app_sock.c: __app_send_raw_with_delay_reply(455) > pid(3300) : cmd(4)
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_launch.c: _term_app(1076) > term done
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_launch.c: __set_reply_handler(1015) > listen fd : 31, send fd : 30
06-13 16:38:13.415+0900 D/APP_CORE( 3300): appcore.c: __aul_handler(632) > [APP 3300]     AUL event: AUL_TERMINATE
06-13 16:38:13.415+0900 I/APP_CORE( 3300): appcore-efl.c: __do_app(496) > [APP 3300] Event: TERMINATE State: RUNNING
06-13 16:38:13.415+0900 D/APP_CORE( 3300): appcore-efl.c: __do_app(517) > [APP 3300] TERMINATE
06-13 16:38:13.415+0900 W/AUL_AMD ( 2772): amd_launch.c: __reply_handler(913) > listen fd(31) , send fd(30), pid(3300), cmd(4)
06-13 16:38:13.415+0900 D/RESOURCED( 2852): cgroup.c: cgroup_write_node(134) > [SECURE_LOG] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 3300
06-13 16:38:13.415+0900 D/AUL     ( 3554): launch.c: app_request_to_launchpad(425) > launch request result : 0
06-13 16:38:13.415+0900 D/AUL     ( 3554): app_sock.c: __app_send_raw(285) > pid(-2) : cmd(14)
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(838) > __request_handler: 14
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_status.c: _status_app_is_running_from_cache(836) > is_running hit cache, return immediately
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(1028) > [SECURE_LOG] APP_IS_RUNNING : org.example.example : 3300
06-13 16:38:13.415+0900 W/AUL_AMD ( 2772): amd_request.c: __send_result_to_client(150) > __send_result_to_client, pid: 3300
06-13 16:38:13.415+0900 D/AUL     ( 3300): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 16:38:13.415+0900 W/AUL_AMD ( 2772): amd_request.c: __request_handler(1056) > app status : 5
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_status.c: _status_update_app_info_list(456) > pid(3300) status(5)
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_status.c: _status_update_app_info_list(468) > pid(3300) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 16:38:13.415+0900 D/AUL     ( 3300): app_sock.c: __app_send_raw_with_noreply(384) > pid(-2) : cmd(22)
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_request.c: __request_handler(838) > __request_handler: 22
06-13 16:38:13.415+0900 W/AUL_AMD ( 2772): amd_request.c: __request_handler(1056) > app status : 5
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_status.c: _status_update_app_info_list(456) > pid(3300) status(5)
06-13 16:38:13.415+0900 D/AUL_AMD ( 2772): amd_status.c: _status_update_app_info_list(468) > pid(3300) appid(org.example.example) pkgid(org.example.example) status(5)
06-13 16:38:13.425+0900 D/APP_CORE( 3300): appcore.c: _appcore_fini_suspend_dbus_handler(944) > [__SUSPEND__] suspend signal finalized
06-13 16:38:13.425+0900 D/APP_CORE( 3300): appcore-efl.c: __after_loop(1169) > [APP 3300] PAUSE before termination
06-13 16:38:13.425+0900 I/CAPI_APPFW_APPLICATION( 3300): app_main.c: _ui_app_appcore_pause(688) > app_appcore_pause
06-13 16:38:13.445+0900 W/CRASH_MANAGER( 3556): worker.c: worker_job(1204) > 1103300657861149733949
