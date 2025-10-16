function Skeleton(props) {
    return (
        <div
            style={{
                width: props.width == "full" ? "100%" : props.width,
                height: props.circle ? props.width : props.height
            }}
            className={`
                ${props.circle ? 'rounded-full' : 'rounded-xl'}
                ${props.dark ? 'bg-gray-400' : 'bg-gray-200'} 
                animate-pulse
            `}>
        </div>
    )
}

export default Skeleton
