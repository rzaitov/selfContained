//
//  ViewController.swift
//  issue40318
//
//  Created by Rustam on 18/04/2016.
//  Copyright © 2016 Rustam. All rights reserved.
//

import UIKit
import CloudKit

class ViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view, typically from a nib.
        let dc = CKContainer.defaultContainer();
        print(dc);
        
    }

    override func didReceiveMemoryWarning() {
        super.didReceiveMemoryWarning()
        // Dispose of any resources that can be recreated.
    }


}

