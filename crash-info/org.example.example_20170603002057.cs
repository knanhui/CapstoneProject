S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7153
Date: 2017-06-03 00:20:57+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7153, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f46000, r3   = 0xb3f46020
r4   = 0x8001b2da, r5   = 0xbef4a2a0
r6   = 0xb282f9a5, r7   = 0xbef4a128
r8   = 0x8001b2da, r9   = 0xb5f28708
r10  = 0xb8c7ca40, fp   = 0xbef4a27c
ip   = 0xb6018120, sp   = 0xbef4a0e8
lr   = 0xb5fdcbd9, pc   = 0xb282f9ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     42496 KB
Buffers:     15632 KB
Cached:     114448 KB
VmPeak:     111088 KB
VmSize:     109612 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24196 KB
VmRSS:       24196 KB
VmData:      35544 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7153 TID = 7153
7153 7157 7284 7285 

Maps Information
b1201000 b1a00000 rw-p [stack:7285]
b1ba5000 b1bad000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1bbe000 b1bbf000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bcf000 b1be3000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bf7000 b1bf8000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c08000 b1c0b000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c1c000 b1c1d000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c2d000 b1c2f000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c3f000 b1c41000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c51000 b1c61000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c71000 b1c7d000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c8f000 b248e000 rw-p [stack:7284]
b27bf000 b27c6000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27d7000 b27df000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27ef000 b2804000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2816000 b281c000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b282c000 b2834000 r-xp /opt/usr/apps/org.example.example/bin/example
b298c000 b2a6f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2aa6000 b2ace000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ae0000 b32df000 rw-p [stack:7157]
b32df000 b32e1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32f1000 b32fb000 r-xp /lib/libnss_files-2.20-2014.11.so
b330c000 b3315000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3326000 b3337000 r-xp /lib/libnsl-2.20-2014.11.so
b334a000 b3350000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3361000 b3362000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b338a000 b3391000 r-xp /usr/lib/libminizip.so.1.0.0
b33a1000 b33a6000 r-xp /usr/lib/libstorage.so.0.1
b33b6000 b3415000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b342b000 b343f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b344f000 b3493000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b34a3000 b34ab000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34bb000 b34eb000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34fe000 b35b7000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35cb000 b361e000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b362f000 b364a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b365a000 b371b000 r-xp /usr/lib/libprotobuf.so.9.0.1
b372e000 b373e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b374e000 b375b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b376c000 b3773000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3783000 b37c4000 r-xp /usr/lib/libmdm.so.1.2.12
b37d4000 b37dc000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37eb000 b37fb000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b381c000 b387c000 r-xp /usr/lib/libasound.so.2.0.0
b388e000 b3891000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b38a1000 b38a4000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b38b4000 b38b9000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38c9000 b38ca000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38da000 b38e5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38f9000 b3900000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3910000 b3916000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3926000 b392b000 r-xp /usr/lib/libmmfsession.so.0.0.1
b393b000 b3956000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3966000 b396d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b397d000 b3980000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3991000 b39bf000 r-xp /usr/lib/libidn.so.11.5.44
b39cf000 b39e5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39f6000 b3a00000 r-xp /usr/lib/libcares.so.2.1.0
b3a10000 b3a1a000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a2a000 b3a2c000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a3c000 b3a3d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a4d000 b3a51000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a62000 b3a8a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a9b000 b3ac4000 r-xp /usr/lib/libturbojpeg.so
b3ae4000 b3aea000 r-xp /usr/lib/libgif.so.4.1.6
b3afa000 b3b40000 r-xp /usr/lib/libcurl.so.4.3.0
b3b51000 b3b72000 r-xp /usr/lib/libexif.so.12.3.3
b3b8d000 b3ba2000 r-xp /usr/lib/libtts.so
b3bb3000 b3bbb000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bcb000 b3c91000 r-xp /usr/lib/libdali-core.so.0.0.0
b3cb1000 b3da9000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3dc8000 b3e96000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3ead000 b3eaf000 r-xp /usr/lib/libboost_system.so.1.51.0
b3ebf000 b3ec5000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ed5000 b3ef8000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3f09000 b3f0b000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f1b000 b3f1d000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f2e000 b3f33000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f4a000 b3f4c000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f5c000 b3f63000 r-xp /usr/lib/libsensord-share.so
b3f73000 b3f8b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f9c000 b3f9f000 r-xp /usr/lib/libXv.so.1.0.0
b3faf000 b3fb4000 r-xp /usr/lib/libutilX.so.1.1.0
b3fc4000 b3fc9000 r-xp /usr/lib/libappcore-common.so.1.1
b3fd9000 b3fe0000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3ff3000 b3ff7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b4008000 b40e6000 r-xp /usr/lib/libCOREGL.so.4.0
b4106000 b4109000 r-xp /usr/lib/libuuid.so.1.3.0
b4119000 b4130000 r-xp /usr/lib/libblkid.so.1.1.0
b4141000 b4143000 r-xp /usr/lib/libXau.so.6.0.0
b4153000 b419a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b41ac000 b41b2000 r-xp /usr/lib/libjson-c.so.2.0.1
b41c3000 b41c7000 r-xp /usr/lib/libogg.so.0.7.1
b41d7000 b41f9000 r-xp /usr/lib/libvorbis.so.0.4.3
b4209000 b42ed000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4309000 b430c000 r-xp /usr/lib/libEGL.so.1.4
b431d000 b4323000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4333000 b4335000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4345000 b4352000 r-xp /usr/lib/libGLESv2.so.2.0
b4363000 b43c5000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43da000 b43f2000 r-xp /usr/lib/libmount.so.1.1.0
b4404000 b4418000 r-xp /usr/lib/libxcb.so.1.1.0
b4428000 b442f000 r-xp /lib/libcrypt-2.20-2014.11.so
b4467000 b4469000 r-xp /usr/lib/libiri.so
b4479000 b4484000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4495000 b44cb000 r-xp /usr/lib/libpulse.so.0.16.2
b44dc000 b451f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4534000 b4549000 r-xp /lib/libexpat.so.1.5.2
b455b000 b4619000 r-xp /usr/lib/libcairo.so.2.11200.14
b462d000 b4635000 r-xp /usr/lib/libdrm.so.2.4.0
b4645000 b4648000 r-xp /usr/lib/libdri2.so.0.0.0
b4658000 b46a6000 r-xp /usr/lib/libssl.so.1.0.0
b46bb000 b46c7000 r-xp /usr/lib/libeeze.so.1.13.0
b46d8000 b46e1000 r-xp /usr/lib/libethumb.so.1.13.0
b46f1000 b46f4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b4704000 b48bb000 r-xp /usr/lib/libcrypto.so.1.0.0
b56a6000 b56af000 r-xp /usr/lib/libXi.so.6.1.0
b56bf000 b56c1000 r-xp /usr/lib/libXgesture.so.7.0.0
b56d1000 b56d5000 r-xp /usr/lib/libXtst.so.6.1.0
b56e5000 b56eb000 r-xp /usr/lib/libXrender.so.1.3.0
b56fb000 b5701000 r-xp /usr/lib/libXrandr.so.2.2.0
b5711000 b5713000 r-xp /usr/lib/libXinerama.so.1.0.0
b5724000 b5727000 r-xp /usr/lib/libXfixes.so.3.1.0
b5737000 b5742000 r-xp /usr/lib/libXext.so.6.4.0
b5752000 b5754000 r-xp /usr/lib/libXdamage.so.1.1.0
b5764000 b5766000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5776000 b5858000 r-xp /usr/lib/libX11.so.6.3.0
b586c000 b5873000 r-xp /usr/lib/libXcursor.so.1.0.2
b5883000 b589b000 r-xp /usr/lib/libudev.so.1.6.0
b589d000 b58a0000 r-xp /lib/libattr.so.1.1.0
b58b0000 b58d0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58d1000 b58d6000 r-xp /usr/lib/libffi.so.6.0.2
b58e7000 b58ff000 r-xp /lib/libz.so.1.2.8
b590f000 b5911000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b5921000 b59f6000 r-xp /usr/lib/libxml2.so.2.9.2
b5a0b000 b5aa6000 r-xp /usr/lib/libstdc++.so.6.0.20
b5ac2000 b5ac5000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ad5000 b5aee000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aff000 b5b10000 r-xp /lib/libresolv-2.20-2014.11.so
b5b24000 b5b9e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bb3000 b5bb5000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bc5000 b5bcc000 r-xp /usr/lib/libembryo.so.1.13.0
b5bdc000 b5be6000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bf7000 b5c0f000 r-xp /usr/lib/libpng12.so.0.50.0
b5c20000 b5c43000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c64000 b5c78000 r-xp /usr/lib/libector.so.1.13.0
b5c89000 b5ca1000 r-xp /usr/lib/liblua-5.1.so
b5cb2000 b5d09000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d1d000 b5d45000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d56000 b5d69000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d7a000 b5db4000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5dc5000 b5dd3000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5de3000 b5deb000 r-xp /usr/lib/libtbm.so.1.0.0
b5dfb000 b5e08000 r-xp /usr/lib/libeio.so.1.13.0
b5e18000 b5e1a000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e2a000 b5e2f000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e3f000 b5e56000 r-xp /usr/lib/libefreet.so.1.13.0
b5e68000 b5e88000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e98000 b5eb8000 r-xp /usr/lib/libecore_con.so.1.13.0
b5eba000 b5ec0000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ed0000 b5ee1000 r-xp /usr/lib/libemotion.so.1.13.0
b5ef2000 b5ef9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5f09000 b5f18000 r-xp /usr/lib/libeo.so.1.13.0
b5f29000 b5f3b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f4c000 b5f51000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f61000 b5f7a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f8a000 b5fa7000 r-xp /usr/lib/libeet.so.1.13.0
b5fc0000 b6008000 r-xp /usr/lib/libeina.so.1.13.0
b6019000 b6029000 r-xp /usr/lib/libefl.so.1.13.0
b603a000 b611f000 r-xp /usr/lib/libicuuc.so.51.1
b613c000 b627c000 r-xp /usr/lib/libicui18n.so.51.1
b6293000 b62cb000 r-xp /usr/lib/libecore_x.so.1.13.0
b62dd000 b62e0000 r-xp /lib/libcap.so.2.21
b62f0000 b6319000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b632a000 b6331000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6343000 b637a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b638b000 b6476000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6489000 b6502000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6514000 b6519000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6529000 b6533000 r-xp /usr/lib/libvconf.so.0.2.45
b6543000 b6545000 r-xp /usr/lib/libvasum.so.0.3.1
b6555000 b6557000 r-xp /usr/lib/libttrace.so.1.1
b6567000 b656a000 r-xp /usr/lib/libiniparser.so.0
b657a000 b65a0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b65b0000 b65b5000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65c6000 b65dd000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65ee000 b6659000 r-xp /lib/libm-2.20-2014.11.so
b666a000 b6670000 r-xp /lib/librt-2.20-2014.11.so
b6681000 b668e000 r-xp /usr/lib/libunwind.so.8.0.1
b66c4000 b67e8000 r-xp /lib/libc-2.20-2014.11.so
b67fd000 b6816000 r-xp /lib/libgcc_s-4.9.so.1
b6826000 b6908000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6919000 b6943000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6954000 b6990000 r-xp /usr/lib/libsystemd.so.0.4.0
b6992000 b6a15000 r-xp /usr/lib/libedje.so.1.13.0
b6a28000 b6a46000 r-xp /usr/lib/libecore.so.1.13.0
b6a66000 b6bed000 r-xp /usr/lib/libevas.so.1.13.0
b6c22000 b6c36000 r-xp /lib/libpthread-2.20-2014.11.so
b6c4a000 b6e7e000 r-xp /usr/lib/libelementary.so.1.13.0
b6ead000 b6eb1000 r-xp /usr/lib/libsmack.so.1.0.0
b6ec1000 b6ec8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ed8000 b6eda000 r-xp /usr/lib/libdlog.so.0.0.0
b6eea000 b6eed000 r-xp /usr/lib/libbundle.so.0.1.22
b6efd000 b6eff000 r-xp /lib/libdl-2.20-2014.11.so
b6f10000 b6f28000 r-xp /usr/lib/libaul.so.0.1.0
b6f3c000 b6f41000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f52000 b6f5f000 r-xp /usr/lib/liblptcp.so
b6f71000 b6f75000 r-xp /usr/lib/libsys-assert.so
b6f86000 b6fa6000 r-xp /lib/ld-2.20-2014.11.so
b6fb7000 b6fbc000 r-xp /usr/bin/launchpad-loader
b8a12000 b8ccb000 rw-p [heap]
bef2a000 bef4b000 rw-p [stack]
bef2a000 bef4b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7153)
Call Stack Count: 18
 0: feeding_view_cb + 0x29 (0xb282f9ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb6a9b175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5f14219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5f12fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a9b515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6aa3725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6aa8f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6aac939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46f3173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a33c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a39a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a39c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f3f2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3ff5909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2831673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6fb8bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66da4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fb8eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
group.c: __set_fg_flag(180) > send_signal FG org.example.example(7097)
06-03 00:20:54.410+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7097, appid: org.example.example, status: fg
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:20:54.430+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:20:54.430+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:20:54.430+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:20:54.430+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:20:54.430+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:20:54.430+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:20:54.430+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:20:54.440+0900 I/APP_CORE( 7097): appcore-efl.c: __do_app(514) > [APP 7097] Event: RESUME State: PAUSED
06-03 00:20:54.440+0900 I/CAPI_APPFW_APPLICATION( 7097): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:20:54.440+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:20:54.450+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:20:54.450+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:54.450+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:54.460+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:54.530+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:20:54.530+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:20:54.530+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:20:54.530+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:20:54.530+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:20:54.541+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:20:54.561+0900 E/EFL     ( 7097): ecore_x<7097> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127434560
06-03 00:20:54.711+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7097 pgid = 7097
06-03 00:20:54.711+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7097)
06-03 00:20:54.721+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:54.731+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:20:54.731+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:20:54.731+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:20:54.731+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:20:54.731+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:20:54.761+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:20:54.761+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:20:54.761+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:20:54.761+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7097] terminate event is forwarded
06-03 00:20:54.761+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:20:54.761+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7097, ]
06-03 00:20:54.761+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:20:54.761+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:20:54.761+0900 I/Tizen::App( 1210): (512) > Not registered pid(7097)
06-03 00:20:54.761+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:20:54.761+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:54.771+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7097
06-03 00:20:54.771+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7097
06-03 00:20:54.771+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7097
06-03 00:20:54.771+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3214
06-03 00:20:54.791+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:20:54.791+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:20:54.791+0900 E/weather-agent( 7261): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:20:54.791+0900 I/CAPI_APPFW_APPLICATION( 7261): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:20:54.791+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:54.791+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7097.
06-03 00:20:54.801+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:20:54.801+0900 E/weather-agent( 7261): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:20:54.801+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:20:54.811+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:20:54.811+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:20:54.811+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:20:54.811+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:54.821+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:20:54.831+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:54.841+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:54.851+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:20:54.851+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:54.871+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:20:54.881+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:54.881+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:20:54.881+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:20:54.881+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:20:54.881+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:20:54.901+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11070976578611496416854
06-03 00:20:54.911+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:54.961+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:20:54.971+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:20:55.021+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:20:55.021+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:20:55.041+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7261
06-03 00:20:55.041+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7261
06-03 00:20:55.041+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[7261] terminate event is forwarded
06-03 00:20:55.041+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:20:55.041+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7261, ]
06-03 00:20:55.041+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:20:55.041+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:20:55.041+0900 I/Tizen::App( 1210): (512) > Not registered pid(7261)
06-03 00:20:55.041+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:20:55.041+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:55.061+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:55.061+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7261.
06-03 00:20:55.481+0900 W/LFE      (15849): [15849] 26:15:27.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:55.511+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127435512
06-03 00:20:55.562+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127435565
06-03 00:20:55.572+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:20:55.572+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:20:55.572+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:20:55.582+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:20:55.592+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:20:55.592+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:20:55.592+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:20:55.592+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:20:55.612+0900 I/CAPI_APPFW_APPLICATION( 7153): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:20:55.612+0900 I/CAPI_APPFW_APPLICATION( 7153): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:20:55.662+0900 E/TBM     ( 7153): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:20:55.692+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7153, appid: org.example.example
06-03 00:20:55.692+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:20:55.692+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7153)
06-03 00:20:55.852+0900 I/APP_CORE( 7153): appcore-efl.c: __do_app(514) > [APP 7153] Event: RESET State: CREATED
06-03 00:20:55.852+0900 I/CAPI_APPFW_APPLICATION( 7153): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:20:55.852+0900 E/EFL     ( 7153): edje<7153> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:55.852+0900 E/EFL     ( 7153): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:55.852+0900 E/EFL     ( 7153): edje<7153> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:55.852+0900 E/EFL     ( 7153): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:55.852+0900 E/EFL     ( 7153): edje<7153> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:55.852+0900 E/EFL     ( 7153): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:55.852+0900 E/EFL     ( 7153): edje<7153> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:55.852+0900 E/EFL     ( 7153): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:55.862+0900 E/EFL     ( 7153): edje<7153> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:55.862+0900 E/EFL     ( 7153): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:55.892+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:55.892+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:55.902+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:55.932+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:20:55.932+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:55.932+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:55.952+0900 W/APP_CORE( 7153): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:20:55.952+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:20:56.052+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:20:56.052+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:20:56.052+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:20:56.062+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:20:56.062+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:20:56.062+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:20:56.062+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7153) status(3)
06-03 00:20:56.062+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7153)
06-03 00:20:56.062+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7153, appid: org.example.example, status: fg
06-03 00:20:56.072+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:20:56.072+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:20:56.072+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:20:56.072+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:20:56.082+0900 I/APP_CORE( 7153): appcore-efl.c: __do_app(514) > [APP 7153] Event: RESUME State: CREATED
06-03 00:20:56.102+0900 I/APP_CORE( 7153): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:20:56.102+0900 I/APP_CORE( 7153): appcore-efl.c: __do_app(625) > [APP 7153] Initial Launching, call the resume_cb
06-03 00:20:56.102+0900 I/CAPI_APPFW_APPLICATION( 7153): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:20:56.412+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7153) status(0)
06-03 00:20:56.613+0900 E/EFL     ( 7153): ecore_x<7153> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127436614
06-03 00:20:56.683+0900 E/EFL     ( 7153): ecore_x<7153> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127436679
06-03 00:20:56.723+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3216
06-03 00:20:56.733+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:20:56.733+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7153.
06-03 00:20:57.513+0900 I/UXT     ( 7288): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:20:57.964+0900 E/EFL     ( 7153): ecore_x<7153> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127437965
06-03 00:20:57.974+0900 W/LFE      (15849): [15849] 26:15:30.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:20:58.124+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 7153 pgid = 7153
06-03 00:20:58.124+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(7153)
06-03 00:20:58.124+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:58.134+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:20:58.134+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:20:58.134+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:20:58.134+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:20:58.134+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:20:58.174+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 00:20:58.174+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 00:20:58.174+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 00:20:58.174+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7153] terminate event is forwarded
06-03 00:20:58.174+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:20:58.174+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7153, ]
06-03 00:20:58.174+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:20:58.174+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:20:58.174+0900 I/Tizen::App( 1210): (512) > Not registered pid(7153)
06-03 00:20:58.174+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:20:58.174+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:58.174+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7153
06-03 00:20:58.174+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7153
06-03 00:20:58.174+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7153
06-03 00:20:58.184+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3219
06-03 00:20:58.194+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:20:58.194+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:20:58.194+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:58.194+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7153.
06-03 00:20:58.194+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:20:58.194+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:58.194+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:20:58.194+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:20:58.214+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:20:58.234+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:20:58.234+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:58.234+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:20:58.234+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:20:58.234+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:58.234+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:58.234+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:58.244+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:58.254+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:20:58.264+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:20:58.264+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:20:58.264+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:20:58.264+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:20:58.264+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:20:58.264+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=0, volume=9, ret=0x0
06-03 00:20:58.264+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:20:58.274+0900 I/TIZEN_N_SOUND_MANAGER(  900): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-03 00:20:58.274+0900 E/TIZEN_N_SOUND_MANAGER(  900): sound_manager_private.c: __convert_sound_manager_error_code(142) > [sound_manager_get_volume] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
06-03 00:20:58.274+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:58.344+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:20:58.354+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:20:59.125+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127439123
06-03 00:20:59.215+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127439211
06-03 00:20:59.215+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:20:59.215+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:20:59.215+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:20:59.235+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:20:59.235+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:20:59.245+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:20:59.245+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:20:59.245+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:20:59.275+0900 I/CAPI_APPFW_APPLICATION( 7288): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:20:59.275+0900 I/CAPI_APPFW_APPLICATION( 7288): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:20:59.305+0900 E/TBM     ( 7288): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:20:59.345+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7288, appid: org.example.example
06-03 00:20:59.345+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:20:59.345+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7288)
06-03 00:20:59.445+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:20:59.485+0900 I/APP_CORE( 7288): appcore-efl.c: __do_app(514) > [APP 7288] Event: RESET State: CREATED
06-03 00:20:59.485+0900 I/CAPI_APPFW_APPLICATION( 7288): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:20:59.485+0900 E/EFL     ( 7288): edje<7288> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:59.485+0900 E/EFL     ( 7288): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:59.495+0900 E/EFL     ( 7288): edje<7288> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:59.495+0900 E/EFL     ( 7288): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:59.495+0900 E/EFL     ( 7288): edje<7288> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:59.495+0900 E/EFL     ( 7288): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:59.495+0900 E/EFL     ( 7288): edje<7288> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:59.495+0900 E/EFL     ( 7288): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:59.495+0900 E/EFL     ( 7288): edje<7288> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:20:59.495+0900 E/EFL     ( 7288): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:20:59.525+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:59.525+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:20:59.525+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:20:59.545+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:20:59.545+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:20:59.555+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:20:59.585+0900 W/APP_CORE( 7288): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:20:59.585+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:20:59.696+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:20:59.696+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:20:59.696+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:20:59.706+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:20:59.706+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:20:59.706+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:20:59.706+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7288) status(3)
06-03 00:20:59.706+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7288)
06-03 00:20:59.706+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7288, appid: org.example.example, status: fg
06-03 00:20:59.716+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:20:59.726+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:20:59.726+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:20:59.726+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:20:59.746+0900 I/APP_CORE( 7288): appcore-efl.c: __do_app(514) > [APP 7288] Event: RESUME State: CREATED
06-03 00:20:59.756+0900 I/APP_CORE( 7288): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:20:59.756+0900 I/APP_CORE( 7288): appcore-efl.c: __do_app(625) > [APP 7288] Initial Launching, call the resume_cb
06-03 00:20:59.756+0900 I/CAPI_APPFW_APPLICATION( 7288): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:20:59.806+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:21:00.056+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7288) status(0)
06-03 00:21:00.266+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:21:00.266+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:21
06-03 00:21:00.266+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:21"
06-03 00:21:00.266+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:21"
06-03 00:21:00.276+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:21:00.276+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2145738352 Time: <font_size=31> </font_size> <font_size=31> 오전 12:21</font_size></font>"
06-03 00:21:00.386+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:21:00.386+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7288.
06-03 00:21:00.396+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3220
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
06-03 00:21:03.559+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107153657861149641685
