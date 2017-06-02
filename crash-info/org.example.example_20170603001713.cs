S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 6807
Date: 2017-06-03 00:17:13+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6807, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f81000, r3   = 0xb3f81020
r4   = 0x8001b6dc, r5   = 0xbe8992a0
r6   = 0xb286ce5d, r7   = 0xbe899128
r8   = 0x8001b6dc, r9   = 0xb5f63708
r10  = 0xb8618db8, fp   = 0xbe89927c
ip   = 0xb6053120, sp   = 0xbe8990e8
lr   = 0xb6017bd9, pc   = 0xb286ce86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     45788 KB
Buffers:     14896 KB
Cached:     110540 KB
VmPeak:     111648 KB
VmSize:     105664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29012 KB
VmRSS:       26976 KB
VmData:      27948 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 6807 TID = 6807
6807 6808 7047 

Maps Information
b1be0000 b1be8000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bf9000 b1bfa000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1c0a000 b1c1e000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c32000 b1c33000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c43000 b1c46000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c57000 b1c58000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c68000 b1c6a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c7a000 b1c7c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c8c000 b1c9c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1cac000 b1cb8000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1cca000 b24c9000 rw-p [stack:7047]
b27fa000 b2801000 r-xp /usr/lib/libefl-extension.so.0.1.0
b2812000 b281a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b282a000 b283f000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2851000 b2857000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2867000 b286f000 r-xp /opt/usr/apps/org.example.example/bin/example
b29c7000 b2aaa000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2ae1000 b2b09000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2b1b000 b331a000 rw-p [stack:6808]
b331a000 b331c000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b332c000 b3336000 r-xp /lib/libnss_files-2.20-2014.11.so
b3347000 b3350000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3361000 b3372000 r-xp /lib/libnsl-2.20-2014.11.so
b3385000 b338b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b339c000 b339d000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b33c5000 b33cc000 r-xp /usr/lib/libminizip.so.1.0.0
b33dc000 b33e1000 r-xp /usr/lib/libstorage.so.0.1
b33f1000 b3450000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3466000 b347a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b348a000 b34ce000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34de000 b34e6000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34f6000 b3526000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3539000 b35f2000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3606000 b3659000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b366a000 b3685000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3695000 b3756000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3769000 b3779000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3789000 b3796000 r-xp /usr/lib/libmdm-common.so.1.0.98
b37a7000 b37ae000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b37be000 b37ff000 r-xp /usr/lib/libmdm.so.1.2.12
b380f000 b3817000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3826000 b3836000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3857000 b38b7000 r-xp /usr/lib/libasound.so.2.0.0
b38c9000 b38cc000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38dc000 b38df000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38ef000 b38f4000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3904000 b3905000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3915000 b3920000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3934000 b393b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b394b000 b3951000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3961000 b3966000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3976000 b3991000 r-xp /usr/lib/libmmfsound.so.0.1.0
b39a1000 b39a8000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b39b8000 b39bb000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b39cc000 b39fa000 r-xp /usr/lib/libidn.so.11.5.44
b3a0a000 b3a20000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3a31000 b3a3b000 r-xp /usr/lib/libcares.so.2.1.0
b3a4b000 b3a55000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a65000 b3a67000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a77000 b3a78000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a88000 b3a8c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a9d000 b3ac5000 r-xp /usr/lib/libui-extension.so.0.1.0
b3ad6000 b3aff000 r-xp /usr/lib/libturbojpeg.so
b3b1f000 b3b25000 r-xp /usr/lib/libgif.so.4.1.6
b3b35000 b3b7b000 r-xp /usr/lib/libcurl.so.4.3.0
b3b8c000 b3bad000 r-xp /usr/lib/libexif.so.12.3.3
b3bc8000 b3bdd000 r-xp /usr/lib/libtts.so
b3bee000 b3bf6000 r-xp /usr/lib/libfeedback.so.0.1.4
b3c06000 b3ccc000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cec000 b3de4000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3e03000 b3ed1000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ee8000 b3eea000 r-xp /usr/lib/libboost_system.so.1.51.0
b3efa000 b3f00000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3f10000 b3f33000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f44000 b3f46000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f56000 b3f58000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f69000 b3f6e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f85000 b3f87000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f97000 b3f9e000 r-xp /usr/lib/libsensord-share.so
b3fae000 b3fc6000 r-xp /usr/lib/libsensor.so.1.1.0
b3fd7000 b3fda000 r-xp /usr/lib/libXv.so.1.0.0
b3fea000 b3fef000 r-xp /usr/lib/libutilX.so.1.1.0
b3fff000 b4004000 r-xp /usr/lib/libappcore-common.so.1.1
b4014000 b401b000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b402e000 b4032000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4043000 b4121000 r-xp /usr/lib/libCOREGL.so.4.0
b4141000 b4144000 r-xp /usr/lib/libuuid.so.1.3.0
b4154000 b416b000 r-xp /usr/lib/libblkid.so.1.1.0
b417c000 b417e000 r-xp /usr/lib/libXau.so.6.0.0
b418e000 b41d5000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41e7000 b41ed000 r-xp /usr/lib/libjson-c.so.2.0.1
b41fe000 b4202000 r-xp /usr/lib/libogg.so.0.7.1
b4212000 b4234000 r-xp /usr/lib/libvorbis.so.0.4.3
b4244000 b4328000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4344000 b4347000 r-xp /usr/lib/libEGL.so.1.4
b4358000 b435e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b436e000 b4370000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4380000 b438d000 r-xp /usr/lib/libGLESv2.so.2.0
b439e000 b4400000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4415000 b442d000 r-xp /usr/lib/libmount.so.1.1.0
b443f000 b4453000 r-xp /usr/lib/libxcb.so.1.1.0
b4463000 b446a000 r-xp /lib/libcrypt-2.20-2014.11.so
b44a2000 b44a4000 r-xp /usr/lib/libiri.so
b44b4000 b44bf000 r-xp /usr/lib/libgpg-error.so.0.15.0
b44d0000 b4506000 r-xp /usr/lib/libpulse.so.0.16.2
b4517000 b455a000 r-xp /usr/lib/libsndfile.so.1.0.25
b456f000 b4584000 r-xp /lib/libexpat.so.1.5.2
b4596000 b4654000 r-xp /usr/lib/libcairo.so.2.11200.14
b4668000 b4670000 r-xp /usr/lib/libdrm.so.2.4.0
b4680000 b4683000 r-xp /usr/lib/libdri2.so.0.0.0
b4693000 b46e1000 r-xp /usr/lib/libssl.so.1.0.0
b46f6000 b4702000 r-xp /usr/lib/libeeze.so.1.13.0
b4713000 b471c000 r-xp /usr/lib/libethumb.so.1.13.0
b472c000 b472f000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b473f000 b48f6000 r-xp /usr/lib/libcrypto.so.1.0.0
b56e1000 b56ea000 r-xp /usr/lib/libXi.so.6.1.0
b56fa000 b56fc000 r-xp /usr/lib/libXgesture.so.7.0.0
b570c000 b5710000 r-xp /usr/lib/libXtst.so.6.1.0
b5720000 b5726000 r-xp /usr/lib/libXrender.so.1.3.0
b5736000 b573c000 r-xp /usr/lib/libXrandr.so.2.2.0
b574c000 b574e000 r-xp /usr/lib/libXinerama.so.1.0.0
b575f000 b5762000 r-xp /usr/lib/libXfixes.so.3.1.0
b5772000 b577d000 r-xp /usr/lib/libXext.so.6.4.0
b578d000 b578f000 r-xp /usr/lib/libXdamage.so.1.1.0
b579f000 b57a1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b57b1000 b5893000 r-xp /usr/lib/libX11.so.6.3.0
b58a7000 b58ae000 r-xp /usr/lib/libXcursor.so.1.0.2
b58be000 b58d6000 r-xp /usr/lib/libudev.so.1.6.0
b58d8000 b58db000 r-xp /lib/libattr.so.1.1.0
b58eb000 b590b000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b590c000 b5911000 r-xp /usr/lib/libffi.so.6.0.2
b5922000 b593a000 r-xp /lib/libz.so.1.2.8
b594a000 b594c000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b595c000 b5a31000 r-xp /usr/lib/libxml2.so.2.9.2
b5a46000 b5ae1000 r-xp /usr/lib/libstdc++.so.6.0.20
b5afd000 b5b00000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5b10000 b5b29000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5b3a000 b5b4b000 r-xp /lib/libresolv-2.20-2014.11.so
b5b5f000 b5bd9000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bee000 b5bf0000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5c00000 b5c07000 r-xp /usr/lib/libembryo.so.1.13.0
b5c17000 b5c21000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5c32000 b5c4a000 r-xp /usr/lib/libpng12.so.0.50.0
b5c5b000 b5c7e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c9f000 b5cb3000 r-xp /usr/lib/libector.so.1.13.0
b5cc4000 b5cdc000 r-xp /usr/lib/liblua-5.1.so
b5ced000 b5d44000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d58000 b5d80000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d91000 b5da4000 r-xp /usr/lib/libfribidi.so.0.3.1
b5db5000 b5def000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5e00000 b5e0e000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5e1e000 b5e26000 r-xp /usr/lib/libtbm.so.1.0.0
b5e36000 b5e43000 r-xp /usr/lib/libeio.so.1.13.0
b5e53000 b5e55000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e65000 b5e6a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e7a000 b5e91000 r-xp /usr/lib/libefreet.so.1.13.0
b5ea3000 b5ec3000 r-xp /usr/lib/libeldbus.so.1.13.0
b5ed3000 b5ef3000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ef5000 b5efb000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5f0b000 b5f1c000 r-xp /usr/lib/libemotion.so.1.13.0
b5f2d000 b5f34000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f44000 b5f53000 r-xp /usr/lib/libeo.so.1.13.0
b5f64000 b5f76000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f87000 b5f8c000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f9c000 b5fb5000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5fc5000 b5fe2000 r-xp /usr/lib/libeet.so.1.13.0
b5ffb000 b6043000 r-xp /usr/lib/libeina.so.1.13.0
b6054000 b6064000 r-xp /usr/lib/libefl.so.1.13.0
b6075000 b615a000 r-xp /usr/lib/libicuuc.so.51.1
b6177000 b62b7000 r-xp /usr/lib/libicui18n.so.51.1
b62ce000 b6306000 r-xp /usr/lib/libecore_x.so.1.13.0
b6318000 b631b000 r-xp /lib/libcap.so.2.21
b632b000 b6354000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6365000 b636c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b637e000 b63b5000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b63c6000 b64b1000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b64c4000 b653d000 r-xp /usr/lib/libsqlite3.so.0.8.6
b654f000 b6554000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6564000 b656e000 r-xp /usr/lib/libvconf.so.0.2.45
b657e000 b6580000 r-xp /usr/lib/libvasum.so.0.3.1
b6590000 b6592000 r-xp /usr/lib/libttrace.so.1.1
b65a2000 b65a5000 r-xp /usr/lib/libiniparser.so.0
b65b5000 b65db000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65eb000 b65f0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6601000 b6618000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6629000 b6694000 r-xp /lib/libm-2.20-2014.11.so
b66a5000 b66ab000 r-xp /lib/librt-2.20-2014.11.so
b66bc000 b66c9000 r-xp /usr/lib/libunwind.so.8.0.1
b66ff000 b6823000 r-xp /lib/libc-2.20-2014.11.so
b6838000 b6851000 r-xp /lib/libgcc_s-4.9.so.1
b6861000 b6943000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6954000 b697e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b698f000 b69cb000 r-xp /usr/lib/libsystemd.so.0.4.0
b69cd000 b6a50000 r-xp /usr/lib/libedje.so.1.13.0
b6a63000 b6a81000 r-xp /usr/lib/libecore.so.1.13.0
b6aa1000 b6c28000 r-xp /usr/lib/libevas.so.1.13.0
b6c5d000 b6c71000 r-xp /lib/libpthread-2.20-2014.11.so
b6c85000 b6eb9000 r-xp /usr/lib/libelementary.so.1.13.0
b6ee8000 b6eec000 r-xp /usr/lib/libsmack.so.1.0.0
b6efc000 b6f03000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f13000 b6f15000 r-xp /usr/lib/libdlog.so.0.0.0
b6f25000 b6f28000 r-xp /usr/lib/libbundle.so.0.1.22
b6f38000 b6f3a000 r-xp /lib/libdl-2.20-2014.11.so
b6f4b000 b6f63000 r-xp /usr/lib/libaul.so.0.1.0
b6f77000 b6f7c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f8d000 b6f9a000 r-xp /usr/lib/liblptcp.so
b6fac000 b6fb0000 r-xp /usr/lib/libsys-assert.so
b6fc1000 b6fe1000 r-xp /lib/ld-2.20-2014.11.so
b6ff2000 b6ff7000 r-xp /usr/bin/launchpad-loader
b83ae000 b8666000 rw-p [heap]
be879000 be89a000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6807)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb286ce86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6ad6175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f4f219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f4dfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6ad6515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6ade725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6ae3f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6ae7939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb472e173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a6ec4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a74a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a74c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f7a2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb4030909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb286c673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6ff3bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb67154bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6ff3eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
binfo(312) > tmp is NULL
06-03 00:17:03.395+0900 E/rpm-installer( 6984): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-03 00:17:03.395+0900 E/rpm-installer( 6984): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-03 00:17:03.395+0900 E/rpm-installer( 6984): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-03 00:17:03.395+0900 E/rpm-installer( 6984): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 00:17:03.395+0900 E/rpm-installer( 6984): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-03 00:17:03.395+0900 E/rpm-installer( 6984): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-03 00:17:03.405+0900 E/PKGMGR_PARSER( 6984): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-03 00:17:03.405+0900 E/PKGMGR_PARSER( 6984): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-03 00:17:03.455+0900 I/PRIVACY-MANAGER-CLIENT( 6984): SocketClient.cpp: SocketClient(37) > Client created
06-03 00:17:03.725+0900 E/PKGMGR_PARSER( 6984): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-03 00:17:03.745+0900 E/PKGMGR_CERT( 6984): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-03 00:17:03.745+0900 E/PKGMGR_CERT( 6984): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-03 00:17:03.745+0900 E/PKGMGR_CERT( 6984): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-03 00:17:03.745+0900 E/PKGMGR_CERT( 6984): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 2
06-03 00:17:03.745+0900 E/PKGMGR_CERT( 6984): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 2
06-03 00:17:03.745+0900 E/PKGMGR_CERT( 6984): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 46 2
06-03 00:17:03.745+0900 E/PKGMGR_CERT( 6984): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 2
06-03 00:17:03.755+0900 E/PKGMGR_CERT( 6984): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-03 00:17:03.755+0900 E/rpm-installer( 6984): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.example/lib]
06-03 00:17:03.765+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 60
06-03 00:17:03.765+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [60]
06-03 00:17:03.765+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [60], install = [96]
06-03 00:17:03.765+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:03.765+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:03.765+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:03.765+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:03.785+0900 E/rpm-installer( 6984): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 00:17:03.815+0900 E/rpm-installer( 6984): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-03 00:17:03.825+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 100
06-03 00:17:03.825+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:03.825+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [100]
06-03 00:17:03.825+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:03.825+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [100], install = [96]
06-03 00:17:03.825+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:03.825+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:04.006+0900 E/PKGMGR_SERVER( 6973): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 00:17:05.467+0900 W/LFE      (15849): [15849] 26:11:37.548[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:05.877+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 00:17:05.877+0900 I/Tizen::App( 1210): (78) > Installation is Completed. [Package = org.example.example]
06-03 00:17:05.877+0900 I/Tizen::App( 1210): (671) > Enter. package(org.example.example), installationResult(0)
06-03 00:17:05.877+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 00:17:05.877+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 00:17:05.877+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 00:17:05.877+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:05.877+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:05.877+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:05.877+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 00:17:05.897+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 00:17:05.897+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 00:17:05.897+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 00:17:05.897+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 00:17:05.897+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 00:17:05.907+0900 I/Tizen::App( 1210): (1360) > package(org.example.example), version(1.0.0), type(tpk), displayName(forpet), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.example), storeClient(), appRootPath(/opt/usr/apps/org.example.example)
06-03 00:17:05.907+0900 W/ISF_PANEL_EFL(  768): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-03 00:17:05.907+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[forpet] enable[1] system[0]
06-03 00:17:05.907+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.example] mdm is not enabled
06-03 00:17:05.917+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.example]
06-03 00:17:05.917+0900 I/Tizen::App( 1210): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.example]
06-03 00:17:05.927+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 00:17:05.927+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 00:17:05.927+0900 E/PKGMGR_INFO( 1210): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-03 00:17:05.927+0900 I/Tizen::App( 1210): (683) > Application count(1) in this package
06-03 00:17:05.927+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 00:17:05.927+0900 I/Tizen::App( 1210): (703) > Exit.
06-03 00:17:05.927+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [96]
06-03 00:17:05.937+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[forpet] enable[1] system[0]
06-03 00:17:05.947+0900 E/PKGMGR_SERVER( 6973): pkgmgr-server.c: sighandler(417) > child NORMAL exit [6984]
06-03 00:17:05.947+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 00:17:05.947+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 00:17:05.947+0900 I/Tizen::App( 1210): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.example.info]
06-03 00:17:05.947+0900 I/Tizen::App( 1210): (131) > Enter
06-03 00:17:05.947+0900 I/Tizen::App( 1210): (137) > org.example.example does not have launch condition
06-03 00:17:05.947+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 00:17:05.957+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 00:17:05.957+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 00:17:05.998+0900 E/PKGMGR_SERVER( 6973): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 00:17:05.998+0900 E/PKGMGR_SERVER( 6973): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 00:17:07.969+0900 W/LFE      (15849): [15849] 26:11:40.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:10.432+0900 W/AUL     ( 7040): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.example)
06-03 00:17:10.432+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:17:10.442+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-03 00:17:10.452+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-03 00:17:10.452+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 00:17:10.452+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 7040
06-03 00:17:10.452+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 00:17:10.462+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:17:10.472+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:17:10.472+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:17:10.472+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:17:10.472+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:17:10.472+0900 W/LFE      (15849): [15849] 26:11:42.552[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:10.502+0900 I/CAPI_APPFW_APPLICATION( 6807): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:17:10.502+0900 I/CAPI_APPFW_APPLICATION( 6807): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:17:10.542+0900 E/TBM     ( 6807): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:17:10.572+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6807, appid: org.example.example
06-03 00:17:10.572+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:17:10.582+0900 W/AUL     ( 7040): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6807)
06-03 00:17:10.742+0900 I/APP_CORE( 6807): appcore-efl.c: __do_app(514) > [APP 6807] Event: RESET State: CREATED
06-03 00:17:10.742+0900 I/CAPI_APPFW_APPLICATION( 6807): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:17:10.742+0900 E/EFL     ( 6807): edje<6807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:10.742+0900 E/EFL     ( 6807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:10.752+0900 E/EFL     ( 6807): edje<6807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:10.752+0900 E/EFL     ( 6807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:10.752+0900 E/EFL     ( 6807): edje<6807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:10.752+0900 E/EFL     ( 6807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:10.752+0900 E/EFL     ( 6807): edje<6807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:10.752+0900 E/EFL     ( 6807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:10.752+0900 E/EFL     ( 6807): edje<6807> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:17:10.752+0900 E/EFL     ( 6807): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:17:10.832+0900 W/APP_CORE( 6807): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:17:10.832+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:17:10.972+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6807) status(4)
06-03 00:17:11.012+0900 I/APP_CORE( 6807): appcore-efl.c: __do_app(514) > [APP 6807] Event: PAUSE State: CREATED
06-03 00:17:11.032+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 6807): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 17
06-03 00:17:11.032+0900 E/APP_CORE( 6807): appcore-efl.c: _capture_and_make_file(1619) > win[8a00002] widget[720] height[1280]
06-03 00:17:11.032+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 00:17:11.313+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6807) status(0)
06-03 00:17:11.573+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:17:11.573+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-03 00:17:11.623+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:17:11.623+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 6807.
06-03 00:17:11.623+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3188
06-03 00:17:12.354+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 00:17:12.354+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 00:17:12.354+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 00:17:12.354+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 00:17:12.354+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:17:12.354+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 00:17:12.354+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:17:12.364+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:17:12.364+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:17:12.364+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:17
06-03 00:17:12.364+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:17"
06-03 00:17:12.364+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:17"
06-03 00:17:12.364+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:17:12.364+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145994182 Time: <font_size=31> </font_size> <font_size=31> 오전 12:17</font_size></font>"
06-03 00:17:12.374+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(7) / batt_Full:(0) / battery_charging(1)"
06-03 00:17:12.374+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 00:17:12.374+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:17:12.374+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:17:12.374+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:17:12.374+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:17:12.374+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:17:12.604+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 00:17:12.614+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 00:17:12.614+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 00:17:12.614+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 00:17:12.614+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:12.614+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 00:17:12.614+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 00:17:12.614+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:17:12.614+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:17:12.614+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:17:12.614+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:17:12.614+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:17:12.624+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:17:12.624+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 7051
06-03 00:17:12.674+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7051
06-03 00:17:12.674+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7051, appid: com.samsung.weather-m-agent
06-03 00:17:12.684+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7051)
06-03 00:17:12.714+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:17:12.714+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7051.
06-03 00:17:12.874+0900 I/UXT     ( 7048): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:17:12.944+0900 E/weather-agent( 7051): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:17:12.944+0900 E/weather-common( 7051): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:17:12.944+0900 E/weather-agent( 7051): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:17:12.944+0900 E/weather-agent( 7051): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:17:12.954+0900 E/weather-common( 7051): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:17:12.954+0900 E/weather-common( 7051): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:17:12.954+0900 E/weather-common( 7051): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:17:12.954+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:17:12.954+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:17:12.954+0900 I/MESSAGE_PORT( 7051): message-port.c: __initialize(872) > initialize
06-03 00:17:12.964+0900 I/MESSAGE_PORT( 7051): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:17:12.964+0900 W/LFE      (15849): [15849] 26:11:45.044[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:17:13.004+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:17:13.004+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:17:13.004+0900 I/MESSAGE_PORT( 7051): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:17:13.004+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:17:13.004+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:17:13.004+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:17:13.004+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:17:13.004+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:17:13.014+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:17:13.014+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:13.014+0900 E/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:17:13.014+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:17:13.014+0900 E/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:17:13.014+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:17:13.014+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:17:13.024+0900 E/MESSAGE_PORT( 7051): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:17:13.024+0900 E/weather-common( 7051): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:17:13.024+0900 E/weather-agent( 7051): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:17:13.024+0900 E/weather-agent( 7051): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:17:13.024+0900 I/MESSAGE_PORT( 7051): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:17:13.044+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127213032
06-03 00:17:13.044+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:17:13.044+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:13.044+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:13.044+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:17:13.054+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:13.054+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:17:13.054+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:17:13.054+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:17:13.054+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:17:13.074+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:13.104+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.114+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.124+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:17:13.134+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.134+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:17:13.134+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:17:13.134+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:17:13.134+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:17:13.155+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127213151
06-03 00:17:13.155+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:17:13.155+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:17:13.155+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:17:13.195+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:17:13.195+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.205+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:17:13.215+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:17:13.215+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:17:13.265+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:17:13.275+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:17:13.485+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:17:13.485+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:17:13.485+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:17:13.485+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:17:13.495+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:13.495+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:17:13.495+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:17:13.495+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:17:13.505+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:13.505+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:17:13.505+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:17:13.505+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:17:13.505+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:17:13.505+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:17:13.505+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:17:13.505+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:17:13.505+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:17:13.505+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:17:13.505+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:17:13.505+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:17:13.505+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:17:13.515+0900 I/APP_CORE( 6807): appcore-efl.c: __do_app(514) > [APP 6807] Event: RESUME State: CREATED
06-03 00:17:13.525+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6807) status(3)
06-03 00:17:13.525+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:17:13.525+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:17:13.525+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(6807)
06-03 00:17:13.525+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6807, appid: org.example.example, status: fg
06-03 00:17:13.545+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:17:13.555+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:17:13.555+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:17:13.555+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:17:13.555+0900 I/APP_CORE( 6807): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:17:13.555+0900 I/APP_CORE( 6807): appcore-efl.c: __do_app(625) > [APP 6807] Initial Launching, call the resume_cb
06-03 00:17:13.555+0900 I/CAPI_APPFW_APPLICATION( 6807): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:17:13.565+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:17:13.605+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:17:13.605+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:17:13.605+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:17:13.605+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:17:13.605+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:17:13.615+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:17:13.735+0900 E/EFL     ( 6807): ecore_x<6807> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127213705
06-03 00:17:13.905+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 6807 pgid = 6807
06-03 00:17:13.905+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(6807)
06-03 00:17:13.905+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:17:13.915+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:17:13.925+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:17:13.925+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:17:13.925+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:17:13.925+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:17:13.975+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:17:13.975+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:17:13.975+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:17:13.985+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:17:13.995+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[6807] terminate event is forwarded
06-03 00:17:13.995+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:17:13.995+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 6807, ]
06-03 00:17:13.995+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:17:13.995+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
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
06-03 00:17:14.095+0900 W/CRASH_MANAGER( 7060): worker.c: worker_job(1199) > 1106807657861149641663
