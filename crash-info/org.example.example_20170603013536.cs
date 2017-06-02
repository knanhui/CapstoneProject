S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: example
PID: 9244
Date: 2017-06-03 01:35:36+0900
Executable File Path: /opt/usr/apps/org.example.example/bin/example
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 9244, uid 5000)

Register Information
r0   = 0xb27c9dbc, r1   = 0x8000ca66
r2   = 0x8000ca66, r3   = 0x80020f08
r4   = 0x8001b6dc, r5   = 0xbe9ec2a0
r6   = 0xb27b7e61, r7   = 0xbe9ec0e8
r8   = 0x8001b6dc, r9   = 0xb5eae708
r10  = 0xb77e2d50, fp   = 0xbe9ec27c
ip   = 0xb27c9a70, sp   = 0xbe9ec028
lr   = 0x00000000, pc   = 0xb27b7ef2
cpsr = 0x800f0030

Memory Information
MemTotal:   987012 KB
MemFree:     59100 KB
Buffers:     11912 KB
Cached:     105576 KB
VmPeak:     111660 KB
VmSize:     106708 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       29024 KB
VmRSS:       27144 KB
VmData:      28992 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35728 KB
VmPTE:          88 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9244 TID = 9244
9244 9246 9466 

Maps Information
b1b2b000 b1b33000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b1b44000 b1b45000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b55000 b1b69000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1b7d000 b1b7e000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1b8e000 b1b91000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1ba2000 b1ba3000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bb3000 b1bb5000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1bc5000 b1bc7000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1bd7000 b1be7000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1bf7000 b1c03000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c15000 b2414000 rw-p [stack:9466]
b2745000 b274c000 r-xp /usr/lib/libefl-extension.so.0.1.0
b275d000 b2765000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b2775000 b278a000 r-xp /usr/lib/libbase-utils-i18n.so.1.0.8
b279c000 b27a2000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27b2000 b27ba000 r-xp /opt/usr/apps/org.example.example/bin/example
b2912000 b29f5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a2c000 b2a54000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a66000 b3265000 rw-p [stack:9246]
b3265000 b3267000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b3277000 b3281000 r-xp /lib/libnss_files-2.20-2014.11.so
b3292000 b329b000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32ac000 b32bd000 r-xp /lib/libnsl-2.20-2014.11.so
b32d0000 b32d6000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32e7000 b32e8000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3310000 b3317000 r-xp /usr/lib/libminizip.so.1.0.0
b3327000 b332c000 r-xp /usr/lib/libstorage.so.0.1
b333c000 b339b000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33b1000 b33c5000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33d5000 b3419000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3429000 b3431000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3441000 b3471000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3484000 b353d000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3551000 b35a4000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35b5000 b35d0000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35e0000 b36a1000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36b4000 b36c4000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36d4000 b36e1000 r-xp /usr/lib/libmdm-common.so.1.0.98
b36f2000 b36f9000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3709000 b374a000 r-xp /usr/lib/libmdm.so.1.2.12
b375a000 b3762000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3771000 b3781000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37a2000 b3802000 r-xp /usr/lib/libasound.so.2.0.0
b3814000 b3817000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3827000 b382a000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b383a000 b383f000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b384f000 b3850000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3860000 b386b000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b387f000 b3886000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3896000 b389c000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38ac000 b38b1000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38c1000 b38dc000 r-xp /usr/lib/libmmfsound.so.0.1.0
b38ec000 b38f3000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3903000 b3906000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3917000 b3945000 r-xp /usr/lib/libidn.so.11.5.44
b3955000 b396b000 r-xp /usr/lib/libnghttp2.so.5.4.0
b397c000 b3986000 r-xp /usr/lib/libcares.so.2.1.0
b3996000 b39a0000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39b0000 b39b2000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39c2000 b39c3000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39d3000 b39d7000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39e8000 b3a10000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a21000 b3a4a000 r-xp /usr/lib/libturbojpeg.so
b3a6a000 b3a70000 r-xp /usr/lib/libgif.so.4.1.6
b3a80000 b3ac6000 r-xp /usr/lib/libcurl.so.4.3.0
b3ad7000 b3af8000 r-xp /usr/lib/libexif.so.12.3.3
b3b13000 b3b28000 r-xp /usr/lib/libtts.so
b3b39000 b3b41000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b51000 b3c17000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c37000 b3d2f000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d4e000 b3e1c000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e33000 b3e35000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e45000 b3e4b000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e5b000 b3e7e000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3e8f000 b3e91000 r-xp /usr/lib/libappsvc.so.0.1.0
b3ea1000 b3ea3000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3eb4000 b3eb9000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ed0000 b3ed2000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ee2000 b3ee9000 r-xp /usr/lib/libsensord-share.so
b3ef9000 b3f11000 r-xp /usr/lib/libsensor.so.1.1.0
b3f22000 b3f25000 r-xp /usr/lib/libXv.so.1.0.0
b3f35000 b3f3a000 r-xp /usr/lib/libutilX.so.1.1.0
b3f4a000 b3f4f000 r-xp /usr/lib/libappcore-common.so.1.1
b3f5f000 b3f66000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f79000 b3f7d000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3f8e000 b406c000 r-xp /usr/lib/libCOREGL.so.4.0
b408c000 b408f000 r-xp /usr/lib/libuuid.so.1.3.0
b409f000 b40b6000 r-xp /usr/lib/libblkid.so.1.1.0
b40c7000 b40c9000 r-xp /usr/lib/libXau.so.6.0.0
b40d9000 b4120000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4132000 b4138000 r-xp /usr/lib/libjson-c.so.2.0.1
b4149000 b414d000 r-xp /usr/lib/libogg.so.0.7.1
b415d000 b417f000 r-xp /usr/lib/libvorbis.so.0.4.3
b418f000 b4273000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b428f000 b4292000 r-xp /usr/lib/libEGL.so.1.4
b42a3000 b42a9000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42b9000 b42bb000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42cb000 b42d8000 r-xp /usr/lib/libGLESv2.so.2.0
b42e9000 b434b000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4360000 b4378000 r-xp /usr/lib/libmount.so.1.1.0
b438a000 b439e000 r-xp /usr/lib/libxcb.so.1.1.0
b43ae000 b43b5000 r-xp /lib/libcrypt-2.20-2014.11.so
b43ed000 b43ef000 r-xp /usr/lib/libiri.so
b43ff000 b440a000 r-xp /usr/lib/libgpg-error.so.0.15.0
b441b000 b4451000 r-xp /usr/lib/libpulse.so.0.16.2
b4462000 b44a5000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ba000 b44cf000 r-xp /lib/libexpat.so.1.5.2
b44e1000 b459f000 r-xp /usr/lib/libcairo.so.2.11200.14
b45b3000 b45bb000 r-xp /usr/lib/libdrm.so.2.4.0
b45cb000 b45ce000 r-xp /usr/lib/libdri2.so.0.0.0
b45de000 b462c000 r-xp /usr/lib/libssl.so.1.0.0
b4641000 b464d000 r-xp /usr/lib/libeeze.so.1.13.0
b465e000 b4667000 r-xp /usr/lib/libethumb.so.1.13.0
b4677000 b467a000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b468a000 b4841000 r-xp /usr/lib/libcrypto.so.1.0.0
b562c000 b5635000 r-xp /usr/lib/libXi.so.6.1.0
b5645000 b5647000 r-xp /usr/lib/libXgesture.so.7.0.0
b5657000 b565b000 r-xp /usr/lib/libXtst.so.6.1.0
b566b000 b5671000 r-xp /usr/lib/libXrender.so.1.3.0
b5681000 b5687000 r-xp /usr/lib/libXrandr.so.2.2.0
b5697000 b5699000 r-xp /usr/lib/libXinerama.so.1.0.0
b56aa000 b56ad000 r-xp /usr/lib/libXfixes.so.3.1.0
b56bd000 b56c8000 r-xp /usr/lib/libXext.so.6.4.0
b56d8000 b56da000 r-xp /usr/lib/libXdamage.so.1.1.0
b56ea000 b56ec000 r-xp /usr/lib/libXcomposite.so.1.0.0
b56fc000 b57de000 r-xp /usr/lib/libX11.so.6.3.0
b57f2000 b57f9000 r-xp /usr/lib/libXcursor.so.1.0.2
b5809000 b5821000 r-xp /usr/lib/libudev.so.1.6.0
b5823000 b5826000 r-xp /lib/libattr.so.1.1.0
b5836000 b5856000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5857000 b585c000 r-xp /usr/lib/libffi.so.6.0.2
b586d000 b5885000 r-xp /lib/libz.so.1.2.8
b5895000 b5897000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58a7000 b597c000 r-xp /usr/lib/libxml2.so.2.9.2
b5991000 b5a2c000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a48000 b5a4b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a5b000 b5a74000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a85000 b5a96000 r-xp /lib/libresolv-2.20-2014.11.so
b5aaa000 b5b24000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b39000 b5b3b000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b4b000 b5b52000 r-xp /usr/lib/libembryo.so.1.13.0
b5b62000 b5b6c000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b7d000 b5b95000 r-xp /usr/lib/libpng12.so.0.50.0
b5ba6000 b5bc9000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bea000 b5bfe000 r-xp /usr/lib/libector.so.1.13.0
b5c0f000 b5c27000 r-xp /usr/lib/liblua-5.1.so
b5c38000 b5c8f000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ca3000 b5ccb000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cdc000 b5cef000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d00000 b5d3a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d4b000 b5d59000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d69000 b5d71000 r-xp /usr/lib/libtbm.so.1.0.0
b5d81000 b5d8e000 r-xp /usr/lib/libeio.so.1.13.0
b5d9e000 b5da0000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5db0000 b5db5000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dc5000 b5ddc000 r-xp /usr/lib/libefreet.so.1.13.0
b5dee000 b5e0e000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e1e000 b5e3e000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e40000 b5e46000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e56000 b5e67000 r-xp /usr/lib/libemotion.so.1.13.0
b5e78000 b5e7f000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5e8f000 b5e9e000 r-xp /usr/lib/libeo.so.1.13.0
b5eaf000 b5ec1000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ed2000 b5ed7000 r-xp /usr/lib/libecore_file.so.1.13.0
b5ee7000 b5f00000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f10000 b5f2d000 r-xp /usr/lib/libeet.so.1.13.0
b5f46000 b5f8e000 r-xp /usr/lib/libeina.so.1.13.0
b5f9f000 b5faf000 r-xp /usr/lib/libefl.so.1.13.0
b5fc0000 b60a5000 r-xp /usr/lib/libicuuc.so.51.1
b60c2000 b6202000 r-xp /usr/lib/libicui18n.so.51.1
b6219000 b6251000 r-xp /usr/lib/libecore_x.so.1.13.0
b6263000 b6266000 r-xp /lib/libcap.so.2.21
b6276000 b629f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62b0000 b62b7000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62c9000 b6300000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6311000 b63fc000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b640f000 b6488000 r-xp /usr/lib/libsqlite3.so.0.8.6
b649a000 b649f000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64af000 b64b9000 r-xp /usr/lib/libvconf.so.0.2.45
b64c9000 b64cb000 r-xp /usr/lib/libvasum.so.0.3.1
b64db000 b64dd000 r-xp /usr/lib/libttrace.so.1.1
b64ed000 b64f0000 r-xp /usr/lib/libiniparser.so.0
b6500000 b6526000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6536000 b653b000 r-xp /usr/lib/libxdgmime.so.1.1.0
b654c000 b6563000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6574000 b65df000 r-xp /lib/libm-2.20-2014.11.so
b65f0000 b65f6000 r-xp /lib/librt-2.20-2014.11.so
b6607000 b6614000 r-xp /usr/lib/libunwind.so.8.0.1
b664a000 b676e000 r-xp /lib/libc-2.20-2014.11.so
b6783000 b679c000 r-xp /lib/libgcc_s-4.9.so.1
b67ac000 b688e000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b689f000 b68c9000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68da000 b6916000 r-xp /usr/lib/libsystemd.so.0.4.0
b6918000 b699b000 r-xp /usr/lib/libedje.so.1.13.0
b69ae000 b69cc000 r-xp /usr/lib/libecore.so.1.13.0
b69ec000 b6b73000 r-xp /usr/lib/libevas.so.1.13.0
b6ba8000 b6bbc000 r-xp /lib/libpthread-2.20-2014.11.so
b6bd0000 b6e04000 r-xp /usr/lib/libelementary.so.1.13.0
b6e33000 b6e37000 r-xp /usr/lib/libsmack.so.1.0.0
b6e47000 b6e4e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e5e000 b6e60000 r-xp /usr/lib/libdlog.so.0.0.0
b6e70000 b6e73000 r-xp /usr/lib/libbundle.so.0.1.22
b6e83000 b6e85000 r-xp /lib/libdl-2.20-2014.11.so
b6e96000 b6eae000 r-xp /usr/lib/libaul.so.0.1.0
b6ec2000 b6ec7000 r-xp /usr/lib/libappcore-efl.so.1.1
b6ed8000 b6ee5000 r-xp /usr/lib/liblptcp.so
b6ef7000 b6efb000 r-xp /usr/lib/libsys-assert.so
b6f0c000 b6f2c000 r-xp /lib/ld-2.20-2014.11.so
b6f3d000 b6f42000 r-xp /usr/bin/launchpad-loader
b7578000 b7833000 rw-p [heap]
be9cc000 be9ed000 rw-p [stack]
End of Maps Information

Callstack Information (PID:9244)
Call Stack Count: 19
 0: create_button_view + 0x1d (0xb27b7ef2) [/opt/usr/apps/org.example.example/bin/example] + 0x5ef2
 1: setting_view_cb + 0x2c (0xb27b7e8d) [/opt/usr/apps/org.example.example/bin/example] + 0x5e8d
 2: (0xb6a21175) [/usr/lib/libevas.so.1] + 0x35175
 3: (0xb5e9a219) [/usr/lib/libeo.so.1] + 0xb219
 4: eo_event_callback_call + 0x68 (0xb5e98fb9) [/usr/lib/libeo.so.1] + 0x9fb9
 5: (0xb6a21515) [/usr/lib/libevas.so.1] + 0x35515
 6: (0xb6a29725) [/usr/lib/libevas.so.1] + 0x3d725
 7: evas_canvas_event_feed_mouse_down + 0x6a (0xb6a2ef6b) [/usr/lib/libevas.so.1] + 0x42f6b
 8: evas_event_feed_mouse_down + 0x30 (0xb6a32939) [/usr/lib/libevas.so.1] + 0x46939
 9: (0xb4679173) [/usr/lib/libecore_input_evas.so.1] + 0x2173
10: (0xb69b9c4b) [/usr/lib/libecore.so.1] + 0xbc4b
11: (0xb69bfa5d) [/usr/lib/libecore.so.1] + 0x11a5d
12: ecore_main_loop_begin + 0x3e (0xb69bfc83) [/usr/lib/libecore.so.1] + 0x11c83
13: appcore_efl_main + 0x20c (0xb6ec52bd) [/usr/lib/libappcore-efl.so.1] + 0x32bd
14: ui_app_main + 0xc0 (0xb3f7b909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
15: main + 0x10e (0xb27b7677) [/opt/usr/apps/org.example.example/bin/example] + 0x5677
16: (0xb6f3ebb5) [/opt/usr/apps/org.example.example/bin/example] + 0x1bb5
17: __libc_start_main + 0x114 (0xb66604bc) [/lib/libc.so.6] + 0x164bc
18: (0xb6f3eeb4) [/opt/usr/apps/org.example.example/bin/example] + 0x1eb4
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
03 01:35:25.302+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [30], install = [96]
06-03 01:35:25.302+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.302+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.302+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.302+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.542+0900 E/rpm-installer( 9403): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
06-03 01:35:25.542+0900 E/rpm-installer( 9403): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
06-03 01:35:25.542+0900 E/rpm-installer( 9403): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
06-03 01:35:25.542+0900 E/rpm-installer( 9403): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
06-03 01:35:25.552+0900 E/rpm-installer( 9403): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
06-03 01:35:25.552+0900 E/rpm-installer( 9403): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
06-03 01:35:25.552+0900 E/PKGMGR_PARSER( 9403): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
06-03 01:35:25.562+0900 E/PKGMGR_PARSER( 9403): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
06-03 01:35:25.613+0900 I/PRIVACY-MANAGER-CLIENT( 9403): SocketClient.cpp: SocketClient(37) > Client created
06-03 01:35:25.863+0900 E/PKGMGR_PARSER( 9403): pkgmgr_parser.c: __check_theme(142) > theme for installation.
06-03 01:35:25.893+0900 E/PKGMGR_CERT( 9403): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-03 01:35:25.893+0900 E/PKGMGR_CERT( 9403): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 107
06-03 01:35:25.893+0900 E/PKGMGR_CERT( 9403): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 107
06-03 01:35:25.893+0900 E/PKGMGR_CERT( 9403): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 44 2
06-03 01:35:25.893+0900 E/PKGMGR_CERT( 9403): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 45 2
06-03 01:35:25.893+0900 E/PKGMGR_CERT( 9403): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 46 2
06-03 01:35:25.893+0900 E/PKGMGR_CERT( 9403): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 47 2
06-03 01:35:25.903+0900 E/PKGMGR_CERT( 9403): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
06-03 01:35:25.903+0900 E/rpm-installer( 9403): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1956) > skip! empty dirpath=[/opt/usr/apps/org.example.example/lib]
06-03 01:35:25.903+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 60
06-03 01:35:25.913+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [60]
06-03 01:35:25.913+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [60], install = [96]
06-03 01:35:25.913+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.913+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.913+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.913+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.933+0900 E/rpm-installer( 9403): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
06-03 01:35:25.963+0900 E/rpm-installer( 9403): coretpk-installer.c: __post_install_for_mmc(652) > (handle == NULL) handle is NULL.
06-03 01:35:25.973+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: install_percent, val: 100
06-03 01:35:25.973+0900 I/Tizen::App( 1210): (119) > InstallationInProgress [100]
06-03 01:35:25.973+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [install_percent], Value = [100], install = [96]
06-03 01:35:25.973+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.973+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.973+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:25.973+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:26.003+0900 E/PKGMGR_SERVER( 9392): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:35:27.985+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
06-03 01:35:27.985+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
06-03 01:35:27.985+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
06-03 01:35:27.985+0900 I/Tizen::App( 1210): (1894) > PackageEventHandler - req: 12100002, pkg_type: tpk, pkg_name: org.example.example, key: end, val: ok
06-03 01:35:27.985+0900 I/Tizen::App( 1210): (78) > Installation is Completed. [Package = org.example.example]
06-03 01:35:27.985+0900 I/Tizen::App( 1210): (671) > Enter. package(org.example.example), installationResult(0)
06-03 01:35:27.995+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:27.995+0900 I/Tizen::App( 1210): (1360) > package(org.example.example), version(1.0.0), type(tpk), displayName(forpet), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.example), storeClient(), appRootPath(/opt/usr/apps/org.example.example)
06-03 01:35:28.005+0900 E/PKGMGR_SERVER( 9392): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
06-03 01:35:28.015+0900 E/PKGMGR_SERVER( 9392): pkgmgr-server.c: sighandler(417) > child NORMAL exit [9403]
06-03 01:35:28.025+0900 W/ISF_PANEL_EFL(  768): isf_panel_efl.cpp: _package_manager_event_cb(1513) > _isf_insert_ime_info_by_pkgid returned 0.
06-03 01:35:28.025+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:28.025+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:28.035+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.example]
06-03 01:35:28.035+0900 E/PKGMGR  ( 1863): pkgmgr.c: __find_op_cbinfo(312) > tmp is NULL
06-03 01:35:28.035+0900 I/Tizen::App( 1210): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.example]
06-03 01:35:28.035+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.example]
06-03 01:35:28.035+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
06-03 01:35:28.035+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
06-03 01:35:28.035+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.example]
06-03 01:35:28.045+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:35:28.045+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:35:28.055+0900 E/PKGMGR_INFO( 1210): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-03 01:35:28.055+0900 I/Tizen::App( 1210): (683) > Application count(1) in this package
06-03 01:35:28.055+0900 I/Tizen::App( 1210): (840) > Enter.
06-03 01:35:28.055+0900 I/Tizen::App( 1210): (703) > Exit.
06-03 01:35:28.055+0900 I/Tizen::App( 1210): (1584) > Package = [org.example.example], Key = [end], Value = [ok], install = [96]
06-03 01:35:28.055+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[forpet] enable[1] system[0]
06-03 01:35:28.055+0900 E/HOME_APPS(  860): mainmenu-package-manager.cpp: _DoPkgJob(484) >  appId[org.example.example] mdm is not enabled
06-03 01:35:28.055+0900 E/cluster-home(  860): mainmenu-data-manager.cpp: GetBoxDataByAppId(2539) >  cannot find box with appid[org.example.example]
06-03 01:35:28.065+0900 I/Tizen::App( 1210): (416) > appName = [example]
06-03 01:35:28.065+0900 I/Tizen::App( 1210): (509) > exe = [/opt/usr/apps/org.example.example/bin/example], displayName = [forpet], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-03 01:35:28.065+0900 I/Tizen::App( 1210): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.example.info]
06-03 01:35:28.065+0900 I/Tizen::App( 1210): (131) > Enter
06-03 01:35:28.065+0900 I/Tizen::App( 1210): (137) > org.example.example does not have launch condition
06-03 01:35:28.065+0900 I/Tizen::App( 1210): (883) > Exit.
06-03 01:35:28.075+0900 E/cluster-home(  860): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[forpet] enable[1] system[0]
06-03 01:35:28.085+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:35:28.085+0900 E/util-view(  860): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
06-03 01:35:29.997+0900 E/PKGMGR_SERVER( 9392): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
06-03 01:35:29.997+0900 E/PKGMGR_SERVER( 9392): pkgmgr-server.c: main(2471) > package manager server terminated.
06-03 01:35:32.609+0900 W/AUL     ( 9459): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.example)
06-03 01:35:32.609+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:35:32.619+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
06-03 01:35:32.629+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
06-03 01:35:32.629+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
06-03 01:35:32.629+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 9459
06-03 01:35:32.629+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
06-03 01:35:32.649+0900 E/RESOURCED(  653): block.c: block_prelaunch_state(134) > insert data org.example.example, table num : 9
06-03 01:35:32.649+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:35:32.649+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
06-03 01:35:32.649+0900 W/AUL_PAD ( 1359): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-03 01:35:32.649+0900 W/AUL_PAD ( 1359): launchpad.c: __send_result_to_caller(267) > Check app launching
06-03 01:35:32.679+0900 I/CAPI_APPFW_APPLICATION( 9244): app_main.c: ui_app_main(789) > app_efl_main
06-03 01:35:32.679+0900 I/CAPI_APPFW_APPLICATION( 9244): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-03 01:35:32.739+0900 E/TBM     ( 9244): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-03 01:35:32.759+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9244, appid: org.example.example
06-03 01:35:32.759+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-03 01:35:32.759+0900 W/AUL     ( 9459): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9244)
06-03 01:35:33.030+0900 I/APP_CORE( 9244): appcore-efl.c: __do_app(514) > [APP 9244] Event: RESET State: CREATED
06-03 01:35:33.030+0900 I/CAPI_APPFW_APPLICATION( 9244): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
06-03 01:35:33.030+0900 E/EFL     ( 9244): edje<9244> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:35:33.030+0900 E/EFL     ( 9244): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:35:33.030+0900 E/EFL     ( 9244): edje<9244> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:35:33.030+0900 E/EFL     ( 9244): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:35:33.040+0900 E/EFL     ( 9244): edje<9244> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:35:33.040+0900 E/EFL     ( 9244): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:35:33.040+0900 E/EFL     ( 9244): edje<9244> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:35:33.040+0900 E/EFL     ( 9244): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:35:33.040+0900 E/EFL     ( 9244): edje<9244> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
06-03 01:35:33.040+0900 E/EFL     ( 9244): By the power of Grayskull, your previous Embryo stack is now broken!
06-03 01:35:33.050+0900 W/APP_CORE( 9244): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5800002
06-03 01:35:33.050+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
06-03 01:35:33.200+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9244) status(4)
06-03 01:35:33.290+0900 I/APP_CORE( 9244): appcore-efl.c: __do_app(514) > [APP 9244] Event: PAUSE State: CREATED
06-03 01:35:33.330+0900 I/TIZEN_N_EFL_UTIL_WINDOW( 9244): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 28
06-03 01:35:33.330+0900 E/APP_CORE( 9244): appcore-efl.c: _capture_and_make_file(1619) > win[5800002] widget[720] height[1280]
06-03 01:35:33.330+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
06-03 01:35:33.550+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9244) status(0)
06-03 01:35:33.760+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:35:33.760+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
06-03 01:35:33.801+0900 I/Tizen::App( 1210): (499) > LaunchedApp(org.example.example)
06-03 01:35:33.801+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for org.example.example, 9244.
06-03 01:35:33.801+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3397
06-03 01:35:34.661+0900 I/UXT     ( 9467): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-03 01:35:35.642+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-03 01:35:35.642+0900 W/LOCKSCREEN(  845): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-03 01:35:35.642+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-03 01:35:35.642+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-03 01:35:35.642+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-03 01:35:35.642+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-03 01:35:35.652+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:35:35.662+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(195) > ""
06-03 01:35:35.662+0900 E/LOCKSCREEN(  845): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-03 01:35:35.672+0900 E/UXT     (  646): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오전 1:35
06-03 01:35:35.672+0900 I/INDICATOR(  646): clock.c: getTimeFormatted(176) > "time format : 오전 1:35"
06-03 01:35:35.672+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(244) > "time format : 오전 1:35"
06-03 01:35:35.672+0900 W/INDICATOR(  646): clock.c: indicator_clock_changed_cb(272) > 
06-03 01:35:35.672+0900 I/INDICATOR(  646): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146677298 Time: <font_size=31> </font_size> <font_size=31> 오전 1:35</font_size></font>"
06-03 01:35:35.672+0900 I/INDICATOR(  646): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(9) / batt_Full:(0) / battery_charging(1)"
06-03 01:35:35.672+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-03 01:35:35.672+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:35:35.672+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:35:35.672+0900 E/INDICATOR(  646): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-03 01:35:35.672+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:35:35.672+0900 E/INDICATOR(  646): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-03 01:35:35.863+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-03 01:35:35.863+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-03 01:35:35.873+0900 W/APP_CORE(  845): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-03 01:35:35.873+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: RESUME State: PAUSED
06-03 01:35:35.873+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:35:35.873+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-03 01:35:35.873+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-03 01:35:35.873+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:35:35.883+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-03 01:35:35.883+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
06-03 01:35:35.883+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 845
06-03 01:35:35.883+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-03 01:35:35.893+0900 W/AUL_AMD (  610): amd_launch.c: start_process(638) > child process: 9472
06-03 01:35:35.903+0900 E/RESOURCED(  653): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-03 01:35:35.943+0900 W/AUL_AMD (  610): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 9472
06-03 01:35:35.943+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 9472, appid: com.samsung.weather-m-agent
06-03 01:35:35.953+0900 W/AUL     (  845): launch.c: app_request_to_launchpad(425) > request cmd(0) result(9472)
06-03 01:35:36.003+0900 I/Tizen::App( 1210): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-03 01:35:36.003+0900 I/Tizen::App( 1210): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 9472.
06-03 01:35:36.113+0900 E/weather-agent( 9472): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-03 01:35:36.113+0900 E/weather-common( 9472): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-03 01:35:36.113+0900 E/weather-agent( 9472): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-03 01:35:36.113+0900 E/weather-agent( 9472): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.deco-app, PortID : lockscreen-message-port[0;m
06-03 01:35:36.123+0900 E/weather-common( 9472): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-03 01:35:36.123+0900 E/weather-common( 9472): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-03 01:35:36.123+0900 E/weather-common( 9472): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-03 01:35:36.123+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-03 01:35:36.123+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-03 01:35:36.123+0900 I/MESSAGE_PORT( 9472): message-port.c: __initialize(872) > initialize
06-03 01:35:36.133+0900 I/MESSAGE_PORT( 9472): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-03 01:35:36.153+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:35:36.153+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:35:36.153+0900 I/MESSAGE_PORT( 9472): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:35:36.153+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-03 01:35:36.153+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-03 01:35:36.153+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-03 01:35:36.153+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:35:36.163+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-03 01:35:36.163+0900 I/MESSAGE_PORT(  845): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.deco-app:lockscreen-message-port]
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.deco-app : com.samsung.weather-m-agent] 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0 
06-03 01:35:36.163+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:35:36.163+0900 E/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._9cf6d0ea23b9b68c90ac722a6de3391c0
06-03 01:35:36.163+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(631) > [0;40;31mmessage_port_send_message failed [com.samsung.deco-app, lockscreen-message-port][0;m
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-03 01:35:36.163+0900 E/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-03 01:35:36.163+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-03 01:35:36.163+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: __message_port_send_message(972) > port exist check !!
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 1360): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-03 01:35:36.173+0900 E/MESSAGE_PORT( 9472): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-03 01:35:36.173+0900 E/weather-common( 9472): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-03 01:35:36.173+0900 E/weather-agent( 9472): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-03 01:35:36.173+0900 E/weather-agent( 9472): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-03 01:35:36.173+0900 I/MESSAGE_PORT( 9472): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-03 01:35:36.173+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:35:36.193+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:35:36.233+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:35:36.233+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:35:36.233+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:35:36.233+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:35:36.233+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:35:36.233+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:35:36.243+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_update_cb(287) > received updating signal
06-03 01:35:36.243+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=131916247
06-03 01:35:36.283+0900 E/GAME    ( 2577): .\..\src\TizenImpl.c: device_display_changed_cb(80) > device_display_changed_cb: state change to 0
06-03 01:35:36.283+0900 I/Tizen::System( 1210): (280) > The screen has been turned on.
06-03 01:35:36.283+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:35:36.303+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:35:36.313+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-03 01:35:36.313+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:35:36.313+0900 W/LOCKSCREEN(  845): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-03 01:35:36.323+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:35:36.333+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-03 01:35:36.333+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-03 01:35:36.333+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:35:36.333+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:35:36.333+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:35:36.333+0900 E/weather-widget( 1360): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-03 01:35:36.343+0900 E/weather-widget( 1360): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-03 01:35:36.343+0900 E/weather-widget( 1360): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-03 01:35:36.343+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-03 01:35:36.343+0900 I/CAPI_WIDGET_APPLICATION( 1360): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-03 01:35:36.343+0900 W/AUL     ( 1360): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1360, appid: com.samsung.weather-m-widget, status: fg
06-03 01:35:36.363+0900 E/EFL     (  845): ecore_x<845> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=131916365
06-03 01:35:36.363+0900 E/LOCKSCREEN(  845): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-03 01:35:36.363+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-03 01:35:36.363+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:35:36.403+0900 E/cluster-home(  860): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-03 01:35:36.403+0900 W/cluster-view(  860): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-03 01:35:36.693+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-03 01:35:36.693+0900 W/LOCKSCREEN(  845): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-03 01:35:36.693+0900 W/LOCKSCREEN(  845): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-03 01:35:36.703+0900 E/LOCKSCREEN(  845): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-03 01:35:36.703+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:35:36.703+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:35:36.703+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:35:36.703+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:35:36.703+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-03 01:35:36.713+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:35:36.713+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:35:36.713+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(845) status(4)
06-03 01:35:36.713+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(845)
06-03 01:35:36.713+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 845, appid: com.samsung.lockscreen, status: bg
06-03 01:35:36.723+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(9244) status(3)
06-03 01:35:36.723+0900 I/APP_CORE( 9244): appcore-efl.c: __do_app(514) > [APP 9244] Event: RESUME State: CREATED
06-03 01:35:36.723+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:35:36.723+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:35:36.733+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG org.example.example(9244)
06-03 01:35:36.733+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 9244, appid: org.example.example, status: fg
06-03 01:35:36.753+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:35:36.773+0900 I/APP_CORE( 9244): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
06-03 01:35:36.773+0900 I/Tizen::System( 1210): (259) > Active app [org.exampl], current [com.samsun] 
06-03 01:35:36.773+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:35:36.773+0900 W/LOCKSCREEN(  845): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-03 01:35:36.773+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-03 01:35:36.773+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-03 01:35:36.773+0900 I/APP_CORE( 9244): appcore-efl.c: __do_app(625) > [APP 9244] Initial Launching, call the resume_cb
06-03 01:35:36.773+0900 I/CAPI_APPFW_APPLICATION( 9244): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:35:36.783+0900 E/LOCKSCREEN(  845): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-03 01:35:36.783+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: PAUSE State: RUNNING
06-03 01:35:36.783+0900 I/CAPI_APPFW_APPLICATION(  845): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-03 01:35:36.783+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:35:36.783+0900 E/LOCKSCREEN(  845): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-03 01:35:36.783+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-03 01:35:36.783+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-03 01:35:36.783+0900 W/LOCKSCREEN(  845): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-03 01:35:36.783+0900 E/LOCKSCREEN(  845): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-03 01:35:36.783+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:35:36.793+0900 I/APP_CORE(  845): appcore-efl.c: __do_app(514) > [APP 845] Event: MEM_FLUSH State: PAUSED
06-03 01:35:36.884+0900 W/LOCKSCREEN(  845): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-03 01:35:36.884+0900 E/LOCKSCREEN(  845): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-03 01:35:36.884+0900 E/LOCKSCREEN(  845): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-03 01:35:36.884+0900 W/LOCKSCREEN(  845): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-03 01:35:36.884+0900 W/LOCKSCREEN(  845): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-03 01:35:36.884+0900 E/LOCKSCREEN(  845): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-03 01:35:36.954+0900 E/EFL     ( 9244): ecore_x<9244> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=131916905
06-03 01:35:37.104+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 9244 pgid = 9244
06-03 01:35:37.104+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(143) > dead_pid(9244)
06-03 01:35:37.104+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:35:37.144+0900 I/AUL_PAD ( 1359): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-03 01:35:37.144+0900 I/AUL_PAD ( 1359): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-03 01:35:37.144+0900 E/AUL_PAD ( 1359): launchpad.c: main(698) > error reading sigchld info
06-03 01:35:37.144+0900 I/Tizen::App( 1210): (243) > App[org.example.example] pid[9244] terminate event is forwarded
06-03 01:35:37.144+0900 I/Tizen::System( 1210): (256) > osp.accessorymanager.service provider is found.
06-03 01:35:37.144+0900 I/Tizen::System( 1210): (196) > Accessory Owner is removed [org.example.example, 9244, ]
06-03 01:35:37.144+0900 I/Tizen::System( 1210): (256) > osp.system.service provider is found.
06-03 01:35:37.144+0900 I/Tizen::App( 1210): (506) > TerminatedApp(org.example.example)
06-03 01:35:37.144+0900 I/Tizen::App( 1210): (512) > Not registered pid(9244)
06-03 01:35:37.144+0900 I/Tizen::System( 1210): (246) > Terminated app [org.example.example]
06-03 01:35:37.144+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:35:37.144+0900 I/ESD     (  887): esd_main.c: __esd_app_dead_handler(1773) > pid: 9244
06-03 01:35:37.144+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 9244
06-03 01:35:37.144+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 9244
06-03 01:35:37.154+0900 E/RESOURCED(  653): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.3402
06-03 01:35:37.164+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(3)
06-03 01:35:37.164+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-03 01:35:37.164+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-03 01:35:37.164+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(860)
06-03 01:35:37.164+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 860, appid: com.samsung.homescreen, status: fg
06-03 01:35:37.164+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(860) status(0)
06-03 01:35:37.174+0900 E/RESOURCED(  653): datausage-common.c: app_terminated_cb(646) > No classid to terminate!
06-03 01:35:37.174+0900 E/weather-agent( 9472): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-03 01:35:37.174+0900 I/CAPI_APPFW_APPLICATION( 9472): service_app_main.c: service_app_exit(446) > service_app_exit
06-03 01:35:37.184+0900 E/weather-agent( 9472): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-03 01:35:37.184+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
06-03 01:35:37.184+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
06-03 01:35:37.184+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:35:37.184+0900 I/Tizen::App( 1210): (782) > Finished invoking application event listener for org.example.example, 9244.
06-03 01:35:37.224+0900 I/APP_CORE(  860): appcore-efl.c: __do_app(514) > [APP 860] Event: RESUME State: PAUSED
06-03 01:35:37.224+0900 I/CAPI_APPFW_APPLICATION(  860): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-03 01:35:37.224+0900 E/cluster-home(  860): homescreen.cpp: OnResume(233) >  app resume
06-03 01:35:37.224+0900 E/EFL     (  336): eo<336> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-03 01:35:37.224+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
06-03 01:35:37.244+0900 I/Tizen::System( 1210): (259) > Active app [com.samsun], current [org.exampl] 
06-03 01:35:37.244+0900 I/Tizen::Io( 1210): (729) > Entry not found
06-03 01:35:37.264+0900 I/Tizen::System( 1210): (157) > change brightness system value.
06-03 01:35:37.284+0900 W/CRASH_MANAGER( 9480): worker.c: worker_job(1199) > 1109244657861149642133
