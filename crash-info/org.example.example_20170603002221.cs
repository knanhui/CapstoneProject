S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7473
Date: 2017-06-03 00:22:21+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7473, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb6f2e000, r3   = 0xb6f2e020
r4   = 0x8001b2da, r5   = 0xbe8c2208
r6   = 0xb6fa39a5, r7   = 0xbe8c2090
r8   = 0x8001b2da, r9   = 0xb5c9c708
r10  = 0xb87c0d48, fp   = 0xbe8c21e4
ip   = 0xb6356120, sp   = 0xbe8c2050
lr   = 0xb631abd9, pc   = 0xb6fa39ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     41232 KB
Buffers:     16732 KB
Cached:     112244 KB
VmPeak:     117180 KB
VmSize:     104556 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25164 KB
VmRSS:       19984 KB
VmData:      33140 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       31076 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7473 TID = 7473
7473 7474 7487 7488 

Maps Information
b1a25000 b1a2d000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1a3e000 b1a4b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b1a5c000 b1a9d000 r-xp /usr/lib/libmdm.so.1.2.12
b1aad000 b1ab5000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b1ac4000 b1ad4000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b1af5000 b1b55000 r-xp /usr/lib/libasound.so.2.0.0
b1b67000 b1b6a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1b7a000 b1b7d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b1b8d000 b1b92000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b1ba2000 b1ba3000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b1bb3000 b1bbe000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b1bd2000 b1bd7000 r-xp /usr/lib/libmmfsession.so.0.0.1
b1be7000 b1c02000 r-xp /usr/lib/libmmfsound.so.0.1.0
b1c12000 b1c19000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b1c29000 b1c33000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b1c43000 b1c45000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b1c55000 b1c56000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b1c66000 b1c6e000 r-xp /usr/lib/libfeedback.so.0.1.4
b1c96000 b1c97000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1ca7000 b1cbb000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1e66000 b1e6c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b1e7d000 b267c000 rw-p [stack:7488]
b267c000 b27d7000 r-xp /usr/lib/egl/libMali.so
b27ec000 b2875000 r-xp /usr/lib/evas/modules/engines/gl_generic/v-1.13/module.so
b288d000 b2897000 r-xp /usr/lib/evas/modules/engines/gl_x11/v-1.13/module.so
b28a8000 b28b4000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b28c6000 b30c5000 rw-p [stack:7487]
b33f6000 b3400000 r-xp /lib/libnss_files-2.20-2014.11.so
b3411000 b341a000 r-xp /lib/libnss_nis-2.20-2014.11.so
b342b000 b343c000 r-xp /lib/libnsl-2.20-2014.11.so
b344f000 b3455000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3466000 b346a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b347b000 b355e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3595000 b35bd000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b35cf000 b3dce000 rw-p [stack:7474]
b3dce000 b3dd0000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3de0000 b3ebe000 r-xp /usr/lib/libCOREGL.so.4.0
b3ede000 b3ee1000 r-xp /lib/libattr.so.1.1.0
b3ef1000 b3ef8000 r-xp /lib/libcrypt-2.20-2014.11.so
b3f30000 b3f33000 r-xp /lib/libcap.so.2.21
b3f43000 b3f45000 r-xp /usr/lib/libiri.so
b3f56000 b3f76000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b3f77000 b3f7a000 r-xp /usr/lib/libuuid.so.1.3.0
b3f8a000 b3fa1000 r-xp /usr/lib/libblkid.so.1.1.0
b3fb2000 b3fdb000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b3fed000 b4034000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4045000 b404b000 r-xp /usr/lib/libjson-c.so.2.0.1
b405c000 b4060000 r-xp /usr/lib/libogg.so.0.7.1
b4070000 b4092000 r-xp /usr/lib/libvorbis.so.0.4.3
b40a2000 b4186000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b41a3000 b41ae000 r-xp /usr/lib/libgpg-error.so.0.15.0
b41be000 b41c1000 r-xp /usr/lib/libEGL.so.1.4
b41d1000 b41d7000 r-xp /usr/lib/libxcb-render.so.0.0.0
b41e7000 b41e9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b41f9000 b4206000 r-xp /usr/lib/libGLESv2.so.2.0
b4218000 b4230000 r-xp /usr/lib/libmount.so.1.1.0
b4241000 b4243000 r-xp /usr/lib/libXau.so.6.0.0
b4253000 b4289000 r-xp /usr/lib/libpulse.so.0.16.2
b429a000 b42dd000 r-xp /usr/lib/libsndfile.so.1.0.25
b42f3000 b436d000 r-xp /usr/lib/libgcrypt.so.20.0.3
b4382000 b4389000 r-xp /usr/lib/libsensord-share.so
b4399000 b43fb000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4410000 b4413000 r-xp /usr/lib/libXv.so.1.0.0
b4423000 b4428000 r-xp /usr/lib/libutilX.so.1.1.0
b4439000 b443e000 r-xp /usr/lib/libffi.so.6.0.2
b444e000 b445f000 r-xp /lib/libresolv-2.20-2014.11.so
b4473000 b4475000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b4485000 b4543000 r-xp /usr/lib/libcairo.so.2.11200.14
b4557000 b455f000 r-xp /usr/lib/libdrm.so.2.4.0
b456f000 b4572000 r-xp /usr/lib/libdri2.so.0.0.0
b4582000 b458e000 r-xp /usr/lib/libeeze.so.1.13.0
b459e000 b45a7000 r-xp /usr/lib/libethumb.so.1.13.0
b45b8000 b45cc000 r-xp /usr/lib/libxcb.so.1.1.0
b45dc000 b45de000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b45ee000 b45f5000 r-xp /usr/lib/libembryo.so.1.13.0
b4605000 b460f000 r-xp /usr/lib/libecore_audio.so.1.13.0
b4621000 b4636000 r-xp /lib/libexpat.so.1.5.2
b4648000 b464b000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b465b000 b4664000 r-xp /usr/lib/libXi.so.6.1.0
b4674000 b4676000 r-xp /usr/lib/libXgesture.so.7.0.0
b4686000 b468a000 r-xp /usr/lib/libXtst.so.6.1.0
b469a000 b46a0000 r-xp /usr/lib/libXrender.so.1.3.0
b46b1000 b46b7000 r-xp /usr/lib/libXrandr.so.2.2.0
b46c7000 b46c9000 r-xp /usr/lib/libXinerama.so.1.0.0
b46d9000 b46dc000 r-xp /usr/lib/libXfixes.so.3.1.0
b46ec000 b46f7000 r-xp /usr/lib/libXext.so.6.4.0
b4707000 b4709000 r-xp /usr/lib/libXdamage.so.1.1.0
b471a000 b471c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b472c000 b4733000 r-xp /usr/lib/libXcursor.so.1.0.2
b4743000 b475b000 r-xp /usr/lib/libudev.so.1.6.0
b475d000 b4799000 r-xp /usr/lib/libsystemd.so.0.4.0
b479b000 b47b3000 r-xp /usr/lib/libsensor.so.1.1.0
b47c5000 b47cc000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b47dc000 b47de000 r-xp /usr/lib/libappsvc.so.0.1.0
b47ee000 b47f1000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b4801000 b481a000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b482b000 b4862000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b4874000 b495f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b4972000 b4977000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b4987000 b4989000 r-xp /usr/lib/libvasum.so.0.3.1
b4999000 b499c000 r-xp /usr/lib/libiniparser.so.0
b49ac000 b49b0000 r-xp /usr/lib/libsmack.so.1.0.0
b49c0000 b49c5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b49d7000 b4a01000 r-xp /usr/lib/libdbus-1.so.3.8.12
b4a12000 b4a29000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4a3a000 b4a3d000 r-xp /usr/lib/libbundle.so.0.1.22
b580e000 b5826000 r-xp /usr/lib/libpng12.so.0.50.0
b5837000 b585a000 r-xp /usr/lib/libjpeg.so.8.0.2
b587b000 b588f000 r-xp /usr/lib/libector.so.1.13.0
b58a0000 b58b8000 r-xp /usr/lib/liblua-5.1.so
b58c9000 b5920000 r-xp /usr/lib/libfreetype.so.6.11.3
b5934000 b5947000 r-xp /usr/lib/libfribidi.so.0.3.1
b5958000 b5992000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b59a3000 b59b1000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b59c1000 b59c9000 r-xp /usr/lib/libtbm.so.1.0.0
b59d9000 b59e6000 r-xp /usr/lib/libeio.so.1.13.0
b59f6000 b59f8000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5a08000 b5a0d000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5a1d000 b5a34000 r-xp /usr/lib/libefreet.so.1.13.0
b5a46000 b5a66000 r-xp /usr/lib/libeldbus.so.1.13.0
b5a76000 b5a96000 r-xp /usr/lib/libecore_con.so.1.13.0
b5a98000 b5a9e000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5aae000 b5abf000 r-xp /usr/lib/libemotion.so.1.13.0
b5ad0000 b5ad7000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ae7000 b5af9000 r-xp /usr/lib/libecore_input.so.1.13.0
b5b0a000 b5b0f000 r-xp /usr/lib/libecore_file.so.1.13.0
b5b1f000 b5b3c000 r-xp /usr/lib/libeet.so.1.13.0
b5b55000 b5b65000 r-xp /usr/lib/libefl.so.1.13.0
b5b76000 b5b78000 r-xp /usr/lib/libttrace.so.1.1
b5b88000 b5c6a000 r-xp /usr/lib/libX11.so.6.3.0
b5c7d000 b5c8c000 r-xp /usr/lib/libeo.so.1.13.0
b5c9d000 b5d20000 r-xp /usr/lib/libedje.so.1.13.0
b5d33000 b5d51000 r-xp /usr/lib/libecore.so.1.13.0
b5d71000 b5d89000 r-xp /lib/libz.so.1.2.8
b5d99000 b5f50000 r-xp /usr/lib/libcrypto.so.1.0.0
b5f79000 b5fc7000 r-xp /usr/lib/libssl.so.1.0.0
b5fdc000 b600a000 r-xp /usr/lib/libidn.so.11.5.44
b601a000 b6030000 r-xp /usr/lib/libnghttp2.so.5.4.0
b6041000 b604b000 r-xp /usr/lib/libcares.so.2.1.0
b605b000 b6130000 r-xp /usr/lib/libxml2.so.2.9.2
b6145000 b616d000 r-xp /usr/lib/libfontconfig.so.1.8.0
b617e000 b6260000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6271000 b627b000 r-xp /usr/lib/libvconf.so.0.2.45
b628b000 b62a4000 r-xp /usr/lib/libecore_evas.so.1.13.0
b62b4000 b62ec000 r-xp /usr/lib/libecore_x.so.1.13.0
b62fe000 b6346000 r-xp /usr/lib/libeina.so.1.13.0
b6357000 b635c000 r-xp /usr/lib/libappcore-common.so.1.1
b636c000 b6371000 r-xp /usr/lib/libappcore-efl.so.1.1
b6381000 b6386000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6397000 b63bd000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b63cd000 b63e5000 r-xp /usr/lib/libaul.so.0.1.0
b63f7000 b6492000 r-xp /usr/lib/libstdc++.so.6.0.20
b64ae000 b6593000 r-xp /usr/lib/libicuuc.so.51.1
b65b0000 b66f0000 r-xp /usr/lib/libicui18n.so.51.1
b6707000 b670e000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6720000 b678b000 r-xp /lib/libm-2.20-2014.11.so
b679c000 b67a2000 r-xp /lib/librt-2.20-2014.11.so
b67b3000 b67b5000 r-xp /lib/libdl-2.20-2014.11.so
b67c6000 b67d3000 r-xp /usr/lib/libunwind.so.8.0.1
b6809000 b6822000 r-xp /lib/libgcc_s-4.9.so.1
b6832000 b6956000 r-xp /lib/libc-2.20-2014.11.so
b696b000 b69e4000 r-xp /usr/lib/libsqlite3.so.0.8.6
b69f6000 b6b7d000 r-xp /usr/lib/libevas.so.1.13.0
b6bb2000 b6de6000 r-xp /usr/lib/libelementary.so.1.13.0
b6e15000 b6e1c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6e2d000 b6e2f000 r-xp /usr/lib/libdlog.so.0.0.0
b6e3f000 b6e85000 r-xp /usr/lib/libcurl.so.4.3.0
b6e96000 b6e9e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6eae000 b6eb2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6ec3000 b6ec5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6ed6000 b6eeb000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b6efb000 b6f0f000 r-xp /lib/libpthread-2.20-2014.11.so
b6f3b000 b6f48000 r-xp /usr/lib/liblptcp.so
b6f5a000 b6f5e000 r-xp /usr/lib/libsys-assert.so
b6f6f000 b6f8f000 r-xp /lib/ld-2.20-2014.11.so
b6fa0000 b6fa8000 r-xp /opt/usr/apps/org.example.example/bin/example
b8513000 b8888000 rw-p [heap]
be8a2000 be8c3000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7473)
Call Stack Count: 17
 0: feeding_view_cb + 0x29 (0xb6fa39ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb6a2b175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5c88219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5c86fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a2b515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a33725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a38f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a3c939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb464a173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb5d3ec4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb5d44a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb5d44c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb636f2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb6eb0909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb6fa5673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: __libc_start_main + 0x114 (0xb68484bc) [/lib/libc.so.6] + 0x164bc
16: (0xb6fa2840) [/opt/usr/apps/org.example.example/bin/example] + 0x2840
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
essage-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
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
06-03 00:21:49.995+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11074456578611496416875
06-03 00:21:50.465+0900 W/LFE      (15849): [15849] 26:16:22.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:52.957+0900 W/LFE      (15849): [15849] 26:16:25.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:55.460+0900 W/LFE      (15849): [15849] 26:16:27.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:57.041+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11074446578611496416877
06-03 00:21:57.962+0900 W/LFE      (15849): [15849] 26:16:30.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:00.465+0900 W/LFE      (15849): [15849] 26:16:32.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:02.957+0900 W/LFE      (15849): [15849] 26:16:35.043[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:05.460+0900 W/LFE      (15849): [15849] 26:16:37.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:07.982+0900 W/LFE      (15849): [15849] 26:16:40.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:10.485+0900 W/LFE      (15849): [15849] 26:16:42.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:12.967+0900 W/LFE      (15849): [15849] 26:16:45.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:14.639+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:22:15.469+0900 W/LFE      (15849): [15849] 26:16:47.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:17.972+0900 W/LFE      (15849): [15849] 26:16:50.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:19.734+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 00:22:19.734+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 00:22:19.734+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 00:22:19.734+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 00:22:19.734+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:22:19.734+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 00:22:19.744+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:22:19.744+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:22
06-03 00:22:19.744+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:22"
06-03 00:22:19.744+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:22"
06-03 00:22:19.744+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:22:19.744+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145612168 Time: <font_size=31> </font_size> <font_size=31> 오전 12:22</font_size></font>"
06-03 00:22:19.744+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(7) / batt_Full:(0) / battery_charging(1)"
06-03 00:22:19.744+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 00:22:19.744+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:22:19.744+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:22:19.744+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:22:19.754+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:22:19.754+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:22:19.754+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:22:19.754+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:22:19.954+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 00:22:19.954+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 00:22:19.954+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 00:22:19.954+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 00:22:19.954+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:19.954+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 00:22:19.954+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 00:22:19.954+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:22:19.964+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:22:19.964+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:22:19.964+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:22:19.964+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:22:19.984+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:22:19.984+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7756
06-03 00:22:20.034+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7756
06-03 00:22:20.034+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7756, appid: com.samsung.weather-m-agent
06-03 00:22:20.034+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7756)
06-03 00:22:20.074+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:22:20.074+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7756.
06-03 00:22:20.254+0900 E/weather-agent( 7756): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:22:20.254+0900 E/weather-common( 7756): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:22:20.254+0900 E/weather-agent( 7756): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:22:20.254+0900 E/weather-agent( 7756): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:22:20.264+0900 E/weather-common( 7756): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:22:20.264+0900 E/weather-common( 7756): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:22:20.264+0900 E/weather-common( 7756): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:22:20.264+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:22:20.264+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:22:20.264+0900 I/MESSAGE_PORT( 7756): message-port.c: __initialize(872) > initialize
06-03 00:22:20.274+0900 I/MESSAGE_PORT( 7756): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:22:20.324+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:22:20.324+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:22:20.324+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:22:20.334+0900 E/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:22:20.334+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:22:20.334+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:20.334+0900 E/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:22:20.334+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:22:20.334+0900 I/MESSAGE_PORT( 7756): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:22:20.344+0900 E/MESSAGE_PORT( 7756): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:22:20.344+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:22:20.344+0900 E/weather-common( 7756): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:22:20.344+0900 E/weather-agent( 7756): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:22:20.344+0900 E/weather-agent( 7756): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:22:20.344+0900 I/MESSAGE_PORT( 7756): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:22:20.344+0900 I/MESSAGE_PORT( 7756): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:22:20.344+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:20.364+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:22:20.364+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:22:20.364+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:20.384+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:20.384+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:20.394+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:22:20.394+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:22:20.394+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:22:20.394+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:20.424+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:22:20.434+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:22:20.474+0900 W/LFE      (15849): [15849] 26:16:52.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:20.494+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:22:20.504+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:22:20.715+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127520716
06-03 00:22:20.855+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127520857
06-03 00:22:20.855+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:22:20.855+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:22:20.855+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:22:20.865+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:22:20.865+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:22:21.195+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:22:21.195+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:22:21.195+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:22:21.195+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:22:21.205+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:22:21.205+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:22:21.205+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:22:21.205+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:22:21.205+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:22:21.215+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:21.225+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:22:21.225+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:22:21.225+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:22:21.225+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:21.235+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7473) status(3)
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:22:21.235+0900 I/APP_CORE( 7473): appcore-efl.c: __do_app(514) > [APP 7473] Event: RESUME State: PAUSED
06-03 00:22:21.235+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:22:21.235+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:22:21.235+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:22:21.235+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:22:21.235+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:22:21.235+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:22:21.235+0900 I/CAPI_APPFW_APPLICATION( 7473): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:21.245+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:22:21.255+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:22:21.255+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:22:21.255+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7473)
06-03 00:22:21.255+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7473, appid: org.example.example, status: fg
06-03 00:22:21.285+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:22:21.285+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:22:21.285+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:21.295+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:21.315+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:21.345+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:22:21.345+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:22:21.345+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:22:21.345+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:22:21.345+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:22:21.345+0900 E/weather-agent( 7756): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:22:21.345+0900 I/CAPI_APPFW_APPLICATION( 7756): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:22:21.345+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:22:21.345+0900 E/weather-agent( 7756): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:22:21.345+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:22:21.345+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:22:21.395+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:22:21.475+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:22:21.485+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7756
06-03 00:22:21.485+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[7756] terminate event is forwarded
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7756, ]
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:22:21.485+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:22:21.485+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7756
06-03 00:22:21.485+0900 I/Tizen::App( 1210): (512) > Not registered pid(7756)
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:22:21.485+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:21.485+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:21.485+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7756.
06-03 00:22:21.686+0900 E/EFL     ( 7473): ecore_x<7473> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127521682
06-03 00:22:21.816+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107473657861149641694
