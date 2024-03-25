"use client";

import { FC } from "react";
import { Button } from "../ui/button";
import { signIn } from "next-auth/react";

interface LoginButtonProps {}

const LoginButton: FC<LoginButtonProps> = ({}) => {
  return (
    <div>
        כניסה
      {/* <Button onClick={() => signIn('id-server', {callbackUrl: '/'})}>Login</Button> */}
    </div>
  );
};

export default LoginButton;
