S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7079
Date: 2017-06-03 00:17:25+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7079, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f59000, r3   = 0xb3f59020
r4   = 0x8001b6dc, r5   = 0xbea5b2a0
r6   = 0xb2844e5d, r7   = 0xbea5b128
r8   = 0x8001b6dc, r9   = 0xb5f3b708
r10  = 0xb885dce8, fp   = 0xbea5b27c
ip   = 0xb602b120, sp   = 0xbea5b0e8
lr   = 0xb5fefbd9, pc   = 0xb2844e86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     39616 KB
Buffers:     15112 KB
Cached:     113460 KB
VmPeak:     128308 KB
VmSize:     127004 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       31348 KB
VmRSS:       30404 KB
VmData:      39156 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:         110 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7079 TID = 7079
7079 7080 7094 7095 

Maps Information
b133d000 b1b3c000 rw-p [stack:7095]
b1bb8000 b1bc0000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bd1000 b1bd2000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1be2000 b1bf6000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c0a000 b1c0b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c1b000 b1c1e000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c2f000 b1c30000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c40000 b1c42000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c52000 b1c54000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c64000 b1c74000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c84000 b1c90000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ca2000 b24a1000 rw-p [stack:7094]
b27d2000 b27d9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27ea000 b27f2000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2802000 b2817000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2829000 b282f000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b283f000 b2847000 r-xp /opt/usr/apps/org.example.example/bin/example
b299f000 b2a82000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ab9000 b2ae1000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2af3000 b32f2000 rw-p [stack:7080]
b32f2000 b32f4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3304000 b330e000 r-xp /lib/libnss_files-2.20-2014.11.so
b331f000 b3328000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3339000 b334a000 r-xp /lib/libnsl-2.20-2014.11.so
b335d000 b3363000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3374000 b3375000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b339d000 b33a4000 r-xp /usr/lib/libminizip.so.1.0.0
b33b4000 b33b9000 r-xp /usr/lib/libstorage.so.0.1
b33c9000 b3428000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b343e000 b3452000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3462000 b34a6000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34b6000 b34be000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ce000 b34fe000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3511000 b35ca000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35de000 b3631000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3642000 b365d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b366d000 b372e000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3741000 b3751000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3761000 b376e000 r-xp /usr/lib/libmdm-common.so.1.0.98
b377f000 b3786000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3796000 b37d7000 r-xp /usr/lib/libmdm.so.1.2.12
b37e7000 b37ef000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37fe000 b380e000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b382f000 b388f000 r-xp /usr/lib/libasound.so.2.0.0
b38a1000 b38a4000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38b4000 b38b7000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38c7000 b38cc000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38dc000 b38dd000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ed000 b38f8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b390c000 b3913000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3923000 b3929000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3939000 b393e000 r-xp /usr/lib/libmmfsession.so.0.0.1
b394e000 b3969000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3979000 b3980000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3990000 b3993000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39a4000 b39d2000 r-xp /usr/lib/libidn.so.11.5.44
b39e2000 b39f8000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a09000 b3a13000 r-xp /usr/lib/libcares.so.2.1.0
b3a23000 b3a2d000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a3d000 b3a3f000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a4f000 b3a50000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a60000 b3a64000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a75000 b3a9d000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aae000 b3ad7000 r-xp /usr/lib/libturbojpeg.so
b3af7000 b3afd000 r-xp /usr/lib/libgif.so.4.1.6
b3b0d000 b3b53000 r-xp /usr/lib/libcurl.so.4.3.0
b3b64000 b3b85000 r-xp /usr/lib/libexif.so.12.3.3
b3ba0000 b3bb5000 r-xp /usr/lib/libtts.so
b3bc6000 b3bce000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bde000 b3ca4000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cc4000 b3dbc000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3ddb000 b3ea9000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ec0000 b3ec2000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ed2000 b3ed8000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ee8000 b3f0b000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f1c000 b3f1e000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f2e000 b3f30000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f41000 b3f46000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f5d000 b3f5f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f6f000 b3f76000 r-xp /usr/lib/libsensord-share.so
b3f86000 b3f9e000 r-xp /usr/lib/libsensor.so.1.1.0
b3faf000 b3fb2000 r-xp /usr/lib/libXv.so.1.0.0
b3fc2000 b3fc7000 r-xp /usr/lib/libutilX.so.1.1.0
b3fd7000 b3fdc000 r-xp /usr/lib/libappcore-common.so.1.1
b3fec000 b3ff3000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4006000 b400a000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b401b000 b40f9000 r-xp /usr/lib/libCOREGL.so.4.0
b4119000 b411c000 r-xp /usr/lib/libuuid.so.1.3.0
b412c000 b4143000 r-xp /usr/lib/libblkid.so.1.1.0
b4154000 b4156000 r-xp /usr/lib/libXau.so.6.0.0
b4166000 b41ad000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41bf000 b41c5000 r-xp /usr/lib/libjson-c.so.2.0.1
b41d6000 b41da000 r-xp /usr/lib/libogg.so.0.7.1
b41ea000 b420c000 r-xp /usr/lib/libvorbis.so.0.4.3
b421c000 b4300000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b431c000 b431f000 r-xp /usr/lib/libEGL.so.1.4
b4330000 b4336000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4346000 b4348000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4358000 b4365000 r-xp /usr/lib/libGLESv2.so.2.0
b4376000 b43d8000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ed000 b4405000 r-xp /usr/lib/libmount.so.1.1.0
b4417000 b442b000 r-xp /usr/lib/libxcb.so.1.1.0
b443b000 b4442000 r-xp /lib/libcrypt-2.20-2014.11.so
b447a000 b447c000 r-xp /usr/lib/libiri.so
b448c000 b4497000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44a8000 b44de000 r-xp /usr/lib/libpulse.so.0.16.2
b44ef000 b4532000 r-xp /usr/lib/libsndfile.so.1.0.25
b4547000 b455c000 r-xp /lib/libexpat.so.1.5.2
b456e000 b462c000 r-xp /usr/lib/libcairo.so.2.11200.14
b4640000 b4648000 r-xp /usr/lib/libdrm.so.2.4.0
b4658000 b465b000 r-xp /usr/lib/libdri2.so.0.0.0
b466b000 b46b9000 r-xp /usr/lib/libssl.so.1.0.0
b46ce000 b46da000 r-xp /usr/lib/libeeze.so.1.13.0
b46eb000 b46f4000 r-xp /usr/lib/libethumb.so.1.13.0
b4704000 b4707000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4717000 b48ce000 r-xp /usr/lib/libcrypto.so.1.0.0
b56b9000 b56c2000 r-xp /usr/lib/libXi.so.6.1.0
b56d2000 b56d4000 r-xp /usr/lib/libXgesture.so.7.0.0
b56e4000 b56e8000 r-xp /usr/lib/libXtst.so.6.1.0
b56f8000 b56fe000 r-xp /usr/lib/libXrender.so.1.3.0
b570e000 b5714000 r-xp /usr/lib/libXrandr.so.2.2.0
b5724000 b5726000 r-xp /usr/lib/libXinerama.so.1.0.0
b5737000 b573a000 r-xp /usr/lib/libXfixes.so.3.1.0
b574a000 b5755000 r-xp /usr/lib/libXext.so.6.4.0
b5765000 b5767000 r-xp /usr/lib/libXdamage.so.1.1.0
b5777000 b5779000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5789000 b586b000 r-xp /usr/lib/libX11.so.6.3.0
b587f000 b5886000 r-xp /usr/lib/libXcursor.so.1.0.2
b5896000 b58ae000 r-xp /usr/lib/libudev.so.1.6.0
b58b0000 b58b3000 r-xp /lib/libattr.so.1.1.0
b58c3000 b58e3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58e4000 b58e9000 r-xp /usr/lib/libffi.so.6.0.2
b58fa000 b5912000 r-xp /lib/libz.so.1.2.8
b5922000 b5924000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5934000 b5a09000 r-xp /usr/lib/libxml2.so.2.9.2
b5a1e000 b5ab9000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ad5000 b5ad8000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ae8000 b5b01000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b12000 b5b23000 r-xp /lib/libresolv-2.20-2014.11.so
b5b37000 b5bb1000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bc6000 b5bc8000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bd8000 b5bdf000 r-xp /usr/lib/libembryo.so.1.13.0
b5bef000 b5bf9000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c0a000 b5c22000 r-xp /usr/lib/libpng12.so.0.50.0
b5c33000 b5c56000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c77000 b5c8b000 r-xp /usr/lib/libector.so.1.13.0
b5c9c000 b5cb4000 r-xp /usr/lib/liblua-5.1.so
b5cc5000 b5d1c000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d30000 b5d58000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d69000 b5d7c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d8d000 b5dc7000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dd8000 b5de6000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5df6000 b5dfe000 r-xp /usr/lib/libtbm.so.1.0.0
b5e0e000 b5e1b000 r-xp /usr/lib/libeio.so.1.13.0
b5e2b000 b5e2d000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e3d000 b5e42000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e52000 b5e69000 r-xp /usr/lib/libefreet.so.1.13.0
b5e7b000 b5e9b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5eab000 b5ecb000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ecd000 b5ed3000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ee3000 b5ef4000 r-xp /usr/lib/libemotion.so.1.13.0
b5f05000 b5f0c000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f1c000 b5f2b000 r-xp /usr/lib/libeo.so.1.13.0
b5f3c000 b5f4e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f5f000 b5f64000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f74000 b5f8d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f9d000 b5fba000 r-xp /usr/lib/libeet.so.1.13.0
b5fd3000 b601b000 r-xp /usr/lib/libeina.so.1.13.0
b602c000 b603c000 r-xp /usr/lib/libefl.so.1.13.0
b604d000 b6132000 r-xp /usr/lib/libicuuc.so.51.1
b614f000 b628f000 r-xp /usr/lib/libicui18n.so.51.1
b62a6000 b62de000 r-xp /usr/lib/libecore_x.so.1.13.0
b62f0000 b62f3000 r-xp /lib/libcap.so.2.21
b6303000 b632c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b633d000 b6344000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6356000 b638d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b639e000 b6489000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b649c000 b6515000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6527000 b652c000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b653c000 b6546000 r-xp /usr/lib/libvconf.so.0.2.45
b6556000 b6558000 r-xp /usr/lib/libvasum.so.0.3.1
b6568000 b656a000 r-xp /usr/lib/libttrace.so.1.1
b657a000 b657d000 r-xp /usr/lib/libiniparser.so.0
b658d000 b65b3000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65c3000 b65c8000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65d9000 b65f0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6601000 b666c000 r-xp /lib/libm-2.20-2014.11.so
b667d000 b6683000 r-xp /lib/librt-2.20-2014.11.so
b6694000 b66a1000 r-xp /usr/lib/libunwind.so.8.0.1
b66d7000 b67fb000 r-xp /lib/libc-2.20-2014.11.so
b6810000 b6829000 r-xp /lib/libgcc_s-4.9.so.1
b6839000 b691b000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b692c000 b6956000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6967000 b69a3000 r-xp /usr/lib/libsystemd.so.0.4.0
b69a5000 b6a28000 r-xp /usr/lib/libedje.so.1.13.0
b6a3b000 b6a59000 r-xp /usr/lib/libecore.so.1.13.0
b6a79000 b6c00000 r-xp /usr/lib/libevas.so.1.13.0
b6c35000 b6c49000 r-xp /lib/libpthread-2.20-2014.11.so
b6c5d000 b6e91000 r-xp /usr/lib/libelementary.so.1.13.0
b6ec0000 b6ec4000 r-xp /usr/lib/libsmack.so.1.0.0
b6ed4000 b6edb000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eeb000 b6eed000 r-xp /usr/lib/libdlog.so.0.0.0
b6efd000 b6f00000 r-xp /usr/lib/libbundle.so.0.1.22
b6f10000 b6f12000 r-xp /lib/libdl-2.20-2014.11.so
b6f23000 b6f3b000 r-xp /usr/lib/libaul.so.0.1.0
b6f4f000 b6f54000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f65000 b6f72000 r-xp /usr/lib/liblptcp.so
b6f84000 b6f88000 r-xp /usr/lib/libsys-assert.so
b6f99000 b6fb9000 r-xp /lib/ld-2.20-2014.11.so
b6fca000 b6fcf000 r-xp /usr/bin/launchpad-loader
b85f3000 b8a7f000 rw-p [heap]
bea3b000 bea5c000 rw-p [stack]
bea3b000 bea5c000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7079)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb2844e86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6aae175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f27219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f25fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6aae515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6ab6725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6abbf6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6abf939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb4706173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a46c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a4ca5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a4cc83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f522bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb4008909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2844673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6fcbbb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66ed4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fcbeb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
00:17:13.995+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:17:13.995+0900 I/Tizen::App( 1210): (512) > Not registered pid(6807)
06-03 00:17:13.995+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:17:13.995+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:13.995+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6807
06-03 00:17:13.995+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6807
06-03 00:17:13.995+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6807
06-03 00:17:14.005+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:17:14.015+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:17:14.015+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:14.015+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:17:14.015+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:14.015+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:14.015+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 6807.
06-03 00:17:14.025+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:14.035+0900 E/weather-agent( 7051): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:17:14.035+0900 I/CAPI_APPFW_APPLICATION( 7051): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:17:14.045+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:17:14.045+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:17:14.045+0900 E/weather-agent( 7051): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:17:14.045+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:17:14.045+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:14.095+0900 W/CRASH_MANAGER( 7060): worker.c: worker_job(1199) > 11068076578611496416633
06-03 00:17:14.115+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:14.125+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:17:14.296+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:17:14.326+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7051
06-03 00:17:14.326+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[7051] terminate event is forwarded
06-03 00:17:14.326+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:17:14.326+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7051, ]
06-03 00:17:14.326+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:17:14.326+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:17:14.326+0900 I/Tizen::App( 1210): (512) > Not registered pid(7051)
06-03 00:17:14.326+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:17:14.336+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:14.336+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7051
06-03 00:17:14.346+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:14.346+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7051.
06-03 00:17:14.356+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:17:14.706+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127214704
06-03 00:17:14.796+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127214791
06-03 00:17:14.806+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:17:14.806+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:17:14.806+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:17:14.816+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:17:14.826+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:17:14.826+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:17:14.826+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:17:14.826+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:17:14.856+0900 I/CAPI_APPFW_APPLICATION( 7048): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:17:14.856+0900 I/CAPI_APPFW_APPLICATION( 7048): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:17:14.896+0900 E/TBM     ( 7048): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:17:14.926+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7048, appid: org.example.example
06-03 00:17:14.926+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:17:14.936+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7048)
06-03 00:17:15.106+0900 I/APP_CORE( 7048): appcore-efl.c: __do_app(514) > [APP 7048] Event: RESET State: CREATED
06-03 00:17:15.106+0900 I/CAPI_APPFW_APPLICATION( 7048): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:17:15.106+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.106+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.106+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.106+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.116+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.116+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.116+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.116+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.116+0900 E/EFL     ( 7048): edje<7048> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:15.116+0900 E/EFL     ( 7048): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:15.146+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:15.146+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:15.176+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:15.187+0900 W/APP_CORE( 7048): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:17:15.197+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:17:15.197+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:17:15.197+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:15.197+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:15.307+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:17:15.307+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:17:15.307+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:17:15.307+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:17:15.307+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:17:15.307+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:17:15.307+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7048) status(3)
06-03 00:17:15.317+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7048)
06-03 00:17:15.317+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7048, appid: org.example.example, status: fg
06-03 00:17:15.327+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:17:15.327+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:17:15.327+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:17:15.327+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:17:15.347+0900 I/APP_CORE( 7048): appcore-efl.c: __do_app(514) > [APP 7048] Event: RESUME State: CREATED
06-03 00:17:15.357+0900 I/APP_CORE( 7048): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:17:15.357+0900 I/APP_CORE( 7048): appcore-efl.c: __do_app(625) > [APP 7048] Initial Launching, call the resume_cb
06-03 00:17:15.357+0900 I/CAPI_APPFW_APPLICATION( 7048): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:15.467+0900 W/LFE      (15849): [15849] 26:11:47.546[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:15.667+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7048) status(0)
06-03 00:17:15.947+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3195
06-03 00:17:15.957+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:17:15.957+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7048.
06-03 00:17:15.977+0900 E/EFL     ( 7048): ecore_x<7048> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127215985
06-03 00:17:16.037+0900 E/EFL     ( 7048): ecore_x<7048> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127216039
06-03 00:17:16.738+0900 I/UXT     ( 7079): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:17:17.279+0900 E/EFL     ( 7048): ecore_x<7048> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127217281
06-03 00:17:17.439+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7048 pgid = 7048
06-03 00:17:17.439+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7048)
06-03 00:17:17.439+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:17.449+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:17:17.449+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:17:17.449+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:17:17.449+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:17:17.449+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:17:17.499+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:17:17.499+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:17:17.499+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:17:17.499+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7048] terminate event is forwarded
06-03 00:17:17.499+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:17:17.499+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7048, ]
06-03 00:17:17.499+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:17:17.499+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:17:17.499+0900 I/Tizen::App( 1210): (512) > Not registered pid(7048)
06-03 00:17:17.499+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:17:17.499+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7048
06-03 00:17:17.499+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:17.509+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7048
06-03 00:17:17.509+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7048
06-03 00:17:17.509+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3198
06-03 00:17:17.509+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:17:17.519+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:17:17.519+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:17.519+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:17:17.519+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:17:17.519+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:17.519+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:17.519+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7048.
06-03 00:17:17.539+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:17:17.539+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:17:17.539+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:17.549+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:17.559+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:17.569+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:17:17.579+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:17:17.579+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:17:17.589+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:17.589+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:17:17.589+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:17:17.589+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:17:17.589+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:17:17.589+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:17:17.589+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:17:17.609+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:17.679+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:17:17.679+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:17:17.969+0900 W/LFE      (15849): [15849] 26:11:50.046[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:18.229+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127218235
06-03 00:17:18.290+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127218289
06-03 00:17:18.290+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:17:18.290+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:17:18.290+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:17:18.310+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:17:18.310+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:17:18.310+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:17:18.310+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:17:18.310+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:17:18.350+0900 I/CAPI_APPFW_APPLICATION( 7079): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:17:18.350+0900 I/CAPI_APPFW_APPLICATION( 7079): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:17:18.410+0900 E/TBM     ( 7079): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:17:18.420+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7079, appid: org.example.example
06-03 00:17:18.420+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:17:18.420+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7079)
06-03 00:17:18.500+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:17:18.610+0900 I/APP_CORE( 7079): appcore-efl.c: __do_app(514) > [APP 7079] Event: RESET State: CREATED
06-03 00:17:18.610+0900 I/CAPI_APPFW_APPLICATION( 7079): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:17:18.610+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.610+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.620+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.620+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.620+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.620+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.620+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.620+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.620+0900 E/EFL     ( 7079): edje<7079> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:18.620+0900 E/EFL     ( 7079): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:18.650+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:18.650+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:18.660+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:18.670+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:17:18.670+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:18.680+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:18.700+0900 W/APP_CORE( 7079): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:17:18.700+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:17:18.820+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:17:18.820+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:17:18.820+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:17:18.820+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:17:18.820+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:17:18.820+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:17:18.820+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7079) status(3)
06-03 00:17:18.830+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7079)
06-03 00:17:18.830+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7079, appid: org.example.example, status: fg
06-03 00:17:18.840+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:17:18.840+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:17:18.840+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:17:18.840+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:17:18.870+0900 I/APP_CORE( 7079): appcore-efl.c: __do_app(514) > [APP 7079] Event: RESUME State: CREATED
06-03 00:17:18.880+0900 I/APP_CORE( 7079): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:17:18.880+0900 I/APP_CORE( 7079): appcore-efl.c: __do_app(625) > [APP 7079] Initial Launching, call the resume_cb
06-03 00:17:18.880+0900 I/CAPI_APPFW_APPLICATION( 7079): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:19.040+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:17:19.180+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7079) status(0)
06-03 00:17:19.351+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127219337
06-03 00:17:19.351+0900 I/example ( 7079): m
06-03 00:17:19.401+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127219402
06-03 00:17:19.461+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:17:19.461+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7079.
06-03 00:17:19.461+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3199
06-03 00:17:20.322+0900 I/UXT     ( 7097): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:17:20.462+0900 W/LFE      (15849): [15849] 26:11:52.545[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:21.373+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127221372
06-03 00:17:21.423+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127221426
06-03 00:17:21.993+0900 W/CRASH_MANAGER( 7060): worker.c: worker_job(1199) > 11070486578611496416637
06-03 00:17:22.343+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=127222303
06-03 00:17:22.343+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=127222344
06-03 00:17:22.343+0900 E/EFL     ( 7079): elementary<7079> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
06-03 00:17:22.974+0900 W/LFE      (15849): [15849] 26:11:55.054[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:22.974+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:17:23.084+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127223083
06-03 00:17:23.114+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_value_string(543) > Enter [system_settings_get_value_string]
06-03 00:17:23.114+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
06-03 00:17:23.114+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
06-03 00:17:23.114+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
06-03 00:17:23.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_value_string(543) > Enter [system_settings_get_value_string]
06-03 00:17:23.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
06-03 00:17:23.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
06-03 00:17:23.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
06-03 00:17:23.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_value_string(543) > Enter [system_settings_get_value_string]
06-03 00:17:23.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_value(404) > Enter [system_settings_get_value]
06-03 00:17:23.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_item(379) > Enter [system_settings_get_item], key=15
06-03 00:17:23.415+0900 E/TIZEN_N_SYSTEM_SETTINGS( 7079): system_settings.c: system_settings_get_item(392) > Enter [system_settings_get_item], index = 14, key = 15, type = 0
06-03 00:17:23.495+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127223159
06-03 00:17:23.835+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
06-03 00:17:24.616+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=127224594
06-03 00:17:24.616+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=127224618
06-03 00:17:24.626+0900 E/EFL     ( 7079): elementary<7079> elc_naviframe.c:1715 _tizen_pop_effect() [DDO]
06-03 00:17:25.186+0900 E/EFL     ( 7079): ecore_x<7079> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127225184
06-03 00:17:25.346+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7079 pgid = 7079
06-03 00:17:25.346+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7079)
06-03 00:17:25.346+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:25.396+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:17:25.396+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:17:25.396+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:17:25.406+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7079] terminate event is forwarded
06-03 00:17:25.406+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:17:25.406+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7079, ]
06-03 00:17:25.406+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:17:25.406+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:17:25.406+0900 I/Tizen::App( 1210): (512) > Not registered pid(7079)
06-03 00:17:25.406+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:17:25.406+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:25.406+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7079
06-03 00:17:25.406+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7079
06-03 00:17:25.406+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7079
06-03 00:17:25.416+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3202
06-03 00:17:25.416+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:17:25.416+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:17:25.416+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:17:25.416+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:17:25.416+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:17:25.426+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:17:25.426+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:17:25.426+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:25.426+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7079.
06-03 00:17:25.437+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:17:25.437+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:25.437+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:17:25.437+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:25.447+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:17:25.467+0900 W/LFE      (15849): [15849] 26:11:57.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:25.467+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:17:25.467+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:17:25.467+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:17:25.467+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:17:25.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:17:25.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:17:25.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:25.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:25.467+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:25.477+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:25.477+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:17:25.487+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:25.487+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:17:25.487+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:17:25.487+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:17:25.487+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:17:25.487+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:17:25.487+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:25.507+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:25.567+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:17:25.577+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:17:26.558+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127226564
06-03 00:17:26.628+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127226629
06-03 00:17:26.628+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:17:26.628+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:17:26.628+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:17:26.638+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:17:26.638+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:17:26.648+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:17:26.648+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:17:26.648+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:17:26.668+0900 I/CAPI_APPFW_APPLICATION( 7097): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:17:26.668+0900 I/CAPI_APPFW_APPLICATION( 7097): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:17:26.698+0900 E/TBM     ( 7097): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:17:26.748+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7097, appid: org.example.example
06-03 00:17:26.748+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:17:26.748+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7097)
06-03 00:17:26.868+0900 I/APP_CORE( 7097): appcore-efl.c: __do_app(514) > [APP 7097] Event: RESET State: CREATED
06-03 00:17:26.868+0900 I/CAPI_APPFW_APPLICATION( 7097): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:17:26.868+0900 E/EFL     ( 7097): edje<7097> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:26.868+0900 E/EFL     ( 7097): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:26.868+0900 E/EFL     ( 7097): edje<7097> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:26.868+0900 E/EFL     ( 7097): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:26.878+0900 E/EFL     ( 7097): edje<7097> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:26.878+0900 E/EFL     ( 7097): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:26.878+0900 E/EFL     ( 7097): edje<7097> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:26.878+0900 E/EFL     ( 7097): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:26.878+0900 E/EFL     ( 7097): edje<7097> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:26.878+0900 E/EFL     ( 7097): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:26.908+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:26.908+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:26.918+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:26.938+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:17:26.938+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:26.938+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:26.948+0900 W/APP_CORE( 7097): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:17:26.958+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:17:27.068+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:17:27.068+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:17:27.068+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:17:27.068+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:17:27.068+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:17:27.068+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:17:27.068+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7097) status(3)
06-03 00:17:27.068+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7097)
06-03 00:17:27.068+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7097, appid: org.example.example, status: fg
06-03 00:17:27.088+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:17:27.088+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:17:27.088+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:17:27.088+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:17:27.108+0900 I/APP_CORE( 7097): appcore-efl.c: __do_app(514) > [APP 7097] Event: RESUME State: CREATED
06-03 00:17:27.118+0900 I/APP_CORE( 7097): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:17:27.118+0900 I/APP_CORE( 7097): appcore-efl.c: __do_app(625) > [APP 7097] Initial Launching, call the resume_cb
06-03 00:17:27.118+0900 I/CAPI_APPFW_APPLICATION( 7097): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:27.428+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7097) status(0)
06-03 00:17:27.779+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3203
06-03 00:17:27.789+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:17:27.789+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7097.
06-03 00:17:27.969+0900 W/LFE      (15849): [15849] 26:12:00.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:28.610+0900 I/UXT     ( 7153): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:17:29.510+0900 E/EFL     ( 7097): ecore_x<7097> lib/ecore_x/xlib/ecore_x_events.c:372 _ecore_key_press() Ecore KeyEvent:press time=127229516
06-03 00:17:29.671+0900 E/EFL     ( 7097): ecore_x<7097> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=127229673
06-03 00:17:29.681+0900 E/VOLUME  (  858): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
06-03 00:17:29.681+0900 E/VOLUME  (  858): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
06-03 00:17:29.681+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 2
06-03 00:17:29.691+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(168) > [_dbus_message_recv_cb:168:W] PRE_LCD_OFF cause[powerkey] (status:3)
06-03 00:17:29.691+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_cb(64) > [_lcd_off_cb:64:W] Dbus LCD off:powerkey
06-03 00:17:29.691+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30000:LCD_WILL_OFF
06-03 00:17:29.691+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30000 event_info:0
06-03 00:17:29.691+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:17:29.691+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] HIDE => WILL RESUME
06-03 00:17:29.691+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, 0x2, 0xbe8305a0
06-03 00:17:29.691+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [2]
06-03 00:17:29.691+0900 I/CAPI_NETWORK_CONNECTION(27388): connection.c: connection_get_type(463) > Connected Network = 0
06-03 00:17:29.701+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:17:29.701+0900 W/UI_GADGET(27388): manager.c: ugman_pause(1092) > [34mugman_pause failed: no root[0m
06-03 00:17:29.701+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:17:29.701+0900 W/APP_CORE( 7097): appcore-efl.c: __cmsg_cb(1038) > LCD Off. Pause the topmost app
06-03 00:17:29.701+0900 I/APP_CORE( 7097): appcore-efl.c: __do_app(514) > [APP 7097] Event: PAUSE State: RUNNING
06-03 00:17:29.701+0900 I/CAPI_APPFW_APPLICATION( 7097): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:17:29.701+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
06-03 00:17:29.701+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(62) > [_lock_state_timer_cb:62:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LAUNCHING_LOCK ##########
06-03 00:17:29.701+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:5
06-03 00:17:29.701+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => WILL PAUSE
06-03 00:17:29.711+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:17:29.711+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:17:29.711+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:17:29.711+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:17:29.711+0900 W/CRASH_MANAGER( 7060): worker.c: worker_job(1199) > 1107079657861149641664
