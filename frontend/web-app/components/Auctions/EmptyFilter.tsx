'use client'

import { useParamsStore } from '@/hooks/useParamsStore'
import React from 'react'
 const EmptyFilter = () =>{
    const reset = useParamsStore(state => state.reset);

    return (
        <div className='h-[40vh] flex flex-col gap-2 justify-center items-center shadow-lg'>
            <div className='mt-4'>
                <h3>לא נמצאו תוצאות עבור פילטר זה</h3>
                {/* {showReset && (
                    <Button outline onClick={reset}>Remove Filters</Button>
                )}
                {showLogin && (
                    <Button outline onClick={() => signIn('id-server', {callbackUrl})}>Login</Button>
                )} */}
            </div>
        </div>
    )
}
export default EmptyFilter;