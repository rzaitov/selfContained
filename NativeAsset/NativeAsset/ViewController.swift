//
//  ViewController.swift
//  NativeAsset
//
//  Created by Rustam on 16/10/2015.
//  Copyright © 2015 Rustam. All rights reserved.
//

import Cocoa

class ViewController: NSViewController {

    override func viewDidLoad() {
        super.viewDidLoad()

        print("viewDidLoad")
        print(NSImage(named: "Folder"))
        // Do any additional setup after loading the view.
    }

    override var representedObject: AnyObject? {
        didSet {
        // Update the view, if already loaded.
        }
    }


}

