//
//  ViewController.m
//  ComponentStore
//
//  Created by Rustam Zaitov on 10/04/15.
//  Copyright (c) 2015 Rustam Zaitov. All rights reserved.
//

#import "ViewController.h"
#import <WebKit/WebKit.h>

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    
    NSURL *url = [NSURL URLWithString:@"http://components.xamarin.com/"];
    NSURLRequest *request = [NSURLRequest requestWithURL:url];
    [[self.WebView mainFrame] loadRequest:request];

    // Do any additional setup after loading the view.
}

- (void)setRepresentedObject:(id)representedObject {
    [super setRepresentedObject:representedObject];

    // Update the view, if already loaded.
}

@end
