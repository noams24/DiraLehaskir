import type { Metadata } from "next";
import "./globals.css";
import Header from "@/components/Header/Header";

export const metadata: Metadata = {
  title: "דירה להשכיר",
  description: "אתר המציג מכרזים של השכרת דירות",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="he" dir="rtl" suppressHydrationWarning={true}>
      <body className="min-h-screen flex flex-col items-stretch m-0">
        <Header />
        <main className="container mx-auto px-5 pt-10">{children}</main>
      </body>
    </html>
  );
}
