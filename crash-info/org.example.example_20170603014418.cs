S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 10056
Date: 2017-06-03 01:44:18+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 10056, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0x8001b6dc, r3   = 0x8001b6dc
r4   = 0x8001b6dc, r5   = 0xbed812a0
r6   = 0xb2782e61, r7   = 0xbed81128
r8   = 0x8001b6dc, r9   = 0xb5e79708
r10  = 0xb8c16f68, fp   = 0xbed8127c
ip   = 0x80004c27, sp   = 0xbed810e8
lr   = 0x8000ca66, pc   = 0xb2782e78
cpsr = 0x80060030

Memory Information
MemTotal:   987012 KB
MemFree:     39700 KB
Buffers:     14252 KB
Cached:     113936 KB
VmPeak:     111660 KB
VmSize:     106708 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29012 KB
VmRSS:       27124 KB
VmData:      28992 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          90 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 10056 TID = 10056
10056 10057 10244 

Maps Information
b1af6000 b1afe000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b0f000 b1b10000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b20000 b1b34000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b48000 b1b49000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b59000 b1b5c000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b6d000 b1b6e000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b7e000 b1b80000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1b90000 b1b92000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1ba2000 b1bb2000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bc2000 b1bce000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1be0000 b23df000 rw-p [stack:10244]
b2710000 b2717000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2728000 b2730000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2740000 b2755000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2767000 b276d000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b277d000 b2785000 r-xp /opt/usr/apps/org.example.example/bin/example
b28dd000 b29c0000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29f7000 b2a1f000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a31000 b3230000 rw-p [stack:10057]
b3230000 b3232000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3242000 b324c000 r-xp /lib/libnss_files-2.20-2014.11.so
b325d000 b3266000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3277000 b3288000 r-xp /lib/libnsl-2.20-2014.11.so
b329b000 b32a1000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32b2000 b32b3000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32db000 b32e2000 r-xp /usr/lib/libminizip.so.1.0.0
b32f2000 b32f7000 r-xp /usr/lib/libstorage.so.0.1
b3307000 b3366000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b337c000 b3390000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33a0000 b33e4000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33f4000 b33fc000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b340c000 b343c000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b344f000 b3508000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b351c000 b356f000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3580000 b359b000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ab000 b366c000 r-xp /usr/lib/libprotobuf.so.9.0.1
b367f000 b368f000 r-xp /usr/lib/libefl-assist.so.0.1.0
b369f000 b36ac000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36bd000 b36c4000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36d4000 b3715000 r-xp /usr/lib/libmdm.so.1.2.12
b3725000 b372d000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b373c000 b374c000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b376d000 b37cd000 r-xp /usr/lib/libasound.so.2.0.0
b37df000 b37e2000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37f2000 b37f5000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3805000 b380a000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b381a000 b381b000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b382b000 b3836000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b384a000 b3851000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3861000 b3867000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3877000 b387c000 r-xp /usr/lib/libmmfsession.so.0.0.1
b388c000 b38a7000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38b7000 b38be000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38ce000 b38d1000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38e2000 b3910000 r-xp /usr/lib/libidn.so.11.5.44
b3920000 b3936000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3947000 b3951000 r-xp /usr/lib/libcares.so.2.1.0
b3961000 b396b000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b397b000 b397d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b398d000 b398e000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b399e000 b39a2000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39b3000 b39db000 r-xp /usr/lib/libui-extension.so.0.1.0
b39ec000 b3a15000 r-xp /usr/lib/libturbojpeg.so
b3a35000 b3a3b000 r-xp /usr/lib/libgif.so.4.1.6
b3a4b000 b3a91000 r-xp /usr/lib/libcurl.so.4.3.0
b3aa2000 b3ac3000 r-xp /usr/lib/libexif.so.12.3.3
b3ade000 b3af3000 r-xp /usr/lib/libtts.so
b3b04000 b3b0c000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b1c000 b3be2000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c02000 b3cfa000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d19000 b3de7000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3dfe000 b3e00000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e10000 b3e16000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e26000 b3e49000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e5a000 b3e5c000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e6c000 b3e6e000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e7f000 b3e84000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e9b000 b3e9d000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ead000 b3eb4000 r-xp /usr/lib/libsensord-share.so
b3ec4000 b3edc000 r-xp /usr/lib/libsensor.so.1.1.0
b3eed000 b3ef0000 r-xp /usr/lib/libXv.so.1.0.0
b3f00000 b3f05000 r-xp /usr/lib/libutilX.so.1.1.0
b3f15000 b3f1a000 r-xp /usr/lib/libappcore-common.so.1.1
b3f2a000 b3f31000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f44000 b3f48000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f59000 b4037000 r-xp /usr/lib/libCOREGL.so.4.0
b4057000 b405a000 r-xp /usr/lib/libuuid.so.1.3.0
b406a000 b4081000 r-xp /usr/lib/libblkid.so.1.1.0
b4092000 b4094000 r-xp /usr/lib/libXau.so.6.0.0
b40a4000 b40eb000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40fd000 b4103000 r-xp /usr/lib/libjson-c.so.2.0.1
b4114000 b4118000 r-xp /usr/lib/libogg.so.0.7.1
b4128000 b414a000 r-xp /usr/lib/libvorbis.so.0.4.3
b415a000 b423e000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b425a000 b425d000 r-xp /usr/lib/libEGL.so.1.4
b426e000 b4274000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4284000 b4286000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4296000 b42a3000 r-xp /usr/lib/libGLESv2.so.2.0
b42b4000 b4316000 r-xp /usr/lib/libpixman-1.so.0.28.2
b432b000 b4343000 r-xp /usr/lib/libmount.so.1.1.0
b4355000 b4369000 r-xp /usr/lib/libxcb.so.1.1.0
b4379000 b4380000 r-xp /lib/libcrypt-2.20-2014.11.so
b43b8000 b43ba000 r-xp /usr/lib/libiri.so
b43ca000 b43d5000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43e6000 b441c000 r-xp /usr/lib/libpulse.so.0.16.2
b442d000 b4470000 r-xp /usr/lib/libsndfile.so.1.0.25
b4485000 b449a000 r-xp /lib/libexpat.so.1.5.2
b44ac000 b456a000 r-xp /usr/lib/libcairo.so.2.11200.14
b457e000 b4586000 r-xp /usr/lib/libdrm.so.2.4.0
b4596000 b4599000 r-xp /usr/lib/libdri2.so.0.0.0
b45a9000 b45f7000 r-xp /usr/lib/libssl.so.1.0.0
b460c000 b4618000 r-xp /usr/lib/libeeze.so.1.13.0
b4629000 b4632000 r-xp /usr/lib/libethumb.so.1.13.0
b4642000 b4645000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4655000 b480c000 r-xp /usr/lib/libcrypto.so.1.0.0
b55f7000 b5600000 r-xp /usr/lib/libXi.so.6.1.0
b5610000 b5612000 r-xp /usr/lib/libXgesture.so.7.0.0
b5622000 b5626000 r-xp /usr/lib/libXtst.so.6.1.0
b5636000 b563c000 r-xp /usr/lib/libXrender.so.1.3.0
b564c000 b5652000 r-xp /usr/lib/libXrandr.so.2.2.0
b5662000 b5664000 r-xp /usr/lib/libXinerama.so.1.0.0
b5675000 b5678000 r-xp /usr/lib/libXfixes.so.3.1.0
b5688000 b5693000 r-xp /usr/lib/libXext.so.6.4.0
b56a3000 b56a5000 r-xp /usr/lib/libXdamage.so.1.1.0
b56b5000 b56b7000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56c7000 b57a9000 r-xp /usr/lib/libX11.so.6.3.0
b57bd000 b57c4000 r-xp /usr/lib/libXcursor.so.1.0.2
b57d4000 b57ec000 r-xp /usr/lib/libudev.so.1.6.0
b57ee000 b57f1000 r-xp /lib/libattr.so.1.1.0
b5801000 b5821000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5822000 b5827000 r-xp /usr/lib/libffi.so.6.0.2
b5838000 b5850000 r-xp /lib/libz.so.1.2.8
b5860000 b5862000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5872000 b5947000 r-xp /usr/lib/libxml2.so.2.9.2
b595c000 b59f7000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a13000 b5a16000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a26000 b5a3f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a50000 b5a61000 r-xp /lib/libresolv-2.20-2014.11.so
b5a75000 b5aef000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b04000 b5b06000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b16000 b5b1d000 r-xp /usr/lib/libembryo.so.1.13.0
b5b2d000 b5b37000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b48000 b5b60000 r-xp /usr/lib/libpng12.so.0.50.0
b5b71000 b5b94000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bb5000 b5bc9000 r-xp /usr/lib/libector.so.1.13.0
b5bda000 b5bf2000 r-xp /usr/lib/liblua-5.1.so
b5c03000 b5c5a000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c6e000 b5c96000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ca7000 b5cba000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ccb000 b5d05000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d16000 b5d24000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d34000 b5d3c000 r-xp /usr/lib/libtbm.so.1.0.0
b5d4c000 b5d59000 r-xp /usr/lib/libeio.so.1.13.0
b5d69000 b5d6b000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d7b000 b5d80000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d90000 b5da7000 r-xp /usr/lib/libefreet.so.1.13.0
b5db9000 b5dd9000 r-xp /usr/lib/libeldbus.so.1.13.0
b5de9000 b5e09000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e0b000 b5e11000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e21000 b5e32000 r-xp /usr/lib/libemotion.so.1.13.0
b5e43000 b5e4a000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e5a000 b5e69000 r-xp /usr/lib/libeo.so.1.13.0
b5e7a000 b5e8c000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e9d000 b5ea2000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb2000 b5ecb000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5edb000 b5ef8000 r-xp /usr/lib/libeet.so.1.13.0
b5f11000 b5f59000 r-xp /usr/lib/libeina.so.1.13.0
b5f6a000 b5f7a000 r-xp /usr/lib/libefl.so.1.13.0
b5f8b000 b6070000 r-xp /usr/lib/libicuuc.so.51.1
b608d000 b61cd000 r-xp /usr/lib/libicui18n.so.51.1
b61e4000 b621c000 r-xp /usr/lib/libecore_x.so.1.13.0
b622e000 b6231000 r-xp /lib/libcap.so.2.21
b6241000 b626a000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b627b000 b6282000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6294000 b62cb000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62dc000 b63c7000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63da000 b6453000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6465000 b646a000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b647a000 b6484000 r-xp /usr/lib/libvconf.so.0.2.45
b6494000 b6496000 r-xp /usr/lib/libvasum.so.0.3.1
b64a6000 b64a8000 r-xp /usr/lib/libttrace.so.1.1
b64b8000 b64bb000 r-xp /usr/lib/libiniparser.so.0
b64cb000 b64f1000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6501000 b6506000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6517000 b652e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b653f000 b65aa000 r-xp /lib/libm-2.20-2014.11.so
b65bb000 b65c1000 r-xp /lib/librt-2.20-2014.11.so
b65d2000 b65df000 r-xp /usr/lib/libunwind.so.8.0.1
b6615000 b6739000 r-xp /lib/libc-2.20-2014.11.so
b674e000 b6767000 r-xp /lib/libgcc_s-4.9.so.1
b6777000 b6859000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b686a000 b6894000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68a5000 b68e1000 r-xp /usr/lib/libsystemd.so.0.4.0
b68e3000 b6966000 r-xp /usr/lib/libedje.so.1.13.0
b6979000 b6997000 r-xp /usr/lib/libecore.so.1.13.0
b69b7000 b6b3e000 r-xp /usr/lib/libevas.so.1.13.0
b6b73000 b6b87000 r-xp /lib/libpthread-2.20-2014.11.so
b6b9b000 b6dcf000 r-xp /usr/lib/libelementary.so.1.13.0
b6dfe000 b6e02000 r-xp /usr/lib/libsmack.so.1.0.0
b6e12000 b6e19000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e29000 b6e2b000 r-xp /usr/lib/libdlog.so.0.0.0
b6e3b000 b6e3e000 r-xp /usr/lib/libbundle.so.0.1.22
b6e4e000 b6e50000 r-xp /lib/libdl-2.20-2014.11.so
b6e61000 b6e79000 r-xp /usr/lib/libaul.so.0.1.0
b6e8d000 b6e92000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ea3000 b6eb0000 r-xp /usr/lib/liblptcp.so
b6ec2000 b6ec6000 r-xp /usr/lib/libsys-assert.so
b6ed7000 b6ef7000 r-xp /lib/ld-2.20-2014.11.so
b6f08000 b6f0d000 r-xp /usr/bin/launchpad-loader
b89ac000 b8c67000 rw-p [heap]
bed61000 bed82000 rw-p [stack]
End of Maps Information

Callstack Information (PID:10056)
Call Stack Count: 18
 0: setting_view_cb + 0x17 (0xb2782e78) [/opt/usr/apps/org.example.example/bin/example] + 0x5e78
 1: (0xb69ec175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5e65219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5e63fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb69ec515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb69f4725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb69f9f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb69fd939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb4644173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6984c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb698aa5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb698ac83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6e902bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3f46909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2782677) [/opt/usr/apps/org.example.example/bin/example] + 0x5677
15: (0xb6f09bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb662b4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6f09eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
GR_SERVER(10178): pkgmgr-server-internal.c: _zone_set_type_and_backend(180) > tep_filepath [/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk]
06-03 01:44:09.213+0900 E/PKGMGR_INFO(10178): pkgmgrinfo_pkginfo.c: pkgmgrinfo_pkginfo_get_unmounted_pkginfo(778) > (exist == 0) pkgid[/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk] not found in DB
06-03 01:44:09.223+0900 E/rpm-installer(10178): librpm.c: __installer_util_delete_dir(171) > opendir(/tmp/coretpk-unzip) failed. [2][No such file or directory]
06-03 01:44:09.233+0900 E/PKGMGR_SERVER(10178): pm-mdm.c: _pm_check_mdm_policy(75) > [0;31m[_pm_check_mdm_policy(): 75](ret != MDM_RESULT_SUCCESS) can not connect mdm server[0;m
06-03 01:44:09.233+0900 E/PKGMGR  (10175): pkgmgr.c: pkgmgr_client_install(1723) > install pkg finish, ret=[101750002]
06-03 01:44:09.374+0900 E/PKGMGR_INSTALLER(10181): pkgmgr_installer.c: pkgmgr_installer_receive_request(225) > option is [i]
06-03 01:44:09.374+0900 E/rpm-installer(10181): rpm-appcore-intf.c: main(186) > [/opt/usr/apps/tmp/org.example.example-1.0.0-arm.tpk] is tpk package.
06-03 01:44:09.394+0900 E/rpm-installer(10181): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
06-03 01:44:09.394+0900 E/rpm-installer(10181): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [install-location] is empty.
06-03 01:44:09.394+0900 E/rpm-installer(10181): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:44:09.394+0900 E/rpm-installer(10181): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
06-03 01:44:09.394+0900 E/rpm-installer(10181): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:44:09.454+0900 W/CERT_SVC_VCORE(10181): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
06-03 01:44:09.514+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: start, val: install
06-03 01:44:09.514+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [start], Value = [install], install = [96]
06-03 01:44:09.514+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:09.514+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:09.514+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:09.514+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:09.524+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 30
06-03 01:44:09.524+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [30]
06-03 01:44:09.524+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [30], install = [96]
06-03 01:44:09.524+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:09.524+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:09.524+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:09.534+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:09.764+0900 E/rpm-installer(10181): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-03 01:44:09.764+0900 E/rpm-installer(10181): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-03 01:44:09.764+0900 E/rpm-installer(10181): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-03 01:44:09.764+0900 E/rpm-installer(10181): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:44:09.764+0900 E/rpm-installer(10181): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-03 01:44:09.764+0900 E/rpm-installer(10181): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-03 01:44:09.774+0900 E/PKGMGR_PARSER(10181): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-03 01:44:09.784+0900 E/PKGMGR_PARSER(10181): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-03 01:44:09.824+0900 I/PRIVACY-MANAGER-CLIENT(10181): SocketClient.cpp: SocketClient(37) > Client created
06-03 01:44:10.074+0900 E/PKGMGR_PARSER(10181): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-03 01:44:10.094+0900 E/PKGMGR_CERT(10181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-03 01:44:10.094+0900 E/PKGMGR_CERT(10181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-03 01:44:10.094+0900 E/PKGMGR_CERT(10181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-03 01:44:10.094+0900 E/PKGMGR_CERT(10181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 2
06-03 01:44:10.094+0900 E/PKGMGR_CERT(10181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 2
06-03 01:44:10.094+0900 E/PKGMGR_CERT(10181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 46 2
06-03 01:44:10.094+0900 E/PKGMGR_CERT(10181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 2
06-03 01:44:10.104+0900 E/PKGMGR_CERT(10181): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-03 01:44:10.104+0900 E/rpm-installer(10181): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.example/lib]
06-03 01:44:10.104+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 60
06-03 01:44:10.104+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [60]
06-03 01:44:10.104+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [60], install = [96]
06-03 01:44:10.104+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:10.104+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:10.104+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:10.104+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:10.124+0900 E/rpm-installer(10181): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:44:10.154+0900 E/rpm-installer(10181): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-03 01:44:10.154+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 100
06-03 01:44:10.154+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [100]
06-03 01:44:10.154+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [100], install = [96]
06-03 01:44:10.154+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:10.154+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:10.154+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:10.154+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:11.005+0900 E/PKGMGR_SERVER(10178): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:44:12.026+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 01:44:12.026+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 01:44:12.026+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 01:44:12.036+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 01:44:12.036+0900 I/Tizen::App( 1210): (78) > Installation is Completed. [Package = org.example.example]
06-03 01:44:12.036+0900 I/Tizen::App( 1210): (671) > Enter. package(org.example.example), installationResult(0)
06-03 01:44:12.046+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:44:12.046+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:44:12.046+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:44:12.046+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:44:12.046+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:44:12.046+0900 I/Tizen::App( 1210): (1360) > package(org.example.example), version(1.0.0), type(tpk), displayName(forpet), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.example), storeClient(), appRootPath(/opt/usr/apps/org.example.example)
06-03 01:44:12.056+0900 E/PKGMGR_SERVER(10178): pkgmgr-server.c: sighandler(417) > child NORMAL exit [10181]
06-03 01:44:12.066+0900 W/ISF_PANEL_EFL(  768): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-03 01:44:12.066+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:12.066+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:12.066+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:12.066+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:44:12.066+0900 I/Tizen::App( 1210): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.example]
06-03 01:44:12.076+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[forpet] enable[1] system[0]
06-03 01:44:12.076+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.example] mdm is not enabled
06-03 01:44:12.076+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.example]
06-03 01:44:12.086+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:44:12.086+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:44:12.086+0900 E/PKGMGR_INFO( 1210): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-03 01:44:12.086+0900 I/Tizen::App( 1210): (683) > Application count(1) in this package
06-03 01:44:12.086+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:44:12.086+0900 I/Tizen::App( 1210): (703) > Exit.
06-03 01:44:12.086+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [96]
06-03 01:44:12.086+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[forpet] enable[1] system[0]
06-03 01:44:12.096+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:44:12.096+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:44:12.096+0900 I/Tizen::App( 1210): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.example.info]
06-03 01:44:12.096+0900 I/Tizen::App( 1210): (131) > Enter
06-03 01:44:12.106+0900 I/Tizen::App( 1210): (137) > org.example.example does not have launch condition
06-03 01:44:12.106+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:44:12.106+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:44:12.106+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:44:12.997+0900 E/PKGMGR_SERVER(10178): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 01:44:12.997+0900 E/PKGMGR_SERVER(10178): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 01:44:16.601+0900 W/AUL     (10237): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.example)
06-03 01:44:16.601+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:44:16.611+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-03 01:44:16.631+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-03 01:44:16.631+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 01:44:16.631+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 10237
06-03 01:44:16.631+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 01:44:16.641+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 9
06-03 01:44:16.641+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:44:16.651+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:44:16.651+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 01:44:16.651+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:44:16.681+0900 I/CAPI_APPFW_APPLICATION(10056): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:44:16.681+0900 I/CAPI_APPFW_APPLICATION(10056): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:44:16.731+0900 E/TBM     (10056): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:44:16.751+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 10056, appid: org.example.example
06-03 01:44:16.751+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:44:16.761+0900 W/AUL     (10237): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10056)
06-03 01:44:17.021+0900 I/APP_CORE(10056): appcore-efl.c: __do_app(514) > [APP 10056] Event: RESET State: CREATED
06-03 01:44:17.021+0900 I/CAPI_APPFW_APPLICATION(10056): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:44:17.031+0900 E/EFL     (10056): edje<10056> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:44:17.031+0900 E/EFL     (10056): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:44:17.031+0900 E/EFL     (10056): edje<10056> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:44:17.031+0900 E/EFL     (10056): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:44:17.031+0900 E/EFL     (10056): edje<10056> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:44:17.031+0900 E/EFL     (10056): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:44:17.031+0900 E/EFL     (10056): edje<10056> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:44:17.031+0900 E/EFL     (10056): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:44:17.031+0900 E/EFL     (10056): edje<10056> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:44:17.031+0900 E/EFL     (10056): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:44:17.051+0900 W/APP_CORE(10056): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7000002
06-03 01:44:17.051+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:44:17.201+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10056) status(4)
06-03 01:44:17.291+0900 I/APP_CORE(10056): appcore-efl.c: __do_app(514) > [APP 10056] Event: PAUSE State: CREATED
06-03 01:44:17.331+0900 I/TIZEN_N_EFL_UTIL_WINDOW(10056): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 30
06-03 01:44:17.331+0900 E/APP_CORE(10056): appcore-efl.c: _capture_and_make_file(1619) > win[7000002] widget[720] height[1280]
06-03 01:44:17.331+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 01:44:17.551+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10056) status(0)
06-03 01:44:17.622+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 01:44:17.622+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 01:44:17.622+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 01:44:17.622+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 01:44:17.622+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 01:44:17.622+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 01:44:17.632+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:44:17.632+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:44:17.632+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 01:44:17.632+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:44
06-03 01:44:17.642+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 1:44"
06-03 01:44:17.642+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:44"
06-03 01:44:17.642+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:44:17.642+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146231595 Time: <font_size=31> </font_size> <font_size=31> 오전 1:44</font_size></font>"
06-03 01:44:17.642+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(0) / battery_charging(1)"
06-03 01:44:17.642+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 01:44:17.642+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:44:17.642+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:44:17.642+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:44:17.642+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:44:17.642+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:44:17.802+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 01:44:17.802+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3482
06-03 01:44:17.852+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:44:17.852+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-03 01:44:17.872+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 01:44:17.872+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 01:44:17.872+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 01:44:17.872+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 01:44:17.872+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:44:17.882+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 01:44:17.882+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 01:44:17.882+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:44:17.882+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 01:44:17.882+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:44:17.882+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 01:44:17.882+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 01:44:17.892+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 10246
06-03 01:44:17.902+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:44:17.912+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 10056.
06-03 01:44:17.942+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 10246
06-03 01:44:17.942+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 10246, appid: com.samsung.weather-m-agent
06-03 01:44:17.962+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(10246)
06-03 01:44:17.972+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 01:44:17.972+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 10246.
06-03 01:44:18.152+0900 E/weather-agent(10246): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 01:44:18.152+0900 E/weather-common(10246): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 01:44:18.152+0900 E/weather-agent(10246): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 01:44:18.152+0900 E/weather-agent(10246): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 01:44:18.162+0900 E/weather-common(10246): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 01:44:18.162+0900 E/weather-common(10246): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 01:44:18.162+0900 E/weather-common(10246): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 01:44:18.162+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 01:44:18.162+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 01:44:18.162+0900 I/MESSAGE_PORT(10246): message-port.c: __initialize(872) > initialize
06-03 01:44:18.172+0900 I/MESSAGE_PORT(10246): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 01:44:18.212+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:44:18.212+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:44:18.212+0900 I/MESSAGE_PORT(10246): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:44:18.212+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 01:44:18.212+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 01:44:18.212+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:44:18.222+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132438222
06-03 01:44:18.222+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:44:18.222+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 01:44:18.232+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:44:18.232+0900 E/MESSAGE_PORT(10246): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 01:44:18.232+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 01:44:18.232+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:44:18.232+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:44:18.242+0900 E/MESSAGE_PORT(10246): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 01:44:18.242+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 01:44:18.242+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:44:18.242+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:44:18.242+0900 I/MESSAGE_PORT(10246): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:44:18.242+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 01:44:18.242+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 01:44:18.242+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:44:18.242+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:44:18.252+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:44:18.252+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:44:18.252+0900 I/MESSAGE_PORT(10246): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:44:18.252+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:44:18.252+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 01:44:18.252+0900 I/MESSAGE_PORT(10246): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 01:44:18.252+0900 I/MESSAGE_PORT(10246): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:44:18.252+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:44:18.252+0900 E/MESSAGE_PORT(10246): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 01:44:18.252+0900 E/weather-common(10246): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 01:44:18.252+0900 E/weather-agent(10246): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 01:44:18.252+0900 E/weather-agent(10246): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 01:44:18.262+0900 I/MESSAGE_PORT(10246): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:44:18.262+0900 I/MESSAGE_PORT(10246): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:44:18.282+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 01:44:18.282+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 01:44:18.282+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:44:18.292+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:44:18.312+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:44:18.312+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 01:44:18.332+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132438330
06-03 01:44:18.332+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 01:44:18.332+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 01:44:18.332+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:44:18.362+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:44:18.362+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:44:18.362+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:44:18.362+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:44:18.362+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:44:18.362+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:44:18.372+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 01:44:18.442+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:44:18.442+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:44:18.663+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 01:44:18.663+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 01:44:18.663+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 01:44:18.663+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 01:44:18.663+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:44:18.663+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:44:18.663+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:44:18.663+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:44:18.663+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:44:18.673+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:44:18.683+0900 I/APP_CORE(10056): appcore-efl.c: __do_app(514) > [APP 10056] Event: RESUME State: CREATED
06-03 01:44:18.683+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:44:18.693+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 01:44:18.693+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 01:44:18.693+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 01:44:18.693+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 01:44:18.693+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 01:44:18.693+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:44:18.693+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:44:18.693+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:44:18.693+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 01:44:18.693+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 01:44:18.693+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:44:18.693+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 01:44:18.703+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 01:44:18.703+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 01:44:18.703+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 01:44:18.703+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(10056) status(3)
06-03 01:44:18.703+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:44:18.703+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:44:18.703+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(10056)
06-03 01:44:18.703+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 10056, appid: org.example.example, status: fg
06-03 01:44:18.713+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 01:44:18.723+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 01:44:18.723+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:44:18.733+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:44:18.733+0900 I/APP_CORE(10056): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:44:18.733+0900 I/APP_CORE(10056): appcore-efl.c: __do_app(625) > [APP 10056] Initial Launching, call the resume_cb
06-03 01:44:18.733+0900 I/CAPI_APPFW_APPLICATION(10056): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:44:18.733+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:44:18.793+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 01:44:18.793+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:44:18.793+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:44:18.793+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:44:18.793+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:44:18.803+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 01:44:18.873+0900 E/EFL     (10056): ecore_x<10056> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=132438836
06-03 01:44:18.873+0900 E/EFL     (10056): ecore_x<10056> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=132438858
06-03 01:44:19.013+0900 I/UXT     (10245): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 01:44:19.033+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:44:19.033+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10056 pgid = 10056
06-03 01:44:19.033+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(10056)
06-03 01:44:19.043+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9996) status(3)
06-03 01:44:19.043+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:44:19.043+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:44:19.043+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.tizen.crash-viewer(9996)
06-03 01:44:19.043+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9996, appid: org.tizen.crash-viewer, status: fg
06-03 01:44:19.073+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:44:19.073+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:44:19.073+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:44:19.073+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[10056] terminate event is forwarded
06-03 01:44:19.073+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:44:19.073+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 10056, ]
06-03 01:44:19.073+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:44:19.073+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 01:44:19.073+0900 I/Tizen::App( 1210): (512) > Not registered pid(10056)
06-03 01:44:19.073+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 01:44:19.073+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:44:19.073+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 10056
06-03 01:44:19.073+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10056
06-03 01:44:19.073+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 10056
06-03 01:44:19.083+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3487
06-03 01:44:19.103+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9996) status(0)
06-03 01:44:19.103+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:44:19.103+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 10056.
06-03 01:44:19.123+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:44:19.133+0900 I/APP_CORE( 9996): appcore-efl.c: __do_app(514) > [APP 9996] Event: RESUME State: PAUSED
06-03 01:44:19.133+0900 I/CAPI_APPFW_APPLICATION( 9996): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:44:19.133+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:44:19.143+0900 I/Tizen::System( 1210): (259) > Active app [org.tizen.], current [org.exampl] 
06-03 01:44:19.143+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:44:19.153+0900 W/CRASH_MANAGER(10256): worker.c: worker_job(1199) > 1110056657861149642185
