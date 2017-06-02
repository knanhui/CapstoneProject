S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 8511
Date: 2017-06-03 01:04:19+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8511, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f3f000, r3   = 0xb3f3f020
r4   = 0x8001b2da, r5   = 0xbebb02a0
r6   = 0xb28289a5, r7   = 0xbebb0128
r8   = 0x8001b2da, r9   = 0xb5f21708
r10  = 0xb787aa30, fp   = 0xbebb027c
ip   = 0xb6011120, sp   = 0xbebb00e8
lr   = 0xb5fd5bd9, pc   = 0xb28289ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     36320 KB
Buffers:     13856 KB
Cached:     109924 KB
VmPeak:     110064 KB
VmSize:     108572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24116 KB
VmRSS:       24116 KB
VmData:      34504 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8511 TID = 8511
8511 8512 8562 8563 

Maps Information
b1323000 b1b22000 rw-p [stack:8563]
b1b9e000 b1ba6000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bb7000 b1bb8000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bc8000 b1bdc000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bf0000 b1bf1000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c01000 b1c04000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c15000 b1c16000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c26000 b1c28000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c38000 b1c3a000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c4a000 b1c5a000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c6a000 b1c76000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c88000 b2487000 rw-p [stack:8562]
b27b8000 b27bf000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27d0000 b27d8000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27e8000 b27fd000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b280f000 b2815000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2825000 b282d000 r-xp /opt/usr/apps/org.example.example/bin/example
b2985000 b2a68000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a9f000 b2ac7000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ad9000 b32d8000 rw-p [stack:8512]
b32d8000 b32da000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32ea000 b32f4000 r-xp /lib/libnss_files-2.20-2014.11.so
b3305000 b330e000 r-xp /lib/libnss_nis-2.20-2014.11.so
b331f000 b3330000 r-xp /lib/libnsl-2.20-2014.11.so
b3343000 b3349000 r-xp /lib/libnss_compat-2.20-2014.11.so
b335a000 b335b000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3383000 b338a000 r-xp /usr/lib/libminizip.so.1.0.0
b339a000 b339f000 r-xp /usr/lib/libstorage.so.0.1
b33af000 b340e000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3424000 b3438000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3448000 b348c000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b349c000 b34a4000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34b4000 b34e4000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34f7000 b35b0000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35c4000 b3617000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3628000 b3643000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3653000 b3714000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3727000 b3737000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3747000 b3754000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3765000 b376c000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b377c000 b37bd000 r-xp /usr/lib/libmdm.so.1.2.12
b37cd000 b37d5000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37e4000 b37f4000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3815000 b3875000 r-xp /usr/lib/libasound.so.2.0.0
b3887000 b388a000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b389a000 b389d000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38ad000 b38b2000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38c2000 b38c3000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38d3000 b38de000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38f2000 b38f9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3909000 b390f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b391f000 b3924000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3934000 b394f000 r-xp /usr/lib/libmmfsound.so.0.1.0
b395f000 b3966000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3976000 b3979000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b398a000 b39b8000 r-xp /usr/lib/libidn.so.11.5.44
b39c8000 b39de000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39ef000 b39f9000 r-xp /usr/lib/libcares.so.2.1.0
b3a09000 b3a13000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a23000 b3a25000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a35000 b3a36000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a46000 b3a4a000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a5b000 b3a83000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a94000 b3abd000 r-xp /usr/lib/libturbojpeg.so
b3add000 b3ae3000 r-xp /usr/lib/libgif.so.4.1.6
b3af3000 b3b39000 r-xp /usr/lib/libcurl.so.4.3.0
b3b4a000 b3b6b000 r-xp /usr/lib/libexif.so.12.3.3
b3b86000 b3b9b000 r-xp /usr/lib/libtts.so
b3bac000 b3bb4000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bc4000 b3c8a000 r-xp /usr/lib/libdali-core.so.0.0.0
b3caa000 b3da2000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dc1000 b3e8f000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ea6000 b3ea8000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eb8000 b3ebe000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ece000 b3ef1000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f02000 b3f04000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f14000 b3f16000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f27000 b3f2c000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f43000 b3f45000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f55000 b3f5c000 r-xp /usr/lib/libsensord-share.so
b3f6c000 b3f84000 r-xp /usr/lib/libsensor.so.1.1.0
b3f95000 b3f98000 r-xp /usr/lib/libXv.so.1.0.0
b3fa8000 b3fad000 r-xp /usr/lib/libutilX.so.1.1.0
b3fbd000 b3fc2000 r-xp /usr/lib/libappcore-common.so.1.1
b3fd2000 b3fd9000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fec000 b3ff0000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4001000 b40df000 r-xp /usr/lib/libCOREGL.so.4.0
b40ff000 b4102000 r-xp /usr/lib/libuuid.so.1.3.0
b4112000 b4129000 r-xp /usr/lib/libblkid.so.1.1.0
b413a000 b413c000 r-xp /usr/lib/libXau.so.6.0.0
b414c000 b4193000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41a5000 b41ab000 r-xp /usr/lib/libjson-c.so.2.0.1
b41bc000 b41c0000 r-xp /usr/lib/libogg.so.0.7.1
b41d0000 b41f2000 r-xp /usr/lib/libvorbis.so.0.4.3
b4202000 b42e6000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4302000 b4305000 r-xp /usr/lib/libEGL.so.1.4
b4316000 b431c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b432c000 b432e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b433e000 b434b000 r-xp /usr/lib/libGLESv2.so.2.0
b435c000 b43be000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43d3000 b43eb000 r-xp /usr/lib/libmount.so.1.1.0
b43fd000 b4411000 r-xp /usr/lib/libxcb.so.1.1.0
b4421000 b4428000 r-xp /lib/libcrypt-2.20-2014.11.so
b4460000 b4462000 r-xp /usr/lib/libiri.so
b4472000 b447d000 r-xp /usr/lib/libgpg-error.so.0.15.0
b448e000 b44c4000 r-xp /usr/lib/libpulse.so.0.16.2
b44d5000 b4518000 r-xp /usr/lib/libsndfile.so.1.0.25
b452d000 b4542000 r-xp /lib/libexpat.so.1.5.2
b4554000 b4612000 r-xp /usr/lib/libcairo.so.2.11200.14
b4626000 b462e000 r-xp /usr/lib/libdrm.so.2.4.0
b463e000 b4641000 r-xp /usr/lib/libdri2.so.0.0.0
b4651000 b469f000 r-xp /usr/lib/libssl.so.1.0.0
b46b4000 b46c0000 r-xp /usr/lib/libeeze.so.1.13.0
b46d1000 b46da000 r-xp /usr/lib/libethumb.so.1.13.0
b46ea000 b46ed000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46fd000 b48b4000 r-xp /usr/lib/libcrypto.so.1.0.0
b569f000 b56a8000 r-xp /usr/lib/libXi.so.6.1.0
b56b8000 b56ba000 r-xp /usr/lib/libXgesture.so.7.0.0
b56ca000 b56ce000 r-xp /usr/lib/libXtst.so.6.1.0
b56de000 b56e4000 r-xp /usr/lib/libXrender.so.1.3.0
b56f4000 b56fa000 r-xp /usr/lib/libXrandr.so.2.2.0
b570a000 b570c000 r-xp /usr/lib/libXinerama.so.1.0.0
b571d000 b5720000 r-xp /usr/lib/libXfixes.so.3.1.0
b5730000 b573b000 r-xp /usr/lib/libXext.so.6.4.0
b574b000 b574d000 r-xp /usr/lib/libXdamage.so.1.1.0
b575d000 b575f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b576f000 b5851000 r-xp /usr/lib/libX11.so.6.3.0
b5865000 b586c000 r-xp /usr/lib/libXcursor.so.1.0.2
b587c000 b5894000 r-xp /usr/lib/libudev.so.1.6.0
b5896000 b5899000 r-xp /lib/libattr.so.1.1.0
b58a9000 b58c9000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58ca000 b58cf000 r-xp /usr/lib/libffi.so.6.0.2
b58e0000 b58f8000 r-xp /lib/libz.so.1.2.8
b5908000 b590a000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b591a000 b59ef000 r-xp /usr/lib/libxml2.so.2.9.2
b5a04000 b5a9f000 r-xp /usr/lib/libstdc++.so.6.0.20
b5abb000 b5abe000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ace000 b5ae7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5af8000 b5b09000 r-xp /lib/libresolv-2.20-2014.11.so
b5b1d000 b5b97000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bac000 b5bae000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bbe000 b5bc5000 r-xp /usr/lib/libembryo.so.1.13.0
b5bd5000 b5bdf000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bf0000 b5c08000 r-xp /usr/lib/libpng12.so.0.50.0
b5c19000 b5c3c000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c5d000 b5c71000 r-xp /usr/lib/libector.so.1.13.0
b5c82000 b5c9a000 r-xp /usr/lib/liblua-5.1.so
b5cab000 b5d02000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d16000 b5d3e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d4f000 b5d62000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d73000 b5dad000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dbe000 b5dcc000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5ddc000 b5de4000 r-xp /usr/lib/libtbm.so.1.0.0
b5df4000 b5e01000 r-xp /usr/lib/libeio.so.1.13.0
b5e11000 b5e13000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e23000 b5e28000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e38000 b5e4f000 r-xp /usr/lib/libefreet.so.1.13.0
b5e61000 b5e81000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e91000 b5eb1000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eb3000 b5eb9000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ec9000 b5eda000 r-xp /usr/lib/libemotion.so.1.13.0
b5eeb000 b5ef2000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f02000 b5f11000 r-xp /usr/lib/libeo.so.1.13.0
b5f22000 b5f34000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f45000 b5f4a000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f5a000 b5f73000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f83000 b5fa0000 r-xp /usr/lib/libeet.so.1.13.0
b5fb9000 b6001000 r-xp /usr/lib/libeina.so.1.13.0
b6012000 b6022000 r-xp /usr/lib/libefl.so.1.13.0
b6033000 b6118000 r-xp /usr/lib/libicuuc.so.51.1
b6135000 b6275000 r-xp /usr/lib/libicui18n.so.51.1
b628c000 b62c4000 r-xp /usr/lib/libecore_x.so.1.13.0
b62d6000 b62d9000 r-xp /lib/libcap.so.2.21
b62e9000 b6312000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6323000 b632a000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b633c000 b6373000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6384000 b646f000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6482000 b64fb000 r-xp /usr/lib/libsqlite3.so.0.8.6
b650d000 b6512000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6522000 b652c000 r-xp /usr/lib/libvconf.so.0.2.45
b653c000 b653e000 r-xp /usr/lib/libvasum.so.0.3.1
b654e000 b6550000 r-xp /usr/lib/libttrace.so.1.1
b6560000 b6563000 r-xp /usr/lib/libiniparser.so.0
b6573000 b6599000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65a9000 b65ae000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65bf000 b65d6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65e7000 b6652000 r-xp /lib/libm-2.20-2014.11.so
b6663000 b6669000 r-xp /lib/librt-2.20-2014.11.so
b667a000 b6687000 r-xp /usr/lib/libunwind.so.8.0.1
b66bd000 b67e1000 r-xp /lib/libc-2.20-2014.11.so
b67f6000 b680f000 r-xp /lib/libgcc_s-4.9.so.1
b681f000 b6901000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6912000 b693c000 r-xp /usr/lib/libdbus-1.so.3.8.12
b694d000 b6989000 r-xp /usr/lib/libsystemd.so.0.4.0
b698b000 b6a0e000 r-xp /usr/lib/libedje.so.1.13.0
b6a21000 b6a3f000 r-xp /usr/lib/libecore.so.1.13.0
b6a5f000 b6be6000 r-xp /usr/lib/libevas.so.1.13.0
b6c1b000 b6c2f000 r-xp /lib/libpthread-2.20-2014.11.so
b6c43000 b6e77000 r-xp /usr/lib/libelementary.so.1.13.0
b6ea6000 b6eaa000 r-xp /usr/lib/libsmack.so.1.0.0
b6eba000 b6ec1000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ed1000 b6ed3000 r-xp /usr/lib/libdlog.so.0.0.0
b6ee3000 b6ee6000 r-xp /usr/lib/libbundle.so.0.1.22
b6ef6000 b6ef8000 r-xp /lib/libdl-2.20-2014.11.so
b6f09000 b6f21000 r-xp /usr/lib/libaul.so.0.1.0
b6f35000 b6f3a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f4b000 b6f58000 r-xp /usr/lib/liblptcp.so
b6f6a000 b6f6e000 r-xp /usr/lib/libsys-assert.so
b6f7f000 b6f9f000 r-xp /lib/ld-2.20-2014.11.so
b6fb0000 b6fb5000 r-xp /usr/bin/launchpad-loader
b7610000 b78c9000 rw-p [heap]
beb90000 bebb1000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8511)
Call Stack Count: 18
 0: feeding_view_cb + 0x29 (0xb28289ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb6a94175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f0d219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f0bfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a94515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a9c725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6aa1f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6aa5939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46ec173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a2cc4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a32a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a32c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f382bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3fee909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb282a673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6fb1bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66d34bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fb1eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
ET SHOW EVENT!!!. WIN:a200002
06-03 01:04:18.881+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:04:18.991+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 01:04:18.991+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:04:18.991+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 01:04:19.001+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 01:04:19.001+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 01:04:19.001+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
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
06-03 01:04:26.078+0900 W/CRASH_MANAGER( 8545): worker.c: worker_job(1199) > 1108511657861149641945
