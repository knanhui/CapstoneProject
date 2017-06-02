S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 6053
Date: 2017-06-03 00:12:51+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6053, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f75000, r3   = 0xb3f75020
r4   = 0x8001b6dc, r5   = 0xbee552a0
r6   = 0xb2860e5d, r7   = 0xbee55128
r8   = 0x8001b6dc, r9   = 0xb5f57708
r10  = 0xb8022df0, fp   = 0xbee5527c
ip   = 0xb6047120, sp   = 0xbee550e8
lr   = 0xb600bbd9, pc   = 0xb2860e86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     41240 KB
Buffers:     13172 KB
Cached:     113676 KB
VmPeak:     111648 KB
VmSize:     103056 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29004 KB
VmRSS:       27132 KB
VmData:      28988 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          86 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6053 TID = 6053
6053 6054 6621 

Maps Information
b1bd4000 b1bdc000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bed000 b1bee000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bfe000 b1c12000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c26000 b1c27000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c37000 b1c3a000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c4b000 b1c4c000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c5c000 b1c5e000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c6e000 b1c70000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c80000 b1c90000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1ca0000 b1cac000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cbe000 b24bd000 rw-p [stack:6621]
b27ee000 b27f5000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2806000 b280e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b281e000 b2833000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2845000 b284b000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b285b000 b2863000 r-xp /opt/usr/apps/org.example.example/bin/example
b29bb000 b2a9e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ad5000 b2afd000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b0f000 b330e000 rw-p [stack:6054]
b330e000 b3310000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3320000 b332a000 r-xp /lib/libnss_files-2.20-2014.11.so
b333b000 b3344000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3355000 b3366000 r-xp /lib/libnsl-2.20-2014.11.so
b3379000 b337f000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3390000 b3391000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33b9000 b33c0000 r-xp /usr/lib/libminizip.so.1.0.0
b33d0000 b33d5000 r-xp /usr/lib/libstorage.so.0.1
b33e5000 b3444000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b345a000 b346e000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b347e000 b34c2000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34d2000 b34da000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34ea000 b351a000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b352d000 b35e6000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35fa000 b364d000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b365e000 b3679000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3689000 b374a000 r-xp /usr/lib/libprotobuf.so.9.0.1
b375d000 b376d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b377d000 b378a000 r-xp /usr/lib/libmdm-common.so.1.0.98
b379b000 b37a2000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37b2000 b37f3000 r-xp /usr/lib/libmdm.so.1.2.12
b3803000 b380b000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b381a000 b382a000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b384b000 b38ab000 r-xp /usr/lib/libasound.so.2.0.0
b38bd000 b38c0000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38d0000 b38d3000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38e3000 b38e8000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38f8000 b38f9000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3909000 b3914000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3928000 b392f000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b393f000 b3945000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3955000 b395a000 r-xp /usr/lib/libmmfsession.so.0.0.1
b396a000 b3985000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3995000 b399c000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39ac000 b39af000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39c0000 b39ee000 r-xp /usr/lib/libidn.so.11.5.44
b39fe000 b3a14000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a25000 b3a2f000 r-xp /usr/lib/libcares.so.2.1.0
b3a3f000 b3a49000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a59000 b3a5b000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a6b000 b3a6c000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a7c000 b3a80000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a91000 b3ab9000 r-xp /usr/lib/libui-extension.so.0.1.0
b3aca000 b3af3000 r-xp /usr/lib/libturbojpeg.so
b3b13000 b3b19000 r-xp /usr/lib/libgif.so.4.1.6
b3b29000 b3b6f000 r-xp /usr/lib/libcurl.so.4.3.0
b3b80000 b3ba1000 r-xp /usr/lib/libexif.so.12.3.3
b3bbc000 b3bd1000 r-xp /usr/lib/libtts.so
b3be2000 b3bea000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bfa000 b3cc0000 r-xp /usr/lib/libdali-core.so.0.0.0
b3ce0000 b3dd8000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3df7000 b3ec5000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3edc000 b3ede000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eee000 b3ef4000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f04000 b3f27000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f38000 b3f3a000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f4a000 b3f4c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f5d000 b3f62000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f79000 b3f7b000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f8b000 b3f92000 r-xp /usr/lib/libsensord-share.so
b3fa2000 b3fba000 r-xp /usr/lib/libsensor.so.1.1.0
b3fcb000 b3fce000 r-xp /usr/lib/libXv.so.1.0.0
b3fde000 b3fe3000 r-xp /usr/lib/libutilX.so.1.1.0
b3ff3000 b3ff8000 r-xp /usr/lib/libappcore-common.so.1.1
b4008000 b400f000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b4022000 b4026000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4037000 b4115000 r-xp /usr/lib/libCOREGL.so.4.0
b4135000 b4138000 r-xp /usr/lib/libuuid.so.1.3.0
b4148000 b415f000 r-xp /usr/lib/libblkid.so.1.1.0
b4170000 b4172000 r-xp /usr/lib/libXau.so.6.0.0
b4182000 b41c9000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41db000 b41e1000 r-xp /usr/lib/libjson-c.so.2.0.1
b41f2000 b41f6000 r-xp /usr/lib/libogg.so.0.7.1
b4206000 b4228000 r-xp /usr/lib/libvorbis.so.0.4.3
b4238000 b431c000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4338000 b433b000 r-xp /usr/lib/libEGL.so.1.4
b434c000 b4352000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4362000 b4364000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4374000 b4381000 r-xp /usr/lib/libGLESv2.so.2.0
b4392000 b43f4000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4409000 b4421000 r-xp /usr/lib/libmount.so.1.1.0
b4433000 b4447000 r-xp /usr/lib/libxcb.so.1.1.0
b4457000 b445e000 r-xp /lib/libcrypt-2.20-2014.11.so
b4496000 b4498000 r-xp /usr/lib/libiri.so
b44a8000 b44b3000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44c4000 b44fa000 r-xp /usr/lib/libpulse.so.0.16.2
b450b000 b454e000 r-xp /usr/lib/libsndfile.so.1.0.25
b4563000 b4578000 r-xp /lib/libexpat.so.1.5.2
b458a000 b4648000 r-xp /usr/lib/libcairo.so.2.11200.14
b465c000 b4664000 r-xp /usr/lib/libdrm.so.2.4.0
b4674000 b4677000 r-xp /usr/lib/libdri2.so.0.0.0
b4687000 b46d5000 r-xp /usr/lib/libssl.so.1.0.0
b46ea000 b46f6000 r-xp /usr/lib/libeeze.so.1.13.0
b4707000 b4710000 r-xp /usr/lib/libethumb.so.1.13.0
b4720000 b4723000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4733000 b48ea000 r-xp /usr/lib/libcrypto.so.1.0.0
b56d5000 b56de000 r-xp /usr/lib/libXi.so.6.1.0
b56ee000 b56f0000 r-xp /usr/lib/libXgesture.so.7.0.0
b5700000 b5704000 r-xp /usr/lib/libXtst.so.6.1.0
b5714000 b571a000 r-xp /usr/lib/libXrender.so.1.3.0
b572a000 b5730000 r-xp /usr/lib/libXrandr.so.2.2.0
b5740000 b5742000 r-xp /usr/lib/libXinerama.so.1.0.0
b5753000 b5756000 r-xp /usr/lib/libXfixes.so.3.1.0
b5766000 b5771000 r-xp /usr/lib/libXext.so.6.4.0
b5781000 b5783000 r-xp /usr/lib/libXdamage.so.1.1.0
b5793000 b5795000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57a5000 b5887000 r-xp /usr/lib/libX11.so.6.3.0
b589b000 b58a2000 r-xp /usr/lib/libXcursor.so.1.0.2
b58b2000 b58ca000 r-xp /usr/lib/libudev.so.1.6.0
b58cc000 b58cf000 r-xp /lib/libattr.so.1.1.0
b58df000 b58ff000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5900000 b5905000 r-xp /usr/lib/libffi.so.6.0.2
b5916000 b592e000 r-xp /lib/libz.so.1.2.8
b593e000 b5940000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5950000 b5a25000 r-xp /usr/lib/libxml2.so.2.9.2
b5a3a000 b5ad5000 r-xp /usr/lib/libstdc++.so.6.0.20
b5af1000 b5af4000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b04000 b5b1d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b2e000 b5b3f000 r-xp /lib/libresolv-2.20-2014.11.so
b5b53000 b5bcd000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5be2000 b5be4000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bf4000 b5bfb000 r-xp /usr/lib/libembryo.so.1.13.0
b5c0b000 b5c15000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c26000 b5c3e000 r-xp /usr/lib/libpng12.so.0.50.0
b5c4f000 b5c72000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c93000 b5ca7000 r-xp /usr/lib/libector.so.1.13.0
b5cb8000 b5cd0000 r-xp /usr/lib/liblua-5.1.so
b5ce1000 b5d38000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d4c000 b5d74000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d85000 b5d98000 r-xp /usr/lib/libfribidi.so.0.3.1
b5da9000 b5de3000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5df4000 b5e02000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e12000 b5e1a000 r-xp /usr/lib/libtbm.so.1.0.0
b5e2a000 b5e37000 r-xp /usr/lib/libeio.so.1.13.0
b5e47000 b5e49000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e59000 b5e5e000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e6e000 b5e85000 r-xp /usr/lib/libefreet.so.1.13.0
b5e97000 b5eb7000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ec7000 b5ee7000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ee9000 b5eef000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5eff000 b5f10000 r-xp /usr/lib/libemotion.so.1.13.0
b5f21000 b5f28000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f38000 b5f47000 r-xp /usr/lib/libeo.so.1.13.0
b5f58000 b5f6a000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f7b000 b5f80000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f90000 b5fa9000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fb9000 b5fd6000 r-xp /usr/lib/libeet.so.1.13.0
b5fef000 b6037000 r-xp /usr/lib/libeina.so.1.13.0
b6048000 b6058000 r-xp /usr/lib/libefl.so.1.13.0
b6069000 b614e000 r-xp /usr/lib/libicuuc.so.51.1
b616b000 b62ab000 r-xp /usr/lib/libicui18n.so.51.1
b62c2000 b62fa000 r-xp /usr/lib/libecore_x.so.1.13.0
b630c000 b630f000 r-xp /lib/libcap.so.2.21
b631f000 b6348000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6359000 b6360000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6372000 b63a9000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63ba000 b64a5000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64b8000 b6531000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6543000 b6548000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6558000 b6562000 r-xp /usr/lib/libvconf.so.0.2.45
b6572000 b6574000 r-xp /usr/lib/libvasum.so.0.3.1
b6584000 b6586000 r-xp /usr/lib/libttrace.so.1.1
b6596000 b6599000 r-xp /usr/lib/libiniparser.so.0
b65a9000 b65cf000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65df000 b65e4000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65f5000 b660c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b661d000 b6688000 r-xp /lib/libm-2.20-2014.11.so
b6699000 b669f000 r-xp /lib/librt-2.20-2014.11.so
b66b0000 b66bd000 r-xp /usr/lib/libunwind.so.8.0.1
b66f3000 b6817000 r-xp /lib/libc-2.20-2014.11.so
b682c000 b6845000 r-xp /lib/libgcc_s-4.9.so.1
b6855000 b6937000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6948000 b6972000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6983000 b69bf000 r-xp /usr/lib/libsystemd.so.0.4.0
b69c1000 b6a44000 r-xp /usr/lib/libedje.so.1.13.0
b6a57000 b6a75000 r-xp /usr/lib/libecore.so.1.13.0
b6a95000 b6c1c000 r-xp /usr/lib/libevas.so.1.13.0
b6c51000 b6c65000 r-xp /lib/libpthread-2.20-2014.11.so
b6c79000 b6ead000 r-xp /usr/lib/libelementary.so.1.13.0
b6edc000 b6ee0000 r-xp /usr/lib/libsmack.so.1.0.0
b6ef0000 b6ef7000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f07000 b6f09000 r-xp /usr/lib/libdlog.so.0.0.0
b6f19000 b6f1c000 r-xp /usr/lib/libbundle.so.0.1.22
b6f2c000 b6f2e000 r-xp /lib/libdl-2.20-2014.11.so
b6f3f000 b6f57000 r-xp /usr/lib/libaul.so.0.1.0
b6f6b000 b6f70000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f81000 b6f8e000 r-xp /usr/lib/liblptcp.so
b6fa0000 b6fa4000 r-xp /usr/lib/libsys-assert.so
b6fb5000 b6fd5000 r-xp /lib/ld-2.20-2014.11.so
b6fe6000 b6feb000 r-xp /usr/bin/launchpad-loader
b7db8000 b8070000 rw-p [heap]
bee35000 bee56000 rw-p [stack]
bee35000 bee56000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6053)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb2860e86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6aca175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f43219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f41fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6aca515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6ad2725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6ad7f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6adb939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb4722173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a62c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a68a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a68c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f6e2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb4024909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2860673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6fe7bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb67094bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fe7eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
o.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 2
06-03 00:12:39.468+0900 E/PKGMGR_CERT( 6557): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-03 00:12:39.468+0900 E/rpm-installer( 6557): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.example/lib]
06-03 00:12:39.478+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 60
06-03 00:12:39.478+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [60]
06-03 00:12:39.478+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [60], install = [1]
06-03 00:12:39.478+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:39.478+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:39.478+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:39.478+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:39.498+0900 E/rpm-installer( 6557): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 00:12:39.528+0900 E/rpm-installer( 6557): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-03 00:12:39.528+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 100
06-03 00:12:39.528+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [100]
06-03 00:12:39.528+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [100], install = [1]
06-03 00:12:39.528+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:39.528+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:39.528+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:39.528+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:39.998+0900 E/PKGMGR_SERVER( 6546): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 00:12:40.468+0900 W/LFE      (15849): [15849] 26:07:12.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:41.389+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 00:12:41.389+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 00:12:41.389+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 00:12:41.389+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:41.389+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:41.389+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 00:12:41.389+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:41.389+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:12:41.389+0900 I/Tizen::App( 1210): (78) > Installation is Completed. [Package = org.example.example]
06-03 00:12:41.389+0900 I/Tizen::App( 1210): (671) > Enter. package(org.example.example), installationResult(0)
06-03 00:12:41.389+0900 I/Tizen::App( 1210): (1360) > package(org.example.example), version(1.0.0), type(tpk), displayName(forpet), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.example), storeClient(), appRootPath(/opt/usr/apps/org.example.example)
06-03 00:12:41.409+0900 I/Tizen::App( 1210): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.example]
06-03 00:12:41.409+0900 W/ISF_PANEL_EFL(  768): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-03 00:12:41.429+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 00:12:41.429+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 00:12:41.429+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 00:12:41.429+0900 E/PKGMGR_INFO( 1210): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-03 00:12:41.429+0900 I/Tizen::App( 1210): (683) > Application count(1) in this package
06-03 00:12:41.429+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 00:12:41.429+0900 I/Tizen::App( 1210): (703) > Exit.
06-03 00:12:41.429+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [1]
06-03 00:12:41.429+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 00:12:41.429+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 00:12:41.429+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 00:12:41.429+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 00:12:41.439+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[forpet] enable[1] system[0]
06-03 00:12:41.439+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.example] mdm is not enabled
06-03 00:12:41.439+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.example]
06-03 00:12:41.439+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 00:12:41.439+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 00:12:41.439+0900 I/Tizen::App( 1210): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.example.info]
06-03 00:12:41.439+0900 I/Tizen::App( 1210): (131) > Enter
06-03 00:12:41.449+0900 I/Tizen::App( 1210): (137) > org.example.example does not have launch condition
06-03 00:12:41.449+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 00:12:41.459+0900 E/PKGMGR_SERVER( 6546): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6557]
06-03 00:12:41.459+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[forpet] enable[1] system[0]
06-03 00:12:41.469+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 00:12:41.479+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 00:12:42.000+0900 E/PKGMGR_SERVER( 6546): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 00:12:42.000+0900 E/PKGMGR_SERVER( 6546): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 00:12:42.971+0900 W/LFE      (15849): [15849] 26:07:15.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:45.473+0900 W/LFE      (15849): [15849] 26:07:17.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:45.944+0900 W/AUL     ( 6614): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.example)
06-03 00:12:45.944+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:12:45.954+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-03 00:12:45.964+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-03 00:12:45.964+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 00:12:45.964+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 6614
06-03 00:12:45.964+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 00:12:45.974+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:12:45.974+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:12:45.974+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:12:45.984+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:12:45.984+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:12:46.004+0900 I/CAPI_APPFW_APPLICATION( 6053): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:12:46.004+0900 I/CAPI_APPFW_APPLICATION( 6053): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:12:46.044+0900 E/TBM     ( 6053): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:12:46.084+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6053, appid: org.example.example
06-03 00:12:46.084+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:12:46.094+0900 W/AUL     ( 6614): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6053)
06-03 00:12:46.244+0900 I/APP_CORE( 6053): appcore-efl.c: __do_app(514) > [APP 6053] Event: RESET State: CREATED
06-03 00:12:46.244+0900 I/CAPI_APPFW_APPLICATION( 6053): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:12:46.254+0900 E/EFL     ( 6053): edje<6053> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:46.254+0900 E/EFL     ( 6053): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:46.254+0900 E/EFL     ( 6053): edje<6053> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:46.254+0900 E/EFL     ( 6053): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:46.254+0900 E/EFL     ( 6053): edje<6053> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:46.254+0900 E/EFL     ( 6053): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:46.254+0900 E/EFL     ( 6053): edje<6053> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:46.254+0900 E/EFL     ( 6053): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:46.264+0900 E/EFL     ( 6053): edje<6053> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:12:46.264+0900 E/EFL     ( 6053): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:12:46.344+0900 W/APP_CORE( 6053): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:12:46.344+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:12:46.474+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6053) status(4)
06-03 00:12:46.514+0900 I/APP_CORE( 6053): appcore-efl.c: __do_app(514) > [APP 6053] Event: PAUSE State: CREATED
06-03 00:12:46.524+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 6053): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 12
06-03 00:12:46.524+0900 E/APP_CORE( 6053): appcore-efl.c: _capture_and_make_file(1619) > win[9c00002] widget[720] height[1280]
06-03 00:12:46.524+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 00:12:46.815+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6053) status(0)
06-03 00:12:47.085+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:12:47.085+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-03 00:12:47.125+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:12:47.125+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 6053.
06-03 00:12:47.125+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3153
06-03 00:12:47.976+0900 W/LFE      (15849): [15849] 26:07:20.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:47.996+0900 I/UXT     ( 6622): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:12:48.767+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 00:12:48.767+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 00:12:48.767+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 00:12:48.767+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 00:12:48.767+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:12:48.767+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 00:12:48.777+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:12:48.777+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:12:48.777+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:12:48.777+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:12
06-03 00:12:48.777+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:12"
06-03 00:12:48.777+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:12"
06-03 00:12:48.777+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:12:48.777+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146135306 Time: <font_size=31> </font_size> <font_size=31> 오전 12:12</font_size></font>"
06-03 00:12:48.777+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(7) / batt_Full:(0) / battery_charging(1)"
06-03 00:12:48.777+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 00:12:48.777+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:12:48.777+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:12:48.777+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:12:48.787+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:12:48.787+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:12:48.997+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 00:12:49.007+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 00:12:49.007+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 00:12:49.007+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 00:12:49.007+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:49.007+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 00:12:49.007+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 00:12:49.007+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:12:49.007+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:12:49.007+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:12:49.007+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:12:49.007+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:12:49.007+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:12:49.017+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 6627
06-03 00:12:49.027+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:12:49.067+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 6627
06-03 00:12:49.067+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6627, appid: com.samsung.weather-m-agent
06-03 00:12:49.067+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6627)
06-03 00:12:49.107+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:12:49.107+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 6627.
06-03 00:12:49.267+0900 E/weather-agent( 6627): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:12:49.267+0900 E/weather-common( 6627): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:12:49.267+0900 E/weather-agent( 6627): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:12:49.267+0900 E/weather-agent( 6627): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:12:49.267+0900 E/weather-common( 6627): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:12:49.277+0900 E/weather-common( 6627): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:12:49.277+0900 E/weather-common( 6627): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:12:49.277+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:12:49.277+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:12:49.277+0900 I/MESSAGE_PORT( 6627): message-port.c: __initialize(872) > initialize
06-03 00:12:49.287+0900 I/MESSAGE_PORT( 6627): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:12:49.307+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:12:49.307+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:12:49.307+0900 I/MESSAGE_PORT( 6627): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:12:49.307+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:12:49.307+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:12:49.307+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:12:49.317+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:12:49.317+0900 E/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:12:49.317+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:12:49.317+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:12:49.317+0900 E/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:12:49.317+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:12:49.317+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:12:49.327+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:12:49.327+0900 E/MESSAGE_PORT( 6627): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:12:49.327+0900 E/weather-common( 6627): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:12:49.327+0900 E/weather-agent( 6627): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:12:49.327+0900 E/weather-agent( 6627): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:12:49.327+0900 I/MESSAGE_PORT( 6627): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:12:49.337+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:49.357+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.397+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.407+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:12:49.407+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:12:49.427+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:12:49.427+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:49.427+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:12:49.437+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:12:49.437+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:12:49.437+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:12:49.457+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:49.487+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:12:49.497+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:12:49.497+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:12:49.497+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.507+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.517+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:12:49.527+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:12:49.527+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:12:49.527+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:12:49.527+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:12:49.527+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:12:49.587+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:12:49.587+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:12:49.758+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126949757
06-03 00:12:49.918+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126949921
06-03 00:12:49.918+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:12:49.918+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:12:49.918+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:12:50.248+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:12:50.248+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:12:50.248+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:12:50.248+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:12:50.258+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:12:50.258+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:12:50.258+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:12:50.258+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:12:50.258+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:12:50.268+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:12:50.278+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:12:50.278+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:12:50.278+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:12:50.278+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:12:50.278+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:12:50.278+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:12:50.278+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:12:50.288+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:50.288+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:12:50.288+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:12:50.288+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:12:50.298+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6053) status(3)
06-03 00:12:50.298+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:12:50.298+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:12:50.298+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(6053)
06-03 00:12:50.298+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6053, appid: org.example.example, status: fg
06-03 00:12:50.298+0900 I/APP_CORE( 6053): appcore-efl.c: __do_app(514) > [APP 6053] Event: RESUME State: CREATED
06-03 00:12:50.318+0900 I/APP_CORE( 6053): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:12:50.318+0900 I/APP_CORE( 6053): appcore-efl.c: __do_app(625) > [APP 6053] Initial Launching, call the resume_cb
06-03 00:12:50.318+0900 I/CAPI_APPFW_APPLICATION( 6053): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:50.328+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:12:50.338+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:12:50.338+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:50.338+0900 E/weather-agent( 6627): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:12:50.338+0900 I/CAPI_APPFW_APPLICATION( 6627): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:12:50.338+0900 E/weather-agent( 6627): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:12:50.338+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:12:50.338+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:12:50.348+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:50.378+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:50.378+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:12:50.378+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:12:50.378+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:12:50.378+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:12:50.378+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:12:50.388+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:12:50.458+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:12:50.468+0900 W/LFE      (15849): [15849] 26:07:22.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:12:50.528+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:12:50.538+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[6627] terminate event is forwarded
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6627, ]
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:12:50.538+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:12:50.538+0900 I/Tizen::App( 1210): (512) > Not registered pid(6627)
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:12:50.538+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:50.538+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6627
06-03 00:12:50.538+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6627
06-03 00:12:50.538+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:50.538+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6627.
06-03 00:12:51.499+0900 E/EFL     ( 6053): ecore_x<6053> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126951507
06-03 00:12:51.719+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6053 pgid = 6053
06-03 00:12:51.719+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(6053)
06-03 00:12:51.719+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:51.780+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:12:51.780+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:12:51.780+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:12:51.780+0900 W/HOME_APPS(  860): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/usr/apps/com.samsung.homescreen/res/images/HD/calendar/calendar_03.png], Loading state:[1]
06-03 00:12:51.790+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[6053] terminate event is forwarded
06-03 00:12:51.790+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:12:51.790+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 6053, ]
06-03 00:12:51.790+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:12:51.790+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:12:51.790+0900 I/Tizen::App( 1210): (512) > Not registered pid(6053)
06-03 00:12:51.790+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:12:51.790+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:51.790+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6053
06-03 00:12:51.790+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6053
06-03 00:12:51.790+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 6053
06-03 00:12:51.790+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3158
06-03 00:12:51.810+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:12:51.810+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:12:51.810+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:12:51.810+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:12:51.810+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:12:51.810+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:12:51.820+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:12:51.830+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:51.830+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 6053.
06-03 00:12:51.840+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:12:51.840+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:12:51.840+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:12:51.840+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:12:51.860+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:12:51.870+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:12:51.870+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:12:51.890+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:12:51.930+0900 W/CRASH_MANAGER( 6635): worker.c: worker_job(1199) > 1106053657861149641637
