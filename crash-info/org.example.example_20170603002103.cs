S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7315
Date: 2017-06-03 00:21:03+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7315, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb6ece000, r3   = 0xb6ece020
r4   = 0x8001b2da, r5   = 0xbe968208
r6   = 0xb6f439a5, r7   = 0xbe968090
r8   = 0x8001b2da, r9   = 0xb5c3c708
r10  = 0xb7e69d60, fp   = 0xbe9681e4
ip   = 0xb62f6120, sp   = 0xbe968050
lr   = 0xb62babd9, pc   = 0xb6f439ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     43700 KB
Buffers:     15756 KB
Cached:     115788 KB
VmPeak:     112964 KB
VmSize:     112960 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       20024 KB
VmRSS:       20024 KB
VmData:      41260 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       31076 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 5
PID = 7315 TID = 7315
7315 7317 7326 7327 7328 

Maps Information
b114a000 b1949000 rw-p [stack:7328]
b19c5000 b19cd000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b19de000 b19eb000 r-xp /usr/lib/libmdm-common.so.1.0.98
b19fc000 b1a3d000 r-xp /usr/lib/libmdm.so.1.2.12
b1a4d000 b1a55000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b1a64000 b1a74000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b1a95000 b1af5000 r-xp /usr/lib/libasound.so.2.0.0
b1b07000 b1b0a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1b1a000 b1b1d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b1b2d000 b1b32000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1b42000 b1b43000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b1b53000 b1b5e000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b1b72000 b1b77000 r-xp /usr/lib/libmmfsession.so.0.0.1
b1b87000 b1ba2000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1bb2000 b1bb9000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b1bc9000 b1bd3000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b1be3000 b1be5000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b1bf5000 b1bf6000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b1c06000 b1c0e000 r-xp /usr/lib/libfeedback.so.0.1.4
b1c36000 b1c37000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c47000 b1c5b000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1e06000 b1e0c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b1e1d000 b261c000 rw-p [stack:7327]
b261c000 b2777000 r-xp /usr/lib/egl/libMali.so
b278c000 b2815000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b282d000 b2837000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b2848000 b2854000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b2866000 b3065000 rw-p [stack:7326]
b3396000 b33a0000 r-xp /lib/libnss_files-2.20-2014.11.so
b33b1000 b33ba000 r-xp /lib/libnss_nis-2.20-2014.11.so
b33cb000 b33dc000 r-xp /lib/libnsl-2.20-2014.11.so
b33ef000 b33f5000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3406000 b340a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b341b000 b34fe000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3535000 b355d000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b356f000 b3d6e000 rw-p [stack:7317]
b3d6e000 b3d70000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3d80000 b3e5e000 r-xp /usr/lib/libCOREGL.so.4.0
b3e7e000 b3e81000 r-xp /lib/libattr.so.1.1.0
b3e91000 b3e98000 r-xp /lib/libcrypt-2.20-2014.11.so
b3ed0000 b3ed3000 r-xp /lib/libcap.so.2.21
b3ee3000 b3ee5000 r-xp /usr/lib/libiri.so
b3ef6000 b3f16000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3f17000 b3f1a000 r-xp /usr/lib/libuuid.so.1.3.0
b3f2a000 b3f41000 r-xp /usr/lib/libblkid.so.1.1.0
b3f52000 b3f7b000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3f8d000 b3fd4000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b3fe5000 b3feb000 r-xp /usr/lib/libjson-c.so.2.0.1
b3ffc000 b4000000 r-xp /usr/lib/libogg.so.0.7.1
b4010000 b4032000 r-xp /usr/lib/libvorbis.so.0.4.3
b4042000 b4126000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4143000 b414e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b415e000 b4161000 r-xp /usr/lib/libEGL.so.1.4
b4171000 b4177000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4187000 b4189000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4199000 b41a6000 r-xp /usr/lib/libGLESv2.so.2.0
b41b8000 b41d0000 r-xp /usr/lib/libmount.so.1.1.0
b41e1000 b41e3000 r-xp /usr/lib/libXau.so.6.0.0
b41f3000 b4229000 r-xp /usr/lib/libpulse.so.0.16.2
b423a000 b427d000 r-xp /usr/lib/libsndfile.so.1.0.25
b4293000 b430d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b4322000 b4329000 r-xp /usr/lib/libsensord-share.so
b4339000 b439b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43b0000 b43b3000 r-xp /usr/lib/libXv.so.1.0.0
b43c3000 b43c8000 r-xp /usr/lib/libutilX.so.1.1.0
b43d9000 b43de000 r-xp /usr/lib/libffi.so.6.0.2
b43ee000 b43ff000 r-xp /lib/libresolv-2.20-2014.11.so
b4413000 b4415000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b4425000 b44e3000 r-xp /usr/lib/libcairo.so.2.11200.14
b44f7000 b44ff000 r-xp /usr/lib/libdrm.so.2.4.0
b450f000 b4512000 r-xp /usr/lib/libdri2.so.0.0.0
b4522000 b452e000 r-xp /usr/lib/libeeze.so.1.13.0
b453e000 b4547000 r-xp /usr/lib/libethumb.so.1.13.0
b4558000 b456c000 r-xp /usr/lib/libxcb.so.1.1.0
b457c000 b457e000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b458e000 b4595000 r-xp /usr/lib/libembryo.so.1.13.0
b45a5000 b45af000 r-xp /usr/lib/libecore_audio.so.1.13.0
b45c1000 b45d6000 r-xp /lib/libexpat.so.1.5.2
b45e8000 b45eb000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b45fb000 b4604000 r-xp /usr/lib/libXi.so.6.1.0
b4614000 b4616000 r-xp /usr/lib/libXgesture.so.7.0.0
b4626000 b462a000 r-xp /usr/lib/libXtst.so.6.1.0
b463a000 b4640000 r-xp /usr/lib/libXrender.so.1.3.0
b4651000 b4657000 r-xp /usr/lib/libXrandr.so.2.2.0
b4667000 b4669000 r-xp /usr/lib/libXinerama.so.1.0.0
b4679000 b467c000 r-xp /usr/lib/libXfixes.so.3.1.0
b468c000 b4697000 r-xp /usr/lib/libXext.so.6.4.0
b46a7000 b46a9000 r-xp /usr/lib/libXdamage.so.1.1.0
b46ba000 b46bc000 r-xp /usr/lib/libXcomposite.so.1.0.0
b46cc000 b46d3000 r-xp /usr/lib/libXcursor.so.1.0.2
b46e3000 b46fb000 r-xp /usr/lib/libudev.so.1.6.0
b46fd000 b4739000 r-xp /usr/lib/libsystemd.so.0.4.0
b473b000 b4753000 r-xp /usr/lib/libsensor.so.1.1.0
b4765000 b476c000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b477c000 b477e000 r-xp /usr/lib/libappsvc.so.0.1.0
b478e000 b4791000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b47a1000 b47ba000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b47cb000 b4802000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b4814000 b48ff000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b4912000 b4917000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b4927000 b4929000 r-xp /usr/lib/libvasum.so.0.3.1
b4939000 b493c000 r-xp /usr/lib/libiniparser.so.0
b494c000 b4950000 r-xp /usr/lib/libsmack.so.1.0.0
b4960000 b4965000 r-xp /usr/lib/libxdgmime.so.1.1.0
b4977000 b49a1000 r-xp /usr/lib/libdbus-1.so.3.8.12
b49b2000 b49c9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b49da000 b49dd000 r-xp /usr/lib/libbundle.so.0.1.22
b57ae000 b57c6000 r-xp /usr/lib/libpng12.so.0.50.0
b57d7000 b57fa000 r-xp /usr/lib/libjpeg.so.8.0.2
b581b000 b582f000 r-xp /usr/lib/libector.so.1.13.0
b5840000 b5858000 r-xp /usr/lib/liblua-5.1.so
b5869000 b58c0000 r-xp /usr/lib/libfreetype.so.6.11.3
b58d4000 b58e7000 r-xp /usr/lib/libfribidi.so.0.3.1
b58f8000 b5932000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5943000 b5951000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5961000 b5969000 r-xp /usr/lib/libtbm.so.1.0.0
b5979000 b5986000 r-xp /usr/lib/libeio.so.1.13.0
b5996000 b5998000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b59a8000 b59ad000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b59bd000 b59d4000 r-xp /usr/lib/libefreet.so.1.13.0
b59e6000 b5a06000 r-xp /usr/lib/libeldbus.so.1.13.0
b5a16000 b5a36000 r-xp /usr/lib/libecore_con.so.1.13.0
b5a38000 b5a3e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5a4e000 b5a5f000 r-xp /usr/lib/libemotion.so.1.13.0
b5a70000 b5a77000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5a87000 b5a99000 r-xp /usr/lib/libecore_input.so.1.13.0
b5aaa000 b5aaf000 r-xp /usr/lib/libecore_file.so.1.13.0
b5abf000 b5adc000 r-xp /usr/lib/libeet.so.1.13.0
b5af5000 b5b05000 r-xp /usr/lib/libefl.so.1.13.0
b5b16000 b5b18000 r-xp /usr/lib/libttrace.so.1.1
b5b28000 b5c0a000 r-xp /usr/lib/libX11.so.6.3.0
b5c1d000 b5c2c000 r-xp /usr/lib/libeo.so.1.13.0
b5c3d000 b5cc0000 r-xp /usr/lib/libedje.so.1.13.0
b5cd3000 b5cf1000 r-xp /usr/lib/libecore.so.1.13.0
b5d11000 b5d29000 r-xp /lib/libz.so.1.2.8
b5d39000 b5ef0000 r-xp /usr/lib/libcrypto.so.1.0.0
b5f19000 b5f67000 r-xp /usr/lib/libssl.so.1.0.0
b5f7c000 b5faa000 r-xp /usr/lib/libidn.so.11.5.44
b5fba000 b5fd0000 r-xp /usr/lib/libnghttp2.so.5.4.0
b5fe1000 b5feb000 r-xp /usr/lib/libcares.so.2.1.0
b5ffb000 b60d0000 r-xp /usr/lib/libxml2.so.2.9.2
b60e5000 b610d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b611e000 b6200000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6211000 b621b000 r-xp /usr/lib/libvconf.so.0.2.45
b622b000 b6244000 r-xp /usr/lib/libecore_evas.so.1.13.0
b6254000 b628c000 r-xp /usr/lib/libecore_x.so.1.13.0
b629e000 b62e6000 r-xp /usr/lib/libeina.so.1.13.0
b62f7000 b62fc000 r-xp /usr/lib/libappcore-common.so.1.1
b630c000 b6311000 r-xp /usr/lib/libappcore-efl.so.1.1
b6321000 b6326000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6337000 b635d000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b636d000 b6385000 r-xp /usr/lib/libaul.so.0.1.0
b6397000 b6432000 r-xp /usr/lib/libstdc++.so.6.0.20
b644e000 b6533000 r-xp /usr/lib/libicuuc.so.51.1
b6550000 b6690000 r-xp /usr/lib/libicui18n.so.51.1
b66a7000 b66ae000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b66c0000 b672b000 r-xp /lib/libm-2.20-2014.11.so
b673c000 b6742000 r-xp /lib/librt-2.20-2014.11.so
b6753000 b6755000 r-xp /lib/libdl-2.20-2014.11.so
b6766000 b6773000 r-xp /usr/lib/libunwind.so.8.0.1
b67a9000 b67c2000 r-xp /lib/libgcc_s-4.9.so.1
b67d2000 b68f6000 r-xp /lib/libc-2.20-2014.11.so
b690b000 b6984000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6996000 b6b1d000 r-xp /usr/lib/libevas.so.1.13.0
b6b52000 b6d86000 r-xp /usr/lib/libelementary.so.1.13.0
b6db5000 b6dbc000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6dcd000 b6dcf000 r-xp /usr/lib/libdlog.so.0.0.0
b6ddf000 b6e25000 r-xp /usr/lib/libcurl.so.4.3.0
b6e36000 b6e3e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6e4e000 b6e52000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6e63000 b6e65000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6e76000 b6e8b000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b6e9b000 b6eaf000 r-xp /lib/libpthread-2.20-2014.11.so
b6edb000 b6ee8000 r-xp /usr/lib/liblptcp.so
b6efa000 b6efe000 r-xp /usr/lib/libsys-assert.so
b6f0f000 b6f2f000 r-xp /lib/ld-2.20-2014.11.so
b6f40000 b6f48000 r-xp /opt/usr/apps/org.example.example/bin/example
b7bbc000 b7f19000 rw-p [heap]
be948000 be969000 rw-p [stack]
b6f40000 b6f48000 r-xp /opt/usr/apps/org.example.example/bin/example
b7bbc000 b7f19000 rw-p [heap]
be948000 be969000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7315)
Call Stack Count: 17
 0: feeding_view_cb + 0x29 (0xb6f439ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb69cb175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5c28219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5c26fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb69cb515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb69d3725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb69d8f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb69dc939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb45ea173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb5cdec4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb5ce4a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb5ce4c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb630f2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb6e50909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb6f45673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: __libc_start_main + 0x114 (0xb67e84bc) [/lib/libc.so.6] + 0x164bc
16: (0xb6f42840) [/opt/usr/apps/org.example.example/bin/example] + 0x2840
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
c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:11.517+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:11.607+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:11.607+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:12.058+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11072886578611496416860
06-03 00:21:12.118+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127452125
06-03 00:21:12.218+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127452223
06-03 00:21:12.228+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:21:12.228+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:21:12.228+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:21:12.248+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:21:12.248+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:12.258+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:21:12.258+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:21:12.258+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:21:12.278+0900 I/CAPI_APPFW_APPLICATION( 7392): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:21:12.278+0900 I/CAPI_APPFW_APPLICATION( 7392): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:21:12.318+0900 E/TBM     ( 7392): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:21:12.358+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7392, appid: org.example.example
06-03 00:21:12.358+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:21:12.358+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7392)
06-03 00:21:12.498+0900 I/APP_CORE( 7392): appcore-efl.c: __do_app(514) > [APP 7392] Event: RESET State: CREATED
06-03 00:21:12.498+0900 I/CAPI_APPFW_APPLICATION( 7392): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:21:12.498+0900 E/EFL     ( 7392): edje<7392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:12.498+0900 E/EFL     ( 7392): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:12.508+0900 E/EFL     ( 7392): edje<7392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:12.508+0900 E/EFL     ( 7392): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:12.508+0900 E/EFL     ( 7392): edje<7392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:12.508+0900 E/EFL     ( 7392): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:12.508+0900 E/EFL     ( 7392): edje<7392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:12.508+0900 E/EFL     ( 7392): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:12.508+0900 E/EFL     ( 7392): edje<7392> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:12.508+0900 E/EFL     ( 7392): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:12.548+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:12.548+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:12.548+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:12.568+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:12.568+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:12.568+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:12.588+0900 W/APP_CORE( 7392): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:21:12.588+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:12.688+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:12.688+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:12.688+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:12.688+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:12.688+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:12.688+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:12.698+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7392) status(3)
06-03 00:21:12.698+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7392)
06-03 00:21:12.698+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7392, appid: org.example.example, status: fg
06-03 00:21:12.708+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:12.708+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:12.708+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:12.708+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:12.748+0900 I/APP_CORE( 7392): appcore-efl.c: __do_app(514) > [APP 7392] Event: RESUME State: CREATED
06-03 00:21:12.758+0900 I/APP_CORE( 7392): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:12.758+0900 I/APP_CORE( 7392): appcore-efl.c: __do_app(625) > [APP 7392] Initial Launching, call the resume_cb
06-03 00:21:12.758+0900 I/CAPI_APPFW_APPLICATION( 7392): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:12.968+0900 W/LFE      (15849): [15849] 26:15:45.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:13.069+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7392) status(0)
06-03 00:21:13.149+0900 E/EFL     ( 7392): ecore_x<7392> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127453151
06-03 00:21:13.319+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:13.319+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:21:13.329+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:13.329+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:13.329+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:21:13.329+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:21:13.359+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:21:13.399+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7392 pgid = 7392
06-03 00:21:13.399+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7392)
06-03 00:21:13.409+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:21:13.409+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:13.409+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:21:13.409+0900 E/Tizen::App( 1210): (703) > Cannot acquire app for 7392.
06-03 00:21:13.409+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:13.409+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3233
06-03 00:21:13.419+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:13.429+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:21:13.439+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:13.439+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:13.439+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:13.439+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:13.439+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:13.459+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:13.459+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:13.459+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:13.469+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:13.479+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:21:13.479+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:21:13.479+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:21:13.479+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:21:13.479+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:13.569+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:21:13.569+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:21:13.569+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:21:13.569+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7392
06-03 00:21:13.569+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7392
06-03 00:21:13.569+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7392
06-03 00:21:13.569+0900 I/Tizen::App( 1210): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 7392.
06-03 00:21:13.599+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:13.609+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:13.629+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3234
06-03 00:21:13.629+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:21:13.999+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127454001
06-03 00:21:14.030+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127454034
06-03 00:21:14.030+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:21:14.040+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:21:14.040+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:21:14.060+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:21:14.060+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:14.060+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:21:14.060+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(534) > Candidate is not prepared, enter legacy logic
06-03 00:21:14.060+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:21:14.060+0900 E/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(273) > launching failed
06-03 00:21:14.060+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3063) > Launch with legacy way : no launchpad
06-03 00:21:14.070+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7445
06-03 00:21:14.120+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7445
06-03 00:21:14.120+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7445, appid: org.example.example
06-03 00:21:14.120+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:21:14.130+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7445)
06-03 00:21:14.150+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:14.150+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7445.
06-03 00:21:14.200+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127454200
06-03 00:21:14.270+0900 I/CAPI_APPFW_APPLICATION( 7445): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:21:14.290+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127454296
06-03 00:21:14.580+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:21:14.740+0900 I/CAPI_APPFW_APPLICATION( 7445): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:21:14.740+0900 I/UXT     ( 7444): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:21:14.780+0900 E/TBM     ( 7445): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:21:14.780+0900 I/MALI    ( 7445): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=7445   open drm_fd=84 
06-03 00:21:15.071+0900 I/APP_CORE( 7445): appcore-efl.c: __do_app(514) > [APP 7445] Event: RESET State: CREATED
06-03 00:21:15.071+0900 I/CAPI_APPFW_APPLICATION( 7445): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:21:15.071+0900 E/EFL     ( 7445): edje<7445> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:15.071+0900 E/EFL     ( 7445): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:15.071+0900 E/EFL     ( 7445): edje<7445> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:15.071+0900 E/EFL     ( 7445): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:15.071+0900 E/EFL     ( 7445): edje<7445> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:15.071+0900 E/EFL     ( 7445): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:15.071+0900 E/EFL     ( 7445): edje<7445> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:15.071+0900 E/EFL     ( 7445): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:15.081+0900 E/EFL     ( 7445): edje<7445> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:15.081+0900 E/EFL     ( 7445): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:15.111+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:15.111+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:15.151+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:15.151+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:15.161+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:15.161+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:15.171+0900 W/APP_CORE( 7445): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00003
06-03 00:21:15.171+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:15.171+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:15.171+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:15.171+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:15.181+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:15.181+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:15.181+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:15.181+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7445) status(3)
06-03 00:21:15.181+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:15.181+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:15.181+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7445)
06-03 00:21:15.181+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7445, appid: org.example.example, status: fg
06-03 00:21:15.191+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:15.191+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:15.191+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:15.191+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:15.261+0900 I/APP_CORE( 7445): appcore-efl.c: __do_app(514) > [APP 7445] Event: RESUME State: CREATED
06-03 00:21:15.281+0900 I/APP_CORE( 7445): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:15.281+0900 I/APP_CORE( 7445): appcore-efl.c: __do_app(625) > [APP 7445] Initial Launching, call the resume_cb
06-03 00:21:15.281+0900 I/CAPI_APPFW_APPLICATION( 7445): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:15.471+0900 W/LFE      (15849): [15849] 26:15:47.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:15.531+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7445) status(0)
06-03 00:21:15.781+0900 E/EFL     ( 7445): ecore_x<7445> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127455783
06-03 00:21:15.901+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:21:15.901+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:15.911+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7445
06-03 00:21:15.911+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7445
06-03 00:21:15.911+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7445
06-03 00:21:15.911+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7445] terminate event is forwarded
06-03 00:21:15.911+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:15.911+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7445, ]
06-03 00:21:15.911+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:15.911+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:21:15.911+0900 I/Tizen::App( 1210): (512) > Not registered pid(7445)
06-03 00:21:15.911+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:21:15.911+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:15.911+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:21:15.911+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:15.911+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:15.911+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:21:15.911+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:21:15.931+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:15.931+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7445.
06-03 00:21:15.941+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:21:15.981+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:21:15.981+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:15.981+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:21:15.981+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:15.981+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:15.991+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:21:16.011+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:16.011+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:16.011+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:16.011+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:16.011+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:16.011+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:16.011+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:16.021+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:16.021+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:16.031+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:16.031+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:21:16.031+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:21:16.031+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:21:16.031+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:21:16.122+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:16.122+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:16.692+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127456694
06-03 00:21:16.772+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127456769
06-03 00:21:16.772+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:21:16.772+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:21:16.782+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:21:16.792+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:21:16.792+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:16.802+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:21:16.802+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:21:16.802+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:21:16.822+0900 I/CAPI_APPFW_APPLICATION( 7444): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:21:16.832+0900 I/CAPI_APPFW_APPLICATION( 7444): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:21:16.872+0900 E/TBM     ( 7444): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:21:16.902+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7444, appid: org.example.example
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
06-03 00:21:21.046+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107315657861149641686
