S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7288
Date: 2017-06-03 00:21:00+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7288, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f6c000, r3   = 0xb3f6c020
r4   = 0x8001b6dc, r5   = 0xbec822a0
r6   = 0xb2857e5d, r7   = 0xbec82128
r8   = 0x8001b6dc, r9   = 0xb5f4e708
r10  = 0xb8717f38, fp   = 0xbec8227c
ip   = 0xb603e120, sp   = 0xbec820e8
lr   = 0xb6002bd9, pc   = 0xb2857e86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     40284 KB
Buffers:     15644 KB
Cached:     116984 KB
VmPeak:     115576 KB
VmSize:     114972 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       27124 KB
VmRSS:       26976 KB
VmData:      37192 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7288 TID = 7288
7288 7289 7303 7304 

Maps Information
b1350000 b1b4f000 rw-p [stack:7304]
b1bcb000 b1bd3000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1be4000 b1be5000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bf5000 b1c09000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c1d000 b1c1e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c2e000 b1c31000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c42000 b1c43000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c53000 b1c55000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c65000 b1c67000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c77000 b1c87000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c97000 b1ca3000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cb5000 b24b4000 rw-p [stack:7303]
b27e5000 b27ec000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27fd000 b2805000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2815000 b282a000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b283c000 b2842000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2852000 b285a000 r-xp /opt/usr/apps/org.example.example/bin/example
b29b2000 b2a95000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2acc000 b2af4000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b06000 b3305000 rw-p [stack:7289]
b3305000 b3307000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3317000 b3321000 r-xp /lib/libnss_files-2.20-2014.11.so
b3332000 b333b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b334c000 b335d000 r-xp /lib/libnsl-2.20-2014.11.so
b3370000 b3376000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3387000 b3388000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33b0000 b33b7000 r-xp /usr/lib/libminizip.so.1.0.0
b33c7000 b33cc000 r-xp /usr/lib/libstorage.so.0.1
b33dc000 b343b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3451000 b3465000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3475000 b34b9000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34c9000 b34d1000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34e1000 b3511000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3524000 b35dd000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35f1000 b3644000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3655000 b3670000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3680000 b3741000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3754000 b3764000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3774000 b3781000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3792000 b3799000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37a9000 b37ea000 r-xp /usr/lib/libmdm.so.1.2.12
b37fa000 b3802000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3811000 b3821000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3842000 b38a2000 r-xp /usr/lib/libasound.so.2.0.0
b38b4000 b38b7000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38c7000 b38ca000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38da000 b38df000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38ef000 b38f0000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3900000 b390b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b391f000 b3926000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3936000 b393c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b394c000 b3951000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3961000 b397c000 r-xp /usr/lib/libmmfsound.so.0.1.0
b398c000 b3993000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39a3000 b39a6000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39b7000 b39e5000 r-xp /usr/lib/libidn.so.11.5.44
b39f5000 b3a0b000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a1c000 b3a26000 r-xp /usr/lib/libcares.so.2.1.0
b3a36000 b3a40000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a50000 b3a52000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a62000 b3a63000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a73000 b3a77000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a88000 b3ab0000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ac1000 b3aea000 r-xp /usr/lib/libturbojpeg.so
b3b0a000 b3b10000 r-xp /usr/lib/libgif.so.4.1.6
b3b20000 b3b66000 r-xp /usr/lib/libcurl.so.4.3.0
b3b77000 b3b98000 r-xp /usr/lib/libexif.so.12.3.3
b3bb3000 b3bc8000 r-xp /usr/lib/libtts.so
b3bd9000 b3be1000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bf1000 b3cb7000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cd7000 b3dcf000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dee000 b3ebc000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ed3000 b3ed5000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ee5000 b3eeb000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3efb000 b3f1e000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f2f000 b3f31000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f41000 b3f43000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f54000 b3f59000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f70000 b3f72000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f82000 b3f89000 r-xp /usr/lib/libsensord-share.so
b3f99000 b3fb1000 r-xp /usr/lib/libsensor.so.1.1.0
b3fc2000 b3fc5000 r-xp /usr/lib/libXv.so.1.0.0
b3fd5000 b3fda000 r-xp /usr/lib/libutilX.so.1.1.0
b3fea000 b3fef000 r-xp /usr/lib/libappcore-common.so.1.1
b3fff000 b4006000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4019000 b401d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b402e000 b410c000 r-xp /usr/lib/libCOREGL.so.4.0
b412c000 b412f000 r-xp /usr/lib/libuuid.so.1.3.0
b413f000 b4156000 r-xp /usr/lib/libblkid.so.1.1.0
b4167000 b4169000 r-xp /usr/lib/libXau.so.6.0.0
b4179000 b41c0000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41d2000 b41d8000 r-xp /usr/lib/libjson-c.so.2.0.1
b41e9000 b41ed000 r-xp /usr/lib/libogg.so.0.7.1
b41fd000 b421f000 r-xp /usr/lib/libvorbis.so.0.4.3
b422f000 b4313000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b432f000 b4332000 r-xp /usr/lib/libEGL.so.1.4
b4343000 b4349000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4359000 b435b000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b436b000 b4378000 r-xp /usr/lib/libGLESv2.so.2.0
b4389000 b43eb000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4400000 b4418000 r-xp /usr/lib/libmount.so.1.1.0
b442a000 b443e000 r-xp /usr/lib/libxcb.so.1.1.0
b444e000 b4455000 r-xp /lib/libcrypt-2.20-2014.11.so
b448d000 b448f000 r-xp /usr/lib/libiri.so
b449f000 b44aa000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44bb000 b44f1000 r-xp /usr/lib/libpulse.so.0.16.2
b4502000 b4545000 r-xp /usr/lib/libsndfile.so.1.0.25
b455a000 b456f000 r-xp /lib/libexpat.so.1.5.2
b4581000 b463f000 r-xp /usr/lib/libcairo.so.2.11200.14
b4653000 b465b000 r-xp /usr/lib/libdrm.so.2.4.0
b466b000 b466e000 r-xp /usr/lib/libdri2.so.0.0.0
b467e000 b46cc000 r-xp /usr/lib/libssl.so.1.0.0
b46e1000 b46ed000 r-xp /usr/lib/libeeze.so.1.13.0
b46fe000 b4707000 r-xp /usr/lib/libethumb.so.1.13.0
b4717000 b471a000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b472a000 b48e1000 r-xp /usr/lib/libcrypto.so.1.0.0
b56cc000 b56d5000 r-xp /usr/lib/libXi.so.6.1.0
b56e5000 b56e7000 r-xp /usr/lib/libXgesture.so.7.0.0
b56f7000 b56fb000 r-xp /usr/lib/libXtst.so.6.1.0
b570b000 b5711000 r-xp /usr/lib/libXrender.so.1.3.0
b5721000 b5727000 r-xp /usr/lib/libXrandr.so.2.2.0
b5737000 b5739000 r-xp /usr/lib/libXinerama.so.1.0.0
b574a000 b574d000 r-xp /usr/lib/libXfixes.so.3.1.0
b575d000 b5768000 r-xp /usr/lib/libXext.so.6.4.0
b5778000 b577a000 r-xp /usr/lib/libXdamage.so.1.1.0
b578a000 b578c000 r-xp /usr/lib/libXcomposite.so.1.0.0
b579c000 b587e000 r-xp /usr/lib/libX11.so.6.3.0
b5892000 b5899000 r-xp /usr/lib/libXcursor.so.1.0.2
b58a9000 b58c1000 r-xp /usr/lib/libudev.so.1.6.0
b58c3000 b58c6000 r-xp /lib/libattr.so.1.1.0
b58d6000 b58f6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58f7000 b58fc000 r-xp /usr/lib/libffi.so.6.0.2
b590d000 b5925000 r-xp /lib/libz.so.1.2.8
b5935000 b5937000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5947000 b5a1c000 r-xp /usr/lib/libxml2.so.2.9.2
b5a31000 b5acc000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ae8000 b5aeb000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5afb000 b5b14000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b25000 b5b36000 r-xp /lib/libresolv-2.20-2014.11.so
b5b4a000 b5bc4000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bd9000 b5bdb000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5beb000 b5bf2000 r-xp /usr/lib/libembryo.so.1.13.0
b5c02000 b5c0c000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c1d000 b5c35000 r-xp /usr/lib/libpng12.so.0.50.0
b5c46000 b5c69000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c8a000 b5c9e000 r-xp /usr/lib/libector.so.1.13.0
b5caf000 b5cc7000 r-xp /usr/lib/liblua-5.1.so
b5cd8000 b5d2f000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d43000 b5d6b000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d7c000 b5d8f000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da0000 b5dda000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5deb000 b5df9000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e09000 b5e11000 r-xp /usr/lib/libtbm.so.1.0.0
b5e21000 b5e2e000 r-xp /usr/lib/libeio.so.1.13.0
b5e3e000 b5e40000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e50000 b5e55000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e65000 b5e7c000 r-xp /usr/lib/libefreet.so.1.13.0
b5e8e000 b5eae000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ebe000 b5ede000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee0000 b5ee6000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ef6000 b5f07000 r-xp /usr/lib/libemotion.so.1.13.0
b5f18000 b5f1f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f2f000 b5f3e000 r-xp /usr/lib/libeo.so.1.13.0
b5f4f000 b5f61000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f72000 b5f77000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f87000 b5fa0000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb0000 b5fcd000 r-xp /usr/lib/libeet.so.1.13.0
b5fe6000 b602e000 r-xp /usr/lib/libeina.so.1.13.0
b603f000 b604f000 r-xp /usr/lib/libefl.so.1.13.0
b6060000 b6145000 r-xp /usr/lib/libicuuc.so.51.1
b6162000 b62a2000 r-xp /usr/lib/libicui18n.so.51.1
b62b9000 b62f1000 r-xp /usr/lib/libecore_x.so.1.13.0
b6303000 b6306000 r-xp /lib/libcap.so.2.21
b6316000 b633f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6350000 b6357000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6369000 b63a0000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63b1000 b649c000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64af000 b6528000 r-xp /usr/lib/libsqlite3.so.0.8.6
b653a000 b653f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b654f000 b6559000 r-xp /usr/lib/libvconf.so.0.2.45
b6569000 b656b000 r-xp /usr/lib/libvasum.so.0.3.1
b657b000 b657d000 r-xp /usr/lib/libttrace.so.1.1
b658d000 b6590000 r-xp /usr/lib/libiniparser.so.0
b65a0000 b65c6000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65d6000 b65db000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65ec000 b6603000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6614000 b667f000 r-xp /lib/libm-2.20-2014.11.so
b6690000 b6696000 r-xp /lib/librt-2.20-2014.11.so
b66a7000 b66b4000 r-xp /usr/lib/libunwind.so.8.0.1
b66ea000 b680e000 r-xp /lib/libc-2.20-2014.11.so
b6823000 b683c000 r-xp /lib/libgcc_s-4.9.so.1
b684c000 b692e000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b693f000 b6969000 r-xp /usr/lib/libdbus-1.so.3.8.12
b697a000 b69b6000 r-xp /usr/lib/libsystemd.so.0.4.0
b69b8000 b6a3b000 r-xp /usr/lib/libedje.so.1.13.0
b6a4e000 b6a6c000 r-xp /usr/lib/libecore.so.1.13.0
b6a8c000 b6c13000 r-xp /usr/lib/libevas.so.1.13.0
b6c48000 b6c5c000 r-xp /lib/libpthread-2.20-2014.11.so
b6c70000 b6ea4000 r-xp /usr/lib/libelementary.so.1.13.0
b6ed3000 b6ed7000 r-xp /usr/lib/libsmack.so.1.0.0
b6ee7000 b6eee000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6efe000 b6f00000 r-xp /usr/lib/libdlog.so.0.0.0
b6f10000 b6f13000 r-xp /usr/lib/libbundle.so.0.1.22
b6f23000 b6f25000 r-xp /lib/libdl-2.20-2014.11.so
b6f36000 b6f4e000 r-xp /usr/lib/libaul.so.0.1.0
b6f62000 b6f67000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f78000 b6f85000 r-xp /usr/lib/liblptcp.so
b6f97000 b6f9b000 r-xp /usr/lib/libsys-assert.so
b6fac000 b6fcc000 r-xp /lib/ld-2.20-2014.11.so
b6fdd000 b6fe2000 r-xp /usr/bin/launchpad-loader
b84ad000 b8766000 rw-p [heap]
bec62000 bec83000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7288)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb2857e86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6ac1175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f3a219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f38fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6ac1515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6ac9725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6acef6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6ad2939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb4719173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a59c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a5fa5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a5fc83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f652bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb401b909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2857673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6fdebb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb67004bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fdeeb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
rop_busname(324) > Does not exist in busname hash: :1.3220
06-03 00:21:00.426+0900 E/EFL     ( 7288): ecore_x<7288> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127440422
06-03 00:21:00.476+0900 W/LFE      (15849): [15849] 26:15:32.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:00.616+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7288 pgid = 7288
06-03 00:21:00.616+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7288)
06-03 00:21:00.616+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:00.636+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:21:00.636+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:00.636+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:00.636+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:21:00.636+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:21:00.687+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:21:00.687+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:21:00.687+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:21:00.697+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7288] terminate event is forwarded
06-03 00:21:00.697+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:00.697+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7288, ]
06-03 00:21:00.697+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:00.697+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:21:00.697+0900 I/Tizen::App( 1210): (512) > Not registered pid(7288)
06-03 00:21:00.697+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:21:00.697+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:00.697+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7288
06-03 00:21:00.697+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7288
06-03 00:21:00.697+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7288
06-03 00:21:00.707+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:21:00.707+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:00.707+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:21:00.707+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:00.707+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3221
06-03 00:21:00.717+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:21:00.727+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:00.727+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:21:00.737+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:00.737+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7288.
06-03 00:21:00.757+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:00.757+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:00.767+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:21:00.787+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:00.807+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:00.807+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:00.807+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:00.807+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:00.807+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:00.827+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:00.837+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:00.847+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:21:00.847+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:21:00.847+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:21:00.847+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:21:00.937+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:00.947+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:01.637+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127441640
06-03 00:21:01.697+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127441705
06-03 00:21:01.707+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:21:01.707+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:21:01.707+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:21:01.728+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:21:01.728+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:01.738+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:21:01.738+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(534) > Candidate is not prepared, enter legacy logic
06-03 00:21:01.738+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:21:01.738+0900 E/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(273) > launching failed
06-03 00:21:01.738+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3063) > Launch with legacy way : no launchpad
06-03 00:21:01.738+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7315
06-03 00:21:01.788+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7315
06-03 00:21:01.788+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7315, appid: org.example.example
06-03 00:21:01.788+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:21:01.808+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7315)
06-03 00:21:01.818+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:01.818+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7315.
06-03 00:21:01.938+0900 I/CAPI_APPFW_APPLICATION( 7315): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:21:01.948+0900 I/UXT     ( 7306): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:21:02.288+0900 I/CAPI_APPFW_APPLICATION( 7315): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:21:02.358+0900 E/TBM     ( 7315): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:21:02.358+0900 I/MALI    ( 7315): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=7315   open drm_fd=84 
06-03 00:21:02.658+0900 I/APP_CORE( 7315): appcore-efl.c: __do_app(514) > [APP 7315] Event: RESET State: CREATED
06-03 00:21:02.658+0900 I/CAPI_APPFW_APPLICATION( 7315): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:21:02.658+0900 E/EFL     ( 7315): edje<7315> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:02.658+0900 E/EFL     ( 7315): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:02.658+0900 E/EFL     ( 7315): edje<7315> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:02.658+0900 E/EFL     ( 7315): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:02.658+0900 E/EFL     ( 7315): edje<7315> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:02.658+0900 E/EFL     ( 7315): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:02.658+0900 E/EFL     ( 7315): edje<7315> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:02.658+0900 E/EFL     ( 7315): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:02.668+0900 E/EFL     ( 7315): edje<7315> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:02.668+0900 E/EFL     ( 7315): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:02.698+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:02.698+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:02.728+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:02.749+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:02.749+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:02.749+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:02.759+0900 W/APP_CORE( 7315): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00003
06-03 00:21:02.769+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:02.779+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:02.779+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:02.779+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:02.779+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:02.779+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:02.779+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:02.789+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7315) status(3)
06-03 00:21:02.789+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7315)
06-03 00:21:02.789+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7315, appid: org.example.example, status: fg
06-03 00:21:02.799+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:02.799+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:02.799+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:02.799+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:02.839+0900 I/APP_CORE( 7315): appcore-efl.c: __do_app(514) > [APP 7315] Event: RESUME State: CREATED
06-03 00:21:02.859+0900 I/APP_CORE( 7315): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:02.859+0900 I/APP_CORE( 7315): appcore-efl.c: __do_app(625) > [APP 7315] Initial Launching, call the resume_cb
06-03 00:21:02.859+0900 I/CAPI_APPFW_APPLICATION( 7315): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:02.979+0900 W/LFE      (15849): [15849] 26:15:35.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:03.149+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7315) status(0)
06-03 00:21:03.559+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11071536578611496416857
06-03 00:21:03.569+0900 E/EFL     ( 7315): ecore_x<7315> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127443571
06-03 00:21:03.699+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:21:03.699+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:03.709+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7315] terminate event is forwarded
06-03 00:21:03.709+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:03.709+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7315, ]
06-03 00:21:03.709+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:03.709+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:21:03.709+0900 I/Tizen::App( 1210): (512) > Not registered pid(7315)
06-03 00:21:03.709+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:21:03.709+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:03.709+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7315
06-03 00:21:03.709+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7315
06-03 00:21:03.709+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7315
06-03 00:21:03.719+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:21:03.719+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:03.719+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:03.719+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:21:03.719+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:21:03.719+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:21:03.729+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:03.729+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7315.
06-03 00:21:03.749+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:21:03.790+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:21:03.790+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:03.790+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:21:03.790+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:03.800+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:03.800+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:21:03.810+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:03.810+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:03.810+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:03.810+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:03.810+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:03.820+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:03.820+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:03.820+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:03.820+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:03.830+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:03.830+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:21:03.830+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:21:03.830+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:21:03.830+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:21:03.930+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:03.940+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:03.980+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:21:05.461+0900 W/LFE      (15849): [15849] 26:15:37.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:05.882+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127445880
06-03 00:21:06.002+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127445999
06-03 00:21:06.002+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:21:06.002+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:21:06.002+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:21:06.012+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:21:06.012+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:06.012+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:21:06.022+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:21:06.022+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:21:06.032+0900 I/CAPI_APPFW_APPLICATION( 7306): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:21:06.032+0900 I/CAPI_APPFW_APPLICATION( 7306): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:21:06.062+0900 E/TBM     ( 7306): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:21:06.122+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7306, appid: org.example.example
06-03 00:21:06.122+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:21:06.132+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7306)
06-03 00:21:06.222+0900 I/APP_CORE( 7306): appcore-efl.c: __do_app(514) > [APP 7306] Event: RESET State: CREATED
06-03 00:21:06.222+0900 I/CAPI_APPFW_APPLICATION( 7306): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:21:06.222+0900 E/EFL     ( 7306): edje<7306> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:06.222+0900 E/EFL     ( 7306): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:06.232+0900 E/EFL     ( 7306): edje<7306> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:06.232+0900 E/EFL     ( 7306): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:06.232+0900 E/EFL     ( 7306): edje<7306> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:06.232+0900 E/EFL     ( 7306): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:06.232+0900 E/EFL     ( 7306): edje<7306> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:06.232+0900 E/EFL     ( 7306): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:06.232+0900 E/EFL     ( 7306): edje<7306> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:06.232+0900 E/EFL     ( 7306): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:06.262+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:06.262+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:06.292+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:06.292+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:06.302+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:06.312+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:06.312+0900 W/APP_CORE( 7306): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:21:06.322+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:06.412+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:06.412+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:06.422+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:06.422+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:06.422+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:06.422+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:06.422+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7306) status(3)
06-03 00:21:06.422+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7306)
06-03 00:21:06.422+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7306, appid: org.example.example, status: fg
06-03 00:21:06.432+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:06.432+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:06.432+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:06.432+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:06.462+0900 I/APP_CORE( 7306): appcore-efl.c: __do_app(514) > [APP 7306] Event: RESUME State: CREATED
06-03 00:21:06.472+0900 I/APP_CORE( 7306): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:06.472+0900 I/APP_CORE( 7306): appcore-efl.c: __do_app(625) > [APP 7306] Initial Launching, call the resume_cb
06-03 00:21:06.472+0900 I/CAPI_APPFW_APPLICATION( 7306): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:06.782+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7306) status(0)
06-03 00:21:07.163+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:07.163+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7306.
06-03 00:21:07.934+0900 I/UXT     ( 7371): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:21:07.974+0900 W/LFE      (15849): [15849] 26:15:40.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:08.144+0900 E/EFL     ( 7306): ecore_x<7306> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127448147
06-03 00:21:08.314+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7306 pgid = 7306
06-03 00:21:08.314+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7306)
06-03 00:21:08.314+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:08.374+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:21:08.374+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:21:08.374+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:21:08.374+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7306
06-03 00:21:08.374+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7306] terminate event is forwarded
06-03 00:21:08.374+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:08.374+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7306, ]
06-03 00:21:08.374+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:08.374+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:21:08.374+0900 I/Tizen::App( 1210): (512) > Not registered pid(7306)
06-03 00:21:08.374+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:21:08.374+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:08.374+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7306
06-03 00:21:08.374+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7306
06-03 00:21:08.384+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3228
06-03 00:21:08.384+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:21:08.384+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:08.384+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:08.384+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:21:08.384+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:21:08.394+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:21:08.394+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:21:08.394+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:21:08.394+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:08.394+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:21:08.394+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:08.404+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:08.404+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7306.
06-03 00:21:08.424+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:08.424+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:08.424+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:08.434+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:21:08.454+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:08.454+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:08.454+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:08.454+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:08.454+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:08.474+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:08.484+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:08.484+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:21:08.484+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:21:08.484+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:21:08.484+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:21:08.484+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:21:08.484+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:08.494+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:21:08.494+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:08.494+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:08.614+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:08.624+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:09.075+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127449069
06-03 00:21:09.145+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127449146
06-03 00:21:09.155+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:21:09.155+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:21:09.155+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:21:09.175+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:21:09.175+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:21:09.175+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:21:09.185+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:21:09.185+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:21:09.205+0900 I/CAPI_APPFW_APPLICATION( 7371): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:21:09.205+0900 I/CAPI_APPFW_APPLICATION( 7371): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:21:09.255+0900 E/TBM     ( 7371): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:21:09.285+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7371, appid: org.example.example
06-03 00:21:09.285+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:21:09.295+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7371)
06-03 00:21:09.445+0900 I/APP_CORE( 7371): appcore-efl.c: __do_app(514) > [APP 7371] Event: RESET State: CREATED
06-03 00:21:09.445+0900 I/CAPI_APPFW_APPLICATION( 7371): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:21:09.445+0900 E/EFL     ( 7371): edje<7371> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:09.445+0900 E/EFL     ( 7371): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:09.455+0900 E/EFL     ( 7371): edje<7371> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:09.455+0900 E/EFL     ( 7371): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:09.455+0900 E/EFL     ( 7371): edje<7371> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:09.455+0900 E/EFL     ( 7371): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:09.455+0900 E/EFL     ( 7371): edje<7371> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:09.455+0900 E/EFL     ( 7371): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:09.455+0900 E/EFL     ( 7371): edje<7371> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:21:09.455+0900 E/EFL     ( 7371): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:21:09.495+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:09.495+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:09.505+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:09.505+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:21:09.505+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:09.515+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:09.545+0900 W/APP_CORE( 7371): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:21:09.545+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:21:09.645+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:21:09.645+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:21:09.645+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:21:09.655+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:21:09.655+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:21:09.655+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:21:09.655+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7371) status(3)
06-03 00:21:09.655+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7371)
06-03 00:21:09.655+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7371, appid: org.example.example, status: fg
06-03 00:21:09.665+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:21:09.665+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:21:09.665+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:21:09.665+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:21:09.685+0900 I/APP_CORE( 7371): appcore-efl.c: __do_app(514) > [APP 7371] Event: RESUME State: CREATED
06-03 00:21:09.695+0900 I/APP_CORE( 7371): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:21:09.695+0900 I/APP_CORE( 7371): appcore-efl.c: __do_app(625) > [APP 7371] Initial Launching, call the resume_cb
06-03 00:21:09.695+0900 I/CAPI_APPFW_APPLICATION( 7371): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:10.006+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7371) status(0)
06-03 00:21:10.236+0900 E/EFL     ( 7371): ecore_x<7371> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127450234
06-03 00:21:10.316+0900 E/EFL     ( 7371): ecore_x<7371> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127450310
06-03 00:21:10.326+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:10.326+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7371.
06-03 00:21:10.326+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3229
06-03 00:21:10.476+0900 W/LFE      (15849): [15849] 26:15:42.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:21:11.137+0900 I/UXT     ( 7392): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:21:11.167+0900 E/EFL     ( 7371): ecore_x<7371> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127451171
06-03 00:21:11.327+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7371 pgid = 7371
06-03 00:21:11.327+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7371)
06-03 00:21:11.327+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:11.337+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:21:11.337+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:21:11.337+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:21:11.337+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:21:11.337+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:21:11.377+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:21:11.377+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:21:11.377+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:21:11.377+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7371] terminate event is forwarded
06-03 00:21:11.377+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:21:11.377+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7371, ]
06-03 00:21:11.377+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:21:11.377+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:21:11.377+0900 I/Tizen::App( 1210): (512) > Not registered pid(7371)
06-03 00:21:11.377+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:21:11.377+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:11.387+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7371
06-03 00:21:11.387+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7371
06-03 00:21:11.387+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7371
06-03 00:21:11.417+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:21:11.417+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:21:11.427+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:11.427+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7371.
06-03 00:21:11.437+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:21:11.437+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:21:11.437+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:21:11.437+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:21:11.447+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:21:11.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:21:11.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:21:11.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:11.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:11.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:11.467+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:21:11.487+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:21:11.487+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:21:11.487+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:21:11.487+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:21:11.487+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:21:11.487+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:21:11.487+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:21:11.497+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:21:11.507+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:21:11.507+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:11.517+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:21:11.517+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:21:11.517+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:21:11.607+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:21:11.607+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:21:12.058+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107288657861149641686
