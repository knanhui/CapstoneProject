S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 7470
Date: 2017-06-03 00:22:31+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 7470, uid 5000)

Register Information
r0   = 0x8000ca66, r1   = 0x372c3034
r2   = 0xb3f1b000, r3   = 0xb3f1b020
r4   = 0x8001b2da, r5   = 0xbe99a2a0
r6   = 0xb28049a5, r7   = 0xbe99a128
r8   = 0x8001b2da, r9   = 0xb5efd708
r10  = 0xb74d1a38, fp   = 0xbe99a27c
ip   = 0xb5fed120, sp   = 0xbe99a0e8
lr   = 0xb5fb1bd9, pc   = 0xb28049ce
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     39300 KB
Buffers:     16848 KB
Cached:     111368 KB
VmPeak:     110064 KB
VmSize:     108572 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       24192 KB
VmRSS:       24192 KB
VmData:      34504 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          82 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 7470 TID = 7470
7470 7475 7778 7779 

Maps Information
b12ff000 b1afe000 rw-p [stack:7779]
b1b7a000 b1b82000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b93000 b1b94000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1ba4000 b1bb8000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bcc000 b1bcd000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bdd000 b1be0000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1bf1000 b1bf2000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c02000 b1c04000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c14000 b1c16000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c26000 b1c36000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c46000 b1c52000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c64000 b2463000 rw-p [stack:7778]
b2794000 b279b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27ac000 b27b4000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b27c4000 b27d9000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b27eb000 b27f1000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2801000 b2809000 r-xp /opt/usr/apps/org.example.example/bin/example
b2961000 b2a44000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a7b000 b2aa3000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab5000 b32b4000 rw-p [stack:7475]
b32b4000 b32b6000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c6000 b32d0000 r-xp /lib/libnss_files-2.20-2014.11.so
b32e1000 b32ea000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32fb000 b330c000 r-xp /lib/libnsl-2.20-2014.11.so
b331f000 b3325000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3336000 b3337000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335f000 b3366000 r-xp /usr/lib/libminizip.so.1.0.0
b3376000 b337b000 r-xp /usr/lib/libstorage.so.0.1
b338b000 b33ea000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b3400000 b3414000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3424000 b3468000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3478000 b3480000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3490000 b34c0000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d3000 b358c000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b35a0000 b35f3000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3604000 b361f000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362f000 b36f0000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3703000 b3713000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3723000 b3730000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3741000 b3748000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3758000 b3799000 r-xp /usr/lib/libmdm.so.1.2.12
b37a9000 b37b1000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37c0000 b37d0000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37f1000 b3851000 r-xp /usr/lib/libasound.so.2.0.0
b3863000 b3866000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3876000 b3879000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3889000 b388e000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b389e000 b389f000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38af000 b38ba000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38ce000 b38d5000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e5000 b38eb000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38fb000 b3900000 r-xp /usr/lib/libmmfsession.so.0.0.1
b3910000 b392b000 r-xp /usr/lib/libmmfsound.so.0.1.0
b393b000 b3942000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3952000 b3955000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3966000 b3994000 r-xp /usr/lib/libidn.so.11.5.44
b39a4000 b39ba000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39cb000 b39d5000 r-xp /usr/lib/libcares.so.2.1.0
b39e5000 b39ef000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39ff000 b3a01000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a11000 b3a12000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a22000 b3a26000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a37000 b3a5f000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a70000 b3a99000 r-xp /usr/lib/libturbojpeg.so
b3ab9000 b3abf000 r-xp /usr/lib/libgif.so.4.1.6
b3acf000 b3b15000 r-xp /usr/lib/libcurl.so.4.3.0
b3b26000 b3b47000 r-xp /usr/lib/libexif.so.12.3.3
b3b62000 b3b77000 r-xp /usr/lib/libtts.so
b3b88000 b3b90000 r-xp /usr/lib/libfeedback.so.0.1.4
b3ba0000 b3c66000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c86000 b3d7e000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d9d000 b3e6b000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e82000 b3e84000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e94000 b3e9a000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3eaa000 b3ecd000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ede000 b3ee0000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ef0000 b3ef2000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f03000 b3f08000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1f000 b3f21000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f31000 b3f38000 r-xp /usr/lib/libsensord-share.so
b3f48000 b3f60000 r-xp /usr/lib/libsensor.so.1.1.0
b3f71000 b3f74000 r-xp /usr/lib/libXv.so.1.0.0
b3f84000 b3f89000 r-xp /usr/lib/libutilX.so.1.1.0
b3f99000 b3f9e000 r-xp /usr/lib/libappcore-common.so.1.1
b3fae000 b3fb5000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc8000 b3fcc000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fdd000 b40bb000 r-xp /usr/lib/libCOREGL.so.4.0
b40db000 b40de000 r-xp /usr/lib/libuuid.so.1.3.0
b40ee000 b4105000 r-xp /usr/lib/libblkid.so.1.1.0
b4116000 b4118000 r-xp /usr/lib/libXau.so.6.0.0
b4128000 b416f000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4181000 b4187000 r-xp /usr/lib/libjson-c.so.2.0.1
b4198000 b419c000 r-xp /usr/lib/libogg.so.0.7.1
b41ac000 b41ce000 r-xp /usr/lib/libvorbis.so.0.4.3
b41de000 b42c2000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42de000 b42e1000 r-xp /usr/lib/libEGL.so.1.4
b42f2000 b42f8000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4308000 b430a000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b431a000 b4327000 r-xp /usr/lib/libGLESv2.so.2.0
b4338000 b439a000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43af000 b43c7000 r-xp /usr/lib/libmount.so.1.1.0
b43d9000 b43ed000 r-xp /usr/lib/libxcb.so.1.1.0
b43fd000 b4404000 r-xp /lib/libcrypt-2.20-2014.11.so
b443c000 b443e000 r-xp /usr/lib/libiri.so
b444e000 b4459000 r-xp /usr/lib/libgpg-error.so.0.15.0
b446a000 b44a0000 r-xp /usr/lib/libpulse.so.0.16.2
b44b1000 b44f4000 r-xp /usr/lib/libsndfile.so.1.0.25
b4509000 b451e000 r-xp /lib/libexpat.so.1.5.2
b4530000 b45ee000 r-xp /usr/lib/libcairo.so.2.11200.14
b4602000 b460a000 r-xp /usr/lib/libdrm.so.2.4.0
b461a000 b461d000 r-xp /usr/lib/libdri2.so.0.0.0
b462d000 b467b000 r-xp /usr/lib/libssl.so.1.0.0
b4690000 b469c000 r-xp /usr/lib/libeeze.so.1.13.0
b46ad000 b46b6000 r-xp /usr/lib/libethumb.so.1.13.0
b46c6000 b46c9000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d9000 b4890000 r-xp /usr/lib/libcrypto.so.1.0.0
b567b000 b5684000 r-xp /usr/lib/libXi.so.6.1.0
b5694000 b5696000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a6000 b56aa000 r-xp /usr/lib/libXtst.so.6.1.0
b56ba000 b56c0000 r-xp /usr/lib/libXrender.so.1.3.0
b56d0000 b56d6000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e6000 b56e8000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f9000 b56fc000 r-xp /usr/lib/libXfixes.so.3.1.0
b570c000 b5717000 r-xp /usr/lib/libXext.so.6.4.0
b5727000 b5729000 r-xp /usr/lib/libXdamage.so.1.1.0
b5739000 b573b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b574b000 b582d000 r-xp /usr/lib/libX11.so.6.3.0
b5841000 b5848000 r-xp /usr/lib/libXcursor.so.1.0.2
b5858000 b5870000 r-xp /usr/lib/libudev.so.1.6.0
b5872000 b5875000 r-xp /lib/libattr.so.1.1.0
b5885000 b58a5000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a6000 b58ab000 r-xp /usr/lib/libffi.so.6.0.2
b58bc000 b58d4000 r-xp /lib/libz.so.1.2.8
b58e4000 b58e6000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f6000 b59cb000 r-xp /usr/lib/libxml2.so.2.9.2
b59e0000 b5a7b000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a97000 b5a9a000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aaa000 b5ac3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad4000 b5ae5000 r-xp /lib/libresolv-2.20-2014.11.so
b5af9000 b5b73000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b88000 b5b8a000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b9a000 b5ba1000 r-xp /usr/lib/libembryo.so.1.13.0
b5bb1000 b5bbb000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bcc000 b5be4000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf5000 b5c18000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c39000 b5c4d000 r-xp /usr/lib/libector.so.1.13.0
b5c5e000 b5c76000 r-xp /usr/lib/liblua-5.1.so
b5c87000 b5cde000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf2000 b5d1a000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d2b000 b5d3e000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4f000 b5d89000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d9a000 b5da8000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db8000 b5dc0000 r-xp /usr/lib/libtbm.so.1.0.0
b5dd0000 b5ddd000 r-xp /usr/lib/libeio.so.1.13.0
b5ded000 b5def000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dff000 b5e04000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e14000 b5e2b000 r-xp /usr/lib/libefreet.so.1.13.0
b5e3d000 b5e5d000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e6d000 b5e8d000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8f000 b5e95000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea5000 b5eb6000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec7000 b5ece000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ede000 b5eed000 r-xp /usr/lib/libeo.so.1.13.0
b5efe000 b5f10000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f21000 b5f26000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f36000 b5f4f000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5f000 b5f7c000 r-xp /usr/lib/libeet.so.1.13.0
b5f95000 b5fdd000 r-xp /usr/lib/libeina.so.1.13.0
b5fee000 b5ffe000 r-xp /usr/lib/libefl.so.1.13.0
b600f000 b60f4000 r-xp /usr/lib/libicuuc.so.51.1
b6111000 b6251000 r-xp /usr/lib/libicui18n.so.51.1
b6268000 b62a0000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b2000 b62b5000 r-xp /lib/libcap.so.2.21
b62c5000 b62ee000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62ff000 b6306000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6318000 b634f000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6360000 b644b000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b645e000 b64d7000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e9000 b64ee000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64fe000 b6508000 r-xp /usr/lib/libvconf.so.0.2.45
b6518000 b651a000 r-xp /usr/lib/libvasum.so.0.3.1
b652a000 b652c000 r-xp /usr/lib/libttrace.so.1.1
b653c000 b653f000 r-xp /usr/lib/libiniparser.so.0
b654f000 b6575000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6585000 b658a000 r-xp /usr/lib/libxdgmime.so.1.1.0
b659b000 b65b2000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c3000 b662e000 r-xp /lib/libm-2.20-2014.11.so
b663f000 b6645000 r-xp /lib/librt-2.20-2014.11.so
b6656000 b6663000 r-xp /usr/lib/libunwind.so.8.0.1
b6699000 b67bd000 r-xp /lib/libc-2.20-2014.11.so
b67d2000 b67eb000 r-xp /lib/libgcc_s-4.9.so.1
b67fb000 b68dd000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ee000 b6918000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6929000 b6965000 r-xp /usr/lib/libsystemd.so.0.4.0
b6967000 b69ea000 r-xp /usr/lib/libedje.so.1.13.0
b69fd000 b6a1b000 r-xp /usr/lib/libecore.so.1.13.0
b6a3b000 b6bc2000 r-xp /usr/lib/libevas.so.1.13.0
b6bf7000 b6c0b000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1f000 b6e53000 r-xp /usr/lib/libelementary.so.1.13.0
b6e82000 b6e86000 r-xp /usr/lib/libsmack.so.1.0.0
b6e96000 b6e9d000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ead000 b6eaf000 r-xp /usr/lib/libdlog.so.0.0.0
b6ebf000 b6ec2000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed2000 b6ed4000 r-xp /lib/libdl-2.20-2014.11.so
b6ee5000 b6efd000 r-xp /usr/lib/libaul.so.0.1.0
b6f11000 b6f16000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f27000 b6f34000 r-xp /usr/lib/liblptcp.so
b6f46000 b6f4a000 r-xp /usr/lib/libsys-assert.so
b6f5b000 b6f7b000 r-xp /lib/ld-2.20-2014.11.so
b6f8c000 b6f91000 r-xp /usr/bin/launchpad-loader
b7267000 b7520000 rw-p [heap]
be97a000 be99b000 rw-p [stack]
End of Maps Information

Callstack Information (PID:7470)
Call Stack Count: 18
 0: feeding_view_cb + 0x29 (0xb28049ce) [/opt/usr/apps/org.example.example/bin/example] + 0x39ce
 1: (0xb6a70175) [/usr/lib/libevas.so.1] + 0x35175
 2: (0xb5ee9219) [/usr/lib/libeo.so.1] + 0xb219
 3: eo_event_callback_call + 0x68 (0xb5ee7fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 4: (0xb6a70515) [/usr/lib/libevas.so.1] + 0x35515
 5: (0xb6a78725) [/usr/lib/libevas.so.1] + 0x3d725
 6: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a7df6b) [/usr/lib/libevas.so.1] + 0x42f6b
 7: evas_event_feed_mouse_down + 0x30 (0xb6a81939) [/usr/lib/libevas.so.1] + 0x46939
 8: (0xb46c8173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
 9: (0xb6a08c4b) [/usr/lib/libecore.so.1] + 0xbc4b
10: (0xb6a0ea5d) [/usr/lib/libecore.so.1] + 0x11a5d
11: ecore_main_loop_begin + 0x3e (0xb6a0ec83) [/usr/lib/libecore.so.1] + 0x11c83
12: appcore_efl_main + 0x20c (0xb6f142bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
13: ui_app_main + 0xc0 (0xb3fca909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
14: main + 0x10e (0xb2806673) [/opt/usr/apps/org.example.example/bin/example] + 0x5673
15: (0xb6f8dbb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
16: __libc_start_main + 0x114 (0xb66af4bc) [/lib/libc.so.6] + 0x164bc
17: (0xb6f8deb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
t_handler: 22
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
06-03 00:22:21.816+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 11074736578611496416941
06-03 00:22:21.846+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:21.846+0900 W/AUL_AMD (  610): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-03 00:22:21.846+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[7473] terminate event is forwarded
06-03 00:22:21.846+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 00:22:21.846+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 7473, ]
06-03 00:22:21.846+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 00:22:21.846+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 00:22:21.846+0900 I/Tizen::App( 1210): (512) > Not registered pid(7473)
06-03 00:22:21.846+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 00:22:21.846+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:21.846+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7473
06-03 00:22:21.846+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 7473
06-03 00:22:21.846+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 7473
06-03 00:22:21.856+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 00:22:21.856+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 00:22:21.876+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 00:22:21.876+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 00:22:21.876+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 00:22:21.856+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:21.876+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 00:22:21.876+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 7473.
06-03 00:22:21.886+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 00:22:21.936+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:21.936+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 00:22:21.936+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:21.936+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 00:22:21.946+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:21.946+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:21.966+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:21.976+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 00:22:21.976+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 00:22:21.976+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:21.986+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 00:22:21.986+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 00:22:21.986+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 00:22:21.986+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 00:22:21.986+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 00:22:21.996+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:22.076+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 00:22:22.086+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 00:22:22.967+0900 W/LFE      (15849): [15849] 26:16:55.051[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:23.918+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127523923
06-03 00:22:23.998+0900 E/EFL     (  860): ecore_x<860> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127523999
06-03 00:22:23.998+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.example)
06-03 00:22:23.998+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 1
06-03 00:22:23.998+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 860
06-03 00:22:24.008+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 8
06-03 00:22:24.008+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 00:22:24.018+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 00:22:24.018+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 00:22:24.018+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 00:22:24.038+0900 I/CAPI_APPFW_APPLICATION( 7470): app_main.c: ui_app_main(789) > app_efl_main
06-03 00:22:24.038+0900 I/CAPI_APPFW_APPLICATION( 7470): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 00:22:24.068+0900 E/TBM     ( 7470): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 00:22:24.118+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7470, appid: org.example.example
06-03 00:22:24.118+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 00:22:24.118+0900 W/AUL     (  860): launch.c: app_request_to_launchpad(425) > request cmd(1) result(7470)
06-03 00:22:24.248+0900 I/APP_CORE( 7470): appcore-efl.c: __do_app(514) > [APP 7470] Event: RESET State: CREATED
06-03 00:22:24.248+0900 I/CAPI_APPFW_APPLICATION( 7470): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 00:22:24.248+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.248+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.258+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.258+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.258+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.258+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.258+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.258+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.258+0900 E/EFL     ( 7470): edje<7470> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 00:22:24.258+0900 E/EFL     ( 7470): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 00:22:24.288+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:24.288+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 00:22:24.308+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 00:22:24.318+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 00:22:24.318+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 00:22:24.328+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 00:22:24.358+0900 W/APP_CORE( 7470): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:9c00002
06-03 00:22:24.358+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 00:22:24.458+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: PAUSE State: RUNNING
06-03 00:22:24.458+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 00:22:24.458+0900 E/cluster-home(  860): homescreen.cpp: OnPause(260) >  app pause
06-03 00:22:24.458+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(4)
06-03 00:22:24.458+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(860)
06-03 00:22:24.458+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: bg
06-03 00:22:24.458+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7470) status(3)
06-03 00:22:24.468+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(7470)
06-03 00:22:24.468+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 7470, appid: org.example.example, status: fg
06-03 00:22:24.478+0900 E/weather-widget( 1360): Widget4x4Page.cpp: SetRefreshButton(72) > [0;40;31m[SetRefreshButton(): 72] (mCityLayout == NULL) [return][0;m
06-03 00:22:24.488+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_pause_cb(304) > widget obj was paused
06-03 00:22:24.488+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(152) > enter background group
06-03 00:22:24.488+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: bg
06-03 00:22:24.508+0900 I/APP_CORE( 7470): appcore-efl.c: __do_app(514) > [APP 7470] Event: RESUME State: CREATED
06-03 00:22:24.518+0900 I/APP_CORE( 7470): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 00:22:24.518+0900 I/APP_CORE( 7470): appcore-efl.c: __do_app(625) > [APP 7470] Initial Launching, call the resume_cb
06-03 00:22:24.518+0900 I/CAPI_APPFW_APPLICATION( 7470): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 00:22:24.829+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(7470) status(0)
06-03 00:22:25.149+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3247
06-03 00:22:25.159+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 00:22:25.159+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 7470.
06-03 00:22:25.459+0900 W/LFE      (15849): [15849] 26:16:57.544[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:25.940+0900 I/UXT     ( 7780): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 00:22:26.240+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 00:22:26.340+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-03 00:22:27.932+0900 E/EFL     ( 7470): ecore_x<7470> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127527929
06-03 00:22:27.972+0900 W/LFE      (15849): [15849] 26:17:00.050[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:27.982+0900 E/EFL     ( 7470): ecore_x<7470> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=127527983
06-03 00:22:29.473+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: MEM_FLUSH State: PAUSED
06-03 00:22:30.474+0900 W/LFE      (15849): [15849] 26:17:02.551[F:lfeBoost.cpp     L:   84][00][HIGH] [32mCPU Boost(0xb9534590) On[0m
06-03 00:22:30.995+0900 I/Tizen::Net::Wifi( 1210): (941) > The background scan result updated.
06-03 00:22:31.315+0900 E/EFL     ( 7470): ecore_x<7470> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=127531313
06-03 00:22:31.485+0900 W/CRASH_MANAGER( 7269): worker.c: worker_job(1199) > 1107470657861149641695
