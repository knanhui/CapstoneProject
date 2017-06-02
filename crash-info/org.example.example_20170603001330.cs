S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 6712
Date: 2017-06-03 00:13:30+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 6712, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f31000, r3   = 0xb3f31020
r4   = 0x8001b6dc, r5   = 0xbeacd2a0
r6   = 0xb281ce5d, r7   = 0xbeacd128
r8   = 0x8001b6dc, r9   = 0xb5f13708
r10  = 0xb8a6aea0, fp   = 0xbeacd27c
ip   = 0xb6003120, sp   = 0xbeacd0e8
lr   = 0xb5fc7bd9, pc   = 0xb281ce86
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     48196 KB
Buffers:     14340 KB
Cached:     113184 KB
VmPeak:     110064 KB
VmSize:     108572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24172 KB
VmRSS:       24172 KB
VmData:      34504 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 6712 TID = 6712
6712 6714 6805 6806 

Maps Information
b1315000 b1b14000 rw-p [stack:6806]
b1b90000 b1b98000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1ba9000 b1baa000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bba000 b1bce000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1be2000 b1be3000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bf3000 b1bf6000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c07000 b1c08000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c18000 b1c1a000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c2a000 b1c2c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c3c000 b1c4c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c5c000 b1c68000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c7a000 b2479000 rw-p [stack:6805]
b27aa000 b27b1000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27c2000 b27ca000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27da000 b27ef000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b2801000 b2807000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2817000 b281f000 r-xp /opt/usr/apps/org.example.example/bin/example
b2977000 b2a5a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a91000 b2ab9000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2acb000 b32ca000 rw-p [stack:6714]
b32ca000 b32cc000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32dc000 b32e6000 r-xp /lib/libnss_files-2.20-2014.11.so
b32f7000 b3300000 r-xp /lib/libnss_nis-2.20-2014.11.so
b3311000 b3322000 r-xp /lib/libnsl-2.20-2014.11.so
b3335000 b333b000 r-xp /lib/libnss_compat-2.20-2014.11.so
b334c000 b334d000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3375000 b337c000 r-xp /usr/lib/libminizip.so.1.0.0
b338c000 b3391000 r-xp /usr/lib/libstorage.so.0.1
b33a1000 b3400000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3416000 b342a000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b343a000 b347e000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b348e000 b3496000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b34a6000 b34d6000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34e9000 b35a2000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35b6000 b3609000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b361a000 b3635000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b3645000 b3706000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3719000 b3729000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3739000 b3746000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3757000 b375e000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b376e000 b37af000 r-xp /usr/lib/libmdm.so.1.2.12
b37bf000 b37c7000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37d6000 b37e6000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b3807000 b3867000 r-xp /usr/lib/libasound.so.2.0.0
b3879000 b387c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b388c000 b388f000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b389f000 b38a4000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b38b4000 b38b5000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38c5000 b38d0000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38e4000 b38eb000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38fb000 b3901000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3911000 b3916000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3926000 b3941000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3951000 b3958000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3968000 b396b000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b397c000 b39aa000 r-xp /usr/lib/libidn.so.11.5.44
b39ba000 b39d0000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39e1000 b39eb000 r-xp /usr/lib/libcares.so.2.1.0
b39fb000 b3a05000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b3a15000 b3a17000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a27000 b3a28000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a38000 b3a3c000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a4d000 b3a75000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a86000 b3aaf000 r-xp /usr/lib/libturbojpeg.so
b3acf000 b3ad5000 r-xp /usr/lib/libgif.so.4.1.6
b3ae5000 b3b2b000 r-xp /usr/lib/libcurl.so.4.3.0
b3b3c000 b3b5d000 r-xp /usr/lib/libexif.so.12.3.3
b3b78000 b3b8d000 r-xp /usr/lib/libtts.so
b3b9e000 b3ba6000 r-xp /usr/lib/libfeedback.so.0.1.4
b3bb6000 b3c7c000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c9c000 b3d94000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3db3000 b3e81000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e98000 b3e9a000 r-xp /usr/lib/libboost_system.so.1.51.0
b3eaa000 b3eb0000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ec0000 b3ee3000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ef4000 b3ef6000 r-xp /usr/lib/libappsvc.so.0.1.0
b3f06000 b3f08000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f19000 b3f1e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f35000 b3f37000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f47000 b3f4e000 r-xp /usr/lib/libsensord-share.so
b3f5e000 b3f76000 r-xp /usr/lib/libsensor.so.1.1.0
b3f87000 b3f8a000 r-xp /usr/lib/libXv.so.1.0.0
b3f9a000 b3f9f000 r-xp /usr/lib/libutilX.so.1.1.0
b3faf000 b3fb4000 r-xp /usr/lib/libappcore-common.so.1.1
b3fc4000 b3fcb000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fde000 b3fe2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3ff3000 b40d1000 r-xp /usr/lib/libCOREGL.so.4.0
b40f1000 b40f4000 r-xp /usr/lib/libuuid.so.1.3.0
b4104000 b411b000 r-xp /usr/lib/libblkid.so.1.1.0
b412c000 b412e000 r-xp /usr/lib/libXau.so.6.0.0
b413e000 b4185000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4197000 b419d000 r-xp /usr/lib/libjson-c.so.2.0.1
b41ae000 b41b2000 r-xp /usr/lib/libogg.so.0.7.1
b41c2000 b41e4000 r-xp /usr/lib/libvorbis.so.0.4.3
b41f4000 b42d8000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42f4000 b42f7000 r-xp /usr/lib/libEGL.so.1.4
b4308000 b430e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b431e000 b4320000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4330000 b433d000 r-xp /usr/lib/libGLESv2.so.2.0
b434e000 b43b0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43c5000 b43dd000 r-xp /usr/lib/libmount.so.1.1.0
b43ef000 b4403000 r-xp /usr/lib/libxcb.so.1.1.0
b4413000 b441a000 r-xp /lib/libcrypt-2.20-2014.11.so
b4452000 b4454000 r-xp /usr/lib/libiri.so
b4464000 b446f000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4480000 b44b6000 r-xp /usr/lib/libpulse.so.0.16.2
b44c7000 b450a000 r-xp /usr/lib/libsndfile.so.1.0.25
b451f000 b4534000 r-xp /lib/libexpat.so.1.5.2
b4546000 b4604000 r-xp /usr/lib/libcairo.so.2.11200.14
b4618000 b4620000 r-xp /usr/lib/libdrm.so.2.4.0
b4630000 b4633000 r-xp /usr/lib/libdri2.so.0.0.0
b4643000 b4691000 r-xp /usr/lib/libssl.so.1.0.0
b46a6000 b46b2000 r-xp /usr/lib/libeeze.so.1.13.0
b46c3000 b46cc000 r-xp /usr/lib/libethumb.so.1.13.0
b46dc000 b46df000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46ef000 b48a6000 r-xp /usr/lib/libcrypto.so.1.0.0
b5691000 b569a000 r-xp /usr/lib/libXi.so.6.1.0
b56aa000 b56ac000 r-xp /usr/lib/libXgesture.so.7.0.0
b56bc000 b56c0000 r-xp /usr/lib/libXtst.so.6.1.0
b56d0000 b56d6000 r-xp /usr/lib/libXrender.so.1.3.0
b56e6000 b56ec000 r-xp /usr/lib/libXrandr.so.2.2.0
b56fc000 b56fe000 r-xp /usr/lib/libXinerama.so.1.0.0
b570f000 b5712000 r-xp /usr/lib/libXfixes.so.3.1.0
b5722000 b572d000 r-xp /usr/lib/libXext.so.6.4.0
b573d000 b573f000 r-xp /usr/lib/libXdamage.so.1.1.0
b574f000 b5751000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5761000 b5843000 r-xp /usr/lib/libX11.so.6.3.0
b5857000 b585e000 r-xp /usr/lib/libXcursor.so.1.0.2
b586e000 b5886000 r-xp /usr/lib/libudev.so.1.6.0
b5888000 b588b000 r-xp /lib/libattr.so.1.1.0
b589b000 b58bb000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58bc000 b58c1000 r-xp /usr/lib/libffi.so.6.0.2
b58d2000 b58ea000 r-xp /lib/libz.so.1.2.8
b58fa000 b58fc000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b590c000 b59e1000 r-xp /usr/lib/libxml2.so.2.9.2
b59f6000 b5a91000 r-xp /usr/lib/libstdc++.so.6.0.20
b5aad000 b5ab0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ac0000 b5ad9000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5aea000 b5afb000 r-xp /lib/libresolv-2.20-2014.11.so
b5b0f000 b5b89000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b9e000 b5ba0000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5bb0000 b5bb7000 r-xp /usr/lib/libembryo.so.1.13.0
b5bc7000 b5bd1000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5be2000 b5bfa000 r-xp /usr/lib/libpng12.so.0.50.0
b5c0b000 b5c2e000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c4f000 b5c63000 r-xp /usr/lib/libector.so.1.13.0
b5c74000 b5c8c000 r-xp /usr/lib/liblua-5.1.so
b5c9d000 b5cf4000 r-xp /usr/lib/libfreetype.so.6.11.3
b5d08000 b5d30000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d41000 b5d54000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d65000 b5d9f000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5db0000 b5dbe000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5dce000 b5dd6000 r-xp /usr/lib/libtbm.so.1.0.0
b5de6000 b5df3000 r-xp /usr/lib/libeio.so.1.13.0
b5e03000 b5e05000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5e15000 b5e1a000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e2a000 b5e41000 r-xp /usr/lib/libefreet.so.1.13.0
b5e53000 b5e73000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e83000 b5ea3000 r-xp /usr/lib/libecore_con.so.1.13.0
b5ea5000 b5eab000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ebb000 b5ecc000 r-xp /usr/lib/libemotion.so.1.13.0
b5edd000 b5ee4000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ef4000 b5f03000 r-xp /usr/lib/libeo.so.1.13.0
b5f14000 b5f26000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f37000 b5f3c000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f4c000 b5f65000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f75000 b5f92000 r-xp /usr/lib/libeet.so.1.13.0
b5fab000 b5ff3000 r-xp /usr/lib/libeina.so.1.13.0
b6004000 b6014000 r-xp /usr/lib/libefl.so.1.13.0
b6025000 b610a000 r-xp /usr/lib/libicuuc.so.51.1
b6127000 b6267000 r-xp /usr/lib/libicui18n.so.51.1
b627e000 b62b6000 r-xp /usr/lib/libecore_x.so.1.13.0
b62c8000 b62cb000 r-xp /lib/libcap.so.2.21
b62db000 b6304000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b6315000 b631c000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b632e000 b6365000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6376000 b6461000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6474000 b64ed000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ff000 b6504000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b6514000 b651e000 r-xp /usr/lib/libvconf.so.0.2.45
b652e000 b6530000 r-xp /usr/lib/libvasum.so.0.3.1
b6540000 b6542000 r-xp /usr/lib/libttrace.so.1.1
b6552000 b6555000 r-xp /usr/lib/libiniparser.so.0
b6565000 b658b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b659b000 b65a0000 r-xp /usr/lib/libxdgmime.so.1.1.0
b65b1000 b65c8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65d9000 b6644000 r-xp /lib/libm-2.20-2014.11.so
b6655000 b665b000 r-xp /lib/librt-2.20-2014.11.so
b666c000 b6679000 r-xp /usr/lib/libunwind.so.8.0.1
b66af000 b67d3000 r-xp /lib/libc-2.20-2014.11.so
b67e8000 b6801000 r-xp /lib/libgcc_s-4.9.so.1
b6811000 b68f3000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b6904000 b692e000 r-xp /usr/lib/libdbus-1.so.3.8.12
b693f000 b697b000 r-xp /usr/lib/libsystemd.so.0.4.0
b697d000 b6a00000 r-xp /usr/lib/libedje.so.1.13.0
b6a13000 b6a31000 r-xp /usr/lib/libecore.so.1.13.0
b6a51000 b6bd8000 r-xp /usr/lib/libevas.so.1.13.0
b6c0d000 b6c21000 r-xp /lib/libpthread-2.20-2014.11.so
b6c35000 b6e69000 r-xp /usr/lib/libelementary.so.1.13.0
b6e98000 b6e9c000 r-xp /usr/lib/libsmack.so.1.0.0
b6eac000 b6eb3000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ec3000 b6ec5000 r-xp /usr/lib/libdlog.so.0.0.0
b6ed5000 b6ed8000 r-xp /usr/lib/libbundle.so.0.1.22
b6ee8000 b6eea000 r-xp /lib/libdl-2.20-2014.11.so
b6efb000 b6f13000 r-xp /usr/lib/libaul.so.0.1.0
b6f27000 b6f2c000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f3d000 b6f4a000 r-xp /usr/lib/liblptcp.so
b6f5c000 b6f60000 r-xp /usr/lib/libsys-assert.so
b6f71000 b6f91000 r-xp /lib/ld-2.20-2014.11.so
b6fa2000 b6fa7000 r-xp /usr/bin/launchpad-loader
b8800000 b8ab9000 rw-p [heap]
beaad000 beace000 rw-p [stack]
End of Maps Information

Callstack Information (PID:6712)
Call Stack Count: 18
 0: setting_view_cb + 0x29 (0xb281ce86) [/opt/usr/apps/org.example.example/bin/example] + 0x5e86
 1: (0xb6a86175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5eff219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5efdfb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a86515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a8e725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a93f6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a97939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46de173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a1ec4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a24a5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a24c83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f2a2bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3fe0909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb281c673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6fa3bb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66c54bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6fa3eb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
6+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:13:08.326+0900 E/weather-common( 6725): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:13:08.326+0900 E/weather-agent( 6725): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:13:08.326+0900 E/weather-agent( 6725): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:13:08.326+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:13:08.326+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:08.326+0900 I/MESSAGE_PORT( 6725): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:13:08.326+0900 I/MESSAGE_PORT( 6725): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:13:08.346+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:08.376+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:13:08.376+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:13:08.376+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:08.376+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:08.376+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:08.386+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:13:08.386+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:13:08.406+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:13:08.416+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:08.426+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:1:LOCK
06-03 00:13:08.426+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:1 event_info:0
06-03 00:13:08.426+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:13:08.426+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
06-03 00:13:08.426+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [visible]
06-03 00:13:08.426+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10001:WIN_BECOME_VISIBLE
06-03 00:13:08.426+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10001 event_info:0
06-03 00:13:08.426+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
06-03 00:13:08.426+0900 W/APP_CORE(  845): appcore-efl.c: __visibility_cb(989) > LCD status is off, skip the AE_RESUME event
06-03 00:13:08.436+0900 W/INDICATOR(  646): main.c: _indicator_lock_status_cb(413) > Hide Clock
06-03 00:13:08.436+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:13:08.436+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:13:08.436+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:13:08.436+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:13:08.436+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:13:08.436+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
06-03 00:13:08.436+0900 W/LOCKSCREEN(  845): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
06-03 00:13:08.436+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
06-03 00:13:08.436+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
06-03 00:13:08.436+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
06-03 00:13:08.436+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
06-03 00:13:08.466+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:13:08.466+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:09.317+0900 E/weather-agent( 6725): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:13:09.317+0900 I/CAPI_APPFW_APPLICATION( 6725): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:13:09.317+0900 E/weather-agent( 6725): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:13:09.317+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:13:09.317+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:13:09.447+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:13:09.457+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6725
06-03 00:13:09.457+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[6725] terminate event is forwarded
06-03 00:13:09.457+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:13:09.457+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6725, ]
06-03 00:13:09.457+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:13:09.457+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:13:09.457+0900 I/Tizen::App( 1210): (512) > Not registered pid(6725)
06-03 00:13:09.457+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:13:09.457+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:13:09.457+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6725
06-03 00:13:09.457+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:13:09.457+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6725.
06-03 00:13:10.468+0900 W/LFE      (15849): [15849] 26:07:42.555[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:12.860+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
06-03 00:13:12.980+0900 W/LFE      (15849): [15849] 26:07:45.056[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:14.121+0900 W/BROWSER_PROVIDER(29519): browser-provider-requests-manager.c: bp_thread_requests_manager(892) > old client[BOOKMARK_CSC:1903049268] slot:3 sock:18
06-03 00:13:14.332+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:13:15.473+0900 W/LFE      (15849): [15849] 26:07:47.556[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:17.975+0900 W/LFE      (15849): [15849] 26:07:50.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:20.468+0900 W/LFE      (15849): [15849] 26:07:52.550[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:22.970+0900 W/LFE      (15849): [15849] 26:07:55.049[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:25.472+0900 W/LFE      (15849): [15849] 26:07:57.547[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:26.774+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 00:13:26.774+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 00:13:26.774+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 00:13:26.774+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 00:13:26.774+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 00:13:26.774+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 00:13:26.784+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 00:13:26.784+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:13:26.784+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 12:13
06-03 00:13:26.784+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 12:13"
06-03 00:13:26.784+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 12:13"
06-03 00:13:26.784+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 00:13:26.784+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146779757 Time: <font_size=31> </font_size> <font_size=31> 오전 12:13</font_size></font>"
06-03 00:13:26.784+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(7) / batt_Full:(0) / battery_charging(1)"
06-03 00:13:26.784+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 00:13:26.784+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:13:26.784+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:13:26.784+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 00:13:26.784+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 00:13:26.794+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:13:26.794+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 00:13:26.994+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 00:13:26.994+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 00:13:26.994+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 00:13:26.994+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 00:13:26.994+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:13:26.994+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 00:13:26.994+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 00:13:26.994+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:13:26.994+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 00:13:26.994+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 00:13:26.994+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 00:13:26.994+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 00:13:27.014+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 6794
06-03 00:13:27.014+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:13:27.064+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 6794
06-03 00:13:27.064+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6794, appid: com.samsung.weather-m-agent
06-03 00:13:27.074+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(6794)
06-03 00:13:27.124+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 00:13:27.124+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 6794.
06-03 00:13:27.244+0900 E/weather-agent( 6794): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 00:13:27.244+0900 E/weather-common( 6794): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 00:13:27.244+0900 E/weather-agent( 6794): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 00:13:27.244+0900 E/weather-agent( 6794): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 00:13:27.244+0900 E/weather-common( 6794): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 00:13:27.244+0900 E/weather-common( 6794): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 00:13:27.244+0900 E/weather-common( 6794): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 00:13:27.244+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 00:13:27.244+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 00:13:27.244+0900 I/MESSAGE_PORT( 6794): message-port.c: __initialize(872) > initialize
06-03 00:13:27.254+0900 I/MESSAGE_PORT( 6794): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:13:27.284+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 00:13:27.284+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 00:13:27.284+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 00:13:27.294+0900 E/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 00:13:27.294+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 00:13:27.294+0900 E/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 6794): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 00:13:27.294+0900 E/MESSAGE_PORT( 6794): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 00:13:27.294+0900 E/weather-common( 6794): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 00:13:27.294+0900 E/weather-agent( 6794): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 00:13:27.294+0900 E/weather-agent( 6794): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 00:13:27.294+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 00:13:27.304+0900 I/MESSAGE_PORT( 6794): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 00:13:27.304+0900 I/MESSAGE_PORT( 6794): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 00:13:27.304+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:27.314+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:27.354+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:13:27.354+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:13:27.354+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:27.354+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:27.354+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:27.364+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:13:27.364+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 00:13:27.414+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 00:13:27.414+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:13:27.414+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 00:13:27.424+0900 I/Internet(27388): main.cpp: __display_changed_cb(1445) > 3, (nil), 0xbe8305a0
06-03 00:13:27.424+0900 I/Internet(27388): main.cpp: __display_changed_cb(1462) > DISPLAY_STATE_SCREEN state : [0]
06-03 00:13:27.424+0900 I/Internet(27388): main.cpp: __display_changed_cb(1474) > paused
06-03 00:13:27.454+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:13:27.454+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:13:27.454+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:13:27.464+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:27.464+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 00:13:27.464+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:13:27.464+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:13:27.464+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:27.464+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:27.464+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:27.474+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:13:27.484+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:13:27.484+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:13:27.484+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:13:27.484+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:13:27.484+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:13:27.494+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126987477
06-03 00:13:27.564+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:13:27.564+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:13:27.614+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126987618
06-03 00:13:27.624+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 00:13:27.624+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 00:13:27.624+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:13:27.955+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 00:13:27.955+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 00:13:27.955+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 00:13:27.955+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 00:13:27.955+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:13:27.955+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:13:27.955+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:13:27.955+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:13:27.955+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 00:13:27.975+0900 W/LFE      (15849): [15849] 26:08:00.053[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:13:27.985+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:13:27.985+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:13:27.985+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:13:27.985+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:13:27.985+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 00:13:27.985+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 00:13:27.985+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 00:13:27.995+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:13:27.995+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:13:27.995+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 00:13:27.995+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 00:13:27.995+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 00:13:27.995+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 00:13:27.995+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 00:13:27.995+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:13:27.995+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:13:27.995+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 00:13:27.995+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 00:13:27.995+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 00:13:27.995+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 00:13:27.995+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 00:13:28.005+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:13:28.005+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:13:28.005+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:13:28.005+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:13:28.025+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:13:28.055+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [com.samsun] 
06-03 00:13:28.055+0900 I/Tizen::System( 1210): (273) > Current App[com.samsun] is already actived.
06-03 00:13:28.085+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:28.105+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 00:13:28.105+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 00:13:28.105+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 00:13:28.105+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 00:13:28.105+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 00:13:28.115+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 00:13:28.305+0900 E/weather-agent( 6794): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 00:13:28.305+0900 I/CAPI_APPFW_APPLICATION( 6794): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 00:13:28.305+0900 E/weather-agent( 6794): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 00:13:28.305+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 00:13:28.305+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 00:13:28.355+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126988355
06-03 00:13:28.425+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:13:28.435+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=126988431
06-03 00:13:28.435+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:13:28.445+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:13:28.445+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:13:28.455+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:13:28.455+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:13:28.455+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:13:28.465+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:13:28.465+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:13:28.485+0900 I/CAPI_APPFW_APPLICATION( 6712): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:13:28.485+0900 I/CAPI_APPFW_APPLICATION( 6712): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:13:28.525+0900 E/TBM     ( 6712): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:13:28.565+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 6712, appid: org.example.example
06-03 00:13:28.565+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:13:28.565+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(6712)
06-03 00:13:28.585+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:13:28.585+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 6794
06-03 00:13:28.585+0900 I/Tizen::App( 1210): (243) > App[com.samsung.weather-m-agent] pid[6794] terminate event is forwarded
06-03 00:13:28.585+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:13:28.585+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 6794, ]
06-03 00:13:28.585+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:13:28.585+0900 I/Tizen::App( 1210): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-03 00:13:28.585+0900 I/Tizen::App( 1210): (512) > Not registered pid(6794)
06-03 00:13:28.585+0900 I/Tizen::System( 1210): (246) > Terminated app [com.samsung.weather-m-agent]
06-03 00:13:28.585+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:13:28.585+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 6794
06-03 00:13:28.595+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:13:28.595+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 6794.
06-03 00:13:28.686+0900 I/APP_CORE( 6712): appcore-efl.c: __do_app(514) > [APP 6712] Event: RESET State: CREATED
06-03 00:13:28.686+0900 I/CAPI_APPFW_APPLICATION( 6712): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:13:28.686+0900 E/EFL     ( 6712): edje<6712> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:28.686+0900 E/EFL     ( 6712): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:28.686+0900 E/EFL     ( 6712): edje<6712> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:28.686+0900 E/EFL     ( 6712): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:28.686+0900 E/EFL     ( 6712): edje<6712> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:28.686+0900 E/EFL     ( 6712): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:28.686+0900 E/EFL     ( 6712): edje<6712> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:28.686+0900 E/EFL     ( 6712): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:28.686+0900 E/EFL     ( 6712): edje<6712> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:13:28.686+0900 E/EFL     ( 6712): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:13:28.726+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:13:28.726+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:13:28.726+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:13:28.746+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:13:28.746+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:13:28.746+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:13:28.766+0900 W/APP_CORE( 6712): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:8a00002
06-03 00:13:28.766+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:13:28.866+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:13:28.866+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:13:28.866+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:13:28.866+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:13:28.866+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:13:28.866+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:13:28.866+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6712) status(3)
06-03 00:13:28.876+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(6712)
06-03 00:13:28.876+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 6712, appid: org.example.example, status: fg
06-03 00:13:28.886+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:13:28.886+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:13:28.886+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:13:28.886+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:13:28.906+0900 I/APP_CORE( 6712): appcore-efl.c: __do_app(514) > [APP 6712] Event: RESUME State: CREATED
06-03 00:13:28.916+0900 I/APP_CORE( 6712): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:13:28.916+0900 I/APP_CORE( 6712): appcore-efl.c: __do_app(625) > [APP 6712] Initial Launching, call the resume_cb
06-03 00:13:28.916+0900 I/CAPI_APPFW_APPLICATION( 6712): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:13:29.226+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(6712) status(0)
06-03 00:13:29.616+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:13:29.616+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 6712.
06-03 00:13:30.097+0900 E/EFL     ( 6712): ecore_x<6712> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=126990104
06-03 00:13:30.247+0900 W/CRASH_MANAGER( 6635): worker.c: worker_job(1199) > 1106712657861149641641
