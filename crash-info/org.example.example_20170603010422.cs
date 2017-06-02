S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 8568
Date: 2017-06-03 01:04:22+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8568, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb6f3a000, r3   = 0xb6f3a020
r4   = 0x8001b6dc, r5   = 0xbe84d208
r6   = 0xb6fb1e5d, r7   = 0xbe84d090
r8   = 0x8001b6dc, r9   = 0xb5ca8708
r10  = 0xb85903a8, fp   = 0xbe84d1e4
ip   = 0xb6362120, sp   = 0xbe84d050
lr   = 0xb6326bd9, pc   = 0xb6fb1e86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     35456 KB
Buffers:     13880 KB
Cached:     110016 KB
VmPeak:     103756 KB
VmSize:     103752 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19984 KB
VmRSS:       19984 KB
VmData:      32052 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       31076 KB
VmPTE:          78 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8568 TID = 8568
8568 8569 8579 8580 

Maps Information
b1a31000 b1a39000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1a4a000 b1a57000 r-xp /usr/lib/libmdm-common.so.1.0.98
b1a68000 b1aa9000 r-xp /usr/lib/libmdm.so.1.2.12
b1ab9000 b1ac1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b1ad0000 b1ae0000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b1b01000 b1b61000 r-xp /usr/lib/libasound.so.2.0.0
b1b73000 b1b76000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1b86000 b1b89000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b1b99000 b1b9e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1bae000 b1baf000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b1bbf000 b1bca000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b1bde000 b1be3000 r-xp /usr/lib/libmmfsession.so.0.0.1
b1bf3000 b1c0e000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1c1e000 b1c25000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b1c35000 b1c3f000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b1c4f000 b1c51000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b1c61000 b1c62000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b1c72000 b1c7a000 r-xp /usr/lib/libfeedback.so.0.1.4
b1ca2000 b1ca3000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1cb3000 b1cc7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1e72000 b1e78000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b1e89000 b2688000 rw-p [stack:8580]
b2688000 b27e3000 r-xp /usr/lib/egl/libMali.so
b27f8000 b2881000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b2899000 b28a3000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b28b4000 b28c0000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28d2000 b30d1000 rw-p [stack:8579]
b3402000 b340c000 r-xp /lib/libnss_files-2.20-2014.11.so
b341d000 b3426000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3437000 b3448000 r-xp /lib/libnsl-2.20-2014.11.so
b345b000 b3461000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3472000 b3476000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3487000 b356a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b35a1000 b35c9000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b35db000 b3dda000 rw-p [stack:8569]
b3dda000 b3ddc000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3dec000 b3eca000 r-xp /usr/lib/libCOREGL.so.4.0
b3eea000 b3eed000 r-xp /lib/libattr.so.1.1.0
b3efd000 b3f04000 r-xp /lib/libcrypt-2.20-2014.11.so
b3f3c000 b3f3f000 r-xp /lib/libcap.so.2.21
b3f4f000 b3f51000 r-xp /usr/lib/libiri.so
b3f62000 b3f82000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3f83000 b3f86000 r-xp /usr/lib/libuuid.so.1.3.0
b3f96000 b3fad000 r-xp /usr/lib/libblkid.so.1.1.0
b3fbe000 b3fe7000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3ff9000 b4040000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4051000 b4057000 r-xp /usr/lib/libjson-c.so.2.0.1
b4068000 b406c000 r-xp /usr/lib/libogg.so.0.7.1
b407c000 b409e000 r-xp /usr/lib/libvorbis.so.0.4.3
b40ae000 b4192000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b41af000 b41ba000 r-xp /usr/lib/libgpg-error.so.0.15.0
b41ca000 b41cd000 r-xp /usr/lib/libEGL.so.1.4
b41dd000 b41e3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b41f3000 b41f5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4205000 b4212000 r-xp /usr/lib/libGLESv2.so.2.0
b4224000 b423c000 r-xp /usr/lib/libmount.so.1.1.0
b424d000 b424f000 r-xp /usr/lib/libXau.so.6.0.0
b425f000 b4295000 r-xp /usr/lib/libpulse.so.0.16.2
b42a6000 b42e9000 r-xp /usr/lib/libsndfile.so.1.0.25
b42ff000 b4379000 r-xp /usr/lib/libgcrypt.so.20.0.3
b438e000 b4395000 r-xp /usr/lib/libsensord-share.so
b43a5000 b4407000 r-xp /usr/lib/libpixman-1.so.0.28.2
b441c000 b441f000 r-xp /usr/lib/libXv.so.1.0.0
b442f000 b4434000 r-xp /usr/lib/libutilX.so.1.1.0
b4445000 b444a000 r-xp /usr/lib/libffi.so.6.0.2
b445a000 b446b000 r-xp /lib/libresolv-2.20-2014.11.so
b447f000 b4481000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b4491000 b454f000 r-xp /usr/lib/libcairo.so.2.11200.14
b4563000 b456b000 r-xp /usr/lib/libdrm.so.2.4.0
b457b000 b457e000 r-xp /usr/lib/libdri2.so.0.0.0
b458e000 b459a000 r-xp /usr/lib/libeeze.so.1.13.0
b45aa000 b45b3000 r-xp /usr/lib/libethumb.so.1.13.0
b45c4000 b45d8000 r-xp /usr/lib/libxcb.so.1.1.0
b45e8000 b45ea000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b45fa000 b4601000 r-xp /usr/lib/libembryo.so.1.13.0
b4611000 b461b000 r-xp /usr/lib/libecore_audio.so.1.13.0
b462d000 b4642000 r-xp /lib/libexpat.so.1.5.2
b4654000 b4657000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4667000 b4670000 r-xp /usr/lib/libXi.so.6.1.0
b4680000 b4682000 r-xp /usr/lib/libXgesture.so.7.0.0
b4692000 b4696000 r-xp /usr/lib/libXtst.so.6.1.0
b46a6000 b46ac000 r-xp /usr/lib/libXrender.so.1.3.0
b46bd000 b46c3000 r-xp /usr/lib/libXrandr.so.2.2.0
b46d3000 b46d5000 r-xp /usr/lib/libXinerama.so.1.0.0
b46e5000 b46e8000 r-xp /usr/lib/libXfixes.so.3.1.0
b46f8000 b4703000 r-xp /usr/lib/libXext.so.6.4.0
b4713000 b4715000 r-xp /usr/lib/libXdamage.so.1.1.0
b4726000 b4728000 r-xp /usr/lib/libXcomposite.so.1.0.0
b4738000 b473f000 r-xp /usr/lib/libXcursor.so.1.0.2
b474f000 b4767000 r-xp /usr/lib/libudev.so.1.6.0
b4769000 b47a5000 r-xp /usr/lib/libsystemd.so.0.4.0
b47a7000 b47bf000 r-xp /usr/lib/libsensor.so.1.1.0
b47d1000 b47d8000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b47e8000 b47ea000 r-xp /usr/lib/libappsvc.so.0.1.0
b47fa000 b47fd000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b480d000 b4826000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4837000 b486e000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b4880000 b496b000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b497e000 b4983000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b4993000 b4995000 r-xp /usr/lib/libvasum.so.0.3.1
b49a5000 b49a8000 r-xp /usr/lib/libiniparser.so.0
b49b8000 b49bc000 r-xp /usr/lib/libsmack.so.1.0.0
b49cc000 b49d1000 r-xp /usr/lib/libxdgmime.so.1.1.0
b49e3000 b4a0d000 r-xp /usr/lib/libdbus-1.so.3.8.12
b4a1e000 b4a35000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4a46000 b4a49000 r-xp /usr/lib/libbundle.so.0.1.22
b581a000 b5832000 r-xp /usr/lib/libpng12.so.0.50.0
b5843000 b5866000 r-xp /usr/lib/libjpeg.so.8.0.2
b5887000 b589b000 r-xp /usr/lib/libector.so.1.13.0
b58ac000 b58c4000 r-xp /usr/lib/liblua-5.1.so
b58d5000 b592c000 r-xp /usr/lib/libfreetype.so.6.11.3
b5940000 b5953000 r-xp /usr/lib/libfribidi.so.0.3.1
b5964000 b599e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b59af000 b59bd000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b59cd000 b59d5000 r-xp /usr/lib/libtbm.so.1.0.0
b59e5000 b59f2000 r-xp /usr/lib/libeio.so.1.13.0
b5a02000 b5a04000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5a14000 b5a19000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5a29000 b5a40000 r-xp /usr/lib/libefreet.so.1.13.0
b5a52000 b5a72000 r-xp /usr/lib/libeldbus.so.1.13.0
b5a82000 b5aa2000 r-xp /usr/lib/libecore_con.so.1.13.0
b5aa4000 b5aaa000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5aba000 b5acb000 r-xp /usr/lib/libemotion.so.1.13.0
b5adc000 b5ae3000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5af3000 b5b05000 r-xp /usr/lib/libecore_input.so.1.13.0
b5b16000 b5b1b000 r-xp /usr/lib/libecore_file.so.1.13.0
b5b2b000 b5b48000 r-xp /usr/lib/libeet.so.1.13.0
b5b61000 b5b71000 r-xp /usr/lib/libefl.so.1.13.0
b5b82000 b5b84000 r-xp /usr/lib/libttrace.so.1.1
b5b94000 b5c76000 r-xp /usr/lib/libX11.so.6.3.0
b5c89000 b5c98000 r-xp /usr/lib/libeo.so.1.13.0
b5ca9000 b5d2c000 r-xp /usr/lib/libedje.so.1.13.0
b5d3f000 b5d5d000 r-xp /usr/lib/libecore.so.1.13.0
b5d7d000 b5d95000 r-xp /lib/libz.so.1.2.8
b5da5000 b5f5c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5f85000 b5fd3000 r-xp /usr/lib/libssl.so.1.0.0
b5fe8000 b6016000 r-xp /usr/lib/libidn.so.11.5.44
b6026000 b603c000 r-xp /usr/lib/libnghttp2.so.5.4.0
b604d000 b6057000 r-xp /usr/lib/libcares.so.2.1.0
b6067000 b613c000 r-xp /usr/lib/libxml2.so.2.9.2
b6151000 b6179000 r-xp /usr/lib/libfontconfig.so.1.8.0
b618a000 b626c000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b627d000 b6287000 r-xp /usr/lib/libvconf.so.0.2.45
b6297000 b62b0000 r-xp /usr/lib/libecore_evas.so.1.13.0
b62c0000 b62f8000 r-xp /usr/lib/libecore_x.so.1.13.0
b630a000 b6352000 r-xp /usr/lib/libeina.so.1.13.0
b6363000 b6368000 r-xp /usr/lib/libappcore-common.so.1.1
b6378000 b637d000 r-xp /usr/lib/libappcore-efl.so.1.1
b638d000 b6392000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b63a3000 b63c9000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b63d9000 b63f1000 r-xp /usr/lib/libaul.so.0.1.0
b6403000 b649e000 r-xp /usr/lib/libstdc++.so.6.0.20
b64ba000 b659f000 r-xp /usr/lib/libicuuc.so.51.1
b65bc000 b66fc000 r-xp /usr/lib/libicui18n.so.51.1
b6713000 b671a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b672c000 b6797000 r-xp /lib/libm-2.20-2014.11.so
b67a8000 b67ae000 r-xp /lib/librt-2.20-2014.11.so
b67bf000 b67c1000 r-xp /lib/libdl-2.20-2014.11.so
b67d2000 b67df000 r-xp /usr/lib/libunwind.so.8.0.1
b6815000 b682e000 r-xp /lib/libgcc_s-4.9.so.1
b683e000 b6962000 r-xp /lib/libc-2.20-2014.11.so
b6977000 b69f0000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6a02000 b6b89000 r-xp /usr/lib/libevas.so.1.13.0
b6bbe000 b6df2000 r-xp /usr/lib/libelementary.so.1.13.0
b6e21000 b6e28000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6e39000 b6e3b000 r-xp /usr/lib/libdlog.so.0.0.0
b6e4b000 b6e91000 r-xp /usr/lib/libcurl.so.4.3.0
b6ea2000 b6eaa000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6eba000 b6ebe000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6ecf000 b6ed1000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6ee2000 b6ef7000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b6f07000 b6f1b000 r-xp /lib/libpthread-2.20-2014.11.so
b6f47000 b6f54000 r-xp /usr/lib/liblptcp.so
b6f66000 b6f6a000 r-xp /usr/lib/libsys-assert.so
b6f7b000 b6f9b000 r-xp /lib/ld-2.20-2014.11.so
b6fac000 b6fb4000 r-xp /opt/usr/apps/org.example.example/bin/example
b82e2000 b8647000 rw-p [heap]
be82d000 be84e000 rw-p [stack]
b82e2000 b8647000 rw-p [heap]
be82d000 be84e000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8568)
Call Stack Count: 17
 0: setting_view_cb + 0x29 (0xb6fb1e86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6a37175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5c94219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5c92fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a37515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a3f725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a44f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a48939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb4656173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb5d4ac4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb5d50a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb5d50c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb637b2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb6ebc909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb6fb1673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: __libc_start_main + 0x114 (0xb68544bc) [/lib/libc.so.6] + 0x164bc
16: (0xb6fae840) [/opt/usr/apps/org.example.example/bin/example] + 0x2840
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
_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 01:04:19.001+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8511) status(3)
06-03 01:04:19.001+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(8511)
06-03 01:04:19.001+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8511, appid: org.example.example, status: fg
06-03 01:04:19.011+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 01:04:19.011+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 01:04:19.011+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 01:04:19.011+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 01:04:19.031+0900 I/APP_CORE( 8511): appcore-efl.c: __do_app(514) > [APP 8511] Event: RESUME State: CREATED
06-03 01:04:19.041+0900 I/APP_CORE( 8511): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:04:19.041+0900 I/APP_CORE( 8511): appcore-efl.c: __do_app(625) > [APP 8511] Initial Launching, call the resume_cb
06-03 01:04:19.041+0900 I/CAPI_APPFW_APPLICATION( 8511): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:19.352+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8511) status(0)
06-03 01:04:19.552+0900 E/EFL     ( 8511): ecore_x<8511> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=130039552
06-03 01:04:19.702+0900 E/Tizen::App( 1210): (703) > Cannot acquire app for 8511.
06-03 01:04:19.712+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3302
06-03 01:04:19.722+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8511 pgid = 8511
06-03 01:04:19.722+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(8511)
06-03 01:04:19.722+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:19.752+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 01:04:19.752+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:04:19.752+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:04:19.752+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 01:04:19.752+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 01:04:19.802+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:04:19.802+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:04:19.802+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:04:19.802+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 8511
06-03 01:04:19.802+0900 I/Tizen::App( 1210): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 8511.
06-03 01:04:19.802+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8511
06-03 01:04:19.802+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8511
06-03 01:04:19.812+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3303
06-03 01:04:19.822+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 01:04:19.822+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:19.822+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 01:04:19.822+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:04:19.822+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 01:04:19.832+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:19.842+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 01:04:19.842+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:19.852+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:04:19.862+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:04:19.862+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:19.862+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:19.862+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:19.872+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:04:19.882+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 01:04:19.882+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:19.902+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:19.912+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:19.912+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 01:04:19.912+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 01:04:19.912+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 01:04:19.912+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 01:04:20.072+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:04:20.072+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:04:20.463+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=130040458
06-03 01:04:20.473+0900 W/LFE      (15849): [15849] 26:58:52.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:20.553+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=130040556
06-03 01:04:20.563+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 01:04:20.563+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 01:04:20.563+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 01:04:20.583+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 9
06-03 01:04:20.583+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:04:20.593+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:04:20.593+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(534) > Candidate is not prepared, enter legacy logic
06-03 01:04:20.593+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:04:20.593+0900 E/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(273) > launching failed
06-03 01:04:20.593+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3063) > Launch with legacy way : no launchpad
06-03 01:04:20.593+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 8568
06-03 01:04:20.653+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 8568
06-03 01:04:20.653+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8568, appid: org.example.example
06-03 01:04:20.653+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:04:20.663+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 01:04:20.663+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 8568.
06-03 01:04:20.673+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(8568)
06-03 01:04:20.813+0900 I/CAPI_APPFW_APPLICATION( 8568): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:04:21.214+0900 I/UXT     ( 8564): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 01:04:21.224+0900 I/CAPI_APPFW_APPLICATION( 8568): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:04:21.264+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=130041262
06-03 01:04:21.284+0900 E/TBM     ( 8568): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:04:21.284+0900 I/MALI    ( 8568): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=8568   open drm_fd=84 
06-03 01:04:21.364+0900 E/EFL     (  610): ecore_x<610> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=130041360
06-03 01:04:21.584+0900 I/APP_CORE( 8568): appcore-efl.c: __do_app(514) > [APP 8568] Event: RESET State: CREATED
06-03 01:04:21.584+0900 I/CAPI_APPFW_APPLICATION( 8568): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:04:21.594+0900 E/EFL     ( 8568): edje<8568> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:21.594+0900 E/EFL     ( 8568): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:21.594+0900 E/EFL     ( 8568): edje<8568> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:21.594+0900 E/EFL     ( 8568): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:21.594+0900 E/EFL     ( 8568): edje<8568> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:21.594+0900 E/EFL     ( 8568): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:21.594+0900 E/EFL     ( 8568): edje<8568> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:21.594+0900 E/EFL     ( 8568): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:21.594+0900 E/EFL     ( 8568): edje<8568> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:04:21.594+0900 E/EFL     ( 8568): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:04:21.634+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:21.634+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:21.654+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 01:04:21.684+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 01:04:21.684+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:21.704+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:21.704+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:21.714+0900 W/APP_CORE( 8568): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:a400003
06-03 01:04:21.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:04:21.744+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 01:04:21.744+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:04:21.744+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 01:04:21.754+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 01:04:21.754+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 01:04:21.754+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 01:04:21.754+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8568) status(3)
06-03 01:04:21.754+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:04:21.754+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:04:21.754+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(8568)
06-03 01:04:21.754+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8568, appid: org.example.example, status: fg
06-03 01:04:21.764+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 01:04:21.764+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 01:04:21.764+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 01:04:21.764+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 01:04:21.824+0900 I/APP_CORE( 8568): appcore-efl.c: __do_app(514) > [APP 8568] Event: RESUME State: CREATED
06-03 01:04:21.854+0900 I/APP_CORE( 8568): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:04:21.854+0900 I/APP_CORE( 8568): appcore-efl.c: __do_app(625) > [APP 8568] Initial Launching, call the resume_cb
06-03 01:04:21.854+0900 I/CAPI_APPFW_APPLICATION( 8568): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:22.084+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8568) status(0)
06-03 01:04:22.195+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 01:04:22.415+0900 E/EFL     ( 8568): ecore_x<8568> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=130042409
06-03 01:04:22.555+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:22.555+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 01:04:22.585+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[8568] terminate event is forwarded
06-03 01:04:22.585+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:04:22.585+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 8568, ]
06-03 01:04:22.585+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:04:22.585+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 01:04:22.585+0900 I/Tizen::App( 1210): (512) > Not registered pid(8568)
06-03 01:04:22.585+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 01:04:22.585+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 8568
06-03 01:04:22.585+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 01:04:22.585+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:22.585+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:04:22.585+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:04:22.595+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 01:04:22.595+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 01:04:22.595+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8568
06-03 01:04:22.595+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8568
06-03 01:04:22.595+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:22.595+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 8568.
06-03 01:04:22.595+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:04:22.615+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 01:04:22.665+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 01:04:22.665+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:04:22.665+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 01:04:22.665+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:22.665+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:22.705+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 01:04:22.725+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 01:04:22.725+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:22.745+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:22.745+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:04:22.755+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:04:22.755+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:22.755+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:22.755+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:22.775+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:04:22.785+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:22.785+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 01:04:22.785+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 01:04:22.785+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 01:04:22.785+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 01:04:22.885+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:04:22.885+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:04:22.975+0900 W/LFE      (15849): [15849] 26:58:55.047[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:23.576+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=130043569
06-03 01:04:23.576+0900 E/cluster-view(  860): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86PowerOff]Key [Down]Event!! 
06-03 01:04:23.766+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 01:04:23.766+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 01:04:23.766+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=130043761
06-03 01:04:23.766+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 01:04:23.766+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 01:04:23.766+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 01:04:23.776+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 01:04:23.776+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 01:04:23.776+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 01:04:23.776+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 01:04:23.776+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 01:04:23.786+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 01:04:23.796+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[powerkey] (status:3)
06-03 01:04:23.796+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:powerkey
06-03 01:04:23.796+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
06-03 01:04:23.796+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:0
06-03 01:04:23.796+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 01:04:23.796+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
06-03 01:04:23.806+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:04:23.806+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 01:04:23.816+0900 W/APP_CORE(  860): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
06-03 01:04:23.816+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 01:04:23.816+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:04:23.816+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 01:04:23.816+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
06-03 01:04:23.816+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
06-03 01:04:23.816+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
06-03 01:04:23.816+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
06-03 01:04:23.816+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 01:04:23.816+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:04:23.816+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 01:04:23.816+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 01:04:23.826+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 8590
06-03 01:04:23.886+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 8590
06-03 01:04:23.886+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8590, appid: com.samsung.weather-m-agent
06-03 01:04:23.896+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 01:04:23.896+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 8590.
06-03 01:04:23.906+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8590)
06-03 01:04:23.956+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:04:24.046+0900 E/weather-agent( 8590): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 01:04:24.046+0900 E/weather-common( 8590): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 01:04:24.056+0900 E/weather-agent( 8590): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 01:04:24.056+0900 E/weather-agent( 8590): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 01:04:24.056+0900 E/weather-common( 8590): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 01:04:24.056+0900 E/weather-common( 8590): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 01:04:24.056+0900 E/weather-common( 8590): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 01:04:24.056+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 01:04:24.056+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 01:04:24.056+0900 I/MESSAGE_PORT( 8590): message-port.c: __initialize(872) > initialize
06-03 01:04:24.066+0900 I/MESSAGE_PORT( 8590): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 01:04:24.166+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 01:04:24.166+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 01:04:24.166+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 01:04:24.166+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 01:04:24.207+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(3)
06-03 01:04:24.207+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:04:24.207+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:04:24.207+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.lockscreen(845)
06-03 01:04:24.207+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: fg
06-03 01:04:24.207+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 01:04:24.207+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 01:04:24.207+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 01:04:24.217+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(0)
06-03 01:04:24.217+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: PAUSED
06-03 01:04:24.217+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:04:24.217+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:04:24.217+0900 I/MESSAGE_PORT( 8590): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:24.217+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 01:04:24.217+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 01:04:24.217+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:04:24.227+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:04:24.227+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:24.227+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:04:24.227+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 01:04:24.227+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:04:24.227+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:04:24.227+0900 I/MESSAGE_PORT( 8590): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:24.227+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 01:04:24.227+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 01:04:24.227+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:04:24.237+0900 E/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 01:04:24.237+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:04:24.237+0900 E/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 01:04:24.237+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:04:24.237+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:04:24.247+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:04:24.247+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:04:24.247+0900 I/MESSAGE_PORT( 8590): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:04:24.247+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 01:04:24.247+0900 I/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 01:04:24.247+0900 I/MESSAGE_PORT( 8590): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:04:24.247+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:04:24.247+0900 E/MESSAGE_PORT( 8590): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 01:04:24.247+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 01:04:24.247+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 01:04:24.257+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 01:04:24.257+0900 E/weather-common( 8590): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 01:04:24.257+0900 E/weather-agent( 8590): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 01:04:24.257+0900 E/weather-agent( 8590): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 01:04:24.257+0900 I/MESSAGE_PORT( 8590): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:04:24.257+0900 I/MESSAGE_PORT( 8590): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:04:24.267+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [com.samsun] 
06-03 01:04:24.267+0900 I/Tizen::System( 1210): (273) > Current App[com.samsun] is already actived.
06-03 01:04:24.277+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:24.287+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:24.297+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 01:04:24.297+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 01:04:24.297+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 01:04:24.307+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 01:04:24.317+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:04:24.317+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:04:24.317+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:24.317+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:24.317+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:04:24.317+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:04:24.327+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 01:04:24.367+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:04:24.367+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:04:24.397+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:04:24.407+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:04:24.417+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:1:LOCK
06-03 01:04:24.417+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:1 event_info:0
06-03 01:04:24.417+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 01:04:24.417+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
06-03 01:04:24.417+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [visible]
06-03 01:04:24.417+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10001:WIN_BECOME_VISIBLE
06-03 01:04:24.417+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10001 event_info:0
06-03 01:04:24.417+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
06-03 01:04:24.417+0900 W/APP_CORE(  845): appcore-efl.c: __visibility_cb(989) > LCD status is off, skip the AE_RESUME event
06-03 01:04:24.417+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 01:04:24.427+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(413) > Hide Clock
06-03 01:04:24.427+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:04:24.427+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:04:24.427+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:04:24.427+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:04:24.427+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
06-03 01:04:24.427+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
06-03 01:04:24.427+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
06-03 01:04:24.427+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
06-03 01:04:24.427+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
06-03 01:04:24.427+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
06-03 01:04:25.258+0900 E/weather-agent( 8590): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 01:04:25.258+0900 I/CAPI_APPFW_APPLICATION( 8590): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 01:04:25.258+0900 E/weather-agent( 8590): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 01:04:25.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 01:04:25.258+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 01:04:25.378+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 01:04:25.388+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[8590] terminate event is forwarded
06-03 01:04:25.388+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:04:25.388+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 8590, ]
06-03 01:04:25.388+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:04:25.388+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 01:04:25.388+0900 I/Tizen::App( 1210): (512) > Not registered pid(8590)
06-03 01:04:25.388+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 01:04:25.388+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:04:25.388+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 8590
06-03 01:04:25.398+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:04:25.398+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 8590.
06-03 01:04:25.398+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8590
06-03 01:04:25.468+0900 W/LFE      (15849): [15849] 26:58:57.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:26.078+0900 W/CRASH_MANAGER( 8545): worker.c: worker_job(1199) > 11085116578611496419459
06-03 01:04:27.970+0900 W/LFE      (15849): [15849] 26:59:00.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:28.811+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
06-03 01:04:30.262+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 01:04:30.473+0900 W/LFE      (15849): [15849] 26:59:02.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:32.975+0900 W/LFE      (15849): [15849] 26:59:05.052[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 01:04:33.235+0900 W/CRASH_MANAGER( 8545): worker.c: worker_job(1199) > 1108568657861149641946
