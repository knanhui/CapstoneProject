S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7445
Date: 2017-06-03 00:21:15+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7445, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb6ea5000, r3   = 0xb6ea5020
r4   = 0x8001b2da, r5   = 0xbe8c1218
r6   = 0xb6f1a9a5, r7   = 0xbe8c10a0
r8   = 0x8001b2da, r9   = 0xb5c13708
r10  = 0xb7ddcf20, fp   = 0xbe8c11f4
ip   = 0xb62cd120, sp   = 0xbe8c1060
lr   = 0xb6291bd9, pc   = 0xb6f1a9ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     43584 KB
Buffers:     15916 KB
Cached:     116324 KB
VmPeak:     103748 KB
VmSize:     103744 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19984 KB
VmRSS:       19984 KB
VmData:      32044 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       31076 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7445 TID = 7445
7445 7446 7456 7457 

Maps Information
b199c000 b19a4000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b19b5000 b19c2000 r-xp /usr/lib/libmdm-common.so.1.0.98
b19d3000 b1a14000 r-xp /usr/lib/libmdm.so.1.2.12
b1a24000 b1a2c000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b1a3b000 b1a4b000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b1a6c000 b1acc000 r-xp /usr/lib/libasound.so.2.0.0
b1ade000 b1ae1000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1af1000 b1af4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b1b04000 b1b09000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1b19000 b1b1a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b1b2a000 b1b35000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b1b49000 b1b4e000 r-xp /usr/lib/libmmfsession.so.0.0.1
b1b5e000 b1b79000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1b89000 b1b90000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b1ba0000 b1baa000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b1bba000 b1bbc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b1bcc000 b1bcd000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b1bdd000 b1be5000 r-xp /usr/lib/libfeedback.so.0.1.4
b1c0d000 b1c0e000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c1e000 b1c32000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1ddd000 b1de3000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b1df4000 b25f3000 rw-p [stack:7457]
b25f3000 b274e000 r-xp /usr/lib/egl/libMali.so
b2763000 b27ec000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b2804000 b280e000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b281f000 b282b000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b283d000 b303c000 rw-p [stack:7456]
b336d000 b3377000 r-xp /lib/libnss_files-2.20-2014.11.so
b3388000 b3391000 r-xp /lib/libnss_nis-2.20-2014.11.so
b33a2000 b33b3000 r-xp /lib/libnsl-2.20-2014.11.so
b33c6000 b33cc000 r-xp /lib/libnss_compat-2.20-2014.11.so
b33dd000 b33e1000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b33f2000 b34d5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b350c000 b3534000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b3546000 b3d45000 rw-p [stack:7446]
b3d45000 b3d47000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3d57000 b3e35000 r-xp /usr/lib/libCOREGL.so.4.0
b3e55000 b3e58000 r-xp /lib/libattr.so.1.1.0
b3e68000 b3e6f000 r-xp /lib/libcrypt-2.20-2014.11.so
b3ea7000 b3eaa000 r-xp /lib/libcap.so.2.21
b3eba000 b3ebc000 r-xp /usr/lib/libiri.so
b3ecd000 b3eed000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3eee000 b3ef1000 r-xp /usr/lib/libuuid.so.1.3.0
b3f01000 b3f18000 r-xp /usr/lib/libblkid.so.1.1.0
b3f29000 b3f52000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3f64000 b3fab000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3fbc000 b3fc2000 r-xp /usr/lib/libjson-c.so.2.0.1
b3fd3000 b3fd7000 r-xp /usr/lib/libogg.so.0.7.1
b3fe7000 b4009000 r-xp /usr/lib/libvorbis.so.0.4.3
b4019000 b40fd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b411a000 b4125000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4135000 b4138000 r-xp /usr/lib/libEGL.so.1.4
b4148000 b414e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b415e000 b4160000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4170000 b417d000 r-xp /usr/lib/libGLESv2.so.2.0
b418f000 b41a7000 r-xp /usr/lib/libmount.so.1.1.0
b41b8000 b41ba000 r-xp /usr/lib/libXau.so.6.0.0
b41ca000 b4200000 r-xp /usr/lib/libpulse.so.0.16.2
b4211000 b4254000 r-xp /usr/lib/libsndfile.so.1.0.25
b426a000 b42e4000 r-xp /usr/lib/libgcrypt.so.20.0.3
b42f9000 b4300000 r-xp /usr/lib/libsensord-share.so
b4310000 b4372000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4387000 b438a000 r-xp /usr/lib/libXv.so.1.0.0
b439a000 b439f000 r-xp /usr/lib/libutilX.so.1.1.0
b43b0000 b43b5000 r-xp /usr/lib/libffi.so.6.0.2
b43c5000 b43d6000 r-xp /lib/libresolv-2.20-2014.11.so
b43ea000 b43ec000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b43fc000 b44ba000 r-xp /usr/lib/libcairo.so.2.11200.14
b44ce000 b44d6000 r-xp /usr/lib/libdrm.so.2.4.0
b44e6000 b44e9000 r-xp /usr/lib/libdri2.so.0.0.0
b44f9000 b4505000 r-xp /usr/lib/libeeze.so.1.13.0
b4515000 b451e000 r-xp /usr/lib/libethumb.so.1.13.0
b452f000 b4543000 r-xp /usr/lib/libxcb.so.1.1.0
b4553000 b4555000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b4565000 b456c000 r-xp /usr/lib/libembryo.so.1.13.0
b457c000 b4586000 r-xp /usr/lib/libecore_audio.so.1.13.0
b4598000 b45ad000 r-xp /lib/libexpat.so.1.5.2
b45bf000 b45c2000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b45d2000 b45db000 r-xp /usr/lib/libXi.so.6.1.0
b45eb000 b45ed000 r-xp /usr/lib/libXgesture.so.7.0.0
b45fd000 b4601000 r-xp /usr/lib/libXtst.so.6.1.0
b4611000 b4617000 r-xp /usr/lib/libXrender.so.1.3.0
b4628000 b462e000 r-xp /usr/lib/libXrandr.so.2.2.0
b463e000 b4640000 r-xp /usr/lib/libXinerama.so.1.0.0
b4650000 b4653000 r-xp /usr/lib/libXfixes.so.3.1.0
b4663000 b466e000 r-xp /usr/lib/libXext.so.6.4.0
b467e000 b4680000 r-xp /usr/lib/libXdamage.so.1.1.0
b4691000 b4693000 r-xp /usr/lib/libXcomposite.so.1.0.0
b46a3000 b46aa000 r-xp /usr/lib/libXcursor.so.1.0.2
b46ba000 b46d2000 r-xp /usr/lib/libudev.so.1.6.0
b46d4000 b4710000 r-xp /usr/lib/libsystemd.so.0.4.0
b4712000 b472a000 r-xp /usr/lib/libsensor.so.1.1.0
b473c000 b4743000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4753000 b4755000 r-xp /usr/lib/libappsvc.so.0.1.0
b4765000 b4768000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b4778000 b4791000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b47a2000 b47d9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b47eb000 b48d6000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b48e9000 b48ee000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b48fe000 b4900000 r-xp /usr/lib/libvasum.so.0.3.1
b4910000 b4913000 r-xp /usr/lib/libiniparser.so.0
b4923000 b4927000 r-xp /usr/lib/libsmack.so.1.0.0
b4937000 b493c000 r-xp /usr/lib/libxdgmime.so.1.1.0
b494e000 b4978000 r-xp /usr/lib/libdbus-1.so.3.8.12
b4989000 b49a0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b49b1000 b49b4000 r-xp /usr/lib/libbundle.so.0.1.22
b5785000 b579d000 r-xp /usr/lib/libpng12.so.0.50.0
b57ae000 b57d1000 r-xp /usr/lib/libjpeg.so.8.0.2
b57f2000 b5806000 r-xp /usr/lib/libector.so.1.13.0
b5817000 b582f000 r-xp /usr/lib/liblua-5.1.so
b5840000 b5897000 r-xp /usr/lib/libfreetype.so.6.11.3
b58ab000 b58be000 r-xp /usr/lib/libfribidi.so.0.3.1
b58cf000 b5909000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b591a000 b5928000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5938000 b5940000 r-xp /usr/lib/libtbm.so.1.0.0
b5950000 b595d000 r-xp /usr/lib/libeio.so.1.13.0
b596d000 b596f000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b597f000 b5984000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5994000 b59ab000 r-xp /usr/lib/libefreet.so.1.13.0
b59bd000 b59dd000 r-xp /usr/lib/libeldbus.so.1.13.0
b59ed000 b5a0d000 r-xp /usr/lib/libecore_con.so.1.13.0
b5a0f000 b5a15000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5a25000 b5a36000 r-xp /usr/lib/libemotion.so.1.13.0
b5a47000 b5a4e000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5a5e000 b5a70000 r-xp /usr/lib/libecore_input.so.1.13.0
b5a81000 b5a86000 r-xp /usr/lib/libecore_file.so.1.13.0
b5a96000 b5ab3000 r-xp /usr/lib/libeet.so.1.13.0
b5acc000 b5adc000 r-xp /usr/lib/libefl.so.1.13.0
b5aed000 b5aef000 r-xp /usr/lib/libttrace.so.1.1
b5aff000 b5be1000 r-xp /usr/lib/libX11.so.6.3.0
b5bf4000 b5c03000 r-xp /usr/lib/libeo.so.1.13.0
b5c14000 b5c97000 r-xp /usr/lib/libedje.so.1.13.0
b5caa000 b5cc8000 r-xp /usr/lib/libecore.so.1.13.0
b5ce8000 b5d00000 r-xp /lib/libz.so.1.2.8
b5d10000 b5ec7000 r-xp /usr/lib/libcrypto.so.1.0.0
b5ef0000 b5f3e000 r-xp /usr/lib/libssl.so.1.0.0
b5f53000 b5f81000 r-xp /usr/lib/libidn.so.11.5.44
b5f91000 b5fa7000 r-xp /usr/lib/libnghttp2.so.5.4.0
b5fb8000 b5fc2000 r-xp /usr/lib/libcares.so.2.1.0
b5fd2000 b60a7000 r-xp /usr/lib/libxml2.so.2.9.2
b60bc000 b60e4000 r-xp /usr/lib/libfontconfig.so.1.8.0
b60f5000 b61d7000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b61e8000 b61f2000 r-xp /usr/lib/libvconf.so.0.2.45
b6202000 b621b000 r-xp /usr/lib/libecore_evas.so.1.13.0
b622b000 b6263000 r-xp /usr/lib/libecore_x.so.1.13.0
b6275000 b62bd000 r-xp /usr/lib/libeina.so.1.13.0
b62ce000 b62d3000 r-xp /usr/lib/libappcore-common.so.1.1
b62e3000 b62e8000 r-xp /usr/lib/libappcore-efl.so.1.1
b62f8000 b62fd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b630e000 b6334000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6344000 b635c000 r-xp /usr/lib/libaul.so.0.1.0
b636e000 b6409000 r-xp /usr/lib/libstdc++.so.6.0.20
b6425000 b650a000 r-xp /usr/lib/libicuuc.so.51.1
b6527000 b6667000 r-xp /usr/lib/libicui18n.so.51.1
b667e000 b6685000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6697000 b6702000 r-xp /lib/libm-2.20-2014.11.so
b6713000 b6719000 r-xp /lib/librt-2.20-2014.11.so
b672a000 b672c000 r-xp /lib/libdl-2.20-2014.11.so
b673d000 b674a000 r-xp /usr/lib/libunwind.so.8.0.1
b6780000 b6799000 r-xp /lib/libgcc_s-4.9.so.1
b67a9000 b68cd000 r-xp /lib/libc-2.20-2014.11.so
b68e2000 b695b000 r-xp /usr/lib/libsqlite3.so.0.8.6
b696d000 b6af4000 r-xp /usr/lib/libevas.so.1.13.0
b6b29000 b6d5d000 r-xp /usr/lib/libelementary.so.1.13.0
b6d8c000 b6d93000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6da4000 b6da6000 r-xp /usr/lib/libdlog.so.0.0.0
b6db6000 b6dfc000 r-xp /usr/lib/libcurl.so.4.3.0
b6e0d000 b6e15000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6e25000 b6e29000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6e3a000 b6e3c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6e4d000 b6e62000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b6e72000 b6e86000 r-xp /lib/libpthread-2.20-2014.11.so
b6eb2000 b6ebf000 r-xp /usr/lib/liblptcp.so
b6ed1000 b6ed5000 r-xp /usr/lib/libsys-assert.so
b6ee6000 b6f06000 r-xp /lib/ld-2.20-2014.11.so
b6f17000 b6f1f000 r-xp /opt/usr/apps/org.example.example/bin/example
b7b2f000 b7e92000 rw-p [heap]
be8a1000 be8c2000 rw-p [stack]
b7b2f000 b7e92000 rw-p [heap]
be8a1000 be8c2000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7445)
Call Stack Count: 17
 0: feeding_view_cb + 0x29 (0xb6f1a9ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb69a2175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5bff219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5bfdfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb69a2515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb69aa725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb69aff6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb69b3939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb45c1173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb5cb5c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb5cbba5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb5cbbc83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb62e62bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb6e27909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb6f1c673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: __libc_start_main + 0x114 (0xb67bf4bc) [/lib/libc.so.6] + 0x164bc
16: (0xb6f19840) [/opt/usr/apps/org.example.example/bin/example] + 0x2840
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
, appid: org.example.example
06-03 00:21:16.902+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:21:16.902+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7444)
06-03 00:21:17.062+0900 I/APP_CORE( 7444): appcore-efl.c: __do_app(514) > [APP 7444] Event: RESET State: CREATED
06-03 00:21:17.062+0900 I/CAPI_APPFW_APPLICATION( 7444): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:21:17.062+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.062+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.072+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.072+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.072+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.072+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.072+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.072+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.072+0900 E/EFL     ( 7444): edje<7444> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:17.072+0900 E/EFL     ( 7444): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:17.103+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:17.103+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:17.133+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:17.143+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:17.143+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:17.153+0900 W/APP_CORE( 7444): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:21:17.153+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:17.153+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:17.263+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:17.263+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:17.263+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:17.263+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:17.263+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:17.263+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:17.263+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7444) status(3)
06-03 00:21:17.263+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7444)
06-03 00:21:17.263+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7444, appid: org.example.example, status: fg
06-03 00:21:17.273+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:17.273+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:17.273+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:17.273+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:17.293+0900 I/APP_CORE( 7444): appcore-efl.c: __do_app(514) > [APP 7444] Event: RESUME State: CREATED
06-03 00:21:17.303+0900 I/APP_CORE( 7444): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:17.303+0900 I/APP_CORE( 7444): appcore-efl.c: __do_app(625) > [APP 7444] Initial Launching, call the resume_cb
06-03 00:21:17.303+0900 I/CAPI_APPFW_APPLICATION( 7444): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:17.613+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7444) status(0)
06-03 00:21:17.813+0900 E/EFL     ( 7444): ecore_x<7444> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127457812
06-03 00:21:17.933+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3238
06-03 00:21:17.943+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:17.943+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7444.
06-03 00:21:17.973+0900 W/LFE      (15849): [15849] 26:15:50.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:17.983+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7444 pgid = 7444
06-03 00:21:17.983+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7444)
06-03 00:21:17.983+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:18.053+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:21:18.053+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:21:18.053+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:21:18.053+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7444] terminate event is forwarded
06-03 00:21:18.053+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:18.053+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7444, ]
06-03 00:21:18.053+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:18.053+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:21:18.053+0900 I/Tizen::App( 1210): (512) > Not registered pid(7444)
06-03 00:21:18.053+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:21:18.053+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:18.053+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7444
06-03 00:21:18.053+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7444
06-03 00:21:18.053+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7444
06-03 00:21:18.063+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3239
06-03 00:21:18.073+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:21:18.073+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:21:18.073+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:18.073+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:21:18.073+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:18.073+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:18.073+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:21:18.073+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:21:18.073+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:21:18.073+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:18.083+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:21:18.083+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:18.083+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7444.
06-03 00:21:18.093+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:21:18.093+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:18.103+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:18.103+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:18.103+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:18.114+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:18.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:18.114+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:21:18.114+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:21:18.114+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:21:18.114+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:21:18.264+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:18.264+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:18.654+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127458652
06-03 00:21:18.744+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127458738
06-03 00:21:18.744+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:21:18.744+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:21:18.754+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:21:18.764+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:21:18.764+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:18.774+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:21:18.774+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(534) > Candidate is not prepared, enter legacy logic
06-03 00:21:18.774+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:21:18.774+0900 E/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(273) > launching failed
06-03 00:21:18.774+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3063) > Launch with legacy way : no launchpad
06-03 00:21:18.774+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7473
06-03 00:21:18.824+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7473
06-03 00:21:18.824+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7473, appid: org.example.example
06-03 00:21:18.824+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:21:18.834+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7473)
06-03 00:21:18.854+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:18.854+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7473.
06-03 00:21:19.004+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:21:19.415+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:21:19.435+0900 I/UXT     ( 7470): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:21:19.475+0900 E/TBM     ( 7473): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:21:19.475+0900 I/MALI    ( 7473): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=7473   open drm_fd=84 
06-03 00:21:19.805+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: RESET State: CREATED
06-03 00:21:19.805+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:21:19.805+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.805+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.805+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.805+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.805+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.805+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.805+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.805+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.815+0900 E/EFL     ( 7473): edje<7473> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:19.815+0900 E/EFL     ( 7473): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:19.845+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:19.845+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:19.855+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:19.865+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:19.865+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:19.875+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:19.905+0900 W/APP_CORE( 7473): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00003
06-03 00:21:19.905+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:19.915+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:19.915+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:19.915+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:19.915+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:19.915+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:19.915+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:19.925+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7473) status(3)
06-03 00:21:19.925+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:19.925+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:19.925+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7473)
06-03 00:21:19.925+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7473, appid: org.example.example, status: fg
06-03 00:21:19.935+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:19.935+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:19.935+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:19.935+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:19.985+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: RESUME State: CREATED
06-03 00:21:20.005+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:20.005+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(625) > [APP 7473] Initial Launching, call the resume_cb
06-03 00:21:20.005+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:20.276+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7473) status(0)
06-03 00:21:20.476+0900 W/LFE      (15849): [15849] 26:15:52.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:20.996+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:21:21.046+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11073156578611496416863
06-03 00:21:22.668+0900 E/EFL     ( 7473): ecore_x<7473> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=127462668
06-03 00:21:22.838+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:21:22.838+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:21:22.838+0900 E/EFL     ( 7473): ecore_x<7473> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=127462840
06-03 00:21:22.838+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 00:21:22.838+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 00:21:22.838+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 00:21:22.838+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[powerkey] (status:3)
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:powerkey
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:0
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:21:22.858+0900 W/APP_CORE( 7473): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
06-03 00:21:22.858+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: PAUSE State: RUNNING
06-03 00:21:22.858+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:22.858+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
06-03 00:21:22.868+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:21:22.868+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:21:22.868+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
06-03 00:21:22.868+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
06-03 00:21:22.868+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
06-03 00:21:22.868+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
06-03 00:21:22.868+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:21:22.868+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:21:22.878+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:21:22.878+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:21:22.888+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7520
06-03 00:21:22.888+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:22.898+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 00:21:22.938+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7520
06-03 00:21:22.938+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7520, appid: com.samsung.weather-m-agent
06-03 00:21:22.938+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7520)
06-03 00:21:22.948+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:21:22.948+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7520.
06-03 00:21:22.958+0900 W/LFE      (15849): [15849] 26:15:55.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:23.078+0900 E/weather-agent( 7520): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:21:23.078+0900 E/weather-common( 7520): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:21:23.088+0900 E/weather-agent( 7520): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:21:23.088+0900 E/weather-agent( 7520): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:21:23.088+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:21:23.088+0900 I/MESSAGE_PORT( 7520): message-port.c: __initialize(872) > initialize
06-03 00:21:23.098+0900 I/MESSAGE_PORT( 7520): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:21:23.239+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 00:21:23.249+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:21:23.249+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:21:23.249+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 00:21:23.249+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 00:21:23.259+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: PAUSE State: PAUSED
06-03 00:21:23.269+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(3)
06-03 00:21:23.269+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:23.269+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:23.269+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(845)
06-03 00:21:23.269+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: fg
06-03 00:21:23.269+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7473) status(4)
06-03 00:21:23.269+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG org.example.example(7473)
06-03 00:21:23.269+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7473, appid: org.example.example, status: bg
06-03 00:21:23.279+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(0)
06-03 00:21:23.299+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:21:23.299+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.299+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:21:23.299+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:21:23.309+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:21:23.309+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:21:23.319+0900 E/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:21:23.319+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:21:23.319+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:21:23.339+0900 E/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:21:23.339+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 7520): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:21:23.339+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:21:23.339+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:23.349+0900 E/MESSAGE_PORT( 7520): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:21:23.349+0900 E/weather-common( 7520): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:21:23.349+0900 E/weather-agent( 7520): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:21:23.349+0900 E/weather-agent( 7520): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:21:23.349+0900 I/MESSAGE_PORT( 7520): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:21:23.349+0900 I/MESSAGE_PORT( 7520): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:21:23.359+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:23.359+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:23.369+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:23.379+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:21:23.379+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:23.379+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 7473): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 117
06-03 00:21:23.379+0900 E/APP_CORE( 7473): appcore-efl.c: _capture_and_make_file(1619) > win[8a00003] widget[720] height[1280]
06-03 00:21:23.379+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 00:21:23.379+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:23.379+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:21:23.379+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:23.389+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:23.429+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:23.439+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:23.439+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:21:23.489+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:23.499+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:23.499+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 00:21:23.509+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:21:23.509+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:1:LOCK
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:1 event_info:0
06-03 00:21:23.519+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [visible]
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10001:WIN_BECOME_VISIBLE
06-03 00:21:23.519+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10001 event_info:0
06-03 00:21:23.519+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
06-03 00:21:23.519+0900 W/APP_CORE(  845): appcore-efl.c: __visibility_cb(989) > LCD status is off, skip the AE_RESUME event
06-03 00:21:23.529+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:21:23.529+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:21:23.529+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
06-03 00:21:23.529+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
06-03 00:21:23.539+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(413) > Hide Clock
06-03 00:21:24.350+0900 E/weather-agent( 7520): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:21:24.350+0900 I/CAPI_APPFW_APPLICATION( 7520): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:21:24.350+0900 E/weather-agent( 7520): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:21:24.350+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:21:24.350+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:21:24.470+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:21:24.480+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7520
06-03 00:21:24.480+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[7520] terminate event is forwarded
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7520, ]
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:24.480+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:21:24.480+0900 I/Tizen::App( 1210): (512) > Not registered pid(7520)
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:21:24.480+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:24.480+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7520
06-03 00:21:24.480+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:24.480+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7520.
06-03 00:21:24.920+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
06-03 00:21:25.471+0900 W/LFE      (15849): [15849] 26:15:57.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:27.873+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: MEM_FLUSH State: PAUSED
06-03 00:21:27.973+0900 W/LFE      (15849): [15849] 26:16:00.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:28.283+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11073066578611496416868
06-03 00:21:29.364+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:21:30.476+0900 W/LFE      (15849): [15849] 26:16:02.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:32.968+0900 W/LFE      (15849): [15849] 26:16:05.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:35.470+0900 W/LFE      (15849): [15849] 26:16:07.551[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:35.741+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11073716578611496416871
06-03 00:21:37.973+0900 W/LFE      (15849): [15849] 26:16:10.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:40.475+0900 W/LFE      (15849): [15849] 26:16:12.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:42.878+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11073926578611496416873
06-03 00:21:42.958+0900 W/LFE      (15849): [15849] 26:16:15.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:45.480+0900 W/LFE      (15849): [15849] 26:16:17.558[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:47.983+0900 W/LFE      (15849): [15849] 26:16:20.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:49.995+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107445657861149641687
