	      ***************************************

	     PBS Materials (Integrity Software and Games)

	      ***************************************

Thank you for downloading this materials package. I have personally made all materials and their associated textures: no textures have been downloaded from external sources. Please read this document thoroughly as it will explain the organization of this package as well as give helpful hints on how to use it properly.

This package is designed to meet almost all of your material needs with Unity's new PBS (Physically Based Shading) rendering system. I plan to add many more materials as time allows, so I have included a number on all materials (even if there is currently only one in its category) for ease of updating (ie. "Brick 1","Dirt 1", etc.). Each category has its own folder that contains all respective materials and a subfolder with all textures pertaining to its materials.

For example:

PBS Materials (ISG)
    Dirt
        -Dirt 1 (material)
        -Dirt 2 (material)
        -Textures
            -Dirt 1 (texture)
            -Dirt 2 (texture)

If two materials use the same texture they will not only have the same number, but also a letter at the end of the name (ie. Metal 1a and Metal 1b share the same "Metal 1" texture(s) but have different settings). Furthermore, if two materials share only some of their textures, the shared textures will be marked without a letter while the textures that are not shared will have a letter that matches its respective material (ie. say Metal 1a and Metal 1b share a normal texture but have different displacement (heightmap) textures: textures will be marked "Metal 1 Normals" (shared), "Metal 1a Displacement" (not shared), and "Metal 1b Displacement" (also not shared)). The exception to this rule is when a detail texture (such as rust on metal) would be used across many different materials. In this case, "Metal Rust" has no number attached, indicating that it is used in many materials.

Most textures are 2048x2048 or 1024x1024 so be sure to adjust max size in the import settings to minimize file size. Because many materials use multiple textures it is often best to adjust the resolution of the main (albedo) texture and then use the same res. on normal, heightmap, occlusion, etc..

Materials have as many textures (albedo, metallic, normal, heightmap, occlusion) as are necessary, but heightmaps in particular can often be removed to improve speed, as they are often expensive (of course normals could also be removed for mobile apps). Also I have adjusted the "tiling" on many materials to normalize the size, so you may need to adjust this to meet your needs. However, be careful to keep both 'X' and 'Y' equal to avoid distortion (unless of course you want distorted textures).

If you would like to adjust material settings to better suit your game (which may just be removing a heightmap), I recommend that you make a copy of the material that must be edited and name it "Xmaterial_1", "Xmaterial_2", and so on. For example, if you need to edit "Stone 1" and you just start to edit, when you update to get new materials your changes will be lost. Rather, make a copy of "Stone 1" and name it "Stone 1_1", meaning first edit of "Stone 1", and updating the package should not mess with your changes. On the other hand, I may, due to feedback from other developers, include new and better materials/textures that will overwrite preexisting ones. If you have not modified a material, the visual quality of your game may improve when you update.

If you have any questions about this asset, or you have a particular material that you would like for us to include, please email us at:

assetsupport@integrity-sg.com