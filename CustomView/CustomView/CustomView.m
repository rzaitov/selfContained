//
//  CustomView.m
//  CustomView
//
//  Created by Rustam on 25/08/2015.
//  Copyright © 2015 Rustam. All rights reserved.
//

#import "CustomView.h"

@implementation CustomView

/*
// Only override drawRect: if you perform custom drawing.
// An empty implementation adversely affects performance during animation.
- (void)drawRect:(CGRect)rect {
    // Drawing code
}
*/

- (instancetype)initWithFrame:(CGRect)frame
{
    NSLog(@"initWithFrame called");
    self = [super initWithFrame:frame];
    if (self) {
        NSLog(@"left %@", self.LeftView);
        NSLog(@"right %@", self.RightView);
    }
    return self;
}

- (instancetype)initWithCoder:(NSCoder *)coder
{
    NSLog(@"initWithCoder called");
    self = [super initWithCoder:coder];
    if (self) {
        NSLog(@"left %@", self.LeftView);
        NSLog(@"right %@", self.RightView);
    }

    return self;
}

- (void)awakeFromNib
{
    NSLog(@"awakeFromNib called");
    NSLog(@"left %@", self.LeftView);
    NSLog(@"right %@", self.RightView);
}

@end
