S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 8002
Date: 2017-06-03 00:59:48+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 8002, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3e99000, r3   = 0xb3e99020
r4   = 0x8001b6dc, r5   = 0xbee142a0
r6   = 0xb2784e5d, r7   = 0xbee14128
r8   = 0x8001b6dc, r9   = 0xb5e7b708
r10  = 0xb84239b0, fp   = 0xbee1427c
ip   = 0xb5f6b120, sp   = 0xbee140e8
lr   = 0xb5f2fbd9, pc   = 0xb2784e86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     35368 KB
Buffers:     13756 KB
Cached:     109784 KB
VmPeak:     120900 KB
VmSize:     112208 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       28992 KB
VmRSS:       27012 KB
VmData:      38144 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          90 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 8002 TID = 8002
8002 8003 8138 8139 

Maps Information
b127d000 b1a7c000 rw-p [stack:8139]
b1af8000 b1b00000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b11000 b1b12000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b22000 b1b36000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b4a000 b1b4b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b5b000 b1b5e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1b6f000 b1b70000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1b80000 b1b82000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1b92000 b1b94000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1ba4000 b1bb4000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bc4000 b1bd0000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1be2000 b23e1000 rw-p [stack:8138]
b2712000 b2719000 r-xp /usr/lib/libefl-extension.so.0.1.0
b272a000 b2732000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2742000 b2757000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2769000 b276f000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b277f000 b2787000 r-xp /opt/usr/apps/org.example.example/bin/example
b28df000 b29c2000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b29f9000 b2a21000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a33000 b3232000 rw-p [stack:8003]
b3232000 b3234000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3244000 b324e000 r-xp /lib/libnss_files-2.20-2014.11.so
b325f000 b3268000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3279000 b328a000 r-xp /lib/libnsl-2.20-2014.11.so
b329d000 b32a3000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32b4000 b32b5000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b32dd000 b32e4000 r-xp /usr/lib/libminizip.so.1.0.0
b32f4000 b32f9000 r-xp /usr/lib/libstorage.so.0.1
b3309000 b3368000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b337e000 b3392000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33a2000 b33e6000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b33f6000 b33fe000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b340e000 b343e000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3451000 b350a000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b351e000 b3571000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3582000 b359d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35ad000 b366e000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3681000 b3691000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36a1000 b36ae000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36bf000 b36c6000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b36d6000 b3717000 r-xp /usr/lib/libmdm.so.1.2.12
b3727000 b372f000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b373e000 b374e000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b376f000 b37cf000 r-xp /usr/lib/libasound.so.2.0.0
b37e1000 b37e4000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b37f4000 b37f7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3807000 b380c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b381c000 b381d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b382d000 b3838000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b384c000 b3853000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3863000 b3869000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3879000 b387e000 r-xp /usr/lib/libmmfsession.so.0.0.1
b388e000 b38a9000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38b9000 b38c0000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b38d0000 b38d3000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b38e4000 b3912000 r-xp /usr/lib/libidn.so.11.5.44
b3922000 b3938000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3949000 b3953000 r-xp /usr/lib/libcares.so.2.1.0
b3963000 b396d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b397d000 b397f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b398f000 b3990000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39a0000 b39a4000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39b5000 b39dd000 r-xp /usr/lib/libui-extension.so.0.1.0
b39ee000 b3a17000 r-xp /usr/lib/libturbojpeg.so
b3a37000 b3a3d000 r-xp /usr/lib/libgif.so.4.1.6
b3a4d000 b3a93000 r-xp /usr/lib/libcurl.so.4.3.0
b3aa4000 b3ac5000 r-xp /usr/lib/libexif.so.12.3.3
b3ae0000 b3af5000 r-xp /usr/lib/libtts.so
b3b06000 b3b0e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b1e000 b3be4000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c04000 b3cfc000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d1b000 b3de9000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e00000 b3e02000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e12000 b3e18000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e28000 b3e4b000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e5c000 b3e5e000 r-xp /usr/lib/libappsvc.so.0.1.0
b3e6e000 b3e70000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3e81000 b3e86000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3e9d000 b3e9f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3eaf000 b3eb6000 r-xp /usr/lib/libsensord-share.so
b3ec6000 b3ede000 r-xp /usr/lib/libsensor.so.1.1.0
b3eef000 b3ef2000 r-xp /usr/lib/libXv.so.1.0.0
b3f02000 b3f07000 r-xp /usr/lib/libutilX.so.1.1.0
b3f17000 b3f1c000 r-xp /usr/lib/libappcore-common.so.1.1
b3f2c000 b3f33000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f46000 b3f4a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f5b000 b4039000 r-xp /usr/lib/libCOREGL.so.4.0
b4059000 b405c000 r-xp /usr/lib/libuuid.so.1.3.0
b406c000 b4083000 r-xp /usr/lib/libblkid.so.1.1.0
b4094000 b4096000 r-xp /usr/lib/libXau.so.6.0.0
b40a6000 b40ed000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b40ff000 b4105000 r-xp /usr/lib/libjson-c.so.2.0.1
b4116000 b411a000 r-xp /usr/lib/libogg.so.0.7.1
b412a000 b414c000 r-xp /usr/lib/libvorbis.so.0.4.3
b415c000 b4240000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b425c000 b425f000 r-xp /usr/lib/libEGL.so.1.4
b4270000 b4276000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4286000 b4288000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4298000 b42a5000 r-xp /usr/lib/libGLESv2.so.2.0
b42b6000 b4318000 r-xp /usr/lib/libpixman-1.so.0.28.2
b432d000 b4345000 r-xp /usr/lib/libmount.so.1.1.0
b4357000 b436b000 r-xp /usr/lib/libxcb.so.1.1.0
b437b000 b4382000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ba000 b43bc000 r-xp /usr/lib/libiri.so
b43cc000 b43d7000 r-xp /usr/lib/libgpg-error.so.0.15.0
b43e8000 b441e000 r-xp /usr/lib/libpulse.so.0.16.2
b442f000 b4472000 r-xp /usr/lib/libsndfile.so.1.0.25
b4487000 b449c000 r-xp /lib/libexpat.so.1.5.2
b44ae000 b456c000 r-xp /usr/lib/libcairo.so.2.11200.14
b4580000 b4588000 r-xp /usr/lib/libdrm.so.2.4.0
b4598000 b459b000 r-xp /usr/lib/libdri2.so.0.0.0
b45ab000 b45f9000 r-xp /usr/lib/libssl.so.1.0.0
b460e000 b461a000 r-xp /usr/lib/libeeze.so.1.13.0
b462b000 b4634000 r-xp /usr/lib/libethumb.so.1.13.0
b4644000 b4647000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4657000 b480e000 r-xp /usr/lib/libcrypto.so.1.0.0
b55f9000 b5602000 r-xp /usr/lib/libXi.so.6.1.0
b5612000 b5614000 r-xp /usr/lib/libXgesture.so.7.0.0
b5624000 b5628000 r-xp /usr/lib/libXtst.so.6.1.0
b5638000 b563e000 r-xp /usr/lib/libXrender.so.1.3.0
b564e000 b5654000 r-xp /usr/lib/libXrandr.so.2.2.0
b5664000 b5666000 r-xp /usr/lib/libXinerama.so.1.0.0
b5677000 b567a000 r-xp /usr/lib/libXfixes.so.3.1.0
b568a000 b5695000 r-xp /usr/lib/libXext.so.6.4.0
b56a5000 b56a7000 r-xp /usr/lib/libXdamage.so.1.1.0
b56b7000 b56b9000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56c9000 b57ab000 r-xp /usr/lib/libX11.so.6.3.0
b57bf000 b57c6000 r-xp /usr/lib/libXcursor.so.1.0.2
b57d6000 b57ee000 r-xp /usr/lib/libudev.so.1.6.0
b57f0000 b57f3000 r-xp /lib/libattr.so.1.1.0
b5803000 b5823000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5824000 b5829000 r-xp /usr/lib/libffi.so.6.0.2
b583a000 b5852000 r-xp /lib/libz.so.1.2.8
b5862000 b5864000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5874000 b5949000 r-xp /usr/lib/libxml2.so.2.9.2
b595e000 b59f9000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a15000 b5a18000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a28000 b5a41000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a52000 b5a63000 r-xp /lib/libresolv-2.20-2014.11.so
b5a77000 b5af1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b06000 b5b08000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b18000 b5b1f000 r-xp /usr/lib/libembryo.so.1.13.0
b5b2f000 b5b39000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b4a000 b5b62000 r-xp /usr/lib/libpng12.so.0.50.0
b5b73000 b5b96000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bb7000 b5bcb000 r-xp /usr/lib/libector.so.1.13.0
b5bdc000 b5bf4000 r-xp /usr/lib/liblua-5.1.so
b5c05000 b5c5c000 r-xp /usr/lib/libfreetype.so.6.11.3
b5c70000 b5c98000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5ca9000 b5cbc000 r-xp /usr/lib/libfribidi.so.0.3.1
b5ccd000 b5d07000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d18000 b5d26000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d36000 b5d3e000 r-xp /usr/lib/libtbm.so.1.0.0
b5d4e000 b5d5b000 r-xp /usr/lib/libeio.so.1.13.0
b5d6b000 b5d6d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5d7d000 b5d82000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5d92000 b5da9000 r-xp /usr/lib/libefreet.so.1.13.0
b5dbb000 b5ddb000 r-xp /usr/lib/libeldbus.so.1.13.0
b5deb000 b5e0b000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e0d000 b5e13000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e23000 b5e34000 r-xp /usr/lib/libemotion.so.1.13.0
b5e45000 b5e4c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e5c000 b5e6b000 r-xp /usr/lib/libeo.so.1.13.0
b5e7c000 b5e8e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5e9f000 b5ea4000 r-xp /usr/lib/libecore_file.so.1.13.0
b5eb4000 b5ecd000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5edd000 b5efa000 r-xp /usr/lib/libeet.so.1.13.0
b5f13000 b5f5b000 r-xp /usr/lib/libeina.so.1.13.0
b5f6c000 b5f7c000 r-xp /usr/lib/libefl.so.1.13.0
b5f8d000 b6072000 r-xp /usr/lib/libicuuc.so.51.1
b608f000 b61cf000 r-xp /usr/lib/libicui18n.so.51.1
b61e6000 b621e000 r-xp /usr/lib/libecore_x.so.1.13.0
b6230000 b6233000 r-xp /lib/libcap.so.2.21
b6243000 b626c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b627d000 b6284000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6296000 b62cd000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b62de000 b63c9000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b63dc000 b6455000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6467000 b646c000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b647c000 b6486000 r-xp /usr/lib/libvconf.so.0.2.45
b6496000 b6498000 r-xp /usr/lib/libvasum.so.0.3.1
b64a8000 b64aa000 r-xp /usr/lib/libttrace.so.1.1
b64ba000 b64bd000 r-xp /usr/lib/libiniparser.so.0
b64cd000 b64f3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6503000 b6508000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6519000 b6530000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6541000 b65ac000 r-xp /lib/libm-2.20-2014.11.so
b65bd000 b65c3000 r-xp /lib/librt-2.20-2014.11.so
b65d4000 b65e1000 r-xp /usr/lib/libunwind.so.8.0.1
b6617000 b673b000 r-xp /lib/libc-2.20-2014.11.so
b6750000 b6769000 r-xp /lib/libgcc_s-4.9.so.1
b6779000 b685b000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b686c000 b6896000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68a7000 b68e3000 r-xp /usr/lib/libsystemd.so.0.4.0
b68e5000 b6968000 r-xp /usr/lib/libedje.so.1.13.0
b697b000 b6999000 r-xp /usr/lib/libecore.so.1.13.0
b69b9000 b6b40000 r-xp /usr/lib/libevas.so.1.13.0
b6b75000 b6b89000 r-xp /lib/libpthread-2.20-2014.11.so
b6b9d000 b6dd1000 r-xp /usr/lib/libelementary.so.1.13.0
b6e00000 b6e04000 r-xp /usr/lib/libsmack.so.1.0.0
b6e14000 b6e1b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e2b000 b6e2d000 r-xp /usr/lib/libdlog.so.0.0.0
b6e3d000 b6e40000 r-xp /usr/lib/libbundle.so.0.1.22
b6e50000 b6e52000 r-xp /lib/libdl-2.20-2014.11.so
b6e63000 b6e7b000 r-xp /usr/lib/libaul.so.0.1.0
b6e8f000 b6e94000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ea5000 b6eb2000 r-xp /usr/lib/liblptcp.so
b6ec4000 b6ec8000 r-xp /usr/lib/libsys-assert.so
b6ed9000 b6ef9000 r-xp /lib/ld-2.20-2014.11.so
b6f0a000 b6f0f000 r-xp /usr/bin/launchpad-loader
b81c9000 b846e000 rw-p [heap]
bedf4000 bee15000 rw-p [stack]
End of Maps Information

Callstack Information (PID:8002)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb2784e86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb69ee175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5e67219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5e65fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb69ee515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb69f6725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb69fbf6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb69ff939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb4646173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6986c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb698ca5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb698cc83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6e922bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3f48909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2784673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6f0bbb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb662d4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6f0beb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
470+0900 W/LFE      (15849): [15849] 26:50:27.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:55:57.973+0900 W/LFE      (15849): [15849] 26:50:30.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:00.475+0900 W/LFE      (15849): [15849] 26:50:32.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:02.978+0900 W/LFE      (15849): [15849] 26:50:35.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:05.460+0900 W/LFE      (15849): [15849] 26:50:37.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:07.962+0900 W/LFE      (15849): [15849] 26:50:40.045[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:10.475+0900 W/LFE      (15849): [15849] 26:50:42.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:12.977+0900 W/LFE      (15849): [15849] 26:50:45.048[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:15.470+0900 W/LFE      (15849): [15849] 26:50:47.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:16.621+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:56:17.972+0900 W/LFE      (15849): [15849] 26:50:50.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:20.475+0900 W/LFE      (15849): [15849] 26:50:52.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:22.967+0900 W/LFE      (15849): [15849] 26:50:55.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:25.479+0900 W/LFE      (15849): [15849] 26:50:57.557[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:27.962+0900 W/LFE      (15849): [15849] 26:51:00.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:30.464+0900 W/LFE      (15849): [15849] 26:51:02.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:32.967+0900 W/LFE      (15849): [15849] 26:51:05.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:35.459+0900 W/LFE      (15849): [15849] 26:51:07.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:37.972+0900 W/LFE      (15849): [15849] 26:51:10.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:40.474+0900 W/LFE      (15849): [15849] 26:51:12.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:42.987+0900 W/LFE      (15849): [15849] 26:51:15.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:45.479+0900 W/LFE      (15849): [15849] 26:51:17.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:47.981+0900 W/LFE      (15849): [15849] 26:51:20.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:50.464+0900 W/LFE      (15849): [15849] 26:51:22.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:52.956+0900 W/LFE      (15849): [15849] 26:51:25.045[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:55.459+0900 W/LFE      (15849): [15849] 26:51:27.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:56:57.961+0900 W/LFE      (15849): [15849] 26:51:30.045[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:00.474+0900 W/LFE      (15849): [15849] 26:51:32.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:02.976+0900 W/LFE      (15849): [15849] 26:51:35.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:05.468+0900 W/LFE      (15849): [15849] 26:51:37.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:07.971+0900 W/LFE      (15849): [15849] 26:51:40.047[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:10.473+0900 W/LFE      (15849): [15849] 26:51:42.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:12.976+0900 W/LFE      (15849): [15849] 26:51:45.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:15.468+0900 W/LFE      (15849): [15849] 26:51:47.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:16.679+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:57:17.971+0900 W/LFE      (15849): [15849] 26:51:50.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:20.473+0900 W/LFE      (15849): [15849] 26:51:52.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:22.986+0900 W/LFE      (15849): [15849] 26:51:55.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:25.478+0900 W/LFE      (15849): [15849] 26:51:57.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:27.960+0900 W/LFE      (15849): [15849] 26:52:00.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:30.463+0900 W/LFE      (15849): [15849] 26:52:02.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:32.965+0900 W/LFE      (15849): [15849] 26:52:05.043[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:35.458+0900 W/LFE      (15849): [15849] 26:52:07.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:37.960+0900 W/LFE      (15849): [15849] 26:52:10.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:40.473+0900 W/LFE      (15849): [15849] 26:52:12.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:42.975+0900 W/LFE      (15849): [15849] 26:52:15.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:45.468+0900 W/LFE      (15849): [15849] 26:52:17.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:47.980+0900 W/LFE      (15849): [15849] 26:52:20.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:50.462+0900 W/LFE      (15849): [15849] 26:52:22.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:52.965+0900 W/LFE      (15849): [15849] 26:52:25.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:55.477+0900 W/LFE      (15849): [15849] 26:52:27.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:57:57.970+0900 W/LFE      (15849): [15849] 26:52:30.051[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:00.472+0900 W/LFE      (15849): [15849] 26:52:32.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:02.975+0900 W/LFE      (15849): [15849] 26:52:35.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:05.477+0900 W/LFE      (15849): [15849] 26:52:37.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:07.969+0900 W/LFE      (15849): [15849] 26:52:40.055[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:10.472+0900 W/LFE      (15849): [15849] 26:52:42.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:12.974+0900 W/LFE      (15849): [15849] 26:52:45.047[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:15.467+0900 W/LFE      (15849): [15849] 26:52:47.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:16.738+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:58:17.969+0900 W/LFE      (15849): [15849] 26:52:50.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:20.472+0900 W/LFE      (15849): [15849] 26:52:52.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:22.974+0900 W/LFE      (15849): [15849] 26:52:55.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:25.477+0900 W/LFE      (15849): [15849] 26:52:57.554[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:27.979+0900 W/LFE      (15849): [15849] 26:53:00.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:30.471+0900 W/LFE      (15849): [15849] 26:53:02.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:32.984+0900 W/LFE      (15849): [15849] 26:53:05.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:35.466+0900 W/LFE      (15849): [15849] 26:53:07.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:37.969+0900 W/LFE      (15849): [15849] 26:53:10.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:40.471+0900 W/LFE      (15849): [15849] 26:53:12.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:42.974+0900 W/LFE      (15849): [15849] 26:53:15.048[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:45.476+0900 W/LFE      (15849): [15849] 26:53:17.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:47.968+0900 W/LFE      (15849): [15849] 26:53:20.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:50.471+0900 W/LFE      (15849): [15849] 26:53:22.553[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:52.973+0900 W/LFE      (15849): [15849] 26:53:25.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:55.486+0900 W/LFE      (15849): [15849] 26:53:27.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:58:57.968+0900 W/LFE      (15849): [15849] 26:53:30.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:00.471+0900 W/LFE      (15849): [15849] 26:53:32.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:02.973+0900 W/LFE      (15849): [15849] 26:53:35.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:05.486+0900 W/LFE      (15849): [15849] 26:53:37.558[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:07.978+0900 W/LFE      (15849): [15849] 26:53:40.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:10.480+0900 W/LFE      (15849): [15849] 26:53:42.557[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:12.983+0900 W/LFE      (15849): [15849] 26:53:45.057[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:15.465+0900 W/LFE      (15849): [15849] 26:53:47.542[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:16.797+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:59:17.958+0900 W/LFE      (15849): [15849] 26:53:50.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:20.460+0900 W/LFE      (15849): [15849] 26:53:52.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:22.963+0900 W/LFE      (15849): [15849] 26:53:55.045[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:24.124+0900 W/LOCKSCREEN(  845): property.c: _vconf_cb(228) > [_vconf_cb:228:W] property 200 is changed to 88
06-03 00:59:24.124+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:40000:CONF_CHANGED
06-03 00:59:24.124+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:40000 event_info:200
06-03 00:59:24.124+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:40000 event_info:200
06-03 00:59:24.134+0900 E/INDICATOR(  646): battery.c: indicator_battery_update_display(598) > indicator_battery_update_display[598]	 ""
06-03 00:59:25.485+0900 W/LFE      (15849): [15849] 26:53:57.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:27.978+0900 W/LFE      (15849): [15849] 26:54:00.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:30.480+0900 W/LFE      (15849): [15849] 26:54:02.557[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:32.962+0900 W/LFE      (15849): [15849] 26:54:05.042[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:35.465+0900 W/LFE      (15849): [15849] 26:54:07.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:37.957+0900 W/LFE      (15849): [15849] 26:54:10.043[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:40.460+0900 W/LFE      (15849): [15849] 26:54:12.543[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:42.962+0900 W/LFE      (15849): [15849] 26:54:15.045[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:45.475+0900 W/LFE      (15849): [15849] 26:54:17.549[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:45.935+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 00:59:45.935+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 00:59:45.935+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 00:59:45.935+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 00:59:45.935+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:59:45.935+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 00:59:45.945+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:59:45.945+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:59:45.945+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:59:45.945+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:59
06-03 00:59:45.945+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:59"
06-03 00:59:45.945+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:59"
06-03 00:59:45.945+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:59:45.945+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147460035 Time: <font_size=31> </font_size> <font_size=31> 오전 12:59</font_size></font>"
06-03 00:59:45.955+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(8) / batt_Full:(0) / battery_charging(1)"
06-03 00:59:45.955+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 00:59:45.955+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:59:45.955+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:59:45.955+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:59:45.955+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:59:45.955+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:59:46.155+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 00:59:46.155+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 00:59:46.155+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 00:59:46.155+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 00:59:46.155+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:59:46.155+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 00:59:46.155+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 00:59:46.155+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:59:46.155+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:59:46.165+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:59:46.165+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:59:46.175+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:59:46.175+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:59:46.185+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 8276
06-03 00:59:46.185+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:59:46.235+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 8276
06-03 00:59:46.235+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 8276, appid: com.samsung.weather-m-agent
06-03 00:59:46.235+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(8276)
06-03 00:59:46.295+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:59:46.295+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 8276.
06-03 00:59:46.416+0900 E/weather-agent( 8276): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:59:46.426+0900 E/weather-common( 8276): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:59:46.426+0900 E/weather-agent( 8276): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:59:46.426+0900 E/weather-agent( 8276): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:59:46.426+0900 E/weather-common( 8276): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:59:46.426+0900 E/weather-common( 8276): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:59:46.426+0900 E/weather-common( 8276): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:59:46.426+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:59:46.426+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:59:46.426+0900 I/MESSAGE_PORT( 8276): message-port.c: __initialize(872) > initialize
06-03 00:59:46.436+0900 I/MESSAGE_PORT( 8276): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:59:46.466+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:59:46.466+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:59:46.466+0900 I/MESSAGE_PORT( 8276): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:59:46.466+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:59:46.466+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:59:46.466+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:59:46.476+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:59:46.476+0900 E/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:59:46.476+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:59:46.476+0900 E/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:59:46.476+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:59:46.476+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:59:46.486+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:59:46.486+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:59:46.486+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:59:46.486+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:59:46.486+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:59:46.486+0900 I/MESSAGE_PORT( 8276): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:59:46.486+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:59:46.486+0900 I/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:59:46.486+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:59:46.486+0900 I/MESSAGE_PORT( 8276): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:59:46.496+0900 E/MESSAGE_PORT( 8276): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:59:46.496+0900 E/weather-common( 8276): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:59:46.496+0900 E/weather-agent( 8276): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:59:46.496+0900 E/weather-agent( 8276): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:59:46.496+0900 I/MESSAGE_PORT( 8276): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:59:46.496+0900 I/MESSAGE_PORT( 8276): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:59:46.496+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:59:46.526+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:59:46.556+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:59:46.556+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:59:46.566+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:59:46.566+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:59:46.566+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:59:46.566+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:59:46.576+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:59:46.586+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:59:46.606+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:59:46.606+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:59:46.606+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:59:46.606+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:59:46.606+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:59:46.606+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:59:46.616+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:59:46.676+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:59:46.676+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:59:46.836+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=129766832
06-03 00:59:46.956+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=129766952
06-03 00:59:46.956+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:59:46.956+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:59:46.956+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:59:47.286+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:59:47.286+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:59:47.286+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:59:47.286+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:59:47.286+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:59:47.286+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:59:47.286+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:59:47.286+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:59:47.286+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:59:47.286+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:59:47.296+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:59:47.296+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:59:47.296+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:59:47.296+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:59:47.306+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(8002) status(3)
06-03 00:59:47.306+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:59:47.306+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:59:47.316+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(8002)
06-03 00:59:47.316+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 8002, appid: org.example.example, status: fg
06-03 00:59:47.326+0900 I/APP_CORE( 8002): appcore-efl.c: __do_app(514) > [APP 8002] Event: RESUME State: PAUSED
06-03 00:59:47.326+0900 I/CAPI_APPFW_APPLICATION( 8002): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:59:47.336+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:59:47.336+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:59:47.336+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:59:47.336+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:59:47.336+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:59:47.336+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:59:47.336+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:59:47.336+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:59:47.336+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:59:47.336+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:59:47.336+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:59:47.336+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:59:47.346+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:59:47.366+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:59:47.366+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:59:47.376+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:59:47.376+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:59:47.447+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:59:47.447+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:59:47.447+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:59:47.447+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:59:47.447+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:59:47.457+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:59:47.487+0900 E/weather-agent( 8276): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:59:47.487+0900 I/CAPI_APPFW_APPLICATION( 8276): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:59:47.487+0900 E/weather-agent( 8276): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:59:47.487+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:59:47.487+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:59:47.547+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:59:47.607+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:59:47.617+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 8276
06-03 00:59:47.617+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[8276] terminate event is forwarded
06-03 00:59:47.617+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:59:47.617+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 8276, ]
06-03 00:59:47.617+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:59:47.617+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:59:47.617+0900 I/Tizen::App( 1210): (512) > Not registered pid(8276)
06-03 00:59:47.617+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:59:47.617+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:59:47.617+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8276
06-03 00:59:47.617+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:59:47.617+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 8276.
06-03 00:59:47.967+0900 W/LFE      (15849): [15849] 26:54:20.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:59:47.977+0900 E/EFL     ( 8002): ecore_x<8002> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=129767987
06-03 00:59:48.187+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 8002 pgid = 8002
06-03 00:59:48.187+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(8002)
06-03 00:59:48.187+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:59:48.227+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:59:48.227+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:59:48.227+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:59:48.227+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:59:48.227+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:59:48.267+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:59:48.267+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:59:48.267+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:59:48.267+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 8002
06-03 00:59:48.277+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[8002] terminate event is forwarded
06-03 00:59:48.277+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:59:48.277+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 8002, ]
06-03 00:59:48.277+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:59:48.277+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:59:48.277+0900 I/Tizen::App( 1210): (512) > Not registered pid(8002)
06-03 00:59:48.277+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:59:48.277+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:59:48.277+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 8002
06-03 00:59:48.277+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 8002
06-03 00:59:48.277+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3281
06-03 00:59:48.287+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:59:48.297+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:59:48.297+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:59:48.297+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:59:48.297+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:59:48.297+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:59:48.297+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 8002.
06-03 00:59:48.297+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:59:48.327+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:59:48.337+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:59:48.337+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:59:48.337+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:59:48.337+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:59:48.337+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:59:48.337+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:59:48.337+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:59:48.347+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:59:48.347+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:59:48.357+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:59:48.357+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:59:48.357+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:59:48.357+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:59:48.357+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:59:48.407+0900 W/CRASH_MANAGER( 8286): worker.c: worker_job(1199) > 1108002657861149641918
